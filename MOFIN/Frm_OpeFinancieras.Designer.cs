namespace MOFIN
{
    partial class Frm_OpeFinancieras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OpeFinancieras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab_MonOperaciones = new System.Windows.Forms.TabControl();
            this.Pag1 = new System.Windows.Forms.TabPage();
            this.Pan_Pag1 = new System.Windows.Forms.Panel();
            this.Grd_Clientes = new System.Windows.Forms.DataGridView();
            this.BS_CClientes = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_Hasta1 = new System.Windows.Forms.Label();
            this.Lbl_Desde1 = new System.Windows.Forms.Label();
            this.Dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.Chk_Exportar = new System.Windows.Forms.CheckBox();
            this.Btn_Procesar = new System.Windows.Forms.Button();
            this.Chk_IncSoloExcep = new System.Windows.Forms.CheckBox();
            this.Chk_ExcMeses = new System.Windows.Forms.CheckBox();
            this.Lbl_ListClientes1 = new System.Windows.Forms.Label();
            this.Lbl_ListOperAfec = new System.Windows.Forms.Label();
            this.Grd_MonitorFinanciero = new System.Windows.Forms.DataGridView();
            this.iDSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecGeneracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecUltOperacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivRiesgoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodUsoCtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTransacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfNroTransacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcTransacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtoComprasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtoVentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totOperacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfFinancieroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcOperacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejecutivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_RepOperacional = new System.Windows.Forms.BindingSource(this.components);
            this.Pag2 = new System.Windows.Forms.TabPage();
            this.Grd_Observaciones = new System.Windows.Forms.DataGridView();
            this.Col_ObsFec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ObsObserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_OObservaciones = new System.Windows.Forms.BindingSource(this.components);
            this.Grd_HistPerfOperac = new System.Windows.Forms.DataGridView();
            this.Col_PerFec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PerMto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PerNroTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PerRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_OHistPerfOperac = new System.Windows.Forms.BindingSource(this.components);
            this.Grd_ClieInfInversor = new System.Windows.Forms.DataGridView();
            this.Col_CliCod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CliDocID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CliNme2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Obsvaciones = new System.Windows.Forms.Label();
            this.Lbl_Perfil = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Lbl_ListClientes2 = new System.Windows.Forms.Label();
            this.Pan_BtnsPerfil = new System.Windows.Forms.Panel();
            this.Btn_PerfInc = new System.Windows.Forms.Button();
            this.Btn_PerfEli = new System.Windows.Forms.Button();
            this.Btn_PerfMod = new System.Windows.Forms.Button();
            this.Pan_BtnsObserv = new System.Windows.Forms.Panel();
            this.Btn_ObsInc = new System.Windows.Forms.Button();
            this.Btn_ObsMod = new System.Windows.Forms.Button();
            this.Btn_ObsEli = new System.Windows.Forms.Button();
            this.Pag3 = new System.Windows.Forms.TabPage();
            this.Pan_Pag3 = new System.Windows.Forms.Panel();
            this.Btn_Ocultar = new System.Windows.Forms.Button();
            this.Grd_Reporte = new System.Windows.Forms.DataGridView();
            this.Chk_ElimOper = new System.Windows.Forms.CheckBox();
            this.Grd_DetOperaciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn106 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn107 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn108 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn109 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn115 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn116 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn117 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn118 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn119 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn120 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn121 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn122 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn215 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn216 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn217 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn218 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn219 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_OOperFinancieras = new System.Windows.Forms.BindingSource(this.components);
            this.Grd_ClieDetOper = new System.Windows.Forms.DataGridView();
            this.Col_CliCod3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CliDocID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CliNme3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chk_Reporte = new System.Windows.Forms.CheckBox();
            this.Pan_Reporte = new System.Windows.Forms.Panel();
            this.Btn_ProcReporte = new System.Windows.Forms.Button();
            this.Lbl_Hasta2 = new System.Windows.Forms.Label();
            this.Lbl_Desde2 = new System.Windows.Forms.Label();
            this.Dtp_RepHasta = new System.Windows.Forms.DateTimePicker();
            this.Dtp_RepDesde = new System.Windows.Forms.DateTimePicker();
            this.Btn_MostrarTodos = new System.Windows.Forms.Button();
            this.Btn_Importar = new System.Windows.Forms.Button();
            this.Lbl_DetOperaciones = new System.Windows.Forms.Label();
            this.Lbl_ListClientes3 = new System.Windows.Forms.Label();
            this.Cmb_TipArchExport = new System.Windows.Forms.ComboBox();
            this.Txt_NmeArchExport = new System.Windows.Forms.TextBox();
            this.Lbl_ArcExpNme = new System.Windows.Forms.Label();
            this.Lbl_ArcExpTip = new System.Windows.Forms.Label();
            this.Btn_Exportar = new System.Windows.Forms.Button();
            this.DS_MonitorOperaciones = new MOFIN.MonitorOperacionesDataSet();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodUsoCta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfilFinanciero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTransacciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_MonOperaciones.SuspendLayout();
            this.Pag1.SuspendLayout();
            this.Pan_Pag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_MonitorFinanciero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RepOperacional)).BeginInit();
            this.Pag2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Observaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_HistPerfOperac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OHistPerfOperac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ClieInfInversor)).BeginInit();
            this.Pan_BtnsPerfil.SuspendLayout();
            this.Pan_BtnsObserv.SuspendLayout();
            this.Pag3.SuspendLayout();
            this.Pan_Pag3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_DetOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OOperFinancieras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ClieDetOper)).BeginInit();
            this.Pan_Reporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MonitorOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_MonOperaciones
            // 
            this.Tab_MonOperaciones.Controls.Add(this.Pag1);
            this.Tab_MonOperaciones.Controls.Add(this.Pag2);
            this.Tab_MonOperaciones.Controls.Add(this.Pag3);
            this.Tab_MonOperaciones.Location = new System.Drawing.Point(10, 56);
            this.Tab_MonOperaciones.Name = "Tab_MonOperaciones";
            this.Tab_MonOperaciones.SelectedIndex = 0;
            this.Tab_MonOperaciones.ShowToolTips = true;
            this.Tab_MonOperaciones.Size = new System.Drawing.Size(981, 540);
            this.Tab_MonOperaciones.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Tab_MonOperaciones.TabIndex = 0;
            // 
            // Pag1
            // 
            this.Pag1.AutoScroll = true;
            this.Pag1.Controls.Add(this.Pan_Pag1);
            this.Pag1.Location = new System.Drawing.Point(4, 23);
            this.Pag1.Name = "Pag1";
            this.Pag1.Padding = new System.Windows.Forms.Padding(3);
            this.Pag1.Size = new System.Drawing.Size(973, 513);
            this.Pag1.TabIndex = 0;
            this.Pag1.Text = "Monitor Financiero";
            this.Pag1.UseVisualStyleBackColor = true;
            // 
            // Pan_Pag1
            // 
            this.Pan_Pag1.Controls.Add(this.Grd_Clientes);
            this.Pan_Pag1.Controls.Add(this.Lbl_Hasta1);
            this.Pan_Pag1.Controls.Add(this.Lbl_Desde1);
            this.Pan_Pag1.Controls.Add(this.Dtp_Hasta);
            this.Pan_Pag1.Controls.Add(this.dtp_Desde);
            this.Pan_Pag1.Controls.Add(this.Chk_Exportar);
            this.Pan_Pag1.Controls.Add(this.Btn_Procesar);
            this.Pan_Pag1.Controls.Add(this.Chk_IncSoloExcep);
            this.Pan_Pag1.Controls.Add(this.Chk_ExcMeses);
            this.Pan_Pag1.Controls.Add(this.Lbl_ListClientes1);
            this.Pan_Pag1.Controls.Add(this.Lbl_ListOperAfec);
            this.Pan_Pag1.Controls.Add(this.Grd_MonitorFinanciero);
            this.Pan_Pag1.Location = new System.Drawing.Point(2, 4);
            this.Pan_Pag1.Name = "Pan_Pag1";
            this.Pan_Pag1.Size = new System.Drawing.Size(970, 491);
            this.Pan_Pag1.TabIndex = 18;
            // 
            // Grd_Clientes
            // 
            this.Grd_Clientes.AllowUserToAddRows = false;
            this.Grd_Clientes.AllowUserToDeleteRows = false;
            this.Grd_Clientes.AllowUserToResizeRows = false;
            this.Grd_Clientes.AutoGenerateColumns = false;
            this.Grd_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Doc_ID,
            this.Nombre,
            this.PeriodUsoCta,
            this.Activo,
            this.Ejecutivo,
            this.NivelRiesgo,
            this.PerfilFinanciero,
            this.NroTransacciones});
            this.Grd_Clientes.DataSource = this.BS_CClientes;
            this.Grd_Clientes.Location = new System.Drawing.Point(16, 27);
            this.Grd_Clientes.Name = "Grd_Clientes";
            this.Grd_Clientes.ReadOnly = true;
            this.Grd_Clientes.RowHeadersVisible = false;
            this.Grd_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_Clientes.Size = new System.Drawing.Size(350, 301);
            this.Grd_Clientes.TabIndex = 17;
            // 
            // BS_CClientes
            // 
            this.BS_CClientes.DataSource = typeof(MofinModelo.C_Clientes);
            // 
            // Lbl_Hasta1
            // 
            this.Lbl_Hasta1.AutoSize = true;
            this.Lbl_Hasta1.Location = new System.Drawing.Point(86, 368);
            this.Lbl_Hasta1.Name = "Lbl_Hasta1";
            this.Lbl_Hasta1.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Hasta1.TabIndex = 17;
            this.Lbl_Hasta1.Text = "Hasta";
            this.Lbl_Hasta1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Desde1
            // 
            this.Lbl_Desde1.AutoSize = true;
            this.Lbl_Desde1.Location = new System.Drawing.Point(86, 345);
            this.Lbl_Desde1.Name = "Lbl_Desde1";
            this.Lbl_Desde1.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Desde1.TabIndex = 16;
            this.Lbl_Desde1.Text = "Desde";
            this.Lbl_Desde1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dtp_Hasta
            // 
            this.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Hasta.Location = new System.Drawing.Point(134, 363);
            this.Dtp_Hasta.Name = "Dtp_Hasta";
            this.Dtp_Hasta.Size = new System.Drawing.Size(115, 20);
            this.Dtp_Hasta.TabIndex = 15;
            // 
            // dtp_Desde
            // 
            this.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Desde.Location = new System.Drawing.Point(134, 340);
            this.dtp_Desde.Name = "dtp_Desde";
            this.dtp_Desde.Size = new System.Drawing.Size(115, 20);
            this.dtp_Desde.TabIndex = 14;
            // 
            // Chk_Exportar
            // 
            this.Chk_Exportar.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_Exportar.AutoEllipsis = true;
            this.Chk_Exportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chk_Exportar.BackgroundImage")));
            this.Chk_Exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chk_Exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chk_Exportar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Chk_Exportar.FlatAppearance.BorderSize = 3;
            this.Chk_Exportar.Location = new System.Drawing.Point(309, 440);
            this.Chk_Exportar.Name = "Chk_Exportar";
            this.Chk_Exportar.Size = new System.Drawing.Size(48, 48);
            this.Chk_Exportar.TabIndex = 13;
            this.Chk_Exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Chk_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Chk_Exportar.UseVisualStyleBackColor = true;
            this.Chk_Exportar.CheckStateChanged += new System.EventHandler(this.Chk_Exportar_CheckStateChanged);
            // 
            // Btn_Procesar
            // 
            this.Btn_Procesar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Procesar.BackgroundImage")));
            this.Btn_Procesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Procesar.FlatAppearance.BorderSize = 0;
            this.Btn_Procesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Procesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Procesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Procesar.Location = new System.Drawing.Point(134, 429);
            this.Btn_Procesar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Procesar.Name = "Btn_Procesar";
            this.Btn_Procesar.Size = new System.Drawing.Size(38, 53);
            this.Btn_Procesar.TabIndex = 12;
            this.Btn_Procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Procesar.UseVisualStyleBackColor = true;
            this.Btn_Procesar.Click += new System.EventHandler(this.Btn_Procesar_Click);
            // 
            // Chk_IncSoloExcep
            // 
            this.Chk_IncSoloExcep.AutoSize = true;
            this.Chk_IncSoloExcep.Checked = true;
            this.Chk_IncSoloExcep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_IncSoloExcep.Location = new System.Drawing.Point(55, 404);
            this.Chk_IncSoloExcep.Name = "Chk_IncSoloExcep";
            this.Chk_IncSoloExcep.Size = new System.Drawing.Size(194, 18);
            this.Chk_IncSoloExcep.TabIndex = 5;
            this.Chk_IncSoloExcep.Text = "Incluir Solo Excepciones";
            this.Chk_IncSoloExcep.UseVisualStyleBackColor = true;
            // 
            // Chk_ExcMeses
            // 
            this.Chk_ExcMeses.AutoSize = true;
            this.Chk_ExcMeses.Checked = true;
            this.Chk_ExcMeses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_ExcMeses.Location = new System.Drawing.Point(55, 385);
            this.Chk_ExcMeses.Name = "Chk_ExcMeses";
            this.Chk_ExcMeses.Size = new System.Drawing.Size(229, 18);
            this.Chk_ExcMeses.TabIndex = 4;
            this.Chk_ExcMeses.Text = "Excluir Meses Sin Operaciones";
            this.Chk_ExcMeses.UseVisualStyleBackColor = true;
            // 
            // Lbl_ListClientes1
            // 
            this.Lbl_ListClientes1.AutoSize = true;
            this.Lbl_ListClientes1.Location = new System.Drawing.Point(10, 7);
            this.Lbl_ListClientes1.Name = "Lbl_ListClientes1";
            this.Lbl_ListClientes1.Size = new System.Drawing.Size(140, 14);
            this.Lbl_ListClientes1.TabIndex = 3;
            this.Lbl_ListClientes1.Text = "Listado de Clientes";
            // 
            // Lbl_ListOperAfec
            // 
            this.Lbl_ListOperAfec.AutoSize = true;
            this.Lbl_ListOperAfec.Location = new System.Drawing.Point(378, 7);
            this.Lbl_ListOperAfec.Name = "Lbl_ListOperAfec";
            this.Lbl_ListOperAfec.Size = new System.Drawing.Size(231, 14);
            this.Lbl_ListOperAfec.TabIndex = 2;
            this.Lbl_ListOperAfec.Text = "Listado de Operaciones Afectadas";
            // 
            // Grd_MonitorFinanciero
            // 
            this.Grd_MonitorFinanciero.AllowUserToAddRows = false;
            this.Grd_MonitorFinanciero.AllowUserToDeleteRows = false;
            this.Grd_MonitorFinanciero.AllowUserToOrderColumns = true;
            this.Grd_MonitorFinanciero.AutoGenerateColumns = false;
            this.Grd_MonitorFinanciero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_MonitorFinanciero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSistemaDataGridViewTextBoxColumn,
            this.fecGeneracionDataGridViewTextBoxColumn,
            this.fecUltOperacDataGridViewTextBoxColumn,
            this.codClienteDataGridViewTextBoxColumn,
            this.nmeclienteDataGridViewTextBoxColumn,
            this.docIDDataGridViewTextBoxColumn,
            this.nivRiesgoDataGridViewTextBoxColumn,
            this.periodUsoCtaDataGridViewTextBoxColumn,
            this.nroTransacDataGridViewTextBoxColumn,
            this.perfNroTransacDataGridViewTextBoxColumn,
            this.porcTransacDataGridViewTextBoxColumn,
            this.mtoComprasDataGridViewTextBoxColumn,
            this.mtoVentasDataGridViewTextBoxColumn,
            this.totOperacionesDataGridViewTextBoxColumn,
            this.perfFinancieroDataGridViewTextBoxColumn,
            this.porcOperacionesDataGridViewTextBoxColumn,
            this.alarmaDataGridViewTextBoxColumn,
            this.ejecutivoDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.Grd_MonitorFinanciero.DataSource = this.BS_RepOperacional;
            this.Grd_MonitorFinanciero.Location = new System.Drawing.Point(381, 27);
            this.Grd_MonitorFinanciero.Name = "Grd_MonitorFinanciero";
            this.Grd_MonitorFinanciero.ReadOnly = true;
            this.Grd_MonitorFinanciero.RowHeadersVisible = false;
            this.Grd_MonitorFinanciero.Size = new System.Drawing.Size(577, 455);
            this.Grd_MonitorFinanciero.TabIndex = 0;
            // 
            // iDSistemaDataGridViewTextBoxColumn
            // 
            this.iDSistemaDataGridViewTextBoxColumn.DataPropertyName = "ID_Sistema";
            this.iDSistemaDataGridViewTextBoxColumn.HeaderText = "ID_Sistema";
            this.iDSistemaDataGridViewTextBoxColumn.Name = "iDSistemaDataGridViewTextBoxColumn";
            this.iDSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecGeneracionDataGridViewTextBoxColumn
            // 
            this.fecGeneracionDataGridViewTextBoxColumn.DataPropertyName = "Fec_Generacion";
            this.fecGeneracionDataGridViewTextBoxColumn.HeaderText = "Fec_Generacion";
            this.fecGeneracionDataGridViewTextBoxColumn.Name = "fecGeneracionDataGridViewTextBoxColumn";
            this.fecGeneracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecUltOperacDataGridViewTextBoxColumn
            // 
            this.fecUltOperacDataGridViewTextBoxColumn.DataPropertyName = "Fec_UltOperac";
            this.fecUltOperacDataGridViewTextBoxColumn.HeaderText = "Fec_UltOperac";
            this.fecUltOperacDataGridViewTextBoxColumn.Name = "fecUltOperacDataGridViewTextBoxColumn";
            this.fecUltOperacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            this.codClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmeclienteDataGridViewTextBoxColumn
            // 
            this.nmeclienteDataGridViewTextBoxColumn.DataPropertyName = "Nme_cliente";
            this.nmeclienteDataGridViewTextBoxColumn.HeaderText = "Nme_cliente";
            this.nmeclienteDataGridViewTextBoxColumn.Name = "nmeclienteDataGridViewTextBoxColumn";
            this.nmeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docIDDataGridViewTextBoxColumn
            // 
            this.docIDDataGridViewTextBoxColumn.DataPropertyName = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.HeaderText = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.Name = "docIDDataGridViewTextBoxColumn";
            this.docIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivRiesgoDataGridViewTextBoxColumn
            // 
            this.nivRiesgoDataGridViewTextBoxColumn.DataPropertyName = "Niv_Riesgo";
            this.nivRiesgoDataGridViewTextBoxColumn.HeaderText = "Niv_Riesgo";
            this.nivRiesgoDataGridViewTextBoxColumn.Name = "nivRiesgoDataGridViewTextBoxColumn";
            this.nivRiesgoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodUsoCtaDataGridViewTextBoxColumn
            // 
            this.periodUsoCtaDataGridViewTextBoxColumn.DataPropertyName = "Period_UsoCta";
            this.periodUsoCtaDataGridViewTextBoxColumn.HeaderText = "Period_UsoCta";
            this.periodUsoCtaDataGridViewTextBoxColumn.Name = "periodUsoCtaDataGridViewTextBoxColumn";
            this.periodUsoCtaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroTransacDataGridViewTextBoxColumn
            // 
            this.nroTransacDataGridViewTextBoxColumn.DataPropertyName = "Nro_Transac";
            this.nroTransacDataGridViewTextBoxColumn.HeaderText = "Nro_Transac";
            this.nroTransacDataGridViewTextBoxColumn.Name = "nroTransacDataGridViewTextBoxColumn";
            this.nroTransacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perfNroTransacDataGridViewTextBoxColumn
            // 
            this.perfNroTransacDataGridViewTextBoxColumn.DataPropertyName = "Perf_NroTransac";
            this.perfNroTransacDataGridViewTextBoxColumn.HeaderText = "Perf_NroTransac";
            this.perfNroTransacDataGridViewTextBoxColumn.Name = "perfNroTransacDataGridViewTextBoxColumn";
            this.perfNroTransacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcTransacDataGridViewTextBoxColumn
            // 
            this.porcTransacDataGridViewTextBoxColumn.DataPropertyName = "Porc_Transac";
            this.porcTransacDataGridViewTextBoxColumn.HeaderText = "Porc_Transac";
            this.porcTransacDataGridViewTextBoxColumn.Name = "porcTransacDataGridViewTextBoxColumn";
            this.porcTransacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtoComprasDataGridViewTextBoxColumn
            // 
            this.mtoComprasDataGridViewTextBoxColumn.DataPropertyName = "Mto_Compras";
            this.mtoComprasDataGridViewTextBoxColumn.HeaderText = "Mto_Compras";
            this.mtoComprasDataGridViewTextBoxColumn.Name = "mtoComprasDataGridViewTextBoxColumn";
            this.mtoComprasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtoVentasDataGridViewTextBoxColumn
            // 
            this.mtoVentasDataGridViewTextBoxColumn.DataPropertyName = "Mto_Ventas";
            this.mtoVentasDataGridViewTextBoxColumn.HeaderText = "Mto_Ventas";
            this.mtoVentasDataGridViewTextBoxColumn.Name = "mtoVentasDataGridViewTextBoxColumn";
            this.mtoVentasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totOperacionesDataGridViewTextBoxColumn
            // 
            this.totOperacionesDataGridViewTextBoxColumn.DataPropertyName = "Tot_Operaciones";
            this.totOperacionesDataGridViewTextBoxColumn.HeaderText = "Tot_Operaciones";
            this.totOperacionesDataGridViewTextBoxColumn.Name = "totOperacionesDataGridViewTextBoxColumn";
            this.totOperacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perfFinancieroDataGridViewTextBoxColumn
            // 
            this.perfFinancieroDataGridViewTextBoxColumn.DataPropertyName = "Perf_Financiero";
            this.perfFinancieroDataGridViewTextBoxColumn.HeaderText = "Perf_Financiero";
            this.perfFinancieroDataGridViewTextBoxColumn.Name = "perfFinancieroDataGridViewTextBoxColumn";
            this.perfFinancieroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcOperacionesDataGridViewTextBoxColumn
            // 
            this.porcOperacionesDataGridViewTextBoxColumn.DataPropertyName = "Porc_Operaciones";
            this.porcOperacionesDataGridViewTextBoxColumn.HeaderText = "Porc_Operaciones";
            this.porcOperacionesDataGridViewTextBoxColumn.Name = "porcOperacionesDataGridViewTextBoxColumn";
            this.porcOperacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmaDataGridViewTextBoxColumn
            // 
            this.alarmaDataGridViewTextBoxColumn.DataPropertyName = "Alarma";
            this.alarmaDataGridViewTextBoxColumn.HeaderText = "Alarma";
            this.alarmaDataGridViewTextBoxColumn.Name = "alarmaDataGridViewTextBoxColumn";
            this.alarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ejecutivoDataGridViewTextBoxColumn
            // 
            this.ejecutivoDataGridViewTextBoxColumn.DataPropertyName = "Ejecutivo";
            this.ejecutivoDataGridViewTextBoxColumn.HeaderText = "Ejecutivo";
            this.ejecutivoDataGridViewTextBoxColumn.Name = "ejecutivoDataGridViewTextBoxColumn";
            this.ejecutivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_RepOperacional
            // 
            this.BS_RepOperacional.DataSource = typeof(MofinModelo.O_RepOperacional);
            // 
            // Pag2
            // 
            this.Pag2.AutoScroll = true;
            this.Pag2.Controls.Add(this.Grd_Observaciones);
            this.Pag2.Controls.Add(this.Grd_HistPerfOperac);
            this.Pag2.Controls.Add(this.Grd_ClieInfInversor);
            this.Pag2.Controls.Add(this.Lbl_Obsvaciones);
            this.Pag2.Controls.Add(this.Lbl_Perfil);
            this.Pag2.Controls.Add(this.Btn_Cancelar);
            this.Pag2.Controls.Add(this.Btn_Aceptar);
            this.Pag2.Controls.Add(this.Lbl_ListClientes2);
            this.Pag2.Controls.Add(this.Pan_BtnsPerfil);
            this.Pag2.Controls.Add(this.Pan_BtnsObserv);
            this.Pag2.Location = new System.Drawing.Point(4, 23);
            this.Pag2.Name = "Pag2";
            this.Pag2.Padding = new System.Windows.Forms.Padding(3);
            this.Pag2.Size = new System.Drawing.Size(973, 513);
            this.Pag2.TabIndex = 1;
            this.Pag2.Text = "Información del Inversor";
            this.Pag2.UseVisualStyleBackColor = true;
            // 
            // Grd_Observaciones
            // 
            this.Grd_Observaciones.AllowUserToAddRows = false;
            this.Grd_Observaciones.AllowUserToDeleteRows = false;
            this.Grd_Observaciones.AllowUserToOrderColumns = true;
            this.Grd_Observaciones.AutoGenerateColumns = false;
            this.Grd_Observaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grd_Observaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Observaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ObsFec,
            this.Col_ObsObserv});
            this.Grd_Observaciones.DataSource = this.BS_OObservaciones;
            this.Grd_Observaciones.Location = new System.Drawing.Point(383, 267);
            this.Grd_Observaciones.Name = "Grd_Observaciones";
            this.Grd_Observaciones.ReadOnly = true;
            this.Grd_Observaciones.RowHeadersVisible = false;
            this.Grd_Observaciones.Size = new System.Drawing.Size(577, 200);
            this.Grd_Observaciones.TabIndex = 24;
            // 
            // Col_ObsFec
            // 
            this.Col_ObsFec.DataPropertyName = "fecha";
            this.Col_ObsFec.HeaderText = "fecha";
            this.Col_ObsFec.Name = "Col_ObsFec";
            this.Col_ObsFec.ReadOnly = true;
            // 
            // Col_ObsObserv
            // 
            this.Col_ObsObserv.DataPropertyName = "Observacion";
            this.Col_ObsObserv.FillWeight = 220F;
            this.Col_ObsObserv.HeaderText = "Observacion";
            this.Col_ObsObserv.Name = "Col_ObsObserv";
            this.Col_ObsObserv.ReadOnly = true;
            this.Col_ObsObserv.Width = 474;
            // 
            // BS_OObservaciones
            // 
            this.BS_OObservaciones.DataSource = typeof(MofinModelo.O_Observaciones);
            // 
            // Grd_HistPerfOperac
            // 
            this.Grd_HistPerfOperac.AllowUserToAddRows = false;
            this.Grd_HistPerfOperac.AllowUserToDeleteRows = false;
            this.Grd_HistPerfOperac.AllowUserToOrderColumns = true;
            this.Grd_HistPerfOperac.AutoGenerateColumns = false;
            this.Grd_HistPerfOperac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_HistPerfOperac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_PerFec,
            this.Col_PerMto,
            this.Col_PerNroTra,
            this.Col_PerRiesgo});
            this.Grd_HistPerfOperac.DataSource = this.BS_OHistPerfOperac;
            this.Grd_HistPerfOperac.Location = new System.Drawing.Point(383, 31);
            this.Grd_HistPerfOperac.Name = "Grd_HistPerfOperac";
            this.Grd_HistPerfOperac.ReadOnly = true;
            this.Grd_HistPerfOperac.RowHeadersVisible = false;
            this.Grd_HistPerfOperac.Size = new System.Drawing.Size(577, 200);
            this.Grd_HistPerfOperac.TabIndex = 24;
            // 
            // Col_PerFec
            // 
            this.Col_PerFec.DataPropertyName = "Fecha";
            this.Col_PerFec.HeaderText = "Fecha";
            this.Col_PerFec.Name = "Col_PerFec";
            this.Col_PerFec.ReadOnly = true;
            // 
            // Col_PerMto
            // 
            this.Col_PerMto.DataPropertyName = "Mto_Perfil";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Col_PerMto.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_PerMto.HeaderText = "Mto_Perfil";
            this.Col_PerMto.Name = "Col_PerMto";
            this.Col_PerMto.ReadOnly = true;
            this.Col_PerMto.Width = 125;
            // 
            // Col_PerNroTra
            // 
            this.Col_PerNroTra.DataPropertyName = "Nro_Transacciones";
            this.Col_PerNroTra.HeaderText = "Nro_Transacciones";
            this.Col_PerNroTra.Name = "Col_PerNroTra";
            this.Col_PerNroTra.ReadOnly = true;
            // 
            // Col_PerRiesgo
            // 
            this.Col_PerRiesgo.DataPropertyName = "Nivel_Riesgo";
            this.Col_PerRiesgo.HeaderText = "Nivel_Riesgo";
            this.Col_PerRiesgo.Name = "Col_PerRiesgo";
            this.Col_PerRiesgo.ReadOnly = true;
            this.Col_PerRiesgo.Width = 249;
            // 
            // BS_OHistPerfOperac
            // 
            this.BS_OHistPerfOperac.DataSource = typeof(MofinModelo.O_HistPerfOperac);
            // 
            // Grd_ClieInfInversor
            // 
            this.Grd_ClieInfInversor.AllowUserToAddRows = false;
            this.Grd_ClieInfInversor.AllowUserToDeleteRows = false;
            this.Grd_ClieInfInversor.AutoGenerateColumns = false;
            this.Grd_ClieInfInversor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ClieInfInversor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CliCod2,
            this.Col_CliDocID2,
            this.Col_CliNme2,
            this.dataGridViewTextBoxColumn1});
            this.Grd_ClieInfInversor.DataSource = this.BS_CClientes;
            this.Grd_ClieInfInversor.Location = new System.Drawing.Point(18, 31);
            this.Grd_ClieInfInversor.Name = "Grd_ClieInfInversor";
            this.Grd_ClieInfInversor.ReadOnly = true;
            this.Grd_ClieInfInversor.RowHeadersVisible = false;
            this.Grd_ClieInfInversor.Size = new System.Drawing.Size(350, 475);
            this.Grd_ClieInfInversor.TabIndex = 24;
            this.Grd_ClieInfInversor.CurrentCellChanged += new System.EventHandler(this.Grd_ClieInfInversor_CurrentCellChanged);
            // 
            // Col_CliCod2
            // 
            this.Col_CliCod2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_CliCod2.DataPropertyName = "Codigo";
            this.Col_CliCod2.HeaderText = "Codigo";
            this.Col_CliCod2.Name = "Col_CliCod2";
            this.Col_CliCod2.ReadOnly = true;
            this.Col_CliCod2.Width = 74;
            // 
            // Col_CliDocID2
            // 
            this.Col_CliDocID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_CliDocID2.DataPropertyName = "Doc_ID";
            this.Col_CliDocID2.HeaderText = "Doc_ID";
            this.Col_CliDocID2.Name = "Col_CliDocID2";
            this.Col_CliDocID2.ReadOnly = true;
            this.Col_CliDocID2.Width = 74;
            // 
            // Col_CliNme2
            // 
            this.Col_CliNme2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_CliNme2.DataPropertyName = "Nombre";
            this.Col_CliNme2.HeaderText = "Nombre";
            this.Col_CliNme2.Name = "Col_CliNme2";
            this.Col_CliNme2.ReadOnly = true;
            this.Col_CliNme2.Width = 74;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PeriodUsoCta";
            this.dataGridViewTextBoxColumn1.HeaderText = "PeriodUsoCta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Lbl_Obsvaciones
            // 
            this.Lbl_Obsvaciones.AutoSize = true;
            this.Lbl_Obsvaciones.Location = new System.Drawing.Point(435, 242);
            this.Lbl_Obsvaciones.Name = "Lbl_Obsvaciones";
            this.Lbl_Obsvaciones.Size = new System.Drawing.Size(98, 14);
            this.Lbl_Obsvaciones.TabIndex = 24;
            this.Lbl_Obsvaciones.Text = "Observaciones";
            this.Lbl_Obsvaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Perfil
            // 
            this.Lbl_Perfil.AutoSize = true;
            this.Lbl_Perfil.Location = new System.Drawing.Point(435, 11);
            this.Lbl_Perfil.Name = "Lbl_Perfil";
            this.Lbl_Perfil.Size = new System.Drawing.Size(49, 14);
            this.Lbl_Perfil.TabIndex = 23;
            this.Lbl_Perfil.Text = "Perfil";
            this.Lbl_Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(736, 468);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 22;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(623, 468);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 21;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Lbl_ListClientes2
            // 
            this.Lbl_ListClientes2.AutoSize = true;
            this.Lbl_ListClientes2.Location = new System.Drawing.Point(22, 11);
            this.Lbl_ListClientes2.Name = "Lbl_ListClientes2";
            this.Lbl_ListClientes2.Size = new System.Drawing.Size(140, 14);
            this.Lbl_ListClientes2.TabIndex = 4;
            this.Lbl_ListClientes2.Text = "Listado de Clientes";
            // 
            // Pan_BtnsPerfil
            // 
            this.Pan_BtnsPerfil.Controls.Add(this.Btn_PerfInc);
            this.Pan_BtnsPerfil.Controls.Add(this.Btn_PerfEli);
            this.Pan_BtnsPerfil.Controls.Add(this.Btn_PerfMod);
            this.Pan_BtnsPerfil.Location = new System.Drawing.Point(829, -1);
            this.Pan_BtnsPerfil.Name = "Pan_BtnsPerfil";
            this.Pan_BtnsPerfil.Size = new System.Drawing.Size(101, 34);
            this.Pan_BtnsPerfil.TabIndex = 25;
            // 
            // Btn_PerfInc
            // 
            this.Btn_PerfInc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_PerfInc.BackgroundImage")));
            this.Btn_PerfInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PerfInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PerfInc.FlatAppearance.BorderSize = 0;
            this.Btn_PerfInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_PerfInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_PerfInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfInc.Location = new System.Drawing.Point(4, 4);
            this.Btn_PerfInc.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PerfInc.Name = "Btn_PerfInc";
            this.Btn_PerfInc.Size = new System.Drawing.Size(24, 24);
            this.Btn_PerfInc.TabIndex = 15;
            this.Btn_PerfInc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PerfInc.UseVisualStyleBackColor = true;
            this.Btn_PerfInc.Click += new System.EventHandler(this.Btn_PerfInc_Click);
            // 
            // Btn_PerfEli
            // 
            this.Btn_PerfEli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_PerfEli.BackgroundImage")));
            this.Btn_PerfEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PerfEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PerfEli.FlatAppearance.BorderSize = 0;
            this.Btn_PerfEli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_PerfEli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_PerfEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfEli.Location = new System.Drawing.Point(68, 4);
            this.Btn_PerfEli.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PerfEli.Name = "Btn_PerfEli";
            this.Btn_PerfEli.Size = new System.Drawing.Size(24, 24);
            this.Btn_PerfEli.TabIndex = 17;
            this.Btn_PerfEli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PerfEli.UseVisualStyleBackColor = true;
            this.Btn_PerfEli.Click += new System.EventHandler(this.Btn_PerfEli_Click);
            // 
            // Btn_PerfMod
            // 
            this.Btn_PerfMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_PerfMod.BackgroundImage")));
            this.Btn_PerfMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PerfMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PerfMod.FlatAppearance.BorderSize = 0;
            this.Btn_PerfMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_PerfMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_PerfMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PerfMod.Location = new System.Drawing.Point(36, 4);
            this.Btn_PerfMod.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_PerfMod.Name = "Btn_PerfMod";
            this.Btn_PerfMod.Size = new System.Drawing.Size(24, 24);
            this.Btn_PerfMod.TabIndex = 16;
            this.Btn_PerfMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PerfMod.UseVisualStyleBackColor = true;
            this.Btn_PerfMod.Click += new System.EventHandler(this.Btn_PerfMod_Click);
            // 
            // Pan_BtnsObserv
            // 
            this.Pan_BtnsObserv.Controls.Add(this.Btn_ObsInc);
            this.Pan_BtnsObserv.Controls.Add(this.Btn_ObsMod);
            this.Pan_BtnsObserv.Controls.Add(this.Btn_ObsEli);
            this.Pan_BtnsObserv.Location = new System.Drawing.Point(833, 235);
            this.Pan_BtnsObserv.Name = "Pan_BtnsObserv";
            this.Pan_BtnsObserv.Size = new System.Drawing.Size(100, 35);
            this.Pan_BtnsObserv.TabIndex = 26;
            // 
            // Btn_ObsInc
            // 
            this.Btn_ObsInc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ObsInc.BackgroundImage")));
            this.Btn_ObsInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ObsInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ObsInc.FlatAppearance.BorderSize = 0;
            this.Btn_ObsInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_ObsInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_ObsInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ObsInc.Location = new System.Drawing.Point(4, 4);
            this.Btn_ObsInc.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ObsInc.Name = "Btn_ObsInc";
            this.Btn_ObsInc.Size = new System.Drawing.Size(24, 24);
            this.Btn_ObsInc.TabIndex = 18;
            this.Btn_ObsInc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ObsInc.UseVisualStyleBackColor = true;
            this.Btn_ObsInc.Click += new System.EventHandler(this.Btn_ObsInc_Click);
            // 
            // Btn_ObsMod
            // 
            this.Btn_ObsMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ObsMod.BackgroundImage")));
            this.Btn_ObsMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ObsMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ObsMod.FlatAppearance.BorderSize = 0;
            this.Btn_ObsMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_ObsMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_ObsMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ObsMod.Location = new System.Drawing.Point(36, 4);
            this.Btn_ObsMod.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ObsMod.Name = "Btn_ObsMod";
            this.Btn_ObsMod.Size = new System.Drawing.Size(24, 24);
            this.Btn_ObsMod.TabIndex = 19;
            this.Btn_ObsMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ObsMod.UseVisualStyleBackColor = true;
            this.Btn_ObsMod.Click += new System.EventHandler(this.Btn_ObsMod_Click);
            // 
            // Btn_ObsEli
            // 
            this.Btn_ObsEli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ObsEli.BackgroundImage")));
            this.Btn_ObsEli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ObsEli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ObsEli.FlatAppearance.BorderSize = 0;
            this.Btn_ObsEli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_ObsEli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_ObsEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ObsEli.Location = new System.Drawing.Point(68, 4);
            this.Btn_ObsEli.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ObsEli.Name = "Btn_ObsEli";
            this.Btn_ObsEli.Size = new System.Drawing.Size(24, 24);
            this.Btn_ObsEli.TabIndex = 20;
            this.Btn_ObsEli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ObsEli.UseVisualStyleBackColor = true;
            this.Btn_ObsEli.Click += new System.EventHandler(this.Btn_ObsEli_Click);
            // 
            // Pag3
            // 
            this.Pag3.AutoScroll = true;
            this.Pag3.Controls.Add(this.Pan_Pag3);
            this.Pag3.Location = new System.Drawing.Point(4, 23);
            this.Pag3.Name = "Pag3";
            this.Pag3.Size = new System.Drawing.Size(973, 513);
            this.Pag3.TabIndex = 2;
            this.Pag3.Text = "Detalles de Operaciones";
            this.Pag3.UseVisualStyleBackColor = true;
            this.Pag3.Enter += new System.EventHandler(this.Pag3_Enter);
            // 
            // Pan_Pag3
            // 
            this.Pan_Pag3.Controls.Add(this.Btn_Ocultar);
            this.Pan_Pag3.Controls.Add(this.Grd_Reporte);
            this.Pan_Pag3.Controls.Add(this.Chk_ElimOper);
            this.Pan_Pag3.Controls.Add(this.Grd_DetOperaciones);
            this.Pan_Pag3.Controls.Add(this.Grd_ClieDetOper);
            this.Pan_Pag3.Controls.Add(this.Chk_Reporte);
            this.Pan_Pag3.Controls.Add(this.Pan_Reporte);
            this.Pan_Pag3.Controls.Add(this.Btn_MostrarTodos);
            this.Pan_Pag3.Controls.Add(this.Btn_Importar);
            this.Pan_Pag3.Controls.Add(this.Lbl_DetOperaciones);
            this.Pan_Pag3.Controls.Add(this.Lbl_ListClientes3);
            this.Pan_Pag3.Location = new System.Drawing.Point(7, 10);
            this.Pan_Pag3.Name = "Pan_Pag3";
            this.Pan_Pag3.Size = new System.Drawing.Size(963, 489);
            this.Pan_Pag3.TabIndex = 35;
            // 
            // Btn_Ocultar
            // 
            this.Btn_Ocultar.Location = new System.Drawing.Point(557, 460);
            this.Btn_Ocultar.Name = "Btn_Ocultar";
            this.Btn_Ocultar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ocultar.TabIndex = 37;
            this.Btn_Ocultar.Text = "Ocultar";
            this.Btn_Ocultar.UseVisualStyleBackColor = true;
            this.Btn_Ocultar.Visible = false;
            this.Btn_Ocultar.Click += new System.EventHandler(this.Btn_Ocultar_Click);
            // 
            // Grd_Reporte
            // 
            this.Grd_Reporte.AllowUserToAddRows = false;
            this.Grd_Reporte.AllowUserToDeleteRows = false;
            this.Grd_Reporte.AllowUserToOrderColumns = true;
            this.Grd_Reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grd_Reporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grd_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Reporte.Location = new System.Drawing.Point(195, 3);
            this.Grd_Reporte.Name = "Grd_Reporte";
            this.Grd_Reporte.Size = new System.Drawing.Size(595, 442);
            this.Grd_Reporte.TabIndex = 36;
            this.Grd_Reporte.Visible = false;
            // 
            // Chk_ElimOper
            // 
            this.Chk_ElimOper.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_ElimOper.AutoEllipsis = true;
            this.Chk_ElimOper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chk_ElimOper.BackgroundImage")));
            this.Chk_ElimOper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chk_ElimOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chk_ElimOper.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Chk_ElimOper.FlatAppearance.BorderSize = 3;
            this.Chk_ElimOper.Location = new System.Drawing.Point(357, 434);
            this.Chk_ElimOper.Name = "Chk_ElimOper";
            this.Chk_ElimOper.Size = new System.Drawing.Size(48, 48);
            this.Chk_ElimOper.TabIndex = 35;
            this.Chk_ElimOper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Chk_ElimOper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Chk_ElimOper.UseVisualStyleBackColor = true;
            this.Chk_ElimOper.CheckedChanged += new System.EventHandler(this.Chk_ElimOper_CheckedChanged);
            // 
            // Grd_DetOperaciones
            // 
            this.Grd_DetOperaciones.AllowUserToAddRows = false;
            this.Grd_DetOperaciones.AllowUserToDeleteRows = false;
            this.Grd_DetOperaciones.AllowUserToOrderColumns = true;
            this.Grd_DetOperaciones.AutoGenerateColumns = false;
            this.Grd_DetOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grd_DetOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_DetOperaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn106,
            this.dataGridViewTextBoxColumn107,
            this.dataGridViewTextBoxColumn108,
            this.dataGridViewTextBoxColumn109,
            this.dataGridViewTextBoxColumn110,
            this.dataGridViewTextBoxColumn111,
            this.dataGridViewTextBoxColumn112,
            this.dataGridViewTextBoxColumn113,
            this.dataGridViewTextBoxColumn114,
            this.dataGridViewTextBoxColumn115,
            this.dataGridViewTextBoxColumn116,
            this.dataGridViewTextBoxColumn117,
            this.dataGridViewTextBoxColumn118,
            this.dataGridViewTextBoxColumn119,
            this.dataGridViewTextBoxColumn120,
            this.dataGridViewTextBoxColumn121,
            this.dataGridViewTextBoxColumn122,
            this.dataGridViewTextBoxColumn123,
            this.dataGridViewTextBoxColumn215,
            this.dataGridViewTextBoxColumn216,
            this.dataGridViewTextBoxColumn217,
            this.dataGridViewTextBoxColumn218,
            this.dataGridViewTextBoxColumn219});
            this.Grd_DetOperaciones.DataSource = this.BS_OOperFinancieras;
            this.Grd_DetOperaciones.Location = new System.Drawing.Point(376, 21);
            this.Grd_DetOperaciones.Name = "Grd_DetOperaciones";
            this.Grd_DetOperaciones.ReadOnly = true;
            this.Grd_DetOperaciones.RowHeadersVisible = false;
            this.Grd_DetOperaciones.Size = new System.Drawing.Size(577, 405);
            this.Grd_DetOperaciones.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn106
            // 
            this.dataGridViewTextBoxColumn106.DataPropertyName = "ID_Sistema";
            this.dataGridViewTextBoxColumn106.HeaderText = "ID_Sistema";
            this.dataGridViewTextBoxColumn106.Name = "dataGridViewTextBoxColumn106";
            this.dataGridViewTextBoxColumn106.ReadOnly = true;
            this.dataGridViewTextBoxColumn106.Width = 102;
            // 
            // dataGridViewTextBoxColumn107
            // 
            this.dataGridViewTextBoxColumn107.DataPropertyName = "Tipo_Orden";
            this.dataGridViewTextBoxColumn107.HeaderText = "Tipo_Orden";
            this.dataGridViewTextBoxColumn107.Name = "dataGridViewTextBoxColumn107";
            this.dataGridViewTextBoxColumn107.ReadOnly = true;
            this.dataGridViewTextBoxColumn107.Width = 102;
            // 
            // dataGridViewTextBoxColumn108
            // 
            this.dataGridViewTextBoxColumn108.DataPropertyName = "Fec_Pacto";
            this.dataGridViewTextBoxColumn108.HeaderText = "Fec_Pacto";
            this.dataGridViewTextBoxColumn108.Name = "dataGridViewTextBoxColumn108";
            this.dataGridViewTextBoxColumn108.ReadOnly = true;
            this.dataGridViewTextBoxColumn108.Width = 95;
            // 
            // dataGridViewTextBoxColumn109
            // 
            this.dataGridViewTextBoxColumn109.DataPropertyName = "Doc_ID";
            this.dataGridViewTextBoxColumn109.HeaderText = "Doc_ID";
            this.dataGridViewTextBoxColumn109.Name = "dataGridViewTextBoxColumn109";
            this.dataGridViewTextBoxColumn109.ReadOnly = true;
            this.dataGridViewTextBoxColumn109.Width = 74;
            // 
            // dataGridViewTextBoxColumn110
            // 
            this.dataGridViewTextBoxColumn110.DataPropertyName = "Cod_Cliente";
            this.dataGridViewTextBoxColumn110.HeaderText = "Cod_Cliente";
            this.dataGridViewTextBoxColumn110.Name = "dataGridViewTextBoxColumn110";
            this.dataGridViewTextBoxColumn110.ReadOnly = true;
            this.dataGridViewTextBoxColumn110.Width = 109;
            // 
            // dataGridViewTextBoxColumn111
            // 
            this.dataGridViewTextBoxColumn111.DataPropertyName = "Nme_Cliente";
            this.dataGridViewTextBoxColumn111.HeaderText = "Nme_Cliente";
            this.dataGridViewTextBoxColumn111.Name = "dataGridViewTextBoxColumn111";
            this.dataGridViewTextBoxColumn111.ReadOnly = true;
            this.dataGridViewTextBoxColumn111.Width = 109;
            // 
            // dataGridViewTextBoxColumn112
            // 
            this.dataGridViewTextBoxColumn112.DataPropertyName = "Fec_Cierre";
            this.dataGridViewTextBoxColumn112.HeaderText = "Fec_Cierre";
            this.dataGridViewTextBoxColumn112.Name = "dataGridViewTextBoxColumn112";
            this.dataGridViewTextBoxColumn112.ReadOnly = true;
            this.dataGridViewTextBoxColumn112.Width = 102;
            // 
            // dataGridViewTextBoxColumn113
            // 
            this.dataGridViewTextBoxColumn113.DataPropertyName = "Fec_Valor";
            this.dataGridViewTextBoxColumn113.HeaderText = "Fec_Valor";
            this.dataGridViewTextBoxColumn113.Name = "dataGridViewTextBoxColumn113";
            this.dataGridViewTextBoxColumn113.ReadOnly = true;
            this.dataGridViewTextBoxColumn113.Width = 95;
            // 
            // dataGridViewTextBoxColumn114
            // 
            this.dataGridViewTextBoxColumn114.DataPropertyName = "Mto_Solicitado";
            this.dataGridViewTextBoxColumn114.HeaderText = "Mto_Solicitado";
            this.dataGridViewTextBoxColumn114.Name = "dataGridViewTextBoxColumn114";
            this.dataGridViewTextBoxColumn114.ReadOnly = true;
            this.dataGridViewTextBoxColumn114.Width = 130;
            // 
            // dataGridViewTextBoxColumn115
            // 
            this.dataGridViewTextBoxColumn115.DataPropertyName = "Mto_Pactado";
            this.dataGridViewTextBoxColumn115.HeaderText = "Mto_Pactado";
            this.dataGridViewTextBoxColumn115.Name = "dataGridViewTextBoxColumn115";
            this.dataGridViewTextBoxColumn115.ReadOnly = true;
            this.dataGridViewTextBoxColumn115.Width = 109;
            // 
            // dataGridViewTextBoxColumn116
            // 
            this.dataGridViewTextBoxColumn116.DataPropertyName = "Cod_Titulo";
            this.dataGridViewTextBoxColumn116.HeaderText = "Cod_Titulo";
            this.dataGridViewTextBoxColumn116.Name = "dataGridViewTextBoxColumn116";
            this.dataGridViewTextBoxColumn116.ReadOnly = true;
            this.dataGridViewTextBoxColumn116.Width = 102;
            // 
            // dataGridViewTextBoxColumn117
            // 
            this.dataGridViewTextBoxColumn117.DataPropertyName = "Precio_USD";
            this.dataGridViewTextBoxColumn117.HeaderText = "Precio_USD";
            this.dataGridViewTextBoxColumn117.Name = "dataGridViewTextBoxColumn117";
            this.dataGridViewTextBoxColumn117.ReadOnly = true;
            this.dataGridViewTextBoxColumn117.Width = 102;
            // 
            // dataGridViewTextBoxColumn118
            // 
            this.dataGridViewTextBoxColumn118.DataPropertyName = "Efectivo";
            this.dataGridViewTextBoxColumn118.HeaderText = "Efectivo";
            this.dataGridViewTextBoxColumn118.Name = "dataGridViewTextBoxColumn118";
            this.dataGridViewTextBoxColumn118.ReadOnly = true;
            this.dataGridViewTextBoxColumn118.Width = 88;
            // 
            // dataGridViewTextBoxColumn119
            // 
            this.dataGridViewTextBoxColumn119.DataPropertyName = "Comision_Clie";
            this.dataGridViewTextBoxColumn119.HeaderText = "Comision_Clie";
            this.dataGridViewTextBoxColumn119.Name = "dataGridViewTextBoxColumn119";
            this.dataGridViewTextBoxColumn119.ReadOnly = true;
            this.dataGridViewTextBoxColumn119.Width = 123;
            // 
            // dataGridViewTextBoxColumn120
            // 
            this.dataGridViewTextBoxColumn120.DataPropertyName = "Cod_Contraparte";
            this.dataGridViewTextBoxColumn120.HeaderText = "Cod_Contraparte";
            this.dataGridViewTextBoxColumn120.Name = "dataGridViewTextBoxColumn120";
            this.dataGridViewTextBoxColumn120.ReadOnly = true;
            this.dataGridViewTextBoxColumn120.Width = 137;
            // 
            // dataGridViewTextBoxColumn121
            // 
            this.dataGridViewTextBoxColumn121.DataPropertyName = "Nme_Contraparte";
            this.dataGridViewTextBoxColumn121.HeaderText = "Nme_Contraparte";
            this.dataGridViewTextBoxColumn121.Name = "dataGridViewTextBoxColumn121";
            this.dataGridViewTextBoxColumn121.ReadOnly = true;
            this.dataGridViewTextBoxColumn121.Width = 137;
            // 
            // dataGridViewTextBoxColumn122
            // 
            this.dataGridViewTextBoxColumn122.DataPropertyName = "Agencia";
            this.dataGridViewTextBoxColumn122.HeaderText = "Agencia";
            this.dataGridViewTextBoxColumn122.Name = "dataGridViewTextBoxColumn122";
            this.dataGridViewTextBoxColumn122.ReadOnly = true;
            this.dataGridViewTextBoxColumn122.Width = 81;
            // 
            // dataGridViewTextBoxColumn123
            // 
            this.dataGridViewTextBoxColumn123.DataPropertyName = "Sec_Operac";
            this.dataGridViewTextBoxColumn123.HeaderText = "Sec_Operac";
            this.dataGridViewTextBoxColumn123.Name = "dataGridViewTextBoxColumn123";
            this.dataGridViewTextBoxColumn123.ReadOnly = true;
            this.dataGridViewTextBoxColumn123.Width = 102;
            // 
            // dataGridViewTextBoxColumn215
            // 
            this.dataGridViewTextBoxColumn215.DataPropertyName = "Cod_Bloq";
            this.dataGridViewTextBoxColumn215.HeaderText = "Cod_Bloq";
            this.dataGridViewTextBoxColumn215.Name = "dataGridViewTextBoxColumn215";
            this.dataGridViewTextBoxColumn215.ReadOnly = true;
            this.dataGridViewTextBoxColumn215.Width = 88;
            // 
            // dataGridViewTextBoxColumn216
            // 
            this.dataGridViewTextBoxColumn216.DataPropertyName = "Nro_OrdBCV";
            this.dataGridViewTextBoxColumn216.HeaderText = "Nro_OrdBCV";
            this.dataGridViewTextBoxColumn216.Name = "dataGridViewTextBoxColumn216";
            this.dataGridViewTextBoxColumn216.ReadOnly = true;
            this.dataGridViewTextBoxColumn216.Width = 102;
            // 
            // dataGridViewTextBoxColumn217
            // 
            this.dataGridViewTextBoxColumn217.DataPropertyName = "Cta_USD";
            this.dataGridViewTextBoxColumn217.HeaderText = "Cta_USD";
            this.dataGridViewTextBoxColumn217.Name = "dataGridViewTextBoxColumn217";
            this.dataGridViewTextBoxColumn217.ReadOnly = true;
            this.dataGridViewTextBoxColumn217.Width = 81;
            // 
            // dataGridViewTextBoxColumn218
            // 
            this.dataGridViewTextBoxColumn218.DataPropertyName = "Comprobante";
            this.dataGridViewTextBoxColumn218.HeaderText = "Comprobante";
            this.dataGridViewTextBoxColumn218.Name = "dataGridViewTextBoxColumn218";
            this.dataGridViewTextBoxColumn218.ReadOnly = true;
            this.dataGridViewTextBoxColumn218.Width = 109;
            // 
            // dataGridViewTextBoxColumn219
            // 
            this.dataGridViewTextBoxColumn219.DataPropertyName = "Hora_carga";
            this.dataGridViewTextBoxColumn219.HeaderText = "Hora_carga";
            this.dataGridViewTextBoxColumn219.Name = "dataGridViewTextBoxColumn219";
            this.dataGridViewTextBoxColumn219.ReadOnly = true;
            this.dataGridViewTextBoxColumn219.Width = 102;
            // 
            // BS_OOperFinancieras
            // 
            this.BS_OOperFinancieras.DataSource = typeof(MofinModelo.O_Operfinancieras);
            // 
            // Grd_ClieDetOper
            // 
            this.Grd_ClieDetOper.AllowUserToAddRows = false;
            this.Grd_ClieDetOper.AllowUserToDeleteRows = false;
            this.Grd_ClieDetOper.AutoGenerateColumns = false;
            this.Grd_ClieDetOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ClieDetOper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CliCod3,
            this.Col_CliDocID3,
            this.Col_CliNme3,
            this.dataGridViewTextBoxColumn2});
            this.Grd_ClieDetOper.DataSource = this.BS_CClientes;
            this.Grd_ClieDetOper.Location = new System.Drawing.Point(11, 21);
            this.Grd_ClieDetOper.Name = "Grd_ClieDetOper";
            this.Grd_ClieDetOper.ReadOnly = true;
            this.Grd_ClieDetOper.RowHeadersVisible = false;
            this.Grd_ClieDetOper.Size = new System.Drawing.Size(350, 405);
            this.Grd_ClieDetOper.TabIndex = 34;
            this.Grd_ClieDetOper.CurrentCellChanged += new System.EventHandler(this.Grd_ClieDetOper_CurrentCellChanged);
            // 
            // Col_CliCod3
            // 
            this.Col_CliCod3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_CliCod3.DataPropertyName = "Codigo";
            this.Col_CliCod3.HeaderText = "Codigo";
            this.Col_CliCod3.Name = "Col_CliCod3";
            this.Col_CliCod3.ReadOnly = true;
            this.Col_CliCod3.Width = 74;
            // 
            // Col_CliDocID3
            // 
            this.Col_CliDocID3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_CliDocID3.DataPropertyName = "Doc_ID";
            this.Col_CliDocID3.HeaderText = "Doc_ID";
            this.Col_CliDocID3.Name = "Col_CliDocID3";
            this.Col_CliDocID3.ReadOnly = true;
            this.Col_CliDocID3.Width = 74;
            // 
            // Col_CliNme3
            // 
            this.Col_CliNme3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_CliNme3.DataPropertyName = "Nombre";
            this.Col_CliNme3.HeaderText = "Nombre";
            this.Col_CliNme3.Name = "Col_CliNme3";
            this.Col_CliNme3.ReadOnly = true;
            this.Col_CliNme3.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PeriodUsoCta";
            this.dataGridViewTextBoxColumn2.HeaderText = "PeriodUsoCta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Chk_Reporte
            // 
            this.Chk_Reporte.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chk_Reporte.AutoEllipsis = true;
            this.Chk_Reporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chk_Reporte.BackgroundImage")));
            this.Chk_Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chk_Reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chk_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Chk_Reporte.FlatAppearance.BorderSize = 3;
            this.Chk_Reporte.Location = new System.Drawing.Point(19, 434);
            this.Chk_Reporte.Name = "Chk_Reporte";
            this.Chk_Reporte.Size = new System.Drawing.Size(48, 48);
            this.Chk_Reporte.TabIndex = 32;
            this.Chk_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Chk_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Chk_Reporte.UseVisualStyleBackColor = true;
            this.Chk_Reporte.CheckedChanged += new System.EventHandler(this.Chk_Reporte_CheckedChanged);
            // 
            // Pan_Reporte
            // 
            this.Pan_Reporte.Controls.Add(this.Btn_ProcReporte);
            this.Pan_Reporte.Controls.Add(this.Lbl_Hasta2);
            this.Pan_Reporte.Controls.Add(this.Lbl_Desde2);
            this.Pan_Reporte.Controls.Add(this.Dtp_RepHasta);
            this.Pan_Reporte.Controls.Add(this.Dtp_RepDesde);
            this.Pan_Reporte.Location = new System.Drawing.Point(76, 431);
            this.Pan_Reporte.Name = "Pan_Reporte";
            this.Pan_Reporte.Size = new System.Drawing.Size(243, 53);
            this.Pan_Reporte.TabIndex = 31;
            this.Pan_Reporte.Visible = false;
            // 
            // Btn_ProcReporte
            // 
            this.Btn_ProcReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ProcReporte.BackgroundImage")));
            this.Btn_ProcReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ProcReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ProcReporte.FlatAppearance.BorderSize = 0;
            this.Btn_ProcReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_ProcReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_ProcReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ProcReporte.Location = new System.Drawing.Point(193, 7);
            this.Btn_ProcReporte.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ProcReporte.Name = "Btn_ProcReporte";
            this.Btn_ProcReporte.Size = new System.Drawing.Size(38, 38);
            this.Btn_ProcReporte.TabIndex = 31;
            this.Btn_ProcReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ProcReporte.UseVisualStyleBackColor = true;
            this.Btn_ProcReporte.Click += new System.EventHandler(this.Btn_ProcReporte_Click);
            // 
            // Lbl_Hasta2
            // 
            this.Lbl_Hasta2.AutoSize = true;
            this.Lbl_Hasta2.Location = new System.Drawing.Point(3, 35);
            this.Lbl_Hasta2.Name = "Lbl_Hasta2";
            this.Lbl_Hasta2.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Hasta2.TabIndex = 21;
            this.Lbl_Hasta2.Text = "Hasta";
            // 
            // Lbl_Desde2
            // 
            this.Lbl_Desde2.AutoSize = true;
            this.Lbl_Desde2.Location = new System.Drawing.Point(3, 9);
            this.Lbl_Desde2.Name = "Lbl_Desde2";
            this.Lbl_Desde2.Size = new System.Drawing.Size(42, 14);
            this.Lbl_Desde2.TabIndex = 20;
            this.Lbl_Desde2.Text = "Desde";
            // 
            // Dtp_RepHasta
            // 
            this.Dtp_RepHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_RepHasta.Location = new System.Drawing.Point(58, 30);
            this.Dtp_RepHasta.Name = "Dtp_RepHasta";
            this.Dtp_RepHasta.Size = new System.Drawing.Size(115, 20);
            this.Dtp_RepHasta.TabIndex = 19;
            // 
            // Dtp_RepDesde
            // 
            this.Dtp_RepDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_RepDesde.Location = new System.Drawing.Point(58, 4);
            this.Dtp_RepDesde.Name = "Dtp_RepDesde";
            this.Dtp_RepDesde.Size = new System.Drawing.Size(115, 20);
            this.Dtp_RepDesde.TabIndex = 18;
            // 
            // Btn_MostrarTodos
            // 
            this.Btn_MostrarTodos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarTodos.BackgroundImage")));
            this.Btn_MostrarTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_MostrarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MostrarTodos.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarTodos.Location = new System.Drawing.Point(797, 439);
            this.Btn_MostrarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_MostrarTodos.Name = "Btn_MostrarTodos";
            this.Btn_MostrarTodos.Size = new System.Drawing.Size(38, 38);
            this.Btn_MostrarTodos.TabIndex = 28;
            this.Btn_MostrarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.Btn_MostrarTodos.Click += new System.EventHandler(this.Btn_MostrarTodos_Click);
            // 
            // Btn_Importar
            // 
            this.Btn_Importar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Importar.BackgroundImage")));
            this.Btn_Importar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Importar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Importar.FlatAppearance.BorderSize = 0;
            this.Btn_Importar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Importar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Importar.Location = new System.Drawing.Point(867, 439);
            this.Btn_Importar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Importar.Name = "Btn_Importar";
            this.Btn_Importar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Importar.TabIndex = 27;
            this.Btn_Importar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Importar.UseVisualStyleBackColor = true;
            this.Btn_Importar.Click += new System.EventHandler(this.Btn_Importar_Click);
            // 
            // Lbl_DetOperaciones
            // 
            this.Lbl_DetOperaciones.AutoSize = true;
            this.Lbl_DetOperaciones.Location = new System.Drawing.Point(366, 4);
            this.Lbl_DetOperaciones.Name = "Lbl_DetOperaciones";
            this.Lbl_DetOperaciones.Size = new System.Drawing.Size(168, 14);
            this.Lbl_DetOperaciones.TabIndex = 26;
            this.Lbl_DetOperaciones.Text = "Detalles de Operaciones";
            // 
            // Lbl_ListClientes3
            // 
            this.Lbl_ListClientes3.AutoSize = true;
            this.Lbl_ListClientes3.Location = new System.Drawing.Point(16, 4);
            this.Lbl_ListClientes3.Name = "Lbl_ListClientes3";
            this.Lbl_ListClientes3.Size = new System.Drawing.Size(140, 14);
            this.Lbl_ListClientes3.TabIndex = 25;
            this.Lbl_ListClientes3.Text = "Listado de Clientes";
            // 
            // Cmb_TipArchExport
            // 
            this.Cmb_TipArchExport.FormattingEnabled = true;
            this.Cmb_TipArchExport.Items.AddRange(new object[] {
            "Archivo de Texto, delimitados por \";\" (.TXT) | *.TXT;",
            "Archivo Plano, delimitados por \";\"  (.CSV) | *.CSV;",
            "Archivo de Excel (.XLS) | *.XLS;"});
            this.Cmb_TipArchExport.Location = new System.Drawing.Point(345, 641);
            this.Cmb_TipArchExport.Name = "Cmb_TipArchExport";
            this.Cmb_TipArchExport.Size = new System.Drawing.Size(424, 22);
            this.Cmb_TipArchExport.TabIndex = 1;
            // 
            // Txt_NmeArchExport
            // 
            this.Txt_NmeArchExport.Location = new System.Drawing.Point(343, 615);
            this.Txt_NmeArchExport.Name = "Txt_NmeArchExport";
            this.Txt_NmeArchExport.Size = new System.Drawing.Size(426, 20);
            this.Txt_NmeArchExport.TabIndex = 2;
            this.Txt_NmeArchExport.DoubleClick += new System.EventHandler(this.Txt_NmeArchExport_DoubleClick);
            // 
            // Lbl_ArcExpNme
            // 
            this.Lbl_ArcExpNme.AutoSize = true;
            this.Lbl_ArcExpNme.Location = new System.Drawing.Point(288, 621);
            this.Lbl_ArcExpNme.Name = "Lbl_ArcExpNme";
            this.Lbl_ArcExpNme.Size = new System.Drawing.Size(49, 14);
            this.Lbl_ArcExpNme.TabIndex = 14;
            this.Lbl_ArcExpNme.Text = "Nombre";
            this.Lbl_ArcExpNme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_ArcExpTip
            // 
            this.Lbl_ArcExpTip.AutoSize = true;
            this.Lbl_ArcExpTip.Location = new System.Drawing.Point(213, 644);
            this.Lbl_ArcExpTip.Name = "Lbl_ArcExpTip";
            this.Lbl_ArcExpTip.Size = new System.Drawing.Size(126, 14);
            this.Lbl_ArcExpTip.TabIndex = 15;
            this.Lbl_ArcExpTip.Text = "Con Formato para:";
            this.Lbl_ArcExpTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Exportar
            // 
            this.Btn_Exportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Exportar.BackgroundImage")));
            this.Btn_Exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exportar.FlatAppearance.BorderSize = 0;
            this.Btn_Exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exportar.Location = new System.Drawing.Point(797, 618);
            this.Btn_Exportar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Exportar.Name = "Btn_Exportar";
            this.Btn_Exportar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Exportar.TabIndex = 14;
            this.Btn_Exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Exportar.UseVisualStyleBackColor = true;
            // 
            // DS_MonitorOperaciones
            // 
            this.DS_MonitorOperaciones.DataSetName = "MonitorOperacionesDataSet";
            this.DS_MonitorOperaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 74;
            // 
            // Doc_ID
            // 
            this.Doc_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Doc_ID.DataPropertyName = "Doc_ID";
            this.Doc_ID.HeaderText = "Doc_ID";
            this.Doc_ID.Name = "Doc_ID";
            this.Doc_ID.ReadOnly = true;
            this.Doc_ID.Width = 74;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 74;
            // 
            // PeriodUsoCta
            // 
            this.PeriodUsoCta.DataPropertyName = "PeriodUsoCta";
            this.PeriodUsoCta.HeaderText = "PeriodUsoCta";
            this.PeriodUsoCta.Name = "PeriodUsoCta";
            this.PeriodUsoCta.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            // 
            // Ejecutivo
            // 
            this.Ejecutivo.DataPropertyName = "Ejecutivo";
            this.Ejecutivo.HeaderText = "Ejecutivo";
            this.Ejecutivo.Name = "Ejecutivo";
            this.Ejecutivo.ReadOnly = true;
            this.Ejecutivo.Visible = false;
            // 
            // NivelRiesgo
            // 
            this.NivelRiesgo.DataPropertyName = "NivelRiesgo";
            this.NivelRiesgo.HeaderText = "NivelRiesgo";
            this.NivelRiesgo.Name = "NivelRiesgo";
            this.NivelRiesgo.ReadOnly = true;
            this.NivelRiesgo.Visible = false;
            // 
            // PerfilFinanciero
            // 
            this.PerfilFinanciero.DataPropertyName = "PerfilFinanciero";
            this.PerfilFinanciero.HeaderText = "PerfilFinanciero";
            this.PerfilFinanciero.Name = "PerfilFinanciero";
            this.PerfilFinanciero.ReadOnly = true;
            this.PerfilFinanciero.Visible = false;
            // 
            // NroTransacciones
            // 
            this.NroTransacciones.DataPropertyName = "NroTransacciones";
            this.NroTransacciones.HeaderText = "NroTransacciones";
            this.NroTransacciones.Name = "NroTransacciones";
            this.NroTransacciones.ReadOnly = true;
            this.NroTransacciones.Visible = false;
            // 
            // Frm_OpeFinancieras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.Btn_Exportar);
            this.Controls.Add(this.Lbl_ArcExpTip);
            this.Controls.Add(this.Lbl_ArcExpNme);
            this.Controls.Add(this.Txt_NmeArchExport);
            this.Controls.Add(this.Cmb_TipArchExport);
            this.Controls.Add(this.Tab_MonOperaciones);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_OpeFinancieras";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Resizable = false;
            this.Text = "Monitor de Operaciones Financieras";
            this.Load += new System.EventHandler(this.Frm_OpeFinancieras_Load);
            this.Tab_MonOperaciones.ResumeLayout(false);
            this.Pag1.ResumeLayout(false);
            this.Pan_Pag1.ResumeLayout(false);
            this.Pan_Pag1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_MonitorFinanciero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RepOperacional)).EndInit();
            this.Pag2.ResumeLayout(false);
            this.Pag2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Observaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_HistPerfOperac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OHistPerfOperac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ClieInfInversor)).EndInit();
            this.Pan_BtnsPerfil.ResumeLayout(false);
            this.Pan_BtnsObserv.ResumeLayout(false);
            this.Pag3.ResumeLayout(false);
            this.Pan_Pag3.ResumeLayout(false);
            this.Pan_Pag3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_DetOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OOperFinancieras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ClieDetOper)).EndInit();
            this.Pan_Reporte.ResumeLayout(false);
            this.Pan_Reporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MonitorOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_MonOperaciones;
        private System.Windows.Forms.TabPage Pag1;
        private System.Windows.Forms.CheckBox Chk_IncSoloExcep;
        private System.Windows.Forms.CheckBox Chk_ExcMeses;
        private System.Windows.Forms.Label Lbl_ListClientes1;
        private System.Windows.Forms.Label Lbl_ListOperAfec;
        private System.Windows.Forms.TabPage Pag2;
        private System.Windows.Forms.TabPage Pag3;
        private System.Windows.Forms.CheckBox Chk_Exportar;
        private System.Windows.Forms.Button Btn_Procesar;
        private System.Windows.Forms.ComboBox Cmb_TipArchExport;
        private System.Windows.Forms.TextBox Txt_NmeArchExport;
        private System.Windows.Forms.Label Lbl_ArcExpNme;
        private System.Windows.Forms.Label Lbl_ArcExpTip;
        private System.Windows.Forms.Button Btn_Exportar;
        private System.Windows.Forms.Label Lbl_Hasta1;
        private System.Windows.Forms.Label Lbl_Desde1;
        private System.Windows.Forms.DateTimePicker Dtp_Hasta;
        private System.Windows.Forms.DateTimePicker dtp_Desde;
        private System.Windows.Forms.Label Lbl_ListClientes2;
        private System.Windows.Forms.Button Btn_ObsEli;
        private System.Windows.Forms.Button Btn_ObsMod;
        private System.Windows.Forms.Button Btn_ObsInc;
        private System.Windows.Forms.Button Btn_PerfEli;
        private System.Windows.Forms.Button Btn_PerfMod;
        private System.Windows.Forms.Button Btn_PerfInc;
        private System.Windows.Forms.Label Lbl_Obsvaciones;
        private System.Windows.Forms.Label Lbl_Perfil;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label Lbl_DetOperaciones;
        private System.Windows.Forms.Label Lbl_ListClientes3;
        private System.Windows.Forms.Panel Pan_Reporte;
        private System.Windows.Forms.Button Btn_ProcReporte;
        private System.Windows.Forms.Label Lbl_Hasta2;
        private System.Windows.Forms.Label Lbl_Desde2;
        private System.Windows.Forms.DateTimePicker Dtp_RepHasta;
        private System.Windows.Forms.DateTimePicker Dtp_RepDesde;
        private System.Windows.Forms.Button Btn_MostrarTodos;
        private System.Windows.Forms.Button Btn_Importar;
        private System.Windows.Forms.CheckBox Chk_Reporte;
        private System.Windows.Forms.DataGridView Grd_Clientes;
        private System.Windows.Forms.BindingSource BS_CClientes;
        private MonitorOperacionesDataSet DS_MonitorOperaciones;
        private System.Windows.Forms.DataGridView Grd_ClieInfInversor;
        private System.Windows.Forms.DataGridView Grd_MonitorFinanciero;
        private System.Windows.Forms.DataGridView Grd_ClieDetOper;
        private System.Windows.Forms.DataGridView Grd_Observaciones;
        private System.Windows.Forms.BindingSource BS_OObservaciones;
        private System.Windows.Forms.DataGridView Grd_HistPerfOperac;
        private System.Windows.Forms.BindingSource BS_OHistPerfOperac;
        private System.Windows.Forms.Panel Pan_BtnsPerfil;
        private System.Windows.Forms.Panel Pan_BtnsObserv;
        private System.Windows.Forms.Panel Pan_Pag1;
        private System.Windows.Forms.Panel Pan_Pag3;
        private System.Windows.Forms.DataGridView Grd_DetOperaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn215;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn216;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn217;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn218;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn219;
        private System.Windows.Forms.BindingSource BS_OOperFinancieras;
        private System.Windows.Forms.CheckBox Chk_ElimOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ObsFec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ObsObserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CliCod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CliDocID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CliNme2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CliCod3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CliDocID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CliNme3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Btn_Ocultar;
        private System.Windows.Forms.DataGridView Grd_Reporte;
        private System.Windows.Forms.BindingSource BS_RepOperacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PerFec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PerMto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PerNroTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PerRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecGeneracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecUltOperacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivRiesgoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodUsoCtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTransacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfNroTransacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcTransacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtoComprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtoVentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totOperacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfFinancieroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcOperacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodUsoCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfilFinanciero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTransacciones;
    }
}