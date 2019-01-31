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
            System.Windows.Forms.Label Lbl_ToTrimestral;
            System.Windows.Forms.Label iG_TipDocIDLabel;
            System.Windows.Forms.Label Lbl_FecVencDocID;
            System.Windows.Forms.Label Lbl_Nacionalidad;
            System.Windows.Forms.Label Lbl_PaisNacimiento;
            System.Windows.Forms.Label Lbl_PaisResidencia;
            System.Windows.Forms.Label Lbl_Estado;
            System.Windows.Forms.Label Lbl_Profesion;
            System.Windows.Forms.Label Lbl_ActivComercial;
            System.Windows.Forms.Label Lbl_TipoVinculo;
            System.Windows.Forms.Label Lbl_NmeBeneficiario;
            System.Windows.Forms.Label Lbl_BenefDoc_ID;
            System.Windows.Forms.Label Lbl_BenefPaisNacim;
            System.Windows.Forms.Label Lbl_BenefNacionalidad;
            System.Windows.Forms.Label Lbl_BenefPaisResid;
            System.Windows.Forms.Label Lbl_BenefEstado;
            System.Windows.Forms.Label Lbl_BenefProfesion;
            System.Windows.Forms.Label Lbl_BenefVincPorcent;
            System.Windows.Forms.Label Lbl_BenefVincEmpresa;
            System.Windows.Forms.Label Lbl_BenefCriptomonedas;
            System.Windows.Forms.Label Lbl_Productos;
            System.Windows.Forms.Label Lbl_Servicios;
            System.Windows.Forms.Label Lbl_Criptomonedas;
            System.Windows.Forms.Label Lbl_VolOperaciones;
            System.Windows.Forms.Label Lbl_PEP;
            System.Windows.Forms.Label Lbl_TipoEstructura;
            System.Windows.Forms.Label iG_TipoPersJurLabel;
            System.Windows.Forms.Label Lbl_Edad;
            System.Windows.Forms.Label Lbl_BenefPEP;
            System.Windows.Forms.Label Lbl_BenefEdad;
            System.Windows.Forms.Label Lbl_BenefFecVenc;
            System.Windows.Forms.Label Lbl_ToTrimestre;
            System.Windows.Forms.Label Lbl_NroOperaciones;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
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
            this.Pan_Detalles1 = new System.Windows.Forms.Panel();
            this.Cmb_TipDocID = new System.Windows.Forms.ComboBox();
            this.BS_CClientes = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MTipoDocID = new System.Windows.Forms.BindingSource(this.components);
            this.Lst_Productos = new System.Windows.Forms.ListBox();
            this.Cmb_Criptomonedas = new System.Windows.Forms.ComboBox();
            this.BS_MCriptomonedas = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_VolOperNat = new System.Windows.Forms.ComboBox();
            this.BS_MVolOperPersNat = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_PEP = new System.Windows.Forms.ComboBox();
            this.BS_MPEP = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_TipoEstructura = new System.Windows.Forms.ComboBox();
            this.BS_MTipoEstructuraEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_TipoPersJuridica = new System.Windows.Forms.ComboBox();
            this.BS_MTipoPersJuridica = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_Edad = new System.Windows.Forms.ComboBox();
            this.BS_MEdad = new System.Windows.Forms.BindingSource(this.components);
            this.Lst_Servicios = new System.Windows.Forms.ListBox();
            this.Cmb_ActivComercial = new System.Windows.Forms.ComboBox();
            this.BS_MActivComercial = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_Profesion = new System.Windows.Forms.ComboBox();
            this.BS_MProfesiones = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.BS_MEstados = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_PaisResidencia = new System.Windows.Forms.ComboBox();
            this.BS_Res = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_PaisNacimiento = new System.Windows.Forms.ComboBox();
            this.BS_Nac = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.BS_MPais = new System.Windows.Forms.BindingSource(this.components);
            this.DTP_FecVencDocID = new System.Windows.Forms.DateTimePicker();
            this.Pag2 = new System.Windows.Forms.TabPage();
            this.Pan_BenefBtns = new System.Windows.Forms.Panel();
            this.Btn_BenefIncluir = new System.Windows.Forms.Button();
            this.Btn_BenefEliminar = new System.Windows.Forms.Button();
            this.Btn_BenefModificar = new System.Windows.Forms.Button();
            this.Btn_BenefAceptar = new System.Windows.Forms.Button();
            this.Btn_BenefCancelar = new System.Windows.Forms.Button();
            this.Lbl_BenefEtiqPuntuacion = new System.Windows.Forms.Label();
            this.Lbl_BenefPuntuacion = new System.Windows.Forms.Label();
            this.Pan_Detalles2 = new System.Windows.Forms.Panel();
            this.Cmb_BenefCriptomonedas = new System.Windows.Forms.ComboBox();
            this.BS_CFirBenAcc = new System.Windows.Forms.BindingSource(this.components);
            this.BS_AutCriptomoneda = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_BenefPEP = new System.Windows.Forms.ComboBox();
            this.BS_AutPEP = new System.Windows.Forms.BindingSource(this.components);
            this.Nud_BenefVincPorcent = new System.Windows.Forms.NumericUpDown();
            this.Cmb_BenefVincEmpresa = new System.Windows.Forms.TextBox();
            this.Cmb_BenefProfesion = new System.Windows.Forms.ComboBox();
            this.BS_AutProfesion = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_BenefEdad = new System.Windows.Forms.ComboBox();
            this.BS_AutEdad = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_BenefEstado = new System.Windows.Forms.ComboBox();
            this.Cmb_BenefPaisResid = new System.Windows.Forms.ComboBox();
            this.BS_AutRes = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_BenefNacionalidad = new System.Windows.Forms.ComboBox();
            this.BS_AutNac = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_BenefPaisNacim = new System.Windows.Forms.ComboBox();
            this.BS_AutPaisNac = new System.Windows.Forms.BindingSource(this.components);
            this.Dtp_BenefFec_Venc = new System.Windows.Forms.DateTimePicker();
            this.Txt_BenefDoc_ID = new System.Windows.Forms.TextBox();
            this.Txt_BenefNme = new System.Windows.Forms.TextBox();
            this.Grp_BenfTipoVinculacion = new System.Windows.Forms.GroupBox();
            this.Opc_TipVinc3 = new System.Windows.Forms.RadioButton();
            this.Opc_TipVinc2 = new System.Windows.Forms.RadioButton();
            this.Opc_TipVinc1 = new System.Windows.Forms.RadioButton();
            this.Grd_CFirBenAcc = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pag3 = new System.Windows.Forms.TabPage();
            this.Pan_Detalles3 = new System.Windows.Forms.Panel();
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
            this.Btn_Trimestre = new System.Windows.Forms.Button();
            this.Pan_Detalles4 = new System.Windows.Forms.Panel();
            this.NUD_NroTransacciones = new System.Windows.Forms.NumericUpDown();
            this.NUD_TriAno = new System.Windows.Forms.NumericUpDown();
            this.NUD_TriMes = new System.Windows.Forms.NumericUpDown();
            this.Txt_TriNroOperaciones = new System.Windows.Forms.TextBox();
            this.Txt_TriMntOperaciones = new System.Windows.Forms.TextBox();
            this.DTP_FecUltAct = new System.Windows.Forms.DateTimePicker();
            this.periodUsoCtaTextBox = new System.Windows.Forms.TextBox();
            this.Txt_PerFinanciero = new System.Windows.Forms.TextBox();
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
            this.Lbl_Puntuacion = new System.Windows.Forms.Label();
            this.Lbl_Activo = new System.Windows.Forms.Label();
            this.Lbl_EtiqPunt = new System.Windows.Forms.Label();
            this.Pan_DetallesEnc = new System.Windows.Forms.Panel();
            this.Grp_TipoPersona = new System.Windows.Forms.GroupBox();
            this.Opc_TipPers2 = new System.Windows.Forms.RadioButton();
            this.Opc_TipPers1 = new System.Windows.Forms.RadioButton();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_DocID = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.monitorOperacionesDataSet = new MOFIN.MonitorOperacionesDataSet();
            this.Grd_Clientes = new System.Windows.Forms.DataGridView();
            this.iDSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientePuntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benefPuntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infGenPuntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constExpedPuntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condEspSeguridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGPaisNacimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGNacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGPaisResidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGPEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProfesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGTipDocIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGFecVencDocIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGTipoPersJurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGEdadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGActivComerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGVolumOperacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGCriptomonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGTipoEstructuraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGServicio10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGProducto10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc18DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc25DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc26DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc27DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc28DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc29DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEOpc30DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejecutivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelRiesgoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilFinancieroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodUsoCtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTransaccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecUltimActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimMesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimAnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimNroOperacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trimMontoOperacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapaEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_CHistActClientes = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MAntiguedad = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MNivelRiesgo = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MProductos = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MServicios = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MVolOperPersJur = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_Antiguedad = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cmb_NivelRiesgo = new System.Windows.Forms.ComboBox();
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
            Lbl_ToTrimestral = new System.Windows.Forms.Label();
            iG_TipDocIDLabel = new System.Windows.Forms.Label();
            Lbl_FecVencDocID = new System.Windows.Forms.Label();
            Lbl_Nacionalidad = new System.Windows.Forms.Label();
            Lbl_PaisNacimiento = new System.Windows.Forms.Label();
            Lbl_PaisResidencia = new System.Windows.Forms.Label();
            Lbl_Estado = new System.Windows.Forms.Label();
            Lbl_Profesion = new System.Windows.Forms.Label();
            Lbl_ActivComercial = new System.Windows.Forms.Label();
            Lbl_TipoVinculo = new System.Windows.Forms.Label();
            Lbl_NmeBeneficiario = new System.Windows.Forms.Label();
            Lbl_BenefDoc_ID = new System.Windows.Forms.Label();
            Lbl_BenefPaisNacim = new System.Windows.Forms.Label();
            Lbl_BenefNacionalidad = new System.Windows.Forms.Label();
            Lbl_BenefPaisResid = new System.Windows.Forms.Label();
            Lbl_BenefEstado = new System.Windows.Forms.Label();
            Lbl_BenefProfesion = new System.Windows.Forms.Label();
            Lbl_BenefVincPorcent = new System.Windows.Forms.Label();
            Lbl_BenefVincEmpresa = new System.Windows.Forms.Label();
            Lbl_BenefCriptomonedas = new System.Windows.Forms.Label();
            Lbl_Productos = new System.Windows.Forms.Label();
            Lbl_Servicios = new System.Windows.Forms.Label();
            Lbl_Criptomonedas = new System.Windows.Forms.Label();
            Lbl_VolOperaciones = new System.Windows.Forms.Label();
            Lbl_PEP = new System.Windows.Forms.Label();
            Lbl_TipoEstructura = new System.Windows.Forms.Label();
            iG_TipoPersJurLabel = new System.Windows.Forms.Label();
            Lbl_Edad = new System.Windows.Forms.Label();
            Lbl_BenefPEP = new System.Windows.Forms.Label();
            Lbl_BenefEdad = new System.Windows.Forms.Label();
            Lbl_BenefFecVenc = new System.Windows.Forms.Label();
            Lbl_ToTrimestre = new System.Windows.Forms.Label();
            Lbl_NroOperaciones = new System.Windows.Forms.Label();
            this.TS_BarraHerramientas.SuspendLayout();
            this.Tab_Clientes.SuspendLayout();
            this.Pag1.SuspendLayout();
            this.Pan_Detalles1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoDocID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MCriptomonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersNat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoEstructuraEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoPersJuridica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MActivComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProfesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Nac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPais)).BeginInit();
            this.Pag2.SuspendLayout();
            this.Pan_BenefBtns.SuspendLayout();
            this.Pan_Detalles2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CFirBenAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutCriptomoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutPEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_BenefVincPorcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutProfesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutNac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutPaisNac)).BeginInit();
            this.Grp_BenfTipoVinculacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_CFirBenAcc)).BeginInit();
            this.Pag3.SuspendLayout();
            this.Pan_Detalles3.SuspendLayout();
            this.Pag4.SuspendLayout();
            this.Pan_Detalles4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NroTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriMes)).BeginInit();
            this.Grp_PerUsoCta.SuspendLayout();
            this.Pag5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_MapEpresa)).BeginInit();
            this.Pan_DetallesEnc.SuspendLayout();
            this.Grp_TipoPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorOperacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHistActClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAntiguedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MNivelRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersJur)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new System.Drawing.Point(206, 68);
            Lbl_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new System.Drawing.Size(49, 15);
            Lbl_Codigo.TabIndex = 41;
            Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_DocID
            // 
            Lbl_DocID.AutoSize = true;
            Lbl_DocID.Location = new System.Drawing.Point(385, 68);
            Lbl_DocID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_DocID.Name = "Lbl_DocID";
            Lbl_DocID.Size = new System.Drawing.Size(48, 15);
            Lbl_DocID.TabIndex = 42;
            Lbl_DocID.Text = "Doc ID:";
            // 
            // Lbl_Nombre
            // 
            Lbl_Nombre.AutoSize = true;
            Lbl_Nombre.Location = new System.Drawing.Point(206, 93);
            Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Nombre.Name = "Lbl_Nombre";
            Lbl_Nombre.Size = new System.Drawing.Size(52, 15);
            Lbl_Nombre.TabIndex = 43;
            Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Observacion
            // 
            Lbl_Observacion.AutoSize = true;
            Lbl_Observacion.Location = new System.Drawing.Point(53, 22);
            Lbl_Observacion.Name = "Lbl_Observacion";
            Lbl_Observacion.Size = new System.Drawing.Size(78, 15);
            Lbl_Observacion.TabIndex = 0;
            Lbl_Observacion.Text = "Observacion:";
            // 
            // Lbl_Ejecutivo
            // 
            Lbl_Ejecutivo.AutoSize = true;
            Lbl_Ejecutivo.Location = new System.Drawing.Point(71, 231);
            Lbl_Ejecutivo.Name = "Lbl_Ejecutivo";
            Lbl_Ejecutivo.Size = new System.Drawing.Size(60, 15);
            Lbl_Ejecutivo.TabIndex = 2;
            Lbl_Ejecutivo.Text = "Ejecutivo:";
            // 
            // Lbl_NivRiesgo
            // 
            Lbl_NivRiesgo.AutoSize = true;
            Lbl_NivRiesgo.Location = new System.Drawing.Point(53, 257);
            Lbl_NivRiesgo.Name = "Lbl_NivRiesgo";
            Lbl_NivRiesgo.Size = new System.Drawing.Size(78, 15);
            Lbl_NivRiesgo.TabIndex = 6;
            Lbl_NivRiesgo.Text = "Nivel Riesgo:";
            // 
            // Lbl_PerFinanciero
            // 
            Lbl_PerFinanciero.AutoSize = true;
            Lbl_PerFinanciero.Location = new System.Drawing.Point(35, 283);
            Lbl_PerFinanciero.Name = "Lbl_PerFinanciero";
            Lbl_PerFinanciero.Size = new System.Drawing.Size(96, 15);
            Lbl_PerFinanciero.TabIndex = 7;
            Lbl_PerFinanciero.Text = "Perfil Financiero:";
            // 
            // Lbl_PerUsoCta
            // 
            Lbl_PerUsoCta.AutoSize = true;
            Lbl_PerUsoCta.Location = new System.Drawing.Point(41, 312);
            Lbl_PerUsoCta.Name = "Lbl_PerUsoCta";
            Lbl_PerUsoCta.Size = new System.Drawing.Size(90, 15);
            Lbl_PerUsoCta.TabIndex = 8;
            Lbl_PerUsoCta.Text = "Period Uso Cta:";
            // 
            // Lbl_NroTransacciones
            // 
            Lbl_NroTransacciones.AutoSize = true;
            Lbl_NroTransacciones.Location = new System.Drawing.Point(20, 341);
            Lbl_NroTransacciones.Name = "Lbl_NroTransacciones";
            Lbl_NroTransacciones.Size = new System.Drawing.Size(111, 15);
            Lbl_NroTransacciones.TabIndex = 10;
            Lbl_NroTransacciones.Text = "Nro Transacciones:";
            // 
            // Lbl_FecUltAct
            // 
            Lbl_FecUltAct.AutoSize = true;
            Lbl_FecUltAct.Location = new System.Drawing.Point(49, 368);
            Lbl_FecUltAct.Name = "Lbl_FecUltAct";
            Lbl_FecUltAct.Size = new System.Drawing.Size(82, 15);
            Lbl_FecUltAct.TabIndex = 12;
            Lbl_FecUltAct.Text = "Fec Ultim Act:";
            // 
            // Lbl_ToTrimestral
            // 
            Lbl_ToTrimestral.AutoSize = true;
            Lbl_ToTrimestral.Location = new System.Drawing.Point(577, 366);
            Lbl_ToTrimestral.Name = "Lbl_ToTrimestral";
            Lbl_ToTrimestral.Size = new System.Drawing.Size(47, 15);
            Lbl_ToTrimestral.TabIndex = 20;
            Lbl_ToTrimestral.Text = "Monto:";
            // 
            // iG_TipDocIDLabel
            // 
            iG_TipDocIDLabel.AutoSize = true;
            iG_TipDocIDLabel.Location = new System.Drawing.Point(8, 14);
            iG_TipDocIDLabel.Name = "iG_TipDocIDLabel";
            iG_TipDocIDLabel.Size = new System.Drawing.Size(76, 15);
            iG_TipDocIDLabel.TabIndex = 1;
            iG_TipDocIDLabel.Text = "Tipo Doc ID:";
            // 
            // Lbl_FecVencDocID
            // 
            Lbl_FecVencDocID.AutoSize = true;
            Lbl_FecVencDocID.Location = new System.Drawing.Point(46, 44);
            Lbl_FecVencDocID.Name = "Lbl_FecVencDocID";
            Lbl_FecVencDocID.Size = new System.Drawing.Size(108, 15);
            Lbl_FecVencDocID.TabIndex = 3;
            Lbl_FecVencDocID.Text = "Fec. Venc. Doc. ID:";
            // 
            // Lbl_Nacionalidad
            // 
            Lbl_Nacionalidad.AutoSize = true;
            Lbl_Nacionalidad.Location = new System.Drawing.Point(8, 70);
            Lbl_Nacionalidad.Name = "Lbl_Nacionalidad";
            Lbl_Nacionalidad.Size = new System.Drawing.Size(80, 15);
            Lbl_Nacionalidad.TabIndex = 5;
            Lbl_Nacionalidad.Text = "Nacionalidad:";
            // 
            // Lbl_PaisNacimiento
            // 
            Lbl_PaisNacimiento.AutoSize = true;
            Lbl_PaisNacimiento.Location = new System.Drawing.Point(8, 101);
            Lbl_PaisNacimiento.Name = "Lbl_PaisNacimiento";
            Lbl_PaisNacimiento.Size = new System.Drawing.Size(95, 15);
            Lbl_PaisNacimiento.TabIndex = 7;
            Lbl_PaisNacimiento.Text = "Pais Nacimiento:";
            // 
            // Lbl_PaisResidencia
            // 
            Lbl_PaisResidencia.AutoSize = true;
            Lbl_PaisResidencia.Location = new System.Drawing.Point(8, 129);
            Lbl_PaisResidencia.Name = "Lbl_PaisResidencia";
            Lbl_PaisResidencia.Size = new System.Drawing.Size(93, 15);
            Lbl_PaisResidencia.TabIndex = 9;
            Lbl_PaisResidencia.Text = "Pais Residencia:";
            // 
            // Lbl_Estado
            // 
            Lbl_Estado.AutoSize = true;
            Lbl_Estado.Location = new System.Drawing.Point(8, 158);
            Lbl_Estado.Name = "Lbl_Estado";
            Lbl_Estado.Size = new System.Drawing.Size(98, 15);
            Lbl_Estado.TabIndex = 11;
            Lbl_Estado.Text = "Ubic. Geográfica:";
            // 
            // Lbl_Profesion
            // 
            Lbl_Profesion.AutoSize = true;
            Lbl_Profesion.Location = new System.Drawing.Point(8, 185);
            Lbl_Profesion.Name = "Lbl_Profesion";
            Lbl_Profesion.Size = new System.Drawing.Size(61, 15);
            Lbl_Profesion.TabIndex = 25;
            Lbl_Profesion.Text = "Profesión:";
            // 
            // Lbl_ActivComercial
            // 
            Lbl_ActivComercial.AutoSize = true;
            Lbl_ActivComercial.Location = new System.Drawing.Point(8, 213);
            Lbl_ActivComercial.Name = "Lbl_ActivComercial";
            Lbl_ActivComercial.Size = new System.Drawing.Size(118, 15);
            Lbl_ActivComercial.TabIndex = 27;
            Lbl_ActivComercial.Text = "Actividad Comercial:";
            // 
            // Lbl_TipoVinculo
            // 
            Lbl_TipoVinculo.AutoSize = true;
            Lbl_TipoVinculo.Location = new System.Drawing.Point(300, 27);
            Lbl_TipoVinculo.Name = "Lbl_TipoVinculo";
            Lbl_TipoVinculo.Size = new System.Drawing.Size(100, 15);
            Lbl_TipoVinculo.TabIndex = 1;
            Lbl_TipoVinculo.Text = "Tipo Vinculación:";
            // 
            // Lbl_NmeBeneficiario
            // 
            Lbl_NmeBeneficiario.AutoSize = true;
            Lbl_NmeBeneficiario.Location = new System.Drawing.Point(300, 94);
            Lbl_NmeBeneficiario.Name = "Lbl_NmeBeneficiario";
            Lbl_NmeBeneficiario.Size = new System.Drawing.Size(52, 15);
            Lbl_NmeBeneficiario.TabIndex = 4;
            Lbl_NmeBeneficiario.Text = "Nombre:";
            // 
            // Lbl_BenefDoc_ID
            // 
            Lbl_BenefDoc_ID.AutoSize = true;
            Lbl_BenefDoc_ID.Location = new System.Drawing.Point(300, 120);
            Lbl_BenefDoc_ID.Name = "Lbl_BenefDoc_ID";
            Lbl_BenefDoc_ID.Size = new System.Drawing.Size(48, 15);
            Lbl_BenefDoc_ID.TabIndex = 6;
            Lbl_BenefDoc_ID.Text = "Doc ID:";
            // 
            // Lbl_BenefPaisNacim
            // 
            Lbl_BenefPaisNacim.AutoSize = true;
            Lbl_BenefPaisNacim.Location = new System.Drawing.Point(300, 146);
            Lbl_BenefPaisNacim.Name = "Lbl_BenefPaisNacim";
            Lbl_BenefPaisNacim.Size = new System.Drawing.Size(95, 15);
            Lbl_BenefPaisNacim.TabIndex = 10;
            Lbl_BenefPaisNacim.Text = "Pais Nacimiento:";
            // 
            // Lbl_BenefNacionalidad
            // 
            Lbl_BenefNacionalidad.AutoSize = true;
            Lbl_BenefNacionalidad.Location = new System.Drawing.Point(300, 174);
            Lbl_BenefNacionalidad.Name = "Lbl_BenefNacionalidad";
            Lbl_BenefNacionalidad.Size = new System.Drawing.Size(80, 15);
            Lbl_BenefNacionalidad.TabIndex = 12;
            Lbl_BenefNacionalidad.Text = "Nacionalidad:";
            // 
            // Lbl_BenefPaisResid
            // 
            Lbl_BenefPaisResid.AutoSize = true;
            Lbl_BenefPaisResid.Location = new System.Drawing.Point(300, 202);
            Lbl_BenefPaisResid.Name = "Lbl_BenefPaisResid";
            Lbl_BenefPaisResid.Size = new System.Drawing.Size(93, 15);
            Lbl_BenefPaisResid.TabIndex = 14;
            Lbl_BenefPaisResid.Text = "Pais Residencia:";
            // 
            // Lbl_BenefEstado
            // 
            Lbl_BenefEstado.AutoSize = true;
            Lbl_BenefEstado.Location = new System.Drawing.Point(300, 231);
            Lbl_BenefEstado.Name = "Lbl_BenefEstado";
            Lbl_BenefEstado.Size = new System.Drawing.Size(98, 15);
            Lbl_BenefEstado.TabIndex = 16;
            Lbl_BenefEstado.Text = "Ubic. Geográfica:";
            // 
            // Lbl_BenefProfesion
            // 
            Lbl_BenefProfesion.AutoSize = true;
            Lbl_BenefProfesion.Location = new System.Drawing.Point(300, 259);
            Lbl_BenefProfesion.Name = "Lbl_BenefProfesion";
            Lbl_BenefProfesion.Size = new System.Drawing.Size(61, 15);
            Lbl_BenefProfesion.TabIndex = 20;
            Lbl_BenefProfesion.Text = "Profesion:";
            // 
            // Lbl_BenefVincPorcent
            // 
            Lbl_BenefVincPorcent.AutoSize = true;
            Lbl_BenefVincPorcent.Location = new System.Drawing.Point(300, 340);
            Lbl_BenefVincPorcent.Name = "Lbl_BenefVincPorcent";
            Lbl_BenefVincPorcent.Size = new System.Drawing.Size(82, 15);
            Lbl_BenefVincPorcent.TabIndex = 26;
            Lbl_BenefVincPorcent.Text = "% Accionario:";
            // 
            // Lbl_BenefVincEmpresa
            // 
            Lbl_BenefVincEmpresa.AutoSize = true;
            Lbl_BenefVincEmpresa.Location = new System.Drawing.Point(300, 315);
            Lbl_BenefVincEmpresa.Name = "Lbl_BenefVincEmpresa";
            Lbl_BenefVincEmpresa.Size = new System.Drawing.Size(105, 15);
            Lbl_BenefVincEmpresa.TabIndex = 60;
            Lbl_BenefVincEmpresa.Text = "Es Benef. Final en:";
            // 
            // Lbl_BenefCriptomonedas
            // 
            Lbl_BenefCriptomonedas.AutoSize = true;
            Lbl_BenefCriptomonedas.Location = new System.Drawing.Point(300, 287);
            Lbl_BenefCriptomonedas.Name = "Lbl_BenefCriptomonedas";
            Lbl_BenefCriptomonedas.Size = new System.Drawing.Size(112, 15);
            Lbl_BenefCriptomonedas.TabIndex = 58;
            Lbl_BenefCriptomonedas.Text = "Maneja Criptomon.:";
            // 
            // Lbl_Productos
            // 
            Lbl_Productos.AutoSize = true;
            Lbl_Productos.Location = new System.Drawing.Point(479, 243);
            Lbl_Productos.Name = "Lbl_Productos";
            Lbl_Productos.Size = new System.Drawing.Size(65, 15);
            Lbl_Productos.TabIndex = 40;
            Lbl_Productos.Text = "Productos:";
            // 
            // Lbl_Servicios
            // 
            Lbl_Servicios.AutoSize = true;
            Lbl_Servicios.Location = new System.Drawing.Point(144, 243);
            Lbl_Servicios.Name = "Lbl_Servicios";
            Lbl_Servicios.Size = new System.Drawing.Size(59, 15);
            Lbl_Servicios.TabIndex = 41;
            Lbl_Servicios.Text = "Servicios:";
            // 
            // Lbl_Criptomonedas
            // 
            Lbl_Criptomonedas.AutoSize = true;
            Lbl_Criptomonedas.Location = new System.Drawing.Point(391, 156);
            Lbl_Criptomonedas.Name = "Lbl_Criptomonedas";
            Lbl_Criptomonedas.Size = new System.Drawing.Size(134, 15);
            Lbl_Criptomonedas.TabIndex = 39;
            Lbl_Criptomonedas.Text = "Maneja Criptomonedas:";
            // 
            // Lbl_VolOperaciones
            // 
            Lbl_VolOperaciones.AutoSize = true;
            Lbl_VolOperaciones.Location = new System.Drawing.Point(426, 128);
            Lbl_VolOperaciones.Name = "Lbl_VolOperaciones";
            Lbl_VolOperaciones.Size = new System.Drawing.Size(99, 15);
            Lbl_VolOperaciones.TabIndex = 38;
            Lbl_VolOperaciones.Text = "Vol. Operaciones:";
            // 
            // Lbl_PEP
            // 
            Lbl_PEP.AutoSize = true;
            Lbl_PEP.Location = new System.Drawing.Point(479, 100);
            Lbl_PEP.Name = "Lbl_PEP";
            Lbl_PEP.Size = new System.Drawing.Size(46, 15);
            Lbl_PEP.TabIndex = 37;
            Lbl_PEP.Text = "P.E.P.\'s:";
            // 
            // Lbl_TipoEstructura
            // 
            Lbl_TipoEstructura.AutoSize = true;
            Lbl_TipoEstructura.Location = new System.Drawing.Point(432, 72);
            Lbl_TipoEstructura.Name = "Lbl_TipoEstructura";
            Lbl_TipoEstructura.Size = new System.Drawing.Size(93, 15);
            Lbl_TipoEstructura.TabIndex = 36;
            Lbl_TipoEstructura.Text = "Tipo Estructura:";
            // 
            // iG_TipoPersJurLabel
            // 
            iG_TipoPersJurLabel.AutoSize = true;
            iG_TipoPersJurLabel.Location = new System.Drawing.Point(417, 44);
            iG_TipoPersJurLabel.Name = "iG_TipoPersJurLabel";
            iG_TipoPersJurLabel.Size = new System.Drawing.Size(108, 15);
            iG_TipoPersJurLabel.TabIndex = 35;
            iG_TipoPersJurLabel.Text = "Tipo Pers. Jurídica:";
            // 
            // Lbl_Edad
            // 
            Lbl_Edad.AutoSize = true;
            Lbl_Edad.Location = new System.Drawing.Point(488, 14);
            Lbl_Edad.Name = "Lbl_Edad";
            Lbl_Edad.Size = new System.Drawing.Size(37, 15);
            Lbl_Edad.TabIndex = 34;
            Lbl_Edad.Text = "Edad:";
            // 
            // Lbl_BenefPEP
            // 
            Lbl_BenefPEP.AutoSize = true;
            Lbl_BenefPEP.Location = new System.Drawing.Point(672, 204);
            Lbl_BenefPEP.Name = "Lbl_BenefPEP";
            Lbl_BenefPEP.Size = new System.Drawing.Size(46, 15);
            Lbl_BenefPEP.TabIndex = 66;
            Lbl_BenefPEP.Text = "P.E.P.\'s:";
            // 
            // Lbl_BenefEdad
            // 
            Lbl_BenefEdad.AutoSize = true;
            Lbl_BenefEdad.Location = new System.Drawing.Point(672, 148);
            Lbl_BenefEdad.Name = "Lbl_BenefEdad";
            Lbl_BenefEdad.Size = new System.Drawing.Size(37, 15);
            Lbl_BenefEdad.TabIndex = 65;
            Lbl_BenefEdad.Text = "Edad:";
            // 
            // Lbl_BenefFecVenc
            // 
            Lbl_BenefFecVenc.AutoSize = true;
            Lbl_BenefFecVenc.Location = new System.Drawing.Point(540, 121);
            Lbl_BenefFecVenc.Name = "Lbl_BenefFecVenc";
            Lbl_BenefFecVenc.Size = new System.Drawing.Size(61, 15);
            Lbl_BenefFecVenc.TabIndex = 64;
            Lbl_BenefFecVenc.Text = "Fec Venc.:";
            // 
            // Lbl_ToTrimestre
            // 
            Lbl_ToTrimestre.AutoSize = true;
            Lbl_ToTrimestre.Location = new System.Drawing.Point(587, 259);
            Lbl_ToTrimestre.Name = "Lbl_ToTrimestre";
            Lbl_ToTrimestre.Size = new System.Drawing.Size(169, 15);
            Lbl_ToTrimestre.TabIndex = 30;
            Lbl_ToTrimestre.Text = "Total Movilizado del Trimestre";
            // 
            // Lbl_NroOperaciones
            // 
            Lbl_NroOperaciones.AutoSize = true;
            Lbl_NroOperaciones.Location = new System.Drawing.Point(577, 343);
            Lbl_NroOperaciones.Name = "Lbl_NroOperaciones";
            Lbl_NroOperaciones.Size = new System.Drawing.Size(103, 15);
            Lbl_NroOperaciones.TabIndex = 31;
            Lbl_NroOperaciones.Text = "Nro. Operaciones:";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(138, 540);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(33, 36);
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(63, 540);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(33, 36);
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
            this.TSB_Siguiente.Click += new System.EventHandler(this.TSB_Siguiente_Click);
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
            this.TS_BarraHerramientas.Location = new System.Drawing.Point(537, 10);
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
            this.TSB_Anterior.Click += new System.EventHandler(this.TSB_Anterior_Click);
            // 
            // TSB_Ultimo
            // 
            this.TSB_Ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Ultimo.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ultimo.Image")));
            this.TSB_Ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ultimo.Name = "TSB_Ultimo";
            this.TSB_Ultimo.Size = new System.Drawing.Size(40, 40);
            this.TSB_Ultimo.Text = "Último";
            this.TSB_Ultimo.Click += new System.EventHandler(this.TSB_Ultimo_Click);
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
            this.TSB_Agregar.Click += new System.EventHandler(this.TSB_Agregar_Click);
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
            this.Tab_Clientes.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tab_Clientes.Controls.Add(this.Pag1);
            this.Tab_Clientes.Controls.Add(this.Pag2);
            this.Tab_Clientes.Controls.Add(this.Pag3);
            this.Tab_Clientes.Controls.Add(this.Pag4);
            this.Tab_Clientes.Controls.Add(this.Pag5);
            this.Tab_Clientes.Location = new System.Drawing.Point(245, 120);
            this.Tab_Clientes.Name = "Tab_Clientes";
            this.Tab_Clientes.SelectedIndex = 0;
            this.Tab_Clientes.Size = new System.Drawing.Size(808, 460);
            this.Tab_Clientes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Tab_Clientes.TabIndex = 48;
            // 
            // Pag1
            // 
            this.Pag1.AutoScroll = true;
            this.Pag1.Controls.Add(Lbl_Productos);
            this.Pag1.Controls.Add(Lbl_Servicios);
            this.Pag1.Controls.Add(Lbl_Criptomonedas);
            this.Pag1.Controls.Add(Lbl_VolOperaciones);
            this.Pag1.Controls.Add(Lbl_PEP);
            this.Pag1.Controls.Add(Lbl_TipoEstructura);
            this.Pag1.Controls.Add(iG_TipoPersJurLabel);
            this.Pag1.Controls.Add(Lbl_Edad);
            this.Pag1.Controls.Add(Lbl_ActivComercial);
            this.Pag1.Controls.Add(Lbl_Profesion);
            this.Pag1.Controls.Add(Lbl_Estado);
            this.Pag1.Controls.Add(Lbl_PaisResidencia);
            this.Pag1.Controls.Add(Lbl_PaisNacimiento);
            this.Pag1.Controls.Add(Lbl_Nacionalidad);
            this.Pag1.Controls.Add(Lbl_FecVencDocID);
            this.Pag1.Controls.Add(iG_TipDocIDLabel);
            this.Pag1.Controls.Add(this.Pan_Detalles1);
            this.Pag1.Location = new System.Drawing.Point(4, 27);
            this.Pag1.Name = "Pag1";
            this.Pag1.Padding = new System.Windows.Forms.Padding(3);
            this.Pag1.Size = new System.Drawing.Size(800, 429);
            this.Pag1.TabIndex = 0;
            this.Pag1.Text = "Información General : 2";
            this.Pag1.UseVisualStyleBackColor = true;
            // 
            // Pan_Detalles1
            // 
            this.Pan_Detalles1.Controls.Add(this.comboBox1);
            this.Pan_Detalles1.Controls.Add(this.Cmb_Antiguedad);
            this.Pan_Detalles1.Controls.Add(this.Cmb_TipDocID);
            this.Pan_Detalles1.Controls.Add(this.Lst_Productos);
            this.Pan_Detalles1.Controls.Add(this.Cmb_Criptomonedas);
            this.Pan_Detalles1.Controls.Add(this.Cmb_VolOperNat);
            this.Pan_Detalles1.Controls.Add(this.Cmb_PEP);
            this.Pan_Detalles1.Controls.Add(this.Cmb_TipoEstructura);
            this.Pan_Detalles1.Controls.Add(this.Cmb_TipoPersJuridica);
            this.Pan_Detalles1.Controls.Add(this.Cmb_Edad);
            this.Pan_Detalles1.Controls.Add(this.Lst_Servicios);
            this.Pan_Detalles1.Controls.Add(this.Cmb_ActivComercial);
            this.Pan_Detalles1.Controls.Add(this.Cmb_Profesion);
            this.Pan_Detalles1.Controls.Add(this.Cmb_Estado);
            this.Pan_Detalles1.Controls.Add(this.Cmb_PaisResidencia);
            this.Pan_Detalles1.Controls.Add(this.Cmb_PaisNacimiento);
            this.Pan_Detalles1.Controls.Add(this.Cmb_Nacionalidad);
            this.Pan_Detalles1.Controls.Add(this.DTP_FecVencDocID);
            this.Pan_Detalles1.Location = new System.Drawing.Point(125, 8);
            this.Pan_Detalles1.Name = "Pan_Detalles1";
            this.Pan_Detalles1.Size = new System.Drawing.Size(674, 415);
            this.Pan_Detalles1.TabIndex = 33;
            // 
            // Cmb_TipDocID
            // 
            this.Cmb_TipDocID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_TipDocID", true));
            this.Cmb_TipDocID.DataSource = this.BS_MTipoDocID;
            this.Cmb_TipDocID.DisplayMember = "Descripcion";
            this.Cmb_TipDocID.FormattingEnabled = true;
            this.Cmb_TipDocID.Location = new System.Drawing.Point(4, 6);
            this.Cmb_TipDocID.Name = "Cmb_TipDocID";
            this.Cmb_TipDocID.Size = new System.Drawing.Size(250, 23);
            this.Cmb_TipDocID.TabIndex = 49;
            this.Cmb_TipDocID.ValueMember = "Codigo";
            // 
            // BS_CClientes
            // 
            this.BS_CClientes.DataSource = typeof(MofinModelo.C_Clientes);
            // 
            // BS_MTipoDocID
            // 
            this.BS_MTipoDocID.DataSource = typeof(MofinModelo.M_TipoDocID);
            // 
            // Lst_Productos
            // 
            this.Lst_Productos.FormattingEnabled = true;
            this.Lst_Productos.ItemHeight = 15;
            this.Lst_Productos.Location = new System.Drawing.Point(330, 256);
            this.Lst_Productos.Name = "Lst_Productos";
            this.Lst_Productos.Size = new System.Drawing.Size(320, 154);
            this.Lst_Productos.TabIndex = 48;
            // 
            // Cmb_Criptomonedas
            // 
            this.Cmb_Criptomonedas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_Criptomoneda", true));
            this.Cmb_Criptomonedas.DataSource = this.BS_MCriptomonedas;
            this.Cmb_Criptomonedas.DisplayMember = "Descripcion";
            this.Cmb_Criptomonedas.FormattingEnabled = true;
            this.Cmb_Criptomonedas.Location = new System.Drawing.Point(404, 145);
            this.Cmb_Criptomonedas.Name = "Cmb_Criptomonedas";
            this.Cmb_Criptomonedas.Size = new System.Drawing.Size(250, 23);
            this.Cmb_Criptomonedas.TabIndex = 47;
            this.Cmb_Criptomonedas.ValueMember = "Codigo";
            // 
            // BS_MCriptomonedas
            // 
            this.BS_MCriptomonedas.DataSource = typeof(MofinModelo.M_Criptomonedas);
            // 
            // Cmb_VolOperNat
            // 
            this.Cmb_VolOperNat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_VolumOperac", true));
            this.Cmb_VolOperNat.DataSource = this.BS_MVolOperPersNat;
            this.Cmb_VolOperNat.DisplayMember = "Descripcion";
            this.Cmb_VolOperNat.FormattingEnabled = true;
            this.Cmb_VolOperNat.Location = new System.Drawing.Point(404, 117);
            this.Cmb_VolOperNat.Name = "Cmb_VolOperNat";
            this.Cmb_VolOperNat.Size = new System.Drawing.Size(250, 23);
            this.Cmb_VolOperNat.TabIndex = 46;
            this.Cmb_VolOperNat.ValueMember = "Codigo";
            // 
            // BS_MVolOperPersNat
            // 
            this.BS_MVolOperPersNat.DataSource = typeof(MofinModelo.M_VolOperPersNat);
            // 
            // Cmb_PEP
            // 
            this.Cmb_PEP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_PEP", true));
            this.Cmb_PEP.DataSource = this.BS_MPEP;
            this.Cmb_PEP.DisplayMember = "Descripcion";
            this.Cmb_PEP.FormattingEnabled = true;
            this.Cmb_PEP.Location = new System.Drawing.Point(404, 89);
            this.Cmb_PEP.Name = "Cmb_PEP";
            this.Cmb_PEP.Size = new System.Drawing.Size(250, 23);
            this.Cmb_PEP.TabIndex = 45;
            this.Cmb_PEP.ValueMember = "Codigo";
            // 
            // BS_MPEP
            // 
            this.BS_MPEP.DataSource = typeof(MofinModelo.M_PEP);
            // 
            // Cmb_TipoEstructura
            // 
            this.Cmb_TipoEstructura.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_TipoEstructura", true));
            this.Cmb_TipoEstructura.DataSource = this.BS_MTipoEstructuraEmpresa;
            this.Cmb_TipoEstructura.DisplayMember = "Descripcion";
            this.Cmb_TipoEstructura.FormattingEnabled = true;
            this.Cmb_TipoEstructura.Location = new System.Drawing.Point(404, 61);
            this.Cmb_TipoEstructura.Name = "Cmb_TipoEstructura";
            this.Cmb_TipoEstructura.Size = new System.Drawing.Size(250, 23);
            this.Cmb_TipoEstructura.TabIndex = 44;
            this.Cmb_TipoEstructura.ValueMember = "Codigo";
            // 
            // BS_MTipoEstructuraEmpresa
            // 
            this.BS_MTipoEstructuraEmpresa.DataSource = typeof(MofinModelo.M_TipoEstructuraEmpresa);
            // 
            // Cmb_TipoPersJuridica
            // 
            this.Cmb_TipoPersJuridica.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_TipoPersJur", true));
            this.Cmb_TipoPersJuridica.DataSource = this.BS_MTipoPersJuridica;
            this.Cmb_TipoPersJuridica.DisplayMember = "Descripcion";
            this.Cmb_TipoPersJuridica.FormattingEnabled = true;
            this.Cmb_TipoPersJuridica.Location = new System.Drawing.Point(404, 33);
            this.Cmb_TipoPersJuridica.Name = "Cmb_TipoPersJuridica";
            this.Cmb_TipoPersJuridica.Size = new System.Drawing.Size(250, 23);
            this.Cmb_TipoPersJuridica.TabIndex = 43;
            this.Cmb_TipoPersJuridica.ValueMember = "Codigo";
            // 
            // BS_MTipoPersJuridica
            // 
            this.BS_MTipoPersJuridica.DataSource = typeof(MofinModelo.M_TipoPersJuridica);
            // 
            // Cmb_Edad
            // 
            this.Cmb_Edad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_Edad", true));
            this.Cmb_Edad.DataSource = this.BS_MEdad;
            this.Cmb_Edad.DisplayMember = "Descripcion";
            this.Cmb_Edad.FormattingEnabled = true;
            this.Cmb_Edad.Location = new System.Drawing.Point(404, 3);
            this.Cmb_Edad.Name = "Cmb_Edad";
            this.Cmb_Edad.Size = new System.Drawing.Size(250, 23);
            this.Cmb_Edad.TabIndex = 42;
            this.Cmb_Edad.ValueMember = "Codigo";
            // 
            // BS_MEdad
            // 
            this.BS_MEdad.DataSource = typeof(MofinModelo.M_Edad);
            // 
            // Lst_Servicios
            // 
            this.Lst_Servicios.FormattingEnabled = true;
            this.Lst_Servicios.ItemHeight = 15;
            this.Lst_Servicios.Location = new System.Drawing.Point(4, 256);
            this.Lst_Servicios.Name = "Lst_Servicios";
            this.Lst_Servicios.Size = new System.Drawing.Size(320, 154);
            this.Lst_Servicios.TabIndex = 41;
            // 
            // Cmb_ActivComercial
            // 
            this.Cmb_ActivComercial.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_ActivComer", true));
            this.Cmb_ActivComercial.DataSource = this.BS_MActivComercial;
            this.Cmb_ActivComercial.DisplayMember = "Descripcion";
            this.Cmb_ActivComercial.FormattingEnabled = true;
            this.Cmb_ActivComercial.Location = new System.Drawing.Point(4, 202);
            this.Cmb_ActivComercial.Name = "Cmb_ActivComercial";
            this.Cmb_ActivComercial.Size = new System.Drawing.Size(650, 23);
            this.Cmb_ActivComercial.TabIndex = 40;
            this.Cmb_ActivComercial.ValueMember = "Codigo";
            // 
            // BS_MActivComercial
            // 
            this.BS_MActivComercial.DataSource = typeof(MofinModelo.M_ActivComercial);
            // 
            // Cmb_Profesion
            // 
            this.Cmb_Profesion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_Profesion", true));
            this.Cmb_Profesion.DataSource = this.BS_MProfesiones;
            this.Cmb_Profesion.DisplayMember = "Descripcion";
            this.Cmb_Profesion.FormattingEnabled = true;
            this.Cmb_Profesion.Location = new System.Drawing.Point(4, 174);
            this.Cmb_Profesion.Name = "Cmb_Profesion";
            this.Cmb_Profesion.Size = new System.Drawing.Size(650, 23);
            this.Cmb_Profesion.TabIndex = 39;
            this.Cmb_Profesion.ValueMember = "Codigo";
            // 
            // BS_MProfesiones
            // 
            this.BS_MProfesiones.DataSource = typeof(MofinModelo.M_Profesiones);
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_Estado", true));
            this.Cmb_Estado.DataSource = this.BS_MEstados;
            this.Cmb_Estado.DisplayMember = "Descripcion";
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(4, 144);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(205, 23);
            this.Cmb_Estado.TabIndex = 38;
            this.Cmb_Estado.ValueMember = "Codigo";
            // 
            // BS_MEstados
            // 
            this.BS_MEstados.DataSource = typeof(MofinModelo.M_Estados);
            // 
            // Cmb_PaisResidencia
            // 
            this.Cmb_PaisResidencia.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_PaisResid", true));
            this.Cmb_PaisResidencia.DataSource = this.BS_Res;
            this.Cmb_PaisResidencia.DisplayMember = "Descripcion";
            this.Cmb_PaisResidencia.FormattingEnabled = true;
            this.Cmb_PaisResidencia.Location = new System.Drawing.Point(4, 116);
            this.Cmb_PaisResidencia.Name = "Cmb_PaisResidencia";
            this.Cmb_PaisResidencia.Size = new System.Drawing.Size(250, 23);
            this.Cmb_PaisResidencia.TabIndex = 37;
            this.Cmb_PaisResidencia.ValueMember = "Codigo";
            this.Cmb_PaisResidencia.SelectedIndexChanged += new System.EventHandler(this.Cmb_PaisResidencia_SelectedIndexChanged);
            // 
            // BS_Res
            // 
            this.BS_Res.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // Cmb_PaisNacimiento
            // 
            this.Cmb_PaisNacimiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_PaisNacim", true));
            this.Cmb_PaisNacimiento.DataSource = this.BS_Nac;
            this.Cmb_PaisNacimiento.DisplayMember = "Descripcion";
            this.Cmb_PaisNacimiento.FormattingEnabled = true;
            this.Cmb_PaisNacimiento.Location = new System.Drawing.Point(4, 88);
            this.Cmb_PaisNacimiento.Name = "Cmb_PaisNacimiento";
            this.Cmb_PaisNacimiento.Size = new System.Drawing.Size(250, 23);
            this.Cmb_PaisNacimiento.TabIndex = 36;
            this.Cmb_PaisNacimiento.ValueMember = "Codigo";
            // 
            // BS_Nac
            // 
            this.BS_Nac.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // Cmb_Nacionalidad
            // 
            this.Cmb_Nacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CClientes, "IG_Nacionalidad", true));
            this.Cmb_Nacionalidad.DataSource = this.BS_MPais;
            this.Cmb_Nacionalidad.DisplayMember = "Descripcion";
            this.Cmb_Nacionalidad.FormattingEnabled = true;
            this.Cmb_Nacionalidad.Location = new System.Drawing.Point(4, 60);
            this.Cmb_Nacionalidad.Name = "Cmb_Nacionalidad";
            this.Cmb_Nacionalidad.Size = new System.Drawing.Size(250, 23);
            this.Cmb_Nacionalidad.TabIndex = 35;
            this.Cmb_Nacionalidad.ValueMember = "Codigo";
            // 
            // BS_MPais
            // 
            this.BS_MPais.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // DTP_FecVencDocID
            // 
            this.DTP_FecVencDocID.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "IG_FecVencDocID", true));
            this.DTP_FecVencDocID.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FecVencDocID.Location = new System.Drawing.Point(47, 33);
            this.DTP_FecVencDocID.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DTP_FecVencDocID.Name = "DTP_FecVencDocID";
            this.DTP_FecVencDocID.Size = new System.Drawing.Size(105, 22);
            this.DTP_FecVencDocID.TabIndex = 34;
            this.DTP_FecVencDocID.Value = new System.DateTime(2018, 12, 30, 19, 29, 21, 0);
            // 
            // Pag2
            // 
            this.Pag2.AutoScroll = true;
            this.Pag2.Controls.Add(Lbl_BenefPEP);
            this.Pag2.Controls.Add(Lbl_BenefEdad);
            this.Pag2.Controls.Add(Lbl_BenefFecVenc);
            this.Pag2.Controls.Add(this.Pan_BenefBtns);
            this.Pag2.Controls.Add(Lbl_BenefVincEmpresa);
            this.Pag2.Controls.Add(Lbl_BenefCriptomonedas);
            this.Pag2.Controls.Add(this.Lbl_BenefEtiqPuntuacion);
            this.Pag2.Controls.Add(this.Lbl_BenefPuntuacion);
            this.Pag2.Controls.Add(Lbl_BenefVincPorcent);
            this.Pag2.Controls.Add(Lbl_BenefProfesion);
            this.Pag2.Controls.Add(Lbl_BenefEstado);
            this.Pag2.Controls.Add(Lbl_BenefPaisResid);
            this.Pag2.Controls.Add(Lbl_BenefNacionalidad);
            this.Pag2.Controls.Add(Lbl_BenefPaisNacim);
            this.Pag2.Controls.Add(Lbl_BenefDoc_ID);
            this.Pag2.Controls.Add(Lbl_NmeBeneficiario);
            this.Pag2.Controls.Add(Lbl_TipoVinculo);
            this.Pag2.Controls.Add(this.Pan_Detalles2);
            this.Pag2.Location = new System.Drawing.Point(4, 27);
            this.Pag2.Name = "Pag2";
            this.Pag2.Padding = new System.Windows.Forms.Padding(3);
            this.Pag2.Size = new System.Drawing.Size(800, 429);
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
            this.Pan_BenefBtns.Location = new System.Drawing.Point(61, 367);
            this.Pan_BenefBtns.Name = "Pan_BenefBtns";
            this.Pan_BenefBtns.Size = new System.Drawing.Size(581, 43);
            this.Pan_BenefBtns.TabIndex = 62;
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
            this.Btn_BenefIncluir.Location = new System.Drawing.Point(20, 4);
            this.Btn_BenefIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefIncluir.Name = "Btn_BenefIncluir";
            this.Btn_BenefIncluir.Size = new System.Drawing.Size(33, 36);
            this.Btn_BenefIncluir.TabIndex = 59;
            this.Btn_BenefIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefIncluir.UseVisualStyleBackColor = true;
            this.Btn_BenefIncluir.Click += new System.EventHandler(this.Btn_BenefIncluir_Click);
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
            this.Btn_BenefEliminar.Location = new System.Drawing.Point(135, 4);
            this.Btn_BenefEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefEliminar.Name = "Btn_BenefEliminar";
            this.Btn_BenefEliminar.Size = new System.Drawing.Size(33, 36);
            this.Btn_BenefEliminar.TabIndex = 61;
            this.Btn_BenefEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefEliminar.UseVisualStyleBackColor = true;
            this.Btn_BenefEliminar.Click += new System.EventHandler(this.Btn_BenefEliminar_Click);
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
            this.Btn_BenefModificar.Location = new System.Drawing.Point(77, 4);
            this.Btn_BenefModificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefModificar.Name = "Btn_BenefModificar";
            this.Btn_BenefModificar.Size = new System.Drawing.Size(33, 36);
            this.Btn_BenefModificar.TabIndex = 60;
            this.Btn_BenefModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefModificar.UseVisualStyleBackColor = true;
            this.Btn_BenefModificar.Click += new System.EventHandler(this.Btn_BenefModificar_Click);
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
            this.Btn_BenefAceptar.Location = new System.Drawing.Point(462, 4);
            this.Btn_BenefAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefAceptar.Name = "Btn_BenefAceptar";
            this.Btn_BenefAceptar.Size = new System.Drawing.Size(33, 36);
            this.Btn_BenefAceptar.TabIndex = 57;
            this.Btn_BenefAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefAceptar.UseVisualStyleBackColor = true;
            this.Btn_BenefAceptar.Click += new System.EventHandler(this.Btn_BenefAceptar_Click);
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
            this.Btn_BenefCancelar.Location = new System.Drawing.Point(531, 4);
            this.Btn_BenefCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BenefCancelar.Name = "Btn_BenefCancelar";
            this.Btn_BenefCancelar.Size = new System.Drawing.Size(33, 36);
            this.Btn_BenefCancelar.TabIndex = 58;
            this.Btn_BenefCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_BenefCancelar.UseVisualStyleBackColor = true;
            this.Btn_BenefCancelar.Click += new System.EventHandler(this.Btn_BenefCancelar_Click);
            // 
            // Lbl_BenefEtiqPuntuacion
            // 
            this.Lbl_BenefEtiqPuntuacion.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BenefEtiqPuntuacion.Location = new System.Drawing.Point(695, 10);
            this.Lbl_BenefEtiqPuntuacion.Name = "Lbl_BenefEtiqPuntuacion";
            this.Lbl_BenefEtiqPuntuacion.Size = new System.Drawing.Size(52, 11);
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
            this.Lbl_BenefPuntuacion.Location = new System.Drawing.Point(693, 8);
            this.Lbl_BenefPuntuacion.Name = "Lbl_BenefPuntuacion";
            this.Lbl_BenefPuntuacion.Size = new System.Drawing.Size(57, 66);
            this.Lbl_BenefPuntuacion.TabIndex = 53;
            this.Lbl_BenefPuntuacion.Text = "2";
            this.Lbl_BenefPuntuacion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Pan_Detalles2
            // 
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefCriptomonedas);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefPEP);
            this.Pan_Detalles2.Controls.Add(this.Nud_BenefVincPorcent);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefVincEmpresa);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefProfesion);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefEdad);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefEstado);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefPaisResid);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefNacionalidad);
            this.Pan_Detalles2.Controls.Add(this.Cmb_BenefPaisNacim);
            this.Pan_Detalles2.Controls.Add(this.Dtp_BenefFec_Venc);
            this.Pan_Detalles2.Controls.Add(this.Txt_BenefDoc_ID);
            this.Pan_Detalles2.Controls.Add(this.Txt_BenefNme);
            this.Pan_Detalles2.Controls.Add(this.Grp_BenfTipoVinculacion);
            this.Pan_Detalles2.Controls.Add(this.Grd_CFirBenAcc);
            this.Pan_Detalles2.Location = new System.Drawing.Point(9, 6);
            this.Pan_Detalles2.Name = "Pan_Detalles2";
            this.Pan_Detalles2.Size = new System.Drawing.Size(776, 356);
            this.Pan_Detalles2.TabIndex = 63;
            // 
            // Cmb_BenefCriptomonedas
            // 
            this.Cmb_BenefCriptomonedas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "Criptomoneda", true));
            this.Cmb_BenefCriptomonedas.DataSource = this.BS_AutCriptomoneda;
            this.Cmb_BenefCriptomonedas.DisplayMember = "Descripcion";
            this.Cmb_BenefCriptomonedas.FormattingEnabled = true;
            this.Cmb_BenefCriptomonedas.Location = new System.Drawing.Point(404, 279);
            this.Cmb_BenefCriptomonedas.Name = "Cmb_BenefCriptomonedas";
            this.Cmb_BenefCriptomonedas.Size = new System.Drawing.Size(200, 23);
            this.Cmb_BenefCriptomonedas.TabIndex = 74;
            this.Cmb_BenefCriptomonedas.ValueMember = "Codigo";
            // 
            // BS_CFirBenAcc
            // 
            this.BS_CFirBenAcc.DataSource = typeof(MofinModelo.C_FirBenAcc);
            // 
            // BS_AutCriptomoneda
            // 
            this.BS_AutCriptomoneda.DataSource = typeof(MofinModelo.M_Criptomonedas);
            // 
            // Cmb_BenefPEP
            // 
            this.Cmb_BenefPEP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "PEP", true));
            this.Cmb_BenefPEP.DataSource = this.BS_AutPEP;
            this.Cmb_BenefPEP.DisplayMember = "Descripcion";
            this.Cmb_BenefPEP.FormattingEnabled = true;
            this.Cmb_BenefPEP.Location = new System.Drawing.Point(610, 223);
            this.Cmb_BenefPEP.Name = "Cmb_BenefPEP";
            this.Cmb_BenefPEP.Size = new System.Drawing.Size(150, 23);
            this.Cmb_BenefPEP.TabIndex = 73;
            this.Cmb_BenefPEP.ValueMember = "Codigo";
            // 
            // BS_AutPEP
            // 
            this.BS_AutPEP.DataSource = typeof(MofinModelo.M_PEP);
            // 
            // Nud_BenefVincPorcent
            // 
            this.Nud_BenefVincPorcent.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CFirBenAcc, "VincPorcent", true));
            this.Nud_BenefVincPorcent.Location = new System.Drawing.Point(404, 334);
            this.Nud_BenefVincPorcent.Name = "Nud_BenefVincPorcent";
            this.Nud_BenefVincPorcent.Size = new System.Drawing.Size(65, 22);
            this.Nud_BenefVincPorcent.TabIndex = 72;
            // 
            // Cmb_BenefVincEmpresa
            // 
            this.Cmb_BenefVincEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "VincEmpresa", true));
            this.Cmb_BenefVincEmpresa.Location = new System.Drawing.Point(404, 308);
            this.Cmb_BenefVincEmpresa.Name = "Cmb_BenefVincEmpresa";
            this.Cmb_BenefVincEmpresa.Size = new System.Drawing.Size(356, 22);
            this.Cmb_BenefVincEmpresa.TabIndex = 71;
            // 
            // Cmb_BenefProfesion
            // 
            this.Cmb_BenefProfesion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "Profesion", true));
            this.Cmb_BenefProfesion.DataSource = this.BS_AutProfesion;
            this.Cmb_BenefProfesion.DisplayMember = "Descripcion";
            this.Cmb_BenefProfesion.FormattingEnabled = true;
            this.Cmb_BenefProfesion.Location = new System.Drawing.Point(404, 251);
            this.Cmb_BenefProfesion.Name = "Cmb_BenefProfesion";
            this.Cmb_BenefProfesion.Size = new System.Drawing.Size(356, 23);
            this.Cmb_BenefProfesion.TabIndex = 70;
            this.Cmb_BenefProfesion.ValueMember = "Codigo";
            // 
            // BS_AutProfesion
            // 
            this.BS_AutProfesion.DataSource = typeof(MofinModelo.M_Profesiones);
            // 
            // Cmb_BenefEdad
            // 
            this.Cmb_BenefEdad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "Edad", true));
            this.Cmb_BenefEdad.DataSource = this.BS_AutEdad;
            this.Cmb_BenefEdad.DisplayMember = "Descripcion";
            this.Cmb_BenefEdad.FormattingEnabled = true;
            this.Cmb_BenefEdad.Location = new System.Drawing.Point(610, 167);
            this.Cmb_BenefEdad.Name = "Cmb_BenefEdad";
            this.Cmb_BenefEdad.Size = new System.Drawing.Size(150, 23);
            this.Cmb_BenefEdad.TabIndex = 69;
            this.Cmb_BenefEdad.ValueMember = "Codigo";
            // 
            // BS_AutEdad
            // 
            this.BS_AutEdad.DataSource = typeof(MofinModelo.M_Edad);
            // 
            // Cmb_BenefEstado
            // 
            this.Cmb_BenefEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "Estado", true));
            this.Cmb_BenefEstado.DataSource = this.BS_MEstados;
            this.Cmb_BenefEstado.DisplayMember = "Descripcion";
            this.Cmb_BenefEstado.FormattingEnabled = true;
            this.Cmb_BenefEstado.Location = new System.Drawing.Point(404, 223);
            this.Cmb_BenefEstado.Name = "Cmb_BenefEstado";
            this.Cmb_BenefEstado.Size = new System.Drawing.Size(200, 23);
            this.Cmb_BenefEstado.TabIndex = 68;
            this.Cmb_BenefEstado.ValueMember = "Codigo";
            // 
            // Cmb_BenefPaisResid
            // 
            this.Cmb_BenefPaisResid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "PaisResid", true));
            this.Cmb_BenefPaisResid.DataSource = this.BS_AutRes;
            this.Cmb_BenefPaisResid.DisplayMember = "Descripcion";
            this.Cmb_BenefPaisResid.FormattingEnabled = true;
            this.Cmb_BenefPaisResid.Location = new System.Drawing.Point(404, 195);
            this.Cmb_BenefPaisResid.Name = "Cmb_BenefPaisResid";
            this.Cmb_BenefPaisResid.Size = new System.Drawing.Size(200, 23);
            this.Cmb_BenefPaisResid.TabIndex = 67;
            this.Cmb_BenefPaisResid.ValueMember = "Codigo";
            this.Cmb_BenefPaisResid.SelectedIndexChanged += new System.EventHandler(this.Cmb_BenefPaisResid_SelectedIndexChanged);
            // 
            // BS_AutRes
            // 
            this.BS_AutRes.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // Cmb_BenefNacionalidad
            // 
            this.Cmb_BenefNacionalidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "Nacionalidad", true));
            this.Cmb_BenefNacionalidad.DataSource = this.BS_AutNac;
            this.Cmb_BenefNacionalidad.DisplayMember = "Descripcion";
            this.Cmb_BenefNacionalidad.FormattingEnabled = true;
            this.Cmb_BenefNacionalidad.Location = new System.Drawing.Point(404, 167);
            this.Cmb_BenefNacionalidad.Name = "Cmb_BenefNacionalidad";
            this.Cmb_BenefNacionalidad.Size = new System.Drawing.Size(200, 23);
            this.Cmb_BenefNacionalidad.TabIndex = 66;
            this.Cmb_BenefNacionalidad.ValueMember = "Codigo";
            // 
            // BS_AutNac
            // 
            this.BS_AutNac.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // Cmb_BenefPaisNacim
            // 
            this.Cmb_BenefPaisNacim.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BS_CFirBenAcc, "PaisNacim", true));
            this.Cmb_BenefPaisNacim.DataSource = this.BS_AutPaisNac;
            this.Cmb_BenefPaisNacim.DisplayMember = "Descripcion";
            this.Cmb_BenefPaisNacim.FormattingEnabled = true;
            this.Cmb_BenefPaisNacim.Location = new System.Drawing.Point(404, 139);
            this.Cmb_BenefPaisNacim.Name = "Cmb_BenefPaisNacim";
            this.Cmb_BenefPaisNacim.Size = new System.Drawing.Size(200, 23);
            this.Cmb_BenefPaisNacim.TabIndex = 65;
            this.Cmb_BenefPaisNacim.ValueMember = "Codigo";
            // 
            // BS_AutPaisNac
            // 
            this.BS_AutPaisNac.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // Dtp_BenefFec_Venc
            // 
            this.Dtp_BenefFec_Venc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CFirBenAcc, "Fec_Vencimiento", true));
            this.Dtp_BenefFec_Venc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_BenefFec_Venc.Location = new System.Drawing.Point(610, 112);
            this.Dtp_BenefFec_Venc.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Dtp_BenefFec_Venc.Name = "Dtp_BenefFec_Venc";
            this.Dtp_BenefFec_Venc.Size = new System.Drawing.Size(150, 22);
            this.Dtp_BenefFec_Venc.TabIndex = 64;
            this.Dtp_BenefFec_Venc.Value = new System.DateTime(2018, 12, 30, 20, 18, 49, 0);
            // 
            // Txt_BenefDoc_ID
            // 
            this.Txt_BenefDoc_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Doc_ID", true));
            this.Txt_BenefDoc_ID.Location = new System.Drawing.Point(404, 112);
            this.Txt_BenefDoc_ID.Name = "Txt_BenefDoc_ID";
            this.Txt_BenefDoc_ID.Size = new System.Drawing.Size(100, 22);
            this.Txt_BenefDoc_ID.TabIndex = 63;
            // 
            // Txt_BenefNme
            // 
            this.Txt_BenefNme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CFirBenAcc, "Nombre", true));
            this.Txt_BenefNme.Location = new System.Drawing.Point(404, 86);
            this.Txt_BenefNme.Name = "Txt_BenefNme";
            this.Txt_BenefNme.Size = new System.Drawing.Size(356, 22);
            this.Txt_BenefNme.TabIndex = 62;
            // 
            // Grp_BenfTipoVinculacion
            // 
            this.Grp_BenfTipoVinculacion.Controls.Add(this.Opc_TipVinc3);
            this.Grp_BenfTipoVinculacion.Controls.Add(this.Opc_TipVinc2);
            this.Grp_BenfTipoVinculacion.Controls.Add(this.Opc_TipVinc1);
            this.Grp_BenfTipoVinculacion.Location = new System.Drawing.Point(404, 8);
            this.Grp_BenfTipoVinculacion.Name = "Grp_BenfTipoVinculacion";
            this.Grp_BenfTipoVinculacion.Size = new System.Drawing.Size(164, 72);
            this.Grp_BenfTipoVinculacion.TabIndex = 61;
            this.Grp_BenfTipoVinculacion.TabStop = false;
            // 
            // Opc_TipVinc3
            // 
            this.Opc_TipVinc3.AutoSize = true;
            this.Opc_TipVinc3.Location = new System.Drawing.Point(6, 46);
            this.Opc_TipVinc3.Name = "Opc_TipVinc3";
            this.Opc_TipVinc3.Size = new System.Drawing.Size(81, 19);
            this.Opc_TipVinc3.TabIndex = 2;
            this.Opc_TipVinc3.Text = "Cónyugue";
            this.Opc_TipVinc3.UseVisualStyleBackColor = true;
            this.Opc_TipVinc3.CheckedChanged += new System.EventHandler(this.Opc_TipVinc1_CheckedChanged);
            // 
            // Opc_TipVinc2
            // 
            this.Opc_TipVinc2.AutoSize = true;
            this.Opc_TipVinc2.Location = new System.Drawing.Point(6, 28);
            this.Opc_TipVinc2.Name = "Opc_TipVinc2";
            this.Opc_TipVinc2.Size = new System.Drawing.Size(71, 19);
            this.Opc_TipVinc2.TabIndex = 1;
            this.Opc_TipVinc2.Text = "Firmante";
            this.Opc_TipVinc2.UseVisualStyleBackColor = true;
            this.Opc_TipVinc2.CheckedChanged += new System.EventHandler(this.Opc_TipVinc1_CheckedChanged);
            // 
            // Opc_TipVinc1
            // 
            this.Opc_TipVinc1.AutoSize = true;
            this.Opc_TipVinc1.Checked = true;
            this.Opc_TipVinc1.Location = new System.Drawing.Point(6, 10);
            this.Opc_TipVinc1.Name = "Opc_TipVinc1";
            this.Opc_TipVinc1.Size = new System.Drawing.Size(117, 19);
            this.Opc_TipVinc1.TabIndex = 0;
            this.Opc_TipVinc1.TabStop = true;
            this.Opc_TipVinc1.Text = "Beneficiario Final";
            this.Opc_TipVinc1.UseVisualStyleBackColor = true;
            this.Opc_TipVinc1.CheckedChanged += new System.EventHandler(this.Opc_TipVinc1_CheckedChanged);
            // 
            // Grd_CFirBenAcc
            // 
            this.Grd_CFirBenAcc.AllowUserToAddRows = false;
            this.Grd_CFirBenAcc.AllowUserToDeleteRows = false;
            this.Grd_CFirBenAcc.AutoGenerateColumns = false;
            this.Grd_CFirBenAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_CFirBenAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.edadDataGridViewTextBoxColumn});
            this.Grd_CFirBenAcc.DataSource = this.BS_CFirBenAcc;
            this.Grd_CFirBenAcc.Location = new System.Drawing.Point(8, 18);
            this.Grd_CFirBenAcc.MultiSelect = false;
            this.Grd_CFirBenAcc.Name = "Grd_CFirBenAcc";
            this.Grd_CFirBenAcc.ReadOnly = true;
            this.Grd_CFirBenAcc.RowHeadersVisible = false;
            this.Grd_CFirBenAcc.Size = new System.Drawing.Size(278, 332);
            this.Grd_CFirBenAcc.TabIndex = 1;
            this.Grd_CFirBenAcc.CurrentCellChanged += new System.EventHandler(this.Grd_CFirBenAcc_CurrentCellChanged);
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Width = 200;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pag3
            // 
            this.Pag3.AutoScroll = true;
            this.Pag3.Controls.Add(this.Pan_Detalles3);
            this.Pag3.Location = new System.Drawing.Point(4, 27);
            this.Pag3.Name = "Pag3";
            this.Pag3.Padding = new System.Windows.Forms.Padding(3);
            this.Pag3.Size = new System.Drawing.Size(800, 429);
            this.Pag3.TabIndex = 2;
            this.Pag3.Text = "Constitución del Expediente";
            this.Pag3.UseVisualStyleBackColor = true;
            // 
            // Pan_Detalles3
            // 
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc30);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc29);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc28);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc27);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc26);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc25);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc24);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc23);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc22);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc21);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc20);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc19);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc18);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc17);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc16);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc15);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc14);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc13);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc12);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc11);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc10);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc9);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc8);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc7);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc6);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc5);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc4);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc3);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc2);
            this.Pan_Detalles3.Controls.Add(this.Chk_Opc1);
            this.Pan_Detalles3.Location = new System.Drawing.Point(9, 6);
            this.Pan_Detalles3.Name = "Pan_Detalles3";
            this.Pan_Detalles3.Size = new System.Drawing.Size(761, 412);
            this.Pan_Detalles3.TabIndex = 45;
            // 
            // Chk_Opc30
            // 
            this.Chk_Opc30.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc30", true));
            this.Chk_Opc30.Location = new System.Drawing.Point(383, 383);
            this.Chk_Opc30.Name = "Chk_Opc30";
            this.Chk_Opc30.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc30.TabIndex = 59;
            this.Chk_Opc30.Text = "OPC30";
            this.Chk_Opc30.UseVisualStyleBackColor = true;
            this.Chk_Opc30.Visible = false;
            // 
            // Chk_Opc29
            // 
            this.Chk_Opc29.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc29", true));
            this.Chk_Opc29.Location = new System.Drawing.Point(383, 357);
            this.Chk_Opc29.Name = "Chk_Opc29";
            this.Chk_Opc29.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc29.TabIndex = 58;
            this.Chk_Opc29.Text = "OPC29";
            this.Chk_Opc29.UseVisualStyleBackColor = true;
            this.Chk_Opc29.Visible = false;
            // 
            // Chk_Opc28
            // 
            this.Chk_Opc28.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc28", true));
            this.Chk_Opc28.Location = new System.Drawing.Point(383, 331);
            this.Chk_Opc28.Name = "Chk_Opc28";
            this.Chk_Opc28.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc28.TabIndex = 57;
            this.Chk_Opc28.Text = "OPC28";
            this.Chk_Opc28.UseVisualStyleBackColor = true;
            this.Chk_Opc28.Visible = false;
            // 
            // Chk_Opc27
            // 
            this.Chk_Opc27.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc27", true));
            this.Chk_Opc27.Location = new System.Drawing.Point(383, 305);
            this.Chk_Opc27.Name = "Chk_Opc27";
            this.Chk_Opc27.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc27.TabIndex = 56;
            this.Chk_Opc27.Text = "Datos del Cónyugue o Cotitular";
            this.Chk_Opc27.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc26
            // 
            this.Chk_Opc26.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc26", true));
            this.Chk_Opc26.Location = new System.Drawing.Point(383, 279);
            this.Chk_Opc26.Name = "Chk_Opc26";
            this.Chk_Opc26.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc26.TabIndex = 55;
            this.Chk_Opc26.Text = "Lugar y Fecha de Nacimiento";
            this.Chk_Opc26.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc25
            // 
            this.Chk_Opc25.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc25", true));
            this.Chk_Opc25.Location = new System.Drawing.Point(383, 253);
            this.Chk_Opc25.Name = "Chk_Opc25";
            this.Chk_Opc25.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc25.TabIndex = 54;
            this.Chk_Opc25.Text = "Tipo de Negocio";
            this.Chk_Opc25.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc24
            // 
            this.Chk_Opc24.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc24", true));
            this.Chk_Opc24.Location = new System.Drawing.Point(383, 227);
            this.Chk_Opc24.Name = "Chk_Opc24";
            this.Chk_Opc24.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc24.TabIndex = 53;
            this.Chk_Opc24.Text = "Cargo";
            this.Chk_Opc24.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc23
            // 
            this.Chk_Opc23.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc23", true));
            this.Chk_Opc23.Location = new System.Drawing.Point(383, 201);
            this.Chk_Opc23.Name = "Chk_Opc23";
            this.Chk_Opc23.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc23.TabIndex = 52;
            this.Chk_Opc23.Text = "Referencias Bancarias, Comerciales y/o Personales";
            this.Chk_Opc23.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc22
            // 
            this.Chk_Opc22.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc22", true));
            this.Chk_Opc22.Location = new System.Drawing.Point(383, 175);
            this.Chk_Opc22.Name = "Chk_Opc22";
            this.Chk_Opc22.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc22.TabIndex = 51;
            this.Chk_Opc22.Text = "Teléfono Laboral";
            this.Chk_Opc22.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc21
            // 
            this.Chk_Opc21.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc21", true));
            this.Chk_Opc21.Location = new System.Drawing.Point(383, 149);
            this.Chk_Opc21.Name = "Chk_Opc21";
            this.Chk_Opc21.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc21.TabIndex = 50;
            this.Chk_Opc21.Text = "Dirección Laboral";
            this.Chk_Opc21.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc20
            // 
            this.Chk_Opc20.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc20", true));
            this.Chk_Opc20.Location = new System.Drawing.Point(383, 123);
            this.Chk_Opc20.Name = "Chk_Opc20";
            this.Chk_Opc20.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc20.TabIndex = 49;
            this.Chk_Opc20.Text = "Estado Civil";
            this.Chk_Opc20.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc19
            // 
            this.Chk_Opc19.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc19", true));
            this.Chk_Opc19.Location = new System.Drawing.Point(383, 97);
            this.Chk_Opc19.Name = "Chk_Opc19";
            this.Chk_Opc19.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc19.TabIndex = 48;
            this.Chk_Opc19.Text = "Nacionalidad";
            this.Chk_Opc19.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc18
            // 
            this.Chk_Opc18.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc18", true));
            this.Chk_Opc18.Location = new System.Drawing.Point(383, 71);
            this.Chk_Opc18.Name = "Chk_Opc18";
            this.Chk_Opc18.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc18.TabIndex = 47;
            this.Chk_Opc18.Text = "Email";
            this.Chk_Opc18.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc17
            // 
            this.Chk_Opc17.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc17", true));
            this.Chk_Opc17.Location = new System.Drawing.Point(383, 45);
            this.Chk_Opc17.Name = "Chk_Opc17";
            this.Chk_Opc17.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc17.TabIndex = 46;
            this.Chk_Opc17.Text = "W9";
            this.Chk_Opc17.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc16
            // 
            this.Chk_Opc16.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc16", true));
            this.Chk_Opc16.Location = new System.Drawing.Point(383, 19);
            this.Chk_Opc16.Name = "Chk_Opc16";
            this.Chk_Opc16.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc16.TabIndex = 45;
            this.Chk_Opc16.Text = "W8BEN";
            this.Chk_Opc16.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc15
            // 
            this.Chk_Opc15.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc15", true));
            this.Chk_Opc15.Location = new System.Drawing.Point(4, 383);
            this.Chk_Opc15.Name = "Chk_Opc15";
            this.Chk_Opc15.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc15.TabIndex = 39;
            this.Chk_Opc15.Text = "OPC15";
            this.Chk_Opc15.UseVisualStyleBackColor = true;
            this.Chk_Opc15.Visible = false;
            // 
            // Chk_Opc14
            // 
            this.Chk_Opc14.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc14", true));
            this.Chk_Opc14.Location = new System.Drawing.Point(4, 357);
            this.Chk_Opc14.Name = "Chk_Opc14";
            this.Chk_Opc14.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc14.TabIndex = 38;
            this.Chk_Opc14.Text = "Actividad Profesional, Industrial o Comercial";
            this.Chk_Opc14.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc13
            // 
            this.Chk_Opc13.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc13", true));
            this.Chk_Opc13.Location = new System.Drawing.Point(4, 331);
            this.Chk_Opc13.Name = "Chk_Opc13";
            this.Chk_Opc13.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc13.TabIndex = 37;
            this.Chk_Opc13.Text = "Huella Dactilar";
            this.Chk_Opc13.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc12
            // 
            this.Chk_Opc12.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc12", true));
            this.Chk_Opc12.Location = new System.Drawing.Point(4, 305);
            this.Chk_Opc12.Name = "Chk_Opc12";
            this.Chk_Opc12.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc12.TabIndex = 36;
            this.Chk_Opc12.Text = "Patrimonio total";
            this.Chk_Opc12.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc11
            // 
            this.Chk_Opc11.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc11", true));
            this.Chk_Opc11.Location = new System.Drawing.Point(4, 279);
            this.Chk_Opc11.Name = "Chk_Opc11";
            this.Chk_Opc11.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc11.TabIndex = 35;
            this.Chk_Opc11.Text = "Total de Activos Líquidos";
            this.Chk_Opc11.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc10
            // 
            this.Chk_Opc10.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc10", true));
            this.Chk_Opc10.Location = new System.Drawing.Point(4, 253);
            this.Chk_Opc10.Name = "Chk_Opc10";
            this.Chk_Opc10.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc10.TabIndex = 34;
            this.Chk_Opc10.Text = "Ingresos Anuales";
            this.Chk_Opc10.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc9
            // 
            this.Chk_Opc9.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc9", true));
            this.Chk_Opc9.Location = new System.Drawing.Point(4, 227);
            this.Chk_Opc9.Name = "Chk_Opc9";
            this.Chk_Opc9.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc9.TabIndex = 33;
            this.Chk_Opc9.Text = "Objetivo de la Inversión en un Ciclo de Mercado";
            this.Chk_Opc9.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc8
            // 
            this.Chk_Opc8.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc8", true));
            this.Chk_Opc8.Location = new System.Drawing.Point(4, 201);
            this.Chk_Opc8.Name = "Chk_Opc8";
            this.Chk_Opc8.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc8.TabIndex = 32;
            this.Chk_Opc8.Text = "Experiencia y Conocimiento como Inversionista";
            this.Chk_Opc8.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc7
            // 
            this.Chk_Opc7.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc7", true));
            this.Chk_Opc7.Location = new System.Drawing.Point(4, 175);
            this.Chk_Opc7.Name = "Chk_Opc7";
            this.Chk_Opc7.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc7.TabIndex = 31;
            this.Chk_Opc7.Text = "Tipo y Número de Documento de Identificación";
            this.Chk_Opc7.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc6
            // 
            this.Chk_Opc6.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc6", true));
            this.Chk_Opc6.Location = new System.Drawing.Point(4, 149);
            this.Chk_Opc6.Name = "Chk_Opc6";
            this.Chk_Opc6.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc6.TabIndex = 30;
            this.Chk_Opc6.Text = "checkBox1";
            this.Chk_Opc6.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc5
            // 
            this.Chk_Opc5.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc5", true));
            this.Chk_Opc5.Location = new System.Drawing.Point(4, 123);
            this.Chk_Opc5.Name = "Chk_Opc5";
            this.Chk_Opc5.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc5.TabIndex = 29;
            this.Chk_Opc5.Text = "checkBox1";
            this.Chk_Opc5.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc4
            // 
            this.Chk_Opc4.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc4", true));
            this.Chk_Opc4.Location = new System.Drawing.Point(4, 97);
            this.Chk_Opc4.Name = "Chk_Opc4";
            this.Chk_Opc4.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc4.TabIndex = 28;
            this.Chk_Opc4.Text = "Declaración Jurada de Origen y Destino de Fondos";
            this.Chk_Opc4.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc3
            // 
            this.Chk_Opc3.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc3", true));
            this.Chk_Opc3.Location = new System.Drawing.Point(4, 71);
            this.Chk_Opc3.Name = "Chk_Opc3";
            this.Chk_Opc3.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc3.TabIndex = 27;
            this.Chk_Opc3.Text = "Constancia de Chequeo en World Compliance";
            this.Chk_Opc3.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc2
            // 
            this.Chk_Opc2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc2", true));
            this.Chk_Opc2.Location = new System.Drawing.Point(4, 45);
            this.Chk_Opc2.Name = "Chk_Opc2";
            this.Chk_Opc2.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc2.TabIndex = 26;
            this.Chk_Opc2.Text = "Copia de Recibo de Servicio Público";
            this.Chk_Opc2.UseVisualStyleBackColor = true;
            // 
            // Chk_Opc1
            // 
            this.Chk_Opc1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_CClientes, "CE_Opc1", true));
            this.Chk_Opc1.Location = new System.Drawing.Point(4, 19);
            this.Chk_Opc1.Name = "Chk_Opc1";
            this.Chk_Opc1.Size = new System.Drawing.Size(300, 22);
            this.Chk_Opc1.TabIndex = 25;
            this.Chk_Opc1.Text = "Copia del Documento de Identidad";
            this.Chk_Opc1.UseVisualStyleBackColor = true;
            // 
            // Pag4
            // 
            this.Pag4.AutoScroll = true;
            this.Pag4.Controls.Add(Lbl_ToTrimestre);
            this.Pag4.Controls.Add(Lbl_NroOperaciones);
            this.Pag4.Controls.Add(this.Btn_Trimestre);
            this.Pag4.Controls.Add(Lbl_ToTrimestral);
            this.Pag4.Controls.Add(Lbl_FecUltAct);
            this.Pag4.Controls.Add(Lbl_NroTransacciones);
            this.Pag4.Controls.Add(Lbl_PerUsoCta);
            this.Pag4.Controls.Add(Lbl_PerFinanciero);
            this.Pag4.Controls.Add(Lbl_NivRiesgo);
            this.Pag4.Controls.Add(Lbl_Ejecutivo);
            this.Pag4.Controls.Add(Lbl_Observacion);
            this.Pag4.Controls.Add(this.Pan_Detalles4);
            this.Pag4.Location = new System.Drawing.Point(4, 27);
            this.Pag4.Name = "Pag4";
            this.Pag4.Padding = new System.Windows.Forms.Padding(3);
            this.Pag4.Size = new System.Drawing.Size(800, 429);
            this.Pag4.TabIndex = 3;
            this.Pag4.Text = "Observaciones";
            this.Pag4.UseVisualStyleBackColor = true;
            // 
            // Btn_Trimestre
            // 
            this.Btn_Trimestre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Trimestre.BackgroundImage")));
            this.Btn_Trimestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Trimestre.Location = new System.Drawing.Point(714, 278);
            this.Btn_Trimestre.Name = "Btn_Trimestre";
            this.Btn_Trimestre.Size = new System.Drawing.Size(42, 45);
            this.Btn_Trimestre.TabIndex = 25;
            this.Btn_Trimestre.UseVisualStyleBackColor = true;
            // 
            // Pan_Detalles4
            // 
            this.Pan_Detalles4.Controls.Add(this.Cmb_NivelRiesgo);
            this.Pan_Detalles4.Controls.Add(this.NUD_NroTransacciones);
            this.Pan_Detalles4.Controls.Add(this.NUD_TriAno);
            this.Pan_Detalles4.Controls.Add(this.NUD_TriMes);
            this.Pan_Detalles4.Controls.Add(this.Txt_TriNroOperaciones);
            this.Pan_Detalles4.Controls.Add(this.Txt_TriMntOperaciones);
            this.Pan_Detalles4.Controls.Add(this.DTP_FecUltAct);
            this.Pan_Detalles4.Controls.Add(this.periodUsoCtaTextBox);
            this.Pan_Detalles4.Controls.Add(this.Txt_PerFinanciero);
            this.Pan_Detalles4.Controls.Add(this.Txt_Ejecutivo);
            this.Pan_Detalles4.Controls.Add(this.Txt_Observacion);
            this.Pan_Detalles4.Controls.Add(this.Grp_PerUsoCta);
            this.Pan_Detalles4.Location = new System.Drawing.Point(159, 6);
            this.Pan_Detalles4.Name = "Pan_Detalles4";
            this.Pan_Detalles4.Size = new System.Drawing.Size(635, 394);
            this.Pan_Detalles4.TabIndex = 27;
            // 
            // NUD_NroTransacciones
            // 
            this.NUD_NroTransacciones.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "NroTransacciones", true));
            this.NUD_NroTransacciones.Location = new System.Drawing.Point(5, 338);
            this.NUD_NroTransacciones.Name = "NUD_NroTransacciones";
            this.NUD_NroTransacciones.Size = new System.Drawing.Size(44, 22);
            this.NUD_NroTransacciones.TabIndex = 37;
            // 
            // NUD_TriAno
            // 
            this.NUD_TriAno.Location = new System.Drawing.Point(475, 274);
            this.NUD_TriAno.Name = "NUD_TriAno";
            this.NUD_TriAno.Size = new System.Drawing.Size(66, 22);
            this.NUD_TriAno.TabIndex = 36;
            // 
            // NUD_TriMes
            // 
            this.NUD_TriMes.Location = new System.Drawing.Point(426, 274);
            this.NUD_TriMes.Name = "NUD_TriMes";
            this.NUD_TriMes.Size = new System.Drawing.Size(44, 22);
            this.NUD_TriMes.TabIndex = 35;
            // 
            // Txt_TriNroOperaciones
            // 
            this.Txt_TriNroOperaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "NroTransacciones", true));
            this.Txt_TriNroOperaciones.Enabled = false;
            this.Txt_TriNroOperaciones.Location = new System.Drawing.Point(541, 332);
            this.Txt_TriNroOperaciones.Name = "Txt_TriNroOperaciones";
            this.Txt_TriNroOperaciones.Size = new System.Drawing.Size(40, 22);
            this.Txt_TriNroOperaciones.TabIndex = 19;
            // 
            // Txt_TriMntOperaciones
            // 
            this.Txt_TriMntOperaciones.Enabled = false;
            this.Txt_TriMntOperaciones.Location = new System.Drawing.Point(498, 359);
            this.Txt_TriMntOperaciones.Name = "Txt_TriMntOperaciones";
            this.Txt_TriMntOperaciones.Size = new System.Drawing.Size(118, 22);
            this.Txt_TriMntOperaciones.TabIndex = 33;
            // 
            // DTP_FecUltAct
            // 
            this.DTP_FecUltAct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_CClientes, "Fec_UltimAct", true));
            this.DTP_FecUltAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FecUltAct.Location = new System.Drawing.Point(5, 364);
            this.DTP_FecUltAct.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DTP_FecUltAct.Name = "DTP_FecUltAct";
            this.DTP_FecUltAct.Size = new System.Drawing.Size(105, 22);
            this.DTP_FecUltAct.TabIndex = 32;
            this.DTP_FecUltAct.Value = new System.DateTime(2018, 12, 30, 17, 53, 59, 0);
            // 
            // periodUsoCtaTextBox
            // 
            this.periodUsoCtaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "PeriodUsoCta", true));
            this.periodUsoCtaTextBox.Location = new System.Drawing.Point(250, 333);
            this.periodUsoCtaTextBox.Name = "periodUsoCtaTextBox";
            this.periodUsoCtaTextBox.Size = new System.Drawing.Size(31, 22);
            this.periodUsoCtaTextBox.TabIndex = 31;
            // 
            // Txt_PerFinanciero
            // 
            this.Txt_PerFinanciero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "PerfilFinanciero", true));
            this.Txt_PerFinanciero.Location = new System.Drawing.Point(5, 277);
            this.Txt_PerFinanciero.Name = "Txt_PerFinanciero";
            this.Txt_PerFinanciero.Size = new System.Drawing.Size(176, 22);
            this.Txt_PerFinanciero.TabIndex = 30;
            // 
            // Txt_Ejecutivo
            // 
            this.Txt_Ejecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Ejecutivo", true));
            this.Txt_Ejecutivo.Location = new System.Drawing.Point(5, 224);
            this.Txt_Ejecutivo.Name = "Txt_Ejecutivo";
            this.Txt_Ejecutivo.Size = new System.Drawing.Size(176, 22);
            this.Txt_Ejecutivo.TabIndex = 28;
            // 
            // Txt_Observacion
            // 
            this.Txt_Observacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Observacion", true));
            this.Txt_Observacion.Location = new System.Drawing.Point(5, 16);
            this.Txt_Observacion.Multiline = true;
            this.Txt_Observacion.Name = "Txt_Observacion";
            this.Txt_Observacion.Size = new System.Drawing.Size(611, 203);
            this.Txt_Observacion.TabIndex = 27;
            // 
            // Grp_PerUsoCta
            // 
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta5);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta4);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta3);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta2);
            this.Grp_PerUsoCta.Controls.Add(this.Opt_PerUsoCta1);
            this.Grp_PerUsoCta.Location = new System.Drawing.Point(5, 295);
            this.Grp_PerUsoCta.Name = "Grp_PerUsoCta";
            this.Grp_PerUsoCta.Size = new System.Drawing.Size(362, 35);
            this.Grp_PerUsoCta.TabIndex = 34;
            this.Grp_PerUsoCta.TabStop = false;
            // 
            // Opt_PerUsoCta5
            // 
            this.Opt_PerUsoCta5.AutoSize = true;
            this.Opt_PerUsoCta5.Location = new System.Drawing.Point(299, 10);
            this.Opt_PerUsoCta5.Name = "Opt_PerUsoCta5";
            this.Opt_PerUsoCta5.Size = new System.Drawing.Size(58, 19);
            this.Opt_PerUsoCta5.TabIndex = 4;
            this.Opt_PerUsoCta5.Text = "Anual";
            this.Opt_PerUsoCta5.UseVisualStyleBackColor = true;
            this.Opt_PerUsoCta5.CheckedChanged += new System.EventHandler(this.Opt_PerUsoCta1_CheckedChanged);
            // 
            // Opt_PerUsoCta4
            // 
            this.Opt_PerUsoCta4.AutoSize = true;
            this.Opt_PerUsoCta4.Location = new System.Drawing.Point(225, 10);
            this.Opt_PerUsoCta4.Name = "Opt_PerUsoCta4";
            this.Opt_PerUsoCta4.Size = new System.Drawing.Size(76, 19);
            this.Opt_PerUsoCta4.TabIndex = 3;
            this.Opt_PerUsoCta4.Text = "Semestral";
            this.Opt_PerUsoCta4.UseVisualStyleBackColor = true;
            this.Opt_PerUsoCta4.CheckedChanged += new System.EventHandler(this.Opt_PerUsoCta1_CheckedChanged);
            // 
            // Opt_PerUsoCta3
            // 
            this.Opt_PerUsoCta3.AutoSize = true;
            this.Opt_PerUsoCta3.Location = new System.Drawing.Point(147, 10);
            this.Opt_PerUsoCta3.Name = "Opt_PerUsoCta3";
            this.Opt_PerUsoCta3.Size = new System.Drawing.Size(78, 19);
            this.Opt_PerUsoCta3.TabIndex = 2;
            this.Opt_PerUsoCta3.Text = "Trimestral";
            this.Opt_PerUsoCta3.UseVisualStyleBackColor = true;
            this.Opt_PerUsoCta3.CheckedChanged += new System.EventHandler(this.Opt_PerUsoCta1_CheckedChanged);
            // 
            // Opt_PerUsoCta2
            // 
            this.Opt_PerUsoCta2.AutoSize = true;
            this.Opt_PerUsoCta2.Location = new System.Drawing.Point(75, 10);
            this.Opt_PerUsoCta2.Name = "Opt_PerUsoCta2";
            this.Opt_PerUsoCta2.Size = new System.Drawing.Size(72, 19);
            this.Opt_PerUsoCta2.TabIndex = 1;
            this.Opt_PerUsoCta2.Text = "Mensual";
            this.Opt_PerUsoCta2.UseVisualStyleBackColor = true;
            this.Opt_PerUsoCta2.CheckedChanged += new System.EventHandler(this.Opt_PerUsoCta1_CheckedChanged);
            // 
            // Opt_PerUsoCta1
            // 
            this.Opt_PerUsoCta1.AutoSize = true;
            this.Opt_PerUsoCta1.Checked = true;
            this.Opt_PerUsoCta1.Location = new System.Drawing.Point(5, 10);
            this.Opt_PerUsoCta1.Name = "Opt_PerUsoCta1";
            this.Opt_PerUsoCta1.Size = new System.Drawing.Size(69, 19);
            this.Opt_PerUsoCta1.TabIndex = 0;
            this.Opt_PerUsoCta1.TabStop = true;
            this.Opt_PerUsoCta1.Text = "Semanal";
            this.Opt_PerUsoCta1.UseVisualStyleBackColor = true;
            this.Opt_PerUsoCta1.CheckedChanged += new System.EventHandler(this.Opt_PerUsoCta1_CheckedChanged);
            // 
            // Pag5
            // 
            this.Pag5.Controls.Add(this.Pic_MapEpresa);
            this.Pag5.Location = new System.Drawing.Point(4, 27);
            this.Pag5.Name = "Pag5";
            this.Pag5.Padding = new System.Windows.Forms.Padding(3);
            this.Pag5.Size = new System.Drawing.Size(800, 429);
            this.Pag5.TabIndex = 4;
            this.Pag5.Text = "Mapa de Propiesdad de la Empresa";
            this.Pag5.UseVisualStyleBackColor = true;
            // 
            // Pic_MapEpresa
            // 
            this.Pic_MapEpresa.Image = ((System.Drawing.Image)(resources.GetObject("Pic_MapEpresa.Image")));
            this.Pic_MapEpresa.Location = new System.Drawing.Point(6, 25);
            this.Pic_MapEpresa.Name = "Pic_MapEpresa";
            this.Pic_MapEpresa.Size = new System.Drawing.Size(785, 393);
            this.Pic_MapEpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_MapEpresa.TabIndex = 0;
            this.Pic_MapEpresa.TabStop = false;
            // 
            // Lbl_Puntuacion
            // 
            this.Lbl_Puntuacion.BackColor = System.Drawing.Color.Black;
            this.Lbl_Puntuacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Puntuacion.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Puntuacion.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_Puntuacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Puntuacion.Location = new System.Drawing.Point(955, 18);
            this.Lbl_Puntuacion.Name = "Lbl_Puntuacion";
            this.Lbl_Puntuacion.Size = new System.Drawing.Size(88, 94);
            this.Lbl_Puntuacion.TabIndex = 0;
            this.Lbl_Puntuacion.Text = "2";
            // 
            // Lbl_Activo
            // 
            this.Lbl_Activo.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Activo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Activo.Location = new System.Drawing.Point(634, 61);
            this.Lbl_Activo.Name = "Lbl_Activo";
            this.Lbl_Activo.Size = new System.Drawing.Size(293, 43);
            this.Lbl_Activo.TabIndex = 51;
            this.Lbl_Activo.Text = "Inactivo";
            this.Lbl_Activo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_EtiqPunt
            // 
            this.Lbl_EtiqPunt.Location = new System.Drawing.Point(957, 20);
            this.Lbl_EtiqPunt.Name = "Lbl_EtiqPunt";
            this.Lbl_EtiqPunt.Size = new System.Drawing.Size(83, 15);
            this.Lbl_EtiqPunt.TabIndex = 52;
            this.Lbl_EtiqPunt.Text = "Puntuación";
            this.Lbl_EtiqPunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pan_DetallesEnc
            // 
            this.Pan_DetallesEnc.Controls.Add(this.Grp_TipoPersona);
            this.Pan_DetallesEnc.Controls.Add(this.Txt_Nombre);
            this.Pan_DetallesEnc.Controls.Add(this.Txt_DocID);
            this.Pan_DetallesEnc.Controls.Add(this.Txt_Codigo);
            this.Pan_DetallesEnc.Location = new System.Drawing.Point(14, 56);
            this.Pan_DetallesEnc.Name = "Pan_DetallesEnc";
            this.Pan_DetallesEnc.Size = new System.Drawing.Size(583, 59);
            this.Pan_DetallesEnc.TabIndex = 53;
            // 
            // Grp_TipoPersona
            // 
            this.Grp_TipoPersona.Controls.Add(this.Opc_TipPers2);
            this.Grp_TipoPersona.Controls.Add(this.Opc_TipPers1);
            this.Grp_TipoPersona.Location = new System.Drawing.Point(4, 1);
            this.Grp_TipoPersona.Name = "Grp_TipoPersona";
            this.Grp_TipoPersona.Size = new System.Drawing.Size(153, 56);
            this.Grp_TipoPersona.TabIndex = 54;
            this.Grp_TipoPersona.TabStop = false;
            // 
            // Opc_TipPers2
            // 
            this.Opc_TipPers2.AutoSize = true;
            this.Opc_TipPers2.Location = new System.Drawing.Point(8, 31);
            this.Opc_TipPers2.Name = "Opc_TipPers2";
            this.Opc_TipPers2.Size = new System.Drawing.Size(112, 19);
            this.Opc_TipPers2.TabIndex = 1;
            this.Opc_TipPers2.Text = "Persona Jurídica";
            this.Opc_TipPers2.UseVisualStyleBackColor = true;
            this.Opc_TipPers2.CheckedChanged += new System.EventHandler(this.Opc_TipPers1_CheckedChanged);
            // 
            // Opc_TipPers1
            // 
            this.Opc_TipPers1.AutoSize = true;
            this.Opc_TipPers1.Checked = true;
            this.Opc_TipPers1.Location = new System.Drawing.Point(8, 11);
            this.Opc_TipPers1.Name = "Opc_TipPers1";
            this.Opc_TipPers1.Size = new System.Drawing.Size(110, 19);
            this.Opc_TipPers1.TabIndex = 0;
            this.Opc_TipPers1.TabStop = true;
            this.Opc_TipPers1.Text = "Persona Natural";
            this.Opc_TipPers1.UseVisualStyleBackColor = true;
            this.Opc_TipPers1.CheckedChanged += new System.EventHandler(this.Opc_TipPers1_CheckedChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(250, 33);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(319, 22);
            this.Txt_Nombre.TabIndex = 53;
            // 
            // Txt_DocID
            // 
            this.Txt_DocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Doc_ID", true));
            this.Txt_DocID.Location = new System.Drawing.Point(429, 8);
            this.Txt_DocID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DocID.Name = "Txt_DocID";
            this.Txt_DocID.Size = new System.Drawing.Size(140, 22);
            this.Txt_DocID.TabIndex = 52;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_CClientes, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(250, 8);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(106, 22);
            this.Txt_Codigo.TabIndex = 51;
            // 
            // monitorOperacionesDataSet
            // 
            this.monitorOperacionesDataSet.DataSetName = "MonitorOperacionesDataSet";
            this.monitorOperacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Grd_Clientes
            // 
            this.Grd_Clientes.AllowUserToAddRows = false;
            this.Grd_Clientes.AllowUserToDeleteRows = false;
            this.Grd_Clientes.AutoGenerateColumns = false;
            this.Grd_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSistemaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.tipoPersonaDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.docIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.clientePuntDataGridViewTextBoxColumn,
            this.benefPuntDataGridViewTextBoxColumn,
            this.infGenPuntDataGridViewTextBoxColumn,
            this.constExpedPuntDataGridViewTextBoxColumn,
            this.condEspSeguridadDataGridViewTextBoxColumn,
            this.iGPaisNacimDataGridViewTextBoxColumn,
            this.iGNacionalidadDataGridViewTextBoxColumn,
            this.iGPaisResidDataGridViewTextBoxColumn,
            this.iGEstadoDataGridViewTextBoxColumn,
            this.iGPEPDataGridViewTextBoxColumn,
            this.iGProfesionDataGridViewTextBoxColumn,
            this.iGTipDocIDDataGridViewTextBoxColumn,
            this.iGFecVencDocIDDataGridViewTextBoxColumn,
            this.iGTipoPersJurDataGridViewTextBoxColumn,
            this.iGEdadDataGridViewTextBoxColumn,
            this.iGActivComerDataGridViewTextBoxColumn,
            this.iGVolumOperacDataGridViewTextBoxColumn,
            this.iGCriptomonedaDataGridViewTextBoxColumn,
            this.iGTipoEstructuraDataGridViewTextBoxColumn,
            this.iGServicio1DataGridViewTextBoxColumn,
            this.iGServicio2DataGridViewTextBoxColumn,
            this.iGServicio3DataGridViewTextBoxColumn,
            this.iGServicio4DataGridViewTextBoxColumn,
            this.iGServicio5DataGridViewTextBoxColumn,
            this.iGServicio6DataGridViewTextBoxColumn,
            this.iGServicio7DataGridViewTextBoxColumn,
            this.iGServicio8DataGridViewTextBoxColumn,
            this.iGServicio9DataGridViewTextBoxColumn,
            this.iGServicio10DataGridViewTextBoxColumn,
            this.iGProducto1DataGridViewTextBoxColumn,
            this.iGProducto2DataGridViewTextBoxColumn,
            this.iGProducto3DataGridViewTextBoxColumn,
            this.iGProducto4DataGridViewTextBoxColumn,
            this.iGProducto5DataGridViewTextBoxColumn,
            this.iGProducto6DataGridViewTextBoxColumn,
            this.iGProducto7DataGridViewTextBoxColumn,
            this.iGProducto8DataGridViewTextBoxColumn,
            this.iGProducto9DataGridViewTextBoxColumn,
            this.iGProducto10DataGridViewTextBoxColumn,
            this.cEOpc1DataGridViewTextBoxColumn,
            this.cEOpc2DataGridViewTextBoxColumn,
            this.cEOpc3DataGridViewTextBoxColumn,
            this.cEOpc4DataGridViewTextBoxColumn,
            this.cEOpc5DataGridViewTextBoxColumn,
            this.cEOpc6DataGridViewTextBoxColumn,
            this.cEOpc7DataGridViewTextBoxColumn,
            this.cEOpc8DataGridViewTextBoxColumn,
            this.cEOpc9DataGridViewTextBoxColumn,
            this.cEOpc10DataGridViewTextBoxColumn,
            this.cEOpc11DataGridViewTextBoxColumn,
            this.cEOpc12DataGridViewTextBoxColumn,
            this.cEOpc13DataGridViewTextBoxColumn,
            this.cEOpc14DataGridViewTextBoxColumn,
            this.cEOpc15DataGridViewTextBoxColumn,
            this.cEOpc16DataGridViewTextBoxColumn,
            this.cEOpc17DataGridViewTextBoxColumn,
            this.cEOpc18DataGridViewTextBoxColumn,
            this.cEOpc19DataGridViewTextBoxColumn,
            this.cEOpc20DataGridViewTextBoxColumn,
            this.cEOpc21DataGridViewTextBoxColumn,
            this.cEOpc22DataGridViewTextBoxColumn,
            this.cEOpc23DataGridViewTextBoxColumn,
            this.cEOpc24DataGridViewTextBoxColumn,
            this.cEOpc25DataGridViewTextBoxColumn,
            this.cEOpc26DataGridViewTextBoxColumn,
            this.cEOpc27DataGridViewTextBoxColumn,
            this.cEOpc28DataGridViewTextBoxColumn,
            this.cEOpc29DataGridViewTextBoxColumn,
            this.cEOpc30DataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.ejecutivoDataGridViewTextBoxColumn,
            this.nivelRiesgoDataGridViewTextBoxColumn,
            this.perfilFinancieroDataGridViewTextBoxColumn,
            this.periodUsoCtaDataGridViewTextBoxColumn,
            this.nroTransaccionesDataGridViewTextBoxColumn,
            this.fecUltimActDataGridViewTextBoxColumn,
            this.trimMesDataGridViewTextBoxColumn,
            this.trimAnoDataGridViewTextBoxColumn,
            this.trimNroOperacDataGridViewTextBoxColumn,
            this.trimMontoOperacDataGridViewTextBoxColumn,
            this.mapaEmpresaDataGridViewTextBoxColumn});
            this.Grd_Clientes.DataSource = this.BS_CClientes;
            this.Grd_Clientes.Location = new System.Drawing.Point(14, 121);
            this.Grd_Clientes.Name = "Grd_Clientes";
            this.Grd_Clientes.ReadOnly = true;
            this.Grd_Clientes.RowHeadersVisible = false;
            this.Grd_Clientes.Size = new System.Drawing.Size(225, 412);
            this.Grd_Clientes.TabIndex = 54;
            this.Grd_Clientes.CurrentCellChanged += new System.EventHandler(this.Grd_Clientes_CurrentCellChanged);
            // 
            // iDSistemaDataGridViewTextBoxColumn
            // 
            this.iDSistemaDataGridViewTextBoxColumn.DataPropertyName = "ID_Sistema";
            this.iDSistemaDataGridViewTextBoxColumn.HeaderText = "ID_Sistema";
            this.iDSistemaDataGridViewTextBoxColumn.Name = "iDSistemaDataGridViewTextBoxColumn";
            this.iDSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSistemaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPersonaDataGridViewTextBoxColumn
            // 
            this.tipoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TipoPersona";
            this.tipoPersonaDataGridViewTextBoxColumn.HeaderText = "TipoPersona";
            this.tipoPersonaDataGridViewTextBoxColumn.Name = "tipoPersonaDataGridViewTextBoxColumn";
            this.tipoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPersonaDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            this.activoDataGridViewTextBoxColumn.Visible = false;
            // 
            // docIDDataGridViewTextBoxColumn
            // 
            this.docIDDataGridViewTextBoxColumn.DataPropertyName = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.HeaderText = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.Name = "docIDDataGridViewTextBoxColumn";
            this.docIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.docIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 130;
            // 
            // clientePuntDataGridViewTextBoxColumn
            // 
            this.clientePuntDataGridViewTextBoxColumn.DataPropertyName = "Cliente_Punt";
            this.clientePuntDataGridViewTextBoxColumn.HeaderText = "Cliente_Punt";
            this.clientePuntDataGridViewTextBoxColumn.Name = "clientePuntDataGridViewTextBoxColumn";
            this.clientePuntDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientePuntDataGridViewTextBoxColumn.Visible = false;
            // 
            // benefPuntDataGridViewTextBoxColumn
            // 
            this.benefPuntDataGridViewTextBoxColumn.DataPropertyName = "Benef_Punt";
            this.benefPuntDataGridViewTextBoxColumn.HeaderText = "Benef_Punt";
            this.benefPuntDataGridViewTextBoxColumn.Name = "benefPuntDataGridViewTextBoxColumn";
            this.benefPuntDataGridViewTextBoxColumn.ReadOnly = true;
            this.benefPuntDataGridViewTextBoxColumn.Visible = false;
            // 
            // infGenPuntDataGridViewTextBoxColumn
            // 
            this.infGenPuntDataGridViewTextBoxColumn.DataPropertyName = "InfGen_Punt";
            this.infGenPuntDataGridViewTextBoxColumn.HeaderText = "InfGen_Punt";
            this.infGenPuntDataGridViewTextBoxColumn.Name = "infGenPuntDataGridViewTextBoxColumn";
            this.infGenPuntDataGridViewTextBoxColumn.ReadOnly = true;
            this.infGenPuntDataGridViewTextBoxColumn.Visible = false;
            // 
            // constExpedPuntDataGridViewTextBoxColumn
            // 
            this.constExpedPuntDataGridViewTextBoxColumn.DataPropertyName = "ConstExped_Punt";
            this.constExpedPuntDataGridViewTextBoxColumn.HeaderText = "ConstExped_Punt";
            this.constExpedPuntDataGridViewTextBoxColumn.Name = "constExpedPuntDataGridViewTextBoxColumn";
            this.constExpedPuntDataGridViewTextBoxColumn.ReadOnly = true;
            this.constExpedPuntDataGridViewTextBoxColumn.Visible = false;
            // 
            // condEspSeguridadDataGridViewTextBoxColumn
            // 
            this.condEspSeguridadDataGridViewTextBoxColumn.DataPropertyName = "CondEspSeguridad";
            this.condEspSeguridadDataGridViewTextBoxColumn.HeaderText = "CondEspSeguridad";
            this.condEspSeguridadDataGridViewTextBoxColumn.Name = "condEspSeguridadDataGridViewTextBoxColumn";
            this.condEspSeguridadDataGridViewTextBoxColumn.ReadOnly = true;
            this.condEspSeguridadDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGPaisNacimDataGridViewTextBoxColumn
            // 
            this.iGPaisNacimDataGridViewTextBoxColumn.DataPropertyName = "IG_PaisNacim";
            this.iGPaisNacimDataGridViewTextBoxColumn.HeaderText = "IG_PaisNacim";
            this.iGPaisNacimDataGridViewTextBoxColumn.Name = "iGPaisNacimDataGridViewTextBoxColumn";
            this.iGPaisNacimDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGPaisNacimDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGNacionalidadDataGridViewTextBoxColumn
            // 
            this.iGNacionalidadDataGridViewTextBoxColumn.DataPropertyName = "IG_Nacionalidad";
            this.iGNacionalidadDataGridViewTextBoxColumn.HeaderText = "IG_Nacionalidad";
            this.iGNacionalidadDataGridViewTextBoxColumn.Name = "iGNacionalidadDataGridViewTextBoxColumn";
            this.iGNacionalidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGNacionalidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGPaisResidDataGridViewTextBoxColumn
            // 
            this.iGPaisResidDataGridViewTextBoxColumn.DataPropertyName = "IG_PaisResid";
            this.iGPaisResidDataGridViewTextBoxColumn.HeaderText = "IG_PaisResid";
            this.iGPaisResidDataGridViewTextBoxColumn.Name = "iGPaisResidDataGridViewTextBoxColumn";
            this.iGPaisResidDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGPaisResidDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGEstadoDataGridViewTextBoxColumn
            // 
            this.iGEstadoDataGridViewTextBoxColumn.DataPropertyName = "IG_Estado";
            this.iGEstadoDataGridViewTextBoxColumn.HeaderText = "IG_Estado";
            this.iGEstadoDataGridViewTextBoxColumn.Name = "iGEstadoDataGridViewTextBoxColumn";
            this.iGEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGEstadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGPEPDataGridViewTextBoxColumn
            // 
            this.iGPEPDataGridViewTextBoxColumn.DataPropertyName = "IG_PEP";
            this.iGPEPDataGridViewTextBoxColumn.HeaderText = "IG_PEP";
            this.iGPEPDataGridViewTextBoxColumn.Name = "iGPEPDataGridViewTextBoxColumn";
            this.iGPEPDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGPEPDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProfesionDataGridViewTextBoxColumn
            // 
            this.iGProfesionDataGridViewTextBoxColumn.DataPropertyName = "IG_Profesion";
            this.iGProfesionDataGridViewTextBoxColumn.HeaderText = "IG_Profesion";
            this.iGProfesionDataGridViewTextBoxColumn.Name = "iGProfesionDataGridViewTextBoxColumn";
            this.iGProfesionDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProfesionDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGTipDocIDDataGridViewTextBoxColumn
            // 
            this.iGTipDocIDDataGridViewTextBoxColumn.DataPropertyName = "IG_TipDocID";
            this.iGTipDocIDDataGridViewTextBoxColumn.HeaderText = "IG_TipDocID";
            this.iGTipDocIDDataGridViewTextBoxColumn.Name = "iGTipDocIDDataGridViewTextBoxColumn";
            this.iGTipDocIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGTipDocIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGFecVencDocIDDataGridViewTextBoxColumn
            // 
            this.iGFecVencDocIDDataGridViewTextBoxColumn.DataPropertyName = "IG_FecVencDocID";
            this.iGFecVencDocIDDataGridViewTextBoxColumn.HeaderText = "IG_FecVencDocID";
            this.iGFecVencDocIDDataGridViewTextBoxColumn.Name = "iGFecVencDocIDDataGridViewTextBoxColumn";
            this.iGFecVencDocIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGFecVencDocIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGTipoPersJurDataGridViewTextBoxColumn
            // 
            this.iGTipoPersJurDataGridViewTextBoxColumn.DataPropertyName = "IG_TipoPersJur";
            this.iGTipoPersJurDataGridViewTextBoxColumn.HeaderText = "IG_TipoPersJur";
            this.iGTipoPersJurDataGridViewTextBoxColumn.Name = "iGTipoPersJurDataGridViewTextBoxColumn";
            this.iGTipoPersJurDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGTipoPersJurDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGEdadDataGridViewTextBoxColumn
            // 
            this.iGEdadDataGridViewTextBoxColumn.DataPropertyName = "IG_Edad";
            this.iGEdadDataGridViewTextBoxColumn.HeaderText = "IG_Edad";
            this.iGEdadDataGridViewTextBoxColumn.Name = "iGEdadDataGridViewTextBoxColumn";
            this.iGEdadDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGEdadDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGActivComerDataGridViewTextBoxColumn
            // 
            this.iGActivComerDataGridViewTextBoxColumn.DataPropertyName = "IG_ActivComer";
            this.iGActivComerDataGridViewTextBoxColumn.HeaderText = "IG_ActivComer";
            this.iGActivComerDataGridViewTextBoxColumn.Name = "iGActivComerDataGridViewTextBoxColumn";
            this.iGActivComerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGActivComerDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGVolumOperacDataGridViewTextBoxColumn
            // 
            this.iGVolumOperacDataGridViewTextBoxColumn.DataPropertyName = "IG_VolumOperac";
            this.iGVolumOperacDataGridViewTextBoxColumn.HeaderText = "IG_VolumOperac";
            this.iGVolumOperacDataGridViewTextBoxColumn.Name = "iGVolumOperacDataGridViewTextBoxColumn";
            this.iGVolumOperacDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGVolumOperacDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGCriptomonedaDataGridViewTextBoxColumn
            // 
            this.iGCriptomonedaDataGridViewTextBoxColumn.DataPropertyName = "IG_Criptomoneda";
            this.iGCriptomonedaDataGridViewTextBoxColumn.HeaderText = "IG_Criptomoneda";
            this.iGCriptomonedaDataGridViewTextBoxColumn.Name = "iGCriptomonedaDataGridViewTextBoxColumn";
            this.iGCriptomonedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGCriptomonedaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGTipoEstructuraDataGridViewTextBoxColumn
            // 
            this.iGTipoEstructuraDataGridViewTextBoxColumn.DataPropertyName = "IG_TipoEstructura";
            this.iGTipoEstructuraDataGridViewTextBoxColumn.HeaderText = "IG_TipoEstructura";
            this.iGTipoEstructuraDataGridViewTextBoxColumn.Name = "iGTipoEstructuraDataGridViewTextBoxColumn";
            this.iGTipoEstructuraDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGTipoEstructuraDataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio1DataGridViewTextBoxColumn
            // 
            this.iGServicio1DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio1";
            this.iGServicio1DataGridViewTextBoxColumn.HeaderText = "IG_Servicio1";
            this.iGServicio1DataGridViewTextBoxColumn.Name = "iGServicio1DataGridViewTextBoxColumn";
            this.iGServicio1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio1DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio2DataGridViewTextBoxColumn
            // 
            this.iGServicio2DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio2";
            this.iGServicio2DataGridViewTextBoxColumn.HeaderText = "IG_Servicio2";
            this.iGServicio2DataGridViewTextBoxColumn.Name = "iGServicio2DataGridViewTextBoxColumn";
            this.iGServicio2DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio2DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio3DataGridViewTextBoxColumn
            // 
            this.iGServicio3DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio3";
            this.iGServicio3DataGridViewTextBoxColumn.HeaderText = "IG_Servicio3";
            this.iGServicio3DataGridViewTextBoxColumn.Name = "iGServicio3DataGridViewTextBoxColumn";
            this.iGServicio3DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio3DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio4DataGridViewTextBoxColumn
            // 
            this.iGServicio4DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio4";
            this.iGServicio4DataGridViewTextBoxColumn.HeaderText = "IG_Servicio4";
            this.iGServicio4DataGridViewTextBoxColumn.Name = "iGServicio4DataGridViewTextBoxColumn";
            this.iGServicio4DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio4DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio5DataGridViewTextBoxColumn
            // 
            this.iGServicio5DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio5";
            this.iGServicio5DataGridViewTextBoxColumn.HeaderText = "IG_Servicio5";
            this.iGServicio5DataGridViewTextBoxColumn.Name = "iGServicio5DataGridViewTextBoxColumn";
            this.iGServicio5DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio5DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio6DataGridViewTextBoxColumn
            // 
            this.iGServicio6DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio6";
            this.iGServicio6DataGridViewTextBoxColumn.HeaderText = "IG_Servicio6";
            this.iGServicio6DataGridViewTextBoxColumn.Name = "iGServicio6DataGridViewTextBoxColumn";
            this.iGServicio6DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio6DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio7DataGridViewTextBoxColumn
            // 
            this.iGServicio7DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio7";
            this.iGServicio7DataGridViewTextBoxColumn.HeaderText = "IG_Servicio7";
            this.iGServicio7DataGridViewTextBoxColumn.Name = "iGServicio7DataGridViewTextBoxColumn";
            this.iGServicio7DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio7DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio8DataGridViewTextBoxColumn
            // 
            this.iGServicio8DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio8";
            this.iGServicio8DataGridViewTextBoxColumn.HeaderText = "IG_Servicio8";
            this.iGServicio8DataGridViewTextBoxColumn.Name = "iGServicio8DataGridViewTextBoxColumn";
            this.iGServicio8DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio8DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio9DataGridViewTextBoxColumn
            // 
            this.iGServicio9DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio9";
            this.iGServicio9DataGridViewTextBoxColumn.HeaderText = "IG_Servicio9";
            this.iGServicio9DataGridViewTextBoxColumn.Name = "iGServicio9DataGridViewTextBoxColumn";
            this.iGServicio9DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio9DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGServicio10DataGridViewTextBoxColumn
            // 
            this.iGServicio10DataGridViewTextBoxColumn.DataPropertyName = "IG_Servicio10";
            this.iGServicio10DataGridViewTextBoxColumn.HeaderText = "IG_Servicio10";
            this.iGServicio10DataGridViewTextBoxColumn.Name = "iGServicio10DataGridViewTextBoxColumn";
            this.iGServicio10DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGServicio10DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto1DataGridViewTextBoxColumn
            // 
            this.iGProducto1DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto1";
            this.iGProducto1DataGridViewTextBoxColumn.HeaderText = "IG_Producto1";
            this.iGProducto1DataGridViewTextBoxColumn.Name = "iGProducto1DataGridViewTextBoxColumn";
            this.iGProducto1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto1DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto2DataGridViewTextBoxColumn
            // 
            this.iGProducto2DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto2";
            this.iGProducto2DataGridViewTextBoxColumn.HeaderText = "IG_Producto2";
            this.iGProducto2DataGridViewTextBoxColumn.Name = "iGProducto2DataGridViewTextBoxColumn";
            this.iGProducto2DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto2DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto3DataGridViewTextBoxColumn
            // 
            this.iGProducto3DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto3";
            this.iGProducto3DataGridViewTextBoxColumn.HeaderText = "IG_Producto3";
            this.iGProducto3DataGridViewTextBoxColumn.Name = "iGProducto3DataGridViewTextBoxColumn";
            this.iGProducto3DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto3DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto4DataGridViewTextBoxColumn
            // 
            this.iGProducto4DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto4";
            this.iGProducto4DataGridViewTextBoxColumn.HeaderText = "IG_Producto4";
            this.iGProducto4DataGridViewTextBoxColumn.Name = "iGProducto4DataGridViewTextBoxColumn";
            this.iGProducto4DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto4DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto5DataGridViewTextBoxColumn
            // 
            this.iGProducto5DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto5";
            this.iGProducto5DataGridViewTextBoxColumn.HeaderText = "IG_Producto5";
            this.iGProducto5DataGridViewTextBoxColumn.Name = "iGProducto5DataGridViewTextBoxColumn";
            this.iGProducto5DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto5DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto6DataGridViewTextBoxColumn
            // 
            this.iGProducto6DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto6";
            this.iGProducto6DataGridViewTextBoxColumn.HeaderText = "IG_Producto6";
            this.iGProducto6DataGridViewTextBoxColumn.Name = "iGProducto6DataGridViewTextBoxColumn";
            this.iGProducto6DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto6DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto7DataGridViewTextBoxColumn
            // 
            this.iGProducto7DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto7";
            this.iGProducto7DataGridViewTextBoxColumn.HeaderText = "IG_Producto7";
            this.iGProducto7DataGridViewTextBoxColumn.Name = "iGProducto7DataGridViewTextBoxColumn";
            this.iGProducto7DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto7DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto8DataGridViewTextBoxColumn
            // 
            this.iGProducto8DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto8";
            this.iGProducto8DataGridViewTextBoxColumn.HeaderText = "IG_Producto8";
            this.iGProducto8DataGridViewTextBoxColumn.Name = "iGProducto8DataGridViewTextBoxColumn";
            this.iGProducto8DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto8DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto9DataGridViewTextBoxColumn
            // 
            this.iGProducto9DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto9";
            this.iGProducto9DataGridViewTextBoxColumn.HeaderText = "IG_Producto9";
            this.iGProducto9DataGridViewTextBoxColumn.Name = "iGProducto9DataGridViewTextBoxColumn";
            this.iGProducto9DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto9DataGridViewTextBoxColumn.Visible = false;
            // 
            // iGProducto10DataGridViewTextBoxColumn
            // 
            this.iGProducto10DataGridViewTextBoxColumn.DataPropertyName = "IG_Producto10";
            this.iGProducto10DataGridViewTextBoxColumn.HeaderText = "IG_Producto10";
            this.iGProducto10DataGridViewTextBoxColumn.Name = "iGProducto10DataGridViewTextBoxColumn";
            this.iGProducto10DataGridViewTextBoxColumn.ReadOnly = true;
            this.iGProducto10DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc1DataGridViewTextBoxColumn
            // 
            this.cEOpc1DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc1";
            this.cEOpc1DataGridViewTextBoxColumn.HeaderText = "CE_Opc1";
            this.cEOpc1DataGridViewTextBoxColumn.Name = "cEOpc1DataGridViewTextBoxColumn";
            this.cEOpc1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc1DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc2DataGridViewTextBoxColumn
            // 
            this.cEOpc2DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc2";
            this.cEOpc2DataGridViewTextBoxColumn.HeaderText = "CE_Opc2";
            this.cEOpc2DataGridViewTextBoxColumn.Name = "cEOpc2DataGridViewTextBoxColumn";
            this.cEOpc2DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc2DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc3DataGridViewTextBoxColumn
            // 
            this.cEOpc3DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc3";
            this.cEOpc3DataGridViewTextBoxColumn.HeaderText = "CE_Opc3";
            this.cEOpc3DataGridViewTextBoxColumn.Name = "cEOpc3DataGridViewTextBoxColumn";
            this.cEOpc3DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc3DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc4DataGridViewTextBoxColumn
            // 
            this.cEOpc4DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc4";
            this.cEOpc4DataGridViewTextBoxColumn.HeaderText = "CE_Opc4";
            this.cEOpc4DataGridViewTextBoxColumn.Name = "cEOpc4DataGridViewTextBoxColumn";
            this.cEOpc4DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc4DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc5DataGridViewTextBoxColumn
            // 
            this.cEOpc5DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc5";
            this.cEOpc5DataGridViewTextBoxColumn.HeaderText = "CE_Opc5";
            this.cEOpc5DataGridViewTextBoxColumn.Name = "cEOpc5DataGridViewTextBoxColumn";
            this.cEOpc5DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc5DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc6DataGridViewTextBoxColumn
            // 
            this.cEOpc6DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc6";
            this.cEOpc6DataGridViewTextBoxColumn.HeaderText = "CE_Opc6";
            this.cEOpc6DataGridViewTextBoxColumn.Name = "cEOpc6DataGridViewTextBoxColumn";
            this.cEOpc6DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc6DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc7DataGridViewTextBoxColumn
            // 
            this.cEOpc7DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc7";
            this.cEOpc7DataGridViewTextBoxColumn.HeaderText = "CE_Opc7";
            this.cEOpc7DataGridViewTextBoxColumn.Name = "cEOpc7DataGridViewTextBoxColumn";
            this.cEOpc7DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc7DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc8DataGridViewTextBoxColumn
            // 
            this.cEOpc8DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc8";
            this.cEOpc8DataGridViewTextBoxColumn.HeaderText = "CE_Opc8";
            this.cEOpc8DataGridViewTextBoxColumn.Name = "cEOpc8DataGridViewTextBoxColumn";
            this.cEOpc8DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc8DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc9DataGridViewTextBoxColumn
            // 
            this.cEOpc9DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc9";
            this.cEOpc9DataGridViewTextBoxColumn.HeaderText = "CE_Opc9";
            this.cEOpc9DataGridViewTextBoxColumn.Name = "cEOpc9DataGridViewTextBoxColumn";
            this.cEOpc9DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc9DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc10DataGridViewTextBoxColumn
            // 
            this.cEOpc10DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc10";
            this.cEOpc10DataGridViewTextBoxColumn.HeaderText = "CE_Opc10";
            this.cEOpc10DataGridViewTextBoxColumn.Name = "cEOpc10DataGridViewTextBoxColumn";
            this.cEOpc10DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc10DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc11DataGridViewTextBoxColumn
            // 
            this.cEOpc11DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc11";
            this.cEOpc11DataGridViewTextBoxColumn.HeaderText = "CE_Opc11";
            this.cEOpc11DataGridViewTextBoxColumn.Name = "cEOpc11DataGridViewTextBoxColumn";
            this.cEOpc11DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc11DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc12DataGridViewTextBoxColumn
            // 
            this.cEOpc12DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc12";
            this.cEOpc12DataGridViewTextBoxColumn.HeaderText = "CE_Opc12";
            this.cEOpc12DataGridViewTextBoxColumn.Name = "cEOpc12DataGridViewTextBoxColumn";
            this.cEOpc12DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc12DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc13DataGridViewTextBoxColumn
            // 
            this.cEOpc13DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc13";
            this.cEOpc13DataGridViewTextBoxColumn.HeaderText = "CE_Opc13";
            this.cEOpc13DataGridViewTextBoxColumn.Name = "cEOpc13DataGridViewTextBoxColumn";
            this.cEOpc13DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc13DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc14DataGridViewTextBoxColumn
            // 
            this.cEOpc14DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc14";
            this.cEOpc14DataGridViewTextBoxColumn.HeaderText = "CE_Opc14";
            this.cEOpc14DataGridViewTextBoxColumn.Name = "cEOpc14DataGridViewTextBoxColumn";
            this.cEOpc14DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc14DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc15DataGridViewTextBoxColumn
            // 
            this.cEOpc15DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc15";
            this.cEOpc15DataGridViewTextBoxColumn.HeaderText = "CE_Opc15";
            this.cEOpc15DataGridViewTextBoxColumn.Name = "cEOpc15DataGridViewTextBoxColumn";
            this.cEOpc15DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc15DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc16DataGridViewTextBoxColumn
            // 
            this.cEOpc16DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc16";
            this.cEOpc16DataGridViewTextBoxColumn.HeaderText = "CE_Opc16";
            this.cEOpc16DataGridViewTextBoxColumn.Name = "cEOpc16DataGridViewTextBoxColumn";
            this.cEOpc16DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc16DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc17DataGridViewTextBoxColumn
            // 
            this.cEOpc17DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc17";
            this.cEOpc17DataGridViewTextBoxColumn.HeaderText = "CE_Opc17";
            this.cEOpc17DataGridViewTextBoxColumn.Name = "cEOpc17DataGridViewTextBoxColumn";
            this.cEOpc17DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc17DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc18DataGridViewTextBoxColumn
            // 
            this.cEOpc18DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc18";
            this.cEOpc18DataGridViewTextBoxColumn.HeaderText = "CE_Opc18";
            this.cEOpc18DataGridViewTextBoxColumn.Name = "cEOpc18DataGridViewTextBoxColumn";
            this.cEOpc18DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc18DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc19DataGridViewTextBoxColumn
            // 
            this.cEOpc19DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc19";
            this.cEOpc19DataGridViewTextBoxColumn.HeaderText = "CE_Opc19";
            this.cEOpc19DataGridViewTextBoxColumn.Name = "cEOpc19DataGridViewTextBoxColumn";
            this.cEOpc19DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc19DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc20DataGridViewTextBoxColumn
            // 
            this.cEOpc20DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc20";
            this.cEOpc20DataGridViewTextBoxColumn.HeaderText = "CE_Opc20";
            this.cEOpc20DataGridViewTextBoxColumn.Name = "cEOpc20DataGridViewTextBoxColumn";
            this.cEOpc20DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc20DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc21DataGridViewTextBoxColumn
            // 
            this.cEOpc21DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc21";
            this.cEOpc21DataGridViewTextBoxColumn.HeaderText = "CE_Opc21";
            this.cEOpc21DataGridViewTextBoxColumn.Name = "cEOpc21DataGridViewTextBoxColumn";
            this.cEOpc21DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc21DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc22DataGridViewTextBoxColumn
            // 
            this.cEOpc22DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc22";
            this.cEOpc22DataGridViewTextBoxColumn.HeaderText = "CE_Opc22";
            this.cEOpc22DataGridViewTextBoxColumn.Name = "cEOpc22DataGridViewTextBoxColumn";
            this.cEOpc22DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc22DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc23DataGridViewTextBoxColumn
            // 
            this.cEOpc23DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc23";
            this.cEOpc23DataGridViewTextBoxColumn.HeaderText = "CE_Opc23";
            this.cEOpc23DataGridViewTextBoxColumn.Name = "cEOpc23DataGridViewTextBoxColumn";
            this.cEOpc23DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc23DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc24DataGridViewTextBoxColumn
            // 
            this.cEOpc24DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc24";
            this.cEOpc24DataGridViewTextBoxColumn.HeaderText = "CE_Opc24";
            this.cEOpc24DataGridViewTextBoxColumn.Name = "cEOpc24DataGridViewTextBoxColumn";
            this.cEOpc24DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc24DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc25DataGridViewTextBoxColumn
            // 
            this.cEOpc25DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc25";
            this.cEOpc25DataGridViewTextBoxColumn.HeaderText = "CE_Opc25";
            this.cEOpc25DataGridViewTextBoxColumn.Name = "cEOpc25DataGridViewTextBoxColumn";
            this.cEOpc25DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc25DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc26DataGridViewTextBoxColumn
            // 
            this.cEOpc26DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc26";
            this.cEOpc26DataGridViewTextBoxColumn.HeaderText = "CE_Opc26";
            this.cEOpc26DataGridViewTextBoxColumn.Name = "cEOpc26DataGridViewTextBoxColumn";
            this.cEOpc26DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc26DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc27DataGridViewTextBoxColumn
            // 
            this.cEOpc27DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc27";
            this.cEOpc27DataGridViewTextBoxColumn.HeaderText = "CE_Opc27";
            this.cEOpc27DataGridViewTextBoxColumn.Name = "cEOpc27DataGridViewTextBoxColumn";
            this.cEOpc27DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc27DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc28DataGridViewTextBoxColumn
            // 
            this.cEOpc28DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc28";
            this.cEOpc28DataGridViewTextBoxColumn.HeaderText = "CE_Opc28";
            this.cEOpc28DataGridViewTextBoxColumn.Name = "cEOpc28DataGridViewTextBoxColumn";
            this.cEOpc28DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc28DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc29DataGridViewTextBoxColumn
            // 
            this.cEOpc29DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc29";
            this.cEOpc29DataGridViewTextBoxColumn.HeaderText = "CE_Opc29";
            this.cEOpc29DataGridViewTextBoxColumn.Name = "cEOpc29DataGridViewTextBoxColumn";
            this.cEOpc29DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc29DataGridViewTextBoxColumn.Visible = false;
            // 
            // cEOpc30DataGridViewTextBoxColumn
            // 
            this.cEOpc30DataGridViewTextBoxColumn.DataPropertyName = "CE_Opc30";
            this.cEOpc30DataGridViewTextBoxColumn.HeaderText = "CE_Opc30";
            this.cEOpc30DataGridViewTextBoxColumn.Name = "cEOpc30DataGridViewTextBoxColumn";
            this.cEOpc30DataGridViewTextBoxColumn.ReadOnly = true;
            this.cEOpc30DataGridViewTextBoxColumn.Visible = false;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // ejecutivoDataGridViewTextBoxColumn
            // 
            this.ejecutivoDataGridViewTextBoxColumn.DataPropertyName = "Ejecutivo";
            this.ejecutivoDataGridViewTextBoxColumn.HeaderText = "Ejecutivo";
            this.ejecutivoDataGridViewTextBoxColumn.Name = "ejecutivoDataGridViewTextBoxColumn";
            this.ejecutivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ejecutivoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nivelRiesgoDataGridViewTextBoxColumn
            // 
            this.nivelRiesgoDataGridViewTextBoxColumn.DataPropertyName = "NivelRiesgo";
            this.nivelRiesgoDataGridViewTextBoxColumn.HeaderText = "NivelRiesgo";
            this.nivelRiesgoDataGridViewTextBoxColumn.Name = "nivelRiesgoDataGridViewTextBoxColumn";
            this.nivelRiesgoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nivelRiesgoDataGridViewTextBoxColumn.Visible = false;
            // 
            // perfilFinancieroDataGridViewTextBoxColumn
            // 
            this.perfilFinancieroDataGridViewTextBoxColumn.DataPropertyName = "PerfilFinanciero";
            this.perfilFinancieroDataGridViewTextBoxColumn.HeaderText = "PerfilFinanciero";
            this.perfilFinancieroDataGridViewTextBoxColumn.Name = "perfilFinancieroDataGridViewTextBoxColumn";
            this.perfilFinancieroDataGridViewTextBoxColumn.ReadOnly = true;
            this.perfilFinancieroDataGridViewTextBoxColumn.Visible = false;
            // 
            // periodUsoCtaDataGridViewTextBoxColumn
            // 
            this.periodUsoCtaDataGridViewTextBoxColumn.DataPropertyName = "PeriodUsoCta";
            this.periodUsoCtaDataGridViewTextBoxColumn.HeaderText = "PeriodUsoCta";
            this.periodUsoCtaDataGridViewTextBoxColumn.Name = "periodUsoCtaDataGridViewTextBoxColumn";
            this.periodUsoCtaDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodUsoCtaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nroTransaccionesDataGridViewTextBoxColumn
            // 
            this.nroTransaccionesDataGridViewTextBoxColumn.DataPropertyName = "NroTransacciones";
            this.nroTransaccionesDataGridViewTextBoxColumn.HeaderText = "NroTransacciones";
            this.nroTransaccionesDataGridViewTextBoxColumn.Name = "nroTransaccionesDataGridViewTextBoxColumn";
            this.nroTransaccionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroTransaccionesDataGridViewTextBoxColumn.Visible = false;
            // 
            // fecUltimActDataGridViewTextBoxColumn
            // 
            this.fecUltimActDataGridViewTextBoxColumn.DataPropertyName = "Fec_UltimAct";
            this.fecUltimActDataGridViewTextBoxColumn.HeaderText = "Fec_UltimAct";
            this.fecUltimActDataGridViewTextBoxColumn.Name = "fecUltimActDataGridViewTextBoxColumn";
            this.fecUltimActDataGridViewTextBoxColumn.ReadOnly = true;
            this.fecUltimActDataGridViewTextBoxColumn.Visible = false;
            // 
            // trimMesDataGridViewTextBoxColumn
            // 
            this.trimMesDataGridViewTextBoxColumn.DataPropertyName = "Trim_Mes";
            this.trimMesDataGridViewTextBoxColumn.HeaderText = "Trim_Mes";
            this.trimMesDataGridViewTextBoxColumn.Name = "trimMesDataGridViewTextBoxColumn";
            this.trimMesDataGridViewTextBoxColumn.ReadOnly = true;
            this.trimMesDataGridViewTextBoxColumn.Visible = false;
            // 
            // trimAnoDataGridViewTextBoxColumn
            // 
            this.trimAnoDataGridViewTextBoxColumn.DataPropertyName = "Trim_Ano";
            this.trimAnoDataGridViewTextBoxColumn.HeaderText = "Trim_Ano";
            this.trimAnoDataGridViewTextBoxColumn.Name = "trimAnoDataGridViewTextBoxColumn";
            this.trimAnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.trimAnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // trimNroOperacDataGridViewTextBoxColumn
            // 
            this.trimNroOperacDataGridViewTextBoxColumn.DataPropertyName = "Trim_NroOperac";
            this.trimNroOperacDataGridViewTextBoxColumn.HeaderText = "Trim_NroOperac";
            this.trimNroOperacDataGridViewTextBoxColumn.Name = "trimNroOperacDataGridViewTextBoxColumn";
            this.trimNroOperacDataGridViewTextBoxColumn.ReadOnly = true;
            this.trimNroOperacDataGridViewTextBoxColumn.Visible = false;
            // 
            // trimMontoOperacDataGridViewTextBoxColumn
            // 
            this.trimMontoOperacDataGridViewTextBoxColumn.DataPropertyName = "Trim_MontoOperac";
            this.trimMontoOperacDataGridViewTextBoxColumn.HeaderText = "Trim_MontoOperac";
            this.trimMontoOperacDataGridViewTextBoxColumn.Name = "trimMontoOperacDataGridViewTextBoxColumn";
            this.trimMontoOperacDataGridViewTextBoxColumn.ReadOnly = true;
            this.trimMontoOperacDataGridViewTextBoxColumn.Visible = false;
            // 
            // mapaEmpresaDataGridViewTextBoxColumn
            // 
            this.mapaEmpresaDataGridViewTextBoxColumn.DataPropertyName = "MapaEmpresa";
            this.mapaEmpresaDataGridViewTextBoxColumn.HeaderText = "MapaEmpresa";
            this.mapaEmpresaDataGridViewTextBoxColumn.Name = "mapaEmpresaDataGridViewTextBoxColumn";
            this.mapaEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mapaEmpresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // BS_CHistActClientes
            // 
            this.BS_CHistActClientes.DataSource = typeof(MofinModelo.C_HistActClientes);
            // 
            // BS_MAntiguedad
            // 
            this.BS_MAntiguedad.DataSource = typeof(MofinModelo.M_Antiguedad);
            // 
            // BS_MNivelRiesgo
            // 
            this.BS_MNivelRiesgo.DataSource = typeof(MofinModelo.M_NivelRiesgo);
            // 
            // BS_MProductos
            // 
            this.BS_MProductos.DataSource = typeof(MofinModelo.M_Productos);
            // 
            // BS_MServicios
            // 
            this.BS_MServicios.DataSource = typeof(MofinModelo.M_Servicios);
            // 
            // BS_MVolOperPersJur
            // 
            this.BS_MVolOperPersJur.DataSource = typeof(MofinModelo.M_VolOperPersJur);
            // 
            // Cmb_Antiguedad
            // 
            this.Cmb_Antiguedad.FormattingEnabled = true;
            this.Cmb_Antiguedad.Location = new System.Drawing.Point(404, 4);
            this.Cmb_Antiguedad.Name = "Cmb_Antiguedad";
            this.Cmb_Antiguedad.Size = new System.Drawing.Size(250, 23);
            this.Cmb_Antiguedad.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(404, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 23);
            this.comboBox1.TabIndex = 51;
            // 
            // Cmb_NivelRiesgo
            // 
            this.Cmb_NivelRiesgo.FormattingEnabled = true;
            this.Cmb_NivelRiesgo.Location = new System.Drawing.Point(5, 250);
            this.Cmb_NivelRiesgo.Name = "Cmb_NivelRiesgo";
            this.Cmb_NivelRiesgo.Size = new System.Drawing.Size(176, 23);
            this.Cmb_NivelRiesgo.TabIndex = 38;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1068, 596);
            this.Controls.Add(this.Grd_Clientes);
            this.Controls.Add(this.Lbl_EtiqPunt);
            this.Controls.Add(this.Lbl_Activo);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_Puntuacion);
            this.Controls.Add(this.Tab_Clientes);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(Lbl_Nombre);
            this.Controls.Add(Lbl_DocID);
            this.Controls.Add(Lbl_Codigo);
            this.Controls.Add(this.Pan_DetallesEnc);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Clientes";
            this.Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            this.Resizable = false;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            this.Tab_Clientes.ResumeLayout(false);
            this.Pag1.ResumeLayout(false);
            this.Pag1.PerformLayout();
            this.Pan_Detalles1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoDocID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MCriptomonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersNat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoEstructuraEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoPersJuridica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MActivComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProfesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Nac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPais)).EndInit();
            this.Pag2.ResumeLayout(false);
            this.Pag2.PerformLayout();
            this.Pan_BenefBtns.ResumeLayout(false);
            this.Pan_Detalles2.ResumeLayout(false);
            this.Pan_Detalles2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CFirBenAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutCriptomoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutPEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_BenefVincPorcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutProfesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutNac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AutPaisNac)).EndInit();
            this.Grp_BenfTipoVinculacion.ResumeLayout(false);
            this.Grp_BenfTipoVinculacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_CFirBenAcc)).EndInit();
            this.Pag3.ResumeLayout(false);
            this.Pan_Detalles3.ResumeLayout(false);
            this.Pag4.ResumeLayout(false);
            this.Pag4.PerformLayout();
            this.Pan_Detalles4.ResumeLayout(false);
            this.Pan_Detalles4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NroTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TriMes)).EndInit();
            this.Grp_PerUsoCta.ResumeLayout(false);
            this.Grp_PerUsoCta.PerformLayout();
            this.Pag5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_MapEpresa)).EndInit();
            this.Pan_DetallesEnc.ResumeLayout(false);
            this.Pan_DetallesEnc.PerformLayout();
            this.Grp_TipoPersona.ResumeLayout(false);
            this.Grp_TipoPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorOperacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHistActClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAntiguedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MNivelRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersJur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox Txt_TriNroOperaciones;
        private System.Windows.Forms.PictureBox Pic_MapEpresa;
        private System.Windows.Forms.Label Lbl_Puntuacion;
        private System.Windows.Forms.Button Btn_Trimestre;
        private System.Windows.Forms.Label Lbl_Activo;
        private System.Windows.Forms.Label Lbl_BenefEtiqPuntuacion;
        private System.Windows.Forms.Label Lbl_BenefPuntuacion;
        private System.Windows.Forms.Label Lbl_EtiqPunt;
        private System.Windows.Forms.Button Btn_BenefEliminar;
        private System.Windows.Forms.Button Btn_BenefModificar;
        private System.Windows.Forms.Button Btn_BenefIncluir;
        private System.Windows.Forms.Button Btn_BenefAceptar;
        private System.Windows.Forms.Button Btn_BenefCancelar;
        private System.Windows.Forms.Panel Pan_BenefBtns;
        private System.Windows.Forms.Panel Pan_Detalles1;
        private System.Windows.Forms.ListBox Lst_Productos;
        private System.Windows.Forms.ComboBox Cmb_Criptomonedas;
        private System.Windows.Forms.ComboBox Cmb_VolOperNat;
        private System.Windows.Forms.ComboBox Cmb_PEP;
        private System.Windows.Forms.ComboBox Cmb_TipoEstructura;
        private System.Windows.Forms.ComboBox Cmb_TipoPersJuridica;
        private System.Windows.Forms.ComboBox Cmb_Edad;
        private System.Windows.Forms.ListBox Lst_Servicios;
        private System.Windows.Forms.ComboBox Cmb_ActivComercial;
        private System.Windows.Forms.ComboBox Cmb_Profesion;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.ComboBox Cmb_PaisResidencia;
        private System.Windows.Forms.ComboBox Cmb_PaisNacimiento;
        private System.Windows.Forms.ComboBox Cmb_Nacionalidad;
        private System.Windows.Forms.DateTimePicker DTP_FecVencDocID;
        private System.Windows.Forms.Panel Pan_Detalles2;
        private System.Windows.Forms.ComboBox Cmb_BenefCriptomonedas;
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
        private System.Windows.Forms.DataGridView Grd_CFirBenAcc;
        private System.Windows.Forms.Panel Pan_Detalles3;
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
        private System.Windows.Forms.Panel Pan_Detalles4;
        private System.Windows.Forms.NumericUpDown NUD_NroTransacciones;
        private System.Windows.Forms.NumericUpDown NUD_TriAno;
        private System.Windows.Forms.NumericUpDown NUD_TriMes;
        private System.Windows.Forms.TextBox Txt_TriMntOperaciones;
        private System.Windows.Forms.DateTimePicker DTP_FecUltAct;
        private System.Windows.Forms.TextBox periodUsoCtaTextBox;
        private System.Windows.Forms.TextBox Txt_PerFinanciero;
        private System.Windows.Forms.TextBox Txt_Ejecutivo;
        private System.Windows.Forms.TextBox Txt_Observacion;
        private System.Windows.Forms.GroupBox Grp_PerUsoCta;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta5;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta4;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta3;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta2;
        private System.Windows.Forms.RadioButton Opt_PerUsoCta1;
        private System.Windows.Forms.Panel Pan_DetallesEnc;
        private System.Windows.Forms.GroupBox Grp_TipoPersona;
        private System.Windows.Forms.RadioButton Opc_TipPers2;
        private System.Windows.Forms.RadioButton Opc_TipPers1;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_DocID;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.ComboBox Cmb_TipDocID;
        private MonitorOperacionesDataSet monitorOperacionesDataSet;
        private System.Windows.Forms.DataGridView Grd_Clientes;
        private System.Windows.Forms.BindingSource BS_MPais;
        private System.Windows.Forms.BindingSource BS_CClientes;
        private System.Windows.Forms.BindingSource BS_CFirBenAcc;
        private System.Windows.Forms.BindingSource BS_CHistActClientes;
        private System.Windows.Forms.BindingSource BS_MActivComercial;
        private System.Windows.Forms.BindingSource BS_MAntiguedad;
        private System.Windows.Forms.BindingSource BS_MTipoDocID;
        private System.Windows.Forms.BindingSource BS_MCriptomonedas;
        private System.Windows.Forms.BindingSource BS_MVolOperPersNat;
        private System.Windows.Forms.BindingSource BS_MPEP;
        private System.Windows.Forms.BindingSource BS_MTipoEstructuraEmpresa;
        private System.Windows.Forms.BindingSource BS_MTipoPersJuridica;
        private System.Windows.Forms.BindingSource BS_MEdad;
        private System.Windows.Forms.BindingSource BS_MProfesiones;
        private System.Windows.Forms.BindingSource BS_MEstados;
        private System.Windows.Forms.BindingSource BS_MNivelRiesgo;
        private System.Windows.Forms.BindingSource BS_MProductos;
        private System.Windows.Forms.BindingSource BS_MServicios;
        private System.Windows.Forms.BindingSource BS_MVolOperPersJur;
        private System.Windows.Forms.BindingSource BS_Res;
        private System.Windows.Forms.BindingSource BS_Nac;
        private System.Windows.Forms.BindingSource BS_AutRes;
        private System.Windows.Forms.BindingSource BS_AutNac;
        private System.Windows.Forms.BindingSource BS_AutPaisNac;
        private System.Windows.Forms.BindingSource BS_AutCriptomoneda;
        private System.Windows.Forms.BindingSource BS_AutPEP;
        private System.Windows.Forms.BindingSource BS_AutProfesion;
        private System.Windows.Forms.BindingSource BS_AutEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientePuntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn benefPuntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infGenPuntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constExpedPuntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condEspSeguridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGPaisNacimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGNacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGPaisResidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGPEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProfesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGTipDocIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGFecVencDocIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGTipoPersJurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGEdadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGActivComerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGVolumOperacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGCriptomonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGTipoEstructuraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGServicio10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGProducto10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc17DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc18DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc21DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc22DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc23DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc24DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc25DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc26DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc27DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc28DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc29DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEOpc30DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelRiesgoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilFinancieroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodUsoCtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTransaccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecUltimActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trimMesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trimAnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trimNroOperacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trimMontoOperacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapaEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Cmb_Antiguedad;
        private System.Windows.Forms.ComboBox Cmb_NivelRiesgo;
    }
}