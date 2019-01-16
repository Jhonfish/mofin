using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MofinNegocios;
using MofinModelo;
using MofinModeloEntorno;


namespace MOFIN
{
    public partial class Frm_BusqPersonas : MetroForm
    {
        public Frm_BusqPersonas()
        {
            InitializeComponent();
        }

        private void Frm_BusqPersonas_Load(object sender, EventArgs e)
        {
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.Listar();
            BS_BBuscados.DataSource = NB_Buscados.Listar();

        }

        private void Opc_CritBus3_CheckedChanged(object sender, EventArgs e)
        {
            this.Grp_DocId.Visible = this.Opc_CritBus3.Checked;
        }
    }
}
