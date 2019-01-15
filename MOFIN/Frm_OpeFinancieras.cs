using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MofinNegocios;
using MofinModelo;
using MofinModeloEntorno;


namespace MOFIN
{
    public partial class Frm_OpeFinancieras : MetroForm
    {
        bool vl_EsNuevo = false;

        public Frm_OpeFinancieras()
        {
            InitializeComponent();
        }

        private void Frm_OpeFinancieras_Load(object sender, EventArgs e)
        {
            this.Cmb_TipArchExport.SelectedIndex = 0;
            this.Height = 630;
            BS_CClientes.DataSource = NC_Clientes.Listar();
            
        }
        private void Modo_Consulta()
        {
            this.Pan_BtnsPerfil.Enabled = true;
            this.Pan_BtnsObserv.Enabled = true;
            this.Pan_Pag1.Enabled = true;
            this.Pan_Pag3.Enabled = true;
            this.Grd_ClieInfInversor.Enabled = true;
            this.Grd_Observaciones.Enabled = true;
            this.Grd_HistPerfOperac.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;
        }

        private void Modo_Edicion(int vl_Opcion)
        {
            this.Chk_Exportar.Checked = false;
            this.Chk_Exportar_CheckStateChanged(null, null);

            this.Pan_BtnsPerfil.Enabled = false;
            this.Pan_BtnsObserv.Enabled = false;
            this.Pan_Pag1.Enabled = false;
            this.Pan_Pag3.Enabled = false;
            this.Grd_ClieInfInversor.Enabled = false;
            if (vl_Opcion == 1)
                this.Grd_Observaciones.Enabled = false;
            else
                this.Grd_HistPerfOperac.Enabled = false;


            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }

        /// *****************************
        /// Comportamiento de los Botones
        /// *****************************
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }
        private void Chk_Exportar_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.Chk_Exportar.Checked == true)
                this.Height = 700;
            else
                this.Height = 630;
        }

        private void Chk_Reporte_CheckedChanged(object sender, EventArgs e)
        {
            this.Pan_Reporte.Visible = this.Chk_Reporte.Checked;
        }

        private void Btn_PerfInc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Modo_Edicion(1);
        }

        private void Btn_ObsInc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Modo_Edicion(2);
        }

        private void Btn_PerfMod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Modo_Edicion(1);
        }

        private void Btn_ObsMod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Modo_Edicion(2);
        }

        private void Btn_PerfEli_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = "Prueba elimiar Historico de Perfil Financiero"; // t_Usuarios.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
//                NUsuarios.Elimiar(t_Usuarios);
//                BS_Usuarios.DataSource = NUsuarios.Listar();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_ObsEli_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = "Prueba elimiar Observación del Perfil Financiero"; // t_Usuarios.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                //                NUsuarios.Elimiar(t_Usuarios);
                //                BS_Usuarios.DataSource = NUsuarios.Listar();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Txt_NmeArchExport_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog vl_ArchivoExport = new OpenFileDialog();

//            vl_ArchivoExport.InitialDirectory = "c:\\";
            vl_ArchivoExport.Filter = this.Cmb_TipArchExport.Text.Trim();   
//            vl_ArchivoExport.FilterIndex = 0;
//            vl_ArchivoExport.RestoreDirectory = true;
            vl_ArchivoExport.CheckFileExists = false;

            if (vl_ArchivoExport.ShowDialog() == DialogResult.OK)
                this.Txt_NmeArchExport.Text = vl_ArchivoExport.FileName;
        }
    }
}
