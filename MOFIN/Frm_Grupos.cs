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
    public partial class Frm_Grupos : MetroForm
    {
        bool vl_EsNuevo = true;
        Grupos t_Grupos = new Grupos();
        Grupo_Opciones t_GruposOpciones = new Grupo_Opciones();

        public Frm_Grupos()
        {
            InitializeComponent();
        }

        private void Frm_Grupos_Load(object sender, EventArgs e)
        {
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
            if (BS_Grupos.Count <= 1)
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
                this.TSB_Primero.Enabled = (BS_Grupos.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_Grupos.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_Grupos.Position == BS_Grupos.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_Grupos.Position == BS_Grupos.Count - 1) ? false : true;
                this.TSB_Modificar.Enabled = true;
                this.TSB_Eliminar.Enabled = true;
                this.TSB_Imprimir.Enabled = true;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (vl_EsNuevo)
            {
                t_GruposOpciones.Cod_Grupo = t_Grupos.Codigo;
                NGrupos.Insertar(t_Grupos);
                NGrupo_Opciones.Insertar(t_GruposOpciones);
            }
            else
            {
                NGrupos.Actualizar(t_Grupos);
                NGrupo_Opciones.Actualizar(t_GruposOpciones);
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
            BS_Grupos.Add(t_Grupos);
            BS_Grupos.MoveLast();
            BS_Grupo_Opciones.Add(t_GruposOpciones);
            BS_Grupo_Opciones.MoveLast();

            t_Grupos = BS_Grupos.Current as Grupos;
            t_GruposOpciones = BS_Grupo_Opciones.AddNew() as Grupo_Opciones;

            this.Modo_Edicion();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            if (BS_Grupos.Current == null)
                return;
            vl_EsNuevo = false;
            t_Grupos = BS_Grupos.Current as Grupos;
            t_GruposOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            this.Modo_Edicion();
        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = t_Grupos.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NGrupos.Elimiar(BS_Grupos.Current as Grupos);
                BS_Grupos.DataSource = NGrupos.Listar();
                Grd_Grupos.Refresh();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            t_Grupos = BS_Grupos.Current as Grupos;
            t_GruposOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;
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
                t_Grupos.Clientes = true;
                this.Chk_Clientes.Checked = true;
            }
        }

        private void Chk_CliBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_CliBusqueda.Checked == true & this.Chk_Clientes.Checked == false)
            {
                t_Grupos.Clientes = true;
                this.Chk_Clientes.Checked = true;
            }
        }

        private void Chk_MonFinanciero_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_MonFinanciero.Checked == true & this.Chk_MonitorOperaciones.Checked == false)
            {
                t_Grupos.Mon_Operaciones = true;
                this.Chk_MonitorOperaciones.Checked = true;
            }
        }

        private void Chk_MonTransaccional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_MonTransaccional.Checked == true & this.Chk_MonitorOperaciones.Checked == false)
            {
                t_Grupos.Mon_Operaciones = true;
                this.Chk_MonitorOperaciones.Checked = true;
            }
        }

        private void Chk_TabMaestras_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_TabMaestras.Checked == true & this.Chk_TablasMaestras.Checked == false)
            {
                t_Grupos.Tablas_Maestras = true;
                this.Chk_TablasMaestras.Checked = true;
            }
        }

        private void Chk_HerUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_HerUsuarios.Checked == true & this.Chk_Herramientas.Checked == false)
            {
                t_Grupos.Opc_Sistema = true;
                this.Chk_Herramientas.Checked = true;
            }
        }

        private void Chk_HerGrupos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_HerGrupos.Checked == true & this.Chk_Herramientas.Checked == false)
            {
                t_Grupos.Opc_Sistema = true;
                this.Chk_Herramientas.Checked = true;
            }
        }

        private void Chk_HerEmpresas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_HerEmpresas.Checked == true & this.Chk_Herramientas.Checked == false)
            {
                t_Grupos.Opc_Sistema = true;
                this.Chk_Herramientas.Checked = true;
            }
        }
    }
}
    