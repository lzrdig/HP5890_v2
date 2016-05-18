using System;
using System.Windows.Forms;

namespace HP5890
{
    public partial class HyperTermForm : Form
    {
        private MainWnd mainFrm;
        private RS232cfgForm portFrm;

        public HyperTermForm()
        {
            InitializeComponent();
        }

        private void comboBoxCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowPortSettings_Click(object sender, EventArgs e)
        {
            portFrm = clsGlobals.g_frmobjRS232Config;
            if (portFrm == null)
            {
                portFrm = new RS232cfgForm();
                portFrm.MdiParent = this.MdiParent;
                clsGlobals.g_frmobjRS232Config = portFrm;
            }
            portFrm.Show();
            portFrm.BringToFront();
        }
    }
}
