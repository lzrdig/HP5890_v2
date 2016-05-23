using System;
using System.Windows.Forms;
using System.IO.Ports;
using Ninject;

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
            IKernel _NJkernel = new StandardKernel(new HP5890MgrModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            clsGlobals.g_frmobjMainWnd = new MainWnd(_NJkernel.Get<HP5890mgr>());
            clsGlobals.g_frmobjRS232Config = null;

            Application.Run(clsGlobals.g_frmobjMainWnd);
        }
    }
}
