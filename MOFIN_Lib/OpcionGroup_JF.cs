using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOFIN_Lib
{
    public partial class OpcionGroup_JF : UserControl
    {
        public OpcionGroup_JF()
        {
            InitializeComponent();
        }

        private void Opc1_CheckedChanged(object sender, EventArgs e)
        {
            this.Tag = Opc1.Tag;
        }

        private void Opc2_CheckedChanged(object sender, EventArgs e)
        {
            this.Tag = Opc2.Tag;
        }

        private void Opc3_CheckedChanged(object sender, EventArgs e)
        {
            this.Tag = Opc3.Tag;
        }

        private void Opc4_CheckedChanged(object sender, EventArgs e)
        {
            this.Tag = Opc4.Tag;
        }
    }
}
