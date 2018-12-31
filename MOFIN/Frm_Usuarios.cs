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
    public partial class Frm_Usuarios : MetroForm
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.TA_Usuarios.Fill(this.DS_Entorno.Usuarios);
            this.Modo_Consulta();
            this.Grd_Usuarios.Focus();

        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Usuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (Grd_Usuarios.CurrentRow != null)
            {
                Opc_Desktop1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Desktop"].Value.ToString() == "1" ? true : false;    // Fijo
                Opc_Desktop2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Desktop"].Value.ToString() == "2" ? true : false;    // Aleatorio

                Opc_Idioma1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Idioma"].Value.ToString() == "1" ? true : false;      // Español
                Opc_Idioma2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Idioma"].Value.ToString() == "2" ? true : false;      // Inglés

                Opc_Pais1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_PaisUso"].Value.ToString() == "1" ? true : false;      // Venezuela
                Opc_Pais2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_PaisUso"].Value.ToString() == "2" ? true : false;      // Panamá

                Opc_FormFec1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_FormFecha"].Value.ToString() == "1" ? true : false; // DD/MM/AAAA
                Opc_FormFec2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_FormFecha"].Value.ToString() == "2" ? true : false; // MM/DD/AAAA

            }
            TSB_ActualizaBotonesNavegacion();
        }

        private void Grd_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modo_Consulta()
        {
            this.Txt_IDUsuario.Enabled = false;
            this.Txt_Nombre.Enabled = false;
            this.Txt_Password.Enabled = false;
            this.Grp_Desktop.Enabled = false;
            this.Grp_FormatoFecha.Enabled = false;
            this.Grp_Idioma.Enabled = false;
            this.Grp_Pais.Enabled = false;
            this.Chk_Sonido.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Usuarios.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Txt_IDUsuario.Enabled = true;
            this.Txt_Nombre.Enabled = true;
            this.Txt_Password.Enabled = true;
            this.Grp_Desktop.Enabled = true;
            this.Grp_FormatoFecha.Enabled = true;
            this.Grp_Idioma.Enabled = true;
            this.Grp_Pais.Enabled = true;
            this.Chk_Sonido.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Usuarios.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_Usuarios.Count <= 1)
            {
                this.TSB_Primero.Enabled = false;
                this.TSB_Anterior.Enabled = false;
                this.TSB_Siguiente.Enabled = false;
                this.TSB_Ultimo.Enabled = false;
                this.TSB_Modificar.Enabled = false;
                this.TSB_Eliminar.Enabled = false;
                this.TSB_Imprimir.Enabled = false;

            }
            else
            {
                this.TSB_Primero.Enabled = (BS_Usuarios.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_Usuarios.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_Usuarios.Position == BS_Usuarios.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_Usuarios.Position == BS_Usuarios.Count - 1) ? false : true;
                this.TSB_Modificar.Enabled = true;
                this.TSB_Eliminar.Enabled = true;
                this.TSB_Imprimir.Enabled = true;
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
            this.BS_Usuarios.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
            BS_Usuarios.AddNew();

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
            string vl_RegEliminar = ((DataRowView)this.BS_Usuarios.Current).Row["Nombre"].ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar, 
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(vl_Resp == DialogResult.Yes)
            {
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_Usuarios.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_Usuarios.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_Usuarios.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_Usuarios.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }

    }
}
    