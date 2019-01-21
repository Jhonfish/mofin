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

namespace MOFIN
{
    public partial class Frm_OpeFinancieras : MetroForm
    {
        bool vl_EsNuevo = false;
        C_Clientes r_Cliente = new C_Clientes();
        O_Observaciones r_Observaciones = new O_Observaciones();
        O_HistPerfOperac r_HistPerfOperac = new O_HistPerfOperac();
        

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
            
        }
        private void Modo_Consulta()
        {
            this.Grd_HistPerfOperac.ReadOnly = true;
            this.Grd_HistPerfOperac.RowHeadersVisible = false;
            this.Grd_HistPerfOperac.AllowUserToAddRows = false;

            this.Grd_Observaciones.ReadOnly = true;
            this.Grd_Observaciones.RowHeadersVisible = false;
            this.Grd_Observaciones.AllowUserToAddRows = false;

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

        private void Btn_ObsEli_Click(object sender, EventArgs e)
        {
            r_Observaciones = BS_OObservaciones.Current as O_Observaciones;
            string vl_RegEliminar = r_Observaciones.fecha.ToShortDateString()+ " / "+ r_Observaciones.Observacion; 
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

            this.Col_CliCod1.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_CliNme1.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_CliDocID1.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Col_CliCod2.HeaderText = this.Col_CliCod1.HeaderText;
            this.Col_CliNme2.HeaderText = this.Col_CliNme1.HeaderText;
            this.Col_CliDocID2.HeaderText = this.Col_CliDocID1.HeaderText;
            this.Col_CliCod3.HeaderText = this.Col_CliCod1.HeaderText;
            this.Col_CliNme3.HeaderText = this.Col_CliNme1.HeaderText;
            this.Col_CliDocID3.HeaderText = this.Col_CliDocID1.HeaderText;

            this.Col_PerFec.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1005);
            this.Col_PerMto.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13022);
            this.Col_PerNroTra.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13023);
            this.Col_PerRiesgo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(13024);
            this.Col_ObsFec.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1005);
            this.Col_ObsObserv.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1015);

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
            r_Cliente = BS_CClientes.Current as C_Clientes;
            List<ListaReporte> Lst_Reporte = new List<ListaReporte>();
            
            // Período de uso de Cuenta:    1: Semanal  2: Mensual  3: Trimestral   4: Semestral    5: Anual
            var vl_PerUso = r_Cliente.PeriodUsoCta;
            DateTime vl_FDesde = this.Dtp_RepDesde.Value;
            DateTime vl_FHasta = this.Dtp_RepHasta.Value;
            DateTime vl_GrupoFDesde = vl_FDesde;
            DateTime vl_GrupoFHasta = DateTime.Today;
            int vl_Ciclo = 0;
            //decimal vl_Abonos = 0;
            //decimal vl_retiros = 0;
            
            List<O_Operfinancieras> Lst_Operaciones;
            Lst_Operaciones = NO_Operfinancieras.ListarPorCodigo(r_Cliente.Codigo, vl_FDesde, vl_FHasta).ToList<O_Operfinancieras>();
            do
            {
                switch (vl_PerUso)
                {
                    case 1:     // Semanal
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
                    var vl_Abonos = Lst_GrupoOperaciones.Where(item => item.Tipo_Orden.Trim() == "ABO")
                                                        .Sum(item => item.Efectivo);
                    var vl_retiros = Lst_GrupoOperaciones.Where(item => item.Tipo_Orden.Trim() == "RET")
                                                        .Sum(item => item.Efectivo);
                }
            } while (vl_GrupoFHasta.Date < vl_FHasta.Date);
        }

        private void Pag3_Enter(object sender, EventArgs e)
        {
            this.Btn_MostrarTodos_Click(null,null);
        }
    }
}
