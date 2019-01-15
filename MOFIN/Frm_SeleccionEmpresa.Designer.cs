namespace MOFIN
{
    partial class Frm_SeleccionEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SeleccionEmpresa));
            this.Lbl_Empresa = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Cmb_Empresa = new System.Windows.Forms.ComboBox();
            this.BS_Empresas = new System.Windows.Forms.BindingSource(this.components);
            this.entornoDataSet = new MOFIN.EntornoDataSet();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.TA_Empresas = new MOFIN.EntornoDataSetTableAdapters.EmpresasTableAdapter();
            this.tableAdapterManager = new MOFIN.EntornoDataSetTableAdapters.TableAdapterManager();
            this.TA_Emp_Accesos = new MOFIN.EntornoDataSetTableAdapters.Emp_AccesosTableAdapter();
            this.TA_Grupos = new MOFIN.EntornoDataSetTableAdapters.GruposTableAdapter();
            this.TA_Usuarios = new MOFIN.EntornoDataSetTableAdapters.UsuariosTableAdapter();
            this.BS_Emp_Accesos = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Grupos = new System.Windows.Forms.BindingSource(this.components);
            this.BS_Usuarios = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entornoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Emp_Accesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Empresa
            // 
            this.Lbl_Empresa.AutoSize = true;
            this.Lbl_Empresa.Location = new System.Drawing.Point(69, 84);
            this.Lbl_Empresa.Name = "Lbl_Empresa";
            this.Lbl_Empresa.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Empresa.TabIndex = 0;
            this.Lbl_Empresa.Text = "Empresa";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Location = new System.Drawing.Point(69, 124);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "Usuario";
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Location = new System.Drawing.Point(69, 163);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(88, 16);
            this.Lbl_Contraseña.TabIndex = 2;
            this.Lbl_Contraseña.Text = "Contraseña";
            // 
            // Cmb_Empresa
            // 
            this.Cmb_Empresa.DataSource = this.BS_Empresas;
            this.Cmb_Empresa.DisplayMember = "Nombre";
            this.Cmb_Empresa.FormattingEnabled = true;
            this.Cmb_Empresa.Location = new System.Drawing.Point(179, 81);
            this.Cmb_Empresa.Name = "Cmb_Empresa";
            this.Cmb_Empresa.Size = new System.Drawing.Size(300, 24);
            this.Cmb_Empresa.TabIndex = 3;
            this.Cmb_Empresa.ValueMember = "Codigo";
            // 
            // BS_Empresas
            // 
            this.BS_Empresas.DataMember = "Empresas";
            this.BS_Empresas.DataSource = this.entornoDataSet;
            // 
            // entornoDataSet
            // 
            this.entornoDataSet.DataSetName = "EntornoDataSet";
            this.entornoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Usuario.Location = new System.Drawing.Point(179, 121);
            this.Txt_Usuario.MaxLength = 32;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(150, 22);
            this.Txt_Usuario.TabIndex = 4;
            // 
            // Txt_Password
            // 
            this.Txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Password.Location = new System.Drawing.Point(179, 160);
            this.Txt_Password.MaxLength = 32;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(150, 22);
            this.Txt_Password.TabIndex = 5;
            this.Txt_Password.UseSystemPasswordChar = true;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(456, 188);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Cancelar.TabIndex = 22;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(374, 188);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(38, 38);
            this.Btn_Aceptar.TabIndex = 21;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // TA_Empresas
            // 
            this.TA_Empresas.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Emp_AccesosTableAdapter = this.TA_Emp_Accesos;
            this.tableAdapterManager.EmpresasTableAdapter = this.TA_Empresas;
            this.tableAdapterManager.Grupo_OpcionesTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = this.TA_Grupos;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.Opc_SistemaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOFIN.EntornoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.TA_Usuarios;
            // 
            // TA_Emp_Accesos
            // 
            this.TA_Emp_Accesos.ClearBeforeFill = true;
            // 
            // TA_Grupos
            // 
            this.TA_Grupos.ClearBeforeFill = true;
            // 
            // TA_Usuarios
            // 
            this.TA_Usuarios.ClearBeforeFill = true;
            // 
            // BS_Emp_Accesos
            // 
            this.BS_Emp_Accesos.DataMember = "Emp_Accesos";
            this.BS_Emp_Accesos.DataSource = this.entornoDataSet;
            // 
            // BS_Grupos
            // 
            this.BS_Grupos.DataMember = "Grupos";
            this.BS_Grupos.DataSource = this.entornoDataSet;
            // 
            // BS_Usuarios
            // 
            this.BS_Usuarios.DataMember = "Usuarios";
            this.BS_Usuarios.DataSource = this.entornoDataSet;
            // 
            // Frm_SeleccionEmpresa
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(516, 250);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Cmb_Empresa);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Empresa);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SeleccionEmpresa";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Selección de Empresa";
            this.Load += new System.EventHandler(this.Frm_SeleccionEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BS_Empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entornoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Emp_Accesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Empresa;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.ComboBox Cmb_Empresa;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private EntornoDataSet entornoDataSet;
        private System.Windows.Forms.BindingSource BS_Empresas;
        private EntornoDataSetTableAdapters.EmpresasTableAdapter TA_Empresas;
        private EntornoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private EntornoDataSetTableAdapters.Emp_AccesosTableAdapter TA_Emp_Accesos;
        private System.Windows.Forms.BindingSource BS_Emp_Accesos;
        private EntornoDataSetTableAdapters.GruposTableAdapter TA_Grupos;
        private System.Windows.Forms.BindingSource BS_Grupos;
        private EntornoDataSetTableAdapters.UsuariosTableAdapter TA_Usuarios;
        private System.Windows.Forms.BindingSource BS_Usuarios;
    }
}