namespace MOFIN_Lib
{
    partial class Grp_Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grp_Opciones));
            this.Pan_Opciones = new System.Windows.Forms.Panel();
            this.Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opcion1 = new System.Windows.Forms.RadioButton();
            this.Pan_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pan_Opciones
            // 
            this.Pan_Opciones.AllowDrop = true;
            this.Pan_Opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pan_Opciones.Controls.Add(this.Opcion2);
            this.Pan_Opciones.Controls.Add(this.Opcion1);
            resources.ApplyResources(this.Pan_Opciones, "Pan_Opciones");
            this.Pan_Opciones.Name = "Pan_Opciones";
            // 
            // Opcion2
            // 
            resources.ApplyResources(this.Opcion2, "Opcion2");
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.TabStop = true;
            this.Opcion2.UseVisualStyleBackColor = true;
            // 
            // Opcion1
            // 
            resources.ApplyResources(this.Opcion1, "Opcion1");
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.TabStop = true;
            this.Opcion1.UseVisualStyleBackColor = true;
            // 
            // Grp_Opciones
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pan_Opciones);
            this.Name = "Grp_Opciones";
            this.Pan_Opciones.ResumeLayout(false);
            this.Pan_Opciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel Pan_Opciones;
        public System.Windows.Forms.RadioButton Opcion2;
        public System.Windows.Forms.RadioButton Opcion1;
    }
}
