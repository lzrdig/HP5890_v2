namespace HP5890
{
    partial class GCctrl
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
            this.grpDet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetectorAlbl = new System.Windows.Forms.Label();
            this.txtBoxDetBTmprt = new System.Windows.Forms.TextBox();
            this.txtBoxDetATmprt = new System.Windows.Forms.TextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.timer4GCdlg = new System.Windows.Forms.Timer(this.components);
            this.grpDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDet
            // 
            this.grpDet.Controls.Add(this.label1);
            this.grpDet.Controls.Add(this.DetectorAlbl);
            this.grpDet.Controls.Add(this.txtBoxDetBTmprt);
            this.grpDet.Controls.Add(this.txtBoxDetATmprt);
            this.grpDet.Location = new System.Drawing.Point(376, 130);
            this.grpDet.Name = "grpDet";
            this.grpDet.Size = new System.Drawing.Size(200, 234);
            this.grpDet.TabIndex = 0;
            this.grpDet.TabStop = false;
            this.grpDet.Text = "Detectors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detector B Temperature";
            // 
            // DetectorAlbl
            // 
            this.DetectorAlbl.AutoSize = true;
            this.DetectorAlbl.Location = new System.Drawing.Point(23, 20);
            this.DetectorAlbl.Name = "DetectorAlbl";
            this.DetectorAlbl.Size = new System.Drawing.Size(121, 13);
            this.DetectorAlbl.TabIndex = 2;
            this.DetectorAlbl.Text = "Detector A Temperature";
            // 
            // txtBoxDetBTmprt
            // 
            this.txtBoxDetBTmprt.Location = new System.Drawing.Point(23, 82);
            this.txtBoxDetBTmprt.Name = "txtBoxDetBTmprt";
            this.txtBoxDetBTmprt.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetBTmprt.TabIndex = 1;
            // 
            // txtBoxDetATmprt
            // 
            this.txtBoxDetATmprt.Location = new System.Drawing.Point(23, 39);
            this.txtBoxDetATmprt.Name = "txtBoxDetATmprt";
            this.txtBoxDetATmprt.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetATmprt.TabIndex = 0;
            // 
            // StopBtn
            // 
            this.StopBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StopBtn.Location = new System.Drawing.Point(309, 39);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(81, 66);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // RunBtn
            // 
            this.RunBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.Image = global::HP5890.Properties.Resources._112_RightArrowShort_Grey;
            this.RunBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunBtn.Location = new System.Drawing.Point(117, 39);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Padding = new System.Windows.Forms.Padding(10);
            this.RunBtn.Size = new System.Drawing.Size(164, 66);
            this.RunBtn.TabIndex = 1;
            this.RunBtn.Text = "RUN\r\n";
            this.RunBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RunBtn.UseVisualStyleBackColor = true;
            // 
            // GCctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 415);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.grpDet);
            this.HelpButton = true;
            this.Name = "GCctrl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "HP5890 Control";
            this.grpDet.ResumeLayout(false);
            this.grpDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDet;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DetectorAlbl;
        private System.Windows.Forms.TextBox txtBoxDetBTmprt;
        private System.Windows.Forms.TextBox txtBoxDetATmprt;
        private System.Windows.Forms.Timer timer4GCdlg;
    }
}