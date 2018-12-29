using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOFIN_Lib
{
    public partial class Frm_MantenimientoBase : Form
    {
        public Frm_MantenimientoBase()
        {
            InitializeComponent();
        }

        public virtual void Modo_Consulta()
        {
            this.TSt_BarraMantenimiento.Enabled = true;
           
        }

        public virtual void Modo_Edicion()
        {
            this.TSt_BarraMantenimiento.Enabled = false;

        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult  vl_resp = MessageBox.Show("desea Eliminar este registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
