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


namespace MOFIN
{
    public partial class Frm_Clientes : MetroForm
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Entorno.Empresas' Puede moverla o quitarla según sea necesario.
            this.TA_Empresas.Fill(this.DS_Entorno.Empresas);
            this.Modo_Consulta();
            this.Grd_Empresas.Focus();

        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Empresas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (Grd_Empresas.CurrentRow != null)
            {
 
            }
        }

        private void Grd_Empresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modo_Consulta()
        {
            this.Txt_Codigo.Enabled = false;
            this.Txt_Nombre.Enabled = false;
            this.Txt_Siglas.Enabled = false;
            this.Txt_DocID.Enabled = false;
            this.Txt_Email.Enabled = false;
            this.Txt_Direc.Enabled = false;
            this.Txt_Telf1.Enabled = false;
            this.Txt_Telf2.Enabled = false;
            this.Txt_Logo.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Empresas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Txt_Codigo.Enabled = true;
            this.Txt_Nombre.Enabled = true;
            this.Txt_Siglas.Enabled = true;
            this.Txt_DocID.Enabled = true;
            this.Txt_Email.Enabled = true;
            this.Txt_Direc.Enabled = true;
            this.Txt_Telf1.Enabled = true;
            this.Txt_Telf2.Enabled = true;
            this.Txt_Logo.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Empresas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_Empresas.Count <= 1)
            {
                this.TSB_Primero.Enabled = false;
                this.TSB_Anterior.Enabled = false;
                this.TSB_Siguiente.Enabled = false;
                this.TSB_Ultimo.Enabled = false;
            }
            else
            {
                this.TSB_Primero.Enabled = (BS_Empresas.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_Empresas.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_Empresas.Position == BS_Empresas.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_Empresas.Position == BS_Empresas.Count - 1) ? false : true;
            }
        }

        //************
        // Comportamiento de Los Botones 
        //************

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();   
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Empresas.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
            BS_Empresas.AddNew();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
          //  string vl_texto = BS_Empresas.Current("Nombre");      // (char)Grd_Empresas.CurrentRow.Cells["Nombre"].Value;

            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + "***", 
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(vl_Resp == DialogResult.Yes)
            {
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_Empresas.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_Empresas.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_Empresas.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_Empresas.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }

        private void Grd_Empresas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grd_Empresas_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (Grd_Empresas.CurrentRow != null)
            {
                TSB_ActualizaBotonesNavegacion();
            }

        }
    }
}
    