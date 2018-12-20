namespace MOFIN
{
    partial class Component1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Component1));
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.Primero = new System.Windows.Forms.ToolStripButton();
            this.Anterior = new System.Windows.Forms.ToolStripButton();
            this.Siguiente = new System.Windows.Forms.ToolStripButton();
            this.Ultimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Incluir = new System.Windows.Forms.ToolStripButton();
            this.Modificar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.BarraHerramientas.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.BackColor = System.Drawing.Color.White;
            this.BarraHerramientas.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Primero,
            this.Anterior,
            this.Siguiente,
            this.Ultimo,
            this.toolStripSeparator1,
            this.Buscar,
            this.toolStripSeparator2,
            this.Incluir,
            this.Modificar,
            this.Eliminar,
            this.Imprimir,
            this.toolStripSeparator3,
            this.Salir});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(751, 70);
            this.BarraHerramientas.TabIndex = 0;
            this.BarraHerramientas.Text = "Barra de Herramientas";
            this.BarraHerramientas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BarraHerramientas_ItemClicked);
            // 
            // Primero
            // 
            this.Primero.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primero.Image = ((System.Drawing.Image)(resources.GetObject("Primero.Image")));
            this.Primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(60, 67);
            this.Primero.Text = "Primero";
            this.Primero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Anterior
            // 
            this.Anterior.Font = new System.Drawing.Font("Courier New", 9F);
            this.Anterior.Image = ((System.Drawing.Image)(resources.GetObject("Anterior.Image")));
            this.Anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(67, 67);
            this.Anterior.Text = "Anterior";
            this.Anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Siguiente
            // 
            this.Siguiente.Font = new System.Drawing.Font("Courier New", 9F);
            this.Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Siguiente.Image")));
            this.Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(74, 67);
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Ultimo
            // 
            this.Ultimo.Font = new System.Drawing.Font("Courier New", 9F);
            this.Ultimo.Image = ((System.Drawing.Image)(resources.GetObject("Ultimo.Image")));
            this.Ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(53, 67);
            this.Ultimo.Text = "Ultimo";
            this.Ultimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(52, 67);
            this.Buscar.Text = "Buscar";
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // Incluir
            // 
            this.Incluir.Image = ((System.Drawing.Image)(resources.GetObject("Incluir.Image")));
            this.Incluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(52, 67);
            this.Incluir.Text = "Incluir";
            this.Incluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(62, 67);
            this.Modificar.Text = "Modificar";
            this.Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(54, 67);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Imprimir
            // 
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(57, 67);
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // Salir
            // 
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(52, 67);
            this.Salir.Text = "Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton Primero;
        private System.Windows.Forms.ToolStripButton Anterior;
        private System.Windows.Forms.ToolStripButton Siguiente;
        private System.Windows.Forms.ToolStripButton Ultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Incluir;
        private System.Windows.Forms.ToolStripButton Modificar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.ToolStripButton Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Salir;
    }
}
