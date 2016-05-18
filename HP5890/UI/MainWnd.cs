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
    public partial class MainWnd : Form
    {
        /// <summary>
        /// Intiation of the MDI window. It includes the generation of the Control Window and
        /// the creation of an object for the serial port to be used for the communication.
        /// The Serial Port object is set to be static in order to ensure its globality.
        /// </summary>
        public MainWnd()
        {
            InitializeComponent();

            // Create the GC control window at the start of the application
            GCctrl newGC = new GCctrl();            
            newGC.MdiParent = this; // Set the Parent Form of the Child window.           
            newGC.Show(); // Display the new form.

            // Create the SerialPort object and connect it to the global pointer,
            //which is stored in the clsGlobals
            clsGlobals.g_comPort = new SerialPort();
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
        {
            HyperTermForm newHyperTermForm = new HyperTermForm();

            newHyperTermForm.MdiParent = this;
            clsGlobals.g_frmobjMainWnd = this;
            newHyperTermForm.Show();
        }
    }
}
