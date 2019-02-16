namespace MOFIN
{
    partial class Frm_Empresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empresas));
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Siglas = new System.Windows.Forms.Label();
            this.Lbl_DocID = new System.Windows.Forms.Label();
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
            this.Grd_Empresas = new System.Windows.Forms.DataGridView();
            this.Col_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Empresas = new System.Windows.Forms.BindingSource(this.components);
            this.Pan_Elementos = new System.Windows.Forms.Panel();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_DocID = new System.Windows.Forms.TextBox();
            this.Txt_Siglas = new System.Windows.Forms.TextBox();
            this.Tab_Empresas = new System.Windows.Forms.TabControl();
            this.Pag1 = new System.Windows.Forms.TabPage();
            this.Pan_Detalles = new System.Windows.Forms.Panel();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Telf1 = new System.Windows.Forms.TextBox();
            this.Txt_Telf2 = new System.Windows.Forms.TextBox();
            this.Txt_Direc = new System.Windows.Forms.TextBox();
            this.Txt_Logo = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Telefono1 = new System.Windows.Forms.Label();
            this.Lbl_Telefono2 = new System.Windows.Forms.Label();
            this.Lbl_Direccion = new System.Windows.Forms.Label();
            this.Lbl_Logo = new System.Windows.Forms.Label();
            this.Pag2 = new System.Windows.Forms.TabPage();
            this.Lbl_Metadata = new System.Windows.Forms.Label();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Lbl_ConexString = new System.Windows.Forms.Label();
            this.Lbl_DsktpImag = new System.Windows.Forms.Label();
            this.Pan_Config = new System.Windows.Forms.Panel();
            this.Txt_Metadata = new System.Windows.Forms.TextBox();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.txt_ConexString = new System.Windows.Forms.TextBox();
            this.NUD_DsktpNr = new System.Windows.Forms.NumericUpDown();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.BS_Grupo_Opciones = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_MetodoValClientes = new System.Windows.Forms.Label();
            this.Grp_MetodoValora = new System.Windows.Forms.GroupBox();
            this.Opc_MetVal1 = new System.Windows.Forms.RadioButton();
            this.Opc_MetVal2 = new System.Windows.Forms.RadioButton();
            this.TS_BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).BeginInit();
            this.Pan_Elementos.SuspendLayout();
            this.Tab_Empresas.SuspendLayout();
            this.Pag1.SuspendLayout();
            this.Pan_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.Pag2.SuspendLayout();
            this.Pan_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DsktpNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupo_Opciones)).BeginInit();
            this.Grp_MetodoValora.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(26, 82);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Codigo.TabIndex = 37;
            this.Lbl_Codigo.Text = "Codigo:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(26, 110);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Nombre.TabIndex = 39;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Siglas
            // 
            this.Lbl_Siglas.AutoSize = true;
            this.Lbl_Siglas.Location = new System.Drawing.Point(6, 12);
            this.Lbl_Siglas.Name = "Lbl_Siglas";
            this.Lbl_Siglas.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Siglas.TabIndex = 41;
            this.Lbl_Siglas.Text = "Siglas:";
            // 
            // Lbl_DocID
            // 
            this.Lbl_DocID.AutoSize = true;
            this.Lbl_DocID.Location = new System.Drawing.Point(238, 82);
            this.Lbl_DocID.Name = "Lbl_DocID";
            this.Lbl_DocID.Size = new System.Drawing.Size(64, 16);
            this.Lbl_DocID.TabIndex = 45;
            this.Lbl_DocID.Text = "Doc ID:";
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
            this.TSB_Imprimir.Click += new System.EventHandler(this.TSB_Imprimir_Click);
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
            // Grd_Empresas
            // 
            this.Grd_Empresas.AllowUserToAddRows = false;
            this.Grd_Empresas.AllowUserToDeleteRows = false;
            this.Grd_Empresas.AutoGenerateColumns = false;
            this.Grd_Empresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grd_Empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Empresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Codigo,
            this.Col_Nombre});
            this.Grd_Empresas.DataSource = this.BS_Empresas;
            this.Grd_Empresas.Location = new System.Drawing.Point(15, 140);
            this.Grd_Empresas.Name = "Grd_Empresas";
            this.Grd_Empresas.ReadOnly = true;
            this.Grd_Empresas.RowHeadersVisible = false;
            this.Grd_Empresas.Size = new System.Drawing.Size(245, 305);
            this.Grd_Empresas.TabIndex = 56;
            this.Grd_Empresas.CurrentCellChanged += new System.EventHandler(this.Grd_Empresas_CurrentCellChanged);
            // 
            // Col_Codigo
            // 
            this.Col_Codigo.DataPropertyName = "Codigo";
            this.Col_Codigo.FillWeight = 245F;
            this.Col_Codigo.HeaderText = "Codigo";
            this.Col_Codigo.MinimumWidth = 245;
            this.Col_Codigo.Name = "Col_Codigo";
            this.Col_Codigo.ReadOnly = true;
            this.Col_Codigo.Visible = false;
            this.Col_Codigo.Width = 245;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_Nombre.DataPropertyName = "Nombre";
            this.Col_Nombre.FillWeight = 242F;
            this.Col_Nombre.HeaderText = "Nombre";
            this.Col_Nombre.MinimumWidth = 242;
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            this.Col_Nombre.Width = 242;
            // 
            // BS_Empresas
            // 
            this.BS_Empresas.DataSource = typeof(MofinModeloEntorno.Empresas);
            // 
            // Pan_Elementos
            // 
            this.Pan_Elementos.Controls.Add(this.Txt_Codigo);
            this.Pan_Elementos.Controls.Add(this.Txt_Nombre);
            this.Pan_Elementos.Controls.Add(this.Txt_DocID);
            this.Pan_Elementos.Location = new System.Drawing.Point(122, 77);
            this.Pan_Elementos.Name = "Pan_Elementos";
            this.Pan_Elementos.Size = new System.Drawing.Size(374, 57);
            this.Pan_Elementos.TabIndex = 57;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(3, 3);
            this.Txt_Codigo.MaxLength = 3;
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Codigo.TabIndex = 0;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(3, 31);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(363, 22);
            this.Txt_Nombre.TabIndex = 2;
            // 
            // Txt_DocID
            // 
            this.Txt_DocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Doc_ID", true));
            this.Txt_DocID.Location = new System.Drawing.Point(181, 3);
            this.Txt_DocID.MaxLength = 20;
            this.Txt_DocID.Name = "Txt_DocID";
            this.Txt_DocID.Size = new System.Drawing.Size(185, 22);
            this.Txt_DocID.TabIndex = 1;
            // 
            // Txt_Siglas
            // 
            this.Txt_Siglas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Siglas", true));
            this.Txt_Siglas.Location = new System.Drawing.Point(3, 3);
            this.Txt_Siglas.MaxLength = 5;
            this.Txt_Siglas.Name = "Txt_Siglas";
            this.Txt_Siglas.Size = new System.Drawing.Size(100, 22);
            this.Txt_Siglas.TabIndex = 0;
            // 
            // Tab_Empresas
            // 
            this.Tab_Empresas.Controls.Add(this.Pag1);
            this.Tab_Empresas.Controls.Add(this.Pag2);
            this.Tab_Empresas.Location = new System.Drawing.Point(266, 140);
            this.Tab_Empresas.Name = "Tab_Empresas";
            this.Tab_Empresas.SelectedIndex = 0;
            this.Tab_Empresas.Size = new System.Drawing.Size(474, 305);
            this.Tab_Empresas.TabIndex = 1;
            // 
            // Pag1
            // 
            this.Pag1.Controls.Add(this.Pan_Detalles);
            this.Pag1.Controls.Add(this.Lbl_Email);
            this.Pag1.Controls.Add(this.Lbl_Telefono1);
            this.Pag1.Controls.Add(this.Lbl_Telefono2);
            this.Pag1.Controls.Add(this.Lbl_Direccion);
            this.Pag1.Controls.Add(this.Lbl_Logo);
            this.Pag1.Controls.Add(this.Lbl_Siglas);
            this.Pag1.Location = new System.Drawing.Point(4, 25);
            this.Pag1.Name = "Pag1";
            this.Pag1.Padding = new System.Windows.Forms.Padding(3);
            this.Pag1.Size = new System.Drawing.Size(466, 276);
            this.Pag1.TabIndex = 0;
            this.Pag1.Text = "Detalles";
            this.Pag1.UseVisualStyleBackColor = true;
            // 
            // Pan_Detalles
            // 
            this.Pan_Detalles.Controls.Add(this.Pic_Logo);
            this.Pan_Detalles.Controls.Add(this.Txt_Siglas);
            this.Pan_Detalles.Controls.Add(this.Txt_Email);
            this.Pan_Detalles.Controls.Add(this.Txt_Telf1);
            this.Pan_Detalles.Controls.Add(this.Txt_Telf2);
            this.Pan_Detalles.Controls.Add(this.Txt_Direc);
            this.Pan_Detalles.Controls.Add(this.Txt_Logo);
            this.Pan_Detalles.Location = new System.Drawing.Point(100, 6);
            this.Pan_Detalles.Name = "Pan_Detalles";
            this.Pan_Detalles.Size = new System.Drawing.Size(360, 261);
            this.Pan_Detalles.TabIndex = 76;
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.Enabled = false;
            this.Pic_Logo.Location = new System.Drawing.Point(250, 143);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(106, 106);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Logo.TabIndex = 71;
            this.Pic_Logo.TabStop = false;
            // 
            // Txt_Email
            // 
            this.Txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Email", true));
            this.Txt_Email.Location = new System.Drawing.Point(3, 87);
            this.Txt_Email.MaxLength = 64;
            this.Txt_Email.Multiline = true;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(353, 50);
            this.Txt_Email.TabIndex = 2;
            // 
            // Txt_Telf1
            // 
            this.Txt_Telf1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Telefono1", true));
            this.Txt_Telf1.Location = new System.Drawing.Point(3, 143);
            this.Txt_Telf1.MaxLength = 20;
            this.Txt_Telf1.Name = "Txt_Telf1";
            this.Txt_Telf1.Size = new System.Drawing.Size(226, 22);
            this.Txt_Telf1.TabIndex = 3;
            // 
            // Txt_Telf2
            // 
            this.Txt_Telf2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Telefono2", true));
            this.Txt_Telf2.Location = new System.Drawing.Point(3, 171);
            this.Txt_Telf2.MaxLength = 20;
            this.Txt_Telf2.Name = "Txt_Telf2";
            this.Txt_Telf2.Size = new System.Drawing.Size(226, 22);
            this.Txt_Telf2.TabIndex = 4;
            // 
            // Txt_Direc
            // 
            this.Txt_Direc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Direccion", true));
            this.Txt_Direc.Location = new System.Drawing.Point(3, 31);
            this.Txt_Direc.MaxLength = 254;
            this.Txt_Direc.Multiline = true;
            this.Txt_Direc.Name = "Txt_Direc";
            this.Txt_Direc.Size = new System.Drawing.Size(353, 50);
            this.Txt_Direc.TabIndex = 1;
            // 
            // Txt_Logo
            // 
            this.Txt_Logo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Logo", true));
            this.Txt_Logo.Location = new System.Drawing.Point(3, 199);
            this.Txt_Logo.MaxLength = 254;
            this.Txt_Logo.Multiline = true;
            this.Txt_Logo.Name = "Txt_Logo";
            this.Txt_Logo.Size = new System.Drawing.Size(226, 50);
            this.Txt_Logo.TabIndex = 5;
            this.Txt_Logo.DoubleClick += new System.EventHandler(this.Txt_Logo_DoubleClick);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(6, 96);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Email.TabIndex = 71;
            this.Lbl_Email.Text = "Email:";
            // 
            // Lbl_Telefono1
            // 
            this.Lbl_Telefono1.AutoSize = true;
            this.Lbl_Telefono1.Location = new System.Drawing.Point(6, 152);
            this.Lbl_Telefono1.Name = "Lbl_Telefono1";
            this.Lbl_Telefono1.Size = new System.Drawing.Size(88, 16);
            this.Lbl_Telefono1.TabIndex = 72;
            this.Lbl_Telefono1.Text = "Telefono1:";
            // 
            // Lbl_Telefono2
            // 
            this.Lbl_Telefono2.AutoSize = true;
            this.Lbl_Telefono2.Location = new System.Drawing.Point(6, 180);
            this.Lbl_Telefono2.Name = "Lbl_Telefono2";
            this.Lbl_Telefono2.Size = new System.Drawing.Size(88, 16);
            this.Lbl_Telefono2.TabIndex = 73;
            this.Lbl_Telefono2.Text = "Telefono2:";
            // 
            // Lbl_Direccion
            // 
            this.Lbl_Direccion.AutoSize = true;
            this.Lbl_Direccion.Location = new System.Drawing.Point(6, 40);
            this.Lbl_Direccion.Name = "Lbl_Direccion";
            this.Lbl_Direccion.Size = new System.Drawing.Size(88, 16);
            this.Lbl_Direccion.TabIndex = 74;
            this.Lbl_Direccion.Text = "Dirección:";
            // 
            // Lbl_Logo
            // 
            this.Lbl_Logo.AutoSize = true;
            this.Lbl_Logo.Location = new System.Drawing.Point(6, 208);
            this.Lbl_Logo.Name = "Lbl_Logo";
            this.Lbl_Logo.Size = new System.Drawing.Size(48, 16);
            this.Lbl_Logo.TabIndex = 75;
            this.Lbl_Logo.Text = "Logo:";
            // 
            // Pag2
            // 
            this.Pag2.Controls.Add(this.Lbl_MetodoValClientes);
            this.Pag2.Controls.Add(this.Lbl_Metadata);
            this.Pag2.Controls.Add(this.Lbl_Proveedor);
            this.Pag2.Controls.Add(this.Lbl_ConexString);
            this.Pag2.Controls.Add(this.Lbl_DsktpImag);
            this.Pag2.Controls.Add(this.Pan_Config);
            this.Pag2.Location = new System.Drawing.Point(4, 25);
            this.Pag2.Name = "Pag2";
            this.Pag2.Padding = new System.Windows.Forms.Padding(3);
            this.Pag2.Size = new System.Drawing.Size(466, 276);
            this.Pag2.TabIndex = 1;
            this.Pag2.Text = "Configuración";
            this.Pag2.UseVisualStyleBackColor = true;
            // 
            // Lbl_Metadata
            // 
            this.Lbl_Metadata.Location = new System.Drawing.Point(6, 108);
            this.Lbl_Metadata.Name = "Lbl_Metadata";
            this.Lbl_Metadata.Size = new System.Drawing.Size(160, 15);
            this.Lbl_Metadata.TabIndex = 73;
            this.Lbl_Metadata.Text = "Metadata";
            this.Lbl_Metadata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.Location = new System.Drawing.Point(6, 61);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(160, 15);
            this.Lbl_Proveedor.TabIndex = 71;
            this.Lbl_Proveedor.Text = "Proveedor";
            this.Lbl_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_ConexString
            // 
            this.Lbl_ConexString.Location = new System.Drawing.Point(6, 14);
            this.Lbl_ConexString.Name = "Lbl_ConexString";
            this.Lbl_ConexString.Size = new System.Drawing.Size(160, 15);
            this.Lbl_ConexString.TabIndex = 2;
            this.Lbl_ConexString.Text = "Cadena de Conexión";
            this.Lbl_ConexString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DsktpImag
            // 
            this.Lbl_DsktpImag.ForeColor = System.Drawing.Color.Black;
            this.Lbl_DsktpImag.Location = new System.Drawing.Point(6, 219);
            this.Lbl_DsktpImag.Name = "Lbl_DsktpImag";
            this.Lbl_DsktpImag.Size = new System.Drawing.Size(160, 39);
            this.Lbl_DsktpImag.TabIndex = 0;
            this.Lbl_DsktpImag.Text = "Número de Fondos de Escritorio";
            this.Lbl_DsktpImag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pan_Config
            // 
            this.Pan_Config.Controls.Add(this.Grp_MetodoValora);
            this.Pan_Config.Controls.Add(this.Txt_Metadata);
            this.Pan_Config.Controls.Add(this.Txt_Proveedor);
            this.Pan_Config.Controls.Add(this.txt_ConexString);
            this.Pan_Config.Controls.Add(this.NUD_DsktpNr);
            this.Pan_Config.Location = new System.Drawing.Point(164, 5);
            this.Pan_Config.Name = "Pan_Config";
            this.Pan_Config.Size = new System.Drawing.Size(301, 270);
            this.Pan_Config.TabIndex = 75;
            // 
            // Txt_Metadata
            // 
            this.Txt_Metadata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Metadata", true));
            this.Txt_Metadata.Location = new System.Drawing.Point(7, 100);
            this.Txt_Metadata.MaxLength = 254;
            this.Txt_Metadata.Multiline = true;
            this.Txt_Metadata.Name = "Txt_Metadata";
            this.Txt_Metadata.Size = new System.Drawing.Size(285, 41);
            this.Txt_Metadata.TabIndex = 2;
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Proveedor", true));
            this.Txt_Proveedor.Location = new System.Drawing.Point(7, 53);
            this.Txt_Proveedor.MaxLength = 254;
            this.Txt_Proveedor.Multiline = true;
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(285, 41);
            this.Txt_Proveedor.TabIndex = 1;
            // 
            // txt_ConexString
            // 
            this.txt_ConexString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Cad_Conexion", true));
            this.txt_ConexString.Location = new System.Drawing.Point(7, 6);
            this.txt_ConexString.MaxLength = 254;
            this.txt_ConexString.Multiline = true;
            this.txt_ConexString.Name = "txt_ConexString";
            this.txt_ConexString.Size = new System.Drawing.Size(285, 41);
            this.txt_ConexString.TabIndex = 0;
            // 
            // NUD_DsktpNr
            // 
            this.NUD_DsktpNr.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BS_Empresas, "NroDesktops", true));
            this.NUD_DsktpNr.Location = new System.Drawing.Point(8, 223);
            this.NUD_DsktpNr.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUD_DsktpNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_DsktpNr.Name = "NUD_DsktpNr";
            this.NUD_DsktpNr.Size = new System.Drawing.Size(61, 22);
            this.NUD_DsktpNr.TabIndex = 4;
            this.NUD_DsktpNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_DsktpNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(643, 92);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 59;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(561, 92);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 58;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // BS_Grupo_Opciones
            // 
            this.BS_Grupo_Opciones.DataSource = typeof(MofinModeloEntorno.Grupo_Opciones);
            // 
            // Lbl_MetodoValClientes
            // 
            this.Lbl_MetodoValClientes.Location = new System.Drawing.Point(6, 160);
            this.Lbl_MetodoValClientes.Name = "Lbl_MetodoValClientes";
            this.Lbl_MetodoValClientes.Size = new System.Drawing.Size(160, 60);
            this.Lbl_MetodoValClientes.TabIndex = 76;
            this.Lbl_MetodoValClientes.Text = "Método de Valoración de Clientes";
            this.Lbl_MetodoValClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Grp_MetodoValora
            // 
            this.Grp_MetodoValora.Controls.Add(this.Opc_MetVal2);
            this.Grp_MetodoValora.Controls.Add(this.Opc_MetVal1);
            this.Grp_MetodoValora.Location = new System.Drawing.Point(7, 147);
            this.Grp_MetodoValora.Name = "Grp_MetodoValora";
            this.Grp_MetodoValora.Size = new System.Drawing.Size(206, 70);
            this.Grp_MetodoValora.TabIndex = 3;
            this.Grp_MetodoValora.TabStop = false;
            // 
            // Opc_MetVal1
            // 
            this.Opc_MetVal1.Location = new System.Drawing.Point(11, 15);
            this.Opc_MetVal1.Name = "Opc_MetVal1";
            this.Opc_MetVal1.Size = new System.Drawing.Size(150, 20);
            this.Opc_MetVal1.TabIndex = 0;
            this.Opc_MetVal1.TabStop = true;
            this.Opc_MetVal1.Text = "Promedio";
            this.Opc_MetVal1.UseVisualStyleBackColor = true;
            // 
            // Opc_MetVal2
            // 
            this.Opc_MetVal2.Location = new System.Drawing.Point(11, 39);
            this.Opc_MetVal2.Name = "Opc_MetVal2";
            this.Opc_MetVal2.Size = new System.Drawing.Size(150, 20);
            this.Opc_MetVal2.TabIndex = 1;
            this.Opc_MetVal2.TabStop = true;
            this.Opc_MetVal2.Text = "Mayor Valor";
            this.Opc_MetVal2.UseVisualStyleBackColor = true;
            // 
            // Frm_Empresas
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(752, 458);
            this.Controls.Add(this.Tab_Empresas);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Grd_Empresas);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_DocID);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Pan_Elementos);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Empresas";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Frm_Empresas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPress_JF);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).EndInit();
            this.Pan_Elementos.ResumeLayout(false);
            this.Pan_Elementos.PerformLayout();
            this.Tab_Empresas.ResumeLayout(false);
            this.Pag1.ResumeLayout(false);
            this.Pag1.PerformLayout();
            this.Pan_Detalles.ResumeLayout(false);
            this.Pan_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.Pag2.ResumeLayout(false);
            this.Pan_Config.ResumeLayout(false);
            this.Pan_Config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DsktpNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupo_Opciones)).EndInit();
            this.Grp_MetodoValora.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingSource BS_Empresas;
        private System.Windows.Forms.DataGridView Grd_Empresas;
        private System.Windows.Forms.Panel Pan_Elementos;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Siglas;
        private System.Windows.Forms.TextBox Txt_DocID;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Siglas;
        private System.Windows.Forms.Label Lbl_DocID;
        private System.Windows.Forms.BindingSource BS_Grupo_Opciones;
        private System.Windows.Forms.TabControl Tab_Empresas;
        private System.Windows.Forms.TabPage Pag1;
        private System.Windows.Forms.Panel Pan_Detalles;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Telf1;
        private System.Windows.Forms.TextBox Txt_Telf2;
        private System.Windows.Forms.TextBox Txt_Direc;
        private System.Windows.Forms.TextBox Txt_Logo;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Telefono1;
        private System.Windows.Forms.Label Lbl_Telefono2;
        private System.Windows.Forms.Label Lbl_Direccion;
        private System.Windows.Forms.Label Lbl_Logo;
        private System.Windows.Forms.TabPage Pag2;
        private System.Windows.Forms.Label Lbl_Metadata;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.Label Lbl_ConexString;
        private System.Windows.Forms.Label Lbl_DsktpImag;
        private System.Windows.Forms.Panel Pan_Config;
        private System.Windows.Forms.TextBox Txt_Metadata;
        private System.Windows.Forms.TextBox Txt_Proveedor;
        private System.Windows.Forms.TextBox txt_ConexString;
        private System.Windows.Forms.NumericUpDown NUD_DsktpNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.Label Lbl_MetodoValClientes;
        private System.Windows.Forms.GroupBox Grp_MetodoValora;
        private System.Windows.Forms.RadioButton Opc_MetVal2;
        private System.Windows.Forms.RadioButton Opc_MetVal1;
    }
}