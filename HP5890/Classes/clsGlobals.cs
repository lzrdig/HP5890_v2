using System;
using System.IO.Ports;


namespace HP5890
{
    public sealed class clsGlobals
    {
        public static MainWnd g_frmobjMainWnd;
        public static RS232cfgForm g_frmobjRS232Config;
        public static SerialPort g_comPort;
        public static HP5890mgr g_gcPortMgr;
    }
}
