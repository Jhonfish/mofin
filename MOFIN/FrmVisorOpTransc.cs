using MofinDatos;
using MofinModelo;
using MofinNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MOFIN.Frm_OpeTransac;

namespace MOFIN
{
    public partial class FrmVisorOpTransc : Form
    {
        C_Clientes r_Cliente;
        List<ListTransac> Lst_Reporte = new List<ListTransac>();
        DateTime vl_FDesde;
        DateTime vl_FHasta;
        Decimal vl_Compra;
        Decimal vl_Venta;
        public FrmVisorOpTransc(C_Clientes cliente, DateTime Dtp_RepDesde, DateTime Dtp_RepHasta)
        {
            InitializeComponent();
            r_Cliente = cliente;
            string vl_Codigo = r_Cliente.Codigo.Trim();
            vl_FDesde = Dtp_RepDesde;
            vl_FHasta = Dtp_RepHasta;
            vl_Compra = 0;
            vl_Venta = 0;
        }

        private void FrmVisorOpTransc_Load(object sender, EventArgs e)
        {
            //int vl_Ciclo = 0;
            //string vl_Obsers = "";

            //Decimal vl_PerFinMonto = (r_Cliente.PerfilFinanciero != null) ? decimal.Parse(r_Cliente.PerfilFinanciero.ToString()) : 0 ;
            //int vl_PerFinNrOper = (r_Cliente.NroTransacciones != null) ? int.Parse(r_Cliente.NroTransacciones.ToString()) : 0;

            List<O_OperTransaccionales> Lst_Operaciones;
            Lst_Operaciones = NO_OperTransaccionales.ListarPorCodigo(r_Cliente.Codigo, vl_FDesde, vl_FHasta).ToList<O_OperTransaccionales>();
            foreach (var r_registro in Lst_Operaciones)
            {   /********
                **Procedimiento para el calculo de los datos mensual del reporte
                *******
                * Tipo de Operacion         SUMA +      Valor       RESTA -     Valor
                * Renta Variable            Venta       Columna1    Compra      Columna1
                * Renta Fija                Compra      Columna1    Venta       Columna1
                * Renta Fija                Venta       Columna1    Compra      Columna1 
                * Margen                    Abono       Columna1    Retiro      Columna1
                *                           Apertura    Columna1    Cierre      Columna1
                * Mutuo                     Cierre      Columna2    Apertura    Columna1
                *******
                * Campos: rg_detopet
                * Tip_Orden, Cod_Clie, mto_Pactad, Val_Efect, Grp_Clie
                *
                * Campos: ReporteTransacional
                * Client_Cod C(8), Producto C(20), Fecha D, PerfTran N(15, 2), Compras N(15,2), Ventas N(15,2), PeTr_Ope N(2), NroOper N(3), Observ M
                *******/
                switch (r_registro.Tipo_Operacion.Trim())
                {
                    case "MARGEN":     // 0 : MARGEN
                        if (r_registro.Tipo_Orden.ToUpper() == "ABONO" | r_registro.Tipo_Orden.ToUpper() == "APERT")
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        else
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Monto_Pactado;
                        }
                        break;

                    case "RENTA FIJA":     // 1 : RENTA FIJA
                        if (r_registro.Tipo_Orden.ToUpper() == "VENTA")
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Monto_Pactado;
                        }
                        else
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        break;

                    case "RENTA VARIABLE":     // 2 : RENTA VARIABLE
                        if (r_registro.Tipo_Orden.ToUpper() == "VENTA")
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Monto_Pactado;
                        }
                        else
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        break;

                    case "FURUTOS":     // 3 : FUTUROS
                        vl_Compra = 0;
                        vl_Venta = 0;
                        break;

                    case "OPCIONES":     // 4 : OPCIONES
                        vl_Compra = 0;
                        vl_Venta = 0;
                        break;

                    case "MUTUO":     // 0 :MUTUO
                        if (r_registro.Tipo_Orden.ToUpper() == "CIERR")
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Valor_Efectivo;
                        }
                        else
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        break;

                }
                // Agrega los datos al List
                Lst_Reporte.Add(new ListTransac()
                {
                    Cod_Cliente = r_Cliente.Codigo,
                    Fecha = r_registro.Fec_Pacto,
                    Producto = r_registro.Tipo_Operacion,
                    Compra = vl_Compra,
                    Venta = vl_Venta
                });
            }
            listTransacBindingSource.DataSource = Lst_Reporte;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (FrmRepTransac frm = new FrmRepTransac(Lst_Reporte, vl_FDesde, vl_FHasta, r_Cliente))
            {
                frm.ShowDialog();
            }
        }
    }
}
