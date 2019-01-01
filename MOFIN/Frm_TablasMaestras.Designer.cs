using MetroFramework.Forms;

namespace MOFIN
{
    partial class Frm_TablasMaestras : MetroForm
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
            System.Windows.Forms.Label Lbl_CodAlfa2;
            System.Windows.Forms.Label Lbl_CodAlfa3;
            System.Windows.Forms.Label Lbl_Nombre;
            System.Windows.Forms.Label Lbl_Valor;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TablasMaestras));
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.TS_BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.TSB_Primero = new System.Windows.Forms.ToolStripButton();
            this.TSB_Anterior = new System.Windows.Forms.ToolStripButton();
            this.TSB_Siguiente = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ultimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Agregar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Modificar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Salir = new System.Windows.Forms.ToolStripButton();
            this.Grd_Detalles = new System.Windows.Forms.DataGridView();
            this.BS_MPais = new System.Windows.Forms.BindingSource(this.components);
            this.DS_MonitorOperaciones = new MOFIN.MonitorOperacionesDataSet();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_CodAlfa2 = new System.Windows.Forms.TextBox();
            this.Txt_CodAlfa3 = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Chk_CES = new System.Windows.Forms.CheckBox();
            this.NUD_Valor = new System.Windows.Forms.NumericUpDown();
            this.Cmb_TablaMaestra = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new MOFIN.MonitorOperacionesDataSetTableAdapters.TableAdapterManager();
            this.BS_MEstados = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MEstados = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_EstadosTableAdapter();
            this.TA_MPais = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_PaisTableAdapter();
            this.BS_MAntiguedad = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MAntiguedad = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_AntiguedadTableAdapter();
            this.BS_MActivComercial = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MActivComercial = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_ActivComercialTableAdapter();
            this.BS_MCriptomonedas = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MCriptomonedas = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_CriptomonedasTableAdapter();
            this.BS_MEdad = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MEdad = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_EdadTableAdapter();
            this.BS_MNivelRiesgo = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MNivelRiesgo = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_NivelRiesgoTableAdapter();
            this.BS_MProfesiones = new System.Windows.Forms.BindingSource(this.components);
            this.TA_MProfesiones = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_ProfesionesTableAdapter();
            Lbl_Codigo = new System.Windows.Forms.Label();
            Lbl_CodAlfa2 = new System.Windows.Forms.Label();
            Lbl_CodAlfa3 = new System.Windows.Forms.Label();
            Lbl_Nombre = new System.Windows.Forms.Label();
            Lbl_Valor = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.TS_BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MonitorOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAntiguedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MActivComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MCriptomonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MNivelRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProfesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new System.Drawing.Point(16, 182);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new System.Drawing.Size(64, 16);
            Lbl_Codigo.TabIndex = 38;
            Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_CodAlfa2
            // 
            Lbl_CodAlfa2.AutoSize = true;
            Lbl_CodAlfa2.Location = new System.Drawing.Point(171, 161);
            Lbl_CodAlfa2.Name = "Lbl_CodAlfa2";
            Lbl_CodAlfa2.Size = new System.Drawing.Size(80, 16);
            Lbl_CodAlfa2.TabIndex = 40;
            Lbl_CodAlfa2.Text = "AlfaNum 2";
            // 
            // Lbl_CodAlfa3
            // 
            Lbl_CodAlfa3.AutoSize = true;
            Lbl_CodAlfa3.Location = new System.Drawing.Point(294, 161);
            Lbl_CodAlfa3.Name = "Lbl_CodAlfa3";
            Lbl_CodAlfa3.Size = new System.Drawing.Size(72, 16);
            Lbl_CodAlfa3.TabIndex = 42;
            Lbl_CodAlfa3.Text = "AlfaNum3";
            // 
            // Lbl_Nombre
            // 
            Lbl_Nombre.AutoSize = true;
            Lbl_Nombre.Location = new System.Drawing.Point(16, 211);
            Lbl_Nombre.Name = "Lbl_Nombre";
            Lbl_Nombre.Size = new System.Drawing.Size(64, 16);
            Lbl_Nombre.TabIndex = 44;
            Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Valor
            // 
            Lbl_Valor.AutoSize = true;
            Lbl_Valor.Location = new System.Drawing.Point(16, 326);
            Lbl_Valor.Name = "Lbl_Valor";
            Lbl_Valor.Size = new System.Drawing.Size(56, 16);
            Lbl_Valor.TabIndex = 49;
            Lbl_Valor.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(216, 16);
            label1.TabIndex = 52;
            label1.Text = "Seleccionar Tabla Maestra:";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(223, 391);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 20;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(141, 391);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 19;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
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
            this.TS_BarraHerramientas.Location = new System.Drawing.Point(342, 13);
            this.TS_BarraHerramientas.Name = "TS_BarraHerramientas";
            this.TS_BarraHerramientas.Size = new System.Drawing.Size(384, 43);
            this.TS_BarraHerramientas.TabIndex = 37;
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
            this.TSB_Agregar.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // TSB_Modificar
            // 
            this.TSB_Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Modificar.Image")));
            this.TSB_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Modificar.Name = "TSB_Modificar";
            this.TSB_Modificar.Size = new System.Drawing.Size(40, 40);
            this.TSB_Modificar.Text = "Modificar";
            this.TSB_Modificar.Click += new System.EventHandler(this.toolStripButton7_Click);
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
            this.TSB_Salir.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // Grd_Detalles
            // 
            this.Grd_Detalles.AllowUserToAddRows = false;
            this.Grd_Detalles.AllowUserToDeleteRows = false;
            this.Grd_Detalles.BackgroundColor = System.Drawing.Color.White;
            this.Grd_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Detalles.Location = new System.Drawing.Point(397, 165);
            this.Grd_Detalles.Name = "Grd_Detalles";
            this.Grd_Detalles.ReadOnly = true;
            this.Grd_Detalles.RowHeadersVisible = false;
            this.Grd_Detalles.Size = new System.Drawing.Size(365, 273);
            this.Grd_Detalles.TabIndex = 38;
            // 
            // BS_MPais
            // 
            this.BS_MPais.DataMember = "M_Pais";
            this.BS_MPais.DataSource = this.DS_MonitorOperaciones;
            // 
            // DS_MonitorOperaciones
            // 
            this.DS_MonitorOperaciones.DataSetName = "MonitorOperacionesDataSet";
            this.DS_MonitorOperaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_MPais, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(84, 180);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(57, 22);
            this.Txt_Codigo.TabIndex = 39;
            // 
            // Txt_CodAlfa2
            // 
            this.Txt_CodAlfa2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_MPais, "Cod_AlfaNum2", true));
            this.Txt_CodAlfa2.Location = new System.Drawing.Point(181, 180);
            this.Txt_CodAlfa2.Name = "Txt_CodAlfa2";
            this.Txt_CodAlfa2.Size = new System.Drawing.Size(57, 22);
            this.Txt_CodAlfa2.TabIndex = 41;
            // 
            // Txt_CodAlfa3
            // 
            this.Txt_CodAlfa3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_MPais, "Cod_AlfaNum3", true));
            this.Txt_CodAlfa3.Location = new System.Drawing.Point(299, 179);
            this.Txt_CodAlfa3.Name = "Txt_CodAlfa3";
            this.Txt_CodAlfa3.Size = new System.Drawing.Size(57, 22);
            this.Txt_CodAlfa3.TabIndex = 43;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_MPais, "Descripcion", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(84, 208);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(272, 110);
            this.Txt_Nombre.TabIndex = 45;
            // 
            // Chk_CES
            // 
            this.Chk_CES.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_CES.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_MPais, "CondEspSeguridad", true));
            this.Chk_CES.Location = new System.Drawing.Point(16, 351);
            this.Chk_CES.Name = "Chk_CES";
            this.Chk_CES.Size = new System.Drawing.Size(303, 24);
            this.Chk_CES.TabIndex = 49;
            this.Chk_CES.Text = "Condición Especial de Seguridad";
            this.Chk_CES.UseVisualStyleBackColor = true;
            // 
            // NUD_Valor
            // 
            this.NUD_Valor.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_MPais, "Valor", true));
            this.NUD_Valor.Location = new System.Drawing.Point(142, 324);
            this.NUD_Valor.Name = "NUD_Valor";
            this.NUD_Valor.Size = new System.Drawing.Size(57, 22);
            this.NUD_Valor.TabIndex = 50;
            // 
            // Cmb_TablaMaestra
            // 
            this.Cmb_TablaMaestra.FormattingEnabled = true;
            this.Cmb_TablaMaestra.Items.AddRange(new object[] {
            "Actividad Comercial",
            "Antigüedad",
            "Criptomonedas",
            "Edad",
            "Estados",
            "Nivel de Riesgo",
            "Pais",
            "P.E.P.",
            "Productos",
            "Profesión",
            "Servicios",
            "Tipo de Documento Identidad",
            "Tipo de Estructura",
            "Tipo de Persona Jurídica",
            "Vol. Oper. Pers. Natural",
            "Vol. Oper. Pers. Jurídica"});
            this.Cmb_TablaMaestra.Location = new System.Drawing.Point(238, 97);
            this.Cmb_TablaMaestra.Name = "Cmb_TablaMaestra";
            this.Cmb_TablaMaestra.Size = new System.Drawing.Size(524, 24);
            this.Cmb_TablaMaestra.TabIndex = 51;
            this.Cmb_TablaMaestra.SelectedIndexChanged += new System.EventHandler(this.Cmb_TablaMaestra_SelectedIndexChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.B_BuscadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.C_ClientesTableAdapter = null;
            this.tableAdapterManager.C_FirBenAccTableAdapter = null;
            this.tableAdapterManager.C_HistActClientesTableAdapter = null;
            this.tableAdapterManager.C_ValorItemConsExpTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // BS_MEstados
            // 
            this.BS_MEstados.DataMember = "M_Estados";
            this.BS_MEstados.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MEstados
            // 
            this.TA_MEstados.ClearBeforeFill = true;
            // 
            // TA_MPais
            // 
            this.TA_MPais.ClearBeforeFill = true;
            // 
            // BS_MAntiguedad
            // 
            this.BS_MAntiguedad.DataMember = "M_Antiguedad";
            this.BS_MAntiguedad.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MAntiguedad
            // 
            this.TA_MAntiguedad.ClearBeforeFill = true;
            // 
            // BS_MActivComercial
            // 
            this.BS_MActivComercial.DataMember = "M_ActivComercial";
            this.BS_MActivComercial.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MActivComercial
            // 
            this.TA_MActivComercial.ClearBeforeFill = true;
            // 
            // BS_MCriptomonedas
            // 
            this.BS_MCriptomonedas.DataMember = "M_Criptomonedas";
            this.BS_MCriptomonedas.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MCriptomonedas
            // 
            this.TA_MCriptomonedas.ClearBeforeFill = true;
            // 
            // BS_MEdad
            // 
            this.BS_MEdad.DataMember = "M_Edad";
            this.BS_MEdad.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MEdad
            // 
            this.TA_MEdad.ClearBeforeFill = true;
            // 
            // BS_MNivelRiesgo
            // 
            this.BS_MNivelRiesgo.DataMember = "M_NivelRiesgo";
            this.BS_MNivelRiesgo.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MNivelRiesgo
            // 
            this.TA_MNivelRiesgo.ClearBeforeFill = true;
            // 
            // BS_MProfesiones
            // 
            this.BS_MProfesiones.DataMember = "M_Profesiones";
            this.BS_MProfesiones.DataSource = this.DS_MonitorOperaciones;
            // 
            // TA_MProfesiones
            // 
            this.TA_MProfesiones.ClearBeforeFill = true;
            // 
            // Frm_TablasMaestras
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(782, 458);
            this.Controls.Add(label1);
            this.Controls.Add(this.Cmb_TablaMaestra);
            this.Controls.Add(Lbl_Valor);
            this.Controls.Add(this.NUD_Valor);
            this.Controls.Add(Lbl_Codigo);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(Lbl_CodAlfa2);
            this.Controls.Add(this.Txt_CodAlfa2);
            this.Controls.Add(Lbl_CodAlfa3);
            this.Controls.Add(this.Txt_CodAlfa3);
            this.Controls.Add(Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Chk_CES);
            this.Controls.Add(this.Grd_Detalles);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TablasMaestras";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Tablas Maestras";
            this.Load += new System.EventHandler(this.Frm_TablasMaestras_Load);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MonitorOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAntiguedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MActivComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MCriptomonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MNivelRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProfesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.ToolStrip TS_BarraHerramientas;
        private System.Windows.Forms.ToolStripButton TSB_Primero;
        private System.Windows.Forms.ToolStripButton TSB_Anterior;
        private System.Windows.Forms.ToolStripButton TSB_Siguiente;
        private System.Windows.Forms.ToolStripButton TSB_Ultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_Agregar;
        private System.Windows.Forms.ToolStripButton TSB_Modificar;
        private System.Windows.Forms.ToolStripButton TSB_Eliminar;
        private System.Windows.Forms.ToolStripButton TSB_Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_Salir;
        private MonitorOperacionesDataSet DS_MonitorOperaciones;
        private MonitorOperacionesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView Grd_Detalles;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_CodAlfa2;
        private System.Windows.Forms.TextBox Txt_CodAlfa3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.CheckBox Chk_CES;
        private System.Windows.Forms.NumericUpDown NUD_Valor;
        private System.Windows.Forms.ComboBox Cmb_TablaMaestra;
        private System.Windows.Forms.BindingSource BS_MEstados;
        private MonitorOperacionesDataSetTableAdapters.M_EstadosTableAdapter TA_MEstados;
        private System.Windows.Forms.BindingSource BS_MPais;
        private MonitorOperacionesDataSetTableAdapters.M_PaisTableAdapter TA_MPais;
        private System.Windows.Forms.BindingSource BS_MAntiguedad;
        private MonitorOperacionesDataSetTableAdapters.M_AntiguedadTableAdapter TA_MAntiguedad;
        private System.Windows.Forms.BindingSource BS_MActivComercial;
        private MonitorOperacionesDataSetTableAdapters.M_ActivComercialTableAdapter TA_MActivComercial;
        private System.Windows.Forms.BindingSource BS_MCriptomonedas;
        private MonitorOperacionesDataSetTableAdapters.M_CriptomonedasTableAdapter TA_MCriptomonedas;
        private System.Windows.Forms.BindingSource BS_MEdad;
        private MonitorOperacionesDataSetTableAdapters.M_EdadTableAdapter TA_MEdad;
        private System.Windows.Forms.BindingSource BS_MNivelRiesgo;
        private MonitorOperacionesDataSetTableAdapters.M_NivelRiesgoTableAdapter TA_MNivelRiesgo;
        private System.Windows.Forms.BindingSource BS_MProfesiones;
        private MonitorOperacionesDataSetTableAdapters.M_ProfesionesTableAdapter TA_MProfesiones;
    }
}