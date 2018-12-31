namespace MOFIN
{
    partial class Frm_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Lbl_Codigo;
            System.Windows.Forms.Label Lbl_DocID;
            System.Windows.Forms.Label Lbl_Nombre;
            System.Windows.Forms.Label Lbl_Observacion;
            System.Windows.Forms.Label Lbl_Ejecutivo;
            System.Windows.Forms.Label Lbl_NivRiesgo;
            System.Windows.Forms.Label Lbl_PerFinanciero;
            System.Windows.Forms.Label Lbl_PerUsoCta;
            System.Windows.Forms.Label Lbl_NroTransacciones;
            System.Windows.Forms.Label Lbl_FecUltAct;
            System.Windows.Forms.Label Lbl_ToTrimestre;
            System.Windows.Forms.Label Lbl_NroOperaciones;
            System.Windows.Forms.Label Lbl_ToTrimestral;
            System.Windows.Forms.Label iG_TipDocIDLabel;
            System.Windows.Forms.Label Lbl_FecVencDocID;
            System.Windows.Forms.Label Lbl_Nacionalidad;
            System.Windows.Forms.Label Lbl_PaisNacimiento;
            System.Windows.Forms.Label Lbl_PaisResidencia;
            System.Windows.Forms.Label Lbl_Estado;
            System.Windows.Forms.Label Lbl_Edad;
            System.Windows.Forms.Label iG_TipoPersJurLabel;
            System.Windows.Forms.Label Lbl_TipoEstructura;
            System.Windows.Forms.Label Lbl_PEP;
            System.Windows.Forms.Label Lbl_VolOperaciones;
            System.Windows.Forms.Label Lbl_Criptomonedas;
            System.Windows.Forms.Label Lbl_Profesion;
            System.Windows.Forms.Label Lbl_ActivComercial;
            System.Windows.Forms.Label Lbl_TipoVinculo;
            System.Windows.Forms.Label Lbl_NmeBeneficiario;
            System.Windows.Forms.Label Lbl_BenefDoc_ID;
            System.Windows.Forms.Label Lbl_BenefFecVenc;
            System.Windows.Forms.Label Lbl_BenefPaisNacim;
            System.Windows.Forms.Label Lbl_BenefNacionalidad;
            System.Windows.Forms.Label Lbl_BenefPaisResid;
            System.Windows.Forms.Label Lbl_BenefEstado;
            System.Windows.Forms.Label Lbl_BenefEdad;
            System.Windows.Forms.Label Lbl_BenefProfesion;
            System.Windows.Forms.Label Lbl_BenefVincPorcent;
            System.Windows.Forms.Label Lbl_BenefPEP;
            System.Windows.Forms.Label Lbl_BenefVincEmpresa;
            System.Windows.Forms.Label Lbl_BenefCriptomonedas;
            System.Windows.Forms.Label Lbl_Productos;
            System.Windows.Forms.Label Lbl_Servicios;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
            this.DS_MonitorOperaciones = new MOFIN.MonitorOperacionesDataSet();
            this.BS_CClientes = new System.Windows.Forms.BindingSource(this.components);
            this.TA_CClientes = new MOFIN.MonitorOperacionesDataSetTableAdapters.C_ClientesTableAdapter();
            this.tableAdapterManager = new MOFIN.MonitorOperacionesDataSetTableAdapters.TableAdapterManager();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_DocID = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.TSB_Siguiente = new System.Windows.Forms.ToolStripButton();
            this.TS_BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.TSB_Primero = new System.Windows.Forms.ToolStripButton();
            this.TSB_Anterior = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ultimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Agregar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Modificar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Salir = new System.Windows.Forms.ToolStripButton();
            this.Tab_Clientes = new System.Windows.Forms.TabControl();
            this.Pag1 = new System.Windows.Forms.TabPage();
            this.Lst_Servicios = new System.Windows.Forms.ListBox();
            this.m_ServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lst_Productos = new System.Windows.Forms.ListBox();
            this.m_ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_ActivComercial = new System.Windows.Forms.ComboBox();
            this.Cmb_Profesion = new System.Windows.Forms.ComboBox();
            this.Cmb_Criptomonedas = new System.Windows.Forms.ComboBox();
            this.Cmb_VolOperNat = new System.Windows.Forms.ComboBox();
            this.Cmb_PEP = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoEstructura = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoPersJuridica = new System.Windows.Forms.ComboBox();
            this.Cmb_Edad = new System.Windows.Forms.ComboBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Cmb_PaisResidencia = new System.Windows.Forms.ComboBox();
            this.Cmb_PaisNacimiento = new System.Windows.Forms.ComboBox();
            this.Cmb_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.DTP_FecVencDocID = new System.Windows.Forms.DateTimePicker();
            this.Cmb_TipDocID = new System.Windows.Forms.ComboBox();
            this.c_ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn14 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn15 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn16 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn17 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn18 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn19 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn20 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn21 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn22 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn23 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn24 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn25 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn26 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn27 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn28 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn29 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn30 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn31 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn32 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn33 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn34 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn35 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn36 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn37 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn38 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn39 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn40 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn41 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn42 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn43 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn44 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn45 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn46 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn47 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn48 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn49 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn50 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn51 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn52 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn53 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pag2 = new System.Windows.Forms.TabPage();
            this.Pan_BenefBtns = new System.Windows.Forms.Panel();
            this.Btn_BenefIncluir = new System.Windows.Forms.Button();
            this.Btn_BenefEliminar = new System.Windows.Forms.Button();
            this.Btn_BenefModificar = new System.Windows.Forms.Button();
            this.Btn_BenefAceptar = new System.Windows.Forms.Button();
            this.Btn_BenefCancelar = new System.Windows.Forms.Button();
            this.Cmb_BenefCriptomonedas = new System.Windows.Forms.ComboBox();
            this.BS_CFirBenAcc = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_BenefEtiqPuntuacion = new System.Windows.Forms.Label();
            this.Lbl_BenefPuntuacion = new System.Windows.Forms.Label();
            this.Cmb_BenefPEP = new System.Windows.Forms.ComboBox();
            this.Nud_BenefVincPorcent = new System.Windows.Forms.NumericUpDown();
            this.Cmb_BenefVincEmpresa = new System.Windows.Forms.TextBox();
            this.Cmb_BenefProfesion = new System.Windows.Forms.ComboBox();
            this.Cmb_BenefEdad = new System.Windows.Forms.ComboBox();
            this.Cmb_BenefEstado = new System.Windows.Forms.ComboBox();
            this.Cmb_BenefPaisResid = new System.Windows.Forms.ComboBox();
            this.Cmb_BenefNacionalidad = new System.Windows.Forms.ComboBox();
            this.Cmb_BenefPaisNacim = new System.Windows.Forms.ComboBox();
            this.Dtp_BenefFec_Venc = new System.Windows.Forms.DateTimePicker();
            this.Txt_BenefDoc_ID = new System.Windows.Forms.TextBox();
            this.Txt_BenefNme = new System.Windows.Forms.TextBox();
            this.Grp_BenfTipoVinculacion = new System.Windows.Forms.GroupBox();
            this.Opc_TipVinc3 = new System.Windows.Forms.RadioButton();
            this.Opc_TipVinc2 = new System.Windows.Forms.RadioButton();
            this.Opc_TipVinc1 = new System.Windows.Forms.RadioButton();
            this.tipoVinculoTextBox = new System.Windows.Forms.TextBox();
            this.Grd_CFirBenAcc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pag3 = new System.Windows.Forms.TabPage();
            this.Chk_Opc30 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc29 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc28 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc27 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc26 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc25 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc24 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc23 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc22 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc21 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc20 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc19 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc18 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc17 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc16 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc15 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc14 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc13 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc12 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc11 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc10 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc9 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc8 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc7 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc6 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc5 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc4 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc3 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc2 = new System.Windows.Forms.CheckBox();
            this.Chk_Opc1 = new System.Windows.Forms.CheckBox();
            this.Pag4 = new System.Windows.Forms.TabPage();
            this.NUD_NroTransacciones = new System.Windows.Forms.NumericUpDown();
            this.Btn_Trimestre = new System.Windows.Forms.Button();
            this.NUD_TriAno = new System.Windows.Forms.NumericUpDown();
            this.NUD_TriMes = new System.Windows.Forms.NumericUpDown();
            this.Txt_TriMntOperaciones = new System.Windows.Forms.TextBox();
            this.Txt_TriNroOperaciones = new System.Windows.Forms.TextBox();
            this.DTP_FecUltAct = new System.Windows.Forms.DateTimePicker();
            this.periodUsoCtaTextBox = new System.Windows.Forms.TextBox();
            this.Txt_PerFinanciero = new System.Windows.Forms.TextBox();
            this.Txt_NivRiesgo = new System.Windows.Forms.TextBox();
            this.Txt_Ejecutivo = new System.Windows.Forms.TextBox();
            this.Txt_Observacion = new System.Windows.Forms.TextBox();
            this.Grp_PerUsoCta = new System.Windows.Forms.GroupBox();
            this.Opt_PerUsoCta5 = new System.Windows.Forms.RadioButton();
            this.Opt_PerUsoCta4 = new System.Windows.Forms.RadioButton();
            this.Opt_PerUsoCta3 = new System.Windows.Forms.RadioButton();
            this.Opt_PerUsoCta2 = new System.Windows.Forms.RadioButton();
            this.Opt_PerUsoCta1 = new System.Windows.Forms.RadioButton();
            this.Pag5 = new System.Windows.Forms.TabPage();
            this.Pic_MapEpresa = new System.Windows.Forms.PictureBox();
            this.TA_CFirBenAcc = new MOFIN.MonitorOperacionesDataSetTableAdapters.C_FirBenAccTableAdapter();
            this.Grp_TipoPersona = new System.Windows.Forms.GroupBox();
            this.Opc_TipPers2 = new System.Windows.Forms.RadioButton();
            this.Opc_TipPers1 = new System.Windows.Forms.RadioButton();
            this.Lbl_Puntuacion = new System.Windows.Forms.Label();
            this.Lbl_Activo = new System.Windows.Forms.Label();
            this.Lbl_EtiqPunt = new System.Windows.Forms.Label();
            this.m_ProductosTableAdapter = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_ProductosTableAdapter();
            this.m_ServiciosTableAdapter = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_ServiciosTableAdapter();
            Lbl_Codigo = new System.Windows.Forms.Label();
            Lbl_DocID = new System.Windows.Forms.Label();
            Lbl_Nombre = new System.Windows.Forms.Label();
            Lbl_Observacion = new System.Windows.Forms.Label();
            Lbl_Ejecutivo = new System.Windows.Forms.Label();
            Lbl_NivRiesgo = new System.Windows.Forms.Label();
            Lbl_PerFinanciero = new System.Windows.Forms.Label();
            Lbl_PerUsoCta = new System.Windows.Forms.Label();
            Lbl_NroTransacciones = new System.Windows.Forms.Label();
            Lbl_FecUltAct = new System.Windows.Forms.Label();
            Lbl_ToTrimestre = new System.Windows.Forms.Label();
            Lbl_NroOperaciones = new System.Windows.Forms.Label();
            Lbl_ToTrimestral = new System.Windows.Forms.Label();
            iG_TipDocIDLabel = new System.Windows.Forms.Label();
            Lbl_FecVencDocID = new System.Windows.Forms.Label();
            Lbl_Nacionalidad = new System.Windows.Forms.Label();
            Lbl_PaisNacimiento = new System.Windows.Forms.Label();
            Lbl_PaisResidencia = new System.Windows.Forms.Label();
            Lbl_Estado = new System.Windows.Forms.Label();
            Lbl_Edad = new System.Windows.Forms.Label();
            iG_TipoPersJurLabel = new System.Windows.Forms.Label();
            Lbl_TipoEstructura = new System.Windows.Forms.Label();
            Lbl_PEP = new System.Windows.Forms.Label();
            Lbl_VolOperaciones = new System.Windows.Forms.Label();
            Lbl_Criptomonedas = new System.Windows.Forms.Label();
            Lbl_Profesion = new System.Windows.Forms.Label();
            Lbl_ActivComercial = new System.Windows.Forms.Label();
            Lbl_TipoVinculo = new System.Windows.Forms.Label();
            Lbl_NmeBeneficiario = new System.Windows.Forms.Label();
            Lbl_BenefDoc_ID = new System.Windows.Forms.Label();
            Lbl_BenefFecVenc = new System.Windows.Forms.Label();
            Lbl_BenefPaisNacim = new System.Windows.Forms.Label();
            Lbl_BenefNacionalidad = new System.Windows.Forms.Label();
            Lbl_BenefPaisResid = new System.Windows.Forms.Label();
            Lbl_BenefEstado = new System.Windows.Forms.Label();
            Lbl_BenefEdad = new System.Windows.Forms.Label();
            Lbl_BenefProfesion = new System.Windows.Forms.Label();
            Lbl_BenefVincPorcent = new System.Windows.Forms.Label();
            Lbl_BenefPEP = new System.Windows.Forms.Label();
            Lbl_BenefVincEmpresa = new System.Windows.Forms.Label();
            Lbl_BenefCriptomonedas = new System.Windows.Forms.Label();
            Lbl_Productos = new System.Windows.Forms.Label();
            Lbl_Servicios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MonitorOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).BeginInit();
            this.TS_BarraHerramientas.SuspendLayout();
            this.Tab_Clientes.SuspendLayout();
            this.Pag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_ClientesDataGridView)).BeginInit();
            this.Pag2.SuspendLayout();
            this.Pan_BenefBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CFirBenAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_BenefVincPorcent)).BeginInit();
            this.Grp_BenfTipoVinculacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_CFirBenAcc)).BeginInit();
            this.Pag3.SuspendLayout();
            this.Pag4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NroTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriMes)).BeginInit();
            this.Grp_PerUsoCta.SuspendLayout();
            this.Pag5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_MapEpresa)).BeginInit();
            this.Grp_TipoPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new System.Drawing.Point(236, 92);
            Lbl_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new System.Drawing.Size(64, 16);
            Lbl_Codigo.TabIndex = 41;
            Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_DocID
            // 
            Lbl_DocID.AutoSize = true;
            Lbl_DocID.Location = new System.Drawing.Point(440, 92);
            Lbl_DocID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_DocID.Name = "Lbl_DocID";
            Lbl_DocID.Size = new System.Drawing.Size(64, 16);
            Lbl_DocID.TabIndex = 42;
            Lbl_DocID.Text = "Doc ID:";
            // 
            // Lbl_Nombre
            // 
            Lbl_Nombre.AutoSize = true;
            Lbl_Nombre.Location = new System.Drawing.Point(236, 118);
            Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Nombre.Name = "Lbl_Nombre";
            Lbl_Nombre.Size = new System.Drawing.Size(64, 16);
            Lbl_Nombre.TabIndex = 43;
            Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Observacion
            // 
            Lbl_Observacion.AutoSize = true;
            Lbl_Observacion.Location = new System.Drawing.Point(72, 24);
            Lbl_Observacion.Name = "Lbl_Observacion";
            Lbl_Observacion.Size = new System.Drawing.Size(104, 16);
            Lbl_Observacion.TabIndex = 0;
            Lbl_Observacion.Text = "Observacion:";
            // 
            // Lbl_Ejecutivo
            // 
            Lbl_Ejecutivo.AutoSize = true;
            Lbl_Ejecutivo.Location = new System.Drawing.Point(88, 246);
            Lbl_Ejecutivo.Name = "Lbl_Ejecutivo";
            Lbl_Ejecutivo.Size = new System.Drawing.Size(88, 16);
            Lbl_Ejecutivo.TabIndex = 2;
            Lbl_Ejecutivo.Text = "Ejecutivo:";
            // 
            // Lbl_NivRiesgo
            // 
            Lbl_NivRiesgo.AutoSize = true;
            Lbl_NivRiesgo.Location = new System.Drawing.Point(64, 274);
            Lbl_NivRiesgo.Name = "Lbl_NivRiesgo";
            Lbl_NivRiesgo.Size = new System.Drawing.Size(112, 16);
            Lbl_NivRiesgo.TabIndex = 6;
            Lbl_NivRiesgo.Text = "Nivel Riesgo:";
            // 
            // Lbl_PerFinanciero
            // 
            Lbl_PerFinanciero.AutoSize = true;
            Lbl_PerFinanciero.Location = new System.Drawing.Point(24, 302);
            Lbl_PerFinanciero.Name = "Lbl_PerFinanciero";
            Lbl_PerFinanciero.Size = new System.Drawing.Size(152, 16);
            Lbl_PerFinanciero.TabIndex = 7;
            Lbl_PerFinanciero.Text = "Perfil Financiero:";
            // 
            // Lbl_PerUsoCta
            // 
            Lbl_PerUsoCta.AutoSize = true;
            Lbl_PerUsoCta.Location = new System.Drawing.Point(48, 333);
            Lbl_PerUsoCta.Name = "Lbl_PerUsoCta";
            Lbl_PerUsoCta.Size = new System.Drawing.Size(128, 16);
            Lbl_PerUsoCta.TabIndex = 8;
            Lbl_PerUsoCta.Text = "Period Uso Cta:";
            // 
            // Lbl_NroTransacciones
            // 
            Lbl_NroTransacciones.AutoSize = true;
            Lbl_NroTransacciones.Location = new System.Drawing.Point(24, 364);
            Lbl_NroTransacciones.Name = "Lbl_NroTransacciones";
            Lbl_NroTransacciones.Size = new System.Drawing.Size(152, 16);
            Lbl_NroTransacciones.TabIndex = 10;
            Lbl_NroTransacciones.Text = "Nro Transacciones:";
            // 
            // Lbl_FecUltAct
            // 
            Lbl_FecUltAct.AutoSize = true;
            Lbl_FecUltAct.Location = new System.Drawing.Point(56, 393);
            Lbl_FecUltAct.Name = "Lbl_FecUltAct";
            Lbl_FecUltAct.Size = new System.Drawing.Size(120, 16);
            Lbl_FecUltAct.TabIndex = 12;
            Lbl_FecUltAct.Text = "Fec Ultim Act:";
            // 
            // Lbl_ToTrimestre
            // 
            Lbl_ToTrimestre.AutoSize = true;
            Lbl_ToTrimestre.Location = new System.Drawing.Point(800, 271);
            Lbl_ToTrimestre.Name = "Lbl_ToTrimestre";
            Lbl_ToTrimestre.Size = new System.Drawing.Size(248, 16);
            Lbl_ToTrimestre.TabIndex = 14;
            Lbl_ToTrimestre.Text = "Total Movilizado del Trimestre";
            // 
            // Lbl_NroOperaciones
            // 
            Lbl_NroOperaciones.AutoSize = true;
            Lbl_NroOperaciones.Location = new System.Drawing.Point(832, 358);
            Lbl_NroOperaciones.Name = "Lbl_NroOperaciones";
            Lbl_NroOperaciones.Size = new System.Drawing.Size(144, 16);
            Lbl_NroOperaciones.TabIndex = 18;
            Lbl_NroOperaciones.Text = "Nro. Operaciones:";
            // 
            // Lbl_ToTrimestral
            // 
            Lbl_ToTrimestral.AutoSize = true;
            Lbl_ToTrimestral.Location = new System.Drawing.Point(832, 390);
            Lbl_ToTrimestral.Name = "Lbl_ToTrimestral";
            Lbl_ToTrimestral.Size = new System.Drawing.Size(56, 16);
            Lbl_ToTrimestral.TabIndex = 20;
            Lbl_ToTrimestral.Text = "Monto:";
            // 
            // iG_TipDocIDLabel
            // 
            iG_TipDocIDLabel.AutoSize = true;
            iG_TipDocIDLabel.Location = new System.Drawing.Point(13, 15);
            iG_TipDocIDLabel.Name = "iG_TipDocIDLabel";
            iG_TipDocIDLabel.Size = new System.Drawing.Size(104, 16);
            iG_TipDocIDLabel.TabIndex = 1;
            iG_TipDocIDLabel.Text = "Tipo Doc ID:";
            // 
            // Lbl_FecVencDocID
            // 
            Lbl_FecVencDocID.AutoSize = true;
            Lbl_FecVencDocID.Location = new System.Drawing.Point(53, 47);
            Lbl_FecVencDocID.Name = "Lbl_FecVencDocID";
            Lbl_FecVencDocID.Size = new System.Drawing.Size(160, 16);
            Lbl_FecVencDocID.TabIndex = 3;
            Lbl_FecVencDocID.Text = "Fec. Venc. Doc. ID:";
            // 
            // Lbl_Nacionalidad
            // 
            Lbl_Nacionalidad.AutoSize = true;
            Lbl_Nacionalidad.Location = new System.Drawing.Point(13, 75);
            Lbl_Nacionalidad.Name = "Lbl_Nacionalidad";
            Lbl_Nacionalidad.Size = new System.Drawing.Size(112, 16);
            Lbl_Nacionalidad.TabIndex = 5;
            Lbl_Nacionalidad.Text = "Nacionalidad:";
            // 
            // Lbl_PaisNacimiento
            // 
            Lbl_PaisNacimiento.AutoSize = true;
            Lbl_PaisNacimiento.Location = new System.Drawing.Point(13, 108);
            Lbl_PaisNacimiento.Name = "Lbl_PaisNacimiento";
            Lbl_PaisNacimiento.Size = new System.Drawing.Size(136, 16);
            Lbl_PaisNacimiento.TabIndex = 7;
            Lbl_PaisNacimiento.Text = "Pais Nacimiento:";
            // 
            // Lbl_PaisResidencia
            // 
            Lbl_PaisResidencia.AutoSize = true;
            Lbl_PaisResidencia.Location = new System.Drawing.Point(13, 138);
            Lbl_PaisResidencia.Name = "Lbl_PaisResidencia";
            Lbl_PaisResidencia.Size = new System.Drawing.Size(136, 16);
            Lbl_PaisResidencia.TabIndex = 9;
            Lbl_PaisResidencia.Text = "Pais Residencia:";
            // 
            // Lbl_Estado
            // 
            Lbl_Estado.AutoSize = true;
            Lbl_Estado.Location = new System.Drawing.Point(13, 168);
            Lbl_Estado.Name = "Lbl_Estado";
            Lbl_Estado.Size = new System.Drawing.Size(144, 16);
            Lbl_Estado.TabIndex = 11;
            Lbl_Estado.Text = "Ubic. Geográfica:";
            // 
            // Lbl_Edad
            // 
            Lbl_Edad.AutoSize = true;
            Lbl_Edad.Location = new System.Drawing.Point(680, 16);
            Lbl_Edad.Name = "Lbl_Edad";
            Lbl_Edad.Size = new System.Drawing.Size(48, 16);
            Lbl_Edad.TabIndex = 13;
            Lbl_Edad.Text = "Edad:";
            // 
            // iG_TipoPersJurLabel
            // 
            iG_TipoPersJurLabel.AutoSize = true;
            iG_TipoPersJurLabel.Location = new System.Drawing.Point(560, 48);
            iG_TipoPersJurLabel.Name = "iG_TipoPersJurLabel";
            iG_TipoPersJurLabel.Size = new System.Drawing.Size(168, 16);
            iG_TipoPersJurLabel.TabIndex = 15;
            iG_TipoPersJurLabel.Text = "Tipo Pers. Jurídica:";
            // 
            // Lbl_TipoEstructura
            // 
            Lbl_TipoEstructura.AutoSize = true;
            Lbl_TipoEstructura.Location = new System.Drawing.Point(592, 78);
            Lbl_TipoEstructura.Name = "Lbl_TipoEstructura";
            Lbl_TipoEstructura.Size = new System.Drawing.Size(136, 16);
            Lbl_TipoEstructura.TabIndex = 17;
            Lbl_TipoEstructura.Text = "Tipo Estructura:";
            // 
            // Lbl_PEP
            // 
            Lbl_PEP.AutoSize = true;
            Lbl_PEP.Location = new System.Drawing.Point(648, 108);
            Lbl_PEP.Name = "Lbl_PEP";
            Lbl_PEP.Size = new System.Drawing.Size(80, 16);
            Lbl_PEP.TabIndex = 19;
            Lbl_PEP.Text = "P.E.P.\'s:";
            // 
            // Lbl_VolOperaciones
            // 
            Lbl_VolOperaciones.AutoSize = true;
            Lbl_VolOperaciones.Location = new System.Drawing.Point(584, 138);
            Lbl_VolOperaciones.Name = "Lbl_VolOperaciones";
            Lbl_VolOperaciones.Size = new System.Drawing.Size(144, 16);
            Lbl_VolOperaciones.TabIndex = 21;
            Lbl_VolOperaciones.Text = "Vol. Operaciones:";
            // 
            // Lbl_Criptomonedas
            // 
            Lbl_Criptomonedas.AutoSize = true;
            Lbl_Criptomonedas.Location = new System.Drawing.Point(552, 168);
            Lbl_Criptomonedas.Name = "Lbl_Criptomonedas";
            Lbl_Criptomonedas.Size = new System.Drawing.Size(176, 16);
            Lbl_Criptomonedas.TabIndex = 23;
            Lbl_Criptomonedas.Text = "Maneja Criptomonedas:";
            // 
            // Lbl_Profesion
            // 
            Lbl_Profesion.AutoSize = true;
            Lbl_Profesion.Location = new System.Drawing.Point(13, 197);
            Lbl_Profesion.Name = "Lbl_Profesion";
            Lbl_Profesion.Size = new System.Drawing.Size(88, 16);
            Lbl_Profesion.TabIndex = 25;
            Lbl_Profesion.Text = "Profesión:";
            // 
            // Lbl_ActivComercial
            // 
            Lbl_ActivComercial.AutoSize = true;
            Lbl_ActivComercial.Location = new System.Drawing.Point(13, 227);
            Lbl_ActivComercial.Name = "Lbl_ActivComercial";
            Lbl_ActivComercial.Size = new System.Drawing.Size(168, 16);
            Lbl_ActivComercial.TabIndex = 27;
            Lbl_ActivComercial.Text = "Actividad Comercial:";
            // 
            // Lbl_TipoVinculo
            // 
            Lbl_TipoVinculo.AutoSize = true;
            Lbl_TipoVinculo.Location = new System.Drawing.Point(435, 29);
            Lbl_TipoVinculo.Name = "Lbl_TipoVinculo";
            Lbl_TipoVinculo.Size = new System.Drawing.Size(144, 16);
            Lbl_TipoVinculo.TabIndex = 1;
            Lbl_TipoVinculo.Text = "Tipo Vinculación:";
            // 
            // Lbl_NmeBeneficiario
            // 
            Lbl_NmeBeneficiario.AutoSize = true;
            Lbl_NmeBeneficiario.Location = new System.Drawing.Point(435, 100);
            Lbl_NmeBeneficiario.Name = "Lbl_NmeBeneficiario";
            Lbl_NmeBeneficiario.Size = new System.Drawing.Size(64, 16);
            Lbl_NmeBeneficiario.TabIndex = 4;
            Lbl_NmeBeneficiario.Text = "Nombre:";
            // 
            // Lbl_BenefDoc_ID
            // 
            Lbl_BenefDoc_ID.AutoSize = true;
            Lbl_BenefDoc_ID.Location = new System.Drawing.Point(435, 128);
            Lbl_BenefDoc_ID.Name = "Lbl_BenefDoc_ID";
            Lbl_BenefDoc_ID.Size = new System.Drawing.Size(64, 16);
            Lbl_BenefDoc_ID.TabIndex = 6;
            Lbl_BenefDoc_ID.Text = "Doc ID:";
            // 
            // Lbl_BenefFecVenc
            // 
            Lbl_BenefFecVenc.AutoSize = true;
            Lbl_BenefFecVenc.Location = new System.Drawing.Point(809, 128);
            Lbl_BenefFecVenc.Name = "Lbl_BenefFecVenc";
            Lbl_BenefFecVenc.Size = new System.Drawing.Size(88, 16);
            Lbl_BenefFecVenc.TabIndex = 8;
            Lbl_BenefFecVenc.Text = "Fec Venc.:";
            // 
            // Lbl_BenefPaisNacim
            // 
            Lbl_BenefPaisNacim.AutoSize = true;
            Lbl_BenefPaisNacim.Location = new System.Drawing.Point(435, 156);
            Lbl_BenefPaisNacim.Name = "Lbl_BenefPaisNacim";
            Lbl_BenefPaisNacim.Size = new System.Drawing.Size(136, 16);
            Lbl_BenefPaisNacim.TabIndex = 10;
            Lbl_BenefPaisNacim.Text = "Pais Nacimiento:";
            // 
            // Lbl_BenefNacionalidad
            // 
            Lbl_BenefNacionalidad.AutoSize = true;
            Lbl_BenefNacionalidad.Location = new System.Drawing.Point(435, 186);
            Lbl_BenefNacionalidad.Name = "Lbl_BenefNacionalidad";
            Lbl_BenefNacionalidad.Size = new System.Drawing.Size(112, 16);
            Lbl_BenefNacionalidad.TabIndex = 12;
            Lbl_BenefNacionalidad.Text = "Nacionalidad:";
            // 
            // Lbl_BenefPaisResid
            // 
            Lbl_BenefPaisResid.AutoSize = true;
            Lbl_BenefPaisResid.Location = new System.Drawing.Point(435, 216);
            Lbl_BenefPaisResid.Name = "Lbl_BenefPaisResid";
            Lbl_BenefPaisResid.Size = new System.Drawing.Size(136, 16);
            Lbl_BenefPaisResid.TabIndex = 14;
            Lbl_BenefPaisResid.Text = "Pais Residencia:";
            // 
            // Lbl_BenefEstado
            // 
            Lbl_BenefEstado.AutoSize = true;
            Lbl_BenefEstado.Location = new System.Drawing.Point(435, 246);
            Lbl_BenefEstado.Name = "Lbl_BenefEstado";
            Lbl_BenefEstado.Size = new System.Drawing.Size(144, 16);
            Lbl_BenefEstado.TabIndex = 16;
            Lbl_BenefEstado.Text = "Ubic. Geográfica:";
            // 
            // Lbl_BenefEdad
            // 
            Lbl_BenefEdad.AutoSize = true;
            Lbl_BenefEdad.Location = new System.Drawing.Point(913, 156);
            Lbl_BenefEdad.Name = "Lbl_BenefEdad";
            Lbl_BenefEdad.Size = new System.Drawing.Size(48, 16);
            Lbl_BenefEdad.TabIndex = 18;
            Lbl_BenefEdad.Text = "Edad:";
            // 
            // Lbl_BenefProfesion
            // 
            Lbl_BenefProfesion.AutoSize = true;
            Lbl_BenefProfesion.Location = new System.Drawing.Point(435, 276);
            Lbl_BenefProfesion.Name = "Lbl_BenefProfesion";
            Lbl_BenefProfesion.Size = new System.Drawing.Size(88, 16);
            Lbl_BenefProfesion.TabIndex = 20;
            Lbl_BenefProfesion.Text = "Profesion:";
            // 
            // Lbl_BenefVincPorcent
            // 
            Lbl_BenefVincPorcent.AutoSize = true;
            Lbl_BenefVincPorcent.Location = new System.Drawing.Point(435, 363);
            Lbl_BenefVincPorcent.Name = "Lbl_BenefVincPorcent";
            Lbl_BenefVincPorcent.Size = new System.Drawing.Size(112, 16);
            Lbl_BenefVincPorcent.TabIndex = 26;
            Lbl_BenefVincPorcent.Text = "% Accionario:";
            // 
            // Lbl_BenefPEP
            // 
            Lbl_BenefPEP.AutoSize = true;
            Lbl_BenefPEP.Location = new System.Drawing.Point(900, 216);
            Lbl_BenefPEP.Name = "Lbl_BenefPEP";
            Lbl_BenefPEP.Size = new System.Drawing.Size(80, 16);
            Lbl_BenefPEP.TabIndex = 28;
            Lbl_BenefPEP.Text = "P.E.P.\'s:";
            // 
            // Lbl_BenefVincEmpresa
            // 
            Lbl_BenefVincEmpresa.AutoSize = true;
            Lbl_BenefVincEmpresa.Location = new System.Drawing.Point(435, 336);
            Lbl_BenefVincEmpresa.Name = "Lbl_BenefVincEmpresa";
            Lbl_BenefVincEmpresa.Size = new System.Drawing.Size(160, 16);
            Lbl_BenefVincEmpresa.TabIndex = 60;
            Lbl_BenefVincEmpresa.Text = "Es Benef. Final en:";
            // 
            // Lbl_BenefCriptomonedas
            // 
            Lbl_BenefCriptomonedas.AutoSize = true;
            Lbl_BenefCriptomonedas.Location = new System.Drawing.Point(435, 306);
            Lbl_BenefCriptomonedas.Name = "Lbl_BenefCriptomonedas";
            Lbl_BenefCriptomonedas.Size = new System.Drawing.Size(152, 16);
            Lbl_BenefCriptomonedas.TabIndex = 58;
            Lbl_BenefCriptomonedas.Text = "Maneja Criptomon.:";
            // 
            // Lbl_Productos
            // 
            Lbl_Productos.AutoSize = true;
            Lbl_Productos.Location = new System.Drawing.Point(731, 255);
            Lbl_Productos.Name = "Lbl_Productos";
            Lbl_Productos.Size = new System.Drawing.Size(88, 16);
            Lbl_Productos.TabIndex = 29;
            Lbl_Productos.Text = "Productos:";
            // 
            // Lbl_Servicios
            // 
            Lbl_Servicios.AutoSize = true;
            Lbl_Servicios.Location = new System.Drawing.Point(417, 255);
            Lbl_Servicios.Name = "Lbl_Servicios";
            Lbl_Servicios.Size = new System.Drawing.Size(88, 16);
            Lbl_Servicios.TabIndex = 31;
            Lbl_Servicios.Text = "Servicios:";
            // 
            // DS_MonitorOperaciones
            // 
            this.DS_MonitorOperaciones.DataSetName = "MonitorOperacionesDataSet";
            this.DS_MonitorOperaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_CClientes
            // 
            this.BS_CClientes.DataMember = "C_Clientes";
            this.BS_CClientes.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_CClientes
            // 
            this.TA_CClientes.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.B_BuscadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.C_ClientesTableAdapter = this.TA_CClientes;
            this.tableAdapterManager.C_FirBenAccTableAdapter = null;
            this.tableAdapterManager.C_HistActClientesTableAdapter = null;
            this.tableAdapterManager.C_ValorItemConsExpTableAdapter = null;
            this.tableAdapterManager.M_ActivComercialTableAdapter = null;
            this.tableAdapterManager.M_AntiguedadTableAdapter = null;
            this.tableAdapterManager.M_CriptomonedasTableAdapter = null;
            this.tableAdapterManager.M_EdadTableAdapter = null;
            this.tableAdapterManager.M_EstadosTableAdapter = null;
            this.tableAdapterManager.M_NivelRiesgoTableAdapter = null;
            this.tableAdapterManager.M_PaisTableAdapter = null;
            this.tableAdapterManager.M_PEPTableAdapter = null;
            this.tableAdapterManager.M_ProductosTableAdapter = null;
            this.tableAdapterManager.M_ProfesionesTableAdapter = null;
            this.tableAdapterManager.M_ServiciosTableAdapter = null;
            this.tableAdapterManager.M_TipoDocIDTableAdapter = null;
            this.tableAdapterManager.M_TipoEstructuraEmpresaTableAdapter = null;
            this.tableAdapterManager.M_TipoPersJuridicaTableAdapter = null;
            this.tableAdapterManager.M_VolOperPersJurTableAdapter = null;
            this.tableAdapterManager.M_VolOperPersNatTableAdapter = null;
            this.tableAdapterManager.O_HistPerfOperacTableAdapter = null;
            this.tableAdapterManager.O_ObservacionesTableAdapter = null;
            this.tableAdapterManager.O_OperfinancierasTableAdapter = null;
            this.tableAdapterManager.O_OperTransaccionalesTableAdapter = null;
            this.tableAdapterManager.O_RepOperacionalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOFIN.MonitorOperacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(308, 89);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(121, 22);
            this.Txt_Codigo.TabIndex = 42;
            // 
            // Txt_DocID
            // 
            this.Txt_DocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Doc_ID", true));
            this.Txt_DocID.Location = new System.Drawing.Point(512, 89);
            this.Txt_DocID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DocID.Name = "Txt_DocID";
            this.Txt_DocID.Size = new System.Drawing.Size(160, 22);
            this.Txt_DocID.TabIndex = 43;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(308, 115);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(364, 22);
            this.Txt_Nombre.TabIndex = 44;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(579, 632);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 46;
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Visible = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.BackgroundImage")));
            this.Btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Location = new System.Drawing.Point(472, 632);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 45;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // TSB_Siguiente
            // 
            this.TSB_Siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Siguiente.Image")));
            this.TSB_Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Siguiente.Name = "TSB_Siguiente";
            this.TSB_Siguiente.Size = new System.Drawing.Size(40, 40);
            this.TSB_Siguiente.Text = "Siguiente";
            // 
            // TS_BarraHerramientas
            // 
            this.TS_BarraHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.TS_BarraHerramientas.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_BarraHerramientas.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_BarraHerramientas.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.TS_BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Primero,
            this.TSB_Anterior,
            this.TSB_Siguiente,
            this.TSB_Ultimo,
            this.toolStripSeparator1,
            this.TSB_Agregar,
            this.TSB_Modificar,
            this.TSB_Eliminar,
            this.TSB_Imprimir,
            this.toolStripSeparator3,
            this.TSB_Salir});
            this.TS_BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TS_BarraHerramientas.Location = new System.Drawing.Point(560, 15);
            this.TS_BarraHerramientas.Name = "TS_BarraHerramientas";
            this.TS_BarraHerramientas.Size = new System.Drawing.Size(384, 43);
            this.TS_BarraHerramientas.TabIndex = 47;
            this.TS_BarraHerramientas.Text = "toolStrip1";
            // 
            // TSB_Primero
            // 
            this.TSB_Primero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Primero.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Primero.Image")));
            this.TSB_Primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Primero.Name = "TSB_Primero";
            this.TSB_Primero.Size = new System.Drawing.Size(40, 40);
            this.TSB_Primero.Text = "Primero";
            this.TSB_Primero.Click += new System.EventHandler(this.TSB_Primero_Click);
            // 
            // TSB_Anterior
            // 
            this.TSB_Anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Anterior.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Anterior.Image")));
            this.TSB_Anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Anterior.Name = "TSB_Anterior";
            this.TSB_Anterior.Size = new System.Drawing.Size(40, 40);
            this.TSB_Anterior.Text = "Anterior";
            // 
            // TSB_Ultimo
            // 
            this.TSB_Ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Ultimo.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ultimo.Image")));
            this.TSB_Ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ultimo.Name = "TSB_Ultimo";
            this.TSB_Ultimo.Size = new System.Drawing.Size(40, 40);
            this.TSB_Ultimo.Text = "Último";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // TSB_Agregar
            // 
            this.TSB_Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Agregar.Image")));
            this.TSB_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Agregar.Name = "TSB_Agregar";
            this.TSB_Agregar.Size = new System.Drawing.Size(40, 40);
            this.TSB_Agregar.Text = "Incluir";
            // 
            // TSB_Modificar
            // 
            this.TSB_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Modificar.Image")));
            this.TSB_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Modificar.Name = "TSB_Modificar";
            this.TSB_Modificar.Size = new System.Drawing.Size(40, 40);
            this.TSB_Modificar.Text = "Modificar";
            this.TSB_Modificar.Click += new System.EventHandler(this.TSB_Modificar_Click);
            // 
            // TSB_Eliminar
            // 
            this.TSB_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Eliminar.Image")));
            this.TSB_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Eliminar.Name = "TSB_Eliminar";
            this.TSB_Eliminar.Size = new System.Drawing.Size(40, 40);
            this.TSB_Eliminar.Text = "Eliminar";
            this.TSB_Eliminar.Click += new System.EventHandler(this.TSB_Eliminar_Click);
            // 
            // TSB_Imprimir
            // 
            this.TSB_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Imprimir.Image")));
            this.TSB_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Imprimir.Name = "TSB_Imprimir";
            this.TSB_Imprimir.Size = new System.Drawing.Size(40, 40);
            this.TSB_Imprimir.Text = "Imprimir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // TSB_Salir
            // 
            this.TSB_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Salir.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Salir.Image")));
            this.TSB_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Salir.Name = "TSB_Salir";
            this.TSB_Salir.Size = new System.Drawing.Size(40, 40);
            this.TSB_Salir.Text = "Salir";
            this.TSB_Salir.Click += new System.EventHandler(this.TSB_Salir_Click);
            // 
            // Tab_Clientes
            // 
            this.Tab_Clientes.Controls.Add(this.Pag1);
            this.Tab_Clientes.Controls.Add(this.Pag2);
            this.Tab_Clientes.Controls.Add(this.Pag3);
            this.Tab_Clientes.Controls.Add(this.Pag4);
            this.Tab_Clientes.Controls.Add(this.Pag5);
            this.Tab_Clientes.Location = new System.Drawing.Point(12, 144);
            this.Tab_Clientes.Name = "Tab_Clientes";
            this.Tab_Clientes.SelectedIndex = 0;
            this.Tab_Clientes.Size = new System.Drawing.Size(1071, 482);
            this.Tab_Clientes.TabIndex = 48;
            // 
            // Pag1
            // 
            this.Pag1.AutoScroll = true;
            this.Pag1.Controls.Add(Lbl_Servicios);
            this.Pag1.Controls.Add(this.Lst_Servicios);
            this.Pag1.Controls.Add(Lbl_Productos);
            this.Pag1.Controls.Add(this.Lst_Productos);
            this.Pag1.Controls.Add(Lbl_ActivComercial);
            this.Pag1.Controls.Add(this.Cmb_ActivComercial);
            this.Pag1.Controls.Add(Lbl_Profesion);
            this.Pag1.Controls.Add(this.Cmb_Profesion);
            this.Pag1.Controls.Add(Lbl_Criptomonedas);
            this.Pag1.Controls.Add(this.Cmb_Criptomonedas);
            this.Pag1.Controls.Add(Lbl_VolOperaciones);
            this.Pag1.Controls.Add(this.Cmb_VolOperNat);
            this.Pag1.Controls.Add(Lbl_PEP);
            this.Pag1.Controls.Add(this.Cmb_PEP);
            this.Pag1.Controls.Add(Lbl_TipoEstructura);
            this.Pag1.Controls.Add(this.Cmb_TipoEstructura);
            this.Pag1.Controls.Add(iG_TipoPersJurLabel);
            this.Pag1.Controls.Add(this.Cmb_TipoPersJuridica);
            this.Pag1.Controls.Add(Lbl_Edad);
            this.Pag1.Controls.Add(this.Cmb_Edad);
            this.Pag1.Controls.Add(Lbl_Estado);
            this.Pag1.Controls.Add(this.Cmb_Estado);
            this.Pag1.Controls.Add(Lbl_PaisResidencia);
            this.Pag1.Controls.Add(this.Cmb_PaisResidencia);
            this.Pag1.Controls.Add(Lbl_PaisNacimiento);
            this.Pag1.Controls.Add(this.Cmb_PaisNacimiento);
            this.Pag1.Controls.Add(Lbl_Nacionalidad);
            this.Pag1.Controls.Add(this.Cmb_Nacionalidad);
            this.Pag1.Controls.Add(Lbl_FecVencDocID);
            this.Pag1.Controls.Add(this.DTP_FecVencDocID);
            this.Pag1.Controls.Add(iG_TipDocIDLabel);
            this.Pag1.Controls.Add(this.Cmb_TipDocID);
            this.Pag1.Controls.Add(this.c_ClientesDataGridView);
            this.Pag1.Location = new System.Drawing.Point(4, 25);
            this.Pag1.Name = "Pag1";
            this.Pag1.Padding = new System.Windows.Forms.Padding(3);
            this.Pag1.Size = new System.Drawing.Size(1063, 453);
            this.Pag1.TabIndex = 0;
            this.Pag1.Text = "Información General : 2";
            this.Pag1.UseVisualStyleBackColor = true;
            this.Pag1.Click += new System.EventHandler(this.Pag1_Click);
            // 
            // Lst_Servicios
            // 
            this.Lst_Servicios.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.m_ServiciosBindingSource, "Descripcion", true));
            this.Lst_Servicios.FormattingEnabled = true;
            this.Lst_Servicios.ItemHeight = 16;
            this.Lst_Servicios.Location = new System.Drawing.Point(420, 274);
            this.Lst_Servicios.Name = "Lst_Servicios";
            this.Lst_Servicios.Size = new System.Drawing.Size(300, 164);
            this.Lst_Servicios.TabIndex = 32;
            // 
            // m_ServiciosBindingSource
            // 
            this.m_ServiciosBindingSource.DataMember = "M_Servicios";
            this.m_ServiciosBindingSource.DataSource = this.DS_MonitorOperaciones;
            // 
            // Lst_Productos
            // 
            this.Lst_Productos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.m_ProductosBindingSource, "Descripcion", true));
            this.Lst_Productos.FormattingEnabled = true;
            this.Lst_Productos.ItemHeight = 16;
            this.Lst_Productos.Location = new System.Drawing.Point(734, 274);
            this.Lst_Productos.Name = "Lst_Productos";
            this.Lst_Productos.Size = new System.Drawing.Size(300, 164);
            this.Lst_Productos.TabIndex = 30;
            // 
            // m_ProductosBindingSource
            // 
            this.m_ProductosBindingSource.DataMember = "M_Productos";
            this.m_ProductosBindingSource.DataSource = this.DS_MonitorOperaciones;
            // 
            // Cmb_ActivComercial
            // 
            this.Cmb_ActivComercial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_ActivComer", true));
            this.Cmb_ActivComercial.FormattingEnabled = true;
            this.Cmb_ActivComercial.Location = new System.Drawing.Point(187, 224);
            this.Cmb_ActivComercial.Name = "Cmb_ActivComercial";
            this.Cmb_ActivComercial.Size = new System.Drawing.Size(847, 24);
            this.Cmb_ActivComercial.TabIndex = 28;
            // 
            // Cmb_Profesion
            // 
            this.Cmb_Profesion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_Profesion", true));
            this.Cmb_Profesion.FormattingEnabled = true;
            this.Cmb_Profesion.Location = new System.Drawing.Point(187, 194);
            this.Cmb_Profesion.Name = "Cmb_Profesion";
            this.Cmb_Profesion.Size = new System.Drawing.Size(847, 24);
            this.Cmb_Profesion.TabIndex = 26;
            // 
            // Cmb_Criptomonedas
            // 
            this.Cmb_Criptomonedas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_Criptomoneda", true));
            this.Cmb_Criptomonedas.FormattingEnabled = true;
            this.Cmb_Criptomonedas.Location = new System.Drawing.Point(734, 164);
            this.Cmb_Criptomonedas.Name = "Cmb_Criptomonedas";
            this.Cmb_Criptomonedas.Size = new System.Drawing.Size(300, 24);
            this.Cmb_Criptomonedas.TabIndex = 24;
            // 
            // Cmb_VolOperNat
            // 
            this.Cmb_VolOperNat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_VolumOperac", true));
            this.Cmb_VolOperNat.FormattingEnabled = true;
            this.Cmb_VolOperNat.Location = new System.Drawing.Point(734, 134);
            this.Cmb_VolOperNat.Name = "Cmb_VolOperNat";
            this.Cmb_VolOperNat.Size = new System.Drawing.Size(300, 24);
            this.Cmb_VolOperNat.TabIndex = 22;
            // 
            // Cmb_PEP
            // 
            this.Cmb_PEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_PEP", true));
            this.Cmb_PEP.FormattingEnabled = true;
            this.Cmb_PEP.Location = new System.Drawing.Point(734, 104);
            this.Cmb_PEP.Name = "Cmb_PEP";
            this.Cmb_PEP.Size = new System.Drawing.Size(300, 24);
            this.Cmb_PEP.TabIndex = 20;
            // 
            // Cmb_TipoEstructura
            // 
            this.Cmb_TipoEstructura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_TipoEstructura", true));
            this.Cmb_TipoEstructura.FormattingEnabled = true;
            this.Cmb_TipoEstructura.Location = new System.Drawing.Point(734, 74);
            this.Cmb_TipoEstructura.Name = "Cmb_TipoEstructura";
            this.Cmb_TipoEstructura.Size = new System.Drawing.Size(300, 24);
            this.Cmb_TipoEstructura.TabIndex = 18;
            // 
            // Cmb_TipoPersJuridica
            // 
            this.Cmb_TipoPersJuridica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_TipoPersJur", true));
            this.Cmb_TipoPersJuridica.FormattingEnabled = true;
            this.Cmb_TipoPersJuridica.Location = new System.Drawing.Point(734, 44);
            this.Cmb_TipoPersJuridica.Name = "Cmb_TipoPersJuridica";
            this.Cmb_TipoPersJuridica.Size = new System.Drawing.Size(300, 24);
            this.Cmb_TipoPersJuridica.TabIndex = 16;
            // 
            // Cmb_Edad
            // 
            this.Cmb_Edad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_Edad", true));
            this.Cmb_Edad.FormattingEnabled = true;
            this.Cmb_Edad.Location = new System.Drawing.Point(734, 12);
            this.Cmb_Edad.Name = "Cmb_Edad";
            this.Cmb_Edad.Size = new System.Drawing.Size(300, 24);
            this.Cmb_Edad.TabIndex = 14;
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_Estado", true));
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(187, 162);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(303, 24);
            this.Cmb_Estado.TabIndex = 12;
            // 
            // Cmb_PaisResidencia
            // 
            this.Cmb_PaisResidencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_PaisResid", true));
            this.Cmb_PaisResidencia.FormattingEnabled = true;
            this.Cmb_PaisResidencia.Location = new System.Drawing.Point(187, 132);
            this.Cmb_PaisResidencia.Name = "Cmb_PaisResidencia";
            this.Cmb_PaisResidencia.Size = new System.Drawing.Size(303, 24);
            this.Cmb_PaisResidencia.TabIndex = 10;
            // 
            // Cmb_PaisNacimiento
            // 
            this.Cmb_PaisNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_PaisNacim", true));
            this.Cmb_PaisNacimiento.FormattingEnabled = true;
            this.Cmb_PaisNacimiento.Location = new System.Drawing.Point(187, 102);
            this.Cmb_PaisNacimiento.Name = "Cmb_PaisNacimiento";
            this.Cmb_PaisNacimiento.Size = new System.Drawing.Size(303, 24);
            this.Cmb_PaisNacimiento.TabIndex = 8;
            // 
            // Cmb_Nacionalidad
            // 
            this.Cmb_Nacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_Nacionalidad", true));
            this.Cmb_Nacionalidad.FormattingEnabled = true;
            this.Cmb_Nacionalidad.Location = new System.Drawing.Point(187, 72);
            this.Cmb_Nacionalidad.Name = "Cmb_Nacionalidad";
            this.Cmb_Nacionalidad.Size = new System.Drawing.Size(303, 24);
            this.Cmb_Nacionalidad.TabIndex = 6;
            // 
            // DTP_FecVencDocID
            // 
            this.DTP_FecVencDocID.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "IG_FecVencDocID", true));
            this.DTP_FecVencDocID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FecVencDocID.Location = new System.Drawing.Point(237, 43);
            this.DTP_FecVencDocID.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DTP_FecVencDocID.Name = "DTP_FecVencDocID";
            this.DTP_FecVencDocID.Size = new System.Drawing.Size(119, 22);
            this.DTP_FecVencDocID.TabIndex = 4;
            this.DTP_FecVencDocID.Value = new System.DateTime(2018, 12, 30, 19, 29, 21, 0);
            // 
            // Cmb_TipDocID
            // 
            this.Cmb_TipDocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "IG_TipDocID", true));
            this.Cmb_TipDocID.FormattingEnabled = true;
            this.Cmb_TipDocID.Location = new System.Drawing.Point(190, 13);
            this.Cmb_TipDocID.Name = "Cmb_TipDocID";
            this.Cmb_TipDocID.Size = new System.Drawing.Size(300, 24);
            this.Cmb_TipDocID.TabIndex = 2;
            // 
            // c_ClientesDataGridView
            // 
            this.c_ClientesDataGridView.AutoGenerateColumns = false;
            this.c_ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.c_ClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn7,
            this.dataGridViewCheckBoxColumn8,
            this.dataGridViewCheckBoxColumn9,
            this.dataGridViewCheckBoxColumn10,
            this.dataGridViewCheckBoxColumn11,
            this.dataGridViewCheckBoxColumn12,
            this.dataGridViewCheckBoxColumn13,
            this.dataGridViewCheckBoxColumn14,
            this.dataGridViewCheckBoxColumn15,
            this.dataGridViewCheckBoxColumn16,
            this.dataGridViewCheckBoxColumn17,
            this.dataGridViewCheckBoxColumn18,
            this.dataGridViewCheckBoxColumn19,
            this.dataGridViewCheckBoxColumn20,
            this.dataGridViewCheckBoxColumn21,
            this.dataGridViewCheckBoxColumn22,
            this.dataGridViewCheckBoxColumn23,
            this.dataGridViewCheckBoxColumn24,
            this.dataGridViewCheckBoxColumn25,
            this.dataGridViewCheckBoxColumn26,
            this.dataGridViewCheckBoxColumn27,
            this.dataGridViewCheckBoxColumn28,
            this.dataGridViewCheckBoxColumn29,
            this.dataGridViewCheckBoxColumn30,
            this.dataGridViewCheckBoxColumn31,
            this.dataGridViewCheckBoxColumn32,
            this.dataGridViewCheckBoxColumn33,
            this.dataGridViewCheckBoxColumn34,
            this.dataGridViewCheckBoxColumn35,
            this.dataGridViewCheckBoxColumn36,
            this.dataGridViewCheckBoxColumn37,
            this.dataGridViewCheckBoxColumn38,
            this.dataGridViewCheckBoxColumn39,
            this.dataGridViewCheckBoxColumn40,
            this.dataGridViewCheckBoxColumn41,
            this.dataGridViewCheckBoxColumn42,
            this.dataGridViewCheckBoxColumn43,
            this.dataGridViewCheckBoxColumn44,
            this.dataGridViewCheckBoxColumn45,
            this.dataGridViewCheckBoxColumn46,
            this.dataGridViewCheckBoxColumn47,
            this.dataGridViewCheckBoxColumn48,
            this.dataGridViewCheckBoxColumn49,
            this.dataGridViewCheckBoxColumn50,
            this.dataGridViewCheckBoxColumn51,
            this.dataGridViewCheckBoxColumn52,
            this.dataGridViewCheckBoxColumn53,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50});
            this.c_ClientesDataGridView.DataSource = this.BS_CClientes;
            this.c_ClientesDataGridView.Location = new System.Drawing.Point(19, 255);
            this.c_ClientesDataGridView.Name = "c_ClientesDataGridView";
            this.c_ClientesDataGridView.ReadOnly = true;
            this.c_ClientesDataGridView.RowHeadersVisible = false;
            this.c_ClientesDataGridView.Size = new System.Drawing.Size(392, 183);
            this.c_ClientesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn17.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 81;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TipoPersona";
            this.dataGridViewTextBoxColumn18.HeaderText = "TipoPersona";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Doc_ID";
            this.dataGridViewTextBoxColumn19.HeaderText = "Doc_ID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 81;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn20.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 81;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Cliente_Punt";
            this.dataGridViewTextBoxColumn21.HeaderText = "Cliente_Punt";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Benef_Punt";
            this.dataGridViewTextBoxColumn22.HeaderText = "Benef_Punt";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "InfGen_Punt";
            this.dataGridViewTextBoxColumn23.HeaderText = "InfGen_Punt";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ConstExped_Punt";
            this.dataGridViewTextBoxColumn24.HeaderText = "ConstExped_Punt";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn3.HeaderText = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "IG_PaisNacim";
            this.dataGridViewTextBoxColumn25.HeaderText = "IG_PaisNacim";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "IG_Nacionalidad";
            this.dataGridViewTextBoxColumn26.HeaderText = "IG_Nacionalidad";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IG_PaisResid";
            this.dataGridViewTextBoxColumn27.HeaderText = "IG_PaisResid";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "IG_Estado";
            this.dataGridViewTextBoxColumn28.HeaderText = "IG_Estado";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "IG_PEP";
            this.dataGridViewTextBoxColumn29.HeaderText = "IG_PEP";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Visible = false;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "IG_Profesion";
            this.dataGridViewTextBoxColumn30.HeaderText = "IG_Profesion";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "IG_TipDocID";
            this.dataGridViewTextBoxColumn31.HeaderText = "IG_TipDocID";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "IG_FecVencDocID";
            this.dataGridViewTextBoxColumn32.HeaderText = "IG_FecVencDocID";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "IG_TipoPersJur";
            this.dataGridViewTextBoxColumn33.HeaderText = "IG_TipoPersJur";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "IG_Edad";
            this.dataGridViewTextBoxColumn34.HeaderText = "IG_Edad";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "IG_ActivComer";
            this.dataGridViewTextBoxColumn35.HeaderText = "IG_ActivComer";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "IG_VolumOperac";
            this.dataGridViewTextBoxColumn36.HeaderText = "IG_VolumOperac";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Visible = false;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "IG_Criptomoneda";
            this.dataGridViewTextBoxColumn37.HeaderText = "IG_Criptomoneda";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Visible = false;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "IG_TipoEstructura";
            this.dataGridViewTextBoxColumn38.HeaderText = "IG_TipoEstructura";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "IG_Servicio1";
            this.dataGridViewCheckBoxColumn4.HeaderText = "IG_Servicio1";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "IG_Servicio2";
            this.dataGridViewCheckBoxColumn5.HeaderText = "IG_Servicio2";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Visible = false;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "IG_Servicio3";
            this.dataGridViewCheckBoxColumn6.HeaderText = "IG_Servicio3";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.ReadOnly = true;
            this.dataGridViewCheckBoxColumn6.Visible = false;
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "IG_Servicio4";
            this.dataGridViewCheckBoxColumn7.HeaderText = "IG_Servicio4";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.ReadOnly = true;
            this.dataGridViewCheckBoxColumn7.Visible = false;
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "IG_Servicio5";
            this.dataGridViewCheckBoxColumn8.HeaderText = "IG_Servicio5";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.ReadOnly = true;
            this.dataGridViewCheckBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "IG_Servicio6";
            this.dataGridViewCheckBoxColumn9.HeaderText = "IG_Servicio6";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.ReadOnly = true;
            this.dataGridViewCheckBoxColumn9.Visible = false;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "IG_Servicio7";
            this.dataGridViewCheckBoxColumn10.HeaderText = "IG_Servicio7";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.ReadOnly = true;
            this.dataGridViewCheckBoxColumn10.Visible = false;
            // 
            // dataGridViewCheckBoxColumn11
            // 
            this.dataGridViewCheckBoxColumn11.DataPropertyName = "IG_Servicio8";
            this.dataGridViewCheckBoxColumn11.HeaderText = "IG_Servicio8";
            this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
            this.dataGridViewCheckBoxColumn11.ReadOnly = true;
            this.dataGridViewCheckBoxColumn11.Visible = false;
            // 
            // dataGridViewCheckBoxColumn12
            // 
            this.dataGridViewCheckBoxColumn12.DataPropertyName = "IG_Servicio9";
            this.dataGridViewCheckBoxColumn12.HeaderText = "IG_Servicio9";
            this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
            this.dataGridViewCheckBoxColumn12.ReadOnly = true;
            this.dataGridViewCheckBoxColumn12.Visible = false;
            // 
            // dataGridViewCheckBoxColumn13
            // 
            this.dataGridViewCheckBoxColumn13.DataPropertyName = "IG_Servicio10";
            this.dataGridViewCheckBoxColumn13.HeaderText = "IG_Servicio10";
            this.dataGridViewCheckBoxColumn13.Name = "dataGridViewCheckBoxColumn13";
            this.dataGridViewCheckBoxColumn13.ReadOnly = true;
            this.dataGridViewCheckBoxColumn13.Visible = false;
            // 
            // dataGridViewCheckBoxColumn14
            // 
            this.dataGridViewCheckBoxColumn14.DataPropertyName = "IG_Producto1";
            this.dataGridViewCheckBoxColumn14.HeaderText = "IG_Producto1";
            this.dataGridViewCheckBoxColumn14.Name = "dataGridViewCheckBoxColumn14";
            this.dataGridViewCheckBoxColumn14.ReadOnly = true;
            this.dataGridViewCheckBoxColumn14.Visible = false;
            // 
            // dataGridViewCheckBoxColumn15
            // 
            this.dataGridViewCheckBoxColumn15.DataPropertyName = "IG_Producto2";
            this.dataGridViewCheckBoxColumn15.HeaderText = "IG_Producto2";
            this.dataGridViewCheckBoxColumn15.Name = "dataGridViewCheckBoxColumn15";
            this.dataGridViewCheckBoxColumn15.ReadOnly = true;
            this.dataGridViewCheckBoxColumn15.Visible = false;
            // 
            // dataGridViewCheckBoxColumn16
            // 
            this.dataGridViewCheckBoxColumn16.DataPropertyName = "IG_Producto3";
            this.dataGridViewCheckBoxColumn16.HeaderText = "IG_Producto3";
            this.dataGridViewCheckBoxColumn16.Name = "dataGridViewCheckBoxColumn16";
            this.dataGridViewCheckBoxColumn16.ReadOnly = true;
            this.dataGridViewCheckBoxColumn16.Visible = false;
            // 
            // dataGridViewCheckBoxColumn17
            // 
            this.dataGridViewCheckBoxColumn17.DataPropertyName = "IG_Producto4";
            this.dataGridViewCheckBoxColumn17.HeaderText = "IG_Producto4";
            this.dataGridViewCheckBoxColumn17.Name = "dataGridViewCheckBoxColumn17";
            this.dataGridViewCheckBoxColumn17.ReadOnly = true;
            this.dataGridViewCheckBoxColumn17.Visible = false;
            // 
            // dataGridViewCheckBoxColumn18
            // 
            this.dataGridViewCheckBoxColumn18.DataPropertyName = "IG_Producto5";
            this.dataGridViewCheckBoxColumn18.HeaderText = "IG_Producto5";
            this.dataGridViewCheckBoxColumn18.Name = "dataGridViewCheckBoxColumn18";
            this.dataGridViewCheckBoxColumn18.ReadOnly = true;
            this.dataGridViewCheckBoxColumn18.Visible = false;
            // 
            // dataGridViewCheckBoxColumn19
            // 
            this.dataGridViewCheckBoxColumn19.DataPropertyName = "IG_Producto6";
            this.dataGridViewCheckBoxColumn19.HeaderText = "IG_Producto6";
            this.dataGridViewCheckBoxColumn19.Name = "dataGridViewCheckBoxColumn19";
            this.dataGridViewCheckBoxColumn19.ReadOnly = true;
            this.dataGridViewCheckBoxColumn19.Visible = false;
            // 
            // dataGridViewCheckBoxColumn20
            // 
            this.dataGridViewCheckBoxColumn20.DataPropertyName = "IG_Producto7";
            this.dataGridViewCheckBoxColumn20.HeaderText = "IG_Producto7";
            this.dataGridViewCheckBoxColumn20.Name = "dataGridViewCheckBoxColumn20";
            this.dataGridViewCheckBoxColumn20.ReadOnly = true;
            this.dataGridViewCheckBoxColumn20.Visible = false;
            // 
            // dataGridViewCheckBoxColumn21
            // 
            this.dataGridViewCheckBoxColumn21.DataPropertyName = "IG_Producto8";
            this.dataGridViewCheckBoxColumn21.HeaderText = "IG_Producto8";
            this.dataGridViewCheckBoxColumn21.Name = "dataGridViewCheckBoxColumn21";
            this.dataGridViewCheckBoxColumn21.ReadOnly = true;
            this.dataGridViewCheckBoxColumn21.Visible = false;
            // 
            // dataGridViewCheckBoxColumn22
            // 
            this.dataGridViewCheckBoxColumn22.DataPropertyName = "IG_Producto9";
            this.dataGridViewCheckBoxColumn22.HeaderText = "IG_Producto9";
            this.dataGridViewCheckBoxColumn22.Name = "dataGridViewCheckBoxColumn22";
            this.dataGridViewCheckBoxColumn22.ReadOnly = true;
            this.dataGridViewCheckBoxColumn22.Visible = false;
            // 
            // dataGridViewCheckBoxColumn23
            // 
            this.dataGridViewCheckBoxColumn23.DataPropertyName = "IG_Producto10";
            this.dataGridViewCheckBoxColumn23.HeaderText = "IG_Producto10";
            this.dataGridViewCheckBoxColumn23.Name = "dataGridViewCheckBoxColumn23";
            this.dataGridViewCheckBoxColumn23.ReadOnly = true;
            this.dataGridViewCheckBoxColumn23.Visible = false;
            // 
            // dataGridViewCheckBoxColumn24
            // 
            this.dataGridViewCheckBoxColumn24.DataPropertyName = "CE_Opc1";
            this.dataGridViewCheckBoxColumn24.HeaderText = "CE_Opc1";
            this.dataGridViewCheckBoxColumn24.Name = "dataGridViewCheckBoxColumn24";
            this.dataGridViewCheckBoxColumn24.ReadOnly = true;
            this.dataGridViewCheckBoxColumn24.Visible = false;
            // 
            // dataGridViewCheckBoxColumn25
            // 
            this.dataGridViewCheckBoxColumn25.DataPropertyName = "CE_Opc2";
            this.dataGridViewCheckBoxColumn25.HeaderText = "CE_Opc2";
            this.dataGridViewCheckBoxColumn25.Name = "dataGridViewCheckBoxColumn25";
            this.dataGridViewCheckBoxColumn25.ReadOnly = true;
            this.dataGridViewCheckBoxColumn25.Visible = false;
            // 
            // dataGridViewCheckBoxColumn26
            // 
            this.dataGridViewCheckBoxColumn26.DataPropertyName = "CE_Opc3";
            this.dataGridViewCheckBoxColumn26.HeaderText = "CE_Opc3";
            this.dataGridViewCheckBoxColumn26.Name = "dataGridViewCheckBoxColumn26";
            this.dataGridViewCheckBoxColumn26.ReadOnly = true;
            this.dataGridViewCheckBoxColumn26.Visible = false;
            // 
            // dataGridViewCheckBoxColumn27
            // 
            this.dataGridViewCheckBoxColumn27.DataPropertyName = "CE_Opc4";
            this.dataGridViewCheckBoxColumn27.HeaderText = "CE_Opc4";
            this.dataGridViewCheckBoxColumn27.Name = "dataGridViewCheckBoxColumn27";
            this.dataGridViewCheckBoxColumn27.ReadOnly = true;
            this.dataGridViewCheckBoxColumn27.Visible = false;
            // 
            // dataGridViewCheckBoxColumn28
            // 
            this.dataGridViewCheckBoxColumn28.DataPropertyName = "CE_Opc5";
            this.dataGridViewCheckBoxColumn28.HeaderText = "CE_Opc5";
            this.dataGridViewCheckBoxColumn28.Name = "dataGridViewCheckBoxColumn28";
            this.dataGridViewCheckBoxColumn28.ReadOnly = true;
            this.dataGridViewCheckBoxColumn28.Visible = false;
            // 
            // dataGridViewCheckBoxColumn29
            // 
            this.dataGridViewCheckBoxColumn29.DataPropertyName = "CE_Opc6";
            this.dataGridViewCheckBoxColumn29.HeaderText = "CE_Opc6";
            this.dataGridViewCheckBoxColumn29.Name = "dataGridViewCheckBoxColumn29";
            this.dataGridViewCheckBoxColumn29.ReadOnly = true;
            this.dataGridViewCheckBoxColumn29.Visible = false;
            // 
            // dataGridViewCheckBoxColumn30
            // 
            this.dataGridViewCheckBoxColumn30.DataPropertyName = "CE_Opc7";
            this.dataGridViewCheckBoxColumn30.HeaderText = "CE_Opc7";
            this.dataGridViewCheckBoxColumn30.Name = "dataGridViewCheckBoxColumn30";
            this.dataGridViewCheckBoxColumn30.ReadOnly = true;
            this.dataGridViewCheckBoxColumn30.Visible = false;
            // 
            // dataGridViewCheckBoxColumn31
            // 
            this.dataGridViewCheckBoxColumn31.DataPropertyName = "CE_Opc8";
            this.dataGridViewCheckBoxColumn31.HeaderText = "CE_Opc8";
            this.dataGridViewCheckBoxColumn31.Name = "dataGridViewCheckBoxColumn31";
            this.dataGridViewCheckBoxColumn31.ReadOnly = true;
            this.dataGridViewCheckBoxColumn31.Visible = false;
            // 
            // dataGridViewCheckBoxColumn32
            // 
            this.dataGridViewCheckBoxColumn32.DataPropertyName = "CE_Opc9";
            this.dataGridViewCheckBoxColumn32.HeaderText = "CE_Opc9";
            this.dataGridViewCheckBoxColumn32.Name = "dataGridViewCheckBoxColumn32";
            this.dataGridViewCheckBoxColumn32.ReadOnly = true;
            this.dataGridViewCheckBoxColumn32.Visible = false;
            // 
            // dataGridViewCheckBoxColumn33
            // 
            this.dataGridViewCheckBoxColumn33.DataPropertyName = "CE_Opc10";
            this.dataGridViewCheckBoxColumn33.HeaderText = "CE_Opc10";
            this.dataGridViewCheckBoxColumn33.Name = "dataGridViewCheckBoxColumn33";
            this.dataGridViewCheckBoxColumn33.ReadOnly = true;
            this.dataGridViewCheckBoxColumn33.Visible = false;
            // 
            // dataGridViewCheckBoxColumn34
            // 
            this.dataGridViewCheckBoxColumn34.DataPropertyName = "CE_Opc11";
            this.dataGridViewCheckBoxColumn34.HeaderText = "CE_Opc11";
            this.dataGridViewCheckBoxColumn34.Name = "dataGridViewCheckBoxColumn34";
            this.dataGridViewCheckBoxColumn34.ReadOnly = true;
            this.dataGridViewCheckBoxColumn34.Visible = false;
            // 
            // dataGridViewCheckBoxColumn35
            // 
            this.dataGridViewCheckBoxColumn35.DataPropertyName = "CE_Opc12";
            this.dataGridViewCheckBoxColumn35.HeaderText = "CE_Opc12";
            this.dataGridViewCheckBoxColumn35.Name = "dataGridViewCheckBoxColumn35";
            this.dataGridViewCheckBoxColumn35.ReadOnly = true;
            this.dataGridViewCheckBoxColumn35.Visible = false;
            // 
            // dataGridViewCheckBoxColumn36
            // 
            this.dataGridViewCheckBoxColumn36.DataPropertyName = "CE_Opc13";
            this.dataGridViewCheckBoxColumn36.HeaderText = "CE_Opc13";
            this.dataGridViewCheckBoxColumn36.Name = "dataGridViewCheckBoxColumn36";
            this.dataGridViewCheckBoxColumn36.ReadOnly = true;
            this.dataGridViewCheckBoxColumn36.Visible = false;
            // 
            // dataGridViewCheckBoxColumn37
            // 
            this.dataGridViewCheckBoxColumn37.DataPropertyName = "CE_Opc14";
            this.dataGridViewCheckBoxColumn37.HeaderText = "CE_Opc14";
            this.dataGridViewCheckBoxColumn37.Name = "dataGridViewCheckBoxColumn37";
            this.dataGridViewCheckBoxColumn37.ReadOnly = true;
            this.dataGridViewCheckBoxColumn37.Visible = false;
            // 
            // dataGridViewCheckBoxColumn38
            // 
            this.dataGridViewCheckBoxColumn38.DataPropertyName = "CE_Opc15";
            this.dataGridViewCheckBoxColumn38.HeaderText = "CE_Opc15";
            this.dataGridViewCheckBoxColumn38.Name = "dataGridViewCheckBoxColumn38";
            this.dataGridViewCheckBoxColumn38.ReadOnly = true;
            this.dataGridViewCheckBoxColumn38.Visible = false;
            // 
            // dataGridViewCheckBoxColumn39
            // 
            this.dataGridViewCheckBoxColumn39.DataPropertyName = "CE_Opc16";
            this.dataGridViewCheckBoxColumn39.HeaderText = "CE_Opc16";
            this.dataGridViewCheckBoxColumn39.Name = "dataGridViewCheckBoxColumn39";
            this.dataGridViewCheckBoxColumn39.ReadOnly = true;
            this.dataGridViewCheckBoxColumn39.Visible = false;
            // 
            // dataGridViewCheckBoxColumn40
            // 
            this.dataGridViewCheckBoxColumn40.DataPropertyName = "CE_Opc17";
            this.dataGridViewCheckBoxColumn40.HeaderText = "CE_Opc17";
            this.dataGridViewCheckBoxColumn40.Name = "dataGridViewCheckBoxColumn40";
            this.dataGridViewCheckBoxColumn40.ReadOnly = true;
            this.dataGridViewCheckBoxColumn40.Visible = false;
            // 
            // dataGridViewCheckBoxColumn41
            // 
            this.dataGridViewCheckBoxColumn41.DataPropertyName = "CE_Opc18";
            this.dataGridViewCheckBoxColumn41.HeaderText = "CE_Opc18";
            this.dataGridViewCheckBoxColumn41.Name = "dataGridViewCheckBoxColumn41";
            this.dataGridViewCheckBoxColumn41.ReadOnly = true;
            this.dataGridViewCheckBoxColumn41.Visible = false;
            // 
            // dataGridViewCheckBoxColumn42
            // 
            this.dataGridViewCheckBoxColumn42.DataPropertyName = "CE_Opc19";
            this.dataGridViewCheckBoxColumn42.HeaderText = "CE_Opc19";
            this.dataGridViewCheckBoxColumn42.Name = "dataGridViewCheckBoxColumn42";
            this.dataGridViewCheckBoxColumn42.ReadOnly = true;
            this.dataGridViewCheckBoxColumn42.Visible = false;
            // 
            // dataGridViewCheckBoxColumn43
            // 
            this.dataGridViewCheckBoxColumn43.DataPropertyName = "CE_Opc20";
            this.dataGridViewCheckBoxColumn43.HeaderText = "CE_Opc20";
            this.dataGridViewCheckBoxColumn43.Name = "dataGridViewCheckBoxColumn43";
            this.dataGridViewCheckBoxColumn43.ReadOnly = true;
            this.dataGridViewCheckBoxColumn43.Visible = false;
            // 
            // dataGridViewCheckBoxColumn44
            // 
            this.dataGridViewCheckBoxColumn44.DataPropertyName = "CE_Opc21";
            this.dataGridViewCheckBoxColumn44.HeaderText = "CE_Opc21";
            this.dataGridViewCheckBoxColumn44.Name = "dataGridViewCheckBoxColumn44";
            this.dataGridViewCheckBoxColumn44.ReadOnly = true;
            this.dataGridViewCheckBoxColumn44.Visible = false;
            // 
            // dataGridViewCheckBoxColumn45
            // 
            this.dataGridViewCheckBoxColumn45.DataPropertyName = "CE_Opc22";
            this.dataGridViewCheckBoxColumn45.HeaderText = "CE_Opc22";
            this.dataGridViewCheckBoxColumn45.Name = "dataGridViewCheckBoxColumn45";
            this.dataGridViewCheckBoxColumn45.ReadOnly = true;
            this.dataGridViewCheckBoxColumn45.Visible = false;
            // 
            // dataGridViewCheckBoxColumn46
            // 
            this.dataGridViewCheckBoxColumn46.DataPropertyName = "CE_Opc23";
            this.dataGridViewCheckBoxColumn46.HeaderText = "CE_Opc23";
            this.dataGridViewCheckBoxColumn46.Name = "dataGridViewCheckBoxColumn46";
            this.dataGridViewCheckBoxColumn46.ReadOnly = true;
            this.dataGridViewCheckBoxColumn46.Visible = false;
            // 
            // dataGridViewCheckBoxColumn47
            // 
            this.dataGridViewCheckBoxColumn47.DataPropertyName = "CE_Opc24";
            this.dataGridViewCheckBoxColumn47.HeaderText = "CE_Opc24";
            this.dataGridViewCheckBoxColumn47.Name = "dataGridViewCheckBoxColumn47";
            this.dataGridViewCheckBoxColumn47.ReadOnly = true;
            this.dataGridViewCheckBoxColumn47.Visible = false;
            // 
            // dataGridViewCheckBoxColumn48
            // 
            this.dataGridViewCheckBoxColumn48.DataPropertyName = "CE_Opc25";
            this.dataGridViewCheckBoxColumn48.HeaderText = "CE_Opc25";
            this.dataGridViewCheckBoxColumn48.Name = "dataGridViewCheckBoxColumn48";
            this.dataGridViewCheckBoxColumn48.ReadOnly = true;
            this.dataGridViewCheckBoxColumn48.Visible = false;
            // 
            // dataGridViewCheckBoxColumn49
            // 
            this.dataGridViewCheckBoxColumn49.DataPropertyName = "CE_Opc26";
            this.dataGridViewCheckBoxColumn49.HeaderText = "CE_Opc26";
            this.dataGridViewCheckBoxColumn49.Name = "dataGridViewCheckBoxColumn49";
            this.dataGridViewCheckBoxColumn49.ReadOnly = true;
            this.dataGridViewCheckBoxColumn49.Visible = false;
            // 
            // dataGridViewCheckBoxColumn50
            // 
            this.dataGridViewCheckBoxColumn50.DataPropertyName = "CE_Opc27";
            this.dataGridViewCheckBoxColumn50.HeaderText = "CE_Opc27";
            this.dataGridViewCheckBoxColumn50.Name = "dataGridViewCheckBoxColumn50";
            this.dataGridViewCheckBoxColumn50.ReadOnly = true;
            this.dataGridViewCheckBoxColumn50.Visible = false;
            // 
            // dataGridViewCheckBoxColumn51
            // 
            this.dataGridViewCheckBoxColumn51.DataPropertyName = "CE_Opc28";
            this.dataGridViewCheckBoxColumn51.HeaderText = "CE_Opc28";
            this.dataGridViewCheckBoxColumn51.Name = "dataGridViewCheckBoxColumn51";
            this.dataGridViewCheckBoxColumn51.ReadOnly = true;
            this.dataGridViewCheckBoxColumn51.Visible = false;
            // 
            // dataGridViewCheckBoxColumn52
            // 
            this.dataGridViewCheckBoxColumn52.DataPropertyName = "CE_Opc29";
            this.dataGridViewCheckBoxColumn52.HeaderText = "CE_Opc29";
            this.dataGridViewCheckBoxColumn52.Name = "dataGridViewCheckBoxColumn52";
            this.dataGridViewCheckBoxColumn52.ReadOnly = true;
            this.dataGridViewCheckBoxColumn52.Visible = false;
            // 
            // dataGridViewCheckBoxColumn53
            // 
            this.dataGridViewCheckBoxColumn53.DataPropertyName = "CE_Opc30";
            this.dataGridViewCheckBoxColumn53.HeaderText = "CE_Opc30";
            this.dataGridViewCheckBoxColumn53.Name = "dataGridViewCheckBoxColumn53";
            this.dataGridViewCheckBoxColumn53.ReadOnly = true;
            this.dataGridViewCheckBoxColumn53.Visible = false;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Observacion";
            this.dataGridViewTextBoxColumn39.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Visible = false;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Ejecutivo";
            this.dataGridViewTextBoxColumn40.HeaderText = "Ejecutivo";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Visible = false;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "NivelRiesgo";
            this.dataGridViewTextBoxColumn41.HeaderText = "NivelRiesgo";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Visible = false;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "PerfilFinanciero";
            this.dataGridViewTextBoxColumn42.HeaderText = "PerfilFinanciero";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Visible = false;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "PeriodUsoCta";
            this.dataGridViewTextBoxColumn43.HeaderText = "PeriodUsoCta";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Visible = false;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "NroTransacciones";
            this.dataGridViewTextBoxColumn44.HeaderText = "NroTransacciones";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Visible = false;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Fec_UltimAct";
            this.dataGridViewTextBoxColumn45.HeaderText = "Fec_UltimAct";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Visible = false;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Trim_Mes";
            this.dataGridViewTextBoxColumn46.HeaderText = "Trim_Mes";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Visible = false;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Trim_Ano";
            this.dataGridViewTextBoxColumn47.HeaderText = "Trim_Ano";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Visible = false;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Trim_NroOperac";
            this.dataGridViewTextBoxColumn48.HeaderText = "Trim_NroOperac";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Visible = false;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Trim_MontoOperac";
            this.dataGridViewTextBoxColumn49.HeaderText = "Trim_MontoOperac";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Visible = false;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "MapaEmpresa";
            this.dataGridViewTextBoxColumn50.HeaderText = "MapaEmpresa";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Visible = false;
            // 
            // Pag2
            // 
            this.Pag2.AutoScroll = true;
            this.Pag2.Controls.Add(this.Pan_BenefBtns);
            this.Pag2.Controls.Add(Lbl_BenefVincEmpresa);
            this.Pag2.Controls.Add(Lbl_BenefCriptomonedas);
            this.Pag2.Controls.Add(this.Cmb_BenefCriptomonedas);
            this.Pag2.Controls.Add(this.Lbl_BenefEtiqPuntuacion);
            this.Pag2.Controls.Add(this.Lbl_BenefPuntuacion);
            this.Pag2.Controls.Add(Lbl_BenefPEP);
            this.Pag2.Controls.Add(this.Cmb_BenefPEP);
            this.Pag2.Controls.Add(Lbl_BenefVincPorcent);
            this.Pag2.Controls.Add(this.Nud_BenefVincPorcent);
            this.Pag2.Controls.Add(this.Cmb_BenefVincEmpresa);
            this.Pag2.Controls.Add(Lbl_BenefProfesion);
            this.Pag2.Controls.Add(this.Cmb_BenefProfesion);
            this.Pag2.Controls.Add(Lbl_BenefEdad);
            this.Pag2.Controls.Add(this.Cmb_BenefEdad);
            this.Pag2.Controls.Add(Lbl_BenefEstado);
            this.Pag2.Controls.Add(this.Cmb_BenefEstado);
            this.Pag2.Controls.Add(Lbl_BenefPaisResid);
            this.Pag2.Controls.Add(this.Cmb_BenefPaisResid);
            this.Pag2.Controls.Add(Lbl_BenefNacionalidad);
            this.Pag2.Controls.Add(this.Cmb_BenefNacionalidad);
            this.Pag2.Controls.Add(Lbl_BenefPaisNacim);
            this.Pag2.Controls.Add(this.Cmb_BenefPaisNacim);
            this.Pag2.Controls.Add(Lbl_BenefFecVenc);
            this.Pag2.Controls.Add(this.Dtp_BenefFec_Venc);
            this.Pag2.Controls.Add(Lbl_BenefDoc_ID);
            this.Pag2.Controls.Add(this.Txt_BenefDoc_ID);
            this.Pag2.Controls.Add(Lbl_NmeBeneficiario);
            this.Pag2.Controls.Add(this.Txt_BenefNme);
            this.Pag2.Controls.Add(this.Grp_BenfTipoVinculacion);
            this.Pag2.Controls.Add(Lbl_TipoVinculo);
            this.Pag2.Controls.Add(this.tipoVinculoTextBox);
            this.Pag2.Controls.Add(this.Grd_CFirBenAcc);
            this.Pag2.Location = new System.Drawing.Point(4, 25);
            this.Pag2.Name = "Pag2";
            this.Pag2.Padding = new System.Windows.Forms.Padding(3);
            this.Pag2.Size = new System.Drawing.Size(1063, 453);
            this.Pag2.TabIndex = 1;
            this.Pag2.Text = "Beneficiarios / Autorizados : 2";
            this.Pag2.UseVisualStyleBackColor = true;
            // 
            // Pan_BenefBtns
            // 
            this.Pan_BenefBtns.Controls.Add(this.Btn_BenefIncluir);
            this.Pan_BenefBtns.Controls.Add(this.Btn_BenefEliminar);
            this.Pan_BenefBtns.Controls.Add(this.Btn_BenefModificar);
            this.Pan_BenefBtns.Controls.Add(this.Btn_BenefAceptar);
            this.Pan_BenefBtns.Controls.Add(this.Btn_BenefCancelar);
            this.Pan_BenefBtns.Location = new System.Drawing.Point(88, 389);
            this.Pan_BenefBtns.Name = "Pan_BenefBtns";
            this.Pan_BenefBtns.Size = new System.Drawing.Size(809, 54);
            this.Pan_BenefBtns.TabIndex = 62;
            this.Pan_BenefBtns.Visible = false;
            // 
            // Btn_BenefIncluir
            // 
            this.Btn_BenefIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BenefIncluir.BackgroundImage")));
            this.Btn_BenefIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_BenefIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BenefIncluir.FlatAppearance.BorderSize = 0;
            this.Btn_BenefIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BenefIncluir.Location = new System.Drawing.Point(23, 4);
            this.Btn_BenefIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefIncluir.Name = "Btn_BenefIncluir";
            this.Btn_BenefIncluir.Size = new System.Drawing.Size(38, 38);
            this.Btn_BenefIncluir.TabIndex = 59;
            this.Btn_BenefIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefIncluir.UseVisualStyleBackColor = true;
            // 
            // Btn_BenefEliminar
            // 
            this.Btn_BenefEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BenefEliminar.BackgroundImage")));
            this.Btn_BenefEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_BenefEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BenefEliminar.FlatAppearance.BorderSize = 0;
            this.Btn_BenefEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BenefEliminar.Location = new System.Drawing.Point(154, 4);
            this.Btn_BenefEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefEliminar.Name = "Btn_BenefEliminar";
            this.Btn_BenefEliminar.Size = new System.Drawing.Size(38, 38);
            this.Btn_BenefEliminar.TabIndex = 61;
            this.Btn_BenefEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefEliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_BenefModificar
            // 
            this.Btn_BenefModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BenefModificar.BackgroundImage")));
            this.Btn_BenefModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_BenefModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BenefModificar.FlatAppearance.BorderSize = 0;
            this.Btn_BenefModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BenefModificar.Location = new System.Drawing.Point(88, 4);
            this.Btn_BenefModificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefModificar.Name = "Btn_BenefModificar";
            this.Btn_BenefModificar.Size = new System.Drawing.Size(38, 38);
            this.Btn_BenefModificar.TabIndex = 60;
            this.Btn_BenefModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefModificar.UseVisualStyleBackColor = true;
            // 
            // Btn_BenefAceptar
            // 
            this.Btn_BenefAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BenefAceptar.BackgroundImage")));
            this.Btn_BenefAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_BenefAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BenefAceptar.FlatAppearance.BorderSize = 0;
            this.Btn_BenefAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BenefAceptar.Location = new System.Drawing.Point(661, 4);
            this.Btn_BenefAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefAceptar.Name = "Btn_BenefAceptar";
            this.Btn_BenefAceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_BenefAceptar.TabIndex = 57;
            this.Btn_BenefAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefAceptar.UseVisualStyleBackColor = true;
            // 
            // Btn_BenefCancelar
            // 
            this.Btn_BenefCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_BenefCancelar.BackgroundImage")));
            this.Btn_BenefCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_BenefCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BenefCancelar.FlatAppearance.BorderSize = 0;
            this.Btn_BenefCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_BenefCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BenefCancelar.Location = new System.Drawing.Point(723, 4);
            this.Btn_BenefCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefCancelar.Name = "Btn_BenefCancelar";
            this.Btn_BenefCancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_BenefCancelar.TabIndex = 58;
            this.Btn_BenefCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefCancelar.UseVisualStyleBackColor = true;
            // 
            // Cmb_BenefCriptomonedas
            // 
            this.Cmb_BenefCriptomonedas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Criptomoneda", true));
            this.Cmb_BenefCriptomonedas.FormattingEnabled = true;
            this.Cmb_BenefCriptomonedas.Location = new System.Drawing.Point(599, 303);
            this.Cmb_BenefCriptomonedas.Name = "Cmb_BenefCriptomonedas";
            this.Cmb_BenefCriptomonedas.Size = new System.Drawing.Size(242, 24);
            this.Cmb_BenefCriptomonedas.TabIndex = 59;
            // 
            // BS_CFirBenAcc
            // 
            this.BS_CFirBenAcc.DataMember = "C_FirBenAcc";
            this.BS_CFirBenAcc.DataSource = this.DS_MonitorOperaciones;
            // 
            // Lbl_BenefEtiqPuntuacion
            // 
            this.Lbl_BenefEtiqPuntuacion.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BenefEtiqPuntuacion.Location = new System.Drawing.Point(968, 11);
            this.Lbl_BenefEtiqPuntuacion.Name = "Lbl_BenefEtiqPuntuacion";
            this.Lbl_BenefEtiqPuntuacion.Size = new System.Drawing.Size(60, 12);
            this.Lbl_BenefEtiqPuntuacion.TabIndex = 54;
            this.Lbl_BenefEtiqPuntuacion.Text = "Puntuación";
            this.Lbl_BenefEtiqPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_BenefPuntuacion
            // 
            this.Lbl_BenefPuntuacion.BackColor = System.Drawing.Color.Black;
            this.Lbl_BenefPuntuacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_BenefPuntuacion.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BenefPuntuacion.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_BenefPuntuacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lbl_BenefPuntuacion.Location = new System.Drawing.Point(966, 9);
            this.Lbl_BenefPuntuacion.Name = "Lbl_BenefPuntuacion";
            this.Lbl_BenefPuntuacion.Size = new System.Drawing.Size(65, 70);
            this.Lbl_BenefPuntuacion.TabIndex = 53;
            this.Lbl_BenefPuntuacion.Text = "2";
            this.Lbl_BenefPuntuacion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Cmb_BenefPEP
            // 
            this.Cmb_BenefPEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "PEP", true));
            this.Cmb_BenefPEP.FormattingEnabled = true;
            this.Cmb_BenefPEP.Location = new System.Drawing.Point(859, 243);
            this.Cmb_BenefPEP.Name = "Cmb_BenefPEP";
            this.Cmb_BenefPEP.Size = new System.Drawing.Size(172, 24);
            this.Cmb_BenefPEP.TabIndex = 29;
            // 
            // Nud_BenefVincPorcent
            // 
            this.Nud_BenefVincPorcent.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CFirBenAcc, "VincPorcent", true));
            this.Nud_BenefVincPorcent.Location = new System.Drawing.Point(599, 361);
            this.Nud_BenefVincPorcent.Name = "Nud_BenefVincPorcent";
            this.Nud_BenefVincPorcent.Size = new System.Drawing.Size(74, 22);
            this.Nud_BenefVincPorcent.TabIndex = 27;
            // 
            // Cmb_BenefVincEmpresa
            // 
            this.Cmb_BenefVincEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "VincEmpresa", true));
            this.Cmb_BenefVincEmpresa.Location = new System.Drawing.Point(599, 333);
            this.Cmb_BenefVincEmpresa.Name = "Cmb_BenefVincEmpresa";
            this.Cmb_BenefVincEmpresa.Size = new System.Drawing.Size(432, 22);
            this.Cmb_BenefVincEmpresa.TabIndex = 25;
            // 
            // Cmb_BenefProfesion
            // 
            this.Cmb_BenefProfesion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Profesion", true));
            this.Cmb_BenefProfesion.FormattingEnabled = true;
            this.Cmb_BenefProfesion.Location = new System.Drawing.Point(599, 273);
            this.Cmb_BenefProfesion.Name = "Cmb_BenefProfesion";
            this.Cmb_BenefProfesion.Size = new System.Drawing.Size(432, 24);
            this.Cmb_BenefProfesion.TabIndex = 21;
            // 
            // Cmb_BenefEdad
            // 
            this.Cmb_BenefEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Edad", true));
            this.Cmb_BenefEdad.FormattingEnabled = true;
            this.Cmb_BenefEdad.Location = new System.Drawing.Point(859, 183);
            this.Cmb_BenefEdad.Name = "Cmb_BenefEdad";
            this.Cmb_BenefEdad.Size = new System.Drawing.Size(172, 24);
            this.Cmb_BenefEdad.TabIndex = 19;
            // 
            // Cmb_BenefEstado
            // 
            this.Cmb_BenefEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Estado", true));
            this.Cmb_BenefEstado.FormattingEnabled = true;
            this.Cmb_BenefEstado.Location = new System.Drawing.Point(599, 243);
            this.Cmb_BenefEstado.Name = "Cmb_BenefEstado";
            this.Cmb_BenefEstado.Size = new System.Drawing.Size(242, 24);
            this.Cmb_BenefEstado.TabIndex = 17;
            // 
            // Cmb_BenefPaisResid
            // 
            this.Cmb_BenefPaisResid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "PaisResid", true));
            this.Cmb_BenefPaisResid.FormattingEnabled = true;
            this.Cmb_BenefPaisResid.Location = new System.Drawing.Point(599, 213);
            this.Cmb_BenefPaisResid.Name = "Cmb_BenefPaisResid";
            this.Cmb_BenefPaisResid.Size = new System.Drawing.Size(242, 24);
            this.Cmb_BenefPaisResid.TabIndex = 15;
            // 
            // Cmb_BenefNacionalidad
            // 
            this.Cmb_BenefNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Nacionalidad", true));
            this.Cmb_BenefNacionalidad.FormattingEnabled = true;
            this.Cmb_BenefNacionalidad.Location = new System.Drawing.Point(599, 183);
            this.Cmb_BenefNacionalidad.Name = "Cmb_BenefNacionalidad";
            this.Cmb_BenefNacionalidad.Size = new System.Drawing.Size(242, 24);
            this.Cmb_BenefNacionalidad.TabIndex = 13;
            // 
            // Cmb_BenefPaisNacim
            // 
            this.Cmb_BenefPaisNacim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "PaisNacim", true));
            this.Cmb_BenefPaisNacim.FormattingEnabled = true;
            this.Cmb_BenefPaisNacim.Location = new System.Drawing.Point(599, 153);
            this.Cmb_BenefPaisNacim.Name = "Cmb_BenefPaisNacim";
            this.Cmb_BenefPaisNacim.Size = new System.Drawing.Size(242, 24);
            this.Cmb_BenefPaisNacim.TabIndex = 11;
            // 
            // Dtp_BenefFec_Venc
            // 
            this.Dtp_BenefFec_Venc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CFirBenAcc, "Fec_Vencimiento", true));
            this.Dtp_BenefFec_Venc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_BenefFec_Venc.Location = new System.Drawing.Point(903, 125);
            this.Dtp_BenefFec_Venc.Name = "Dtp_BenefFec_Venc";
            this.Dtp_BenefFec_Venc.Size = new System.Drawing.Size(128, 22);
            this.Dtp_BenefFec_Venc.TabIndex = 9;
            this.Dtp_BenefFec_Venc.Value = new System.DateTime(2018, 12, 30, 20, 18, 49, 0);
            // 
            // Txt_BenefDoc_ID
            // 
            this.Txt_BenefDoc_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Doc_ID", true));
            this.Txt_BenefDoc_ID.Location = new System.Drawing.Point(599, 125);
            this.Txt_BenefDoc_ID.Name = "Txt_BenefDoc_ID";
            this.Txt_BenefDoc_ID.Size = new System.Drawing.Size(130, 22);
            this.Txt_BenefDoc_ID.TabIndex = 7;
            // 
            // Txt_BenefNme
            // 
            this.Txt_BenefNme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Nombre", true));
            this.Txt_BenefNme.Location = new System.Drawing.Point(599, 97);
            this.Txt_BenefNme.Name = "Txt_BenefNme";
            this.Txt_BenefNme.Size = new System.Drawing.Size(432, 22);
            this.Txt_BenefNme.TabIndex = 5;
            // 
            // Grp_BenfTipoVinculacion
            // 
            this.Grp_BenfTipoVinculacion.Controls.Add(this.Opc_TipVinc3);
            this.Grp_BenfTipoVinculacion.Controls.Add(this.Opc_TipVinc2);
            this.Grp_BenfTipoVinculacion.Controls.Add(this.Opc_TipVinc1);
            this.Grp_BenfTipoVinculacion.Location = new System.Drawing.Point(599, 14);
            this.Grp_BenfTipoVinculacion.Name = "Grp_BenfTipoVinculacion";
            this.Grp_BenfTipoVinculacion.Size = new System.Drawing.Size(188, 77);
            this.Grp_BenfTipoVinculacion.TabIndex = 3;
            this.Grp_BenfTipoVinculacion.TabStop = false;
            // 
            // Opc_TipVinc3
            // 
            this.Opc_TipVinc3.AutoSize = true;
            this.Opc_TipVinc3.Location = new System.Drawing.Point(7, 49);
            this.Opc_TipVinc3.Name = "Opc_TipVinc3";
            this.Opc_TipVinc3.Size = new System.Drawing.Size(90, 20);
            this.Opc_TipVinc3.TabIndex = 2;
            this.Opc_TipVinc3.TabStop = true;
            this.Opc_TipVinc3.Text = "Cónyugue";
            this.Opc_TipVinc3.UseVisualStyleBackColor = true;
            // 
            // Opc_TipVinc2
            // 
            this.Opc_TipVinc2.AutoSize = true;
            this.Opc_TipVinc2.Location = new System.Drawing.Point(7, 30);
            this.Opc_TipVinc2.Name = "Opc_TipVinc2";
            this.Opc_TipVinc2.Size = new System.Drawing.Size(90, 20);
            this.Opc_TipVinc2.TabIndex = 1;
            this.Opc_TipVinc2.TabStop = true;
            this.Opc_TipVinc2.Text = "Firmante";
            this.Opc_TipVinc2.UseVisualStyleBackColor = true;
            // 
            // Opc_TipVinc1
            // 
            this.Opc_TipVinc1.AutoSize = true;
            this.Opc_TipVinc1.Location = new System.Drawing.Point(7, 11);
            this.Opc_TipVinc1.Name = "Opc_TipVinc1";
            this.Opc_TipVinc1.Size = new System.Drawing.Size(170, 20);
            this.Opc_TipVinc1.TabIndex = 0;
            this.Opc_TipVinc1.TabStop = true;
            this.Opc_TipVinc1.Text = "Beneficiario Final";
            this.Opc_TipVinc1.UseVisualStyleBackColor = true;
            // 
            // tipoVinculoTextBox
            // 
            this.tipoVinculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "TipoVinculo", true));
            this.tipoVinculoTextBox.Location = new System.Drawing.Point(477, 48);
            this.tipoVinculoTextBox.Name = "tipoVinculoTextBox";
            this.tipoVinculoTextBox.Size = new System.Drawing.Size(46, 22);
            this.tipoVinculoTextBox.TabIndex = 2;
            // 
            // Grd_CFirBenAcc
            // 
            this.Grd_CFirBenAcc.AllowUserToAddRows = false;
            this.Grd_CFirBenAcc.AllowUserToDeleteRows = false;
            this.Grd_CFirBenAcc.AutoGenerateColumns = false;
            this.Grd_CFirBenAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_CFirBenAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewCheckBoxColumn1});
            this.Grd_CFirBenAcc.DataSource = this.BS_CFirBenAcc;
            this.Grd_CFirBenAcc.Location = new System.Drawing.Point(11, 44);
            this.Grd_CFirBenAcc.MultiSelect = false;
            this.Grd_CFirBenAcc.Name = "Grd_CFirBenAcc";
            this.Grd_CFirBenAcc.ReadOnly = true;
            this.Grd_CFirBenAcc.RowHeadersVisible = false;
            this.Grd_CFirBenAcc.Size = new System.Drawing.Size(404, 339);
            this.Grd_CFirBenAcc.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoVinculo";
            this.dataGridViewTextBoxColumn2.HeaderText = "TipoVinculo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Doc_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Doc_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fec_Vencimiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fec_Vencimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PaisNacim";
            this.dataGridViewTextBoxColumn7.HeaderText = "PaisNacim";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nacionalidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nacionalidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PaisResid";
            this.dataGridViewTextBoxColumn9.HeaderText = "PaisResid";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Profesion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Profesion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Criptomoneda";
            this.dataGridViewTextBoxColumn12.HeaderText = "Criptomoneda";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "VincEmpresa";
            this.dataGridViewTextBoxColumn13.HeaderText = "VincEmpresa";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "VincPorcent";
            this.dataGridViewTextBoxColumn14.HeaderText = "VincPorcent";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PEP";
            this.dataGridViewTextBoxColumn15.HeaderText = "PEP";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Puntuacion";
            this.dataGridViewTextBoxColumn16.HeaderText = "Puntuacion";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // Pag3
            // 
            this.Pag3.AutoScroll = true;
            this.Pag3.Controls.Add(this.Chk_Opc30);
            this.Pag3.Controls.Add(this.Chk_Opc29);
            this.Pag3.Controls.Add(this.Chk_Opc28);
            this.Pag3.Controls.Add(this.Chk_Opc27);
            this.Pag3.Controls.Add(this.Chk_Opc26);
            this.Pag3.Controls.Add(this.Chk_Opc25);
            this.Pag3.Controls.Add(this.Chk_Opc24);
            this.Pag3.Controls.Add(this.Chk_Opc23);
            this.Pag3.Controls.Add(this.Chk_Opc22);
            this.Pag3.Controls.Add(this.Chk_Opc21);
            this.Pag3.Controls.Add(this.Chk_Opc20);
            this.Pag3.Controls.Add(this.Chk_Opc19);
            this.Pag3.Controls.Add(this.Chk_Opc18);
            this.Pag3.Controls.Add(this.Chk_Opc17);
            this.Pag3.Controls.Add(this.Chk_Opc16);
            this.Pag3.Controls.Add(this.Chk_Opc15);
            this.Pag3.Controls.Add(this.Chk_Opc14);
            this.Pag3.Controls.Add(this.Chk_Opc13);
            this.Pag3.Controls.Add(this.Chk_Opc12);
            this.Pag3.Controls.Add(this.Chk_Opc11);
            this.Pag3.Controls.Add(this.Chk_Opc10);
            this.Pag3.Controls.Add(this.Chk_Opc9);
            this.Pag3.Controls.Add(this.Chk_Opc8);
            this.Pag3.Controls.Add(this.Chk_Opc7);
            this.Pag3.Controls.Add(this.Chk_Opc6);
            this.Pag3.Controls.Add(this.Chk_Opc5);
            this.Pag3.Controls.Add(this.Chk_Opc4);
            this.Pag3.Controls.Add(this.Chk_Opc3);
            this.Pag3.Controls.Add(this.Chk_Opc2);
            this.Pag3.Controls.Add(this.Chk_Opc1);
            this.Pag3.Location = new System.Drawing.Point(4, 25);
            this.Pag3.Name = "Pag3";
            this.Pag3.Padding = new System.Windows.Forms.Padding(3);
            this.Pag3.Size = new System.Drawing.Size(1063, 453);
            this.Pag3.TabIndex = 2;
            this.Pag3.Text = "Constitución del Expediente";
            this.Pag3.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc30
            // 
            this.Chk_Opc30.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc30", true));
            this.Chk_Opc30.Location = new System.Drawing.Point(562, 376);
            this.Chk_Opc30.Name = "Chk_Opc30";
            this.Chk_Opc30.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc30.TabIndex = 44;
            this.Chk_Opc30.Text = "OPC30";
            this.Chk_Opc30.UseVisualStyleBackColor = true;
            this.Chk_Opc30.Visible = false;
            // 
            // Chk_Opc29
            // 
            this.Chk_Opc29.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc29", true));
            this.Chk_Opc29.Location = new System.Drawing.Point(562, 351);
            this.Chk_Opc29.Name = "Chk_Opc29";
            this.Chk_Opc29.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc29.TabIndex = 42;
            this.Chk_Opc29.Text = "OPC29";
            this.Chk_Opc29.UseVisualStyleBackColor = true;
            this.Chk_Opc29.Visible = false;
            // 
            // Chk_Opc28
            // 
            this.Chk_Opc28.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc28", true));
            this.Chk_Opc28.Location = new System.Drawing.Point(562, 326);
            this.Chk_Opc28.Name = "Chk_Opc28";
            this.Chk_Opc28.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc28.TabIndex = 40;
            this.Chk_Opc28.Text = "OPC28";
            this.Chk_Opc28.UseVisualStyleBackColor = true;
            this.Chk_Opc28.Visible = false;
            // 
            // Chk_Opc27
            // 
            this.Chk_Opc27.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc27", true));
            this.Chk_Opc27.Location = new System.Drawing.Point(562, 301);
            this.Chk_Opc27.Name = "Chk_Opc27";
            this.Chk_Opc27.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc27.TabIndex = 38;
            this.Chk_Opc27.Text = "Datos del Cónyugue o Cotitular";
            this.Chk_Opc27.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc26
            // 
            this.Chk_Opc26.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc26", true));
            this.Chk_Opc26.Location = new System.Drawing.Point(562, 276);
            this.Chk_Opc26.Name = "Chk_Opc26";
            this.Chk_Opc26.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc26.TabIndex = 36;
            this.Chk_Opc26.Text = "Lugar y Fecha de Nacimiento";
            this.Chk_Opc26.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc25
            // 
            this.Chk_Opc25.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc25", true));
            this.Chk_Opc25.Location = new System.Drawing.Point(562, 251);
            this.Chk_Opc25.Name = "Chk_Opc25";
            this.Chk_Opc25.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc25.TabIndex = 34;
            this.Chk_Opc25.Text = "Tipo de Negocio";
            this.Chk_Opc25.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc24
            // 
            this.Chk_Opc24.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc24", true));
            this.Chk_Opc24.Location = new System.Drawing.Point(562, 226);
            this.Chk_Opc24.Name = "Chk_Opc24";
            this.Chk_Opc24.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc24.TabIndex = 33;
            this.Chk_Opc24.Text = "Cargo";
            this.Chk_Opc24.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc23
            // 
            this.Chk_Opc23.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc23", true));
            this.Chk_Opc23.Location = new System.Drawing.Point(562, 201);
            this.Chk_Opc23.Name = "Chk_Opc23";
            this.Chk_Opc23.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc23.TabIndex = 32;
            this.Chk_Opc23.Text = "Referencias Bancarias, Comerciales y/o Personales";
            this.Chk_Opc23.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc22
            // 
            this.Chk_Opc22.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc22", true));
            this.Chk_Opc22.Location = new System.Drawing.Point(562, 176);
            this.Chk_Opc22.Name = "Chk_Opc22";
            this.Chk_Opc22.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc22.TabIndex = 31;
            this.Chk_Opc22.Text = "Teléfono Laboral";
            this.Chk_Opc22.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc21
            // 
            this.Chk_Opc21.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc21", true));
            this.Chk_Opc21.Location = new System.Drawing.Point(562, 151);
            this.Chk_Opc21.Name = "Chk_Opc21";
            this.Chk_Opc21.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc21.TabIndex = 30;
            this.Chk_Opc21.Text = "Dirección Laboral";
            this.Chk_Opc21.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc20
            // 
            this.Chk_Opc20.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc20", true));
            this.Chk_Opc20.Location = new System.Drawing.Point(562, 126);
            this.Chk_Opc20.Name = "Chk_Opc20";
            this.Chk_Opc20.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc20.TabIndex = 29;
            this.Chk_Opc20.Text = "Estado Civil";
            this.Chk_Opc20.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc19
            // 
            this.Chk_Opc19.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc19", true));
            this.Chk_Opc19.Location = new System.Drawing.Point(562, 101);
            this.Chk_Opc19.Name = "Chk_Opc19";
            this.Chk_Opc19.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc19.TabIndex = 28;
            this.Chk_Opc19.Text = "Nacionalidad";
            this.Chk_Opc19.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc18
            // 
            this.Chk_Opc18.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc18", true));
            this.Chk_Opc18.Location = new System.Drawing.Point(562, 76);
            this.Chk_Opc18.Name = "Chk_Opc18";
            this.Chk_Opc18.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc18.TabIndex = 27;
            this.Chk_Opc18.Text = "Email";
            this.Chk_Opc18.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc17
            // 
            this.Chk_Opc17.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc17", true));
            this.Chk_Opc17.Location = new System.Drawing.Point(562, 51);
            this.Chk_Opc17.Name = "Chk_Opc17";
            this.Chk_Opc17.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc17.TabIndex = 26;
            this.Chk_Opc17.Text = "W9";
            this.Chk_Opc17.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc16
            // 
            this.Chk_Opc16.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc16", true));
            this.Chk_Opc16.Location = new System.Drawing.Point(562, 26);
            this.Chk_Opc16.Name = "Chk_Opc16";
            this.Chk_Opc16.Size = new System.Drawing.Size(476, 24);
            this.Chk_Opc16.TabIndex = 25;
            this.Chk_Opc16.Text = "W8BEN";
            this.Chk_Opc16.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc15
            // 
            this.Chk_Opc15.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc15", true));
            this.Chk_Opc15.Location = new System.Drawing.Point(27, 376);
            this.Chk_Opc15.Name = "Chk_Opc15";
            this.Chk_Opc15.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc15.TabIndex = 24;
            this.Chk_Opc15.Text = "OPC15";
            this.Chk_Opc15.UseVisualStyleBackColor = true;
            this.Chk_Opc15.Visible = false;
            // 
            // Chk_Opc14
            // 
            this.Chk_Opc14.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc14", true));
            this.Chk_Opc14.Location = new System.Drawing.Point(27, 351);
            this.Chk_Opc14.Name = "Chk_Opc14";
            this.Chk_Opc14.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc14.TabIndex = 23;
            this.Chk_Opc14.Text = "Actividad Profesional, Industrial o Comercial";
            this.Chk_Opc14.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc13
            // 
            this.Chk_Opc13.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc13", true));
            this.Chk_Opc13.Location = new System.Drawing.Point(27, 326);
            this.Chk_Opc13.Name = "Chk_Opc13";
            this.Chk_Opc13.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc13.TabIndex = 22;
            this.Chk_Opc13.Text = "Huella Dactilar";
            this.Chk_Opc13.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc12
            // 
            this.Chk_Opc12.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc12", true));
            this.Chk_Opc12.Location = new System.Drawing.Point(27, 301);
            this.Chk_Opc12.Name = "Chk_Opc12";
            this.Chk_Opc12.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc12.TabIndex = 21;
            this.Chk_Opc12.Text = "Patrimonio total";
            this.Chk_Opc12.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc11
            // 
            this.Chk_Opc11.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc11", true));
            this.Chk_Opc11.Location = new System.Drawing.Point(27, 276);
            this.Chk_Opc11.Name = "Chk_Opc11";
            this.Chk_Opc11.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc11.TabIndex = 20;
            this.Chk_Opc11.Text = "Total de Activos Líquidos";
            this.Chk_Opc11.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc10
            // 
            this.Chk_Opc10.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc10", true));
            this.Chk_Opc10.Location = new System.Drawing.Point(27, 251);
            this.Chk_Opc10.Name = "Chk_Opc10";
            this.Chk_Opc10.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc10.TabIndex = 19;
            this.Chk_Opc10.Text = "Ingresos Anuales";
            this.Chk_Opc10.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc9
            // 
            this.Chk_Opc9.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc9", true));
            this.Chk_Opc9.Location = new System.Drawing.Point(27, 226);
            this.Chk_Opc9.Name = "Chk_Opc9";
            this.Chk_Opc9.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc9.TabIndex = 17;
            this.Chk_Opc9.Text = "Objetivo de la Inversión en un Ciclo de Mercado";
            this.Chk_Opc9.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc8
            // 
            this.Chk_Opc8.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc8", true));
            this.Chk_Opc8.Location = new System.Drawing.Point(27, 201);
            this.Chk_Opc8.Name = "Chk_Opc8";
            this.Chk_Opc8.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc8.TabIndex = 15;
            this.Chk_Opc8.Text = "Experiencia y Conocimiento como Inversionista";
            this.Chk_Opc8.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc7
            // 
            this.Chk_Opc7.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc7", true));
            this.Chk_Opc7.Location = new System.Drawing.Point(27, 176);
            this.Chk_Opc7.Name = "Chk_Opc7";
            this.Chk_Opc7.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc7.TabIndex = 13;
            this.Chk_Opc7.Text = "Tipo y Número de Documento de Identificación";
            this.Chk_Opc7.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc6
            // 
            this.Chk_Opc6.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc6", true));
            this.Chk_Opc6.Location = new System.Drawing.Point(27, 151);
            this.Chk_Opc6.Name = "Chk_Opc6";
            this.Chk_Opc6.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc6.TabIndex = 11;
            this.Chk_Opc6.Text = "checkBox1";
            this.Chk_Opc6.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc5
            // 
            this.Chk_Opc5.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc5", true));
            this.Chk_Opc5.Location = new System.Drawing.Point(27, 126);
            this.Chk_Opc5.Name = "Chk_Opc5";
            this.Chk_Opc5.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc5.TabIndex = 9;
            this.Chk_Opc5.Text = "checkBox1";
            this.Chk_Opc5.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc4
            // 
            this.Chk_Opc4.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc4", true));
            this.Chk_Opc4.Location = new System.Drawing.Point(27, 101);
            this.Chk_Opc4.Name = "Chk_Opc4";
            this.Chk_Opc4.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc4.TabIndex = 7;
            this.Chk_Opc4.Text = "Declaración Jurada de Origen y Destino de Fondos";
            this.Chk_Opc4.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc3
            // 
            this.Chk_Opc3.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc3", true));
            this.Chk_Opc3.Location = new System.Drawing.Point(27, 76);
            this.Chk_Opc3.Name = "Chk_Opc3";
            this.Chk_Opc3.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc3.TabIndex = 5;
            this.Chk_Opc3.Text = "Constancia de Chequeo en World Compliance";
            this.Chk_Opc3.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc2
            // 
            this.Chk_Opc2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc2", true));
            this.Chk_Opc2.Location = new System.Drawing.Point(27, 51);
            this.Chk_Opc2.Name = "Chk_Opc2";
            this.Chk_Opc2.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc2.TabIndex = 3;
            this.Chk_Opc2.Text = "Copia de Recibo de Servicio Público";
            this.Chk_Opc2.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc1
            // 
            this.Chk_Opc1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc1", true));
            this.Chk_Opc1.Location = new System.Drawing.Point(27, 26);
            this.Chk_Opc1.Name = "Chk_Opc1";
            this.Chk_Opc1.Size = new System.Drawing.Size(439, 24);
            this.Chk_Opc1.TabIndex = 1;
            this.Chk_Opc1.Text = "Copia del Documento de Identidad";
            this.Chk_Opc1.UseVisualStyleBackColor = true;
            // 
            // Pag4
            // 
            this.Pag4.AutoScroll = true;
            this.Pag4.Controls.Add(this.NUD_NroTransacciones);
            this.Pag4.Controls.Add(this.Btn_Trimestre);
            this.Pag4.Controls.Add(this.NUD_TriAno);
            this.Pag4.Controls.Add(this.NUD_TriMes);
            this.Pag4.Controls.Add(Lbl_ToTrimestral);
            this.Pag4.Controls.Add(this.Txt_TriMntOperaciones);
            this.Pag4.Controls.Add(Lbl_NroOperaciones);
            this.Pag4.Controls.Add(this.Txt_TriNroOperaciones);
            this.Pag4.Controls.Add(Lbl_ToTrimestre);
            this.Pag4.Controls.Add(Lbl_FecUltAct);
            this.Pag4.Controls.Add(this.DTP_FecUltAct);
            this.Pag4.Controls.Add(Lbl_NroTransacciones);
            this.Pag4.Controls.Add(Lbl_PerUsoCta);
            this.Pag4.Controls.Add(this.periodUsoCtaTextBox);
            this.Pag4.Controls.Add(Lbl_PerFinanciero);
            this.Pag4.Controls.Add(this.Txt_PerFinanciero);
            this.Pag4.Controls.Add(Lbl_NivRiesgo);
            this.Pag4.Controls.Add(this.Txt_NivRiesgo);
            this.Pag4.Controls.Add(Lbl_Ejecutivo);
            this.Pag4.Controls.Add(this.Txt_Ejecutivo);
            this.Pag4.Controls.Add(Lbl_Observacion);
            this.Pag4.Controls.Add(this.Txt_Observacion);
            this.Pag4.Controls.Add(this.Grp_PerUsoCta);
            this.Pag4.Location = new System.Drawing.Point(4, 25);
            this.Pag4.Name = "Pag4";
            this.Pag4.Padding = new System.Windows.Forms.Padding(3);
            this.Pag4.Size = new System.Drawing.Size(1063, 453);
            this.Pag4.TabIndex = 3;
            this.Pag4.Text = "Observaciones";
            this.Pag4.UseVisualStyleBackColor = true;
            // 
            // NUD_NroTransacciones
            // 
            this.NUD_NroTransacciones.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "NroTransacciones", true));
            this.NUD_NroTransacciones.Location = new System.Drawing.Point(182, 364);
            this.NUD_NroTransacciones.Name = "NUD_NroTransacciones";
            this.NUD_NroTransacciones.Size = new System.Drawing.Size(50, 22);
            this.NUD_NroTransacciones.TabIndex = 26;
            // 
            // Btn_Trimestre
            // 
            this.Btn_Trimestre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Trimestre.BackgroundImage")));
            this.Btn_Trimestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Trimestre.Location = new System.Drawing.Point(989, 296);
            this.Btn_Trimestre.Name = "Btn_Trimestre";
            this.Btn_Trimestre.Size = new System.Drawing.Size(48, 48);
            this.Btn_Trimestre.TabIndex = 25;
            this.Btn_Trimestre.UseVisualStyleBackColor = true;
            // 
            // NUD_TriAno
            // 
            this.NUD_TriAno.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "Trim_Ano", true));
            this.NUD_TriAno.Location = new System.Drawing.Point(891, 296);
            this.NUD_TriAno.Name = "NUD_TriAno";
            this.NUD_TriAno.Size = new System.Drawing.Size(76, 22);
            this.NUD_TriAno.TabIndex = 24;
            // 
            // NUD_TriMes
            // 
            this.NUD_TriMes.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "Trim_Mes", true));
            this.NUD_TriMes.Location = new System.Drawing.Point(835, 296);
            this.NUD_TriMes.Name = "NUD_TriMes";
            this.NUD_TriMes.Size = new System.Drawing.Size(50, 22);
            this.NUD_TriMes.TabIndex = 23;
            // 
            // Txt_TriMntOperaciones
            // 
            this.Txt_TriMntOperaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Trim_MontoOperac", true));
            this.Txt_TriMntOperaciones.Enabled = false;
            this.Txt_TriMntOperaciones.Location = new System.Drawing.Point(894, 387);
            this.Txt_TriMntOperaciones.Name = "Txt_TriMntOperaciones";
            this.Txt_TriMntOperaciones.Size = new System.Drawing.Size(143, 22);
            this.Txt_TriMntOperaciones.TabIndex = 21;
            // 
            // Txt_TriNroOperaciones
            // 
            this.Txt_TriNroOperaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Trim_NroOperac", true));
            this.Txt_TriNroOperaciones.Enabled = false;
            this.Txt_TriNroOperaciones.Location = new System.Drawing.Point(992, 297);
            this.Txt_TriNroOperaciones.Name = "Txt_TriNroOperaciones";
            this.Txt_TriNroOperaciones.Size = new System.Drawing.Size(45, 22);
            this.Txt_TriNroOperaciones.TabIndex = 19;
            // 
            // DTP_FecUltAct
            // 
            this.DTP_FecUltAct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "Fec_UltimAct", true));
            this.DTP_FecUltAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FecUltAct.Location = new System.Drawing.Point(182, 392);
            this.DTP_FecUltAct.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DTP_FecUltAct.Name = "DTP_FecUltAct";
            this.DTP_FecUltAct.Size = new System.Drawing.Size(119, 22);
            this.DTP_FecUltAct.TabIndex = 13;
            this.DTP_FecUltAct.Value = new System.DateTime(2018, 12, 30, 17, 53, 59, 0);
            // 
            // periodUsoCtaTextBox
            // 
            this.periodUsoCtaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "PeriodUsoCta", true));
            this.periodUsoCtaTextBox.Location = new System.Drawing.Point(462, 359);
            this.periodUsoCtaTextBox.Name = "periodUsoCtaTextBox";
            this.periodUsoCtaTextBox.Size = new System.Drawing.Size(35, 22);
            this.periodUsoCtaTextBox.TabIndex = 9;
            // 
            // Txt_PerFinanciero
            // 
            this.Txt_PerFinanciero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "PerfilFinanciero", true));
            this.Txt_PerFinanciero.Location = new System.Drawing.Point(182, 299);
            this.Txt_PerFinanciero.Name = "Txt_PerFinanciero";
            this.Txt_PerFinanciero.Size = new System.Drawing.Size(200, 22);
            this.Txt_PerFinanciero.TabIndex = 8;
            // 
            // Txt_NivRiesgo
            // 
            this.Txt_NivRiesgo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "NivelRiesgo", true));
            this.Txt_NivRiesgo.Location = new System.Drawing.Point(182, 271);
            this.Txt_NivRiesgo.Name = "Txt_NivRiesgo";
            this.Txt_NivRiesgo.Size = new System.Drawing.Size(200, 22);
            this.Txt_NivRiesgo.TabIndex = 7;
            // 
            // Txt_Ejecutivo
            // 
            this.Txt_Ejecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Ejecutivo", true));
            this.Txt_Ejecutivo.Location = new System.Drawing.Point(182, 243);
            this.Txt_Ejecutivo.Name = "Txt_Ejecutivo";
            this.Txt_Ejecutivo.Size = new System.Drawing.Size(200, 22);
            this.Txt_Ejecutivo.TabIndex = 3;
            // 
            // Txt_Observacion
            // 
            this.Txt_Observacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Observacion", true));
            this.Txt_Observacion.Location = new System.Drawing.Point(182, 21);
            this.Txt_Observacion.Multiline = true;
            this.Txt_Observacion.Name = "Txt_Observacion";
            this.Txt_Observacion.Size = new System.Drawing.Size(855, 216);
            this.Txt_Observacion.TabIndex = 1;
            // 
            // Grp_PerUsoCta
            // 
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta5);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta4);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta3);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta2);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta1);
            this.Grp_PerUsoCta.Location = new System.Drawing.Point(182, 319);
            this.Grp_PerUsoCta.Name = "Grp_PerUsoCta";
            this.Grp_PerUsoCta.Size = new System.Drawing.Size(484, 37);
            this.Grp_PerUsoCta.TabIndex = 22;
            this.Grp_PerUsoCta.TabStop = false;
            // 
            // Opt_PerUsoCta5
            // 
            this.Opt_PerUsoCta5.AutoSize = true;
            this.Opt_PerUsoCta5.Location = new System.Drawing.Point(402, 11);
            this.Opt_PerUsoCta5.Name = "Opt_PerUsoCta5";
            this.Opt_PerUsoCta5.Size = new System.Drawing.Size(66, 20);
            this.Opt_PerUsoCta5.TabIndex = 4;
            this.Opt_PerUsoCta5.TabStop = true;
            this.Opt_PerUsoCta5.Text = "Anual";
            this.Opt_PerUsoCta5.UseVisualStyleBackColor = true;
            // 
            // Opt_PerUsoCta4
            // 
            this.Opt_PerUsoCta4.AutoSize = true;
            this.Opt_PerUsoCta4.Location = new System.Drawing.Point(297, 11);
            this.Opt_PerUsoCta4.Name = "Opt_PerUsoCta4";
            this.Opt_PerUsoCta4.Size = new System.Drawing.Size(98, 20);
            this.Opt_PerUsoCta4.TabIndex = 3;
            this.Opt_PerUsoCta4.TabStop = true;
            this.Opt_PerUsoCta4.Text = "Semestral";
            this.Opt_PerUsoCta4.UseVisualStyleBackColor = true;
            // 
            // Opt_PerUsoCta3
            // 
            this.Opt_PerUsoCta3.AutoSize = true;
            this.Opt_PerUsoCta3.Location = new System.Drawing.Point(184, 11);
            this.Opt_PerUsoCta3.Name = "Opt_PerUsoCta3";
            this.Opt_PerUsoCta3.Size = new System.Drawing.Size(106, 20);
            this.Opt_PerUsoCta3.TabIndex = 2;
            this.Opt_PerUsoCta3.TabStop = true;
            this.Opt_PerUsoCta3.Text = "Trimestral";
            this.Opt_PerUsoCta3.UseVisualStyleBackColor = true;
            // 
            // Opt_PerUsoCta2
            // 
            this.Opt_PerUsoCta2.AutoSize = true;
            this.Opt_PerUsoCta2.Location = new System.Drawing.Point(95, 11);
            this.Opt_PerUsoCta2.Name = "Opt_PerUsoCta2";
            this.Opt_PerUsoCta2.Size = new System.Drawing.Size(82, 20);
            this.Opt_PerUsoCta2.TabIndex = 1;
            this.Opt_PerUsoCta2.TabStop = true;
            this.Opt_PerUsoCta2.Text = "Mensual";
            this.Opt_PerUsoCta2.UseVisualStyleBackColor = true;
            // 
            // Opt_PerUsoCta1
            // 
            this.Opt_PerUsoCta1.AutoSize = true;
            this.Opt_PerUsoCta1.Location = new System.Drawing.Point(6, 11);
            this.Opt_PerUsoCta1.Name = "Opt_PerUsoCta1";
            this.Opt_PerUsoCta1.Size = new System.Drawing.Size(82, 20);
            this.Opt_PerUsoCta1.TabIndex = 0;
            this.Opt_PerUsoCta1.TabStop = true;
            this.Opt_PerUsoCta1.Text = "Semanal";
            this.Opt_PerUsoCta1.UseVisualStyleBackColor = true;
            // 
            // Pag5
            // 
            this.Pag5.Controls.Add(this.Pic_MapEpresa);
            this.Pag5.Location = new System.Drawing.Point(4, 25);
            this.Pag5.Name = "Pag5";
            this.Pag5.Padding = new System.Windows.Forms.Padding(3);
            this.Pag5.Size = new System.Drawing.Size(1063, 453);
            this.Pag5.TabIndex = 4;
            this.Pag5.Text = "Mapa de Propiesdad de la Empresa";
            this.Pag5.UseVisualStyleBackColor = true;
            // 
            // Pic_MapEpresa
            // 
            this.Pic_MapEpresa.Image = ((System.Drawing.Image)(resources.GetObject("Pic_MapEpresa.Image")));
            this.Pic_MapEpresa.Location = new System.Drawing.Point(117, 27);
            this.Pic_MapEpresa.Name = "Pic_MapEpresa";
            this.Pic_MapEpresa.Size = new System.Drawing.Size(903, 401);
            this.Pic_MapEpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_MapEpresa.TabIndex = 0;
            this.Pic_MapEpresa.TabStop = false;
            // 
            // TA_CFirBenAcc
            // 
            this.TA_CFirBenAcc.ClearBeforeFill = true;
            // 
            // Grp_TipoPersona
            // 
            this.Grp_TipoPersona.Controls.Add(this.Opc_TipPers2);
            this.Grp_TipoPersona.Controls.Add(this.Opc_TipPers1);
            this.Grp_TipoPersona.Location = new System.Drawing.Point(26, 77);
            this.Grp_TipoPersona.Name = "Grp_TipoPersona";
            this.Grp_TipoPersona.Size = new System.Drawing.Size(175, 60);
            this.Grp_TipoPersona.TabIndex = 50;
            this.Grp_TipoPersona.TabStop = false;
            // 
            // Opc_TipPers2
            // 
            this.Opc_TipPers2.AutoSize = true;
            this.Opc_TipPers2.Location = new System.Drawing.Point(9, 33);
            this.Opc_TipPers2.Name = "Opc_TipPers2";
            this.Opc_TipPers2.Size = new System.Drawing.Size(154, 20);
            this.Opc_TipPers2.TabIndex = 1;
            this.Opc_TipPers2.TabStop = true;
            this.Opc_TipPers2.Text = "Persona Jurídica";
            this.Opc_TipPers2.UseVisualStyleBackColor = true;
            // 
            // Opc_TipPers1
            // 
            this.Opc_TipPers1.AutoSize = true;
            this.Opc_TipPers1.Location = new System.Drawing.Point(9, 12);
            this.Opc_TipPers1.Name = "Opc_TipPers1";
            this.Opc_TipPers1.Size = new System.Drawing.Size(146, 20);
            this.Opc_TipPers1.TabIndex = 0;
            this.Opc_TipPers1.TabStop = true;
            this.Opc_TipPers1.Text = "Persona Natural";
            this.Opc_TipPers1.UseVisualStyleBackColor = true;
            // 
            // Lbl_Puntuacion
            // 
            this.Lbl_Puntuacion.BackColor = System.Drawing.Color.Black;
            this.Lbl_Puntuacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Puntuacion.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Puntuacion.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_Puntuacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Puntuacion.Location = new System.Drawing.Point(978, 37);
            this.Lbl_Puntuacion.Name = "Lbl_Puntuacion";
            this.Lbl_Puntuacion.Size = new System.Drawing.Size(100, 100);
            this.Lbl_Puntuacion.TabIndex = 0;
            this.Lbl_Puntuacion.Text = "2";
            // 
            // Lbl_Activo
            // 
            this.Lbl_Activo.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Activo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Activo.Location = new System.Drawing.Point(725, 84);
            this.Lbl_Activo.Name = "Lbl_Activo";
            this.Lbl_Activo.Size = new System.Drawing.Size(210, 46);
            this.Lbl_Activo.TabIndex = 51;
            this.Lbl_Activo.Text = "Inactivo";
            this.Lbl_Activo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_EtiqPunt
            // 
            this.Lbl_EtiqPunt.Location = new System.Drawing.Point(980, 39);
            this.Lbl_EtiqPunt.Name = "Lbl_EtiqPunt";
            this.Lbl_EtiqPunt.Size = new System.Drawing.Size(95, 16);
            this.Lbl_EtiqPunt.TabIndex = 52;
            this.Lbl_EtiqPunt.Text = "Puntuación";
            this.Lbl_EtiqPunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_ProductosTableAdapter
            // 
            this.m_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // m_ServiciosTableAdapter
            // 
            this.m_ServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1095, 675);
            this.Controls.Add(this.Lbl_EtiqPunt);
            this.Controls.Add(this.Lbl_Activo);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_Puntuacion);
            this.Controls.Add(this.Grp_TipoPersona);
            this.Controls.Add(this.Tab_Clientes);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(Lbl_DocID);
            this.Controls.Add(this.Txt_DocID);
            this.Controls.Add(Lbl_Codigo);
            this.Controls.Add(this.Txt_Codigo);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Clientes";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_MonitorOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).EndInit();
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            this.Tab_Clientes.ResumeLayout(false);
            this.Pag1.ResumeLayout(false);
            this.Pag1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_ClientesDataGridView)).EndInit();
            this.Pag2.ResumeLayout(false);
            this.Pag2.PerformLayout();
            this.Pan_BenefBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BS_CFirBenAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_BenefVincPorcent)).EndInit();
            this.Grp_BenfTipoVinculacion.ResumeLayout(false);
            this.Grp_BenfTipoVinculacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_CFirBenAcc)).EndInit();
            this.Pag3.ResumeLayout(false);
            this.Pag4.ResumeLayout(false);
            this.Pag4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NroTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriMes)).EndInit();
            this.Grp_PerUsoCta.ResumeLayout(false);
            this.Grp_PerUsoCta.PerformLayout();
            this.Pag5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_MapEpresa)).EndInit();
            this.Grp_TipoPersona.ResumeLayout(false);
            this.Grp_TipoPersona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonitorOperacionesDataSet DS_MonitorOperaciones;
        private System.Windows.Forms.BindingSource BS_CClientes;
        private MonitorOperacionesDataSetTableAdapters.C_ClientesTableAdapter TA_CClientes;
        private MonitorOperacionesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_DocID;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.ToolStripButton TSB_Siguiente;
        private System.Windows.Forms.ToolStrip TS_BarraHerramientas;
        private System.Windows.Forms.ToolStripButton TSB_Primero;
        private System.Windows.Forms.ToolStripButton TSB_Anterior;
        private System.Windows.Forms.ToolStripButton TSB_Ultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_Agregar;
        private System.Windows.Forms.ToolStripButton TSB_Modificar;
        private System.Windows.Forms.ToolStripButton TSB_Eliminar;
        private System.Windows.Forms.ToolStripButton TSB_Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_Salir;
        private System.Windows.Forms.TabControl Tab_Clientes;
        private System.Windows.Forms.TabPage Pag1;
        private System.Windows.Forms.TabPage Pag2;
        private System.Windows.Forms.TabPage Pag3;
        private System.Windows.Forms.TabPage Pag4;
        private System.Windows.Forms.TabPage Pag5;
        private System.Windows.Forms.BindingSource BS_CFirBenAcc;
        private MonitorOperacionesDataSetTableAdapters.C_FirBenAccTableAdapter TA_CFirBenAcc;
        private System.Windows.Forms.DataGridView Grd_CFirBenAcc;
        private System.Windows.Forms.DataGridView c_ClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox Chk_Opc30;
        private System.Windows.Forms.CheckBox Chk_Opc29;
        private System.Windows.Forms.CheckBox Chk_Opc28;
        private System.Windows.Forms.CheckBox Chk_Opc27;
        private System.Windows.Forms.CheckBox Chk_Opc26;
        private System.Windows.Forms.CheckBox Chk_Opc25;
        private System.Windows.Forms.CheckBox Chk_Opc24;
        private System.Windows.Forms.CheckBox Chk_Opc23;
        private System.Windows.Forms.CheckBox Chk_Opc22;
        private System.Windows.Forms.CheckBox Chk_Opc21;
        private System.Windows.Forms.CheckBox Chk_Opc20;
        private System.Windows.Forms.CheckBox Chk_Opc19;
        private System.Windows.Forms.CheckBox Chk_Opc18;
        private System.Windows.Forms.CheckBox Chk_Opc17;
        private System.Windows.Forms.CheckBox Chk_Opc16;
        private System.Windows.Forms.CheckBox Chk_Opc15;
        private System.Windows.Forms.CheckBox Chk_Opc14;
        private System.Windows.Forms.CheckBox Chk_Opc13;
        private System.Windows.Forms.CheckBox Chk_Opc12;
        private System.Windows.Forms.CheckBox Chk_Opc11;
        private System.Windows.Forms.CheckBox Chk_Opc10;
        private System.Windows.Forms.CheckBox Chk_Opc9;
        private System.Windows.Forms.CheckBox Chk_Opc8;
        private System.Windows.Forms.CheckBox Chk_Opc7;
        private System.Windows.Forms.CheckBox Chk_Opc6;
        private System.Windows.Forms.CheckBox Chk_Opc5;
        private System.Windows.Forms.CheckBox Chk_Opc4;
        private System.Windows.Forms.CheckBox Chk_Opc3;
        private System.Windows.Forms.CheckBox Chk_Opc2;
        private System.Windows.Forms.CheckBox Chk_Opc1;
        private System.Windows.Forms.TextBox Txt_TriMntOperaciones;
        private System.Windows.Forms.TextBox Txt_TriNroOperaciones;
        private System.Windows.Forms.DateTimePicker DTP_FecUltAct;
        private System.Windows.Forms.TextBox periodUsoCtaTextBox;
        private System.Windows.Forms.TextBox Txt_PerFinanciero;
        private System.Windows.Forms.TextBox Txt_NivRiesgo;
        private System.Windows.Forms.TextBox Txt_Ejecutivo;
        private System.Windows.Forms.TextBox Txt_Observacion;
        private System.Windows.Forms.PictureBox Pic_MapEpresa;
        private System.Windows.Forms.NumericUpDown NUD_TriAno;
        private System.Windows.Forms.NumericUpDown NUD_TriMes;
        private System.Windows.Forms.GroupBox Grp_PerUsoCta;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta5;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta4;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta3;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta2;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta1;
        private System.Windows.Forms.GroupBox Grp_TipoPersona;
        private System.Windows.Forms.RadioButton Opc_TipPers2;
        private System.Windows.Forms.RadioButton Opc_TipPers1;
        private System.Windows.Forms.Label Lbl_Puntuacion;
        private System.Windows.Forms.NumericUpDown NUD_NroTransacciones;
        private System.Windows.Forms.Button Btn_Trimestre;
        private System.Windows.Forms.ComboBox Cmb_PaisResidencia;
        private System.Windows.Forms.ComboBox Cmb_PaisNacimiento;
        private System.Windows.Forms.ComboBox Cmb_Nacionalidad;
        private System.Windows.Forms.DateTimePicker DTP_FecVencDocID;
        private System.Windows.Forms.ComboBox Cmb_TipDocID;
        private System.Windows.Forms.Label Lbl_Activo;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.ComboBox Cmb_ActivComercial;
        private System.Windows.Forms.ComboBox Cmb_Profesion;
        private System.Windows.Forms.ComboBox Cmb_Criptomonedas;
        private System.Windows.Forms.ComboBox Cmb_VolOperNat;
        private System.Windows.Forms.ComboBox Cmb_PEP;
        private System.Windows.Forms.ComboBox Cmb_TipoEstructura;
        private System.Windows.Forms.ComboBox Cmb_TipoPersJuridica;
        private System.Windows.Forms.ComboBox Cmb_Edad;
        private System.Windows.Forms.ComboBox Cmb_BenefPEP;
        private System.Windows.Forms.NumericUpDown Nud_BenefVincPorcent;
        private System.Windows.Forms.TextBox Cmb_BenefVincEmpresa;
        private System.Windows.Forms.ComboBox Cmb_BenefProfesion;
        private System.Windows.Forms.ComboBox Cmb_BenefEdad;
        private System.Windows.Forms.ComboBox Cmb_BenefEstado;
        private System.Windows.Forms.ComboBox Cmb_BenefPaisResid;
        private System.Windows.Forms.ComboBox Cmb_BenefNacionalidad;
        private System.Windows.Forms.ComboBox Cmb_BenefPaisNacim;
        private System.Windows.Forms.DateTimePicker Dtp_BenefFec_Venc;
        private System.Windows.Forms.TextBox Txt_BenefDoc_ID;
        private System.Windows.Forms.TextBox Txt_BenefNme;
        private System.Windows.Forms.GroupBox Grp_BenfTipoVinculacion;
        private System.Windows.Forms.RadioButton Opc_TipVinc3;
        private System.Windows.Forms.RadioButton Opc_TipVinc2;
        private System.Windows.Forms.RadioButton Opc_TipVinc1;
        private System.Windows.Forms.TextBox tipoVinculoTextBox;
        private System.Windows.Forms.Label Lbl_BenefEtiqPuntuacion;
        private System.Windows.Forms.Label Lbl_BenefPuntuacion;
        private System.Windows.Forms.Label Lbl_EtiqPunt;
        private System.Windows.Forms.ComboBox Cmb_BenefCriptomonedas;
        private System.Windows.Forms.Button Btn_BenefEliminar;
        private System.Windows.Forms.Button Btn_BenefModificar;
        private System.Windows.Forms.Button Btn_BenefIncluir;
        private System.Windows.Forms.Button Btn_BenefAceptar;
        private System.Windows.Forms.Button Btn_BenefCancelar;
        private System.Windows.Forms.Panel Pan_BenefBtns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn20;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn21;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn23;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn25;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn26;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn27;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn28;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn29;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn30;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn31;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn32;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn33;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn34;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn35;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn36;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn37;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn38;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn39;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn40;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn41;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn42;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn43;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn44;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn45;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn46;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn47;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn48;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn49;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn50;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn51;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn52;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.BindingSource m_ProductosBindingSource;
        private MonitorOperacionesDataSetTableAdapters.M_ProductosTableAdapter m_ProductosTableAdapter;
        private System.Windows.Forms.ListBox Lst_Productos;
        private System.Windows.Forms.BindingSource m_ServiciosBindingSource;
        private MonitorOperacionesDataSetTableAdapters.M_ServiciosTableAdapter m_ServiciosTableAdapter;
        private System.Windows.Forms.ListBox Lst_Servicios;
    }
}