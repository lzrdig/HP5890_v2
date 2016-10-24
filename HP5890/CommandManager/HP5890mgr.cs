using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using HP5890.DTOs;

//Command     Code Description

//ID Identification command
//EP Enable Even Parity
//OP Enable Odd Parity
//ZP Disable Parity
//DF Set HP 5890 default configuration
//E+ Enable echo
//E- Disable echo(default)
//H+ Enable host handshake -ENQ/ACK
//H- Disable host handshake(default)
//N+ Enable HP 5890 (node) handshake -ENQ/ACK(default)
//N- Disable HP 5890 (node) handshake
//RS Define read sequence(default (none))
//TS Define termination sequence(default (CR/LF))
//X+ Enable XON/XOFF protocol
//X- Disable XON/XOFF protocol(default)
//AR Acquire or release remote control; locks keyboard
//AT read actual temperatures and flows
//CA change all; send a workfile to HP 5890
//EV Read HP 5890 environmental status
//IC read hp 5890 instrument configuration
//IF read hp 5890 instrument fault string
//IK read last hp 5890 key pressed
//LA list all; receive a workfile from HP 5890
//LU lock or unlock the start key
//OT output text to the hp 5890 display
//RF read Hp 5890 serial interface fault word
//RI read run and readiness information
//RK perform remote keystrokes from the host
//RT retransmit last message sent by the hp 5890
//HR delays start until host is ready
//SM requests that the host be notified when the HP 5890 status is modified
//ST start notification when hp 5890 begins to run
//CD configure data transfer
//CP configure signal producers
//SD send signal data

namespace HP5890
{
    public class HP5890command
    {
        private String _commandCode;
        private String _commandDescription;
        private String _commandGroup;

        public String commandCode { get; set; }
        public String commandDescription { get; set; }
        public String commandGroup { get; set; }

        public HP5890command()
        {
            _commandCode = "";
            _commandDescription = "";
            _commandGroup = "";
        }
        public HP5890command(String cmdCode, String cmdDescr, String cmdGrup)
        {
            _commandCode = cmdCode;
            _commandDescription = cmdDescr;
            _commandGroup = cmdGrup;
        }
        public void Add(String cmdCode, String cmdDescr, String cmdGrup)
        {
            _commandCode = cmdCode;
            _commandDescription = cmdDescr;
            _commandGroup = cmdGrup;
        }
    }


    public class HP5890mgr:IHP5890mgr
    {
        #region Members
        private Char _terminationChr = '\n';
        private String _preCommand = "\x1B"+"C";
        private String _postCommand = "";
        private String _openPortName = "COM1";
        private SerialPort _serialPort = null;
        protected Dictionary<string,HP5890command> gcHP5890cmds = new Dictionary<string,HP5890command>();
        #endregion

        /// <summary>
        /// Constructor. Mainly, it populates the list of commands
        /// </summary>
        public HP5890mgr()
        {
            InitCommandList();

            _serialPort = new SerialPort();
        }

        /// <summary>
        /// Constructor. Mainly, it populates the list of commands and creates a port object with a given name.
        /// </summary>
        public HP5890mgr(string portName)
        {
            InitCommandList();

            _openPortName = portName;
            _serialPort = new SerialPort(portName);
        }

        #region HP5890mgr Properties
        public Char TermChar
        {
            set { _terminationChr = value; }
            get { return _terminationChr; }
        }

        public String PreCmdStr
        {
            set { _preCommand = value; }
            get { return _preCommand; }
        }

        public String PostCmdStr
        {
            set { _postCommand = value; }
            get { return _postCommand; }
        }

        public String OpenPortName
        {
            set { _openPortName = value; }
            get { return _openPortName; }
        }

        public SerialPort PortObj
        {
            //set { _serialPort = value; }
            get { return _serialPort; }
        }
        #endregion

