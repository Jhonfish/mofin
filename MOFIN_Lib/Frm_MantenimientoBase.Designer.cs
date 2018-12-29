namespace MOFIN_Lib
{
    partial class Frm_MantenimientoBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantenimientoBase));
            this.TSt_BarraMantenimiento = new System.Windows.Forms.ToolStrip();
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.TSt_BarraMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSt_BarraMantenimiento
            // 
            this.TSt_BarraMantenimiento.BackColor = System.Drawing.Color.White;
            this.TSt_BarraMantenimiento.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSt_BarraMantenimiento.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TSt_BarraMantenimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.TSt_BarraMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.TSt_BarraMantenimiento.Name = "TSt_BarraMantenimiento";
            this.TSt_BarraMantenimiento.Size = new System.Drawing.Size(940, 55);
            this.TSt_BarraMantenimiento.TabIndex = 1;
            this.TSt_BarraMantenimiento.Text = "Barra de Herramientas";
            // 
            // Primero
            // 
            this.Primero.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primero.Image = ((System.Drawing.Image)(resources.GetObject("Primero.Image")));
            this.Primero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(60, 52);
            this.Primero.Text = "Primero";
            this.Primero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Anterior
            // 
            this.Anterior.Font = new System.Drawing.Font("Courier New", 9F);
            this.Anterior.Image = ((System.Drawing.Image)(resources.GetObject("Anterior.Image")));
            this.Anterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(67, 52);
            this.Anterior.Text = "Anterior";
            this.Anterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Siguiente
            // 
            this.Siguiente.Font = new System.Drawing.Font("Courier New", 9F);
            this.Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("Siguiente.Image")));
            this.Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(74, 52);
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Ultimo
            // 
            this.Ultimo.Font = new System.Drawing.Font("Courier New", 9F);
            this.Ultimo.Image = ((System.Drawing.Image)(resources.GetObject("Ultimo.Image")));
            this.Ultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(53, 52);
            this.Ultimo.Text = "Ultimo";
            this.Ultimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(60, 52);
            this.Buscar.Text = "Buscar";
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // Incluir
            // 
            this.Incluir.Image = ((System.Drawing.Image)(resources.GetObject("Incluir.Image")));
            this.Incluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(68, 52);
            this.Incluir.Text = "Incluir";
            this.Incluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Modificar
            // 
            this.Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Modificar.Image")));
            this.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(84, 52);
            this.Modificar.Text = "Modificar";
            this.Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(76, 52);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(76, 52);
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // Salir
            // 
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(52, 52);
            this.Salir.Text = "Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.BackgroundImage")));
            this.Btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Location = new System.Drawing.Point(823, 449);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(48, 48);
            this.Btn_Aceptar.TabIndex = 2;
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(879, 449);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(48, 48);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_MantenimientoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 510);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.TSt_BarraMantenimiento);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MantenimientoBase";
            this.Text = "Frm_MantenimientoBase";
            this.TSt_BarraMantenimiento.ResumeLayout(false);
            this.TSt_BarraMantenimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public System.Windows.Forms.Button Btn_Aceptar;
        public System.Windows.Forms.Button Btn_Cancelar;
        protected System.Windows.Forms.ToolStrip TSt_BarraMantenimiento;
    }
}