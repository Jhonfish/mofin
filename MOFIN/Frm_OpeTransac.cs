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
using MOFIN_LIB;
using CrystalDecisions.CrystalReports.Engine;


namespace MOFIN
{
    public partial class Frm_OpeTransac : MetroForm
    {
        bool vl_EsNuevo = false;
        C_Clientes r_Cliente = new C_Clientes();
        O_Observaciones r_Observaciones = new O_Observaciones();
        O_HistPerfOperac r_HistPerfOperac = new O_HistPerfOperac();
        M_NivelRiesgo r_NiveldeRiesgo = new M_NivelRiesgo();
        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();

        public Frm_OpeTransac()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_OpeTransaccionales_Load(object sender, EventArgs e)
        {
            this.Cmb_TipArchExport.SelectedIndex = 0;
            this.Height = 610;
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_OObservaciones.DataSource = NO_Observaciones.Listar();
            BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.Listar();
            BS_OOperTransaccionales.DataSource = NO_OperTransaccionales.Listar();
            BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();

            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            this.Modo_Consulta();
        }
        private void Modo_Consulta()
        {
            this.Grd_HistPerfOperac.ReadOnly = true;
            this.Grd_HistPerfOperac.RowHeadersVisible = false;
            this.Grd_HistPerfOperac.AllowUserToAddRows = false;

            this.Grd_Observaciones.ReadOnly = true;
            this.Grd_Observaciones.RowHeadersVisible = false;
            this.Grd_Observaciones.AllowUserToAddRows = false;

            this.Btn_PerfInc.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_I == null ? false : (bool)r_GrupoOpciones.OperTransac_I;
            this.Btn_PerfMod.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_M == null ? false : (bool)r_GrupoOpciones.OperTransac_M;
            this.Btn_PerfEli.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_E == null ? false : (bool)r_GrupoOpciones.OperTransac_E;
            this.Btn_ObsInc.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_I == null ? false : (bool)r_GrupoOpciones.OperTransac_I;
            this.Btn_ObsMod.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_M == null ? false : (bool)r_GrupoOpciones.OperTransac_M;
            this.Btn_ObsEli.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_E == null ? false : (bool)r_GrupoOpciones.OperTransac_E;
            this.Chk_ElimOper.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_E == null ? false : (bool)r_GrupoOpciones.OperTransac_E;
            this.Chk_Exportar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_R == null ? false : (bool)r_GrupoOpciones.OperTransac_R;
            this.Btn_Importar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.OperTransac_R == null ? false : (bool)r_GrupoOpciones.OperTransac_R;

            this.Pan_BtnsPerfil.Enabled = true;
            this.Pan_BtnsObserv.Enabled = true;
            this.Pan_Pag1.Enabled = true;
            this.Pan_Pag3.Enabled = true;
            this.Grd_ClieInfInversor.Enabled = true;
            this.Grd_Observaciones.Enabled = true;
            this.Grd_HistPerfOperac.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;
        }

        private void Modo_Edicion(int vl_Opcion)
        {
            this.Chk_Exportar.Checked = false;
            this.Chk_Exportar_CheckStateChanged(null, null);

            this.Btn_PerfInc.Enabled = false;
            this.Btn_PerfMod.Enabled = false;
            this.Btn_PerfEli.Enabled = false;
            this.Btn_ObsInc.Enabled = false;
            this.Btn_ObsMod.Enabled = false;
            this.Btn_ObsEli.Enabled = false;
            this.Chk_ElimOper.Enabled = false;
            this.Chk_Exportar.Enabled = false;
            this.Btn_Importar.Enabled = false;

            this.Pan_BtnsPerfil.Enabled = false;
            this.Pan_BtnsObserv.Enabled = false;
            this.Pan_Pag1.Enabled = false;
            this.Pan_Pag3.Enabled = false;
            this.Grd_ClieInfInversor.Enabled = false;
            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
            if (vl_Opcion == 1)
            {
                this.Grd_Observaciones.Enabled = false;
                this.Grd_HistPerfOperac.Focus();
            }
            else
            {
                this.Grd_HistPerfOperac.Enabled = false;
                this.Grd_Observaciones.Focus();
            }
        }

        /// *****************************
        /// Comportamiento del formulario
        /// *****************************
        private void Grd_ClieInfInversor_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Cliente = BS_CClientes.Current as C_Clientes;
            BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.ListarPorCodigoTipo(r_Cliente.Codigo, 2);
            BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(r_Cliente.Codigo, 2);
        }

