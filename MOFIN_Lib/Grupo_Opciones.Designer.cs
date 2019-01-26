namespace MOFIN_Lib
{
    partial class Grupo_Opciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pan_Opciones = new System.Windows.Forms.Panel();
            this.Opc_Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opc_Opcion1 = new System.Windows.Forms.RadioButton();
            this.Pan_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Opciones
            // 
            this.Pan_Opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pan_Opciones.Controls.Add(this.Opc_Opcion2);
            this.Pan_Opciones.Controls.Add(this.Opc_Opcion1);
            this.Pan_Opciones.Location = new System.Drawing.Point(6, 4);
            this.Pan_Opciones.Name = "Pan_Opciones";
            this.Pan_Opciones.Size = new System.Drawing.Size(102, 66);
            this.Pan_Opciones.TabIndex = 0;
            this.Pan_Opciones.Paint += new System.Windows.Forms.PaintEventHandler(this.Pan_Opciones_Paint);
            // 
            // Opc_Opcion2
            // 
            this.Opc_Opcion2.AutoSize = true;
            this.Opc_Opcion2.Location = new System.Drawing.Point(14, 36);
            this.Opc_Opcion2.Name = "Opc_Opcion2";
            this.Opc_Opcion2.Size = new System.Drawing.Size(65, 17);
            this.Opc_Opcion2.TabIndex = 1;
            this.Opc_Opcion2.Text = "Opcion2";
            this.Opc_Opcion2.UseVisualStyleBackColor = true;
            this.Opc_Opcion2.CheckedChanged += new System.EventHandler(this.Opc_Opcion1_CheckedChanged);
            // 
            // Opc_Opcion1
            // 
            this.Opc_Opcion1.AutoSize = true;
            this.Opc_Opcion1.Checked = true;
            this.Opc_Opcion1.Location = new System.Drawing.Point(14, 13);
            this.Opc_Opcion1.Name = "Opc_Opcion1";
            this.Opc_Opcion1.Size = new System.Drawing.Size(65, 17);
            this.Opc_Opcion1.TabIndex = 0;
            this.Opc_Opcion1.TabStop = true;
            this.Opc_Opcion1.Text = "Opcion1";
            this.Opc_Opcion1.UseVisualStyleBackColor = true;
            this.Opc_Opcion1.CheckedChanged += new System.EventHandler(this.Opc_Opcion1_CheckedChanged);
            // 
            // Grupo_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan_Opciones);
            this.Name = "Grupo_Opciones";
            this.Size = new System.Drawing.Size(115, 78);
            this.Pan_Opciones.ResumeLayout(false);
            this.Pan_Opciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_Opciones;
        private System.Windows.Forms.RadioButton Opc_Opcion2;
        private System.Windows.Forms.RadioButton Opc_Opcion1;
    }
}
