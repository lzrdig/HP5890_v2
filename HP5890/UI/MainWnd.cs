using System;
using System.Windows.Forms;

namespace HP5890
{
    public partial class MainWnd : Form
    {
        private HP5890mgr _devPortMgr;

        //public delegate void MyDataReceivedEventHandler(string data);
        //public event MyDataReceivedEventHandler DataReceived;
        //private MyDataReceivedEventHandler uiHelper;

        /// <summary>
        /// Intiation of the MDI window. It includes the generation of the Control Window and
        /// the creation of an object for the serial port to be used for the communication.
        /// The Serial Port object is set to be static in order to ensure its globality.
        /// A command manager is injected into the constructor.
        /// </summary>
        public MainWnd(IHP5890mgr devPortMgr)
        {
            InitializeComponent();

            _devPortMgr = (HP5890mgr)devPortMgr;

            clsGlobals.g_gcPortMgr = _devPortMgr;
            clsGlobals.g_comPort = _devPortMgr.PortObj;

            // Create the GC control window at the start of the application
            GCctrl newGC = new GCctrl();
            newGC.MdiParent = this; // Set the Parent Form of the Child window.           
            newGC.Show(); // Display the new form.
        }


        private void rS232PortConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RS232cfgForm comPortFrm = clsGlobals.g_frmobjRS232Config;

            if (comPortFrm == null)
            {
                comPortFrm = new RS232cfgForm();
                comPortFrm.MdiParent = this;
                clsGlobals.g_frmobjRS232Config = comPortFrm;
            }
            comPortFrm.Show();
            comPortFrm.BringToFront();
        }

        private void hyperTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {// multiple hyperterminal windows are to be allowed
            HyperTermForm newHyperTermForm = new HyperTermForm();

            newHyperTermForm.MdiParent = this;
            clsGlobals.g_frmobjMainWnd = this;
            newHyperTermForm.Show();
        }
    }
}
