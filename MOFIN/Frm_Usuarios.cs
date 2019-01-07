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
    public partial class Frm_Usuarios : MetroForm
    {
        bool vl_EsNuevo = true;
        Usuarios t_Usuarios = new Usuarios();

        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            //this.TA_Usuarios.Fill(this.DS_Entorno.Usuarios);
            BS_Usuarios.DataSource = NUsuarios.Listar();

            this.Modo_Consulta();
            this.Grd_Usuarios.Focus();

        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Usuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            t_Usuarios = BS_Usuarios.Current as Usuarios;

            
            if (Grd_Usuarios.CurrentRow != null)
            {
                /*
                if (Grd_Usuarios.CurrentRow.Cells["Cnfg_Desktop"].Value != null)
                {
                    Opc_Desktop1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Desktop"].Value.ToString() == "1" ? true : false;    // Fijo
                    Opc_Desktop2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Desktop"].Value.ToString() == "2" ? true : false;    // Aleatorio
                }
                else
                {
                    Opc_Desktop1.Checked = false;    // Fijo
                    Opc_Desktop2.Checked = false;    // Aleatorio
                }
                if (Grd_Usuarios.CurrentRow.Cells["Cnfg_Idioma"].Value != null)
                {
                    Opc_Idioma1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Idioma"].Value.ToString() == "1" ? true : false;      // Español
                    Opc_Idioma2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_Idioma"].Value.ToString() == "2" ? true : false;      // Inglés
                }
                else
                {
                    Opc_Idioma1.Checked = false;    // Español
                    Opc_Idioma2.Checked = false;    // Ingles
                }
                if (Grd_Usuarios.CurrentRow.Cells["Cnfg_PaisUso"].Value != null)
                {
                    Opc_Pais1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_PaisUso"].Value.ToString() == "1" ? true : false;      // Venezuela
                    Opc_Pais2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_PaisUso"].Value.ToString() == "2" ? true : false;      // Panamá
                }
                else
                {
                    Opc_Pais1.Checked = false;    // Venezuela
                    Opc_Pais2.Checked = false;    // panamá
                }
                if (Grd_Usuarios.CurrentRow.Cells["Cnfg_FormFecha"].Value != null)
                {
                    Opc_FormFec1.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_FormFecha"].Value.ToString() == "1" ? true : false; // DD/MM/AAAA
                    Opc_FormFec2.Checked = Grd_Usuarios.CurrentRow.Cells["Cnfg_FormFecha"].Value.ToString() == "2" ? true : false; // MM/DD/AAAA
                }
                else
                {
                    Opc_FormFec1.Checked = false;    // DD/MM/AAAA
                    Opc_FormFec2.Checked = false;    // MM/DD/AAAA
                }
                */
                Opc_Desktop1.Checked = t_Usuarios.Cnfg_Desktop.ToString() == "1" ? true : false;    // Fijo
                Opc_Desktop2.Checked = t_Usuarios.Cnfg_Desktop.ToString() == "2" ? true : false;    // Aleatorio
                Opc_Idioma1.Checked = t_Usuarios.Cnfg_Idioma.ToString() == "1" ? true : false;      // Español
                Opc_Idioma2.Checked = t_Usuarios.Cnfg_Idioma.ToString() == "2" ? true : false;      // Inglés
                Opc_Pais1.Checked = t_Usuarios.Cnfg_PaisUso.ToString() == "1" ? true : false;      // Venezuela
                Opc_Pais2.Checked = t_Usuarios.Cnfg_PaisUso.ToString() == "2" ? true : false;      // Panamá
                Opc_FormFec1.Checked = t_Usuarios.Cnfg_FormFecha.ToString() == "1" ? true : false; // DD/MM/AAAA
                Opc_FormFec2.Checked = t_Usuarios.Cnfg_FormFecha.ToString() == "2" ? true : false; // MM/DD/AAAA

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

            this.Txt_IDUsuario.Focus();
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
            if (vl_EsNuevo)
                //NM_Edad.Insertar(mEdadBindingSource.Current as M_Edad);
                //NM_Edad.Insertar(m_Edad);
                NUsuarios.Insertar(t_Usuarios);
            else
            {
                //NM_Edad.Actualizar(mEdadBindingSource.Current as M_Edad);
                //NUsuarios.Actualizar(BS_Usuarios.Current as Usuarios);
                //t_Usuarios.Nombre = Txt_Nombre.Text;
                //t_Usuarios.Password = Txt_Password.Text;
                NUsuarios.Actualizar(t_Usuarios);
                this.Modo_Consulta();
                BS_Usuarios.DataSource = NUsuarios.Listar();
                //Grd_Usuarios.Refresh();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();   
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Usuarios.EndEdit();
//            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            /*
            this.Txt_IDUsuario.Clear();
            this.Txt_Nombre.Clear();
            this.Txt_Password.Clear();
            this.Opc_Desktop1.Checked = false;
            this.Opc_Desktop2.Checked = false;
            this.Opc_FormFec1.Checked = false;
            this.Opc_FormFec2.Checked = false;
            this.Opc_Idioma1.Checked = false;
            this.Opc_Idioma2.Checked = false;
            this.Opc_Pais1.Checked = false;
            this.Opc_Pais2.Checked = false;
            this.Chk_Sonido.Checked = false;

            t_Usuarios.ID_Usuario = this.Txt_IDUsuario.Text.Trim();
            t_Usuarios.Nombre = this.Txt_Nombre.Text.Trim();
            t_Usuarios.Password = this.Txt_Password.Text.Trim();
 //           t_Usuarios.Cnfg_SonidoClick = (this.Chk_Sonido.CheckState = true) ? true : false;
            */
            vl_EsNuevo = true;
            this.Modo_Edicion();
            BS_Usuarios.Add(t_Usuarios);
            BS_Usuarios.MoveLast();
//            BS_Usuarios.AddNew();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (BS_Usuarios.Current == null)
                return;
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_IDUsuario.Focus();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = "";
            //string vl_RegEliminar = t_Usuarios.Nombre.ToString();
            if (Grd_Usuarios.CurrentRow.Cells["Nombre"].Value != null)
            {
                vl_RegEliminar = Grd_Usuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar, 
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(vl_Resp == DialogResult.Yes)
            {
                //NM_Edad.Elimiar(mEdadBindingSource.Current as M_Edad);
                NUsuarios.Elimiar(BS_Usuarios.Current as Usuarios);
                BS_Usuarios.DataSource = NUsuarios.Listar();
                Grd_Usuarios.Refresh();
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
    