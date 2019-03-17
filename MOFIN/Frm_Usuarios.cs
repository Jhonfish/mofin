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
        Emp_Accesos r_EmpAccesos = new Emp_Accesos();
        Opc_Sistema r_OpcSistema = new Opc_Sistema();

        public Frm_Usuarios()
        {
            InitializeComponent();

            this.TSB_Primero.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Anterior.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Siguiente.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Ultimo.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.ts_Sep1.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.Asigna_Nombres(null, null);
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            BS_Usuarios.DataSource = NUsuarios.Listar();
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;
            r_EmpAccesos = BS_Emp_Accesos.Current as Emp_Accesos;

            this.Modo_Consulta();
            this.Grd_Usuarios.Focus();
            BS_Empresas.DataSource = NEmpresas.Listar();
            BS_Grupos.DataSource = NGrupos.Listar();
            BS_OpcSistema.DataSource = NOpc_Sistema.Listar();
            r_OpcSistema = BS_OpcSistema.Current as Opc_Sistema;
        }
       //************
        // Comportamiento de Los Botones 
        //************
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
        private void KeyPress_JF(object sender, KeyEventArgs e)
        {
            // Activar el KeyPreview = true en el formulario

            if ((ActiveControl.GetType().Name != "DataGridView") & (this.TSB_Salir.Enabled) & (e.KeyValue == 27 | e.KeyValue == 33 | e.KeyValue == 34 | e.KeyValue == 35 |
                                e.KeyValue == 36 | e.KeyValue == 36 | e.KeyValue == 46 | e.KeyValue == 116 | e.KeyValue == 117 | e.KeyValue == 118 | e.KeyValue == 119))
            {
                //MessageBox.Show(e.KeyCode + " | " + e.KeyData + " | " + e.KeyValue);
                //MessageBox.Show(sender.GetType().ToString());
                //MessageBox.Show(ActiveControl.GetType().Name);

                switch (e.KeyValue)
                {
                    case 27:
                        this.TSB_Salir_Click(false, e);
                        break;
                    case 33:
                        this.TSB_Anterior_Click(false, e);
                        break;
                    case 34:
                        this.TSB_Siguiente_Click(false, e);
                        break;
                    case 35:
                        this.TSB_Ultimo_Click(false, e);
                        break;
                    case 36:
                        this.TSB_Primero_Click(false, e);
                        break;
                    case 46:
                    case 118:
                        this.TSB_Eliminar_Click(false, e);
                        break;
                    case 116:
                        this.TSB_Agregar_Click(false, e);
                        break;
                    case 117:
                        this.TSB_Modificar_Click(false, e);
                        break;
                    case 119:
                        this.TSB_Imprimir_Click(false, e);
                        break;
                }
            }

        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            BS_Usuarios.AddNew();
            //BS_Usuarios.MoveLast();

            r_Usuarios = BS_Usuarios.Current as Usuarios;
            if (r_OpcSistema.IdiomaPredeterminado == 2)
                Opc_Idioma2.Checked = true;
            else
                Opc_Idioma1.Checked = true;
            if (r_OpcSistema.FondoEscritorio == 2)
                Opc_Desktop2.Checked = true;
            else
                Opc_Desktop1.Checked = true;
            if (r_OpcSistema.FormFecha == 2)
                Opc_FormFec2.Checked = true;
            else
                Opc_FormFec1.Checked = true;
            if (r_OpcSistema.PaisUso == 2)
                Opc_Pais2.Checked = true;
            else
                Opc_Pais1.Checked = true;
            Chk_ConfigBtnsBarraHerram.Checked = (bool)r_OpcSistema.BtnsNavegBarraHerram;

            this.Modo_Edicion();
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
                MessageBox.Show(Funciones._Mens_Idioma(9011), Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {

            byte vl_Uno = 1;
            byte vl_Dos = 2;
            r_Usuarios.Cnfg_Desktop = Opc_Desktop2.Checked == true ? vl_Dos : vl_Uno;
            r_Usuarios.Cnfg_Idioma = Opc_Idioma2.Checked == true ? vl_Dos : vl_Uno;
            r_Usuarios.Cnfg_PaisUso = Opc_Pais2.Checked == true ? vl_Dos : vl_Uno;
            r_Usuarios.Cnfg_FormFecha = Opc_FormFec2.Checked == true ? vl_Dos : vl_Uno;

            if (vl_EsNuevo)
                NUsuarios.Insertar(r_Usuarios);
            else
                NUsuarios.Actualizar(r_Usuarios);
            //                NEmp_Accesos.Actualizar(BS_Emp_Accesos.Current as Emp_Accesos);
            this.Modo_Consulta();
            BS_Usuarios.DataSource = NUsuarios.Listar();

            MessageBox.Show(Funciones._Mens_Idioma(9019), Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            BS_Usuarios.CancelEdit();
            r_Usuarios = BS_Usuarios.Current as Usuarios;
            this.Modo_Consulta();
        }

 
        private void Btn_EmpAcc_Inc_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Grd_EmpAccesos.ReadOnly = false;
            BS_Emp_Accesos.AddNew();
            this.Grd_EmpAccesos.Focus();

            Pan_BtnsEmpAccesos.Enabled = false;
            Pan_BotAcpcan_EmpAcc.Visible = true;
        }
        private void Btn_EmpAcc_Mod_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Grd_EmpAccesos.ReadOnly = false;
            this.Grd_EmpAccesos.Focus();

            Pan_BtnsEmpAccesos.Enabled = false;
            Pan_BotAcpcan_EmpAcc.Visible = true;
        }
        private void Btn_EmpAcc_Eli_Click(object sender, EventArgs e)
        {
            r_EmpAccesos = BS_Emp_Accesos.Current as Emp_Accesos;

            string vl_RegEliminar = r_EmpAccesos.Cod_Empresa + " / " + r_EmpAccesos.Cod_Grupo;
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NEmp_Accesos.Elimiar(r_EmpAccesos);
                BS_Emp_Accesos.DataSource = NEmp_Accesos.Listar();
                Grd_EmpAccesos.DataSource = NEmp_Accesos.ListarPorUsuario(r_Usuarios.ID_Usuario.Trim());
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Btn_EmpAcc_Aceptar_Click(object sender, EventArgs e)
        {
            BS_Emp_Accesos.MoveLast();
            r_EmpAccesos = BS_Emp_Accesos.Current as Emp_Accesos;
            r_EmpAccesos.ID_Usuario = r_Usuarios.ID_Usuario;
            if (vl_EsNuevo)
                NEmp_Accesos.Insertar(r_EmpAccesos);
            else
                NEmp_Accesos.Actualizar(r_EmpAccesos);
            //            BS_Emp_Accesos.DataSource = NEmp_Accesos.ListarPorUsuario(r_Usuarios.ID_Usuario);
            //            Grd_EmpAccesos.DataSource = NEmp_Accesos.ListarPorUsuario(r_Usuarios.ID_Usuario.Trim());

            Grd_EmpAccesos.ReadOnly = true;
            Pan_BtnsEmpAccesos.Enabled = true;
            Pan_BotAcpcan_EmpAcc.Visible = false;
            this.Grd_Usuarios_CurrentCellChanged(null,null);
        }
        private void Btn_EmpAcc_Cancelar_Click(object sender, EventArgs e)
        {
            BS_Emp_Accesos.CancelEdit();
            BS_Emp_Accesos.MoveFirst();
            Grd_EmpAccesos.ReadOnly = true;

            Pan_BtnsEmpAccesos.Enabled = true;
            Pan_BotAcpcan_EmpAcc.Visible = false;
        }
        private void TSB_Imprimir_Click(object sender, EventArgs e)
        {

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
                r_Usuarios.Cnfg_BarraHerramientas = Chk_ConfigBtnsBarraHerram.Checked;

                if (r_Usuarios.ID_Usuario != null & r_Usuarios.ID_Usuario != "")
                {
                    BS_Emp_Accesos.DataSource = NEmp_Accesos.ListarPorUsuario(r_Usuarios.ID_Usuario.Trim());
                    Grd_EmpAccesos.DataSource = BS_Emp_Accesos;
                    r_EmpAccesos = BS_Emp_Accesos.Current as Emp_Accesos;
                }
                TSB_ActualizaBotonesNavegacion();
            }
        }

        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = Funciones._Mens_Idioma(7200);
            this.Lbl_IDUsuario.Text = Funciones._Mens_Idioma(7201);
            this.Lbl_Nombre.Text = Funciones._Mens_Idioma(1002);
            this.Lbl_Password.Text = Funciones._Mens_Idioma(1008);
            this.Lbl_FondoEscritorio.Text = Funciones._Mens_Idioma(7202);
            this.Lbl_Idioma.Text = Funciones._Mens_Idioma(7203);
            this.Lbl_PaisUso.Text = Funciones._Mens_Idioma(7204);
            this.Lbl_FormatoFecha.Text = Funciones._Mens_Idioma(7205);
            //this.Chk_Sonido.Text = Funciones._Mens_Idioma(7206);
            this.Col_Empresa.HeaderText = Funciones._Mens_Idioma(7100);
            this.Col_Grupo.HeaderText = Funciones._Mens_Idioma(7300);

            this.Opc_Desktop1.Text = Funciones._Mens_Idioma(7207);
            this.Opc_Desktop2.Text = Funciones._Mens_Idioma(7208);
            this.Opc_Idioma1.Text = Funciones._Mens_Idioma(311);
            this.Opc_Idioma2.Text = Funciones._Mens_Idioma(312);
            this.Opc_Pais1.Text = Funciones._Mens_Idioma(301);
            this.Opc_Pais2.Text = Funciones._Mens_Idioma(302);
            this.Chk_ConfigBtnsBarraHerram.Text = Funciones._Mens_Idioma(7209);

            this.TSB_Primero.Text = Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = Funciones._Mens_Idioma(140);

            this.Col_ID_Usuario.HeaderText = Funciones._Mens_Idioma(7201);
            this.Col_Nombre.HeaderText = Funciones._Mens_Idioma(1002);

            Funciones.TTT_Btn(Btn_Aceptar, Funciones._Mens_Idioma(141));
            Funciones.TTT_Btn(Btn_Cancelar, Funciones._Mens_Idioma(142));
        }

        private void Modo_Consulta()
        {
            this.Pan_Elementos.Enabled = false;
            this.Pan_ElementControlados.Enabled = false;
            this.Pan_BtnsEmpAccesos.Visible = false;

            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Usuarios.Enabled = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_Elementos.Enabled = true;
            this.Pan_ElementControlados.Enabled = (bool)r_OpcSistema.PermitUserCamParam;
            this.Pan_BtnsEmpAccesos.Visible = true;

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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Usuarios_I == null ? false : (bool)r_GrupoOpciones.Usuarios_I;
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Usuarios_I == null ? false : (bool)r_GrupoOpciones.Usuarios_I;
                this.TSB_Modificar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Usuarios_M == null ? false : (bool)r_GrupoOpciones.Usuarios_M;
                this.TSB_Eliminar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Usuarios_E == null ? false : (bool)r_GrupoOpciones.Usuarios_E;
                this.TSB_Imprimir.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Usuarios_P == null ? false : (bool)r_GrupoOpciones.Usuarios_P;
            }
        }


    }

}
    