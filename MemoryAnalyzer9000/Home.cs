using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace MemoryAnalyzer9000
{
    public partial class Home : Form
    {
        public string workbookPath = @"G:\Norsat Users\AVengroff\MemoryAnalyzer9000\Template.xlsx";
        public string saveLocation = @"G:\Norsat Users\AVengroff\MemoryAnalyzer9000\DefaultOutput" + DateTime.Now.ToString("MM/dd/yyyy h_mm tt");
        public bool fStop = false;
        private BackgroundWorker _worker = null; // need to use background thread or something otherwise UI gets blocked

        public Home()
        {
            InitializeComponent();
        }

        // Populate list memory map files
        private void selectFiles_Click(object sender, EventArgs e)
        { 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Memory Map Files|*.mmp";
            openFileDialog1.Title = "Select Memory Maps";
            openFileDialog1.Multiselect = true;
 
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    if (!memoryMapListTextbox.Items.Contains(file))
                    {
                        memoryMapListTextbox.Items.Add(file, true);
                    }
                }
            } 
        }

        // Analyze memory map files in one big function
        private void startAnalysis_Click(object sender, EventArgs e)
        {

            logTextbox.AppendText("Starting to analyze...");
            logTextbox.AppendText(Environment.NewLine);
            logTextbox.AppendText(Environment.NewLine);


            // Ensure we have memory map files to check
            if (!memoryMapListTextbox.CheckedItems.OfType<string>().Any())
            {
                logTextbox.AppendText("No logs to analyze, this should be fast");
                logTextbox.AppendText(Environment.NewLine);
                logTextbox.AppendText("Analysis complete");
                logTextbox.AppendText(Environment.NewLine);
                return;
            }


            // Ensure we were supplied a valid excel worksheet
            Excel.Application exApp = new Excel.Application();
            exApp.DisplayAlerts = false;
            Excel.Workbook exWbk = null;
            try
            {
                exWbk = exApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            }
            catch (Exception e1)
            {
                logTextbox.AppendText("Could not open template worksheet");
                logTextbox.AppendText(e1.ToString());
                logTextbox.AppendText(Environment.NewLine);
                exApp.Quit();
                return;
            }
            Excel.Worksheet exWks = (Excel.Worksheet)exWbk.Sheets["Sheet1"];

            // Write max values to template
            exWks.Cells[3, 12] = maxCommittedMemoryNUD.Value;
            exWks.Cells[4, 12] = maxWorkingSetMemoryNUD.Value;
            exWks.Cells[5, 12] = maxUnusableMemoryNUD.Value;
            exWks.Cells[6, 12] = maxTotalVirtualMemoryNUD.Value;

            int lineCount = 0; // Track where we are in the excel sheet
            const int ROWOFFSET = 3; // First row where we write
            double initialTimeStamp = 0; // First timestamp provided by the memory maps

            // Go through each memory map file and populate excel sheet
            foreach (String currentMemoryMapFile in memoryMapListTextbox.CheckedItems.OfType<string>().ToList())
            {
                if (fStop == true)
                {
                    logTextbox.AppendText(Environment.NewLine);
                    logTextbox.AppendText("Stopping program...");
                    logTextbox.AppendText(Environment.NewLine);
                    fStop = false;
                    break;
                }

                StreamReader reader = File.OpenText(currentMemoryMapFile);
                string currentLine;
                double totalCommittedMemory = 0;
                double totalWorkingSetMemory = 0;
                double totalUnusableMemory = 0;
                double totalVirtualMemory = 0;
                double totalPagesize = 0;
                double currentTimeStamp = 0;

                logTextbox.AppendText("Analyzing file " + (lineCount + 1) + " of " + memoryMapListTextbox.CheckedItems.OfType<string>().ToList().Count());
                logTextbox.AppendText(Environment.NewLine);

                // Go through each line in the memory map file and grab what we need
                while ((currentLine = reader.ReadLine()) != null)
                {
                    string[] logString = currentLine.Split(' ');

                    // If the line contains memory information it starts with "<Region", if it's the line for PageTableSize/timestamp it contains "<Snapshot"
                    if (("<Region" != logString[0]) && ("<Snapshot" != logString[0]))
                    {
                        continue;
                    }

                    if (logString[2].Contains("PageTableSize"))
                    {
                        totalPagesize += Int32.Parse(Regex.Match(logString[2], @"\d+").Value);

                        // Start time stamps at 0 instead of something like 3661511.9834
                        if (0 == initialTimeStamp)
                        {
                            initialTimeStamp = Int64.Parse(Regex.Match(logString[1], @"\d+").Value);
                            currentTimeStamp = 0;
                        }
                        else
                        {
                            const Int64 HOURTOTIMESTAMP = 10 * 3600000000L; // 10 * 1 hour in microseconds. Not sure why multiplied by 10. Apparently too cool for Unix time
                            currentTimeStamp = (Int64.Parse(Regex.Match(logString[1], @"\d+").Value) - initialTimeStamp) / (HOURTOTIMESTAMP);
                            
                            if (0 > currentTimeStamp)
                            {
                                logTextbox.AppendText(Environment.NewLine);
                                logTextbox.AppendText("Timestamp issue. Is it possible logs are out of order and/or extra logs have been included?");
                                logTextbox.AppendText(Environment.NewLine);
                            }
                        }

                        continue;
                    }

                    // Grab type of memory
                    string splitWord = "Type=";
                    string splitResult = currentLine.Substring(currentLine.IndexOf(splitWord, System.StringComparison.Ordinal) + splitWord.Length);
                    string[] parsedString = splitResult.Split('"');
                    string type = parsedString[3];

                    // Grab memory values
                    double committedMemory = Int32.Parse(Regex.Match(logString[6], @"\d+").Value);
                    double workingSetMemory = Int32.Parse(Regex.Match(logString[3], @"\d+").Value) + Int32.Parse(Regex.Match(logString[8], @"\d+").Value);
                    double size = Int32.Parse(Regex.Match(logString[5], @"\d+").Value);

                    switch (type)
                    {
                        case ("Shareable"):
                        case ("Mapped File"):
                        case ("Heap (Shareable)"):
                        case ("Heap (Private Data)"):
                        case ("Managed Heap"):
                        case ("Thread Stack"):
                        case ("Private Data"):
                        case ("Image"):
                        case ("Image (ASLR)"):
                            if (!logString[2].Contains("0")) // Blocks=0 only counts for unusable memory
                            {
                                totalCommittedMemory += committedMemory;
                                totalWorkingSetMemory += workingSetMemory;
                                totalVirtualMemory += size;
                            }
                            break;

                        case ("Unusable"):
                            totalUnusableMemory += size;
                            totalVirtualMemory += size;
                            break;

                        case ("Free"):
                            break;

                        default:
                            logTextbox.AppendText("Unexpected type: " + currentLine);
                            break;
                    }
                    
                }

                // Add page size to memory usage and convert. Totals seem to be off by <5e-5%, not sure why
                const int BYTES_TO_K = 1000;
                totalCommittedMemory += totalPagesize;
                totalWorkingSetMemory += totalPagesize;
                totalVirtualMemory += totalPagesize;
                totalCommittedMemory /= BYTES_TO_K;
                totalWorkingSetMemory /= BYTES_TO_K;
                totalUnusableMemory /= BYTES_TO_K;
                totalVirtualMemory /= BYTES_TO_K;

                // Write to data to excel sheet
                exWks.Cells[lineCount + ROWOFFSET, 2] = currentTimeStamp;
                exWks.Cells[lineCount + ROWOFFSET, 3] = totalCommittedMemory;
                exWks.Cells[lineCount + ROWOFFSET, 4] = totalWorkingSetMemory;
                exWks.Cells[lineCount + ROWOFFSET, 5] = totalUnusableMemory;
                exWks.Cells[lineCount + ROWOFFSET, 6] = totalVirtualMemory;
                lineCount++;

            }


            // Save excel workbook
            logTextbox.AppendText(Environment.NewLine);
            logTextbox.AppendText("Analysis complete saving results to:");
            logTextbox.AppendText(Environment.NewLine);
            logTextbox.AppendText(saveLocation + ".xlsx");
            logTextbox.AppendText(Environment.NewLine);
            logTextbox.AppendText(Environment.NewLine);

            try
            {
                exWbk.SaveAs(saveLocation, Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                    Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                    Excel.XlSaveConflictResolution.xlUserResolution, true,
                    Missing.Value, Missing.Value, Missing.Value);
            }
            catch (Exception e1)
            {
                logTextbox.AppendText("Could not save file " + e1.ToString());
                logTextbox.AppendText(Environment.NewLine);
            }
            finally
            {
                exWbk.Close(Missing.Value, Missing.Value, Missing.Value);
                exApp.Quit();
            }

            // We are done if we don't want to open newly made worksheet
            if (!openExcelSheetCheckBox.Checked)
            {
                return;
            }
            logTextbox.AppendText(Environment.NewLine);
            logTextbox.AppendText("Opening excel sheet");
            logTextbox.AppendText(Environment.NewLine);
            exApp = new Excel.Application();

            try
            {
                exWbk = exApp.Workbooks.Open(saveLocation + ".xlsx", 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            }
            catch (Exception e1)
            {
                logTextbox.AppendText("Could not open new worksheet");
                logTextbox.AppendText(e1.ToString());
                logTextbox.AppendText(Environment.NewLine);
                exApp.Quit();
                return;
            }
            exApp.Visible = true;
        }


        

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logTextbox.Clear();
        }

        private void clearFilesButton_Click(object sender, EventArgs e)
        {
            memoryMapListTextbox.Items.Clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectTemplateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Template File|*.xlsx";
            openFileDialog1.Title = "Select template";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                templateLocationTextbox.Text = openFileDialog1.FileName;
                workbookPath = templateLocationTextbox.Text;
                saveLocation = System.IO.Path.GetDirectoryName(workbookPath) + "\\Results " + DateTime.Now.ToString("MM/dd/yyyy h_mm tt") + ".xlsx";
                outputSaveLocationTextbox.Text = saveLocation + ".xlsx";
            }
        }

        private void changeOutputButton_Click(object sender, EventArgs e)
        {
            saveLocation = outputSaveLocationTextbox.Text;

            logTextbox.AppendText(Environment.NewLine);
            logTextbox.AppendText("Output location set to: " + outputSaveLocationTextbox.Text);
            logTextbox.AppendText(Environment.NewLine);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            fStop = true;
            logTextbox.AppendText("This button is a lie");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            outputSaveLocationTextbox.Text = saveLocation + ".xlsx";
        }

        

    }
}
