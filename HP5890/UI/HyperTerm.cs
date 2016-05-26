using System;
using System.Windows.Forms;
using System.Drawing;

namespace HP5890
{
    public partial class HyperTermForm : Form
    {
        private MainWnd mainFrm;
        private RS232cfgForm portFrm;
        private HP5890mgr curCmdMgr;
        private bool siimulState;

        public HyperTermForm()
        {
            InitializeComponent();

            curCmdMgr = clsGlobals.g_gcPortMgr;
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

        private void sendCommandToPort(object sender, EventArgs e)
        {
            if(curCmdMgr != null) {
                textBoxResponses.Text += string.Format("Sending the command: {0}\n", curCmdMgr.CompileHP5890Command(textBoxCommands.Text));
            }
        }

        private void portSimulationBtn_Click(object sender, EventArgs e)
        {
            if (simulBtnStatus.Text.Equals("port simulation is enabled"))
            {
                simulBtnStatus.Text = "port simulation is disabled";
                simulBtnStatus.ForeColor = Color.YellowGreen;
                simulBtnStatus.BackColor = Color.Gray;
            }
            else
            {
                simulBtnStatus.Text = "port simulation is enabled";
                simulBtnStatus.BackColor = Color.YellowGreen;
                simulBtnStatus.ForeColor = Color.DarkRed;
            }
        }
    }
}
