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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label siglasLabel;
            System.Windows.Forms.Label doc_IDLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label logoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empresas));
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
            this.BS_Empresas = new System.Windows.Forms.BindingSource(this.components);
            this.Pan_Elementos = new System.Windows.Forms.Panel();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Siglas = new System.Windows.Forms.TextBox();
            this.Txt_DocID = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Telf1 = new System.Windows.Forms.TextBox();
            this.Txt_Telf2 = new System.Windows.Forms.TextBox();
            this.Txt_Direc = new System.Windows.Forms.TextBox();
            this.Txt_Logo = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            siglasLabel = new System.Windows.Forms.Label();
            doc_IDLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            telefono2Label = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            this.TS_BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).BeginInit();
            this.Pan_Elementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(26, 82);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(64, 16);
            codigoLabel.TabIndex = 37;
            codigoLabel.Text = "Codigo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 110);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 39;
            nombreLabel.Text = "Nombre:";
            // 
            // siglasLabel
            // 
            siglasLabel.AutoSize = true;
            siglasLabel.Location = new System.Drawing.Point(26, 138);
            siglasLabel.Name = "siglasLabel";
            siglasLabel.Size = new System.Drawing.Size(64, 16);
            siglasLabel.TabIndex = 41;
            siglasLabel.Text = "Siglas:";
            // 
            // doc_IDLabel
            // 
            doc_IDLabel.AutoSize = true;
            doc_IDLabel.Location = new System.Drawing.Point(238, 82);
            doc_IDLabel.Name = "doc_IDLabel";
            doc_IDLabel.Size = new System.Drawing.Size(64, 16);
            doc_IDLabel.TabIndex = 45;
            doc_IDLabel.Text = "Doc ID:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 222);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 16);
            emailLabel.TabIndex = 47;
            emailLabel.Text = "Email:";
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(26, 278);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(88, 16);
            telefono1Label.TabIndex = 49;
            telefono1Label.Text = "Telefono1:";
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(26, 306);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(88, 16);
            telefono2Label.TabIndex = 51;
            telefono2Label.Text = "Telefono2:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(26, 166);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(88, 16);
            direccionLabel.TabIndex = 53;
            direccionLabel.Text = "Dirección:";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(26, 334);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(48, 16);
            logoLabel.TabIndex = 55;
            logoLabel.Text = "Logo:";
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
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.Grd_Empresas.DataSource = this.BS_Empresas;
            this.Grd_Empresas.Location = new System.Drawing.Point(414, 135);
            this.Grd_Empresas.Name = "Grd_Empresas";
            this.Grd_Empresas.RowHeadersVisible = false;
            this.Grd_Empresas.Size = new System.Drawing.Size(333, 246);
            this.Grd_Empresas.TabIndex = 56;
            this.Grd_Empresas.CurrentCellChanged += new System.EventHandler(this.Grd_Empresas_CurrentCellChanged);
            // 
            // BS_Empresas
            // 
            this.BS_Empresas.DataSource = typeof(MofinModeloEntorno.Empresas);
            // 
            // Pan_Elementos
            // 
            this.Pan_Elementos.Controls.Add(this.Txt_Codigo);
            this.Pan_Elementos.Controls.Add(this.Txt_Nombre);
            this.Pan_Elementos.Controls.Add(this.Txt_Siglas);
            this.Pan_Elementos.Controls.Add(this.Txt_DocID);
            this.Pan_Elementos.Controls.Add(this.Txt_Email);
            this.Pan_Elementos.Controls.Add(this.Txt_Telf1);
            this.Pan_Elementos.Controls.Add(this.Txt_Telf2);
            this.Pan_Elementos.Controls.Add(this.Txt_Direc);
            this.Pan_Elementos.Controls.Add(this.Txt_Logo);
            this.Pan_Elementos.Location = new System.Drawing.Point(122, 77);
            this.Pan_Elementos.Name = "Pan_Elementos";
            this.Pan_Elementos.Size = new System.Drawing.Size(374, 317);
            this.Pan_Elementos.TabIndex = 57;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(3, 3);
            this.Txt_Codigo.MaxLength = 3;
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Codigo.TabIndex = 57;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(3, 31);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(363, 22);
            this.Txt_Nombre.TabIndex = 58;
            // 
            // Txt_Siglas
            // 
            this.Txt_Siglas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Siglas", true));
            this.Txt_Siglas.Location = new System.Drawing.Point(3, 59);
            this.Txt_Siglas.MaxLength = 5;
            this.Txt_Siglas.Name = "Txt_Siglas";
            this.Txt_Siglas.Size = new System.Drawing.Size(100, 22);
            this.Txt_Siglas.TabIndex = 59;
            // 
            // Txt_DocID
            // 
            this.Txt_DocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Doc_ID", true));
            this.Txt_DocID.Location = new System.Drawing.Point(181, 3);
            this.Txt_DocID.MaxLength = 20;
            this.Txt_DocID.Name = "Txt_DocID";
            this.Txt_DocID.Size = new System.Drawing.Size(185, 22);
            this.Txt_DocID.TabIndex = 60;
            // 
            // Txt_Email
            // 
            this.Txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Email", true));
            this.Txt_Email.Location = new System.Drawing.Point(3, 143);
            this.Txt_Email.MaxLength = 64;
            this.Txt_Email.Multiline = true;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(280, 50);
            this.Txt_Email.TabIndex = 61;
            // 
            // Txt_Telf1
            // 
            this.Txt_Telf1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Telefono1", true));
            this.Txt_Telf1.Location = new System.Drawing.Point(3, 199);
            this.Txt_Telf1.MaxLength = 20;
            this.Txt_Telf1.Name = "Txt_Telf1";
            this.Txt_Telf1.Size = new System.Drawing.Size(280, 22);
            this.Txt_Telf1.TabIndex = 62;
            // 
            // Txt_Telf2
            // 
            this.Txt_Telf2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Telefono2", true));
            this.Txt_Telf2.Location = new System.Drawing.Point(3, 227);
            this.Txt_Telf2.MaxLength = 20;
            this.Txt_Telf2.Name = "Txt_Telf2";
            this.Txt_Telf2.Size = new System.Drawing.Size(280, 22);
            this.Txt_Telf2.TabIndex = 63;
            // 
            // Txt_Direc
            // 
            this.Txt_Direc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Direccion", true));
            this.Txt_Direc.Location = new System.Drawing.Point(3, 87);
            this.Txt_Direc.MaxLength = 254;
            this.Txt_Direc.Multiline = true;
            this.Txt_Direc.Name = "Txt_Direc";
            this.Txt_Direc.Size = new System.Drawing.Size(280, 50);
            this.Txt_Direc.TabIndex = 64;
            // 
            // Txt_Logo
            // 
            this.Txt_Logo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Logo", true));
            this.Txt_Logo.Location = new System.Drawing.Point(3, 255);
            this.Txt_Logo.MaxLength = 254;
            this.Txt_Logo.Multiline = true;
            this.Txt_Logo.Name = "Txt_Logo";
            this.Txt_Logo.Size = new System.Drawing.Size(280, 50);
            this.Txt_Logo.TabIndex = 65;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(651, 88);
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(569, 88);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 58;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID_Sistema";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID_Sistema";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 81;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Siglas";
            this.dataGridViewTextBoxColumn14.HeaderText = "Siglas";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Directorio";
            this.dataGridViewTextBoxColumn15.HeaderText = "Directorio";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Doc_ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "Doc_ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn17.HeaderText = "Email";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn18.HeaderText = "Telefono1";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Telefono2";
            this.dataGridViewTextBoxColumn19.HeaderText = "Telefono2";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn20.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Logo";
            this.dataGridViewTextBoxColumn21.HeaderText = "Logo";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // Frm_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(776, 400);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Grd_Empresas);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(siglasLabel);
            this.Controls.Add(doc_IDLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Pan_Elementos);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Empresas";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Frm_Empresas_Load);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).EndInit();
            this.Pan_Elementos.ResumeLayout(false);
            this.Pan_Elementos.PerformLayout();
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
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Telf1;
        private System.Windows.Forms.TextBox Txt_Telf2;
        private System.Windows.Forms.TextBox Txt_Direc;
        private System.Windows.Forms.TextBox Txt_Logo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}