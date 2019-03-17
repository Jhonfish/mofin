using MofinDatos;
using MofinModelo;
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
    public partial class FrmRepTransac : Form
    {
        List<ListTransac> Lista;
        DateTime FechaDesde, FechaHasta;
        C_Clientes cliente;

        public FrmRepTransac(List<ListTransac> Lista, DateTime fechaDesde, DateTime fechaHasta, C_Clientes Cliente)
        {
            InitializeComponent();
            this.Lista = Lista;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            cliente = Cliente;
        }

        private void FrmRepTransac_Load(object sender, EventArgs e)
        {
            ListTransacBindingSource.DataSource = Lista;
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("pFechaDesde", FechaDesde.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("pFechaHasta", FechaHasta.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("pNombreCliente", cliente.Nombre),
                    new Microsoft.Reporting.WinForms.ReportParameter("pDocIdentidad", cliente.Doc_ID),
                    new Microsoft.Reporting.WinForms.ReportParameter("pTipoRiesgoCliente", cliente.NivelRiesgo.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("pDireccion", "Caraballeda")
                };
            reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.RefreshReport();
        }
    }
}
