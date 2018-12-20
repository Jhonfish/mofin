using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOFIN
{
    public partial class BarradeHerramientas : Form
    {
        public BarradeHerramientas()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiere eliminar este registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Anterior_Click(object sender, EventArgs e)
        {

        }
    }
}
