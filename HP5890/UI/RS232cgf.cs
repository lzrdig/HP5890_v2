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

            if (comPort.IsOpen)
            {
                PortStateInd.Text = "Port Open";

                baudRateList.Text = comPort.BaudRate.ToString();
                parityList.Text = comPort.Parity.ToString();
                dataBitsList.Text = comPort.DataBits.ToString();
                stopBitList.Text = comPort.StopBits.ToString();

                baudRateList.Enabled = true;
                parityList.Enabled = true;
                dataBitsList.Enabled = true;
                stopBitList.Enabled = true;
                flowCtrlList.Enabled = true;

                PortStateBtn.Enabled = true;
                PortStateInd.Visible = true;
                PortFindBtn.Enabled = false;
            }
            mainFrm.SetPortStatusWnd(string.Format("{0} is {1} ", comPort.PortName, comPort.IsOpen ? string.Format("open"): string.Format("closed")));
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

                baudRateList.SelectedItem = "19200";
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
                comPort.BaudRate = Convert.ToInt32(baudRateList.Text.Equals(string.Empty) ? comPort.BaudRate : Convert.ToInt32(baudRateList.Text));
                comPort.DataBits = Convert.ToInt16(dataBitsList.Text.Equals(string.Empty) ? comPort.DataBits : Convert.ToInt16(dataBitsList.Text.Split(' ').ElementAt(0)));
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (stopBitList.Text.Equals(string.Empty) ? comPort.StopBits.ToString() : stopBitList.Text));
                comPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), (flowCtrlList.Text.Equals(string.Empty) ? comPort.Handshake.ToString() : flowCtrlList.Text));
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), (parityList.Text.Equals(string.Empty) ? comPort.Parity.ToString() : parityList.Text));

                comPort.Open();

                PortStateInd.Text = "Port Open";
                PortStateBtn.Text = "Close";
            }

            mainFrm.SetPortStatusWnd(string.Format("{0} is {1} ", comPort.PortName, comPort.IsOpen ? string.Format("open") : string.Format("closed")));
        }

        private void PortStateInd_Click(object sender, EventArgs e)
        {

        }

        private void PortSettingsUpdate(object sender, EventArgs e)
        {
            UpdatePortStateBtnText();

            if (PortStateInd.Text == "Port Open")
            {
                PortStateBtn.Text = "Close";
                comPort.Close();
                //comPort.PortName = Convert.ToString(portsList.Text);
                comPort.BaudRate = Convert.ToInt32(baudRateList.Text.Equals(string.Empty) ? comPort.BaudRate:Convert.ToInt32(baudRateList.Text) );
                comPort.DataBits = Convert.ToInt16(dataBitsList.Text.Equals(string.Empty) ? comPort.DataBits:Convert.ToInt16(dataBitsList.Text));
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (stopBitList.Text.Equals(string.Empty) ? comPort.StopBits.ToString() : stopBitList.Text));
                comPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), (flowCtrlList.Text.Equals(string.Empty) ? comPort.Handshake.ToString() : flowCtrlList.Text));
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), (parityList.Text.Equals(string.Empty) ? comPort.Parity.ToString() : parityList.Text));
                comPort.Open();

                UpdateControlValues();
            }
        }


        private void RS232Form_Closing(object sender, FormClosingEventArgs e)
        {
            List<Form> parentHtermForms = new List<Form>();

            FormCollection openForms = Application.OpenForms;

            foreach (Form fc in openForms)
                if (fc.Name.Equals("HyperTermForm"))
                {
                    parentHtermForms.Add(fc);
                    ((HyperTermForm)fc).UpdateControlState();
                }
        }
    }
}
