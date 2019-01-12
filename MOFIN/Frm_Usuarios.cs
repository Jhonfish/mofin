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
        //Usuarios t_Usuarios = new Usuarios();
        Usuarios t_Usuarios;

        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
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

        private void Modo_Consulta()
        {
            this.Pan_Elementos.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Usuarios.Enabled = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_Elementos.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Usuarios.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;

            this.Txt_IDUsuario.Focus();
        }
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_Usuarios.Count < 1)
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
            if (Opc_Desktop2.Checked == true)
                t_Usuarios.Cnfg_Desktop = 2;
              else
                t_Usuarios.Cnfg_Desktop = 1;

            if (Opc_Idioma2.Checked == true)
                t_Usuarios.Cnfg_Idioma = 2;
            else
                t_Usuarios.Cnfg_Idioma = 1;

            if (Opc_Pais2.Checked == true)
                t_Usuarios.Cnfg_PaisUso = 2;
            else
                t_Usuarios.Cnfg_PaisUso = 1;

            if (Opc_FormFec2.Checked == true)
                t_Usuarios.Cnfg_FormFecha = 2;
            else
                t_Usuarios.Cnfg_FormFecha = 1;

//            t_Usuarios.Cnfg_Desktop = Opc_Desktop2.Checked == true ? 2 : 1;

            if (vl_EsNuevo)
                NUsuarios.Insertar(t_Usuarios);
                //NUsuarios.Insertar(BS_Usuarios.Current as Usuarios);
            else
                NUsuarios.Actualizar(t_Usuarios);
               // NUsuarios.Actualizar(BS_Usuarios.Current as Usuarios);
                this.Modo_Consulta();
            BS_Usuarios.DataSource = NUsuarios.Listar();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();   
        }
        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Modo_Edicion();
            BS_Usuarios.Add(new Usuarios());
            BS_Usuarios.MoveLast();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            if (BS_Usuarios.Current == null)
                return;
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_IDUsuario.Focus();
        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = t_Usuarios.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NUsuarios.Elimiar(t_Usuarios);
                BS_Usuarios.DataSource = NUsuarios.Listar();
                Grd_Usuarios.Refresh();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    