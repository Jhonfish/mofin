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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_CtrlAccGruposOpciones.Grupos_I == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_I; 
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_CtrlAccGruposOpciones.Grupos_I == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_I;
                this.TSB_Modificar.Enabled = Entorno.vs_Maestro ? true : r_CtrlAccGruposOpciones.Grupos_M == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_M;
                this.TSB_Eliminar.Enabled = Entorno.vs_Maestro ? true : r_CtrlAccGruposOpciones.Grupos_E == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_E;
                this.TSB_Imprimir.Enabled = Entorno.vs_Maestro ? true : r_CtrlAccGruposOpciones.Grupos_P == null ? false : (bool)r_CtrlAccGruposOpciones.Grupos_P;
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
        private void TSB_Imprimir_Click(object sender, EventArgs e)
        {

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
            this.Text = Funciones._Mens_Idioma(7300);
            this.Lbl_Codigo.Text = Funciones._Mens_Idioma(1001);
            this.Lbl_Nombre.Text = Funciones._Mens_Idioma(1002);

            this.Pag_Clientes.Text = Funciones._Mens_Idioma(7321);
                this.Chk_Clientes.Text = this.Pag_Clientes.Text;
                this.Chk_CliMonitor.Text= Funciones._Mens_Idioma(7322);
                this.Chk_CliBusqueda.Text= Funciones._Mens_Idioma(7323);

            this.Pag_Operaciones.Text = Funciones._Mens_Idioma(7331);
                this.Chk_MonitorOperaciones.Text = this.Pag_Operaciones.Text;
                this.Chk_MonFinanciero.Text = Funciones._Mens_Idioma(7332);
                this.Chk_MonTransaccional.Text = Funciones._Mens_Idioma(7333);

            this.Pag_Tablas.Text = Funciones._Mens_Idioma(7341);
                this.Chk_TablasMaestras.Text = this.Pag_Tablas.Text;
                this.Chk_TabMaestras.Text = Funciones._Mens_Idioma(7342);

            this.Pag_Reportes.Text = Funciones._Mens_Idioma(7351);
                this.Chk_Reportes.Text = this.Pag_Reportes.Text;

            this.Pag_OpcSistema.Text = Funciones._Mens_Idioma(7311);
                this.Chk_Herramientas.Text = this.Pag_OpcSistema.Text;
                this.Chk_HerUsuarios.Text = Funciones._Mens_Idioma(7200);
                this.Chk_HerGrupos.Text = Funciones._Mens_Idioma(7300);
                this.Chk_HerEmpresas.Text = Funciones._Mens_Idioma(7100);

            this.TSB_Primero.Text = Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = Funciones._Mens_Idioma(140);

            this.Col_Codigo.HeaderText = Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = Funciones._Mens_Idioma(1002);

            Funciones.TTT_Btn(Btn_Aceptar, Funciones._Mens_Idioma(141));
            Funciones.TTT_Btn(Btn_Cancelar, Funciones._Mens_Idioma(142));

            Funciones.TTT_Pic(Pic_Incluir, Funciones._Mens_Idioma(136));
            Funciones.TTT_Pic(Pic_Modificar, Funciones._Mens_Idioma(137));
            Funciones.TTT_Pic(Pic_Eliminar, Funciones._Mens_Idioma(138));
            Funciones.TTT_Pic(Pic_Imprimir, Funciones._Mens_Idioma(139));
            Funciones.TTT_Pic(Pic_ImpExp, Funciones._Mens_Idioma(1024));

        }


    }
}
    