        private void Grd_ClieDetOper_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Cliente = BS_CClientes.Current as C_Clientes;
            BS_OOperTransaccionales.DataSource = NO_OperTransaccionales.ListarPorCodigo(r_Cliente.Codigo, null, null);
        }

        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = Funciones._Mens_Idioma(14000);
            this.Pag1.Text = Funciones._Mens_Idioma(13010);
            this.Pag2.Text = Funciones._Mens_Idioma(13020);
            this.Pag3.Text = Funciones._Mens_Idioma(13030);
            this.Lbl_ListClientes1.Text = Funciones._Mens_Idioma(12007);
            this.Lbl_ListClientes2.Text = Funciones._Mens_Idioma(12007);
            this.Lbl_ListClientes3.Text = Funciones._Mens_Idioma(12007);
            this.Lbl_ListOperAfec.Text = Funciones._Mens_Idioma(13011);
            this.Lbl_Desde1.Text = Funciones._Mens_Idioma(1013);
            this.Lbl_Desde2.Text = Funciones._Mens_Idioma(1013);
            this.Lbl_Hasta1.Text = Funciones._Mens_Idioma(1014);
            this.Lbl_Hasta2.Text = Funciones._Mens_Idioma(1014);
            this.Chk_ExcMeses.Text = Funciones._Mens_Idioma(13012);
            this.Chk_IncSoloExcep.Text = Funciones._Mens_Idioma(13013);
            this.Lbl_ArcExpNme.Text = Funciones._Mens_Idioma(1002);
            this.Lbl_ArcExpTip.Text = Funciones._Mens_Idioma(1017);
            this.Lbl_Perfil.Text = Funciones._Mens_Idioma(13021);
            this.Lbl_Obsvaciones.Text = Funciones._Mens_Idioma(1016);
            this.Lbl_DetOperaciones.Text = Funciones._Mens_Idioma(13030);

            Funciones.TTT_Btn(Btn_Aceptar, Funciones._Mens_Idioma(141));
            Funciones.TTT_Btn(Btn_Cancelar, Funciones._Mens_Idioma(142));
            Funciones.TTT_Btn(Btn_Procesar, Funciones._Mens_Idioma(1018));
            Funciones.TTT_Chk(Chk_Exportar, Funciones._Mens_Idioma(1019));
            Funciones.TTT_Btn(Btn_Exportar, Funciones._Mens_Idioma(1020));
            Funciones.TTT_Btn(Btn_PerfInc, Funciones._Mens_Idioma(136));
            Funciones.TTT_Btn(Btn_PerfMod, Funciones._Mens_Idioma(137));
            Funciones.TTT_Btn(Btn_PerfEli, Funciones._Mens_Idioma(138));
            Funciones.TTT_Btn(Btn_ObsInc, Funciones._Mens_Idioma(136));
            Funciones.TTT_Btn(Btn_ObsMod, Funciones._Mens_Idioma(137));
            Funciones.TTT_Btn(Btn_ObsEli, Funciones._Mens_Idioma(138));
            Funciones.TTT_Chk(Chk_Reporte, Funciones._Mens_Idioma(13031));
            Funciones.TTT_Btn(Btn_ProcReporte, Funciones._Mens_Idioma(1018));
            Funciones.TTT_Chk(Chk_ElimOper, Funciones._Mens_Idioma(13032));
            Funciones.TTT_Btn(Btn_MostrarTodos, Funciones._Mens_Idioma(143));
            Funciones.TTT_Btn(Btn_Importar, Funciones._Mens_Idioma(1021));

            ///
            /// Grid Clientes Tab1
            /// 
            this.Codigo.HeaderText = Funciones._Mens_Idioma(1001);
            this.Nombre.HeaderText = Funciones._Mens_Idioma(1002);
            this.Doc_ID.HeaderText = Funciones._Mens_Idioma(1004);
            this.Col_CliCod2.HeaderText = this.Codigo.HeaderText;
            this.Col_CliNme2.HeaderText = this.Nombre.HeaderText;
            this.Col_CliDocID2.HeaderText = this.Doc_ID.HeaderText;
            this.Col_CliCod3.HeaderText = this.Codigo.HeaderText;
            this.Col_CliNme3.HeaderText = this.Nombre.HeaderText;
            this.Col_CliDocID3.HeaderText = this.Doc_ID.HeaderText;

            ///
            /// Grid Monitor Operaciones Tab1
            /// 
            this.Col_Alarma.HeaderText = Funciones._Mens_Idioma(13062);
            this.Col_FecGenera.HeaderText = Funciones._Mens_Idioma(13051);
            this.Col_FecUltOper.HeaderText = Funciones._Mens_Idioma(13052);
            this.Col_Codigo.HeaderText = Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = Funciones._Mens_Idioma(1002);
            this.Col_DocID.HeaderText = Funciones._Mens_Idioma(1004);
            this.Col_Nivriesgo.HeaderText = Funciones._Mens_Idioma(10016);
            this.Col_PerUsoCta.HeaderText = Funciones._Mens_Idioma(13054);
            this.Col_NroTrans.HeaderText = Funciones._Mens_Idioma(13056);
            this.Col_PerfNroTrans.HeaderText = Funciones._Mens_Idioma(13055);
            this.Col_PorcNroTrans.HeaderText = Funciones._Mens_Idioma(13057);
            this.Col_MtoCompras.HeaderText = Funciones._Mens_Idioma(13058);
            this.Col_MtoVentas.HeaderText = Funciones._Mens_Idioma(13059);
            this.Col_TotalOperac.HeaderText = Funciones._Mens_Idioma(13060);
            this.Col_PerfFinanciero.HeaderText = Funciones._Mens_Idioma(13061);
            this.Col_PorcOperaciones.HeaderText = Funciones._Mens_Idioma(13057);
            this.Col_Ejecutivo.HeaderText = Funciones._Mens_Idioma(13063);
            this.Col_Comentarios.HeaderText = Funciones._Mens_Idioma(1016);

            ///
            /// Grid Perfil Operacional y Observaciones Tab2
            /// 
            this.Col_PerFec.HeaderText = Funciones._Mens_Idioma(1005);
            this.Col_PerMto.HeaderText = Funciones._Mens_Idioma(13022);
            this.Col_PerNroTra.HeaderText = Funciones._Mens_Idioma(13023);
            this.Col_PerRiesgo.HeaderText = Funciones._Mens_Idioma(13024);
            this.Col_ObsFec.HeaderText = Funciones._Mens_Idioma(1005);
            this.Col_ObsObserv.HeaderText = Funciones._Mens_Idioma(1015);

            ///
            /// Grid Detalle de Operaciones Tab3
            /// 
            this.Col3_TipOrden.HeaderText = Funciones._Mens_Idioma(10033);
            this.Col3_FecPacto.HeaderText = Funciones._Mens_Idioma(10034);
            this.Col3_DocID.HeaderText = Funciones._Mens_Idioma(1004);
            this.Col3_CodCliente.HeaderText = Funciones._Mens_Idioma(1001);
            this.Col3_Nombre.HeaderText = Funciones._Mens_Idioma(1002);
            this.Col3_FecCierre.HeaderText = Funciones._Mens_Idioma(10035);
            this.Col3_FecValor.HeaderText = Funciones._Mens_Idioma(10036);
            //            this.Col3_MtoSolic.HeaderText = Funciones._Mens_Idioma(10037);
            this.Col3_MtoPactado.HeaderText = Funciones._Mens_Idioma(10038);
            this.Col3_Efectivo.HeaderText = Funciones._Mens_Idioma(10039);
            this.Col3_HoraCarga.HeaderText = Funciones._Mens_Idioma(10040);
            this.Col3_Comprobante.HeaderText = Funciones._Mens_Idioma(10041);
        }

        private void Pag3_Enter(object sender, EventArgs e)
        {
            this.Btn_MostrarTodos_Click(null, null);
        }

        /// *****************************
        /// Comportamiento de los Botones
        /// *****************************
        
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            r_Cliente = BS_CClientes.Current as C_Clientes;
            if (Grd_HistPerfOperac.Enabled == true)
            {
                BS_OHistPerfOperac.MoveLast();
                r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
                r_HistPerfOperac.Tipo_Perfil = 2;
                r_HistPerfOperac.Cod_Cliente = r_Cliente.Codigo;
                if (vl_EsNuevo)
                    NO_HistPerfOperac.Insertar(r_HistPerfOperac);
                else
                    NO_HistPerfOperac.Actualizar(r_HistPerfOperac);
            }
            else
            {
                BS_OObservaciones.MoveLast();
                r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
                r_Observaciones.Tipo_Perfil = 2;
                r_Observaciones.Cod_Cliente = r_Cliente.Codigo;
                if (vl_EsNuevo)
                    NO_Observaciones.Insertar(r_Observaciones);
                else
                    NO_Observaciones.Actualizar(r_Observaciones);
            }
            this.Modo_Consulta();
            this.Grd_HistPerfOperac.Refresh();
            this.Grd_Observaciones.Refresh();
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void Btn_PerfInc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Grd_HistPerfOperac.ReadOnly = false;
            BS_OHistPerfOperac.AddNew();
            this.Modo_Edicion(1);
        }
        private void Btn_PerfMod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Grd_HistPerfOperac.ReadOnly = false;
            this.Modo_Edicion(1);
        }
        private void Btn_PerfEli_Click(object sender, EventArgs e)
        {
            r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
            string vl_RegEliminar = r_HistPerfOperac.Fecha.ToShortDateString() + " / " + r_HistPerfOperac.Mto_Perfil.ToString() + " / " + r_HistPerfOperac.Nro_Transacciones.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                //                NUsuarios.Elimiar(t_Usuarios);
                //                BS_Usuarios.DataSource = NUsuarios.Listar();
                NO_HistPerfOperac.Elimiar(r_HistPerfOperac);
                BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.Listar();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_ObsInc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Grd_Observaciones.ReadOnly = false;
            BS_OObservaciones.AddNew();
            this.Modo_Edicion(2);
        }
        private void Btn_ObsMod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Grd_Observaciones.ReadOnly = false;
            this.Modo_Edicion(2);
        }
        private void Btn_ObsEli_Click(object sender, EventArgs e)
        {
            r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
            string vl_RegEliminar = r_Observaciones.fecha.ToShortDateString() + " / " + r_Observaciones.Observacion;
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                //                NUsuarios.Elimiar(t_Usuarios);
                //                BS_Usuarios.DataSource = NUsuarios.Listar();
                NO_Observaciones.Elimiar(r_Observaciones);
                BS_OObservaciones.DataSource = NO_Observaciones.Listar();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog vl_ArchivoImport = new OpenFileDialog();
            string vl_Tipoarchivo = "Archivo de Texto (*.txt)| *.TXT |Archivos CSV (*.CSV)| *.CSV |Archivos de Excel (*.XLS?)| *.XLS?";
            vl_ArchivoImport.Filter = vl_Tipoarchivo;
            // vl_ArchivoImport.CheckFileExists = false;
            if (vl_ArchivoImport.ShowDialog() == DialogResult.OK)
                MessageBox.Show(vl_ArchivoImport.FileName);
            //this.Txt_NmeArchExport.Text = vl_ArchivoImport.FileName;

        }

        private void Chk_Exportar_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.Chk_Exportar.Checked == true)
                this.Height = 675;
            else
                this.Height = 610;
        }
        private void Txt_NmeArchExport_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog vl_ArchivoExport = new OpenFileDialog();
            vl_ArchivoExport.Filter = this.Cmb_TipArchExport.Text.Trim();
            vl_ArchivoExport.CheckFileExists = false;
            if (vl_ArchivoExport.ShowDialog() == DialogResult.OK)
                this.Txt_NmeArchExport.Text = vl_ArchivoExport.FileName;
        }
        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
        }

        private void Chk_Reporte_CheckedChanged(object sender, EventArgs e)
        {
            this.Pan_Reporte.Visible = this.Chk_Reporte.Checked;
        }

        private void Chk_ElimOper_CheckedChanged(object sender, EventArgs e)
        {
            this.Grd_DetOperaciones.AllowUserToDeleteRows = this.Chk_ElimOper.Checked;
            this.Grd_DetOperaciones.RowHeadersVisible = this.Chk_ElimOper.Checked;
        }
        private void Btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            BS_OOperTransaccionales.DataSource = NO_OperTransaccionales.Listar();
        }

        public class ListaReporte
        {
            public string Cod_Cliente { get; set; }
            public DateTime Fecha { get; set; }
            public string Producto { get; set; }
            public decimal Compra { get; set; }
            public decimal Venta { get; set; }
            public string Observ { get; set; }
        }
        private void Btn_ProcReporte_Click(object sender, EventArgs e)
        {
            //BS_CClientes.DataSource = NC_Clientes.Listar();
            r_Cliente = BS_CClientes.Current as C_Clientes;
            string vl_Codigo = r_Cliente.Codigo.Trim();
            List<ListaReporte> Lst_Reporte = new List<ListaReporte>();
            
            DateTime vl_FDesde = (DateTime)this.Dtp_RepDesde.Value.Date;
            DateTime vl_FHasta = (DateTime)this.Dtp_RepHasta.Value.Date;
            Decimal vl_Compra = 0;
            Decimal vl_Venta = 0;

            //int vl_Ciclo = 0;
            string vl_Obsers = "";

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
                        if(r_registro.Tipo_Orden.ToUpper() == "ABONO" | r_registro.Tipo_Orden.ToUpper() == "APERT")
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
                Lst_Reporte.Add(new ListaReporte()
                {
                    Cod_Cliente = r_Cliente.Codigo,
                    Fecha = r_registro.Fec_Pacto,
                    Producto =r_registro.Tipo_Operacion,
                    Compra = vl_Compra,
                    Venta = vl_Venta
                });
            }

            // Procedimiento para el Calculo de las Observaciones a Incluir
            vl_Obsers = "";
            BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(vl_Codigo, 2);    // Tipo 2: Transaccionales
            BS_OObservaciones.MoveFirst();
            foreach (object obj in BS_OObservaciones)
            {
                r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
                if (r_Observaciones.Tipo_Perfil == 2 & r_Observaciones.Cod_Cliente.Trim() == vl_Codigo &
                    r_Observaciones.fecha.Date >= vl_FDesde.Date & r_Observaciones.fecha.Date <= vl_FHasta)
                    vl_Obsers = vl_Obsers + r_Observaciones.fecha.ToShortDateString() + ": " + r_Observaciones.Observacion.Trim() + " \n";
                BS_OObservaciones.MoveNext();
            }
 
            BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.ListarPorCodigoTipo(r_Cliente.Codigo, 2);
            BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(r_Cliente.Codigo, 2);

            Grd_Reporte.DataSource = Lst_Reporte;
            Grd_Reporte.Visible = true;
            Btn_Ocultar.Visible = true;

        }

        private void Btn_Ocultar_Click(object sender, EventArgs e)
        {
            this.Grd_Reporte.Visible = false;
            this.Btn_Ocultar.Visible = false;
        }

        private void Btn_Procesar_Click(object sender, EventArgs e)
        {
            /// 
            /// Creación de la lista con los usuarios involucrados en el reporte
            /// 
            List<O_RepOperacional> Lst_OperTransaccionales = new List<O_RepOperacional>();

            foreach(DataGridViewRow Registro in Grd_Clientes.SelectedRows)
            {

                ///
                /// Captura de la data de la tabla de operaciones segun los parámetros del reporte
                /// 
                string vl_Codigo = Registro.Cells["Codigo"].Value.ToString();
                bool vl_Activo = bool.Parse(Registro.Cells["Activo"].Value.ToString());
                string vl_Nombre = Registro.Cells["Nombre"].Value.ToString();
                string vl_Doc_ID = Registro.Cells["Doc_ID"].Value.ToString();
                string vl_Ejecutivo = Registro.Cells["Ejecutivo"].Value == null ? "SIN EJECUTIVO" : Registro.Cells["Ejecutivo"].Value.ToString();
                int vl_NivelRiesgo = Registro.Cells["NivelRiesgo"].Value == null ? 0 : int.Parse(Registro.Cells["NivelRiesgo"].Value.ToString());
                DateTime vl_FecGeneracion = DateTime.Today;
                DateTime vl_FecUltOperac = DateTime.Today;

                var vl_PerUso = int.Parse(Registro.Cells["PeriodUsoCta"].Value.ToString()); // Período de uso de Cuenta:    1: Semanal  2: Mensual  3: Trimestral   4: Semestral    5: Anual
                DateTime vl_FDesde = (DateTime)this.Dtp_Desde.Value.Date;
                DateTime vl_FHasta = (DateTime)this.Dtp_Hasta.Value.Date;
                DateTime vl_GrupoFDesde = vl_FDesde;
                DateTime vl_GrupoFHasta = DateTime.Today;
                Decimal vl_Compras = 0;
                Decimal vl_Ventas = 0;
                int vl_NroOper = 0;
                int vl_Ciclo = 0;
                string vl_Obsers = "";
                Decimal vl_PerFinMonto = Registro.Cells["PerfilFinanciero"].Value == null ? 0 : decimal.Parse(Registro.Cells["PerfilFinanciero"].Value.ToString());
                Decimal vl_PerFinNrOper = Registro.Cells["NroTransacciones"].Value == null ? 0 : decimal.Parse(Registro.Cells["NroTransacciones"].Value.ToString());


                List<O_OperTransaccionales> Lst_Operaciones;
                Lst_Operaciones = NO_OperTransaccionales.ListarPorCodigo(vl_Codigo, vl_FDesde, vl_FHasta).ToList<O_OperTransaccionales>();
                do
                {
                    switch (vl_PerUso)
                    {
                        case 1:     // Semanal
                            if (vl_Ciclo == 0)
                            {
                                vl_GrupoFDesde = vl_FDesde;
                                var vl_DiasSemana = (int)vl_GrupoFDesde.DayOfWeek;
                                vl_GrupoFHasta = vl_GrupoFDesde.AddDays(6 - vl_DiasSemana);
                                vl_Ciclo = 1;
                            }
                            else
                            {
                                vl_GrupoFDesde = vl_GrupoFHasta.AddDays(1);
                                vl_GrupoFHasta = vl_GrupoFDesde.AddDays(6);
                            }

                            if (vl_GrupoFHasta.Date >= vl_FHasta.Date)
                                vl_GrupoFHasta = vl_FHasta;
                            break;

                        case 2:     // Mensual
                            if (vl_Ciclo == 0)
                            {
                                vl_GrupoFDesde = vl_FDesde;
                                vl_Ciclo = 1;
                            }
                            else
                            {
                                vl_GrupoFDesde = vl_GrupoFHasta.AddDays(1);
                            }
                            vl_GrupoFHasta = DateTime.Parse(MOFIN_LIB.Funciones.UltimoDiaMes(vl_GrupoFDesde).ToString() + "/" +
                                                            vl_GrupoFDesde.Month.ToString() + "/" + vl_GrupoFDesde.Year.ToString());
                            if (vl_GrupoFHasta.Date >= vl_FHasta.Date)
                                vl_GrupoFHasta = vl_FHasta;
                            break;

                        case 3:     // Trimestral
                            if (vl_Ciclo == 0)
                            {
                                vl_GrupoFDesde = vl_FDesde;
                                vl_Ciclo = 1;
                            }
                            else
                            {
                                vl_GrupoFDesde = vl_GrupoFHasta.AddDays(1);
                            }
                            switch (vl_GrupoFDesde.Month)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    vl_GrupoFHasta = DateTime.Parse("31/03/" + vl_GrupoFDesde.Year.ToString());
                                    break;
                                case 4:
                                case 5:
                                case 6:
                                    vl_GrupoFHasta = DateTime.Parse("30/06/" + vl_GrupoFDesde.Year.ToString());
                                    break;
                                case 7:
                                case 8:
                                case 9:
                                    vl_GrupoFHasta = DateTime.Parse("30/09/" + vl_GrupoFDesde.Year.ToString());
                                    break;
                                default:
                                    vl_GrupoFHasta = DateTime.Parse("31/12/" + vl_GrupoFDesde.Year.ToString());
                                    break;
                            }
                            if (vl_GrupoFHasta.Date >= vl_FHasta.Date)
                                vl_GrupoFHasta = vl_FHasta;
                            break;

                        case 4:     // Semestral
                            if (vl_Ciclo == 0)
                            {
                                vl_GrupoFDesde = vl_FDesde;
                                vl_Ciclo = 1;
                            }
                            else
                            {
                                vl_GrupoFDesde = vl_GrupoFHasta.AddDays(1);
                            }
                            switch (vl_GrupoFDesde.Month)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    vl_GrupoFHasta = DateTime.Parse("30/06/" + vl_GrupoFDesde.Year.ToString());
                                    break;
                                default:
                                    vl_GrupoFHasta = DateTime.Parse("31/12/" + vl_GrupoFDesde.Year.ToString());
                                    break;
                            }
                            if (vl_GrupoFHasta.Date >= vl_FHasta.Date)
                                vl_GrupoFHasta = vl_FHasta;
                            break;

                        case 5:     // Anual
                            if (vl_Ciclo == 0)
                            {
                                vl_GrupoFDesde = vl_FDesde;
                                vl_Ciclo = 1;
                            }
                            else
                            {
                                vl_GrupoFDesde = vl_GrupoFHasta.AddDays(1);
                            }
                            vl_GrupoFHasta = DateTime.Parse("31/12/" + vl_GrupoFDesde.Year.ToString());
                            if (vl_GrupoFHasta.Date >= vl_FHasta.Date)
                                vl_GrupoFHasta = vl_FHasta;
                            break;
                    }

                    ///
                    /// Procedimiento para el calculo de los datos el perfil financiero
                    /// 
                    List<O_HistPerfOperac> Lst_PerfFinanciero = new List<O_HistPerfOperac>();
                    Lst_PerfFinanciero = NO_HistPerfOperac.ListarPorCodigoTipo(vl_Codigo, 2);  // Tipo 2: Transaccionales
                    Lst_PerfFinanciero = Lst_PerfFinanciero.OrderBy(Item => Item.Fecha).ToList();
                    BS_OHistPerfOperac.DataSource = Lst_PerfFinanciero.OrderBy(item => item.Fecha).ToList();
                    BS_OHistPerfOperac.MoveFirst();
                    foreach (object obj in BS_OHistPerfOperac)
                    {
                        r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
                        if (r_HistPerfOperac.Tipo_Perfil == 2 & r_HistPerfOperac.Cod_Cliente == vl_Codigo &
                            r_HistPerfOperac.Fecha.Date >= vl_GrupoFDesde.Date & r_HistPerfOperac.Fecha.Date <= vl_GrupoFHasta)
                        {
                            vl_PerFinMonto = r_HistPerfOperac.Mto_Perfil;
                            vl_PerFinNrOper = r_HistPerfOperac.Nro_Transacciones;
                            vl_NivelRiesgo = 1; // r_HistPerfOperac.Nivel_Riesgo;  se debe cambiar el campo en o_HistPerFinancier
                        }
                        BS_OHistPerfOperac.MoveNext();
                    }

                    ///
                    /// Procedimiento para el calculo de las excepciones / Alertas y los montos a prsentar en el reporte
                    /// 
                    var Lst_GrupoOperaciones = Lst_Operaciones.FindAll(x => x.Fec_Pacto >= vl_GrupoFDesde & x.Fec_Pacto <= vl_GrupoFHasta).ToList();
                    if (Lst_GrupoOperaciones != null)
                    {
                        vl_FecGeneracion = DateTime.Today;
                        vl_NroOper = 0;
                        vl_Compras = 0;
                        vl_Ventas = 0;

                        foreach (var r_Operacion in Lst_GrupoOperaciones)
                        {
                            Decimal vl_Margen_Compra = 0;
                            Decimal vl_Margen_Venta = 0;
                            Decimal vl_RtaFija_Compra = 0;
                            Decimal vl_RtaFija_Venta = 0;
                            Decimal vl_RtaVar_Compra = 0;
                            Decimal vl_RtaVar_Venta = 0;
                            Decimal vl_Futuro_Compra = 0;
                            Decimal vl_Futuro_Venta = 0;
                            Decimal vl_Opcion_Compra = 0;
                            Decimal vl_Opcion_Venta = 0;
                            Decimal vl_Mutuo_Compra = 0;
                            Decimal vl_Mutuo_Venta = 0;
                            ///
                            /// Calculo de Montos, segun el tipo de operacion
                            /// 
                            /*if (r_Operacion.Tipo_Orden.Trim() == "ABO")
                                vl_Compras = vl_Compras + (decimal)r_Operacion.Valor_Efectivo;
                            else
                                vl_Ventas = vl_Ventas + (decimal)r_Operacion.Valor_Efectivo;*/
                            switch (r_Operacion.Tipo_Operacion.Trim())
                            {
                                case "MARGEN" :
                                    if (r_Operacion.Tipo_Orden.Trim() == "ABONO" | r_Operacion.Tipo_Orden.Trim() == "APERT")
                                        vl_Margen_Compra = (Decimal)r_Operacion.Monto_Pactado;
                                    else
                                        vl_Margen_Venta = (Decimal)r_Operacion.Monto_Pactado;
                                    break;
                                case "RENTA FIJA":
                                    if (r_Operacion.Tipo_Orden.Trim() == "COMPR")
                                        vl_RtaFija_Compra = (Decimal)r_Operacion.Monto_Pactado;
                                    else
                                        vl_RtaFija_Venta = (Decimal)r_Operacion.Monto_Pactado;
                                    break;
                                case "RENTA VARIABLE":
                                    if (r_Operacion.Tipo_Orden.Trim() == "COMPR")
                                        vl_RtaVar_Compra = (Decimal)r_Operacion.Monto_Pactado;
                                    else
                                        vl_RtaVar_Venta = (Decimal)r_Operacion.Monto_Pactado;
                                    break;
                                case "FUTUROS":
                                    if (r_Operacion.Tipo_Orden.Trim() == "COMPR")
                                        vl_Futuro_Compra = (Decimal)r_Operacion.Monto_Pactado;
                                    else
                                        vl_Futuro_Venta = (Decimal)r_Operacion.Monto_Pactado;
                                    break;
                                case "OPCIONES":
                                    if (r_Operacion.Tipo_Orden.Trim() == "COMPR")
                                        vl_Opcion_Compra = (Decimal)r_Operacion.Monto_Pactado;
                                    else
                                        vl_Opcion_Venta = (Decimal)r_Operacion.Monto_Pactado;
                                    break;
                                case "MUTUO":
                                    if (r_Operacion.Tipo_Orden.Trim() == "APERT")
                                        vl_Mutuo_Compra = (Decimal)r_Operacion.Monto_Pactado;
                                    else
                                        vl_Mutuo_Venta = (Decimal)r_Operacion.Valor_Efectivo;
                                    break;
                            }

                            vl_Compras = vl_Compras + vl_Margen_Compra + vl_RtaFija_Compra + vl_RtaVar_Compra + vl_Futuro_Compra + vl_Opcion_Compra + vl_Mutuo_Compra;
                            vl_Ventas = vl_Ventas + vl_Margen_Venta + vl_RtaFija_Venta + vl_RtaVar_Venta + vl_Futuro_Venta + vl_Opcion_Venta + vl_Mutuo_Venta;

                            vl_NroOper = vl_NroOper + 1;
                            vl_FecUltOperac = r_Operacion.Fec_Pacto.Date;

                            if (((vl_Compras + vl_Ventas) > vl_PerFinMonto | (vl_NroOper > vl_PerFinNrOper)) &
                                 (vl_FecGeneracion == DateTime.Today))
                                vl_FecGeneracion = r_Operacion.Fec_Pacto;
                        }
                    }

                    vl_Obsers = "";
                    if (vl_NroOper > 0)
                    {
                        // Procedimiento para el Calculo de las Observaciones a Incluir
                        BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(vl_Codigo, 2);  // Tipo 2: Transaccionales
                        BS_OObservaciones.MoveFirst();
                        foreach (object obj in BS_OObservaciones)
                        {
                            r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
                            if (r_Observaciones.Tipo_Perfil == 2 & r_Observaciones.Cod_Cliente == vl_Codigo &
                                r_Observaciones.fecha.Date >= vl_GrupoFDesde.Date & r_Observaciones.fecha.Date <= vl_GrupoFHasta)
                                vl_Obsers = vl_Obsers + r_Observaciones.fecha.ToShortDateString() + ": " + r_Observaciones.Observacion.Trim() + " \n";
                            BS_OObservaciones.MoveNext();
                        }
                    }
                    else
                        vl_FecUltOperac = vl_GrupoFHasta.Date;

                    ///
                    /// procdimiento para llenar el list con la información del período
                    /// 
                    decimal vl_Porctrans = vl_NroOper > 0 ? (((vl_NroOper - vl_PerFinNrOper) / vl_PerFinNrOper) * 100) : 0;
                    decimal vl_PorcOperac = vl_NroOper > 0 ? ((((vl_Compras + vl_Ventas) - vl_PerFinMonto) / vl_PerFinMonto) * 100) : 0;
                    bool vl_Alarma = (vl_Porctrans > 0 | vl_PorcOperac > 0) ? true : false;

                    if ((this.Chk_ExcMeses.Checked == false |
                       (this.Chk_ExcMeses.Checked == true & vl_NroOper > 0)) &
                        (this.Chk_IncSoloExcep.Checked == false |
                       (this.Chk_IncSoloExcep.Checked == true & vl_Alarma == true)))
                    {
                        BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.GetById(vl_NivelRiesgo);
                        r_NiveldeRiesgo = BS_MNivelRiesgo.Current as M_NivelRiesgo;

                        Lst_OperTransaccionales.Add(new O_RepOperacional()
                        {
                            Alarma = vl_Alarma,
                            Fec_Generacion = vl_FecGeneracion,
                            Fec_UltOperac = vl_FecUltOperac,
                            Cod_Cliente = vl_Codigo,
                            Nme_cliente = vl_Nombre,
                            Doc_ID = vl_Doc_ID,
                            Ejecutivo = vl_Ejecutivo,
                            Niv_Riesgo = r_NiveldeRiesgo == null ? MOFIN_LIB.Funciones._Mens_Idioma(9012) : r_NiveldeRiesgo.Descripcion.Trim(),
                            Perf_Financiero = vl_PerFinMonto,
                            Perf_NroTransac = (byte)vl_PerFinNrOper,
                            Period_UsoCta = MOFIN_LIB.Funciones._Mens_Idioma(190 + vl_PerUso),
                            Porc_Transac = vl_Porctrans,
                            Mto_Compras = vl_Compras,
                            Mto_Ventas = vl_Ventas,
                            Tot_Operaciones = vl_Compras + vl_Ventas,
                            Porc_Operaciones = vl_PorcOperac,
                            Nro_Transac = (short)vl_NroOper,
                            Comentario = vl_Obsers
                        });
                    }
                } while (vl_GrupoFHasta.Date < vl_FHasta.Date);
            }
            Grd_MonitorFinanciero.DataSource = Lst_OperTransaccionales;

            ///
            /// Procdimiento de coloreado de las celdas del grid de Reporte Financiero
            /// 
            foreach (DataGridViewRow row in Grd_MonitorFinanciero.Rows)
            {
                if ((bool)row.Cells["Col_Alarma"].Value == true)
                    row.DefaultCellStyle.ForeColor = Color.Yellow;
                if ((bool)row.Cells["Col_Alarma"].Value == true & (string)row.Cells["Col_Comentarios"].Value == "")
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

    }
}
