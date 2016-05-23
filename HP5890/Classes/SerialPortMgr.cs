using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Reactive.Subjects;
using System.Threading;

namespace HP5890.Classes
{
    public class SerialPortManager
    {
        private SerialPort serialPrt;
        private string comport = "COM1";
        private string Name = "COM1 Thread";
        Subject<string> messageBus = new Subject<string>();
        public IObservable<string> MessageBus => messageBus;
        private CancellationTokenSource cts = new CancellationTokenSource();

        public SerialPortManager(string comPort)
        {
            this.comport = comPort;
        }

        public void Start()
        {
            ThreadStart ts = new ThreadStart(SerialDeviceThread);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Name = this.Name;
            t.Start();
        }

        private void SerialDeviceThread()
        {
            this.serialPrt = new SerialPort(this.comport);
            while (true)
            {
                string line = this.serialPrt.ReadLine();
                this.messageBus.OnNext(line);
            }
        }
    }
}
