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
            this.grpDet = new System.Windows.Forms.GroupBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpDet
            // 
            this.grpDet.Location = new System.Drawing.Point(376, 130);
            this.grpDet.Name = "grpDet";
            this.grpDet.Size = new System.Drawing.Size(200, 234);
            this.grpDet.TabIndex = 0;
            this.grpDet.TabStop = false;
            this.grpDet.Text = "Detectors";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDet;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button StopBtn;
    }
}