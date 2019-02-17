namespace MOFIN
{
    partial class Frm_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.Lbl_IDUsuario = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_FondoEscritorio = new System.Windows.Forms.Label();
            this.Lbl_Idioma = new System.Windows.Forms.Label();
            this.Lbl_PaisUso = new System.Windows.Forms.Label();
            this.Lbl_FormatoFecha = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.TS_BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.TSB_Primero = new System.Windows.Forms.ToolStripButton();
            this.TSB_Anterior = new System.Windows.Forms.ToolStripButton();
            this.TSB_Siguiente = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ultimo = new System.Windows.Forms.ToolStripButton();
            this.ts_Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Agregar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Modificar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Salir = new System.Windows.Forms.ToolStripButton();
            this.Grd_Usuarios = new System.Windows.Forms.DataGridView();
            this.Col_ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Usuarios = new System.Windows.Forms.BindingSource(this.components);
            this.Pan_Elementos = new System.Windows.Forms.Panel();
            this.Chk_ConfigBtnsBarraHerram = new System.Windows.Forms.CheckBox();
            this.Pan_BotAcpcan_EmpAcc = new System.Windows.Forms.Panel();
            this.Btn_EmpAcc_Cancelar = new System.Windows.Forms.Button();
            this.Btn_EmpAcc_Aceptar = new System.Windows.Forms.Button();
            this.Grd_EmpAccesos = new System.Windows.Forms.DataGridView();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Empresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BS_Empresas = new System.Windows.Forms.BindingSource(this.components);
            this.Col_Grupo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BS_Grupos = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Emp_Accesos = new System.Windows.Forms.BindingSource(this.components);
            this.Grp_FormatoFecha = new System.Windows.Forms.GroupBox();
            this.Opc_FormFec2 = new System.Windows.Forms.RadioButton();
            this.Opc_FormFec1 = new System.Windows.Forms.RadioButton();
            this.Grp_Pais = new System.Windows.Forms.GroupBox();
            this.Opc_Pais2 = new System.Windows.Forms.RadioButton();
            this.Opc_Pais1 = new System.Windows.Forms.RadioButton();
            this.Grp_Idioma = new System.Windows.Forms.GroupBox();
            this.Opc_Idioma2 = new System.Windows.Forms.RadioButton();
            this.Opc_Idioma1 = new System.Windows.Forms.RadioButton();
            this.Grp_Desktop = new System.Windows.Forms.GroupBox();
            this.Opc_Desktop2 = new System.Windows.Forms.RadioButton();
            this.Opc_Desktop1 = new System.Windows.Forms.RadioButton();
            this.Txt_IDUsuario = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Pan_BtnsEmpAccesos = new System.Windows.Forms.Panel();
            this.Btn_EmpAcc_Inc = new System.Windows.Forms.Button();
            this.Btn_EmpAcc_Eli = new System.Windows.Forms.Button();
            this.Btn_EmpAcc_Mod = new System.Windows.Forms.Button();
            this.BS_Grupo_Opciones = new System.Windows.Forms.BindingSource(this.components);
            this.TS_BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Usuarios)).BeginInit();
            this.Pan_Elementos.SuspendLayout();
            this.Pan_BotAcpcan_EmpAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_EmpAccesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Emp_Accesos)).BeginInit();
            this.Grp_FormatoFecha.SuspendLayout();
            this.Grp_Pais.SuspendLayout();
            this.Grp_Idioma.SuspendLayout();
            this.Grp_Desktop.SuspendLayout();
            this.Pan_BtnsEmpAccesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupo_Opciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_IDUsuario
            // 
            this.Lbl_IDUsuario.AutoSize = true;
            this.Lbl_IDUsuario.Location = new System.Drawing.Point(338, 78);
            this.Lbl_IDUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDUsuario.Name = "Lbl_IDUsuario";
            this.Lbl_IDUsuario.Size = new System.Drawing.Size(96, 16);
            this.Lbl_IDUsuario.TabIndex = 21;
            this.Lbl_IDUsuario.Text = "ID Usuario:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(338, 110);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Nombre.TabIndex = 23;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(338, 142);
            this.Lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(80, 16);
            this.Lbl_Password.TabIndex = 25;
            this.Lbl_Password.Text = "Password:";
            // 
            // Lbl_FondoEscritorio
            // 
            this.Lbl_FondoEscritorio.Location = new System.Drawing.Point(338, 173);
            this.Lbl_FondoEscritorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_FondoEscritorio.Name = "Lbl_FondoEscritorio";
            this.Lbl_FondoEscritorio.Size = new System.Drawing.Size(205, 16);
            this.Lbl_FondoEscritorio.TabIndex = 27;
            this.Lbl_FondoEscritorio.Text = "Fondo de Escritorio:";
            this.Lbl_FondoEscritorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Idioma
            // 
            this.Lbl_Idioma.Location = new System.Drawing.Point(624, 173);
            this.Lbl_Idioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Idioma.Name = "Lbl_Idioma";
            this.Lbl_Idioma.Size = new System.Drawing.Size(150, 16);
            this.Lbl_Idioma.TabIndex = 29;
            this.Lbl_Idioma.Text = "Idioma:";
            // 
            // Lbl_PaisUso
            // 
            this.Lbl_PaisUso.Location = new System.Drawing.Point(624, 252);
            this.Lbl_PaisUso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PaisUso.Name = "Lbl_PaisUso";
            this.Lbl_PaisUso.Size = new System.Drawing.Size(150, 16);
            this.Lbl_PaisUso.TabIndex = 31;
            this.Lbl_PaisUso.Text = "Pais Uso:";
            // 
            // Lbl_FormatoFecha
            // 
            this.Lbl_FormatoFecha.Location = new System.Drawing.Point(338, 252);
            this.Lbl_FormatoFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_FormatoFecha.Name = "Lbl_FormatoFecha";
            this.Lbl_FormatoFecha.Size = new System.Drawing.Size(229, 16);
            this.Lbl_FormatoFecha.TabIndex = 33;
            this.Lbl_FormatoFecha.Text = "Formato de Fecha:";
            this.Lbl_FormatoFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(183, 496);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 11;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(101, 496);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 10;
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
            this.ts_Sep1,
            this.TSB_Agregar,
            this.TSB_Modificar,
            this.TSB_Eliminar,
            this.TSB_Imprimir,
            this.toolStripSeparator3,
            this.TSB_Salir});
            this.TS_BarraHerramientas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TS_BarraHerramientas.Location = new System.Drawing.Point(385, 17);
            this.TS_BarraHerramientas.Name = "TS_BarraHerramientas";
            this.TS_BarraHerramientas.Size = new System.Drawing.Size(384, 43);
            this.TS_BarraHerramientas.TabIndex = 9;
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
            // ts_Sep1
            // 
            this.ts_Sep1.Name = "ts_Sep1";
            this.ts_Sep1.Size = new System.Drawing.Size(6, 43);
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
            // Grd_Usuarios
            // 
            this.Grd_Usuarios.AllowUserToAddRows = false;
            this.Grd_Usuarios.AllowUserToDeleteRows = false;
            this.Grd_Usuarios.AutoGenerateColumns = false;
            this.Grd_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID_Usuario,
            this.Col_Nombre});
            this.Grd_Usuarios.DataSource = this.BS_Usuarios;
            this.Grd_Usuarios.Location = new System.Drawing.Point(14, 77);
            this.Grd_Usuarios.Name = "Grd_Usuarios";
            this.Grd_Usuarios.ReadOnly = true;
            this.Grd_Usuarios.RowHeadersVisible = false;
            this.Grd_Usuarios.Size = new System.Drawing.Size(298, 412);
            this.Grd_Usuarios.TabIndex = 8;
            this.Grd_Usuarios.CurrentCellChanged += new System.EventHandler(this.Grd_Usuarios_CurrentCellChanged);
            // 
            // Col_ID_Usuario
            // 
            this.Col_ID_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_ID_Usuario.DataPropertyName = "ID_Usuario";
            this.Col_ID_Usuario.FillWeight = 120F;
            this.Col_ID_Usuario.HeaderText = "ID_Usuario";
            this.Col_ID_Usuario.Name = "Col_ID_Usuario";
            this.Col_ID_Usuario.ReadOnly = true;
            this.Col_ID_Usuario.Width = 113;
            // 
            // Col_Nombre
            // 
            this.Col_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Col_Nombre.DataPropertyName = "Nombre";
            this.Col_Nombre.FillWeight = 280F;
            this.Col_Nombre.HeaderText = "Nombre";
            this.Col_Nombre.Name = "Col_Nombre";
            this.Col_Nombre.ReadOnly = true;
            this.Col_Nombre.Width = 81;
            // 
            // BS_Usuarios
            // 
            this.BS_Usuarios.DataSource = typeof(MofinModeloEntorno.Usuarios);
            // 
            // Pan_Elementos
            // 
            this.Pan_Elementos.Controls.Add(this.Chk_ConfigBtnsBarraHerram);
            this.Pan_Elementos.Controls.Add(this.Pan_BotAcpcan_EmpAcc);
            this.Pan_Elementos.Controls.Add(this.Grd_EmpAccesos);
            this.Pan_Elementos.Controls.Add(this.Grp_FormatoFecha);
            this.Pan_Elementos.Controls.Add(this.Grp_Pais);
            this.Pan_Elementos.Controls.Add(this.Grp_Idioma);
            this.Pan_Elementos.Controls.Add(this.Grp_Desktop);
            this.Pan_Elementos.Controls.Add(this.Txt_IDUsuario);
            this.Pan_Elementos.Controls.Add(this.Txt_Nombre);
            this.Pan_Elementos.Controls.Add(this.Txt_Password);
            this.Pan_Elementos.Controls.Add(this.Pan_BtnsEmpAccesos);
            this.Pan_Elementos.Location = new System.Drawing.Point(330, 75);
            this.Pan_Elementos.Name = "Pan_Elementos";
            this.Pan_Elementos.Size = new System.Drawing.Size(490, 459);
            this.Pan_Elementos.TabIndex = 34;
            // 
            // Chk_ConfigBtnsBarraHerram
            // 
            this.Chk_ConfigBtnsBarraHerram.AutoSize = true;
            this.Chk_ConfigBtnsBarraHerram.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_ConfigBtnsBarraHerram.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Usuarios, "Cnfg_BarraHerramientas", true));
            this.Chk_ConfigBtnsBarraHerram.Location = new System.Drawing.Point(8, 254);
            this.Chk_ConfigBtnsBarraHerram.Name = "Chk_ConfigBtnsBarraHerram";
            this.Chk_ConfigBtnsBarraHerram.Size = new System.Drawing.Size(427, 20);
            this.Chk_ConfigBtnsBarraHerram.TabIndex = 53;
            this.Chk_ConfigBtnsBarraHerram.Text = "Mostrar Botones Navegacion en Barra de Herramienta";
            this.Chk_ConfigBtnsBarraHerram.UseVisualStyleBackColor = true;
            // 
            // Pan_BotAcpcan_EmpAcc
            // 
            this.Pan_BotAcpcan_EmpAcc.Controls.Add(this.Btn_EmpAcc_Cancelar);
            this.Pan_BotAcpcan_EmpAcc.Controls.Add(this.Btn_EmpAcc_Aceptar);
            this.Pan_BotAcpcan_EmpAcc.Location = new System.Drawing.Point(367, 423);
            this.Pan_BotAcpcan_EmpAcc.Name = "Pan_BotAcpcan_EmpAcc";
            this.Pan_BotAcpcan_EmpAcc.Size = new System.Drawing.Size(72, 30);
            this.Pan_BotAcpcan_EmpAcc.TabIndex = 52;
            this.Pan_BotAcpcan_EmpAcc.Visible = false;
            // 
            // Btn_EmpAcc_Cancelar
            // 
            this.Btn_EmpAcc_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EmpAcc_Cancelar.BackgroundImage")));
            this.Btn_EmpAcc_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EmpAcc_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EmpAcc_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_EmpAcc_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmpAcc_Cancelar.Location = new System.Drawing.Point(36, 2);
            this.Btn_EmpAcc_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EmpAcc_Cancelar.Name = "Btn_EmpAcc_Cancelar";
            this.Btn_EmpAcc_Cancelar.Size = new System.Drawing.Size(24, 24);
            this.Btn_EmpAcc_Cancelar.TabIndex = 13;
            this.Btn_EmpAcc_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpAcc_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_EmpAcc_Cancelar.Click += new System.EventHandler(this.Btn_EmpAcc_Cancelar_Click);
            // 
            // Btn_EmpAcc_Aceptar
            // 
            this.Btn_EmpAcc_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EmpAcc_Aceptar.BackgroundImage")));
            this.Btn_EmpAcc_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EmpAcc_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EmpAcc_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_EmpAcc_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmpAcc_Aceptar.Location = new System.Drawing.Point(4, 2);
            this.Btn_EmpAcc_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EmpAcc_Aceptar.Name = "Btn_EmpAcc_Aceptar";
            this.Btn_EmpAcc_Aceptar.Size = new System.Drawing.Size(24, 24);
            this.Btn_EmpAcc_Aceptar.TabIndex = 12;
            this.Btn_EmpAcc_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpAcc_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_EmpAcc_Aceptar.Click += new System.EventHandler(this.Btn_EmpAcc_Aceptar_Click);
            // 
            // Grd_EmpAccesos
            // 
            this.Grd_EmpAccesos.AllowUserToAddRows = false;
            this.Grd_EmpAccesos.AllowUserToDeleteRows = false;
            this.Grd_EmpAccesos.AutoGenerateColumns = false;
            this.Grd_EmpAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_EmpAccesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.Col_Empresa,
            this.Col_Grupo});
            this.Grd_EmpAccesos.DataSource = this.BS_Emp_Accesos;
            this.Grd_EmpAccesos.Location = new System.Drawing.Point(11, 286);
            this.Grd_EmpAccesos.MultiSelect = false;
            this.Grd_EmpAccesos.Name = "Grd_EmpAccesos";
            this.Grd_EmpAccesos.ReadOnly = true;
            this.Grd_EmpAccesos.RowHeadersVisible = false;
            this.Grd_EmpAccesos.Size = new System.Drawing.Size(459, 137);
            this.Grd_EmpAccesos.TabIndex = 50;
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // Col_Empresa
            // 
            this.Col_Empresa.DataPropertyName = "Cod_Empresa";
            this.Col_Empresa.DataSource = this.BS_Empresas;
            this.Col_Empresa.DisplayMember = "Nombre";
            this.Col_Empresa.FillWeight = 227F;
            this.Col_Empresa.HeaderText = "Empresa";
            this.Col_Empresa.Name = "Col_Empresa";
            this.Col_Empresa.ReadOnly = true;
            this.Col_Empresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Empresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_Empresa.ValueMember = "Codigo";
            this.Col_Empresa.Width = 227;
            // 
            // BS_Empresas
            // 
            this.BS_Empresas.DataSource = typeof(MofinModeloEntorno.Empresas);
            // 
            // Col_Grupo
            // 
            this.Col_Grupo.DataPropertyName = "Cod_Grupo";
            this.Col_Grupo.DataSource = this.BS_Grupos;
            this.Col_Grupo.DisplayMember = "Nombre";
            this.Col_Grupo.FillWeight = 227F;
            this.Col_Grupo.HeaderText = "Grupo";
            this.Col_Grupo.Name = "Col_Grupo";
            this.Col_Grupo.ReadOnly = true;
            this.Col_Grupo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Grupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_Grupo.ValueMember = "Codigo";
            this.Col_Grupo.Width = 227;
            // 
            // BS_Grupos
            // 
            this.BS_Grupos.DataSource = typeof(MofinModeloEntorno.Grupos);
            // 
            // BS_Emp_Accesos
            // 
            this.BS_Emp_Accesos.DataSource = typeof(MofinModeloEntorno.Emp_Accesos);
            // 
            // Grp_FormatoFecha
            // 
            this.Grp_FormatoFecha.Controls.Add(this.Opc_FormFec2);
            this.Grp_FormatoFecha.Controls.Add(this.Opc_FormFec1);
            this.Grp_FormatoFecha.Location = new System.Drawing.Point(108, 191);
            this.Grp_FormatoFecha.Name = "Grp_FormatoFecha";
            this.Grp_FormatoFecha.Size = new System.Drawing.Size(132, 55);
            this.Grp_FormatoFecha.TabIndex = 49;
            this.Grp_FormatoFecha.TabStop = false;
            // 
            // Opc_FormFec2
            // 
            this.Opc_FormFec2.AutoSize = true;
            this.Opc_FormFec2.Location = new System.Drawing.Point(10, 27);
            this.Opc_FormFec2.Name = "Opc_FormFec2";
            this.Opc_FormFec2.Size = new System.Drawing.Size(106, 20);
            this.Opc_FormFec2.TabIndex = 1;
            this.Opc_FormFec2.TabStop = true;
            this.Opc_FormFec2.Text = "MM/DD/AAAA";
            this.Opc_FormFec2.UseVisualStyleBackColor = true;
            // 
            // Opc_FormFec1
            // 
            this.Opc_FormFec1.AutoSize = true;
            this.Opc_FormFec1.Location = new System.Drawing.Point(10, 10);
            this.Opc_FormFec1.Name = "Opc_FormFec1";
            this.Opc_FormFec1.Size = new System.Drawing.Size(106, 20);
            this.Opc_FormFec1.TabIndex = 0;
            this.Opc_FormFec1.TabStop = true;
            this.Opc_FormFec1.Text = "DD/MM/AAAA";
            this.Opc_FormFec1.UseVisualStyleBackColor = true;
            // 
            // Grp_Pais
            // 
            this.Grp_Pais.Controls.Add(this.Opc_Pais2);
            this.Grp_Pais.Controls.Add(this.Opc_Pais1);
            this.Grp_Pais.Location = new System.Drawing.Point(312, 191);
            this.Grp_Pais.Name = "Grp_Pais";
            this.Grp_Pais.Size = new System.Drawing.Size(132, 55);
            this.Grp_Pais.TabIndex = 48;
            this.Grp_Pais.TabStop = false;
            // 
            // Opc_Pais2
            // 
            this.Opc_Pais2.AutoSize = true;
            this.Opc_Pais2.Location = new System.Drawing.Point(10, 27);
            this.Opc_Pais2.Name = "Opc_Pais2";
            this.Opc_Pais2.Size = new System.Drawing.Size(74, 20);
            this.Opc_Pais2.TabIndex = 1;
            this.Opc_Pais2.TabStop = true;
            this.Opc_Pais2.Text = "Panamá";
            this.Opc_Pais2.UseVisualStyleBackColor = true;
            // 
            // Opc_Pais1
            // 
            this.Opc_Pais1.AutoSize = true;
            this.Opc_Pais1.Location = new System.Drawing.Point(10, 10);
            this.Opc_Pais1.Name = "Opc_Pais1";
            this.Opc_Pais1.Size = new System.Drawing.Size(98, 20);
            this.Opc_Pais1.TabIndex = 1;
            this.Opc_Pais1.TabStop = true;
            this.Opc_Pais1.Text = "Venezuela";
            this.Opc_Pais1.UseVisualStyleBackColor = true;
            // 
            // Grp_Idioma
            // 
            this.Grp_Idioma.Controls.Add(this.Opc_Idioma2);
            this.Grp_Idioma.Controls.Add(this.Opc_Idioma1);
            this.Grp_Idioma.Location = new System.Drawing.Point(312, 114);
            this.Grp_Idioma.Name = "Grp_Idioma";
            this.Grp_Idioma.Size = new System.Drawing.Size(132, 55);
            this.Grp_Idioma.TabIndex = 47;
            this.Grp_Idioma.TabStop = false;
            // 
            // Opc_Idioma2
            // 
            this.Opc_Idioma2.AutoSize = true;
            this.Opc_Idioma2.Location = new System.Drawing.Point(10, 27);
            this.Opc_Idioma2.Name = "Opc_Idioma2";
            this.Opc_Idioma2.Size = new System.Drawing.Size(74, 20);
            this.Opc_Idioma2.TabIndex = 1;
            this.Opc_Idioma2.TabStop = true;
            this.Opc_Idioma2.Text = "Inglés";
            this.Opc_Idioma2.UseVisualStyleBackColor = true;
            // 
            // Opc_Idioma1
            // 
            this.Opc_Idioma1.AutoSize = true;
            this.Opc_Idioma1.Location = new System.Drawing.Point(10, 10);
            this.Opc_Idioma1.Name = "Opc_Idioma1";
            this.Opc_Idioma1.Size = new System.Drawing.Size(82, 20);
            this.Opc_Idioma1.TabIndex = 0;
            this.Opc_Idioma1.TabStop = true;
            this.Opc_Idioma1.Text = "Español";
            this.Opc_Idioma1.UseVisualStyleBackColor = true;
            // 
            // Grp_Desktop
            // 
            this.Grp_Desktop.Controls.Add(this.Opc_Desktop2);
            this.Grp_Desktop.Controls.Add(this.Opc_Desktop1);
            this.Grp_Desktop.Location = new System.Drawing.Point(108, 114);
            this.Grp_Desktop.Name = "Grp_Desktop";
            this.Grp_Desktop.Size = new System.Drawing.Size(132, 55);
            this.Grp_Desktop.TabIndex = 46;
            this.Grp_Desktop.TabStop = false;
            // 
            // Opc_Desktop2
            // 
            this.Opc_Desktop2.AutoSize = true;
            this.Opc_Desktop2.Location = new System.Drawing.Point(10, 27);
            this.Opc_Desktop2.Name = "Opc_Desktop2";
            this.Opc_Desktop2.Size = new System.Drawing.Size(98, 20);
            this.Opc_Desktop2.TabIndex = 1;
            this.Opc_Desktop2.TabStop = true;
            this.Opc_Desktop2.Text = "Aleatorio";
            this.Opc_Desktop2.UseVisualStyleBackColor = true;
            // 
            // Opc_Desktop1
            // 
            this.Opc_Desktop1.AutoSize = true;
            this.Opc_Desktop1.Location = new System.Drawing.Point(10, 10);
            this.Opc_Desktop1.Name = "Opc_Desktop1";
            this.Opc_Desktop1.Size = new System.Drawing.Size(58, 20);
            this.Opc_Desktop1.TabIndex = 0;
            this.Opc_Desktop1.TabStop = true;
            this.Opc_Desktop1.Text = "Fijo";
            this.Opc_Desktop1.UseVisualStyleBackColor = true;
            // 
            // Txt_IDUsuario
            // 
            this.Txt_IDUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Usuarios, "ID_Usuario", true));
            this.Txt_IDUsuario.Location = new System.Drawing.Point(108, 2);
            this.Txt_IDUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IDUsuario.MaxLength = 16;
            this.Txt_IDUsuario.Name = "Txt_IDUsuario";
            this.Txt_IDUsuario.Size = new System.Drawing.Size(200, 22);
            this.Txt_IDUsuario.TabIndex = 43;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Usuarios, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(108, 34);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(362, 22);
            this.Txt_Nombre.TabIndex = 44;
            // 
            // Txt_Password
            // 
            this.Txt_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Usuarios, "Password", true));
            this.Txt_Password.Location = new System.Drawing.Point(108, 66);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password.MaxLength = 20;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(200, 22);
            this.Txt_Password.TabIndex = 45;
            // 
            // Pan_BtnsEmpAccesos
            // 
            this.Pan_BtnsEmpAccesos.Controls.Add(this.Btn_EmpAcc_Inc);
            this.Pan_BtnsEmpAccesos.Controls.Add(this.Btn_EmpAcc_Eli);
            this.Pan_BtnsEmpAccesos.Controls.Add(this.Btn_EmpAcc_Mod);
            this.Pan_BtnsEmpAccesos.Location = new System.Drawing.Point(197, 422);
            this.Pan_BtnsEmpAccesos.Name = "Pan_BtnsEmpAccesos";
            this.Pan_BtnsEmpAccesos.Size = new System.Drawing.Size(99, 34);
            this.Pan_BtnsEmpAccesos.TabIndex = 51;
            this.Pan_BtnsEmpAccesos.Visible = false;
            // 
            // Btn_EmpAcc_Inc
            // 
            this.Btn_EmpAcc_Inc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EmpAcc_Inc.BackgroundImage")));
            this.Btn_EmpAcc_Inc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EmpAcc_Inc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EmpAcc_Inc.FlatAppearance.BorderSize = 0;
            this.Btn_EmpAcc_Inc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Inc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Inc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmpAcc_Inc.Location = new System.Drawing.Point(4, 4);
            this.Btn_EmpAcc_Inc.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EmpAcc_Inc.Name = "Btn_EmpAcc_Inc";
            this.Btn_EmpAcc_Inc.Size = new System.Drawing.Size(24, 24);
            this.Btn_EmpAcc_Inc.TabIndex = 15;
            this.Btn_EmpAcc_Inc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpAcc_Inc.UseVisualStyleBackColor = true;
            this.Btn_EmpAcc_Inc.Click += new System.EventHandler(this.Btn_EmpAcc_Inc_Click);
            // 
            // Btn_EmpAcc_Eli
            // 
            this.Btn_EmpAcc_Eli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EmpAcc_Eli.BackgroundImage")));
            this.Btn_EmpAcc_Eli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EmpAcc_Eli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EmpAcc_Eli.FlatAppearance.BorderSize = 0;
            this.Btn_EmpAcc_Eli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Eli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Eli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmpAcc_Eli.Location = new System.Drawing.Point(68, 4);
            this.Btn_EmpAcc_Eli.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EmpAcc_Eli.Name = "Btn_EmpAcc_Eli";
            this.Btn_EmpAcc_Eli.Size = new System.Drawing.Size(24, 24);
            this.Btn_EmpAcc_Eli.TabIndex = 17;
            this.Btn_EmpAcc_Eli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpAcc_Eli.UseVisualStyleBackColor = true;
            this.Btn_EmpAcc_Eli.Click += new System.EventHandler(this.Btn_EmpAcc_Eli_Click);
            // 
            // Btn_EmpAcc_Mod
            // 
            this.Btn_EmpAcc_Mod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_EmpAcc_Mod.BackgroundImage")));
            this.Btn_EmpAcc_Mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EmpAcc_Mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EmpAcc_Mod.FlatAppearance.BorderSize = 0;
            this.Btn_EmpAcc_Mod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpAcc_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmpAcc_Mod.Location = new System.Drawing.Point(36, 4);
            this.Btn_EmpAcc_Mod.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EmpAcc_Mod.Name = "Btn_EmpAcc_Mod";
            this.Btn_EmpAcc_Mod.Size = new System.Drawing.Size(24, 24);
            this.Btn_EmpAcc_Mod.TabIndex = 16;
            this.Btn_EmpAcc_Mod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpAcc_Mod.UseVisualStyleBackColor = true;
            this.Btn_EmpAcc_Mod.Click += new System.EventHandler(this.Btn_EmpAcc_Mod_Click);
            // 
            // BS_Grupo_Opciones
            // 
            this.BS_Grupo_Opciones.DataSource = typeof(MofinModeloEntorno.Grupo_Opciones);
            // 
            // Frm_Usuarios
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(827, 537);
            this.Controls.Add(this.Lbl_PaisUso);
            this.Controls.Add(this.Lbl_FormatoFecha);
            this.Controls.Add(this.Lbl_FondoEscritorio);
            this.Controls.Add(this.Lbl_Idioma);
            this.Controls.Add(this.Grd_Usuarios);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(this.Lbl_IDUsuario);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Pan_Elementos);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Usuarios";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPress_JF);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Usuarios)).EndInit();
            this.Pan_Elementos.ResumeLayout(false);
            this.Pan_Elementos.PerformLayout();
            this.Pan_BotAcpcan_EmpAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_EmpAccesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Emp_Accesos)).EndInit();
            this.Grp_FormatoFecha.ResumeLayout(false);
            this.Grp_FormatoFecha.PerformLayout();
            this.Grp_Pais.ResumeLayout(false);
            this.Grp_Pais.PerformLayout();
            this.Grp_Idioma.ResumeLayout(false);
            this.Grp_Idioma.PerformLayout();
            this.Grp_Desktop.ResumeLayout(false);
            this.Grp_Desktop.PerformLayout();
            this.Pan_BtnsEmpAccesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupo_Opciones)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator ts_Sep1;
        private System.Windows.Forms.ToolStripButton TSB_Agregar;
        private System.Windows.Forms.ToolStripButton TSB_Modificar;
        private System.Windows.Forms.ToolStripButton TSB_Eliminar;
        private System.Windows.Forms.ToolStripButton TSB_Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_Salir;
        private System.Windows.Forms.BindingSource BS_Usuarios;
        private System.Windows.Forms.DataGridView Grd_Usuarios;
        private System.Windows.Forms.Panel Pan_Elementos;
        private System.Windows.Forms.GroupBox Grp_FormatoFecha;
        private System.Windows.Forms.RadioButton Opc_FormFec2;
        private System.Windows.Forms.RadioButton Opc_FormFec1;
        private System.Windows.Forms.GroupBox Grp_Pais;
        private System.Windows.Forms.RadioButton Opc_Pais2;
        private System.Windows.Forms.RadioButton Opc_Pais1;
        private System.Windows.Forms.GroupBox Grp_Idioma;
        private System.Windows.Forms.RadioButton Opc_Idioma2;
        private System.Windows.Forms.RadioButton Opc_Idioma1;
        private System.Windows.Forms.GroupBox Grp_Desktop;
        private System.Windows.Forms.RadioButton Opc_Desktop2;
        private System.Windows.Forms.RadioButton Opc_Desktop1;
        private System.Windows.Forms.TextBox Txt_IDUsuario;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_IDUsuario;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_FondoEscritorio;
        private System.Windows.Forms.Label Lbl_Idioma;
        private System.Windows.Forms.Label Lbl_PaisUso;
        private System.Windows.Forms.Label Lbl_FormatoFecha;
        private System.Windows.Forms.BindingSource BS_Grupo_Opciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Nombre;
        private System.Windows.Forms.DataGridView Grd_EmpAccesos;
        private System.Windows.Forms.BindingSource BS_Emp_Accesos;
        private System.Windows.Forms.BindingSource BS_Empresas;
        private System.Windows.Forms.BindingSource BS_Grupos;
        private System.Windows.Forms.Panel Pan_BtnsEmpAccesos;
        private System.Windows.Forms.Button Btn_EmpAcc_Inc;
        private System.Windows.Forms.Button Btn_EmpAcc_Eli;
        private System.Windows.Forms.Button Btn_EmpAcc_Mod;
        private System.Windows.Forms.Panel Pan_BotAcpcan_EmpAcc;
        private System.Windows.Forms.Button Btn_EmpAcc_Cancelar;
        private System.Windows.Forms.Button Btn_EmpAcc_Aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Empresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Grupo;
        private System.Windows.Forms.CheckBox Chk_ConfigBtnsBarraHerram;
    }
}