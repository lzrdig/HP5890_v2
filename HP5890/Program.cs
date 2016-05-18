using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HP5890
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsGlobals.g_frmobjMainWnd = new MainWnd();
            clsGlobals.g_frmobjRS232Config = null;
            clsGlobals.g_comPort = null;
            Application.Run(clsGlobals.g_frmobjMainWnd);
        }
    }
}
