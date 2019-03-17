using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MofinNegocios;
using MOFIN_LIB;

namespace MOFIN
{
    public partial class Frm_VisorCrystalRep : Form
    {
        public Frm_VisorCrystalRep()
        {
            InitializeComponent();
        }

        private void FrmVisorReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'monitorOperacionesDataSet.C_Clientes' Puede moverla o quitarla según sea necesario.
            //this.c_ClientesTableAdapter.Fill(this.monitorOperacionesDataSet.C_Clientes);
            BS_CClientes.DataSource = NC_Clientes.ListarPorCliente("MAR018");
            //this.reportViewer1.RefreshReport();
        }

        private void Rpt_Clientes1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
