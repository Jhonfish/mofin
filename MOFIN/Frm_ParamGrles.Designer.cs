namespace MOFIN
{
    partial class Frm_ParamGrles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParamGrles));
            this.Grp_Idioma = new System.Windows.Forms.GroupBox();
            this.Opc_Idioma2 = new System.Windows.Forms.RadioButton();
            this.Opc_Idioma1 = new System.Windows.Forms.RadioButton();
            this.Chk_PermitUsrCambParam = new System.Windows.Forms.CheckBox();
            this.BS_OpcSistema = new System.Windows.Forms.BindingSource(this.components);
            this.Grp_Opciones = new System.Windows.Forms.GroupBox();
            this.Chk_PermitcambIdioma = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grp_FormPuntoDecimal = new System.Windows.Forms.GroupBox();
            this.Opc_FormPuntoDec2 = new System.Windows.Forms.RadioButton();
            this.Opc_FormPuntoDec1 = new System.Windows.Forms.RadioButton();
            this.Grp_FormatoFecha = new System.Windows.Forms.GroupBox();
            this.Opc_FormFec2 = new System.Windows.Forms.RadioButton();
            this.Opc_FormFec1 = new System.Windows.Forms.RadioButton();
            this.Grp_Pais = new System.Windows.Forms.GroupBox();
            this.Opc_Pais2 = new System.Windows.Forms.RadioButton();
            this.Opc_Pais1 = new System.Windows.Forms.RadioButton();
            this.Grp_Desktop = new System.Windows.Forms.GroupBox();
            this.Opc_Desktop2 = new System.Windows.Forms.RadioButton();
            this.Opc_Desktop1 = new System.Windows.Forms.RadioButton();
            this.Lbl_FondoEscritorio = new System.Windows.Forms.Label();
            this.Lbl_PaisUso = new System.Windows.Forms.Label();
            this.Lbl_FormatoFecha = new System.Windows.Forms.Label();
            this.Lbl_IdiomaPredeterm = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Chk_ConfigBtnsBarraHerram = new System.Windows.Forms.CheckBox();
            this.Grp_Idioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OpcSistema)).BeginInit();
            this.Grp_Opciones.SuspendLayout();
            this.Grp_FormPuntoDecimal.SuspendLayout();
            this.Grp_FormatoFecha.SuspendLayout();
            this.Grp_Pais.SuspendLayout();
            this.Grp_Desktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Idioma
            // 
            this.Grp_Idioma.Controls.Add(this.Opc_Idioma2);
            this.Grp_Idioma.Controls.Add(this.Opc_Idioma1);
            this.Grp_Idioma.ForeColor = System.Drawing.Color.White;
            this.Grp_Idioma.Location = new System.Drawing.Point(26, 129);
            this.Grp_Idioma.Name = "Grp_Idioma";
            this.Grp_Idioma.Size = new System.Drawing.Size(154, 59);
            this.Grp_Idioma.TabIndex = 49;
            this.Grp_Idioma.TabStop = false;
            // 
            // Opc_Idioma2
            // 
            this.Opc_Idioma2.AutoSize = true;
            this.Opc_Idioma2.Location = new System.Drawing.Point(12, 29);
            this.Opc_Idioma2.Name = "Opc_Idioma2";
            this.Opc_Idioma2.Size = new System.Drawing.Size(67, 18);
            this.Opc_Idioma2.TabIndex = 1;
            this.Opc_Idioma2.TabStop = true;
            this.Opc_Idioma2.Text = "Inglés";
            this.Opc_Idioma2.UseVisualStyleBackColor = true;
            // 
            // Opc_Idioma1
            // 
            this.Opc_Idioma1.AutoSize = true;
            this.Opc_Idioma1.Location = new System.Drawing.Point(12, 11);
            this.Opc_Idioma1.Name = "Opc_Idioma1";
            this.Opc_Idioma1.Size = new System.Drawing.Size(74, 18);
            this.Opc_Idioma1.TabIndex = 0;
            this.Opc_Idioma1.TabStop = true;
            this.Opc_Idioma1.Text = "Español";
            this.Opc_Idioma1.UseVisualStyleBackColor = true;
            this.Opc_Idioma1.CheckedChanged += new System.EventHandler(this.Opc_Idioma1_CheckedChanged);
            // 
            // Chk_PermitUsrCambParam
            // 
            this.Chk_PermitUsrCambParam.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_OpcSistema, "PermitUserCamParam", true));
            this.Chk_PermitUsrCambParam.ForeColor = System.Drawing.Color.White;
            this.Chk_PermitUsrCambParam.Location = new System.Drawing.Point(224, 78);
            this.Chk_PermitUsrCambParam.Name = "Chk_PermitUsrCambParam";
            this.Chk_PermitUsrCambParam.Size = new System.Drawing.Size(350, 26);
            this.Chk_PermitUsrCambParam.TabIndex = 51;
            this.Chk_PermitUsrCambParam.Text = "Permitir a los Usuarios Cambiar los Parámetros";
            this.Chk_PermitUsrCambParam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chk_PermitUsrCambParam.UseVisualStyleBackColor = true;
            // 
            // BS_OpcSistema
            // 
            this.BS_OpcSistema.DataSource = typeof(MofinModeloEntorno.Opc_Sistema);
            // 
            // Grp_Opciones
            // 
            this.Grp_Opciones.Controls.Add(this.Chk_ConfigBtnsBarraHerram);
            this.Grp_Opciones.Controls.Add(this.Chk_PermitcambIdioma);
            this.Grp_Opciones.Controls.Add(this.label1);
            this.Grp_Opciones.Controls.Add(this.Grp_FormPuntoDecimal);
            this.Grp_Opciones.Controls.Add(this.Grp_FormatoFecha);
            this.Grp_Opciones.Controls.Add(this.Grp_Pais);
            this.Grp_Opciones.Controls.Add(this.Grp_Desktop);
            this.Grp_Opciones.Controls.Add(this.Lbl_FondoEscritorio);
            this.Grp_Opciones.Controls.Add(this.Lbl_PaisUso);
            this.Grp_Opciones.Controls.Add(this.Lbl_FormatoFecha);
            this.Grp_Opciones.Location = new System.Drawing.Point(215, 84);
            this.Grp_Opciones.Name = "Grp_Opciones";
            this.Grp_Opciones.Size = new System.Drawing.Size(418, 264);
            this.Grp_Opciones.TabIndex = 52;
            this.Grp_Opciones.TabStop = false;
            // 
            // Chk_PermitcambIdioma
            // 
            this.Chk_PermitcambIdioma.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_OpcSistema, "PermitUserCambIdioma", true));
            this.Chk_PermitcambIdioma.ForeColor = System.Drawing.Color.White;
            this.Chk_PermitcambIdioma.Location = new System.Drawing.Point(231, 42);
            this.Chk_PermitcambIdioma.Name = "Chk_PermitcambIdioma";
            this.Chk_PermitcambIdioma.Size = new System.Drawing.Size(168, 48);
            this.Chk_PermitcambIdioma.TabIndex = 58;
            this.Chk_PermitcambIdioma.Text = "Permitir al Usuario Cambiar el Idioma";
            this.Chk_PermitcambIdioma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Formato de Punto Decimal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Grp_FormPuntoDecimal
            // 
            this.Grp_FormPuntoDecimal.Controls.Add(this.Opc_FormPuntoDec2);
            this.Grp_FormPuntoDecimal.Controls.Add(this.Opc_FormPuntoDec1);
            this.Grp_FormPuntoDecimal.ForeColor = System.Drawing.Color.White;
            this.Grp_FormPuntoDecimal.Location = new System.Drawing.Point(231, 191);
            this.Grp_FormPuntoDecimal.Name = "Grp_FormPuntoDecimal";
            this.Grp_FormPuntoDecimal.Size = new System.Drawing.Size(154, 59);
            this.Grp_FormPuntoDecimal.TabIndex = 56;
            this.Grp_FormPuntoDecimal.TabStop = false;
            // 
            // Opc_FormPuntoDec2
            // 
            this.Opc_FormPuntoDec2.AutoSize = true;
            this.Opc_FormPuntoDec2.Location = new System.Drawing.Point(12, 29);
            this.Opc_FormPuntoDec2.Name = "Opc_FormPuntoDec2";
            this.Opc_FormPuntoDec2.Size = new System.Drawing.Size(95, 18);
            this.Opc_FormPuntoDec2.TabIndex = 1;
            this.Opc_FormPuntoDec2.TabStop = true;
            this.Opc_FormPuntoDec2.Text = "123,456.78";
            this.Opc_FormPuntoDec2.UseVisualStyleBackColor = true;
            // 
            // Opc_FormPuntoDec1
            // 
            this.Opc_FormPuntoDec1.AutoSize = true;
            this.Opc_FormPuntoDec1.Location = new System.Drawing.Point(12, 11);
            this.Opc_FormPuntoDec1.Name = "Opc_FormPuntoDec1";
            this.Opc_FormPuntoDec1.Size = new System.Drawing.Size(95, 18);
            this.Opc_FormPuntoDec1.TabIndex = 0;
            this.Opc_FormPuntoDec1.TabStop = true;
            this.Opc_FormPuntoDec1.Text = "123.456,78";
            this.Opc_FormPuntoDec1.UseVisualStyleBackColor = true;
            this.Opc_FormPuntoDec1.CheckedChanged += new System.EventHandler(this.Opc_FormPuntoDec1_CheckedChanged);
            // 
            // Grp_FormatoFecha
            // 
            this.Grp_FormatoFecha.Controls.Add(this.Opc_FormFec2);
            this.Grp_FormatoFecha.Controls.Add(this.Opc_FormFec1);
            this.Grp_FormatoFecha.ForeColor = System.Drawing.Color.White;
            this.Grp_FormatoFecha.Location = new System.Drawing.Point(31, 195);
            this.Grp_FormatoFecha.Name = "Grp_FormatoFecha";
            this.Grp_FormatoFecha.Size = new System.Drawing.Size(154, 59);
            this.Grp_FormatoFecha.TabIndex = 55;
            this.Grp_FormatoFecha.TabStop = false;
            // 
            // Opc_FormFec2
            // 
            this.Opc_FormFec2.AutoSize = true;
            this.Opc_FormFec2.Location = new System.Drawing.Point(12, 29);
            this.Opc_FormFec2.Name = "Opc_FormFec2";
            this.Opc_FormFec2.Size = new System.Drawing.Size(95, 18);
            this.Opc_FormFec2.TabIndex = 1;
            this.Opc_FormFec2.TabStop = true;
            this.Opc_FormFec2.Text = "MM/DD/AAAA";
            this.Opc_FormFec2.UseVisualStyleBackColor = true;
            // 
            // Opc_FormFec1
            // 
            this.Opc_FormFec1.AutoSize = true;
            this.Opc_FormFec1.Location = new System.Drawing.Point(12, 11);
            this.Opc_FormFec1.Name = "Opc_FormFec1";
            this.Opc_FormFec1.Size = new System.Drawing.Size(95, 18);
            this.Opc_FormFec1.TabIndex = 0;
            this.Opc_FormFec1.TabStop = true;
            this.Opc_FormFec1.Text = "DD/MM/AAAA";
            this.Opc_FormFec1.UseVisualStyleBackColor = true;
            this.Opc_FormFec1.CheckedChanged += new System.EventHandler(this.Opc_FormFec1_CheckedChanged);
            // 
            // Grp_Pais
            // 
            this.Grp_Pais.Controls.Add(this.Opc_Pais2);
            this.Grp_Pais.Controls.Add(this.Opc_Pais1);
            this.Grp_Pais.ForeColor = System.Drawing.Color.White;
            this.Grp_Pais.Location = new System.Drawing.Point(31, 112);
            this.Grp_Pais.Name = "Grp_Pais";
            this.Grp_Pais.Size = new System.Drawing.Size(154, 59);
            this.Grp_Pais.TabIndex = 54;
            this.Grp_Pais.TabStop = false;
            // 
            // Opc_Pais2
            // 
            this.Opc_Pais2.AutoSize = true;
            this.Opc_Pais2.Location = new System.Drawing.Point(12, 29);
            this.Opc_Pais2.Name = "Opc_Pais2";
            this.Opc_Pais2.Size = new System.Drawing.Size(67, 18);
            this.Opc_Pais2.TabIndex = 1;
            this.Opc_Pais2.TabStop = true;
            this.Opc_Pais2.Text = "Panamá";
            this.Opc_Pais2.UseVisualStyleBackColor = true;
            // 
            // Opc_Pais1
            // 
            this.Opc_Pais1.AutoSize = true;
            this.Opc_Pais1.Location = new System.Drawing.Point(12, 11);
            this.Opc_Pais1.Name = "Opc_Pais1";
            this.Opc_Pais1.Size = new System.Drawing.Size(88, 18);
            this.Opc_Pais1.TabIndex = 1;
            this.Opc_Pais1.TabStop = true;
            this.Opc_Pais1.Text = "Venezuela";
            this.Opc_Pais1.UseVisualStyleBackColor = true;
            this.Opc_Pais1.CheckedChanged += new System.EventHandler(this.Opc_Pais1_CheckedChanged);
            // 
            // Grp_Desktop
            // 
            this.Grp_Desktop.Controls.Add(this.Opc_Desktop2);
            this.Grp_Desktop.Controls.Add(this.Opc_Desktop1);
            this.Grp_Desktop.ForeColor = System.Drawing.Color.White;
            this.Grp_Desktop.Location = new System.Drawing.Point(31, 34);
            this.Grp_Desktop.Name = "Grp_Desktop";
            this.Grp_Desktop.Size = new System.Drawing.Size(154, 59);
            this.Grp_Desktop.TabIndex = 53;
            this.Grp_Desktop.TabStop = false;
            // 
            // Opc_Desktop2
            // 
            this.Opc_Desktop2.AutoSize = true;
            this.Opc_Desktop2.Location = new System.Drawing.Point(12, 29);
            this.Opc_Desktop2.Name = "Opc_Desktop2";
            this.Opc_Desktop2.Size = new System.Drawing.Size(88, 18);
            this.Opc_Desktop2.TabIndex = 1;
            this.Opc_Desktop2.TabStop = true;
            this.Opc_Desktop2.Text = "Aleatorio";
            this.Opc_Desktop2.UseVisualStyleBackColor = true;
            // 
            // Opc_Desktop1
            // 
            this.Opc_Desktop1.AutoSize = true;
            this.Opc_Desktop1.Location = new System.Drawing.Point(12, 11);
            this.Opc_Desktop1.Name = "Opc_Desktop1";
            this.Opc_Desktop1.Size = new System.Drawing.Size(53, 18);
            this.Opc_Desktop1.TabIndex = 0;
            this.Opc_Desktop1.TabStop = true;
            this.Opc_Desktop1.Text = "Fijo";
            this.Opc_Desktop1.UseVisualStyleBackColor = true;
            this.Opc_Desktop1.CheckedChanged += new System.EventHandler(this.Opc_Desktop1_CheckedChanged);
            // 
            // Lbl_FondoEscritorio
            // 
            this.Lbl_FondoEscritorio.ForeColor = System.Drawing.Color.White;
            this.Lbl_FondoEscritorio.Location = new System.Drawing.Point(10, 14);
            this.Lbl_FondoEscritorio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_FondoEscritorio.Name = "Lbl_FondoEscritorio";
            this.Lbl_FondoEscritorio.Size = new System.Drawing.Size(239, 17);
            this.Lbl_FondoEscritorio.TabIndex = 50;
            this.Lbl_FondoEscritorio.Text = "Fondo de Escritorio:";
            this.Lbl_FondoEscritorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_PaisUso
            // 
            this.Lbl_PaisUso.ForeColor = System.Drawing.Color.White;
            this.Lbl_PaisUso.Location = new System.Drawing.Point(10, 96);
            this.Lbl_PaisUso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_PaisUso.Name = "Lbl_PaisUso";
            this.Lbl_PaisUso.Size = new System.Drawing.Size(175, 17);
            this.Lbl_PaisUso.TabIndex = 51;
            this.Lbl_PaisUso.Text = "Pais Uso:";
            // 
            // Lbl_FormatoFecha
            // 
            this.Lbl_FormatoFecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_FormatoFecha.Location = new System.Drawing.Point(10, 175);
            this.Lbl_FormatoFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_FormatoFecha.Name = "Lbl_FormatoFecha";
            this.Lbl_FormatoFecha.Size = new System.Drawing.Size(150, 17);
            this.Lbl_FormatoFecha.TabIndex = 52;
            this.Lbl_FormatoFecha.Text = "Formato de Fecha:";
            this.Lbl_FormatoFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_IdiomaPredeterm
            // 
            this.Lbl_IdiomaPredeterm.ForeColor = System.Drawing.Color.White;
            this.Lbl_IdiomaPredeterm.Location = new System.Drawing.Point(12, 98);
            this.Lbl_IdiomaPredeterm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_IdiomaPredeterm.Name = "Lbl_IdiomaPredeterm";
            this.Lbl_IdiomaPredeterm.Size = new System.Drawing.Size(195, 43);
            this.Lbl_IdiomaPredeterm.TabIndex = 49;
            this.Lbl_IdiomaPredeterm.Text = "Idioma Predeterminado del Sistema:";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(93, 296);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 54;
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(27, 296);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 53;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Chk_ConfigBtnsBarraHerram
            // 
            this.Chk_ConfigBtnsBarraHerram.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.BS_OpcSistema, "BtnsNavegBarraHerram", true));
            this.Chk_ConfigBtnsBarraHerram.ForeColor = System.Drawing.Color.White;
            this.Chk_ConfigBtnsBarraHerram.Location = new System.Drawing.Point(231, 119);
            this.Chk_ConfigBtnsBarraHerram.Name = "Chk_ConfigBtnsBarraHerram";
            this.Chk_ConfigBtnsBarraHerram.Size = new System.Drawing.Size(168, 47);
            this.Chk_ConfigBtnsBarraHerram.TabIndex = 59;
            this.Chk_ConfigBtnsBarraHerram.Text = "Mostrar Botones Navegacion en Barra de Herramienta";
            this.Chk_ConfigBtnsBarraHerram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_ConfigBtnsBarraHerram.UseVisualStyleBackColor = true;
            // 
            // Frm_ParamGrles
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(650, 360);
            this.Controls.Add(this.Grp_Idioma);
            this.Controls.Add(this.Lbl_IdiomaPredeterm);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Chk_PermitUsrCambParam);
            this.Controls.Add(this.Grp_Opciones);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ParamGrles";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Parámetros Generales del Sistema";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Frm_ParamGrles_Load);
            this.Grp_Idioma.ResumeLayout(false);
            this.Grp_Idioma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_OpcSistema)).EndInit();
            this.Grp_Opciones.ResumeLayout(false);
            this.Grp_FormPuntoDecimal.ResumeLayout(false);
            this.Grp_FormPuntoDecimal.PerformLayout();
            this.Grp_FormatoFecha.ResumeLayout(false);
            this.Grp_FormatoFecha.PerformLayout();
            this.Grp_Pais.ResumeLayout(false);
            this.Grp_Pais.PerformLayout();
            this.Grp_Desktop.ResumeLayout(false);
            this.Grp_Desktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Idioma;
        private System.Windows.Forms.RadioButton Opc_Idioma2;
        private System.Windows.Forms.RadioButton Opc_Idioma1;
        private System.Windows.Forms.BindingSource BS_OpcSistema;
        private System.Windows.Forms.CheckBox Chk_PermitUsrCambParam;
        private System.Windows.Forms.GroupBox Grp_Opciones;
        private System.Windows.Forms.Label Lbl_IdiomaPredeterm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Grp_FormPuntoDecimal;
        private System.Windows.Forms.RadioButton Opc_FormPuntoDec2;
        private System.Windows.Forms.RadioButton Opc_FormPuntoDec1;
        private System.Windows.Forms.GroupBox Grp_FormatoFecha;
        private System.Windows.Forms.RadioButton Opc_FormFec2;
        private System.Windows.Forms.RadioButton Opc_FormFec1;
        private System.Windows.Forms.GroupBox Grp_Pais;
        private System.Windows.Forms.RadioButton Opc_Pais2;
        private System.Windows.Forms.RadioButton Opc_Pais1;
        private System.Windows.Forms.GroupBox Grp_Desktop;
        private System.Windows.Forms.RadioButton Opc_Desktop2;
        private System.Windows.Forms.RadioButton Opc_Desktop1;
        private System.Windows.Forms.Label Lbl_FondoEscritorio;
        private System.Windows.Forms.Label Lbl_PaisUso;
        private System.Windows.Forms.Label Lbl_FormatoFecha;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.CheckBox Chk_PermitcambIdioma;
        private System.Windows.Forms.CheckBox Chk_ConfigBtnsBarraHerram;
    }
}