using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace HP5890
{
    public partial class RS232cfgForm : Form
    {
        private MainWnd mainFrm;
        private SerialPort comPort;
        private RS232cfgForm portForm;

        public RS232cfgForm()
        {
            InitializeComponent();

            mainFrm = clsGlobals.g_frmobjMainWnd;
            portForm = clsGlobals.g_frmobjRS232Config;
            comPort = clsGlobals.g_comPort;
        }

        private void PortFindBtn_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            try
            {
                ArrayComPortsNames = SerialPort.GetPortNames();
                int numPorts = ArrayComPortsNames.GetUpperBound(0);
                if (numPorts > -1)
                {
                    do
                    {
                        index += 1;
                        PortsList.Items.Add(ArrayComPortsNames[index]);
                    }
                    while (!((ArrayComPortsNames[index] == ComPortName) || (index == numPorts)));

                    PortsList.Visible = true;
                    PortsList.DroppedDown = true;
                    PortStateInd.Visible = true;
                    PortFindBtn.Enabled = true;
                    dataBitsList.Enabled = true;
                    stopBitList.Enabled = true;
                    parityList.Enabled = true;
                    flowCtrlList.Enabled = true;
                }
                else
                    MessageBox.Show("No serial ports found");
            }
            catch (FormatException exc)
            {
                if (exc.Source != null)
                    MessageBox.Show("IOException source: {0}", exc.Source);
                throw;
            }
        }

        private void PortsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string portName = PortsList.Items[0].ToString();

            statusWnd.Text = "Port " + portName + " selected";
            if (portName != "")
            {
                PortStateBtn.Enabled = true;
                statusWnd.AppendText("\nSelect port settings and press Open");

                UpdatePortStateBtnText();
                UpdateControlValues();
            }
        }

        private void PortStateBtn_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                PortStateInd.Text = "Port Closed";
                PortStateBtn.Text = "Open";
                comPort.Close();
            }
            else
            {
                comPort.Open();
                PortStateInd.Text = "Port Open";
                PortStateBtn.Text = "Close";
            }
        }

        private void PortStateInd_Click(object sender, EventArgs e)
        {

        }

        private void PortSettingsUpdate(object sender, EventArgs e)
        {
            if (PortStateInd.Text == "Port Open")
            {
                PortStateBtn.Text = "Close";
                comPort.Close();
                //comPort.PortName = Convert.ToString(portsList.Text);
                comPort.BaudRate = Convert.ToInt32(baudRateList.Text);
                comPort.DataBits = Convert.ToInt16(dataBitsList.Text);
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitList.Text);
                comPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowCtrlList.Text);
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), parityList.Text);
                comPort.Open();

                UpdateControlValues();
            }
        }

        public void UpdateControlValues()
        {
            baudRateList.Enabled = true;
            statusWnd.AppendText("\nBaud rate = " + comPort.BaudRate.ToString());
            baudRateList.Text = comPort.BaudRate.ToString();
            statusWnd.AppendText("\nData bits = " + comPort.DataBits.ToString());
            dataBitsList.Text = comPort.DataBits.ToString();
            statusWnd.AppendText("\nHandshake control = " + comPort.Handshake.ToString());
            flowCtrlList.Text = comPort.Handshake.ToString();
            statusWnd.AppendText("\nParity = " + comPort.Parity.ToString());
            parityList.Text = comPort.Parity.ToString();
            statusWnd.AppendText("\nStop Bit = " + comPort.StopBits.ToString());
            stopBitList.Text = comPort.StopBits.ToString();
        }

        public void UpdatePortStateBtnText()
        {
            if (comPort.IsOpen)
            {
                PortStateInd.Text = "Port Open";
            }
            else
            {
                PortStateInd.Text = "Port Closed";
            }
        }
    }
}
