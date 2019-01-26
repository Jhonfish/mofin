namespace MOFIN
{
    partial class Pruebas
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
            System.Windows.Forms.Label descripcionLabel;
            this.monitorOperacionesDataSet = new MOFIN.MonitorOperacionesDataSet();
            this.m_PaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_PaisTableAdapter = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_PaisTableAdapter();
            this.tableAdapterManager = new MOFIN.MonitorOperacionesDataSetTableAdapters.TableAdapterManager();
            this.m_EstadosTableAdapter = new MOFIN.MonitorOperacionesDataSetTableAdapters.M_EstadosTableAdapter();
            this.Cmb_Pais = new System.Windows.Forms.ComboBox();
            this.m_EstadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_EstadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_Codpais = new System.Windows.Forms.TextBox();
            this.m_EstadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Grd_Cao = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_PaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monitorOperacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EstadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EstadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EstadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Cao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PaisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(33, 15);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(27, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Pais";
            // 
            // monitorOperacionesDataSet
            // 
            this.monitorOperacionesDataSet.DataSetName = "MonitorOperacionesDataSet";
            this.monitorOperacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_PaisBindingSource
            // 
            this.m_PaisBindingSource.DataMember = "M_Pais";
            this.m_PaisBindingSource.DataSource = this.monitorOperacionesDataSet;
            // 
            // m_PaisTableAdapter
            // 
            this.m_PaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.B_BuscadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.C_ClientesTableAdapter = null;
            this.tableAdapterManager.C_FirBenAccTableAdapter = null;
            this.tableAdapterManager.C_HistActClientesTableAdapter = null;
            this.tableAdapterManager.C_ValorItemConsExpTableAdapter = null;
            this.tableAdapterManager.M_ActivComercialTableAdapter = null;
            this.tableAdapterManager.M_AntiguedadTableAdapter = null;
            this.tableAdapterManager.M_CriptomonedasTableAdapter = null;
            this.tableAdapterManager.M_EdadTableAdapter = null;
            this.tableAdapterManager.M_EstadosTableAdapter = this.m_EstadosTableAdapter;
            this.tableAdapterManager.M_NivelRiesgoTableAdapter = null;
            this.tableAdapterManager.M_PaisTableAdapter = this.m_PaisTableAdapter;
            this.tableAdapterManager.M_PEPTableAdapter = null;
            this.tableAdapterManager.M_ProductosTableAdapter = null;
            this.tableAdapterManager.M_ProfesionesTableAdapter = null;
            this.tableAdapterManager.M_ServiciosTableAdapter = null;
            this.tableAdapterManager.M_TipoDocIDTableAdapter = null;
            this.tableAdapterManager.M_TipoEstructuraEmpresaTableAdapter = null;
            this.tableAdapterManager.M_TipoPersJuridicaTableAdapter = null;
            this.tableAdapterManager.M_VolOperPersJurTableAdapter = null;
            this.tableAdapterManager.M_VolOperPersNatTableAdapter = null;
            this.tableAdapterManager.O_HistPerfOperacTableAdapter = null;
            this.tableAdapterManager.O_ObservacionesTableAdapter = null;
            this.tableAdapterManager.O_OperfinancierasTableAdapter = null;
            this.tableAdapterManager.O_OperTransaccionalesTableAdapter = null;
            this.tableAdapterManager.O_RepOperacionalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOFIN.MonitorOperacionesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_EstadosTableAdapter
            // 
            this.m_EstadosTableAdapter.ClearBeforeFill = true;
            // 
            // Cmb_Pais
            // 
            this.Cmb_Pais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_PaisBindingSource, "Descripcion", true));
            this.Cmb_Pais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.m_PaisBindingSource, "Codigo", true));
            this.Cmb_Pais.DataSource = this.m_PaisBindingSource;
            this.Cmb_Pais.DisplayMember = "Descripcion";
            this.Cmb_Pais.FormattingEnabled = true;
            this.Cmb_Pais.Location = new System.Drawing.Point(26, 44);
            this.Cmb_Pais.Name = "Cmb_Pais";
            this.Cmb_Pais.Size = new System.Drawing.Size(299, 21);
            this.Cmb_Pais.TabIndex = 2;
            // 
            // m_EstadosBindingSource
            // 
            this.m_EstadosBindingSource.DataMember = "M_Estados";
            this.m_EstadosBindingSource.DataSource = this.monitorOperacionesDataSet;
            // 
            // m_EstadosDataGridView
            // 
            this.m_EstadosDataGridView.AllowUserToAddRows = false;
            this.m_EstadosDataGridView.AllowUserToDeleteRows = false;
            this.m_EstadosDataGridView.AutoGenerateColumns = false;
            this.m_EstadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_EstadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.m_EstadosDataGridView.DataSource = this.m_EstadosBindingSource;
            this.m_EstadosDataGridView.Location = new System.Drawing.Point(331, 44);
            this.m_EstadosDataGridView.Name = "m_EstadosDataGridView";
            this.m_EstadosDataGridView.ReadOnly = true;
            this.m_EstadosDataGridView.RowHeadersVisible = false;
            this.m_EstadosDataGridView.Size = new System.Drawing.Size(435, 204);
            this.m_EstadosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_Pais";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod_Pais";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cod_Compuesto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cod_Compuesto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // txt_Codpais
            // 
            this.txt_Codpais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_PaisBindingSource, "Codigo", true));
            this.txt_Codpais.Location = new System.Drawing.Point(331, 12);
            this.txt_Codpais.Name = "txt_Codpais";
            this.txt_Codpais.Size = new System.Drawing.Size(42, 20);
            this.txt_Codpais.TabIndex = 4;
            this.txt_Codpais.TextChanged += new System.EventHandler(this.txt_Codpais_TextChanged);
            // 
            // m_EstadosBindingSource1
            // 
            this.m_EstadosBindingSource1.DataSource = typeof(MofinModelo.M_Estados);
            // 
            // Grd_Cao
            // 
            this.Grd_Cao.AllowUserToAddRows = false;
            this.Grd_Cao.AllowUserToDeleteRows = false;
            this.Grd_Cao.AutoGenerateColumns = false;
            this.Grd_Cao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Cao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.Grd_Cao.DataSource = this.m_EstadosBindingSource1;
            this.Grd_Cao.Location = new System.Drawing.Point(331, 254);
            this.Grd_Cao.Name = "Grd_Cao";
            this.Grd_Cao.Size = new System.Drawing.Size(435, 196);
            this.Grd_Cao.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Sistema";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Sistema";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cod_Compuesto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cod_Compuesto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CondEspSeguridad";
            this.dataGridViewTextBoxColumn11.HeaderText = "CondEspSeguridad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "M_Pais";
            this.dataGridViewTextBoxColumn12.HeaderText = "M_Pais";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // m_PaisDataGridView
            // 
            this.m_PaisDataGridView.AllowUserToAddRows = false;
            this.m_PaisDataGridView.AllowUserToDeleteRows = false;
            this.m_PaisDataGridView.AutoGenerateColumns = false;
            this.m_PaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_PaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewCheckBoxColumn2});
            this.m_PaisDataGridView.DataSource = this.m_PaisBindingSource;
            this.m_PaisDataGridView.Location = new System.Drawing.Point(26, 224);
            this.m_PaisDataGridView.Name = "m_PaisDataGridView";
            this.m_PaisDataGridView.ReadOnly = true;
            this.m_PaisDataGridView.Size = new System.Drawing.Size(299, 226);
            this.m_PaisDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn16.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Cod_AlfaNum2";
            this.dataGridViewTextBoxColumn14.HeaderText = "Cod_AlfaNum2";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Cod_AlfaNum3";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cod_AlfaNum3";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn17.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn2.HeaderText = "CondEspSeguridad";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_PaisDataGridView);
            this.Controls.Add(this.Grd_Cao);
            this.Controls.Add(this.txt_Codpais);
            this.Controls.Add(this.m_EstadosDataGridView);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.Cmb_Pais);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorOperacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EstadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EstadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_EstadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Cao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PaisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonitorOperacionesDataSet monitorOperacionesDataSet;
        private System.Windows.Forms.BindingSource m_PaisBindingSource;
        private MonitorOperacionesDataSetTableAdapters.M_PaisTableAdapter m_PaisTableAdapter;
        private MonitorOperacionesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox Cmb_Pais;
        private MonitorOperacionesDataSetTableAdapters.M_EstadosTableAdapter m_EstadosTableAdapter;
        private System.Windows.Forms.BindingSource m_EstadosBindingSource;
        private System.Windows.Forms.DataGridView m_EstadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox txt_Codpais;
        private System.Windows.Forms.BindingSource m_EstadosBindingSource1;
        private System.Windows.Forms.DataGridView Grd_Cao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView m_PaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}