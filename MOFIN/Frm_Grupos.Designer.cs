namespace MOFIN
{
    partial class Frm_Grupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Grupos));
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
            this.DS_Entorno = new MOFIN.EntornoDataSet();
            this.BS_Grupos = new System.Windows.Forms.BindingSource(this.components);
            this.TA_Grupos = new MOFIN.EntornoDataSetTableAdapters.GruposTableAdapter();
            this.tableAdapterManager = new MOFIN.EntornoDataSetTableAdapters.TableAdapterManager();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Tab_Opciones = new System.Windows.Forms.TabControl();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.Chk_Clientes = new System.Windows.Forms.CheckBox();
            this.Chk_CliMonitor = new System.Windows.Forms.CheckBox();
            this.Chk_CliBusqueda = new System.Windows.Forms.CheckBox();
            this.Operaciones = new System.Windows.Forms.TabPage();
            this.Chk_MonitorOperaciones = new System.Windows.Forms.CheckBox();
            this.Chk_MonFinanciero = new System.Windows.Forms.CheckBox();
            this.Chk_MonTransaccional = new System.Windows.Forms.CheckBox();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.Chk_TablasMaestras = new System.Windows.Forms.CheckBox();
            this.Chk_TabMaestras = new System.Windows.Forms.CheckBox();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.Chk_Reportes = new System.Windows.Forms.CheckBox();
            this.Herramientas = new System.Windows.Forms.TabPage();
            this.Chk_Herramientas = new System.Windows.Forms.CheckBox();
            this.Chk_HerEmpresas = new System.Windows.Forms.CheckBox();
            this.Chk_HerGrupos = new System.Windows.Forms.CheckBox();
            this.Chk_HerUsuarios = new System.Windows.Forms.CheckBox();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.TS_BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Entorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupos)).BeginInit();
            this.Tab_Opciones.SuspendLayout();
            this.Clientes.SuspendLayout();
            this.Operaciones.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.Reportes.SuspendLayout();
            this.Herramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(37, 107);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(64, 16);
            codigoLabel.TabIndex = 38;
            codigoLabel.Text = "Codigo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(37, 135);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 40;
            nombreLabel.Text = "Nombre:";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(317, 385);
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(212, 385);
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
            this.TS_BarraHerramientas.Location = new System.Drawing.Point(148, 12);
            this.TS_BarraHerramientas.Name = "TS_BarraHerramientas";
            this.TS_BarraHerramientas.Size = new System.Drawing.Size(384, 43);
            this.TS_BarraHerramientas.TabIndex = 37;
            this.TS_BarraHerramientas.Text = "toolStrip1";
            this.TS_BarraHerramientas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Grupos_KeyPress);
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
            // DS_Entorno
            // 
            this.DS_Entorno.DataSetName = "EntornoDataSet";
            this.DS_Entorno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_Grupos
            // 
            this.BS_Grupos.DataMember = "Grupos";
            this.BS_Grupos.DataSource = this.DS_Entorno;
            // 
            // TA_Grupos
            // 
            this.TA_Grupos.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Emp_AccesosTableAdapter = null;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.Grupo_OpcionesTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = this.TA_Grupos;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.Opc_SistemaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOFIN.EntornoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Grupos, "Codigo", true));
            this.Txt_Codigo.Location = new System.Drawing.Point(128, 101);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Codigo.TabIndex = 39;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Grupos, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(128, 128);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(404, 22);
            this.Txt_Nombre.TabIndex = 41;
            // 
            // Tab_Opciones
            // 
            this.Tab_Opciones.Controls.Add(this.Clientes);
            this.Tab_Opciones.Controls.Add(this.Operaciones);
            this.Tab_Opciones.Controls.Add(this.Tablas);
            this.Tab_Opciones.Controls.Add(this.Reportes);
            this.Tab_Opciones.Controls.Add(this.Herramientas);
            this.Tab_Opciones.Location = new System.Drawing.Point(36, 169);
            this.Tab_Opciones.Name = "Tab_Opciones";
            this.Tab_Opciones.SelectedIndex = 0;
            this.Tab_Opciones.Size = new System.Drawing.Size(500, 209);
            this.Tab_Opciones.TabIndex = 70;
            this.Tab_Opciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Grupos_KeyPress);
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.Chk_Clientes);
            this.Clientes.Controls.Add(this.Chk_CliMonitor);
            this.Clientes.Controls.Add(this.Chk_CliBusqueda);
            this.Clientes.Location = new System.Drawing.Point(4, 25);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(492, 180);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // Chk_Clientes
            // 
            this.Chk_Clientes.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Clientes", true));
            this.Chk_Clientes.Location = new System.Drawing.Point(30, 20);
            this.Chk_Clientes.Name = "Chk_Clientes";
            this.Chk_Clientes.Size = new System.Drawing.Size(200, 24);
            this.Chk_Clientes.TabIndex = 59;
            this.Chk_Clientes.Text = "Clientes";
            this.Chk_Clientes.UseVisualStyleBackColor = true;
            // 
            // Chk_CliMonitor
            // 
            this.Chk_CliMonitor.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Cli_Monitor", true));
            this.Chk_CliMonitor.Location = new System.Drawing.Point(170, 50);
            this.Chk_CliMonitor.Name = "Chk_CliMonitor";
            this.Chk_CliMonitor.Size = new System.Drawing.Size(200, 24);
            this.Chk_CliMonitor.TabIndex = 61;
            this.Chk_CliMonitor.Text = "Monitor de clientes";
            this.Chk_CliMonitor.UseVisualStyleBackColor = true;
            // 
            // Chk_CliBusqueda
            // 
            this.Chk_CliBusqueda.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Cli_Busqueda", true));
            this.Chk_CliBusqueda.Location = new System.Drawing.Point(170, 80);
            this.Chk_CliBusqueda.Name = "Chk_CliBusqueda";
            this.Chk_CliBusqueda.Size = new System.Drawing.Size(200, 24);
            this.Chk_CliBusqueda.TabIndex = 63;
            this.Chk_CliBusqueda.Text = "Búsqueda de Clientes";
            this.Chk_CliBusqueda.UseVisualStyleBackColor = true;
            // 
            // Operaciones
            // 
            this.Operaciones.Controls.Add(this.Chk_MonitorOperaciones);
            this.Operaciones.Controls.Add(this.Chk_MonFinanciero);
            this.Operaciones.Controls.Add(this.Chk_MonTransaccional);
            this.Operaciones.Location = new System.Drawing.Point(4, 25);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Padding = new System.Windows.Forms.Padding(3);
            this.Operaciones.Size = new System.Drawing.Size(492, 180);
            this.Operaciones.TabIndex = 1;
            this.Operaciones.Text = "Operaciones";
            this.Operaciones.UseVisualStyleBackColor = true;
            // 
            // Chk_MonitorOperaciones
            // 
            this.Chk_MonitorOperaciones.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Mon_Operaciones", true));
            this.Chk_MonitorOperaciones.Location = new System.Drawing.Point(30, 20);
            this.Chk_MonitorOperaciones.Name = "Chk_MonitorOperaciones";
            this.Chk_MonitorOperaciones.Size = new System.Drawing.Size(200, 24);
            this.Chk_MonitorOperaciones.TabIndex = 65;
            this.Chk_MonitorOperaciones.Text = "Monitor Operaciones";
            this.Chk_MonitorOperaciones.UseVisualStyleBackColor = true;
            // 
            // Chk_MonFinanciero
            // 
            this.Chk_MonFinanciero.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Mon_Financiero", true));
            this.Chk_MonFinanciero.Location = new System.Drawing.Point(170, 50);
            this.Chk_MonFinanciero.Name = "Chk_MonFinanciero";
            this.Chk_MonFinanciero.Size = new System.Drawing.Size(200, 24);
            this.Chk_MonFinanciero.TabIndex = 67;
            this.Chk_MonFinanciero.Text = "Financieras";
            this.Chk_MonFinanciero.UseVisualStyleBackColor = true;
            // 
            // Chk_MonTransaccional
            // 
            this.Chk_MonTransaccional.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Mon_Operacional", true));
            this.Chk_MonTransaccional.Location = new System.Drawing.Point(170, 80);
            this.Chk_MonTransaccional.Name = "Chk_MonTransaccional";
            this.Chk_MonTransaccional.Size = new System.Drawing.Size(200, 24);
            this.Chk_MonTransaccional.TabIndex = 69;
            this.Chk_MonTransaccional.Text = "Transaccionales";
            this.Chk_MonTransaccional.UseVisualStyleBackColor = true;
            // 
            // Tablas
            // 
            this.Tablas.Controls.Add(this.Chk_TablasMaestras);
            this.Tablas.Controls.Add(this.Chk_TabMaestras);
            this.Tablas.Location = new System.Drawing.Point(4, 25);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(492, 180);
            this.Tablas.TabIndex = 2;
            this.Tablas.Text = "Tablas Maestras";
            this.Tablas.UseVisualStyleBackColor = true;
            // 
            // Chk_TablasMaestras
            // 
            this.Chk_TablasMaestras.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Tablas_Maestras", true));
            this.Chk_TablasMaestras.Location = new System.Drawing.Point(30, 20);
            this.Chk_TablasMaestras.Name = "Chk_TablasMaestras";
            this.Chk_TablasMaestras.Size = new System.Drawing.Size(200, 24);
            this.Chk_TablasMaestras.TabIndex = 71;
            this.Chk_TablasMaestras.Text = "Tablas Maestras";
            this.Chk_TablasMaestras.UseVisualStyleBackColor = true;
            // 
            // Chk_TabMaestras
            // 
            this.Chk_TabMaestras.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Tab_Maestras", true));
            this.Chk_TabMaestras.Location = new System.Drawing.Point(170, 50);
            this.Chk_TabMaestras.Name = "Chk_TabMaestras";
            this.Chk_TabMaestras.Size = new System.Drawing.Size(200, 24);
            this.Chk_TabMaestras.TabIndex = 73;
            this.Chk_TabMaestras.Text = "Maestros";
            this.Chk_TabMaestras.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.Reportes.Controls.Add(this.Chk_Reportes);
            this.Reportes.Location = new System.Drawing.Point(4, 25);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(3);
            this.Reportes.Size = new System.Drawing.Size(492, 180);
            this.Reportes.TabIndex = 3;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // Chk_Reportes
            // 
            this.Chk_Reportes.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Reportes", true));
            this.Chk_Reportes.Location = new System.Drawing.Point(30, 20);
            this.Chk_Reportes.Name = "Chk_Reportes";
            this.Chk_Reportes.Size = new System.Drawing.Size(200, 24);
            this.Chk_Reportes.TabIndex = 67;
            this.Chk_Reportes.Text = "Reportes";
            this.Chk_Reportes.UseVisualStyleBackColor = true;
            // 
            // Herramientas
            // 
            this.Herramientas.Controls.Add(this.Chk_Herramientas);
            this.Herramientas.Controls.Add(this.Chk_HerEmpresas);
            this.Herramientas.Controls.Add(this.Chk_HerGrupos);
            this.Herramientas.Controls.Add(this.Chk_HerUsuarios);
            this.Herramientas.Location = new System.Drawing.Point(4, 25);
            this.Herramientas.Name = "Herramientas";
            this.Herramientas.Padding = new System.Windows.Forms.Padding(3);
            this.Herramientas.Size = new System.Drawing.Size(492, 180);
            this.Herramientas.TabIndex = 4;
            this.Herramientas.Text = "Herramientas";
            this.Herramientas.UseVisualStyleBackColor = true;
            // 
            // Chk_Herramientas
            // 
            this.Chk_Herramientas.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Opc_Sistema", true));
            this.Chk_Herramientas.Location = new System.Drawing.Point(30, 20);
            this.Chk_Herramientas.Name = "Chk_Herramientas";
            this.Chk_Herramientas.Size = new System.Drawing.Size(200, 24);
            this.Chk_Herramientas.TabIndex = 53;
            this.Chk_Herramientas.Text = "Herramientas";
            this.Chk_Herramientas.UseVisualStyleBackColor = true;
            // 
            // Chk_HerEmpresas
            // 
            this.Chk_HerEmpresas.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Ops_Empresas", true));
            this.Chk_HerEmpresas.Location = new System.Drawing.Point(170, 110);
            this.Chk_HerEmpresas.Name = "Chk_HerEmpresas";
            this.Chk_HerEmpresas.Size = new System.Drawing.Size(200, 24);
            this.Chk_HerEmpresas.TabIndex = 55;
            this.Chk_HerEmpresas.Text = "Empresas";
            this.Chk_HerEmpresas.UseVisualStyleBackColor = true;
            // 
            // Chk_HerGrupos
            // 
            this.Chk_HerGrupos.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Ops_Grupos", true));
            this.Chk_HerGrupos.Location = new System.Drawing.Point(170, 80);
            this.Chk_HerGrupos.Name = "Chk_HerGrupos";
            this.Chk_HerGrupos.Size = new System.Drawing.Size(200, 24);
            this.Chk_HerGrupos.TabIndex = 57;
            this.Chk_HerGrupos.Text = "Grupos/Perfiles";
            this.Chk_HerGrupos.UseVisualStyleBackColor = true;
            // 
            // Chk_HerUsuarios
            // 
            this.Chk_HerUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Grupos, "Ops_Usuarios", true));
            this.Chk_HerUsuarios.Location = new System.Drawing.Point(170, 50);
            this.Chk_HerUsuarios.Name = "Chk_HerUsuarios";
            this.Chk_HerUsuarios.Size = new System.Drawing.Size(200, 24);
            this.Chk_HerUsuarios.TabIndex = 59;
            this.Chk_HerUsuarios.Text = "Usuarios";
            this.Chk_HerUsuarios.UseVisualStyleBackColor = true;
            // 
            // Frm_Grupos
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(571, 431);
            this.Controls.Add(this.Tab_Opciones);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Grupos";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Frm_Grupos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Grupos_KeyPress);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Entorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupos)).EndInit();
            this.Tab_Opciones.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            this.Operaciones.ResumeLayout(false);
            this.Tablas.ResumeLayout(false);
            this.Reportes.ResumeLayout(false);
            this.Herramientas.ResumeLayout(false);
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
        private EntornoDataSet DS_Entorno;
        private System.Windows.Forms.BindingSource BS_Grupos;
        private EntornoDataSetTableAdapters.GruposTableAdapter TA_Grupos;
        private EntornoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TabControl Tab_Opciones;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.CheckBox Chk_Clientes;
        private System.Windows.Forms.CheckBox Chk_CliMonitor;
        private System.Windows.Forms.CheckBox Chk_CliBusqueda;
        private System.Windows.Forms.TabPage Operaciones;
        private System.Windows.Forms.CheckBox Chk_MonitorOperaciones;
        private System.Windows.Forms.CheckBox Chk_MonFinanciero;
        private System.Windows.Forms.CheckBox Chk_MonTransaccional;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.CheckBox Chk_TablasMaestras;
        private System.Windows.Forms.CheckBox Chk_TabMaestras;
        private System.Windows.Forms.TabPage Reportes;
        private System.Windows.Forms.CheckBox Chk_Reportes;
        private System.Windows.Forms.TabPage Herramientas;
        private System.Windows.Forms.CheckBox Chk_Herramientas;
        private System.Windows.Forms.CheckBox Chk_HerEmpresas;
        private System.Windows.Forms.CheckBox Chk_HerGrupos;
        private System.Windows.Forms.CheckBox Chk_HerUsuarios;
    }
}