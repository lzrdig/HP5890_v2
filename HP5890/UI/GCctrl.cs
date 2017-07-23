using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HP5890
{
    public partial class GCctrl : Form
    {
        public GCctrl()
        {
            InitializeComponent();

            timer4GCdlg.Tick += Timer4GCdlg_Tick;
        }

        private void Timer4GCdlg_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
