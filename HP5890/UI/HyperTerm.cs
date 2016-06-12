using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.IO.Ports;

namespace HP5890
{
    public partial class HyperTermForm : Form
    {
        private MainWnd mainFrm;
        private RS232cfgForm portFrm;
        private HP5890mgr curCmdMgr;
        //private bool siimulState;
        private SerialPort comPort;
        private Timer _timer;

        public HyperTermForm()
        {
            InitializeComponent();

            curCmdMgr = clsGlobals.g_gcPortMgr;
            mainFrm = clsGlobals.g_frmobjMainWnd;
            portFrm = clsGlobals.g_frmobjRS232Config;
            comPort = clsGlobals.g_comPort;

            if (comPort.IsOpen) PortStateInd.Text = "port is open";

            _timer = new Timer();
        }

        public void UpdateControlState()
        {
            if (comPort.IsOpen)
            {
                PortStateInd.Text = "port is open";
                buttonRead.Enabled = true;
                buttonWrite.Enabled = true;
                buttonWriteRead.Enabled = true;
            }
            else
            {
                PortStateInd.Text = "port is closed";
                buttonRead.Enabled = false;
                buttonWrite.Enabled = false;
                buttonWriteRead.Enabled = false;
            }
        }

        private void comboBoxCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCommandType.Text)
            {
                case "configuration and setup":
                    break;
                case "status and setpoint":
                    break;
                case "run control":
                    break;
                default:
                    break;
            }
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

            if (clsGlobals.g_comPort.IsOpen) PortStateInd.Text = "port is open";
            else PortStateInd.Text = "port is closed";
        }

        private void writePort_Click(object sender, EventArgs e)
        {
            if(curCmdMgr != null) {
                //curCmdMgr.CompileHP5890Command(textBoxCommands.Text);

                curCmdMgr.SendCommand(textBoxCommands.Text);
                textBoxResponses.Text = curCmdMgr.PreCmdStr + textBoxCommands.Text + curCmdMgr.TermChar;

                //string cmd = curCmdMgr.PreCmdStr + textBoxCommands.Text + curCmdMgr.TermChar;
                //comPort.WriteLine(cmd);                

                //byte[] bytes = cmd.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
                //comPort.Write(bytes, 0, bytes.Length);
            }
        }

        private void portSimulationBtn_Click(object sender, EventArgs e)
        {
            if (simulBtnStatus.Text.Equals("port simulation is enabled"))
            {
                simulBtnStatus.Text = "port simulation is disabled";
                simulBtnStatus.ForeColor = Color.Red;
                simulBtnStatus.BackColor = Color.Gray;
            }
            else
            {
                simulBtnStatus.Text = "port simulation is enabled";
                simulBtnStatus.BackColor = Color.YellowGreen;
                simulBtnStatus.ForeColor = Color.DarkRed;
            }
        }

        private void readPort_Click(object sender, EventArgs e)
        {
            byte[] buffer = curCmdMgr.ReadUntilTermSeq("\n");

            String str = System.Text.Encoding.Default.GetString(buffer);
            textBoxResponses.Text += "\r\n" + str;
        }

        private void writeANDreadPort_Click(object sender, EventArgs e)
        {
            if (curCmdMgr != null)
            {
                curCmdMgr.SendCommand(textBoxCommands.Text);
                textBoxResponses.Text = curCmdMgr.PreCmdStr + textBoxCommands.Text + curCmdMgr.TermChar + "\r\n";

                _timer.Tick += new EventHandler(stopWatch_Tick);
                _timer.Interval = 50;
                _timer.Start();
            }
        }

        void stopWatch_Tick(object sender, EventArgs e)
        {
            if (comPort.BytesToRead > 0)
            {
                byte[] buffer = curCmdMgr.ReadUntilTermSeq("\n");

                String str = System.Text.Encoding.Default.GetString(buffer);
                textBoxResponses.Text += str;
                _timer.Stop();
            }
        }

        private void RunTestBtn_Click(object sender, EventArgs e)
        {
            if (curCmdMgr != null)
            {
                var response = curCmdMgr.GetReadyState();
            }
        }
    }
}
