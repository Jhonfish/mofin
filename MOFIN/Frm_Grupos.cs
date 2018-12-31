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
    public partial class Frm_Grupos : MetroForm
    {
        public Frm_Grupos()
        {
            InitializeComponent();
        }

        private void Frm_Grupos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Grupos' Puede moverla o quitarla según sea necesario.
            this.TA_Grupos.Fill(this.DS_Entorno.Grupos);
            this.Modo_Consulta();

        }

        //**************
        // Eventos del formulario
        //**************

        private void Refresca_Formulario(object sender, EventArgs e)
        {

            TSB_ActualizaBotonesNavegacion();
        }

        private void Grd_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modo_Consulta()
        {
            this.Txt_Codigo.Enabled = false;
            this.Txt_Nombre.Enabled = false;
            this.Chk_Clientes.Enabled = false;
            this.Chk_CliMonitor.Enabled = false;
            this.Chk_CliBusqueda.Enabled = false;
            this.Chk_MonitorOperaciones.Enabled = false;
            this.Chk_MonFinanciero.Enabled = false;
            this.Chk_MonTransaccional.Enabled = false;
            this.Chk_TablasMaestras.Enabled = false;
            this.Chk_TabMaestras.Enabled = false;
            this.Chk_Reportes.Enabled = false;
            this.Chk_Herramientas.Enabled = false;
            this.Chk_HerUsuarios.Enabled = false;
            this.Chk_HerGrupos.Enabled = false;
            this.Chk_HerEmpresas.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Txt_Codigo.Enabled = true;
            this.Txt_Nombre.Enabled = true;
            this.Chk_Clientes.Enabled = true;
            this.Chk_CliMonitor.Enabled = true;
            this.Chk_CliBusqueda.Enabled = true;
            this.Chk_MonitorOperaciones.Enabled = true;
            this.Chk_MonFinanciero.Enabled = true;
            this.Chk_MonTransaccional.Enabled = true;
            this.Chk_TablasMaestras.Enabled = true;
            this.Chk_TabMaestras.Enabled = true;
            this.Chk_Reportes.Enabled = true;
            this.Chk_Herramientas.Enabled = true;
            this.Chk_HerUsuarios.Enabled = true;
            this.Chk_HerGrupos.Enabled = true;
            this.Chk_HerEmpresas.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
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
            this.Modo_Consulta();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Grupos.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
            BS_Grupos.AddNew();

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
            string vl_RegEliminar = ((DataRowView)this.BS_Grupos.Current).Row["Nombre"].ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
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

        private void gruposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Grupos.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void Frm_Grupos_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TS_BarraHerramientas_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
    