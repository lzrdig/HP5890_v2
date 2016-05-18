namespace HP5890
{
    partial class MainWnd
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
            this.mainWndMenu = new System.Windows.Forms.MenuStrip();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rS232PortConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hyperTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWndMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWndMenu
            // 
            this.mainWndMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationToolStripMenuItem,
            this.methodToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainWndMenu.Location = new System.Drawing.Point(0, 0);
            this.mainWndMenu.Name = "mainWndMenu";
            this.mainWndMenu.Size = new System.Drawing.Size(718, 24);
            this.mainWndMenu.TabIndex = 1;
            this.mainWndMenu.Text = "MainWndMenu";
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeOnStartToolStripMenuItem,
            this.initializeToolStripMenuItem,
            this.rS232PortConfigurationToolStripMenuItem,
            this.hyperTerminalToolStripMenuItem});
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.communicationToolStripMenuItem.Text = "Communication";
            // 
            // initializeOnStartToolStripMenuItem
            // 
            this.initializeOnStartToolStripMenuItem.Name = "initializeOnStartToolStripMenuItem";
            this.initializeOnStartToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.initializeOnStartToolStripMenuItem.Text = "Initialize on Start";
            // 
            // initializeToolStripMenuItem
            // 
            this.initializeToolStripMenuItem.Name = "initializeToolStripMenuItem";
            this.initializeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.initializeToolStripMenuItem.Text = "Initialize";
            // 
            // rS232PortConfigurationToolStripMenuItem
            // 
            this.rS232PortConfigurationToolStripMenuItem.Name = "rS232PortConfigurationToolStripMenuItem";
            this.rS232PortConfigurationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.rS232PortConfigurationToolStripMenuItem.Text = "RS232 Port Configuration";
            this.rS232PortConfigurationToolStripMenuItem.Click += new System.EventHandler(this.rS232PortConfigurationToolStripMenuItem_Click);
            // 
            // methodToolStripMenuItem
            // 
            this.methodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.methodToolStripMenuItem.Name = "methodToolStripMenuItem";
            this.methodToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.methodToolStripMenuItem.Text = "Method";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainControlToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.indicatorsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainControlToolStripMenuItem
            // 
            this.mainControlToolStripMenuItem.Name = "mainControlToolStripMenuItem";
            this.mainControlToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mainControlToolStripMenuItem.Text = "Main Control";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // indicatorsToolStripMenuItem
            // 
            this.indicatorsToolStripMenuItem.Name = "indicatorsToolStripMenuItem";
            this.indicatorsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.indicatorsToolStripMenuItem.Text = "Indicators...";
            // 
            // hyperTerminalToolStripMenuItem
            // 
            this.hyperTerminalToolStripMenuItem.Name = "hyperTerminalToolStripMenuItem";
            this.hyperTerminalToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.hyperTerminalToolStripMenuItem.Text = "Hyper Terminal";
            this.hyperTerminalToolStripMenuItem.Click += new System.EventHandler(this.hyperTerminalToolStripMenuItem_Click);
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 552);
            this.Controls.Add(this.mainWndMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainWndMenu;
            this.Name = "MainWnd";
            this.Text = "HP5890";
            this.mainWndMenu.ResumeLayout(false);
            this.mainWndMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainWndMenu;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeOnStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rS232PortConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hyperTerminalToolStripMenuItem;
    }
}

