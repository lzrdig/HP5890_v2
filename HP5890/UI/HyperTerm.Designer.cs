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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowPortSettings
            // 
            this.buttonShowPortSettings.Location = new System.Drawing.Point(294, 12);
            this.buttonShowPortSettings.Name = "buttonShowPortSettings";
            this.buttonShowPortSettings.Size = new System.Drawing.Size(86, 39);
            this.buttonShowPortSettings.TabIndex = 1;
            this.buttonShowPortSettings.Text = "view port settings";
            this.buttonShowPortSettings.UseVisualStyleBackColor = true;
            this.buttonShowPortSettings.Click += new System.EventHandler(this.buttonShowPortSettings_Click);
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Location = new System.Drawing.Point(12, 106);
            this.textBoxCommands.Multiline = true;
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(368, 61);
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
            this.buttonWriteRead.Location = new System.Drawing.Point(13, 183);
            this.buttonWriteRead.Name = "buttonWriteRead";
            this.buttonWriteRead.Size = new System.Drawing.Size(97, 35);
            this.buttonWriteRead.TabIndex = 4;
            this.buttonWriteRead.Text = "Write Read";
            this.buttonWriteRead.UseVisualStyleBackColor = true;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(146, 183);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(97, 35);
            this.buttonWrite.TabIndex = 5;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(283, 183);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(97, 35);
            this.buttonRead.TabIndex = 6;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            // 
            // comboBoxCommandType
            // 
            this.comboBoxCommandType.FormattingEnabled = true;
            this.comboBoxCommandType.Items.AddRange(new object[] {
            "configuration and setup",
            "status and setpoint",
            "run control",
            "data set-up and control"});
            this.comboBoxCommandType.Location = new System.Drawing.Point(225, 70);
            this.comboBoxCommandType.Name = "comboBoxCommandType";
            this.comboBoxCommandType.Size = new System.Drawing.Size(155, 21);
            this.comboBoxCommandType.TabIndex = 7;
            this.comboBoxCommandType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommandType_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "port closed";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HyperTermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 306);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}