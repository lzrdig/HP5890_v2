namespace HP5890
{
    partial class HyperTermForm
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
            this.buttonShowPortSettings = new System.Windows.Forms.Button();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.textBoxResponses = new System.Windows.Forms.TextBox();
            this.buttonWriteRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.comboBoxCommandType = new System.Windows.Forms.ComboBox();
            this.PortStateInd = new System.Windows.Forms.Button();
            this.simulBtnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowPortSettings
            // 
            this.buttonShowPortSettings.Location = new System.Drawing.Point(294, 36);
            this.buttonShowPortSettings.Name = "buttonShowPortSettings";
            this.buttonShowPortSettings.Size = new System.Drawing.Size(86, 39);
            this.buttonShowPortSettings.TabIndex = 1;
            this.buttonShowPortSettings.Text = "view port settings";
            this.buttonShowPortSettings.UseVisualStyleBackColor = true;
            this.buttonShowPortSettings.Click += new System.EventHandler(this.buttonShowPortSettings_Click);
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Location = new System.Drawing.Point(12, 133);
            this.textBoxCommands.Multiline = true;
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(368, 46);
            this.textBoxCommands.TabIndex = 2;
            // 
            // textBoxResponses
            // 
            this.textBoxResponses.Location = new System.Drawing.Point(12, 233);
            this.textBoxResponses.Multiline = true;
            this.textBoxResponses.Name = "textBoxResponses";
            this.textBoxResponses.Size = new System.Drawing.Size(368, 61);
            this.textBoxResponses.TabIndex = 3;
            // 
            // buttonWriteRead
            // 
            this.buttonWriteRead.Location = new System.Drawing.Point(13, 189);
            this.buttonWriteRead.Name = "buttonWriteRead";
            this.buttonWriteRead.Size = new System.Drawing.Size(97, 35);
            this.buttonWriteRead.TabIndex = 4;
            this.buttonWriteRead.Text = "Write Read";
            this.buttonWriteRead.UseVisualStyleBackColor = true;
            this.buttonWriteRead.Click += new System.EventHandler(this.writeANDreadPort_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(146, 189);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(97, 35);
            this.buttonWrite.TabIndex = 5;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.writePort_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(283, 189);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(97, 35);
            this.buttonRead.TabIndex = 6;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.readPort_Click);
            // 
            // comboBoxCommandType
            // 
            this.comboBoxCommandType.FormattingEnabled = true;
            this.comboBoxCommandType.Items.AddRange(new object[] {
            "configuration and setup",
            "status and setpoint",
            "run control",
            "data set-up and control"});
            this.comboBoxCommandType.Location = new System.Drawing.Point(225, 86);
            this.comboBoxCommandType.Name = "comboBoxCommandType";
            this.comboBoxCommandType.Size = new System.Drawing.Size(155, 21);
            this.comboBoxCommandType.TabIndex = 7;
            this.comboBoxCommandType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommandType_SelectedIndexChanged);
            // 
            // PortStateInd
            // 
            this.PortStateInd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PortStateInd.Location = new System.Drawing.Point(12, 37);
            this.PortStateInd.Name = "PortStateInd";
            this.PortStateInd.Size = new System.Drawing.Size(157, 38);
            this.PortStateInd.TabIndex = 8;
            this.PortStateInd.Text = "port closed";
            this.PortStateInd.UseVisualStyleBackColor = false;
            // 
            // simulBtnStatus
            // 
            this.simulBtnStatus.Location = new System.Drawing.Point(13, 6);
            this.simulBtnStatus.Name = "simulBtnStatus";
            this.simulBtnStatus.Size = new System.Drawing.Size(367, 23);
            this.simulBtnStatus.TabIndex = 9;
            this.simulBtnStatus.Text = "port simulation enabled";
            this.simulBtnStatus.UseVisualStyleBackColor = true;
            this.simulBtnStatus.Click += new System.EventHandler(this.portSimulationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Command to Send";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(13, 78);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(97, 29);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "Run Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.RunTestBtn_Click);
            // 
            // HyperTermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 306);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simulBtnStatus);
            this.Controls.Add(this.PortStateInd);
            this.Controls.Add(this.comboBoxCommandType);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonWriteRead);
            this.Controls.Add(this.textBoxResponses);
            this.Controls.Add(this.textBoxCommands);
            this.Controls.Add(this.buttonShowPortSettings);
            this.Name = "HyperTermForm";
            this.Text = "HyperTerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonShowPortSettings;
        private System.Windows.Forms.TextBox textBoxCommands;
        private System.Windows.Forms.TextBox textBoxResponses;
        private System.Windows.Forms.Button buttonWriteRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ComboBox comboBoxCommandType;
        private System.Windows.Forms.Button PortStateInd;
        private System.Windows.Forms.Button simulBtnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTest;
    }
}