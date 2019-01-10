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
    public partial class Frm_Empresas: MetroForm
    {
        bool vl_EsNuevo = true;
        Empresas t_Empresas = new Empresas();

        public Frm_Empresas()
        {
            InitializeComponent();
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            BS_Empresas.DataSource = NEmpresas.Listar();
            this.Modo_Consulta();
            this.Grd_Empresas.Focus();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Empresas_CurrentCellChanged(object sender, EventArgs e)
        {
            t_Empresas = BS_Empresas.Current as Empresas;
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Consulta()
        {
            this.Pan_Elementos.Enabled = false;
            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Empresas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_Elementos.Enabled = true;
            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Empresas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }

        //************
        // Comportamiento de Los Botones 
        //************
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_Empresas.Count <= 1)
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
                this.TSB_Primero.Enabled = (BS_Empresas.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_Empresas.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_Empresas.Position == BS_Empresas.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_Empresas.Position == BS_Empresas.Count - 1) ? false : true;
                this.TSB_Modificar.Enabled = true;
                this.TSB_Eliminar.Enabled = true;
                this.TSB_Imprimir.Enabled = true;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (vl_EsNuevo)
                //NEmpresas.Insertar(t_Empresas);
                NEmpresas.Insertar(BS_Empresas.Current as Empresas);
            else
                //NEmpresas.Actualizar(t_Empresas);
                NEmpresas.Actualizar(BS_Empresas.Current as Empresas);
            this.Modo_Consulta();
            BS_Empresas.DataSource = NEmpresas.Listar();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();   
        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            BS_Empresas.AddNew();
            //BS_Empresas.Add(t_Empresas);
            BS_Empresas.MoveLast();
            this.Modo_Edicion();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            if (BS_Empresas.Current == null)
                return;
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_Nombre.Focus();
        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
           string vl_RegEliminar = t_Empresas.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NEmpresas.Elimiar(BS_Empresas.Current as Empresas);
                BS_Empresas.DataSource = NEmpresas.Listar();
                //Grd_Empresas.Refresh();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    