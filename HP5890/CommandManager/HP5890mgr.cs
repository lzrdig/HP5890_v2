using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Windows.Forms;

//Command Code    Description

//ID    Identification command
//EP    Enable Even Parity
//OP Enable Odd Parity
//ZP Disable Parity
//DF      Set HP 5890 default configuration
//E+		Enable echo
//E-		Disable echo(default)
//H+		Enable host handshake -ENQ/ACK
//H-		Disable host handshake(default)
//N+		Enable HP 5890 (node) handshake -ENQ/ACK(default)
//N-		Disable HP 5890 (node) handshake
//RS      Define read sequence(default (none))
//TS Define termination sequence(default (CR/LF))
//X+		Enable XON/XOFF protocol
//X-		Disable XON/XOFF protocol(default)
//AR Acquire or release remote control; locks keyboard
//AT read actual temperatures and flows
//CA change all; send a workfile to HP 5890
//EV Read HP 5890 environmental status
//IC read hp 5890 instrument configuration
//IF read hp 5890 instrument fault string
//IK      read last hp 5890 key pressed
//LA list all; receive a workfile from HP 5890
//LU		lock or unlock the start key
//OT      output text to the hp 5890 display
//RF      read Hp 5890 serial interface fault word
//RI      read run and readiness information
//RK      perform remote keystrokes from the host
//RT retransmit last message sent by the hp 5890
//HR delays start until host is ready
//SM      requests that the host be notified when the HP 5890 status is modified
//ST      start notification when hp 5890 begins to run
//CD      configure data transfer
//CP      configure signal producers
//SD      send signal data

namespace HP5890
{
    class HP5890command
    {
        String commandCode;
        String commandDescription;
        String commandGroup;

        public HP5890command()
        {
            commandCode = "";
            commandDescription = "";
            commandGroup = "";
        }

        public HP5890command(String cmdCode, String cmdDescr, String cmdGrup)
        {
            commandCode = cmdCode;
            commandDescription = cmdDescr;
            commandGroup = cmdGrup;
        }
        public void Apply(String cmdCode, String cmdDescr, String cmdGrup)
        {
            commandCode = cmdCode;
            commandDescription = cmdDescr;
            commandGroup = cmdGrup;
        }
    }

    class HP5890mgr
    {
        private Char _terminationChr = '\n';
        private Char _commandChr;
        private String _openPortName = "COM1";
        protected Dictionary<string,HP5890command> gcHP5890cmds = new Dictionary<string,HP5890command>();

        /// <summary>
        /// Constructor. Mainly, it populates the list of commands
        /// </summary>
        public HP5890mgr()
        { InitCommandList(); }

        public HP5890mgr(string portName)
        {
            _openPortName = portName;
            InitCommandList();
        }

        #region HP5890mgr Properties
        public Char TermChar
        {
            set { _terminationChr = value; }
            get { return _terminationChr; }
        }

        public Char CmdChar
        {
            set { _commandChr = value; }
            get { return _commandChr; }
        }

        public String OpenPortName
        {
            set { _openPortName = value; }
            get { return _openPortName; }
        }
        #endregion

        private void InitCommandList()
        {
            HP5890command cmdObj = new HP5890command();

            cmdObj.Apply("ID", "Identification command", "Identification");
            gcHP5890cmds.Add("ID", cmdObj);
            cmdObj.Apply("EP", "Enable Even Parity", "Configuration");
            gcHP5890cmds.Add("EP", cmdObj);
            cmdObj.Apply("LA", "List all settings", "Configuration");
            gcHP5890cmds.Add("LA", cmdObj);
        }

        public void SendCommand(String cmdStr)
        {
            string commandToSend;

            commandToSend = cmdStr + _terminationChr + _commandChr;

            try {
                SerialPort curPort = new SerialPort(_openPortName);

                if (curPort.IsOpen)
                {
                    curPort.Write(commandToSend);
                }
                else
                    throw new Exception("Serial Port is not Open");
            }
            catch (Exception exc){ MessageBox.Show(exc.Message); }
        }

        #region IDENTIFICATION
        public void IDentify()
        {//ID		Identification command
            SendCommand("ID");
        }
        #endregion

        #region CONFIGURATION commands // configuration commands do not have any reply

        public void DFsetdefaults()
        {//DF		Set HP 5890 default configuration
            SendCommand("DF");
        }
        public void TSdefinetermseq()
        {//TS		Define termination sequence (default (CR/LF))
            SendCommand("TS");
        }

        #endregion

        #region STATUS
        // Status & Setpoints read
        public void ATgettemperatures()
        {//AT		read actual temperatures and flows
            SendCommand("AT"+"RQ");
        }
        public void LAlistall()
        {//LA		List all. Get the workfile list from the device
            SendCommand("LA");
        }
        #endregion
    }
}
