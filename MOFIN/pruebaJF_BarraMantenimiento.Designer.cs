namespace MOFIN
{
    partial class pruebaJF_BarraMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pruebaJF_BarraMantenimiento));
            this.BarraMantenimiento = new System.Windows.Forms.ToolStrip();
            this.Btn_Primero = new System.Windows.Forms.ToolStripButton();
            this.Btn_Anterior = new System.Windows.Forms.ToolStripButton();
            this.Btn_Siguiente = new System.Windows.Forms.ToolStripButton();
            this.Btn_Ultimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.BarraMantenimiento.SuspendLayout();
            // 
            // BarraMantenimiento
            // 
            this.BarraMantenimiento.BackColor = System.Drawing.Color.White;
            this.BarraMantenimiento.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraMantenimiento.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.BarraMantenimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Primero,
            this.Btn_Anterior,
            this.Btn_Siguiente,
            this.Btn_Ultimo,
            this.toolStripSeparator1,
            this.Btn_Buscar});
            this.BarraMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.BarraMantenimiento.Name = "BarraMantenimiento";
            this.BarraMantenimiento.Size = new System.Drawing.Size(100, 25);
            this.BarraMantenimiento.Stretch = true;
            this.BarraMantenimiento.TabIndex = 0;
            this.BarraMantenimiento.Text = "toolStrip1";
            this.BarraMantenimiento.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Btn_Primero
            // 
            this.Btn_Primero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Primero.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Primero.Image")));
            this.Btn_Primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Primero.Name = "Btn_Primero";
            this.Btn_Primero.Size = new System.Drawing.Size(52, 22);
            this.Btn_Primero.Text = "Primero";
            // 
            // Btn_Anterior
            // 
            this.Btn_Anterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Anterior.Image")));
            this.Btn_Anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(52, 67);
            this.Btn_Anterior.Text = "Anterior";
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Siguiente.Image")));
            this.Btn_Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Size = new System.Drawing.Size(52, 67);
            this.Btn_Siguiente.Text = "Siguiente";
            // 
            // Btn_Ultimo
            // 
            this.Btn_Ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Ultimo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ultimo.Image")));
            this.Btn_Ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Ultimo.Name = "Btn_Ultimo";
            this.Btn_Ultimo.Size = new System.Drawing.Size(52, 67);
            this.Btn_Ultimo.Text = "Ultimo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(52, 67);
            this.Btn_Buscar.Text = "Buscar";
            this.BarraMantenimiento.ResumeLayout(false);
            this.BarraMantenimiento.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraMantenimiento;
        private System.Windows.Forms.ToolStripButton Btn_Primero;
        private System.Windows.Forms.ToolStripButton Btn_Anterior;
        private System.Windows.Forms.ToolStripButton Btn_Siguiente;
        private System.Windows.Forms.ToolStripButton Btn_Ultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Btn_Buscar;
    }
}
