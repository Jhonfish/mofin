namespace MOFIN
{
    partial class Frm_Desktop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Desktop));
            this.TS_MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Mnu_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Arc_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Arc_SelEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Arc_Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.Arc_VistaPrevia = new System.Windows.Forms.ToolStripMenuItem();
            this.Arc_ConfigImpres = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Arc_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Edi_Deshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.Edi_Rehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Edi_Cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.Edi_Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Edi_Pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Edi_SelecTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver_BarraStado = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Cli_Monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.Cli_Busqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Operaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Ope_Financieras = new System.Windows.Forms.ToolStripMenuItem();
            this.Ope_Transaccionales = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_TablasMaestras = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab_Maestros = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Herramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.Her_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Her_Grupos = new System.Windows.Forms.ToolStripMenuItem();
            this.Her_Empresas = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Ventanas = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ven_Cascada = new System.Windows.Forms.ToolStripMenuItem();
            this.Ven_MosVert = new System.Windows.Forms.ToolStripMenuItem();
            this.Ven_MosHor = new System.Windows.Forms.ToolStripMenuItem();
            this.Ven_CerrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Ayu_Acerca = new System.Windows.Forms.ToolStripMenuItem();
            this.SS_BarradeEstadoPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Detalle1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TS_MenuPrincipal.SuspendLayout();
            this.SS_BarradeEstadoPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS_MenuPrincipal
            // 
            this.TS_MenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.TS_MenuPrincipal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Archivo,
            this.Mnu_Editar,
            this.Mnu_Ver,
            this.Mnu_Clientes,
            this.Mnu_Operaciones,
            this.Mnu_TablasMaestras,
            this.Mnu_Herramientas,
            this.Mnu_Ventanas,
            this.Mnu_Ayuda});
            this.TS_MenuPrincipal.Location = new System.Drawing.Point(3, 60);
            this.TS_MenuPrincipal.MdiWindowListItem = this.Mnu_Ventanas;
            this.TS_MenuPrincipal.Name = "TS_MenuPrincipal";
            this.TS_MenuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.TS_MenuPrincipal.Size = new System.Drawing.Size(837, 24);
            this.TS_MenuPrincipal.TabIndex = 0;
            this.TS_MenuPrincipal.Text = "MenuStrip";
            // 
            // Mnu_Archivo
            // 
            this.Mnu_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arc_Abrir,
            this.toolStripSeparator3,
            this.Arc_SelEmpresa,
            this.toolStripSeparator4,
            this.Arc_Imprimir,
            this.Arc_VistaPrevia,
            this.Arc_ConfigImpres,
            this.toolStripSeparator5,
            this.Arc_Salir});
            this.Mnu_Archivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mnu_Archivo.Name = "Mnu_Archivo";
            this.Mnu_Archivo.Size = new System.Drawing.Size(76, 20);
            this.Mnu_Archivo.Text = "&Archivo";
            // 
            // Arc_Abrir
            // 
            this.Arc_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Arc_Abrir.Image")));
            this.Arc_Abrir.ImageTransparentColor = System.Drawing.Color.Black;
            this.Arc_Abrir.Name = "Arc_Abrir";
            this.Arc_Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Arc_Abrir.Size = new System.Drawing.Size(276, 22);
            this.Arc_Abrir.Text = "&Abrir";
            this.Arc_Abrir.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(273, 6);
            // 
            // Arc_SelEmpresa
            // 
            this.Arc_SelEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("Arc_SelEmpresa.Image")));
            this.Arc_SelEmpresa.Name = "Arc_SelEmpresa";
            this.Arc_SelEmpresa.Size = new System.Drawing.Size(276, 22);
            this.Arc_SelEmpresa.Text = "Selecionar Empresa";
            this.Arc_SelEmpresa.Click += new System.EventHandler(this.Arc_SelEmpresa_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(273, 6);
            // 
            // Arc_Imprimir
            // 
            this.Arc_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Arc_Imprimir.Image")));
            this.Arc_Imprimir.ImageTransparentColor = System.Drawing.Color.Black;
            this.Arc_Imprimir.Name = "Arc_Imprimir";
            this.Arc_Imprimir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Arc_Imprimir.Size = new System.Drawing.Size(276, 22);
            this.Arc_Imprimir.Text = "&Imprimir";
            // 
            // Arc_VistaPrevia
            // 
            this.Arc_VistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("Arc_VistaPrevia.Image")));
            this.Arc_VistaPrevia.ImageTransparentColor = System.Drawing.Color.Black;
            this.Arc_VistaPrevia.Name = "Arc_VistaPrevia";
            this.Arc_VistaPrevia.Size = new System.Drawing.Size(276, 22);
            this.Arc_VistaPrevia.Text = "&Vista previa de impresión";
            // 
            // Arc_ConfigImpres
            // 
            this.Arc_ConfigImpres.Name = "Arc_ConfigImpres";
            this.Arc_ConfigImpres.Size = new System.Drawing.Size(276, 22);
            this.Arc_ConfigImpres.Text = "Configurar impresión";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(273, 6);
            // 
            // Arc_Salir
            // 
            this.Arc_Salir.Name = "Arc_Salir";
            this.Arc_Salir.Size = new System.Drawing.Size(276, 22);
            this.Arc_Salir.Text = "&Salir";
            this.Arc_Salir.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // Mnu_Editar
            // 
            this.Mnu_Editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edi_Deshacer,
            this.Edi_Rehacer,
            this.toolStripSeparator6,
            this.Edi_Cortar,
            this.Edi_Copiar,
            this.Edi_Pegar,
            this.toolStripSeparator7,
            this.Edi_SelecTodo});
            this.Mnu_Editar.Name = "Mnu_Editar";
            this.Mnu_Editar.Size = new System.Drawing.Size(68, 20);
            this.Mnu_Editar.Text = "&Editar";
            // 
            // Edi_Deshacer
            // 
            this.Edi_Deshacer.Image = ((System.Drawing.Image)(resources.GetObject("Edi_Deshacer.Image")));
            this.Edi_Deshacer.ImageTransparentColor = System.Drawing.Color.Black;
            this.Edi_Deshacer.Name = "Edi_Deshacer";
            this.Edi_Deshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Edi_Deshacer.Size = new System.Drawing.Size(260, 22);
            this.Edi_Deshacer.Text = "&Deshacer";
            // 
            // Edi_Rehacer
            // 
            this.Edi_Rehacer.Image = ((System.Drawing.Image)(resources.GetObject("Edi_Rehacer.Image")));
            this.Edi_Rehacer.ImageTransparentColor = System.Drawing.Color.Black;
            this.Edi_Rehacer.Name = "Edi_Rehacer";
            this.Edi_Rehacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Edi_Rehacer.Size = new System.Drawing.Size(260, 22);
            this.Edi_Rehacer.Text = "&Rehacer";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(257, 6);
            // 
            // Edi_Cortar
            // 
            this.Edi_Cortar.Image = ((System.Drawing.Image)(resources.GetObject("Edi_Cortar.Image")));
            this.Edi_Cortar.ImageTransparentColor = System.Drawing.Color.Black;
            this.Edi_Cortar.Name = "Edi_Cortar";
            this.Edi_Cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Edi_Cortar.Size = new System.Drawing.Size(260, 22);
            this.Edi_Cortar.Text = "Cor&tar";
            this.Edi_Cortar.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // Edi_Copiar
            // 
            this.Edi_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("Edi_Copiar.Image")));
            this.Edi_Copiar.ImageTransparentColor = System.Drawing.Color.Black;
            this.Edi_Copiar.Name = "Edi_Copiar";
            this.Edi_Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Edi_Copiar.Size = new System.Drawing.Size(260, 22);
            this.Edi_Copiar.Text = "&Copiar";
            this.Edi_Copiar.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // Edi_Pegar
            // 
            this.Edi_Pegar.Image = ((System.Drawing.Image)(resources.GetObject("Edi_Pegar.Image")));
            this.Edi_Pegar.ImageTransparentColor = System.Drawing.Color.Black;
            this.Edi_Pegar.Name = "Edi_Pegar";
            this.Edi_Pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Edi_Pegar.Size = new System.Drawing.Size(260, 22);
            this.Edi_Pegar.Text = "&Pegar";
            this.Edi_Pegar.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(257, 6);
            // 
            // Edi_SelecTodo
            // 
            this.Edi_SelecTodo.Name = "Edi_SelecTodo";
            this.Edi_SelecTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Edi_SelecTodo.Size = new System.Drawing.Size(260, 22);
            this.Edi_SelecTodo.Text = "Seleccionar &todo";
            // 
            // Mnu_Ver
            // 
            this.Mnu_Ver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ver_BarraStado});
            this.Mnu_Ver.Name = "Mnu_Ver";
            this.Mnu_Ver.Size = new System.Drawing.Size(44, 20);
            this.Mnu_Ver.Text = "&Ver";
            // 
            // Ver_BarraStado
            // 
            this.Ver_BarraStado.Checked = true;
            this.Ver_BarraStado.CheckOnClick = true;
            this.Ver_BarraStado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ver_BarraStado.Name = "Ver_BarraStado";
            this.Ver_BarraStado.Size = new System.Drawing.Size(196, 22);
            this.Ver_BarraStado.Text = "&Barra de estado";
            this.Ver_BarraStado.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // Mnu_Clientes
            // 
            this.Mnu_Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cli_Monitor,
            this.Cli_Busqueda});
            this.Mnu_Clientes.Name = "Mnu_Clientes";
            this.Mnu_Clientes.Size = new System.Drawing.Size(84, 20);
            this.Mnu_Clientes.Text = "&Clientes";
            // 
            // Cli_Monitor
            // 
            this.Cli_Monitor.Name = "Cli_Monitor";
            this.Cli_Monitor.Size = new System.Drawing.Size(236, 22);
            this.Cli_Monitor.Text = "Monitor de Clientes";
            this.Cli_Monitor.Click += new System.EventHandler(this.monitorDeClientesToolStripMenuItem_Click);
            // 
            // Cli_Busqueda
            // 
            this.Cli_Busqueda.Name = "Cli_Busqueda";
            this.Cli_Busqueda.Size = new System.Drawing.Size(236, 22);
            this.Cli_Busqueda.Text = "Búsqueda de Clientes";
            this.Cli_Busqueda.Click += new System.EventHandler(this.búsquedaDeClientesToolStripMenuItem_Click);
            // 
            // Mnu_Operaciones
            // 
            this.Mnu_Operaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ope_Financieras,
            this.Ope_Transaccionales});
            this.Mnu_Operaciones.Name = "Mnu_Operaciones";
            this.Mnu_Operaciones.Size = new System.Drawing.Size(108, 20);
            this.Mnu_Operaciones.Text = "&Operaciones";
            // 
            // Ope_Financieras
            // 
            this.Ope_Financieras.Name = "Ope_Financieras";
            this.Ope_Financieras.Size = new System.Drawing.Size(196, 22);
            this.Ope_Financieras.Text = "Financieras";
            this.Ope_Financieras.Click += new System.EventHandler(this.financierasToolStripMenuItem_Click);
            // 
            // Ope_Transaccionales
            // 
            this.Ope_Transaccionales.Name = "Ope_Transaccionales";
            this.Ope_Transaccionales.Size = new System.Drawing.Size(196, 22);
            this.Ope_Transaccionales.Text = "Transaccionales";
            // 
            // Mnu_TablasMaestras
            // 
            this.Mnu_TablasMaestras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab_Maestros});
            this.Mnu_TablasMaestras.Name = "Mnu_TablasMaestras";
            this.Mnu_TablasMaestras.Size = new System.Drawing.Size(140, 20);
            this.Mnu_TablasMaestras.Text = "Tablas &Maestras";
            this.Mnu_TablasMaestras.Visible = MOFIN_LIB.Entorno.vs_Maestro;
            // 
            // Tab_Maestros
            // 
            this.Tab_Maestros.Name = "Tab_Maestros";
            this.Tab_Maestros.Size = new System.Drawing.Size(196, 22);
            this.Tab_Maestros.Text = "Tablas Maestras";
            this.Tab_Maestros.Click += new System.EventHandler(this.tablasMaestrasToolStripMenuItem_Click);
            // 
            // Mnu_Herramientas
            // 
            this.Mnu_Herramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Her_Usuarios,
            this.Her_Grupos,
            this.Her_Empresas});
            this.Mnu_Herramientas.Name = "Mnu_Herramientas";
            this.Mnu_Herramientas.Size = new System.Drawing.Size(116, 20);
            this.Mnu_Herramientas.Text = "&Herramientas";
            // 
            // Her_Usuarios
            // 
            this.Her_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Her_Usuarios.Image")));
            this.Her_Usuarios.Name = "Her_Usuarios";
            this.Her_Usuarios.Size = new System.Drawing.Size(188, 22);
            this.Her_Usuarios.Text = "Usuarios";
            this.Her_Usuarios.Click += new System.EventHandler(this.Her_Usuarios_Click);
            // 
            // Her_Grupos
            // 
            this.Her_Grupos.Image = ((System.Drawing.Image)(resources.GetObject("Her_Grupos.Image")));
            this.Her_Grupos.Name = "Her_Grupos";
            this.Her_Grupos.Size = new System.Drawing.Size(188, 22);
            this.Her_Grupos.Text = "Gupos/Perfiles";
            this.Her_Grupos.Click += new System.EventHandler(this.Her_Grupos_Click);
            // 
            // Her_Empresas
            // 
            this.Her_Empresas.Image = ((System.Drawing.Image)(resources.GetObject("Her_Empresas.Image")));
            this.Her_Empresas.Name = "Her_Empresas";
            this.Her_Empresas.Size = new System.Drawing.Size(188, 22);
            this.Her_Empresas.Text = "Empresas";
            this.Her_Empresas.Click += new System.EventHandler(this.Her_Empresas_Click);
            // 
            // Mnu_Ventanas
            // 
            this.Mnu_Ventanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.Ven_Cascada,
            this.Ven_MosVert,
            this.Ven_MosHor,
            this.Ven_CerrarTodo});
            this.Mnu_Ventanas.Name = "Mnu_Ventanas";
            this.Mnu_Ventanas.Size = new System.Drawing.Size(84, 20);
            this.Mnu_Ventanas.Text = "Ven&tanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // Ven_Cascada
            // 
            this.Ven_Cascada.Name = "Ven_Cascada";
            this.Ven_Cascada.Size = new System.Drawing.Size(220, 22);
            this.Ven_Cascada.Text = "&Cascada";
            this.Ven_Cascada.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // Ven_MosVert
            // 
            this.Ven_MosVert.Name = "Ven_MosVert";
            this.Ven_MosVert.Size = new System.Drawing.Size(220, 22);
            this.Ven_MosVert.Text = "Mosaico &vertical";
            this.Ven_MosVert.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // Ven_MosHor
            // 
            this.Ven_MosHor.Name = "Ven_MosHor";
            this.Ven_MosHor.Size = new System.Drawing.Size(220, 22);
            this.Ven_MosHor.Text = "Mosaico &horizontal";
            this.Ven_MosHor.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // Ven_CerrarTodo
            // 
            this.Ven_CerrarTodo.Name = "Ven_CerrarTodo";
            this.Ven_CerrarTodo.Size = new System.Drawing.Size(220, 22);
            this.Ven_CerrarTodo.Text = "C&errar todo";
            this.Ven_CerrarTodo.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // Mnu_Ayuda
            // 
            this.Mnu_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.Ayu_Acerca});
            this.Mnu_Ayuda.Name = "Mnu_Ayuda";
            this.Mnu_Ayuda.Size = new System.Drawing.Size(60, 20);
            this.Mnu_Ayuda.Text = "Ay&uda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(201, 6);
            // 
            // Ayu_Acerca
            // 
            this.Ayu_Acerca.Name = "Ayu_Acerca";
            this.Ayu_Acerca.Size = new System.Drawing.Size(204, 22);
            this.Ayu_Acerca.Text = "&Acerca de... ...";
            // 
            // SS_BarradeEstadoPrincipal
            // 
            this.SS_BarradeEstadoPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.Lbl_Detalle1});
            this.SS_BarradeEstadoPrincipal.Location = new System.Drawing.Point(3, 533);
            this.SS_BarradeEstadoPrincipal.Name = "SS_BarradeEstadoPrincipal";
            this.SS_BarradeEstadoPrincipal.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.SS_BarradeEstadoPrincipal.Size = new System.Drawing.Size(837, 22);
            this.SS_BarradeEstadoPrincipal.TabIndex = 2;
            this.SS_BarradeEstadoPrincipal.Text = "Sistema de Monitoreo Financiero";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Lbl_Detalle1
            // 
            this.Lbl_Detalle1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Detalle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Detalle1.Name = "Lbl_Detalle1";
            this.Lbl_Detalle1.Size = new System.Drawing.Size(208, 17);
            this.Lbl_Detalle1.Text = "Empresa / Usuario / Grupo";
            // 
            // Frm_Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MOFIN.Properties.Resources.desktop0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.SS_BarradeEstadoPrincipal);
            this.Controls.Add(this.TS_MenuPrincipal);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.TS_MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Desktop";
            this.Padding = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.Text = "Sistema de Monitoreo Financiero";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Desktop_Load);
            this.TS_MenuPrincipal.ResumeLayout(false);
            this.TS_MenuPrincipal.PerformLayout();
            this.SS_BarradeEstadoPrincipal.ResumeLayout(false);
            this.SS_BarradeEstadoPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip TS_MenuPrincipal;
        private System.Windows.Forms.StatusStrip SS_BarradeEstadoPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem Arc_ConfigImpres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem Ayu_Acerca;
        private System.Windows.Forms.ToolStripMenuItem Ven_MosHor;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Archivo;
        private System.Windows.Forms.ToolStripMenuItem Arc_Abrir;
        private System.Windows.Forms.ToolStripMenuItem Arc_Imprimir;
        private System.Windows.Forms.ToolStripMenuItem Arc_VistaPrevia;
        private System.Windows.Forms.ToolStripMenuItem Arc_Salir;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Editar;
        private System.Windows.Forms.ToolStripMenuItem Edi_Deshacer;
        private System.Windows.Forms.ToolStripMenuItem Edi_Rehacer;
        private System.Windows.Forms.ToolStripMenuItem Edi_Cortar;
        private System.Windows.Forms.ToolStripMenuItem Edi_Copiar;
        private System.Windows.Forms.ToolStripMenuItem Edi_Pegar;
        private System.Windows.Forms.ToolStripMenuItem Edi_SelecTodo;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Ver;
        private System.Windows.Forms.ToolStripMenuItem Ver_BarraStado;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Herramientas;
        private System.Windows.Forms.ToolStripMenuItem Her_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Ventanas;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ven_Cascada;
        private System.Windows.Forms.ToolStripMenuItem Ven_MosVert;
        private System.Windows.Forms.ToolStripMenuItem Ven_CerrarTodo;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Ayuda;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Her_Grupos;
        private System.Windows.Forms.ToolStripMenuItem Her_Empresas;
        private System.Windows.Forms.ToolStripMenuItem Arc_SelEmpresa;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Clientes;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Operaciones;
        private System.Windows.Forms.ToolStripMenuItem Mnu_TablasMaestras;
        private System.Windows.Forms.ToolStripMenuItem Tab_Maestros;
        private System.Windows.Forms.ToolStripMenuItem Ope_Financieras;
        private System.Windows.Forms.ToolStripMenuItem Ope_Transaccionales;
        private System.Windows.Forms.ToolStripMenuItem Cli_Monitor;
        private System.Windows.Forms.ToolStripMenuItem Cli_Busqueda;
        public System.Windows.Forms.ToolStripStatusLabel Lbl_Detalle1;
    }
}



