namespace HP5890
{
    partial class RS232cfgForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// This is to insure that only RS232 from is generated at all times
        ///// </summary>
        //private static RS232cfgForm m_Childform;
        //public static RS232cfgForm GetChildInstance()
        //{
        //    if (m_Childform == null) //if not created yet, Create an instance
        //        m_Childform = new RS232cfgForm();
        //    clsGlobals.g_frmobjRS232Config = m_Childform;
        //    return m_Childform;  //just created or created earlier.Return it
        //}


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
            clsGlobals.g_frmobjRS232Config = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortFindBtn = new System.Windows.Forms.Button();
            this.PortsList = new System.Windows.Forms.ComboBox();
            this.baudRateList = new System.Windows.Forms.ListBox();
            this.PortStateBtn = new System.Windows.Forms.Button();
            this.statusWnd = new System.Windows.Forms.RichTextBox();
            this.stopBitList = new System.Windows.Forms.ComboBox();
            this.parityList = new System.Windows.Forms.ComboBox();
            this.flowCtrlList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitsList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PortStateInd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortFindBtn
            // 
            this.PortFindBtn.Location = new System.Drawing.Point(24, 26);
            this.PortFindBtn.Name = "PortFindBtn";
            this.PortFindBtn.Size = new System.Drawing.Size(75, 23);
            this.PortFindBtn.TabIndex = 0;
            this.PortFindBtn.Text = "Ports";
            this.PortFindBtn.UseVisualStyleBackColor = true;
            this.PortFindBtn.Click += new System.EventHandler(this.PortFindBtn_Click);
            // 
            // PortsList
            // 
            this.PortsList.FormattingEnabled = true;
            this.PortsList.Location = new System.Drawing.Point(147, 27);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(106, 21);
            this.PortsList.TabIndex = 1;
            this.PortsList.Visible = false;
            this.PortsList.SelectedIndexChanged += new System.EventHandler(this.PortsList_SelectedIndexChanged);
            // 
            // baudRateList
            // 
            this.baudRateList.Enabled = false;
            this.baudRateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.ItemHeight = 24;
            this.baudRateList.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateList.Location = new System.Drawing.Point(6, 19);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(106, 28);
            this.baudRateList.TabIndex = 2;
            // 
            // PortStateBtn
            // 
            this.PortStateBtn.Enabled = false;
            this.PortStateBtn.Location = new System.Drawing.Point(24, 60);
            this.PortStateBtn.Name = "PortStateBtn";
            this.PortStateBtn.Size = new System.Drawing.Size(75, 23);
            this.PortStateBtn.TabIndex = 3;
            this.PortStateBtn.Text = "Open";
            this.PortStateBtn.UseVisualStyleBackColor = true;
            this.PortStateBtn.Click += new System.EventHandler(this.PortStateBtn_Click);
            // 
            // statusWnd
            // 
            this.statusWnd.Location = new System.Drawing.Point(24, 266);
            this.statusWnd.Name = "statusWnd";
            this.statusWnd.Size = new System.Drawing.Size(229, 66);
            this.statusWnd.TabIndex = 4;
            this.statusWnd.Text = "";
            // 
            // stopBitList
            // 
            this.stopBitList.Enabled = false;
            this.stopBitList.FormattingEnabled = true;
            this.stopBitList.Items.AddRange(new object[] {
            "0 bits",
            "1 bit"});
            this.stopBitList.Location = new System.Drawing.Point(6, 80);
            this.stopBitList.Name = "stopBitList";
            this.stopBitList.Size = new System.Drawing.Size(106, 21);
            this.stopBitList.TabIndex = 5;
            this.stopBitList.SelectedIndexChanged += new System.EventHandler(this.PortSettingsUpdate);
            // 
            // parityList
            // 
            this.parityList.Enabled = false;
            this.parityList.FormattingEnabled = true;
            this.parityList.Items.AddRange(new object[] {
            "None",
            "Even",
            "Mark",
            "Odd",
            "Space"});
            this.parityList.Location = new System.Drawing.Point(6, 107);
            this.parityList.Name = "parityList";
            this.parityList.Size = new System.Drawing.Size(106, 21);
            this.parityList.TabIndex = 6;
            this.parityList.SelectedIndexChanged += new System.EventHandler(this.PortSettingsUpdate);
            // 
            // flowCtrlList
            // 
            this.flowCtrlList.Enabled = false;
            this.flowCtrlList.FormattingEnabled = true;
            this.flowCtrlList.Items.AddRange(new object[] {
            "None",
            "XonXoff",
            "RequestToSend",
            "RequestToSendXonXoff"});
            this.flowCtrlList.Location = new System.Drawing.Point(6, 134);
            this.flowCtrlList.Name = "flowCtrlList";
            this.flowCtrlList.Size = new System.Drawing.Size(106, 21);
            this.flowCtrlList.TabIndex = 7;
            this.flowCtrlList.SelectedIndexChanged += new System.EventHandler(this.PortSettingsUpdate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataBitsList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudRateList);
            this.groupBox1.Controls.Add(this.flowCtrlList);
            this.groupBox1.Controls.Add(this.stopBitList);
            this.groupBox1.Controls.Add(this.parityList);
            this.groupBox1.Location = new System.Drawing.Point(24, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Bits";
            // 
            // dataBitsList
            // 
            this.dataBitsList.Enabled = false;
            this.dataBitsList.FormattingEnabled = true;
            this.dataBitsList.Items.AddRange(new object[] {
            "5 bits",
            "6 bits",
            "7 bits",
            "8 bits"});
            this.dataBitsList.Location = new System.Drawing.Point(6, 53);
            this.dataBitsList.Name = "dataBitsList";
            this.dataBitsList.Size = new System.Drawing.Size(106, 21);
            this.dataBitsList.TabIndex = 12;
            this.dataBitsList.SelectedIndexChanged += new System.EventHandler(this.PortSettingsUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Flow Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stop Bits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Baud Rate";
            // 
            // PortStateInd
            // 
            this.PortStateInd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PortStateInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortStateInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortStateInd.ForeColor = System.Drawing.Color.Lime;
            this.PortStateInd.Location = new System.Drawing.Point(147, 61);
            this.PortStateInd.Name = "PortStateInd";
            this.PortStateInd.Size = new System.Drawing.Size(106, 22);
            this.PortStateInd.TabIndex = 9;
            this.PortStateInd.Text = "Port Closed";
            this.PortStateInd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PortStateInd.Visible = false;
            // 
            // RS232cfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 349);
            this.Controls.Add(this.PortStateInd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusWnd);
            this.Controls.Add(this.PortStateBtn);
            this.Controls.Add(this.PortsList);
            this.Controls.Add(this.PortFindBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RS232cfgForm";
            this.Text = "RS232cgf";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PortFindBtn;
        private System.Windows.Forms.ComboBox PortsList;
        private System.Windows.Forms.ListBox baudRateList;
        private System.Windows.Forms.Button PortStateBtn;
        private System.Windows.Forms.RichTextBox statusWnd;
        private System.Windows.Forms.ComboBox stopBitList;
        private System.Windows.Forms.ComboBox parityList;
        private System.Windows.Forms.ComboBox flowCtrlList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitsList;
        private System.Windows.Forms.Label PortStateInd;
    }
}