        private void InitCommandList()
        {
            HP5890command cmdObj = new HP5890command();

            cmdObj.Add("ID", "Identification Command", "Identification");
            gcHP5890cmds.Add("ID", cmdObj);
            cmdObj.Add("EP", "Enable Even Parity", "Configuration");
            gcHP5890cmds.Add("EP", cmdObj);
            cmdObj.Add("OP", "Enable Odd Parity", "Configuration");
            gcHP5890cmds.Add("OP", cmdObj);
            cmdObj.Add("ZP", "Disable Parity", "Configuration");
            gcHP5890cmds.Add("ZP", cmdObj);
            cmdObj.Add("DF", "Set HP5890 Default Configuration", "Configuration");
            gcHP5890cmds.Add("DF", cmdObj);
            cmdObj.Add("E+", "Enable Echo", "Configuration");
            gcHP5890cmds.Add("E+", cmdObj);
            cmdObj.Add("E-", "Disable Echo", "Configuration");
            gcHP5890cmds.Add("E-", cmdObj);
            cmdObj.Add("H+", "Enable Host Handshake -ENQ/ACK (default)", "Configuration");
            gcHP5890cmds.Add("H+", cmdObj);
            cmdObj.Add("H-", "Disable Host Handshake", "Configuration");
            gcHP5890cmds.Add("H-", cmdObj);
            cmdObj.Add("N+", "Enable HP5890 (node) Handshake -ENQ/ACK (default)", "Configuration");
            gcHP5890cmds.Add("N+", cmdObj);
            cmdObj.Add("N-", "Disable HP5890 (node) Handshake -ENQ/ACK (default)", "Configuration");
            gcHP5890cmds.Add("N-", cmdObj);
            cmdObj.Add("X+", "Enable XON/XOFF protocol", "Configuration");
            gcHP5890cmds.Add("X+", cmdObj);
            cmdObj.Add("X-", "Disable XON/XOFF protocol (default)", "Configuration");
            gcHP5890cmds.Add("X-", cmdObj);
            cmdObj.Add("RS", "Define read sequence (default (none))", "Configuration");
            gcHP5890cmds.Add("RS", cmdObj);
            cmdObj.Add("TS", "Define termination sequence (default (CR/LF))", "Configuration");
            gcHP5890cmds.Add("TS", cmdObj);
            cmdObj.Add("IC", "Read hp 5890 instrument configuration", "Status and Setpoint");
            gcHP5890cmds.Add("IC", cmdObj);
            cmdObj.Add("AT", "Read actual temperatures and flows", "Status and Setpoint");
            gcHP5890cmds.Add("AT", cmdObj);
            cmdObj.Add("LA", "List all settings", "ListAll");
            gcHP5890cmds.Add("LA", cmdObj);
        }

        public string CompileHP5890Command(string hwCmd)
        {
            String outCommand = String.Empty;

            if(gcHP5890cmds.ContainsKey(hwCmd))
            {
                HP5890command curCmd = gcHP5890cmds[hwCmd];
                outCommand = curCmd.commandCode;
            }

            return outCommand;
        }

        public void SendCommand(string cmdStr)
        {
            string commandToSend;

            commandToSend = PreCmdStr + cmdStr + TermChar;

            try {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Write(commandToSend);
                }
                else
                    throw new Exception("Serial Port is not Open");
            }
            catch (Exception exc){ MessageBox.Show(exc.Message); }
        }

        public byte[] ReadUntilTermSeq(string cmdStr)
        {
            byte[] buffer = new byte[1024];
            int curOffset = 0;
            int count = 1;

            _serialPort.ReadTimeout = 200;
            while (_serialPort.BytesToRead > 0)
            {
                try
                {
                    _serialPort.Read(buffer, curOffset, count);
                    curOffset += count;
                }
                catch (TimeoutException ex)
                {
                    throw;
                }
            }

            return buffer;
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

        #region higher level CONFIGURATION commands (do return values)

        public ReadyStateDataObj GetReadyState()
        {
            byte[] buff = new byte[1024];

            SendCommand("RIRQ");

            Stopwatch _stpWatch = Stopwatch.StartNew();
            bool _continue = true;
            while (_continue)
            {
                if ((PortObj.BytesToRead > 0) || (_stpWatch.ElapsedMilliseconds > 500))
                {
                    if (PortObj.BytesToRead > 0) buff = ReadUntilTermSeq("\n");
                    _stpWatch.Stop();
                    _continue = false;
                }
            }

            ReadyStateDataObj rsStruct = new ReadyStateDataObj();

            var str = System.Text.Encoding.Default.GetString(buff).ToCharArray();
            rsStruct.OvenSCRAM = char.GetNumericValue((char)str.GetValue(3)).Equals(0) ? true:false;

            return rsStruct;
        }

        public HP5890.DTOs.DetectorConfigDataObj GetConfiguration()
        {
            DetectorConfigDataObj cfgData = new DetectorConfigDataObj();

            SendCommand("ICRQ");

            return cfgData;
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

        #region DATA SETUP AND CONTROL
        public void CDconfigdata()
        {//CD		Configure data transfer
            SendCommand("CD");
        }
        #endregion
    }
}
