namespace MOFIN
{
    partial class FrmVisorOpTransc
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
            this.dgvOpTransac = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.BS_CClientes = new System.Windows.Forms.BindingSource(this.components);
            this.listTransacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpTransac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTransacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOpTransac
            // 
            this.dgvOpTransac.AutoGenerateColumns = false;
            this.dgvOpTransac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpTransac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codClienteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.compraDataGridViewTextBoxColumn,
            this.ventaDataGridViewTextBoxColumn});
            this.dgvOpTransac.DataSource = this.listTransacBindingSource;
            this.dgvOpTransac.Location = new System.Drawing.Point(12, 29);
            this.dgvOpTransac.Name = "dgvOpTransac";
            this.dgvOpTransac.Size = new System.Drawing.Size(542, 371);
            this.dgvOpTransac.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(479, 415);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // BS_CClientes
            // 
            this.BS_CClientes.DataSource = typeof(MofinModelo.C_Clientes);
            // 
            // listTransacBindingSource
            // 
            this.listTransacBindingSource.DataSource = typeof(MofinDatos.ListTransac);
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "Cod_Cliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // compraDataGridViewTextBoxColumn
            // 
            this.compraDataGridViewTextBoxColumn.DataPropertyName = "Compra";
            this.compraDataGridViewTextBoxColumn.HeaderText = "Compra";
            this.compraDataGridViewTextBoxColumn.Name = "compraDataGridViewTextBoxColumn";
            // 
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "Venta";
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            // 
            // FrmVisorOpTransc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvOpTransac);
            this.Name = "FrmVisorOpTransc";
            this.Text = "FrmVisorOpTransc";
            this.Load += new System.EventHandler(this.FrmVisorOpTransc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpTransac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTransacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOpTransac;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource BS_CClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listTransacBindingSource;
    }
}