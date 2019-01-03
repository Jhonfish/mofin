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
            System.Windows.Forms.Label Lbl_IDUsuario;
            System.Windows.Forms.Label Lbl_Nombre;
            System.Windows.Forms.Label Lbl_Password;
            System.Windows.Forms.Label Lbl_FondoEscritorio;
            System.Windows.Forms.Label Lbl_Idioma;
            System.Windows.Forms.Label Lbl_PaisUso;
            System.Windows.Forms.Label Lbl_FormatoFecha;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_IDUsuario = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
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
            this.Grp_Desktop = new System.Windows.Forms.GroupBox();
            this.Opc_Desktop2 = new System.Windows.Forms.RadioButton();
            this.Opc_Desktop1 = new System.Windows.Forms.RadioButton();
            this.Grp_Idioma = new System.Windows.Forms.GroupBox();
            this.Opc_Idioma2 = new System.Windows.Forms.RadioButton();
            this.Opc_Idioma1 = new System.Windows.Forms.RadioButton();
            this.Grp_Pais = new System.Windows.Forms.GroupBox();
            this.Opc_Pais2 = new System.Windows.Forms.RadioButton();
            this.Opc_Pais1 = new System.Windows.Forms.RadioButton();
            this.Grp_FormatoFecha = new System.Windows.Forms.GroupBox();
            this.Opc_FormFec2 = new System.Windows.Forms.RadioButton();
            this.Opc_FormFec1 = new System.Windows.Forms.RadioButton();
            this.Chk_Sonido = new System.Windows.Forms.CheckBox();
            this.BS_Usuarios = new System.Windows.Forms.BindingSource(this.components);
            this.Grd_Usuarios = new System.Windows.Forms.DataGridView();
            this.ID_Sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnfg_Desktop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnfg_Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnfg_PaisUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnfg_FormFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lbl_IDUsuario = new System.Windows.Forms.Label();
            Lbl_Nombre = new System.Windows.Forms.Label();
            Lbl_Password = new System.Windows.Forms.Label();
            Lbl_FondoEscritorio = new System.Windows.Forms.Label();
            Lbl_Idioma = new System.Windows.Forms.Label();
            Lbl_PaisUso = new System.Windows.Forms.Label();
            Lbl_FormatoFecha = new System.Windows.Forms.Label();
            this.TS_BarraHerramientas.SuspendLayout();
            this.Grp_Desktop.SuspendLayout();
            this.Grp_Idioma.SuspendLayout();
            this.Grp_Pais.SuspendLayout();
            this.Grp_FormatoFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_IDUsuario
            // 
            Lbl_IDUsuario.AutoSize = true;
            Lbl_IDUsuario.Location = new System.Drawing.Point(34, 71);
            Lbl_IDUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_IDUsuario.Name = "Lbl_IDUsuario";
            Lbl_IDUsuario.Size = new System.Drawing.Size(96, 16);
            Lbl_IDUsuario.TabIndex = 21;
            Lbl_IDUsuario.Text = "ID Usuario:";
            // 
            // Lbl_Nombre
            // 
            Lbl_Nombre.AutoSize = true;
            Lbl_Nombre.Location = new System.Drawing.Point(34, 103);
            Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Nombre.Name = "Lbl_Nombre";
            Lbl_Nombre.Size = new System.Drawing.Size(64, 16);
            Lbl_Nombre.TabIndex = 23;
            Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Location = new System.Drawing.Point(34, 135);
            Lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new System.Drawing.Size(80, 16);
            Lbl_Password.TabIndex = 25;
            Lbl_Password.Text = "Password:";
            // 
            // Lbl_FondoEscritorio
            // 
            Lbl_FondoEscritorio.AutoSize = true;
            Lbl_FondoEscritorio.Location = new System.Drawing.Point(34, 173);
            Lbl_FondoEscritorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_FondoEscritorio.Name = "Lbl_FondoEscritorio";
            Lbl_FondoEscritorio.Size = new System.Drawing.Size(168, 16);
            Lbl_FondoEscritorio.TabIndex = 27;
            Lbl_FondoEscritorio.Text = "Fondo de Escritorio:";
            // 
            // Lbl_Idioma
            // 
            Lbl_Idioma.AutoSize = true;
            Lbl_Idioma.Location = new System.Drawing.Point(34, 236);
            Lbl_Idioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_Idioma.Name = "Lbl_Idioma";
            Lbl_Idioma.Size = new System.Drawing.Size(64, 16);
            Lbl_Idioma.TabIndex = 29;
            Lbl_Idioma.Text = "Idioma:";
            // 
            // Lbl_PaisUso
            // 
            Lbl_PaisUso.AutoSize = true;
            Lbl_PaisUso.Location = new System.Drawing.Point(34, 299);
            Lbl_PaisUso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_PaisUso.Name = "Lbl_PaisUso";
            Lbl_PaisUso.Size = new System.Drawing.Size(80, 16);
            Lbl_PaisUso.TabIndex = 31;
            Lbl_PaisUso.Text = "Pais Uso:";
            // 
            // Lbl_FormatoFecha
            // 
            Lbl_FormatoFecha.AutoSize = true;
            Lbl_FormatoFecha.Location = new System.Drawing.Point(34, 362);
            Lbl_FormatoFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_FormatoFecha.Name = "Lbl_FormatoFecha";
            Lbl_FormatoFecha.Size = new System.Drawing.Size(144, 16);
            Lbl_FormatoFecha.TabIndex = 33;
            Lbl_FormatoFecha.Text = "Formato de Fecha:";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(605, 395);
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(523, 395);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 19;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Txt_IDUsuario
            // 
            this.Txt_IDUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Usuarios, "ID_Usuario", true));
            this.Txt_IDUsuario.Location = new System.Drawing.Point(136, 71);
            this.Txt_IDUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IDUsuario.Name = "Txt_IDUsuario";
            this.Txt_IDUsuario.Size = new System.Drawing.Size(200, 22);
            this.Txt_IDUsuario.TabIndex = 22;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Usuarios, "Nombre", true));
            this.Txt_Nombre.Location = new System.Drawing.Point(136, 103);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(362, 22);
            this.Txt_Nombre.TabIndex = 24;
            // 
            // Txt_Password
            // 
            this.Txt_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Usuarios, "Password", true));
            this.Txt_Password.Location = new System.Drawing.Point(136, 135);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(200, 22);
            this.Txt_Password.TabIndex = 26;
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
            // Grp_Desktop
            // 
            this.Grp_Desktop.Controls.Add(this.Opc_Desktop2);
            this.Grp_Desktop.Controls.Add(this.Opc_Desktop1);
            this.Grp_Desktop.Location = new System.Drawing.Point(206, 161);
            this.Grp_Desktop.Name = "Grp_Desktop";
            this.Grp_Desktop.Size = new System.Drawing.Size(132, 57);
            this.Grp_Desktop.TabIndex = 38;
            this.Grp_Desktop.TabStop = false;
            // 
            // Opc_Desktop2
            // 
            this.Opc_Desktop2.AutoSize = true;
            this.Opc_Desktop2.Location = new System.Drawing.Point(10, 33);
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
            // Grp_Idioma
            // 
            this.Grp_Idioma.Controls.Add(this.Opc_Idioma2);
            this.Grp_Idioma.Controls.Add(this.Opc_Idioma1);
            this.Grp_Idioma.Location = new System.Drawing.Point(206, 224);
            this.Grp_Idioma.Name = "Grp_Idioma";
            this.Grp_Idioma.Size = new System.Drawing.Size(132, 57);
            this.Grp_Idioma.TabIndex = 39;
            this.Grp_Idioma.TabStop = false;
            // 
            // Opc_Idioma2
            // 
            this.Opc_Idioma2.AutoSize = true;
            this.Opc_Idioma2.Location = new System.Drawing.Point(10, 33);
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
            // Grp_Pais
            // 
            this.Grp_Pais.Controls.Add(this.Opc_Pais2);
            this.Grp_Pais.Controls.Add(this.Opc_Pais1);
            this.Grp_Pais.Location = new System.Drawing.Point(206, 287);
            this.Grp_Pais.Name = "Grp_Pais";
            this.Grp_Pais.Size = new System.Drawing.Size(132, 57);
            this.Grp_Pais.TabIndex = 40;
            this.Grp_Pais.TabStop = false;
            // 
            // Opc_Pais2
            // 
            this.Opc_Pais2.AutoSize = true;
            this.Opc_Pais2.Location = new System.Drawing.Point(10, 33);
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
            this.Opc_Pais1.TabIndex = 0;
            this.Opc_Pais1.TabStop = true;
            this.Opc_Pais1.Text = "Venezuela";
            this.Opc_Pais1.UseVisualStyleBackColor = true;
            // 
            // Grp_FormatoFecha
            // 
            this.Grp_FormatoFecha.Controls.Add(this.Opc_FormFec2);
            this.Grp_FormatoFecha.Controls.Add(this.Opc_FormFec1);
            this.Grp_FormatoFecha.Location = new System.Drawing.Point(206, 350);
            this.Grp_FormatoFecha.Name = "Grp_FormatoFecha";
            this.Grp_FormatoFecha.Size = new System.Drawing.Size(132, 57);
            this.Grp_FormatoFecha.TabIndex = 41;
            this.Grp_FormatoFecha.TabStop = false;
            // 
            // Opc_FormFec2
            // 
            this.Opc_FormFec2.AutoSize = true;
            this.Opc_FormFec2.Location = new System.Drawing.Point(10, 33);
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
            // Chk_Sonido
            // 
            this.Chk_Sonido.AutoSize = true;
            this.Chk_Sonido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_Sonido.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_Usuarios, "Cnfg_SonidoClick", true));
            this.Chk_Sonido.Location = new System.Drawing.Point(34, 413);
            this.Chk_Sonido.Name = "Chk_Sonido";
            this.Chk_Sonido.Size = new System.Drawing.Size(187, 20);
            this.Chk_Sonido.TabIndex = 42;
            this.Chk_Sonido.Text = "Sonido de Click:    ";
            this.Chk_Sonido.UseVisualStyleBackColor = true;
            // 
            // BS_Usuarios
            // 
            this.BS_Usuarios.DataSource = typeof(MofinModeloEntorno.Usuarios);
            // 
            // Grd_Usuarios
            // 
            this.Grd_Usuarios.AllowUserToAddRows = false;
            this.Grd_Usuarios.AllowUserToDeleteRows = false;
            this.Grd_Usuarios.AllowUserToResizeRows = false;
            this.Grd_Usuarios.AutoGenerateColumns = false;
            this.Grd_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grd_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Sistema,
            this.ID_Usuario,
            this.Nombre,
            this.Password,
            this.Cnfg_Desktop,
            this.Cnfg_Idioma,
            this.Cnfg_PaisUso,
            this.Cnfg_FormFecha,
            this.dataGridViewTextBoxColumn9});
            this.Grd_Usuarios.DataSource = this.BS_Usuarios;
            this.Grd_Usuarios.Location = new System.Drawing.Point(360, 142);
            this.Grd_Usuarios.Name = "Grd_Usuarios";
            this.Grd_Usuarios.ReadOnly = true;
            this.Grd_Usuarios.RowHeadersVisible = false;
            this.Grd_Usuarios.Size = new System.Drawing.Size(453, 246);
            this.Grd_Usuarios.TabIndex = 43;
            this.Grd_Usuarios.CurrentCellChanged += new System.EventHandler(this.Grd_Usuarios_CurrentCellChanged);
            // 
            // ID_Sistema
            // 
            this.ID_Sistema.DataPropertyName = "ID_Sistema";
            this.ID_Sistema.HeaderText = "ID_Sistema";
            this.ID_Sistema.Name = "ID_Sistema";
            this.ID_Sistema.ReadOnly = true;
            this.ID_Sistema.Width = 113;
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.DataPropertyName = "ID_Usuario";
            this.ID_Usuario.HeaderText = "ID_Usuario";
            this.ID_Usuario.Name = "ID_Usuario";
            this.ID_Usuario.ReadOnly = true;
            this.ID_Usuario.Width = 113;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 81;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 97;
            // 
            // Cnfg_Desktop
            // 
            this.Cnfg_Desktop.DataPropertyName = "Cnfg_Desktop";
            this.Cnfg_Desktop.HeaderText = "Cnfg_Desktop";
            this.Cnfg_Desktop.Name = "Cnfg_Desktop";
            this.Cnfg_Desktop.ReadOnly = true;
            this.Cnfg_Desktop.Width = 129;
            // 
            // Cnfg_Idioma
            // 
            this.Cnfg_Idioma.DataPropertyName = "Cnfg_Idioma";
            this.Cnfg_Idioma.HeaderText = "Cnfg_Idioma";
            this.Cnfg_Idioma.Name = "Cnfg_Idioma";
            this.Cnfg_Idioma.ReadOnly = true;
            this.Cnfg_Idioma.Width = 121;
            // 
            // Cnfg_PaisUso
            // 
            this.Cnfg_PaisUso.DataPropertyName = "Cnfg_PaisUso";
            this.Cnfg_PaisUso.HeaderText = "Cnfg_PaisUso";
            this.Cnfg_PaisUso.Name = "Cnfg_PaisUso";
            this.Cnfg_PaisUso.ReadOnly = true;
            this.Cnfg_PaisUso.Width = 129;
            // 
            // Cnfg_FormFecha
            // 
            this.Cnfg_FormFecha.DataPropertyName = "Cnfg_FormFecha";
            this.Cnfg_FormFecha.HeaderText = "Cnfg_FormFecha";
            this.Cnfg_FormFecha.Name = "Cnfg_FormFecha";
            this.Cnfg_FormFecha.ReadOnly = true;
            this.Cnfg_FormFecha.Width = 145;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cnfg_SonidoClick";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cnfg_SonidoClick";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 161;
            // 
            // Frm_Usuarios
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(833, 456);
            this.Controls.Add(this.Grd_Usuarios);
            this.Controls.Add(this.Chk_Sonido);
            this.Controls.Add(this.Grp_FormatoFecha);
            this.Controls.Add(this.Grp_Pais);
            this.Controls.Add(this.Grp_Idioma);
            this.Controls.Add(this.Grp_Desktop);
            this.Controls.Add(this.TS_BarraHerramientas);
            this.Controls.Add(Lbl_IDUsuario);
            this.Controls.Add(this.Txt_IDUsuario);
            this.Controls.Add(Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(Lbl_Password);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(Lbl_FondoEscritorio);
            this.Controls.Add(Lbl_Idioma);
            this.Controls.Add(Lbl_PaisUso);
            this.Controls.Add(Lbl_FormatoFecha);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Usuarios";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Frm_Usuarios_Load);
            this.TS_BarraHerramientas.ResumeLayout(false);
            this.TS_BarraHerramientas.PerformLayout();
            this.Grp_Desktop.ResumeLayout(false);
            this.Grp_Desktop.PerformLayout();
            this.Grp_Idioma.ResumeLayout(false);
            this.Grp_Idioma.PerformLayout();
            this.Grp_Pais.ResumeLayout(false);
            this.Grp_Pais.PerformLayout();
            this.Grp_FormatoFecha.ResumeLayout(false);
            this.Grp_FormatoFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.TextBox Txt_IDUsuario;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Password;
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
        private System.Windows.Forms.GroupBox Grp_Desktop;
        private System.Windows.Forms.RadioButton Opc_Desktop2;
        private System.Windows.Forms.RadioButton Opc_Desktop1;
        private System.Windows.Forms.GroupBox Grp_Idioma;
        private System.Windows.Forms.RadioButton Opc_Idioma2;
        private System.Windows.Forms.RadioButton Opc_Idioma1;
        private System.Windows.Forms.GroupBox Grp_Pais;
        private System.Windows.Forms.RadioButton Opc_Pais2;
        private System.Windows.Forms.RadioButton Opc_Pais1;
        private System.Windows.Forms.GroupBox Grp_FormatoFecha;
        private System.Windows.Forms.RadioButton Opc_FormFec2;
        private System.Windows.Forms.RadioButton Opc_FormFec1;
        private System.Windows.Forms.CheckBox Chk_Sonido;
        private System.Windows.Forms.BindingSource BS_Usuarios;
        private System.Windows.Forms.DataGridView Grd_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnfg_Desktop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnfg_Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnfg_PaisUso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnfg_FormFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}