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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TablasMaestras));
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_CodAlfa2 = new System.Windows.Forms.Label();
            this.Lbl_CodAlfa3 = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_tablaMaestra = new System.Windows.Forms.Label();
            this.Lbl_Pais = new System.Windows.Forms.Label();
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
            this.iDSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condEspSeguridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_MActivComercial = new System.Windows.Forms.BindingSource(this.components);
            this.Cmb_TablaMaestra = new System.Windows.Forms.ComboBox();
            this.BS_MAntiguedad = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MCriptomonedas = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MEdad = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MEstados = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MNivelRiesgo = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MPais = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MPEP = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MProductos = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MProfesiones = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MServicios = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MTipoDocID = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MTipoEstructuraEmpresa = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MTipoPersJuridica = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MVolOperPersJur = new System.Windows.Forms.BindingSource(this.components);
            this.BS_MVolOperPersNat = new System.Windows.Forms.BindingSource(this.components);
            this.BS_TablaMaestra = new System.Windows.Forms.BindingSource(this.components);
            this.Pan_Elementos = new System.Windows.Forms.Panel();
            this.NUD_Valor = new System.Windows.Forms.NumericUpDown();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_CodAlfa2 = new System.Windows.Forms.TextBox();
            this.Txt_CodAlfa3 = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Chk_CES = new System.Windows.Forms.CheckBox();
            this.Cmb_Pais = new System.Windows.Forms.ComboBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.TS_BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MActivComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAntiguedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MCriptomonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MNivelRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProfesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoDocID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoEstructuraEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoPersJuridica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersJur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersNat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TablaMaestra)).BeginInit();
            this.Pan_Elementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Valor)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(16, 182);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Codigo.TabIndex = 38;
            this.Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_CodAlfa2
            // 
            this.Lbl_CodAlfa2.AutoSize = true;
            this.Lbl_CodAlfa2.Location = new System.Drawing.Point(174, 161);
            this.Lbl_CodAlfa2.Name = "Lbl_CodAlfa2";
            this.Lbl_CodAlfa2.Size = new System.Drawing.Size(72, 16);
            this.Lbl_CodAlfa2.TabIndex = 40;
            this.Lbl_CodAlfa2.Text = "AlfaNum2";
            this.Lbl_CodAlfa2.Visible = false;
            // 
            // Lbl_CodAlfa3
            // 
            this.Lbl_CodAlfa3.AutoSize = true;
            this.Lbl_CodAlfa3.Location = new System.Drawing.Point(292, 161);
            this.Lbl_CodAlfa3.Name = "Lbl_CodAlfa3";
            this.Lbl_CodAlfa3.Size = new System.Drawing.Size(72, 16);
            this.Lbl_CodAlfa3.TabIndex = 42;
            this.Lbl_CodAlfa3.Text = "AlfaNum3";
            this.Lbl_CodAlfa3.Visible = false;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(16, 211);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Nombre.TabIndex = 44;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(16, 326);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Valor.TabIndex = 49;
            this.Lbl_Valor.Text = "Valor:";
            // 
            // Lbl_tablaMaestra
            // 
            this.Lbl_tablaMaestra.AutoSize = true;
            this.Lbl_tablaMaestra.Location = new System.Drawing.Point(16, 100);
            this.Lbl_tablaMaestra.Name = "Lbl_tablaMaestra";
            this.Lbl_tablaMaestra.Size = new System.Drawing.Size(216, 16);
            this.Lbl_tablaMaestra.TabIndex = 52;
            this.Lbl_tablaMaestra.Text = "Seleccionar Tabla Maestra:";
            // 
            // Lbl_Pais
            // 
            this.Lbl_Pais.AutoSize = true;
            this.Lbl_Pais.Location = new System.Drawing.Point(30, 153);
            this.Lbl_Pais.Name = "Lbl_Pais";
            this.Lbl_Pais.Size = new System.Drawing.Size(48, 16);
            this.Lbl_Pais.TabIndex = 54;
            this.Lbl_Pais.Text = "País:";
            this.Lbl_Pais.Visible = false;
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
            this.TS_BarraHerramientas.Location = new System.Drawing.Point(340, 12);
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
            // Grd_Detalles
            // 
            this.Grd_Detalles.AllowUserToAddRows = false;
            this.Grd_Detalles.AllowUserToDeleteRows = false;
            this.Grd_Detalles.AutoGenerateColumns = false;
            this.Grd_Detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grd_Detalles.BackgroundColor = System.Drawing.Color.White;
            this.Grd_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSistemaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.condEspSeguridadDataGridViewTextBoxColumn});
            this.Grd_Detalles.DataSource = this.BS_MActivComercial;
            this.Grd_Detalles.Location = new System.Drawing.Point(397, 150);
            this.Grd_Detalles.Name = "Grd_Detalles";
            this.Grd_Detalles.ReadOnly = true;
            this.Grd_Detalles.RowHeadersVisible = false;
            this.Grd_Detalles.Size = new System.Drawing.Size(365, 288);
            this.Grd_Detalles.TabIndex = 38;
            this.Grd_Detalles.CurrentCellChanged += new System.EventHandler(this.Grd_Detalles_CurrentCellChanged);
            // 
            // iDSistemaDataGridViewTextBoxColumn
            // 
            this.iDSistemaDataGridViewTextBoxColumn.DataPropertyName = "ID_Sistema";
            this.iDSistemaDataGridViewTextBoxColumn.HeaderText = "ID_Sistema";
            this.iDSistemaDataGridViewTextBoxColumn.Name = "iDSistemaDataGridViewTextBoxColumn";
            this.iDSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSistemaDataGridViewTextBoxColumn.Visible = false;
            this.iDSistemaDataGridViewTextBoxColumn.Width = 94;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 81;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 280;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 280;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Visible = false;
            this.valorDataGridViewTextBoxColumn.Width = 73;
            // 
            // condEspSeguridadDataGridViewTextBoxColumn
            // 
            this.condEspSeguridadDataGridViewTextBoxColumn.DataPropertyName = "CondEspSeguridad";
            this.condEspSeguridadDataGridViewTextBoxColumn.HeaderText = "CondEspSeguridad";
            this.condEspSeguridadDataGridViewTextBoxColumn.Name = "condEspSeguridadDataGridViewTextBoxColumn";
            this.condEspSeguridadDataGridViewTextBoxColumn.ReadOnly = true;
            this.condEspSeguridadDataGridViewTextBoxColumn.Visible = false;
            this.condEspSeguridadDataGridViewTextBoxColumn.Width = 161;
            // 
            // BS_MActivComercial
            // 
            this.BS_MActivComercial.DataSource = typeof(MofinModelo.M_ActivComercial);
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
            // BS_MAntiguedad
            // 
            this.BS_MAntiguedad.DataSource = typeof(MofinModelo.M_Antiguedad);
            // 
            // BS_MCriptomonedas
            // 
            this.BS_MCriptomonedas.DataSource = typeof(MofinModelo.M_Criptomonedas);
            // 
            // BS_MEdad
            // 
            this.BS_MEdad.DataSource = typeof(MofinModelo.M_Edad);
            // 
            // BS_MEstados
            // 
            this.BS_MEstados.DataSource = typeof(MofinModelo.M_Estados);
            // 
            // BS_MNivelRiesgo
            // 
            this.BS_MNivelRiesgo.DataSource = typeof(MofinModelo.M_NivelRiesgo);
            // 
            // BS_MPais
            // 
            this.BS_MPais.DataSource = typeof(MofinModelo.M_Pais);
            // 
            // BS_MPEP
            // 
            this.BS_MPEP.DataSource = typeof(MofinModelo.M_PEP);
            // 
            // BS_MProductos
            // 
            this.BS_MProductos.DataSource = typeof(MofinModelo.M_Productos);
            // 
            // BS_MProfesiones
            // 
            this.BS_MProfesiones.DataSource = typeof(MofinModelo.M_Profesiones);
            // 
            // BS_MServicios
            // 
            this.BS_MServicios.DataSource = typeof(MofinModelo.M_Servicios);
            // 
            // BS_MTipoDocID
            // 
            this.BS_MTipoDocID.DataSource = typeof(MofinModelo.M_TipoDocID);
            // 
            // BS_MTipoEstructuraEmpresa
            // 
            this.BS_MTipoEstructuraEmpresa.DataSource = typeof(MofinModelo.M_TipoEstructuraEmpresa);
            // 
            // BS_MTipoPersJuridica
            // 
            this.BS_MTipoPersJuridica.DataSource = typeof(MofinModelo.M_TipoPersJuridica);
            // 
            // BS_MVolOperPersJur
            // 
            this.BS_MVolOperPersJur.DataSource = typeof(MofinModelo.M_VolOperPersJur);
            // 
            // BS_MVolOperPersNat
            // 
            this.BS_MVolOperPersNat.DataSource = typeof(MofinModelo.M_VolOperPersNat);
            // 
            // Pan_Elementos
            // 
            this.Pan_Elementos.Controls.Add(this.NUD_Valor);
            this.Pan_Elementos.Controls.Add(this.Txt_Codigo);
            this.Pan_Elementos.Controls.Add(this.Txt_CodAlfa2);
            this.Pan_Elementos.Controls.Add(this.Txt_CodAlfa3);
            this.Pan_Elementos.Controls.Add(this.Txt_Nombre);
            this.Pan_Elementos.Controls.Add(this.Chk_CES);
            this.Pan_Elementos.Location = new System.Drawing.Point(17, 146);
            this.Pan_Elementos.Name = "Pan_Elementos";
            this.Pan_Elementos.Size = new System.Drawing.Size(353, 236);
            this.Pan_Elementos.TabIndex = 55;
            // 
            // NUD_Valor
            // 
            this.NUD_Valor.Location = new System.Drawing.Point(63, 179);
            this.NUD_Valor.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUD_Valor.Name = "NUD_Valor";
            this.NUD_Valor.Size = new System.Drawing.Size(57, 22);
            this.NUD_Valor.TabIndex = 59;
            this.NUD_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(63, 35);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(57, 22);
            this.Txt_Codigo.TabIndex = 54;
            // 
            // Txt_CodAlfa2
            // 
            this.Txt_CodAlfa2.Location = new System.Drawing.Point(160, 35);
            this.Txt_CodAlfa2.Name = "Txt_CodAlfa2";
            this.Txt_CodAlfa2.Size = new System.Drawing.Size(57, 22);
            this.Txt_CodAlfa2.TabIndex = 55;
            this.Txt_CodAlfa2.Visible = false;
            // 
            // Txt_CodAlfa3
            // 
            this.Txt_CodAlfa3.Location = new System.Drawing.Point(276, 35);
            this.Txt_CodAlfa3.Name = "Txt_CodAlfa3";
            this.Txt_CodAlfa3.Size = new System.Drawing.Size(57, 22);
            this.Txt_CodAlfa3.TabIndex = 56;
            this.Txt_CodAlfa3.Visible = false;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(63, 63);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(270, 110);
            this.Txt_Nombre.TabIndex = 57;
            // 
            // Chk_CES
            // 
            this.Chk_CES.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_CES.Location = new System.Drawing.Point(0, 205);
            this.Chk_CES.Name = "Chk_CES";
            this.Chk_CES.Size = new System.Drawing.Size(303, 24);
            this.Chk_CES.TabIndex = 58;
            this.Chk_CES.Text = "Condición Especial de Seguridad";
            this.Chk_CES.UseVisualStyleBackColor = true;
            // 
            // Cmb_Pais
            // 
            this.Cmb_Pais.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BS_MPais, "Codigo", true));
            this.Cmb_Pais.DataSource = this.BS_MPais;
            this.Cmb_Pais.DisplayMember = "Descripcion";
            this.Cmb_Pais.FormattingEnabled = true;
            this.Cmb_Pais.Location = new System.Drawing.Point(80, 152);
            this.Cmb_Pais.Name = "Cmb_Pais";
            this.Cmb_Pais.Size = new System.Drawing.Size(270, 24);
            this.Cmb_Pais.TabIndex = 61;
            this.Cmb_Pais.Visible = false;
            this.Cmb_Pais.SelectedIndexChanged += new System.EventHandler(this.Cmb_Pais_SelectedIndexChanged);
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(7, 69);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(766, 22);
            this.Txt_Valor.TabIndex = 62;
            // 
            // Frm_TablasMaestras
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(782, 458);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Cmb_Pais);
            this.Controls.Add(this.Lbl_Pais);
            this.Controls.Add(this.Lbl_tablaMaestra);
            this.Controls.Add(this.Cmb_TablaMaestra);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Lbl_CodAlfa2);
            this.Controls.Add(this.Lbl_CodAlfa3);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Grd_Detalles);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Pan_Elementos);
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
            ((System.ComponentModel.ISupportInitialize)(this.BS_MActivComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAntiguedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MCriptomonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MNivelRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MPEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MProfesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoDocID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoEstructuraEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MTipoPersJuridica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersJur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MVolOperPersNat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TablaMaestra)).EndInit();
            this.Pan_Elementos.ResumeLayout(false);
            this.Pan_Elementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Valor)).EndInit();
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
        private System.Windows.Forms.DataGridView Grd_Detalles;
        private System.Windows.Forms.ComboBox Cmb_TablaMaestra;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_CodAlfa2;
        private System.Windows.Forms.Label Lbl_CodAlfa3;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_tablaMaestra;
        private System.Windows.Forms.Label Lbl_Pais;
        private System.Windows.Forms.BindingSource BS_MActivComercial;
        private System.Windows.Forms.BindingSource BS_MAntiguedad;
        private System.Windows.Forms.BindingSource BS_MCriptomonedas;
        private System.Windows.Forms.BindingSource BS_MEdad;
        private System.Windows.Forms.BindingSource BS_MEstados;
        private System.Windows.Forms.BindingSource BS_MNivelRiesgo;
        private System.Windows.Forms.BindingSource BS_MPais;
        private System.Windows.Forms.BindingSource BS_MPEP;
        private System.Windows.Forms.BindingSource BS_MProductos;
        private System.Windows.Forms.BindingSource BS_MProfesiones;
        private System.Windows.Forms.BindingSource BS_MServicios;
        private System.Windows.Forms.BindingSource BS_MTipoDocID;
        private System.Windows.Forms.BindingSource BS_MTipoEstructuraEmpresa;
        private System.Windows.Forms.BindingSource BS_MTipoPersJuridica;
        private System.Windows.Forms.BindingSource BS_MVolOperPersJur;
        private System.Windows.Forms.BindingSource BS_MVolOperPersNat;
        private System.Windows.Forms.BindingSource BS_TablaMaestra;
        private System.Windows.Forms.Panel Pan_Elementos;
        private System.Windows.Forms.NumericUpDown NUD_Valor;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_CodAlfa2;
        private System.Windows.Forms.TextBox Txt_CodAlfa3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.CheckBox Chk_CES;
        private System.Windows.Forms.ComboBox Cmb_Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condEspSeguridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Txt_Valor;
    }
}