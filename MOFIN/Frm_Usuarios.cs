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
using MOFIN_LIB;

namespace MOFIN
{
    public partial class Frm_Usuarios : MetroForm
    {
        bool vl_EsNuevo = true;
        Usuarios r_Usuarios = new Usuarios();
        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();

        public Frm_Usuarios()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            BS_Usuarios.DataSource = NUsuarios.Listar();
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            this.Modo_Consulta();
            this.Grd_Usuarios.Focus();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Usuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Usuarios = BS_Usuarios.Current as Usuarios;
            if (Grd_Usuarios.CurrentRow != null)
            {
                Opc_Desktop1.Checked = r_Usuarios.Cnfg_Desktop.ToString() == "1" ? true : false;    // Fijo
                Opc_Desktop2.Checked = r_Usuarios.Cnfg_Desktop.ToString() == "2" ? true : false;    // Aleatorio
                Opc_Idioma1.Checked = r_Usuarios.Cnfg_Idioma.ToString() == "1" ? true : false;      // Español
                Opc_Idioma2.Checked = r_Usuarios.Cnfg_Idioma.ToString() == "2" ? true : false;      // Inglés
                Opc_Pais1.Checked = r_Usuarios.Cnfg_PaisUso.ToString() == "1" ? true : false;      // Venezuela
                Opc_Pais2.Checked = r_Usuarios.Cnfg_PaisUso.ToString() == "2" ? true : false;      // Panamá
                Opc_FormFec1.Checked = r_Usuarios.Cnfg_FormFecha.ToString() == "1" ? true : false; // DD/MM/AAAA
                Opc_FormFec2.Checked = r_Usuarios.Cnfg_FormFecha.ToString() == "2" ? true : false; // MM/DD/AAAA
            }
            Grd_EmpAccesos.DataSource = NEmp_Accesos.ListarPorUsuario(r_Usuarios.ID_Usuario.Trim());
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
                this.TSB_Agregar.Enabled = r_GrupoOpciones.Usuarios_I == null ? false : (bool)r_GrupoOpciones.Usuarios_I; 
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
                this.TSB_Agregar.Enabled = r_GrupoOpciones.Usuarios_I == null ? false : (bool)r_GrupoOpciones.Usuarios_I;
                this.TSB_Modificar.Enabled = r_GrupoOpciones.Usuarios_M == null ? false : (bool)r_GrupoOpciones.Usuarios_M;
                this.TSB_Eliminar.Enabled = r_GrupoOpciones.Usuarios_E == null ? false : (bool)r_GrupoOpciones.Usuarios_E;
                this.TSB_Imprimir.Enabled = r_GrupoOpciones.Usuarios_P == null ? false : (bool)r_GrupoOpciones.Usuarios_P;
            }
        }

        //************
        // Comportamiento de Los Botones 
        //************

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {

            byte vl_Uno = 1;
            byte vl_Dos = 2;
            r_Usuarios.Cnfg_Desktop = Opc_Desktop2.Checked == true ? vl_Dos : vl_Uno;
            r_Usuarios.Cnfg_Idioma  = Opc_Idioma2.Checked == true ? vl_Dos : vl_Uno;
            r_Usuarios.Cnfg_PaisUso = Opc_Pais2.Checked == true ? vl_Dos : vl_Uno;
            r_Usuarios.Cnfg_FormFecha = Opc_FormFec2.Checked == true ? vl_Dos : vl_Uno;

            if (vl_EsNuevo)
                NUsuarios.Insertar(r_Usuarios);
                //NUsuarios.Insertar(BS_Usuarios.Current as Usuarios);
            else
                NUsuarios.Actualizar(r_Usuarios);
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
            string vl_RegEliminar = r_Usuarios.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NUsuarios.Elimiar(r_Usuarios);
                BS_Usuarios.DataSource = NUsuarios.Listar();
                Grd_Usuarios.Refresh();
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(2200);
            this.Lbl_IDUsuario.Text = MOFIN_LIB.Funciones._Mens_Idioma(2201);
            this.Lbl_Nombre.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_Password.Text = MOFIN_LIB.Funciones._Mens_Idioma(1008);
            this.Lbl_FondoEscritorio.Text = MOFIN_LIB.Funciones._Mens_Idioma(2202);
            this.Lbl_Idioma.Text = MOFIN_LIB.Funciones._Mens_Idioma(2203);
            this.Lbl_PaisUso.Text = MOFIN_LIB.Funciones._Mens_Idioma(2204);
            this.Lbl_FormatoFecha.Text = MOFIN_LIB.Funciones._Mens_Idioma(2205);
            //this.Chk_Sonido.Text = MOFIN_LIB.Funciones._Mens_Idioma(2206);

            this.Opc_Desktop1.Text = MOFIN_LIB.Funciones._Mens_Idioma(2207);
            this.Opc_Desktop2.Text = MOFIN_LIB.Funciones._Mens_Idioma(2208);
            this.Opc_Idioma1.Text = MOFIN_LIB.Funciones._Mens_Idioma(311);
            this.Opc_Idioma2.Text = MOFIN_LIB.Funciones._Mens_Idioma(312);
            this.Opc_Pais1.Text = MOFIN_LIB.Funciones._Mens_Idioma(301);
            this.Opc_Pais2.Text = MOFIN_LIB.Funciones._Mens_Idioma(302);

            this.TSB_Primero.Text = MOFIN_LIB.Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = MOFIN_LIB.Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = MOFIN_LIB.Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = MOFIN_LIB.Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = MOFIN_LIB.Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = MOFIN_LIB.Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = MOFIN_LIB.Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = MOFIN_LIB.Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = MOFIN_LIB.Funciones._Mens_Idioma(140);

            this.Col_ID_Usuario.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(2201);
            this.Col_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }

    }
}
    