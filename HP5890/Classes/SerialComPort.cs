//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO.Ports;

//namespace HP5890
//{
//    class SerialComPort
//    {
//        public static delegate void DataReceivedEventHandler(object sender, ReceivedEventArgs e);
//        public static event DataReceivedEventHandler DataReceived;
//        static SerialPort serialPort = new SerialPort();

//        static SerialComPort()
//        {
//            serialPort = new SerialPort();
//            serialPort.DataReceived += Incoming;
//            serialPort.Open();
//        }

//        private static void Incoming(object sender, SerialDataReceivedEventHandler args)
//        {
//            if (DataReceived != null)
//            {
//                ReceivedEventArgs rea = new ReceivedEventArgs { Data = args.GetObjectData() };
//                DataReceived(this, rea);
//            }
//        }
//    }

//    public class ReceivedEventArgs : EventArgs
//    {
//        public string Data { get; set; }
//    }
//}
