namespace MOFIN
{
    partial class Frm_VisorCrystalRep
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
            this.monitorOperacionesDataSet = new MOFIN.MonitorOperacionesDataSet();
            this.BS_CClientes = new System.Windows.Forms.BindingSource(this.components);
            this.c_ClientesTableAdapter = new MOFIN.MonitorOperacionesDataSetTableAdapters.C_ClientesTableAdapter();
            this.tableAdapterManager = new MOFIN.MonitorOperacionesDataSetTableAdapters.TableAdapterManager();
            this.Rpt_Clientes1 = new MOFIN.Reportes.Rpt_Clientes();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rpt_Clientes2 = new MOFIN.Reportes.Rpt_Clientes();
            this.CrystalReport11 = new MOFIN.Reportes.CrystalReport1();
            ((System.ComponentModel.ISupportInitialize)(this.monitorOperacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // monitorOperacionesDataSet
            // 
            this.monitorOperacionesDataSet.DataSetName = "MonitorOperacionesDataSet";
            this.monitorOperacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BS_CClientes
            // 
            this.BS_CClientes.DataMember = "C_Clientes";
            this.BS_CClientes.DataSource = this.monitorOperacionesDataSet;
            // 
            // c_ClientesTableAdapter
            // 
            this.c_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.B_BuscadosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.C_ClientesTableAdapter = this.c_ClientesTableAdapter;
            this.tableAdapterManager.C_FirBenAccTableAdapter = null;
            this.tableAdapterManager.C_HistActClientesTableAdapter = null;
            this.tableAdapterManager.C_ValorItemConsExpTableAdapter = null;
            this.tableAdapterManager.M_ActivComercialTableAdapter = null;
            this.tableAdapterManager.M_AntiguedadTableAdapter = null;
            this.tableAdapterManager.M_CriptomonedasTableAdapter = null;
            this.tableAdapterManager.M_EdadTableAdapter = null;
            this.tableAdapterManager.M_EstadosTableAdapter = null;
            this.tableAdapterManager.M_NivelRiesgoTableAdapter = null;
            this.tableAdapterManager.M_PaisTableAdapter = null;
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
            // Rpt_Clientes1
            // 
            this.Rpt_Clientes1.InitReport += new System.EventHandler(this.Rpt_Clientes1_InitReport);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Rpt_Clientes2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1064, 701);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // Frm_VisorCrystalRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 701);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Frm_VisorCrystalRep";
            this.Text = "FrmVisorReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisorReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monitorOperacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Reportes.Rpt_Clientes Rpt_Clientes1;
        private MonitorOperacionesDataSet monitorOperacionesDataSet;
        private System.Windows.Forms.BindingSource BS_CClientes;
        private MonitorOperacionesDataSetTableAdapters.C_ClientesTableAdapter c_ClientesTableAdapter;
        private MonitorOperacionesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Reportes.CrystalReport1 CrystalReport11;
        private Reportes.Rpt_Clientes Rpt_Clientes2;
    }
}