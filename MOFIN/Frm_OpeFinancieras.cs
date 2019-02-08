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
    public partial class Frm_OpeFinancieras : MetroForm
    {
        bool vl_EsNuevo = false;
        C_Clientes r_Cliente = new C_Clientes();
        O_Observaciones r_Observaciones = new O_Observaciones();
        O_HistPerfOperac r_HistPerfOperac = new O_HistPerfOperac();
        M_NivelRiesgo r_NiveldeRiesgo = new M_NivelRiesgo();
        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();

        public Frm_OpeFinancieras()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_OpeFinancieras_Load(object sender, EventArgs e)
        {
            this.Cmb_TipArchExport.SelectedIndex = 0;
            this.Height = 610;
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_OObservaciones.DataSource = NO_Observaciones.Listar();
            BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.Listar();
            BS_OOperFinancieras.DataSource = NO_Operfinancieras.Listar();
            BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();

            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            this.Modo_Consulta();
/*            foreach (Control Controles in  Tab_MonOperaciones.Controls)
            {
                var dgv_Control = if (this.GetNextControl(Grd_Clientes, true) = DataGridView);
                {
                    dgv_Control.DefaultCellStyle.BackColor = Color.Black;
                    dgv_Control.DefaultCellStyle.ForeColor = Color.White;
                    Controles.BackgroundColor = Color.Black;
                    Controles.GridColor = Color.Gray;
                    Controles.ForeColor = Color.White;
                }
            }    */

        }
        private void Modo_Consulta()
        {
            this.Grd_HistPerfOperac.ReadOnly = true;
            this.Grd_HistPerfOperac.RowHeadersVisible = false;
            this.Grd_HistPerfOperac.AllowUserToAddRows = false;

            this.Grd_Observaciones.ReadOnly = true;
            this.Grd_Observaciones.RowHeadersVisible = false;
            this.Grd_Observaciones.AllowUserToAddRows = false;

            this.Btn_PerfInc.Enabled = r_GrupoOpciones.OperFinanc_I == null ? false : (bool)r_GrupoOpciones.OperFinanc_I;
            this.Btn_PerfMod.Enabled = r_GrupoOpciones.OperFinanc_M == null ? false : (bool)r_GrupoOpciones.OperFinanc_M;
            this.Btn_PerfEli.Enabled = r_GrupoOpciones.OperFinanc_E == null ? false : (bool)r_GrupoOpciones.OperFinanc_E;
            this.Btn_ObsInc.Enabled = r_GrupoOpciones.OperFinanc_I == null ? false : (bool)r_GrupoOpciones.OperFinanc_I;
            this.Btn_ObsMod.Enabled = r_GrupoOpciones.OperFinanc_M == null ? false : (bool)r_GrupoOpciones.OperFinanc_M;
            this.Btn_ObsEli.Enabled = r_GrupoOpciones.OperFinanc_E == null ? false : (bool)r_GrupoOpciones.OperFinanc_E;
            this.Chk_ElimOper.Enabled = r_GrupoOpciones.OperFinanc_E == null ? false : (bool)r_GrupoOpciones.OperFinanc_E;
            this.Chk_Exportar.Enabled = r_GrupoOpciones.OperFinanc_R == null ? false : (bool)r_GrupoOpciones.OperFinanc_R;
            this.Btn_Importar.Enabled = r_GrupoOpciones.OperFinanc_R == null ? false : (bool)r_GrupoOpciones.OperFinanc_R;

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
        /// Comportamiento de los Botones
        /// *****************************
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            r_Cliente = BS_CClientes.Current as C_Clientes;
            if (Grd_HistPerfOperac.Enabled == true)
            {
                BS_OHistPerfOperac.MoveLast();
                r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
                r_HistPerfOperac.Tipo_Perfil = 1;
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
                r_Observaciones.Tipo_Perfil = 1;
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
        private void Chk_Exportar_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.Chk_Exportar.Checked == true)
                this.Height = 675;
            else
                this.Height = 610;
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

        private void Btn_PerfInc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Grd_HistPerfOperac.ReadOnly = false;
            //            this.Grd_HistPerfOperac.RowHeadersVisible = true;
            //            this.Grd_HistPerfOperac.AllowUserToAddRows = true;
            BS_OHistPerfOperac.AddNew();
            this.Modo_Edicion(1);
        }

        private void Btn_ObsInc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Grd_Observaciones.ReadOnly = false;
            //            this.Grd_Observaciones.RowHeadersVisible = true;
            //            this.Grd_Observaciones.AllowUserToAddRows = true;
            BS_OObservaciones.AddNew();
            this.Modo_Edicion(2);
        }

        private void Btn_PerfMod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Grd_HistPerfOperac.ReadOnly = false;
            this.Modo_Edicion(1);
        }

        private void Btn_ObsMod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Grd_Observaciones.ReadOnly = false;
            this.Modo_Edicion(2);
        }

        private void Btn_PerfEli_Click(object sender, EventArgs e)
        {
            r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
            string vl_RegEliminar = r_HistPerfOperac.Fecha.ToShortDateString()+" / "+ r_HistPerfOperac.Mto_Perfil.ToString()+" / "+ r_HistPerfOperac.Nro_Transacciones.ToString(); 
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NO_HistPerfOperac.Elimiar(r_HistPerfOperac);
                BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.Listar();
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_ObsEli_Click(object sender, EventArgs e)
        {
            r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
            string vl_RegEliminar = r_Observaciones.fecha.ToShortDateString()+ " / "+ r_Observaciones.Observacion; 
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NO_Observaciones.Elimiar(r_Observaciones);
                BS_OObservaciones.DataSource = NO_Observaciones.Listar();
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_NmeArchExport_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog vl_ArchivoExport = new OpenFileDialog();
            vl_ArchivoExport.Filter = this.Cmb_TipArchExport.Text.Trim();   
            vl_ArchivoExport.CheckFileExists = false;
            if (vl_ArchivoExport.ShowDialog() == DialogResult.OK)
                this.Txt_NmeArchExport.Text = vl_ArchivoExport.FileName;
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
        private void Grd_ClieInfInversor_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Cliente = BS_CClientes.Current as C_Clientes;
            BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.ListarPorCodigoTipo(r_Cliente.Codigo, 1);
            BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(r_Cliente.Codigo, 1);
        }

        private void Grd_ClieDetOper_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Cliente = BS_CClientes.Current as C_Clientes;
            BS_OOperFinancieras.DataSource = NO_Operfinancieras.ListarPorCodigo(r_Cliente.Codigo, null, null);
        }

        private void Btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            BS_OOperFinancieras.DataSource = NO_Operfinancieras.Listar();
        }
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(13000);
            this.Pag1.Text = MOFIN_LIB.Funciones._Mens_Idioma(13010);
            this.Pag2.Text = MOFIN_LIB.Funciones._Mens_Idioma(13020);
            this.Pag3.Text = MOFIN_LIB.Funciones._Mens_Idioma(13030);
            this.Lbl_ListClientes1.Text = MOFIN_LIB.Funciones._Mens_Idioma(12007);
            this.Lbl_ListClientes2.Text = MOFIN_LIB.Funciones._Mens_Idioma(12007);
            this.Lbl_ListClientes3.Text = MOFIN_LIB.Funciones._Mens_Idioma(12007);
            this.Lbl_ListOperAfec.Text = MOFIN_LIB.Funciones._Mens_Idioma(13011);
            this.Lbl_Desde1.Text = MOFIN_LIB.Funciones._Mens_Idioma(1013);
            this.Lbl_Desde2.Text = MOFIN_LIB.Funciones._Mens_Idioma(1013);
            this.Lbl_Hasta1.Text = MOFIN_LIB.Funciones._Mens_Idioma(1014);
            this.Lbl_Hasta2.Text = MOFIN_LIB.Funciones._Mens_Idioma(1014);
            this.Chk_ExcMeses.Text = MOFIN_LIB.Funciones._Mens_Idioma(13012);
            this.Chk_IncSoloExcep.Text = MOFIN_LIB.Funciones._Mens_Idioma(13013);
            this.Lbl_ArcExpNme.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_ArcExpTip.Text = MOFIN_LIB.Funciones._Mens_Idioma(1017);
            this.Lbl_Perfil.Text = MOFIN_LIB.Funciones._Mens_Idioma(13021);
            this.Lbl_Obsvaciones.Text = MOFIN_LIB.Funciones._Mens_Idioma(1016);
            this.Lbl_DetOperaciones.Text = MOFIN_LIB.Funciones._Mens_Idioma(13030);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Procesar, MOFIN_LIB.Funciones._Mens_Idioma(1018));
            MOFIN_LIB.Funciones.TTT_Chk(Chk_Exportar, MOFIN_LIB.Funciones._Mens_Idioma(1019));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Exportar, MOFIN_LIB.Funciones._Mens_Idioma(1020));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_PerfInc, MOFIN_LIB.Funciones._Mens_Idioma(136));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_PerfMod, MOFIN_LIB.Funciones._Mens_Idioma(137));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_PerfEli, MOFIN_LIB.Funciones._Mens_Idioma(138));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_ObsInc, MOFIN_LIB.Funciones._Mens_Idioma(136));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_ObsMod, MOFIN_LIB.Funciones._Mens_Idioma(137));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_ObsEli, MOFIN_LIB.Funciones._Mens_Idioma(138));
            MOFIN_LIB.Funciones.TTT_Chk(Chk_Reporte, MOFIN_LIB.Funciones._Mens_Idioma(13031));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_ProcReporte, MOFIN_LIB.Funciones._Mens_Idioma(1018));
            MOFIN_LIB.Funciones.TTT_Chk(Chk_ElimOper, MOFIN_LIB.Funciones._Mens_Idioma(13032));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_MostrarTodos, MOFIN_LIB.Funciones._Mens_Idioma(143));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Importar, MOFIN_LIB.Funciones._Mens_Idioma(1021));

            ///
            /// Grid Clientes Tab1
            /// 
            this.Codigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Doc_ID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Col_CliCod2.HeaderText = this.Codigo.HeaderText;
            this.Col_CliNme2.HeaderText = this.Nombre.HeaderText;
            this.Col_CliDocID2.HeaderText = this.Doc_ID.HeaderText;
            this.Col_CliCod3.HeaderText = this.Codigo.HeaderText;
            this.Col_CliNme3.HeaderText = this.Nombre.HeaderText;
            this.Col_CliDocID3.HeaderText = this.Doc_ID.HeaderText;

            ///
            /// Grid Monitor Operaciones Tab1
            /// 
            this.Col_Alarma.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13062);
            this.Col_FecGenera.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13051);
            this.Col_FecUltOper.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13052);
            this.Col_Codigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_DocID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Col_Nivriesgo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10016);
            this.Col_PerUsoCta.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13054);
            this.Col_NroTrans.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13056);
            this.Col_PerfNroTrans.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13055);
            this.Col_PorcNroTrans.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13057);
            this.Col_MtoCompras.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13058);
            this.Col_MtoVentas.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13059);
            this.Col_TotalOperac.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13060);
            this.Col_PerfFinanciero.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13061);
            this.Col_PorcOperaciones.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13057);
            this.Col_Ejecutivo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13063);
            this.Col_Comentarios.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1016);

            ///
            /// Grid Perfil Operacional y Observaciones Tab2
            /// 
            this.Col_PerFec.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1005);
            this.Col_PerMto.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13022);
            this.Col_PerNroTra.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13023);
            this.Col_PerRiesgo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13024);
            this.Col_ObsFec.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1005);
            this.Col_ObsObserv.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1015);

            ///
            /// Grid Detalle de Operaciones Tab3
            /// 
            this.Col3_TipOrden.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10033);
            this.Col3_FecPacto.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10034);
            this.Col3_DocID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Col3_CodCliente.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col3_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col3_FecCierre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10035);
            this.Col3_FecValor.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10036);
            this.Col3_MtoSolic.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10037);
            this.Col3_MtoPactado.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10038);
            this.Col3_Efectivo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10039);
            this.Col3_HoraCarga.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10040);
            this.Col3_Comprobante.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(10041);
        }

        public class ListaReporte
        {
            public string Cod_Cliente { get; set; }
            public DateTime Fecha { get; set; }
            public decimal PerfTrans_Mto { get; set; }
            public decimal Aportes { get; set; }
            public decimal Retiros { get; set; }
            public int PerfTrans_Nro { get; set; }
            public int NroOperac { get; set; }
            public string Observ { get; set; }
        }
        private void Btn_ProcReporte_Click(object sender, EventArgs e)
        {
            //BS_CClientes.DataSource = NC_Clientes.Listar();
            r_Cliente = BS_CClientes.Current as C_Clientes;
            List<ListaReporte> Lst_Reporte = new List<ListaReporte>();
            
            // Período de uso de Cuenta:    1: Semanal  2: Mensual  3: Trimestral   4: Semestral    5: Anual
            var vl_PerUso = r_Cliente.PeriodUsoCta;
            DateTime vl_FDesde = (DateTime)this.Dtp_RepDesde.Value.Date;
            DateTime vl_FHasta = (DateTime)this.Dtp_RepHasta.Value.Date;
            DateTime vl_GrupoFDesde = vl_FDesde;
            DateTime vl_GrupoFHasta = DateTime.Today;
            Decimal vl_Abonos = 0;
            Decimal vl_Retiros = 0;
            int vl_NroOper = 0;
            int vl_Ciclo = 0;
            string vl_Obsers = "";
            Decimal vl_PerFinMonto = (r_Cliente.PerfilFinanciero != null) ? decimal.Parse(r_Cliente.PerfilFinanciero.ToString()) : 0 ;
            int vl_PerFinNrOper = (r_Cliente.NroTransacciones != null) ? int.Parse(r_Cliente.NroTransacciones.ToString()) : 0;
                       
            List<O_Operfinancieras> Lst_Operaciones;
            Lst_Operaciones = NO_Operfinancieras.ListarPorCodigo(r_Cliente.Codigo, vl_FDesde, vl_FHasta).ToList<O_Operfinancieras>();
            do
            {
                switch (vl_PerUso)
                {
                    case 1:     // Semanal
                        if (vl_Ciclo == 0)
                        {
                            vl_GrupoFDesde = vl_FDesde;
                            var vl_DiasSemana = (int)vl_GrupoFDesde.DayOfWeek;
                            vl_GrupoFHasta = vl_GrupoFDesde.AddDays(6-vl_DiasSemana);
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
                var Lst_GrupoOperaciones = Lst_Operaciones.FindAll(x => x.Fec_Pacto >= vl_GrupoFDesde & x.Fec_Pacto <= vl_GrupoFHasta);
                if (Lst_GrupoOperaciones != null)
                {
                    vl_Abonos = decimal.Parse(Lst_GrupoOperaciones.Where(item => item.Tipo_Orden.Trim() == "ABO")
                                                        .Sum(item => item.Efectivo).ToString());
                    vl_Retiros = decimal.Parse(Lst_GrupoOperaciones.Where(item => item.Tipo_Orden.Trim() == "RET")
                                                        .Sum(item => item.Efectivo).ToString());
                    vl_NroOper = Lst_GrupoOperaciones.Count;
                }

                vl_Obsers = "";
                if (vl_NroOper > 0)
                {
                    // Procedimiento para el Calculo de las Observaciones a Incluir
                    BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(r_Cliente.Codigo, 1);     // 1: Financiero
                    BS_OObservaciones.MoveFirst();
                    foreach (object obj in BS_OObservaciones)
                    {
                        r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
                        if (r_Observaciones.Tipo_Perfil == 1 & r_Observaciones.Cod_Cliente == r_Cliente.Codigo &
                            r_Observaciones.fecha.Date >= vl_GrupoFDesde.Date & r_Observaciones.fecha.Date <= vl_GrupoFHasta)
                            vl_Obsers = vl_Obsers + r_Observaciones.fecha.ToShortDateString() + ": " + r_Observaciones.Observacion.Trim() + " \n";
                        BS_OObservaciones.MoveNext();
                    }
                }

                // Procedimiento para el calculo de los datos el perfil financiero
                List<O_HistPerfOperac> Lst_PerfFinanciero = new List<O_HistPerfOperac>();

                Lst_PerfFinanciero = NO_HistPerfOperac.ListarPorCodigoTipo(r_Cliente.Codigo, 1);      // 1: Financiero
                Lst_PerfFinanciero = Lst_PerfFinanciero.OrderBy(Item => Item.Fecha).ToList();
                BS_OHistPerfOperac.DataSource = Lst_PerfFinanciero.OrderBy(item => item.Fecha).ToList();
                BS_OHistPerfOperac.MoveFirst();
                foreach (object obj in BS_OHistPerfOperac)
                {
                    r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
                    if (r_HistPerfOperac.Tipo_Perfil == 1 & r_HistPerfOperac.Cod_Cliente == r_Cliente.Codigo &
                        r_HistPerfOperac.Fecha.Date >= vl_GrupoFDesde.Date & r_HistPerfOperac.Fecha.Date <= vl_GrupoFHasta)
                    {
                        vl_PerFinMonto = r_HistPerfOperac.Mto_Perfil;
                        vl_PerFinNrOper = r_HistPerfOperac.Nro_Transacciones;
                    }
                    BS_OHistPerfOperac.MoveNext();
                }

                    // Agrega los datos al List
                Lst_Reporte.Add(new ListaReporte()
                {
                    Cod_Cliente = r_Cliente.Codigo,
                    Fecha = vl_GrupoFHasta,
                    PerfTrans_Mto = vl_PerFinMonto,
                    Aportes = vl_Abonos,
                    Retiros = vl_Retiros,
                    PerfTrans_Nro = vl_PerFinNrOper,
                    NroOperac = vl_NroOper,
                    Observ= vl_Obsers
                });
            } while (vl_GrupoFHasta.Date < vl_FHasta.Date);

            BS_OObservaciones.DataSource = NO_Observaciones.Listar();
            BS_OHistPerfOperac.DataSource = NO_HistPerfOperac.ListarPorCodigoTipo(r_Cliente.Codigo, 1);
            Grd_Reporte.DataSource = Lst_Reporte;
            Grd_Reporte.Visible = true;
            Btn_Ocultar.Visible = true;

            ///
            /// Pruebas con el Crysta report
            /// 
            /*BS_opeFinanc_Clientes.DataSource = Lst_Reporte;
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("PUT CRYSTAL REPORT PATHHERE\\CrystalReport1.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();*/
        }

        private void Pag3_Enter(object sender, EventArgs e)
        {
            this.Btn_MostrarTodos_Click(null,null);
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
            List<O_RepOperacional> Lst_OperFinancieras = new List<O_RepOperacional>();

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

                List<O_Operfinancieras> Lst_Operaciones;
                Lst_Operaciones = NO_Operfinancieras.ListarPorCodigo(vl_Codigo, vl_FDesde, vl_FHasta).ToList<O_Operfinancieras>();
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
                    Lst_PerfFinanciero = NO_HistPerfOperac.ListarPorCodigoTipo(vl_Codigo, 1);     // 1: Financiero
                    Lst_PerfFinanciero = Lst_PerfFinanciero.OrderBy(Item => Item.Fecha).ToList();
                    BS_OHistPerfOperac.DataSource = Lst_PerfFinanciero.OrderBy(item => item.Fecha).ToList();
                    BS_OHistPerfOperac.MoveFirst();
                    foreach (object obj in BS_OHistPerfOperac)
                    {
                        r_HistPerfOperac = BS_OHistPerfOperac.Current as O_HistPerfOperac;
                        if (r_HistPerfOperac.Tipo_Perfil == 1 & r_HistPerfOperac.Cod_Cliente == vl_Codigo &
                            r_HistPerfOperac.Fecha.Date >= vl_GrupoFDesde.Date & r_HistPerfOperac.Fecha.Date <= vl_GrupoFHasta)
                        {
                            vl_PerFinMonto = r_HistPerfOperac.Mto_Perfil;
                            vl_PerFinNrOper = r_HistPerfOperac.Nro_Transacciones;
                            vl_NivelRiesgo = 1; // r_HistPerfOperac.Nivel_Riesgo;  se debe cambiar el campo en o_HistPerFinancier
                        }
                        BS_OHistPerfOperac.MoveNext();
                    }

                    ///
                    /// Procedimiento para el calculo de las excepciones / Alertas
                    /// 
                    var Lst_GrupoOperaciones = Lst_Operaciones.FindAll(x => x.Fec_Pacto >= vl_GrupoFDesde & x.Fec_Pacto <= vl_GrupoFHasta).ToList();
                    if (Lst_GrupoOperaciones != null)
                    {
                        /// calculos por Resumen, pero no me dan las fechas de Excepcion y Ultima operacion
                        /*vl_Compras = decimal.Parse(Lst_GrupoOperaciones.Where(item => item.Tipo_Orden.Trim() == "ABO")
                                                            .Sum(item => item.Efectivo).ToString());
                        vl_Ventas = decimal.Parse(Lst_GrupoOperaciones.Where(item => item.Tipo_Orden.Trim() == "RET")
                                                            .Sum(item => item.Efectivo).ToString());
                        vl_NroOper = Lst_GrupoOperaciones.Count; */

                        vl_FecGeneracion = DateTime.Today;
                        vl_NroOper = 0;
                        vl_Compras = 0;
                        vl_Ventas = 0;
                        foreach (var r_Operacion in Lst_GrupoOperaciones)
                        {
                            if (r_Operacion.Tipo_Orden.Trim() == "ABO")
                                vl_Compras = vl_Compras + (decimal)r_Operacion.Efectivo;
                            else
                                vl_Ventas = vl_Ventas + (decimal)r_Operacion.Efectivo;
                            vl_NroOper = vl_NroOper + 1;
                            vl_FecUltOperac = r_Operacion.Fec_Pacto.Date;

                            if (((vl_Compras + vl_Ventas) > vl_PerFinMonto |
                                 (vl_NroOper > vl_PerFinNrOper)) &
                                 (vl_FecGeneracion == DateTime.Today))
                                vl_FecGeneracion = r_Operacion.Fec_Pacto;
                        }
                    }

                    vl_Obsers = "";
                    if (vl_NroOper > 0)
                    {
                        // Procedimiento para el Calculo de las Observaciones a Incluir
                        BS_OObservaciones.DataSource = NO_Observaciones.ListarPorCodigoTipo(vl_Codigo, 1);  // 1: Financiero
                        BS_OObservaciones.MoveFirst();
                        foreach (object obj in BS_OObservaciones)
                        {
                            r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
                            if (r_Observaciones.Tipo_Perfil == 1 & r_Observaciones.Cod_Cliente == vl_Codigo &
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

                            BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.GetById(vl_NivelRiesgo);
                            r_NiveldeRiesgo = BS_MNivelRiesgo.Current as M_NivelRiesgo;

                            Lst_OperFinancieras.Add(new O_RepOperacional()
                            {
                                Alarma = vl_Alarma,
                                Fec_Generacion = vl_FecGeneracion,
                                Fec_UltOperac = vl_FecUltOperac,
                                Cod_Cliente = vl_Codigo,
                                Nme_cliente = vl_Nombre,
                                Doc_ID = vl_Doc_ID,
                                Ejecutivo = vl_Ejecutivo,
                                Niv_Riesgo = r_NiveldeRiesgo == null? MOFIN_LIB.Funciones._Mens_Idioma(9012) : r_NiveldeRiesgo.Descripcion.Trim(),
                                Perf_Financiero = vl_PerFinMonto,
                                Perf_NroTransac = (byte)vl_PerFinNrOper,
                                Period_UsoCta = MOFIN_LIB.Funciones._Mens_Idioma(190 + vl_PerUso),
                                Porc_Transac = vl_Porctrans,
                                Mto_Compras = vl_Compras,
                                Mto_Ventas = vl_Ventas,
                                Tot_Operaciones = vl_Compras+vl_Ventas,
                                Porc_Operaciones = vl_PorcOperac,
                                Nro_Transac = (short)vl_NroOper,
                                Comentario = vl_Obsers
                            });

                } while (vl_GrupoFHasta.Date < vl_FHasta.Date);
            }
            Grd_MonitorFinanciero.DataSource = Lst_OperFinancieras;

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

        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
        }
    }
}
