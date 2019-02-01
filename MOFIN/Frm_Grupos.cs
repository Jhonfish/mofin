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
    public partial class Frm_Grupos : MetroForm
    {
        bool vl_EsNuevo = true;
        Grupos r_Grupos = new Grupos();
        Grupo_Opciones r_GruposOpciones = new Grupo_Opciones();
        Grupo_Opciones r_CtrlAccGruposOpciones = new Grupo_Opciones();

        public Frm_Grupos()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_Grupos_Load(object sender, EventArgs e)
        {
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_CtrlAccGruposOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            BS_Grupos.DataSource = NGrupos.Listar();
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.Listar();

            this.Modo_Consulta();
            this.Grd_Grupos.Focus();
        }
        //************
        // Comportamiento de Los Botones 
        //************
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_Grupos.Count < 1)
            {
                this.TSB_Primero.Enabled = false;
                this.TSB_Anterior.Enabled = false;
                this.TSB_Siguiente.Enabled = false;
                this.TSB_Ultimo.Enabled = false;
                this.TSB_Agregar.Enabled = r_CtrlAccGruposOpciones.Grupos_I == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_I; 
                this.TSB_Modificar.Enabled = false;
                this.TSB_Eliminar.Enabled = false;
                this.TSB_Imprimir.Enabled = false;
            }
            else
            {
                this.TSB_Primero.Enabled = (BS_Grupos.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_Grupos.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_Grupos.Position == BS_Grupos.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_Grupos.Position == BS_Grupos.Count - 1) ? false : true;
                this.TSB_Agregar.Enabled = r_CtrlAccGruposOpciones.Grupos_I == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_I;
                this.TSB_Modificar.Enabled = r_CtrlAccGruposOpciones.Grupos_M == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_M;
                this.TSB_Eliminar.Enabled = r_CtrlAccGruposOpciones.Grupos_E == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_E;
                this.TSB_Imprimir.Enabled = r_CtrlAccGruposOpciones.Grupos_P == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_P;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (vl_EsNuevo)
            {
                r_GruposOpciones.Cod_Grupo = r_Grupos.Codigo;
                NGrupos.Insertar(r_Grupos);
                NGrupo_Opciones.Insertar(r_GruposOpciones);
            }
            else
            {
                NGrupos.Actualizar(r_Grupos);
                NGrupo_Opciones.Actualizar(r_GruposOpciones);
            }
            this.Modo_Consulta();
            BS_Grupos.DataSource = NGrupos.Listar();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            BS_Grupos.Add(r_Grupos);
            BS_Grupos.MoveLast();
            BS_Grupo_Opciones.Add(r_GruposOpciones);
            BS_Grupo_Opciones.MoveLast();

            r_Grupos = BS_Grupos.Current as Grupos;
            r_GruposOpciones = BS_Grupo_Opciones.AddNew() as Grupo_Opciones;

            this.Modo_Edicion();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            if (BS_Grupos.Current == null)
                return;
            vl_EsNuevo = false;
            r_Grupos = BS_Grupos.Current as Grupos;
            r_GruposOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            this.Modo_Edicion();
        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = r_Grupos.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NGrupo_Opciones.Elimiar(BS_Grupo_Opciones.Current as Grupo_Opciones);
                NGrupos.Elimiar(BS_Grupos.Current as Grupos);
                BS_Grupos.DataSource = NGrupos.Listar();
                r_Grupos = BS_Grupos.Current as Grupos;
                BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(r_Grupos.Codigo);
                Grd_Grupos.Refresh();
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_Grupos.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_Grupos.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_Grupos.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_Grupos.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Grupos_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Grupos = BS_Grupos.Current as Grupos;
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(r_Grupos.Codigo);
            r_GruposOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Consulta()
        { 
            this.Pan_Elementos.Enabled = false;
            this.Pan_Elementos1.Enabled = false;
            this.Pan_Elementos2.Enabled = false;
            this.Pan_Elementos3.Enabled = false;
            this.Pan_Elementos4.Enabled = false;
            this.Pan_Elementos5.Enabled = false;
            this.TS_BarraHerramientas.Enabled = true;

            this.Grd_Grupos.Enabled = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_Elementos.Enabled = true;
            this.Txt_Codigo.Enabled = vl_EsNuevo;
            this.Pan_Elementos1.Enabled = true;
            this.Pan_Elementos2.Enabled = true;
            this.Pan_Elementos3.Enabled = true;
            this.Pan_Elementos4.Enabled = true;
            this.Pan_Elementos5.Enabled = true;
            this.TS_BarraHerramientas.Enabled = false;

            this.Grd_Grupos.Enabled = false;
            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;

            this.Txt_Codigo.Focus();
        }

        
        private void Chk_CliMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_CliMonitor.Checked == true & this.Chk_Clientes.Checked == false)
            {
                r_Grupos.Clientes = true;
                this.Chk_Clientes.Checked = true;
            }
        }

        private void Chk_CliBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_CliBusqueda.Checked == true & this.Chk_Clientes.Checked == false)
            {
                r_Grupos.Clientes = true;
                this.Chk_Clientes.Checked = true;
            }
        }

        private void Chk_MonFinanciero_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_MonFinanciero.Checked == true & this.Chk_MonitorOperaciones.Checked == false)
            {
                r_Grupos.Mon_Operaciones = true;
                this.Chk_MonitorOperaciones.Checked = true;
            }
        }

        private void Chk_MonTransaccional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_MonTransaccional.Checked == true & this.Chk_MonitorOperaciones.Checked == false)
            {
                r_Grupos.Mon_Operaciones = true;
                this.Chk_MonitorOperaciones.Checked = true;
            }
        }

        private void Chk_TabMaestras_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_TabMaestras.Checked == true & this.Chk_TablasMaestras.Checked == false)
            {
                r_Grupos.Tablas_Maestras = true;
                this.Chk_TablasMaestras.Checked = true;
            }
        }

        private void Chk_HerUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_HerUsuarios.Checked == true & this.Chk_Herramientas.Checked == false)
            {
                r_Grupos.Opc_Sistema = true;
                this.Chk_Herramientas.Checked = true;
            }
        }

        private void Chk_HerGrupos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_HerGrupos.Checked == true & this.Chk_Herramientas.Checked == false)
            {
                r_Grupos.Opc_Sistema = true;
                this.Chk_Herramientas.Checked = true;
            }
        }

        private void Chk_HerEmpresas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_HerEmpresas.Checked == true & this.Chk_Herramientas.Checked == false)
            {
                r_Grupos.Opc_Sistema = true;
                this.Chk_Herramientas.Checked = true;
            }
        }
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(2300);
            this.Lbl_Codigo.Text = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Lbl_Nombre.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);

            this.Pag_Clientes.Text = MOFIN_LIB.Funciones._Mens_Idioma(2321);
                this.Chk_Clientes.Text = this.Pag_Clientes.Text;
                this.Chk_CliMonitor.Text= MOFIN_LIB.Funciones._Mens_Idioma(2322);
                this.Chk_CliBusqueda.Text= MOFIN_LIB.Funciones._Mens_Idioma(2323);

            this.Pag_Operaciones.Text = MOFIN_LIB.Funciones._Mens_Idioma(2331);
                this.Chk_MonitorOperaciones.Text = this.Pag_Operaciones.Text;
                this.Chk_MonFinanciero.Text = MOFIN_LIB.Funciones._Mens_Idioma(2332);
                this.Chk_MonTransaccional.Text = MOFIN_LIB.Funciones._Mens_Idioma(2333);

            this.Pag_Tablas.Text = MOFIN_LIB.Funciones._Mens_Idioma(2341);
                this.Chk_TablasMaestras.Text = this.Pag_Tablas.Text;
                this.Chk_TabMaestras.Text = MOFIN_LIB.Funciones._Mens_Idioma(2342);

            this.Pag_Reportes.Text = MOFIN_LIB.Funciones._Mens_Idioma(2351);
                this.Chk_Reportes.Text = this.Pag_Reportes.Text;

            this.Pag_OpcSistema.Text = MOFIN_LIB.Funciones._Mens_Idioma(2311);
                this.Chk_Herramientas.Text = this.Pag_OpcSistema.Text;
                this.Chk_HerUsuarios.Text = MOFIN_LIB.Funciones._Mens_Idioma(2200);
                this.Chk_HerGrupos.Text = MOFIN_LIB.Funciones._Mens_Idioma(2300);
                this.Chk_HerEmpresas.Text = MOFIN_LIB.Funciones._Mens_Idioma(2100);

            this.TSB_Primero.Text = MOFIN_LIB.Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = MOFIN_LIB.Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = MOFIN_LIB.Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = MOFIN_LIB.Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = MOFIN_LIB.Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = MOFIN_LIB.Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = MOFIN_LIB.Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = MOFIN_LIB.Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = MOFIN_LIB.Funciones._Mens_Idioma(140);

            this.Col_Codigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }
    }
}
    