using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOFIN
{
    public partial class pruebaJF_BarraMantenimiento : Component
    {
        public pruebaJF_BarraMantenimiento()
        {
            InitializeComponent();
        }

        public pruebaJF_BarraMantenimiento(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }
    }
}
