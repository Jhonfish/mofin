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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label siglasLabel;
            System.Windows.Forms.Label doc_IDLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label logoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
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
            this.tableAdapterManager = new MOFIN.EntornoDataSetTableAdapters.TableAdapterManager();
            this.TA_Empresas = new MOFIN.EntornoDataSetTableAdapters.EmpresasTableAdapter();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Siglas = new System.Windows.Forms.TextBox();
            this.Txt_DocID = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Telf1 = new System.Windows.Forms.TextBox();
            this.Txt_Telf2 = new System.Windows.Forms.TextBox();
            this.Txt_Direc = new System.Windows.Forms.TextBox();
            this.Txt_Logo = new System.Windows.Forms.TextBox();
            this.DS_Entorno = new MOFIN.EntornoDataSet();
            this.BS_Empresas = new System.Windows.Forms.BindingSource(this.components);
            this.Grd_Empresas = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.DS_Entorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(25, 115);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(64, 16);
            codigoLabel.TabIndex = 37;
            codigoLabel.Text = "Codigo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 143);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 39;
            nombreLabel.Text = "Nombre:";
            // 
            // siglasLabel
            // 
            siglasLabel.AutoSize = true;
            siglasLabel.Location = new System.Drawing.Point(25, 171);
            siglasLabel.Name = "siglasLabel";
            siglasLabel.Size = new System.Drawing.Size(64, 16);
            siglasLabel.TabIndex = 41;
            siglasLabel.Text = "Siglas:";
            // 
            // doc_IDLabel
            // 
            doc_IDLabel.AutoSize = true;
            doc_IDLabel.Location = new System.Drawing.Point(237, 115);
            doc_IDLabel.Name = "doc_IDLabel";
            doc_IDLabel.Size = new System.Drawing.Size(64, 16);
            doc_IDLabel.TabIndex = 45;
            doc_IDLabel.Text = "Doc ID:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(25, 255);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 16);
            emailLabel.TabIndex = 47;
            emailLabel.Text = "Email:";
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(25, 311);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(88, 16);
            telefono1Label.TabIndex = 49;
            telefono1Label.Text = "Telefono1:";
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(25, 339);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(88, 16);
            telefono2Label.TabIndex = 51;
            telefono2Label.Text = "Telefono2:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(25, 199);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(88, 16);
            direccionLabel.TabIndex = 53;
            direccionLabel.Text = "Dirección:";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(25, 367);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(48, 16);
            logoLabel.TabIndex = 55;
            logoLabel.Text = "Logo:";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(643, 123);
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(561, 123);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Emp_AccesosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.Grupo_OpcionesTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.Opc_SistemaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOFIN.EntornoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // TA_Empresas
            // 
            this.TA_Empresas.ClearBeforeFill = true;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(127, 112);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Codigo.TabIndex = 38;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(127, 140);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(363, 22);
            this.Txt_Nombre.TabIndex = 40;
            // 
            // Txt_Siglas
            // 
            this.Txt_Siglas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Siglas", true));
            this.Txt_Siglas.Location = new System.Drawing.Point(127, 168);
            this.Txt_Siglas.Name = "Txt_Siglas";
            this.Txt_Siglas.Size = new System.Drawing.Size(100, 22);
            this.Txt_Siglas.TabIndex = 42;
            // 
            // Txt_DocID
            // 
            this.Txt_DocID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Doc_ID", true));
            this.Txt_DocID.Location = new System.Drawing.Point(305, 112);
            this.Txt_DocID.Name = "Txt_DocID";
            this.Txt_DocID.Size = new System.Drawing.Size(185, 22);
            this.Txt_DocID.TabIndex = 46;
            // 
            // Txt_Email
            // 
            this.Txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Email", true));
            this.Txt_Email.Location = new System.Drawing.Point(127, 252);
            this.Txt_Email.Multiline = true;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(280, 50);
            this.Txt_Email.TabIndex = 48;
            // 
            // Txt_Telf1
            // 
            this.Txt_Telf1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Telefono1", true));
            this.Txt_Telf1.Location = new System.Drawing.Point(127, 308);
            this.Txt_Telf1.Name = "Txt_Telf1";
            this.Txt_Telf1.Size = new System.Drawing.Size(280, 22);
            this.Txt_Telf1.TabIndex = 50;
            // 
            // Txt_Telf2
            // 
            this.Txt_Telf2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Telefono2", true));
            this.Txt_Telf2.Location = new System.Drawing.Point(127, 336);
            this.Txt_Telf2.Name = "Txt_Telf2";
            this.Txt_Telf2.Size = new System.Drawing.Size(280, 22);
            this.Txt_Telf2.TabIndex = 52;
            // 
            // Txt_Direc
            // 
            this.Txt_Direc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Direccion", true));
            this.Txt_Direc.Location = new System.Drawing.Point(127, 196);
            this.Txt_Direc.Multiline = true;
            this.Txt_Direc.Name = "Txt_Direc";
            this.Txt_Direc.Size = new System.Drawing.Size(280, 50);
            this.Txt_Direc.TabIndex = 54;
            // 
            // Txt_Logo
            // 
            this.Txt_Logo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Empresas, "Logo", true));
            this.Txt_Logo.Location = new System.Drawing.Point(127, 364);
            this.Txt_Logo.Multiline = true;
            this.Txt_Logo.Name = "Txt_Logo";
            this.Txt_Logo.Size = new System.Drawing.Size(280, 50);
            this.Txt_Logo.TabIndex = 56;
            // 
            // DS_Entorno
            // 
            this.DS_Entorno.DataSetName = "EntornoDataSet";
            this.DS_Entorno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_Empresas
            // 
            this.BS_Empresas.DataMember = "Empresas";
            this.BS_Empresas.DataSource = this.DS_Entorno;
            // 
            // Grd_Empresas
            // 
            this.Grd_Empresas.AllowUserToAddRows = false;
            this.Grd_Empresas.AllowUserToDeleteRows = false;
            this.Grd_Empresas.AutoGenerateColumns = false;
            this.Grd_Empresas.BackgroundColor = System.Drawing.Color.White;
            this.Grd_Empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Empresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.Grd_Empresas.DataSource = this.BS_Empresas;
            this.Grd_Empresas.Location = new System.Drawing.Point(413, 168);
            this.Grd_Empresas.Name = "Grd_Empresas";
            this.Grd_Empresas.ReadOnly = true;
            this.Grd_Empresas.RowHeadersVisible = false;
            this.Grd_Empresas.Size = new System.Drawing.Size(343, 268);
            this.Grd_Empresas.TabIndex = 56;
            this.Grd_Empresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Empresas_CellContentClick_1);
            this.Grd_Empresas.CurrentCellChanged += new System.EventHandler(this.Grd_Empresas_CurrentCellChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 340;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Siglas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Siglas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Directorio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Directorio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Doc_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Doc_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefono2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Logo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Logo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // Frm_Empresas
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(765, 445);
            this.Controls.Add(this.Grd_Empresas);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(siglasLabel);
            this.Controls.Add(this.Txt_Siglas);
            this.Controls.Add(doc_IDLabel);
            this.Controls.Add(this.Txt_DocID);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(this.Txt_Telf1);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(this.Txt_Telf2);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.Txt_Direc);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.Txt_Logo);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
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
            ((System.ComponentModel.ISupportInitialize)(this.DS_Entorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Empresas)).EndInit();
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
        private EntornoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EntornoDataSetTableAdapters.EmpresasTableAdapter TA_Empresas;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Siglas;
        private System.Windows.Forms.TextBox Txt_DocID;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Telf1;
        private System.Windows.Forms.TextBox Txt_Telf2;
        private System.Windows.Forms.TextBox Txt_Direc;
        private System.Windows.Forms.TextBox Txt_Logo;
        private EntornoDataSet DS_Entorno;
        private System.Windows.Forms.BindingSource BS_Empresas;
        private System.Windows.Forms.DataGridView Grd_Empresas;
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
    }
}