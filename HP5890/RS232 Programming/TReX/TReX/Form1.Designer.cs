namespace TReX
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.signatureButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.expandedProtocolCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadTimeout = 150;
            // 
            // signatureButton
            // 
            this.signatureButton.Location = new System.Drawing.Point(12, 12);
            this.signatureButton.Name = "signatureButton";
            this.signatureButton.Size = new System.Drawing.Size(100, 23);
            this.signatureButton.TabIndex = 0;
            this.signatureButton.Text = "Get Signature";
            this.signatureButton.UseVisualStyleBackColor = true;
            this.signatureButton.Click += new System.EventHandler(this.signatureButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 54);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(268, 200);
            this.logTextBox.TabIndex = 1;
            // 
            // expandedProtocolCheckBox
            // 
            this.expandedProtocolCheckBox.AutoSize = true;
            this.expandedProtocolCheckBox.Location = new System.Drawing.Point(149, 16);
            this.expandedProtocolCheckBox.Name = "expandedProtocolCheckBox";
            this.expandedProtocolCheckBox.Size = new System.Drawing.Size(116, 17);
            this.expandedProtocolCheckBox.TabIndex = 2;
            this.expandedProtocolCheckBox.Text = "Expanded Protocol";
            this.expandedProtocolCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.expandedProtocolCheckBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.signatureButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button signatureButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.CheckBox expandedProtocolCheckBox;
    }
}

