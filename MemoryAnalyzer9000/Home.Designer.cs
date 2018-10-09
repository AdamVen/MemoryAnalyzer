namespace MemoryAnalyzer9000
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addFilesButton = new System.Windows.Forms.Button();
            this.memoryMapListTextbox = new System.Windows.Forms.CheckedListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.logsLabel = new System.Windows.Forms.Label();
            this.logAnalysisLabel = new System.Windows.Forms.Label();
            this.clearAnalysisButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.clearFilesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeOutputButton = new System.Windows.Forms.Button();
            this.outputSaveLocationTextbox = new System.Windows.Forms.TextBox();
            this.outputSaveLocationLabel = new System.Windows.Forms.Label();
            this.openExcelSheetCheckBox = new System.Windows.Forms.CheckBox();
            this.maxCommittedMemoryNUD = new System.Windows.Forms.NumericUpDown();
            this.maxTotalVirtualMemoryNUD = new System.Windows.Forms.NumericUpDown();
            this.maxUnusableMemoryNUD = new System.Windows.Forms.NumericUpDown();
            this.maxWorkingSetMemoryNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MBLabel = new System.Windows.Forms.Label();
            this.maxTotalVirtualLabel = new System.Windows.Forms.Label();
            this.maxUnusableLabel = new System.Windows.Forms.Label();
            this.maxCommittedLabel = new System.Windows.Forms.Label();
            this.maxWorkingSetLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.templateLocationTextbox = new System.Windows.Forms.TextBox();
            this.selectTemplateButton = new System.Windows.Forms.Button();
            this.templateLocationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCommittedMemoryNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTotalVirtualMemoryNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUnusableMemoryNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorkingSetMemoryNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // addFilesButton
            // 
            this.addFilesButton.Location = new System.Drawing.Point(5, 185);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(75, 23);
            this.addFilesButton.TabIndex = 1;
            this.addFilesButton.Text = "Add Files";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.selectFiles_Click);
            // 
            // memoryMapListTextbox
            // 
            this.memoryMapListTextbox.FormattingEnabled = true;
            this.memoryMapListTextbox.Location = new System.Drawing.Point(4, 25);
            this.memoryMapListTextbox.Name = "memoryMapListTextbox";
            this.memoryMapListTextbox.Size = new System.Drawing.Size(613, 154);
            this.memoryMapListTextbox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 163);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startAnalysis_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(6, 22);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(613, 135);
            this.logTextbox.TabIndex = 7;
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.Location = new System.Drawing.Point(4, 6);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(30, 13);
            this.logsLabel.TabIndex = 8;
            this.logsLabel.Text = "Logs";
            // 
            // logAnalysisLabel
            // 
            this.logAnalysisLabel.AutoSize = true;
            this.logAnalysisLabel.Location = new System.Drawing.Point(3, 9);
            this.logAnalysisLabel.Name = "logAnalysisLabel";
            this.logAnalysisLabel.Size = new System.Drawing.Size(129, 13);
            this.logAnalysisLabel.TabIndex = 9;
            this.logAnalysisLabel.Text = "Memory Maps To Analyze";
            // 
            // clearAnalysisButton
            // 
            this.clearAnalysisButton.Location = new System.Drawing.Point(545, 166);
            this.clearAnalysisButton.Name = "clearAnalysisButton";
            this.clearAnalysisButton.Size = new System.Drawing.Size(75, 23);
            this.clearAnalysisButton.TabIndex = 10;
            this.clearAnalysisButton.Text = "Clear";
            this.clearAnalysisButton.UseVisualStyleBackColor = true;
            this.clearAnalysisButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.logsLabel);
            this.panel1.Controls.Add(this.clearAnalysisButton);
            this.panel1.Controls.Add(this.logTextbox);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(7, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 194);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(87, 163);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // clearFilesButton
            // 
            this.clearFilesButton.Location = new System.Drawing.Point(543, 185);
            this.clearFilesButton.Name = "clearFilesButton";
            this.clearFilesButton.Size = new System.Drawing.Size(75, 23);
            this.clearFilesButton.TabIndex = 12;
            this.clearFilesButton.Text = "Clear Files";
            this.clearFilesButton.UseVisualStyleBackColor = true;
            this.clearFilesButton.Click += new System.EventHandler(this.clearFilesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logAnalysisLabel);
            this.panel2.Controls.Add(this.clearFilesButton);
            this.panel2.Controls.Add(this.memoryMapListTextbox);
            this.panel2.Controls.Add(this.addFilesButton);
            this.panel2.Location = new System.Drawing.Point(7, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 218);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.changeOutputButton);
            this.panel3.Controls.Add(this.outputSaveLocationTextbox);
            this.panel3.Controls.Add(this.outputSaveLocationLabel);
            this.panel3.Controls.Add(this.openExcelSheetCheckBox);
            this.panel3.Controls.Add(this.maxCommittedMemoryNUD);
            this.panel3.Controls.Add(this.maxTotalVirtualMemoryNUD);
            this.panel3.Controls.Add(this.maxUnusableMemoryNUD);
            this.panel3.Controls.Add(this.maxWorkingSetMemoryNUD);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MBLabel);
            this.panel3.Controls.Add(this.maxTotalVirtualLabel);
            this.panel3.Controls.Add(this.maxUnusableLabel);
            this.panel3.Controls.Add(this.maxCommittedLabel);
            this.panel3.Controls.Add(this.maxWorkingSetLabel);
            this.panel3.Controls.Add(this.settingsLabel);
            this.panel3.Controls.Add(this.templateLocationTextbox);
            this.panel3.Controls.Add(this.selectTemplateButton);
            this.panel3.Controls.Add(this.templateLocationLabel);
            this.panel3.Location = new System.Drawing.Point(7, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 194);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // changeOutputButton
            // 
            this.changeOutputButton.Location = new System.Drawing.Point(506, 59);
            this.changeOutputButton.Name = "changeOutputButton";
            this.changeOutputButton.Size = new System.Drawing.Size(111, 23);
            this.changeOutputButton.TabIndex = 34;
            this.changeOutputButton.Text = "Change Output";
            this.changeOutputButton.UseVisualStyleBackColor = true;
            this.changeOutputButton.Click += new System.EventHandler(this.changeOutputButton_Click);
            // 
            // outputSaveLocationTextbox
            // 
            this.outputSaveLocationTextbox.Location = new System.Drawing.Point(139, 59);
            this.outputSaveLocationTextbox.Name = "outputSaveLocationTextbox";
            this.outputSaveLocationTextbox.Size = new System.Drawing.Size(364, 20);
            this.outputSaveLocationTextbox.TabIndex = 33;
            this.outputSaveLocationTextbox.Text = "G:\\Norsat Users\\AVengroff\\MemoryAnalyzer9000\\Output.xlsx";
            // 
            // outputSaveLocationLabel
            // 
            this.outputSaveLocationLabel.AutoSize = true;
            this.outputSaveLocationLabel.Location = new System.Drawing.Point(4, 62);
            this.outputSaveLocationLabel.Name = "outputSaveLocationLabel";
            this.outputSaveLocationLabel.Size = new System.Drawing.Size(111, 13);
            this.outputSaveLocationLabel.TabIndex = 32;
            this.outputSaveLocationLabel.Text = "Output Save Location";
            // 
            // openExcelSheetCheckBox
            // 
            this.openExcelSheetCheckBox.AutoSize = true;
            this.openExcelSheetCheckBox.Checked = true;
            this.openExcelSheetCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openExcelSheetCheckBox.Location = new System.Drawing.Point(7, 155);
            this.openExcelSheetCheckBox.Name = "openExcelSheetCheckBox";
            this.openExcelSheetCheckBox.Size = new System.Drawing.Size(191, 17);
            this.openExcelSheetCheckBox.TabIndex = 31;
            this.openExcelSheetCheckBox.Text = "Open Excel Sheet When Complete";
            this.openExcelSheetCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxCommittedMemoryNUD
            // 
            this.maxCommittedMemoryNUD.Location = new System.Drawing.Point(348, 117);
            this.maxCommittedMemoryNUD.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.maxCommittedMemoryNUD.Name = "maxCommittedMemoryNUD";
            this.maxCommittedMemoryNUD.Size = new System.Drawing.Size(49, 20);
            this.maxCommittedMemoryNUD.TabIndex = 30;
            this.maxCommittedMemoryNUD.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // maxTotalVirtualMemoryNUD
            // 
            this.maxTotalVirtualMemoryNUD.Location = new System.Drawing.Point(348, 91);
            this.maxTotalVirtualMemoryNUD.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.maxTotalVirtualMemoryNUD.Name = "maxTotalVirtualMemoryNUD";
            this.maxTotalVirtualMemoryNUD.Size = new System.Drawing.Size(49, 20);
            this.maxTotalVirtualMemoryNUD.TabIndex = 29;
            this.maxTotalVirtualMemoryNUD.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // maxUnusableMemoryNUD
            // 
            this.maxUnusableMemoryNUD.Location = new System.Drawing.Point(139, 117);
            this.maxUnusableMemoryNUD.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.maxUnusableMemoryNUD.Name = "maxUnusableMemoryNUD";
            this.maxUnusableMemoryNUD.Size = new System.Drawing.Size(49, 20);
            this.maxUnusableMemoryNUD.TabIndex = 28;
            this.maxUnusableMemoryNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // maxWorkingSetMemoryNUD
            // 
            this.maxWorkingSetMemoryNUD.Location = new System.Drawing.Point(139, 91);
            this.maxWorkingSetMemoryNUD.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.maxWorkingSetMemoryNUD.Name = "maxWorkingSetMemoryNUD";
            this.maxWorkingSetMemoryNUD.Size = new System.Drawing.Size(49, 20);
            this.maxWorkingSetMemoryNUD.TabIndex = 27;
            this.maxWorkingSetMemoryNUD.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "MB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "MB";
            // 
            // MBLabel
            // 
            this.MBLabel.AutoSize = true;
            this.MBLabel.Location = new System.Drawing.Point(403, 119);
            this.MBLabel.Name = "MBLabel";
            this.MBLabel.Size = new System.Drawing.Size(23, 13);
            this.MBLabel.TabIndex = 23;
            this.MBLabel.Text = "MB";
            // 
            // maxTotalVirtualLabel
            // 
            this.maxTotalVirtualLabel.AutoSize = true;
            this.maxTotalVirtualLabel.Location = new System.Drawing.Point(223, 93);
            this.maxTotalVirtualLabel.Name = "maxTotalVirtualLabel";
            this.maxTotalVirtualLabel.Size = new System.Drawing.Size(126, 13);
            this.maxTotalVirtualLabel.TabIndex = 18;
            this.maxTotalVirtualLabel.Text = "Max Total Virtual Memory";
            // 
            // maxUnusableLabel
            // 
            this.maxUnusableLabel.AutoSize = true;
            this.maxUnusableLabel.Location = new System.Drawing.Point(4, 124);
            this.maxUnusableLabel.Name = "maxUnusableLabel";
            this.maxUnusableLabel.Size = new System.Drawing.Size(115, 13);
            this.maxUnusableLabel.TabIndex = 17;
            this.maxUnusableLabel.Text = "Max Unusable Memory";
            // 
            // maxCommittedLabel
            // 
            this.maxCommittedLabel.AutoSize = true;
            this.maxCommittedLabel.Location = new System.Drawing.Point(223, 119);
            this.maxCommittedLabel.Name = "maxCommittedLabel";
            this.maxCommittedLabel.Size = new System.Drawing.Size(119, 13);
            this.maxCommittedLabel.TabIndex = 16;
            this.maxCommittedLabel.Text = "Max Committed Memory";
            // 
            // maxWorkingSetLabel
            // 
            this.maxWorkingSetLabel.AutoSize = true;
            this.maxWorkingSetLabel.Location = new System.Drawing.Point(4, 93);
            this.maxWorkingSetLabel.Name = "maxWorkingSetLabel";
            this.maxWorkingSetLabel.Size = new System.Drawing.Size(129, 13);
            this.maxWorkingSetLabel.TabIndex = 15;
            this.maxWorkingSetLabel.Text = "Max Working Set Memory";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(3, 9);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(45, 13);
            this.settingsLabel.TabIndex = 13;
            this.settingsLabel.Text = "Settings";
            // 
            // templateLocationTextbox
            // 
            this.templateLocationTextbox.Location = new System.Drawing.Point(139, 28);
            this.templateLocationTextbox.Name = "templateLocationTextbox";
            this.templateLocationTextbox.Size = new System.Drawing.Size(364, 20);
            this.templateLocationTextbox.TabIndex = 14;
            this.templateLocationTextbox.Text = "G:\\Norsat Users\\AVengroff\\MemoryAnalyzer9000\\Template.xlsx";
            // 
            // selectTemplateButton
            // 
            this.selectTemplateButton.Location = new System.Drawing.Point(506, 26);
            this.selectTemplateButton.Name = "selectTemplateButton";
            this.selectTemplateButton.Size = new System.Drawing.Size(111, 23);
            this.selectTemplateButton.TabIndex = 13;
            this.selectTemplateButton.Text = "Select Template";
            this.selectTemplateButton.UseVisualStyleBackColor = true;
            this.selectTemplateButton.Click += new System.EventHandler(this.selectTemplateButton_Click);
            // 
            // templateLocationLabel
            // 
            this.templateLocationLabel.AutoSize = true;
            this.templateLocationLabel.Location = new System.Drawing.Point(4, 31);
            this.templateLocationLabel.Name = "templateLocationLabel";
            this.templateLocationLabel.Size = new System.Drawing.Size(95, 13);
            this.templateLocationLabel.TabIndex = 11;
            this.templateLocationLabel.Text = "Template Location";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 649);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "MemoryAnalyzer9000";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCommittedMemoryNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTotalVirtualMemoryNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUnusableMemoryNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorkingSetMemoryNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.CheckedListBox memoryMapListTextbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.Label logsLabel;
        private System.Windows.Forms.Label logAnalysisLabel;
        private System.Windows.Forms.Button clearAnalysisButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearFilesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox templateLocationTextbox;
        private System.Windows.Forms.Button selectTemplateButton;
        private System.Windows.Forms.Label templateLocationLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label maxTotalVirtualLabel;
        private System.Windows.Forms.Label maxUnusableLabel;
        private System.Windows.Forms.Label maxCommittedLabel;
        private System.Windows.Forms.Label maxWorkingSetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.NumericUpDown maxCommittedMemoryNUD;
        private System.Windows.Forms.NumericUpDown maxTotalVirtualMemoryNUD;
        private System.Windows.Forms.NumericUpDown maxUnusableMemoryNUD;
        private System.Windows.Forms.NumericUpDown maxWorkingSetMemoryNUD;
        private System.Windows.Forms.CheckBox openExcelSheetCheckBox;
        private System.Windows.Forms.Button changeOutputButton;
        private System.Windows.Forms.TextBox outputSaveLocationTextbox;
        private System.Windows.Forms.Label outputSaveLocationLabel;
        private System.Windows.Forms.Button stopButton;
    }
}

