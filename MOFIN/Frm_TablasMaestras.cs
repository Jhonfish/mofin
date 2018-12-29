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
    public partial class Frm_TablasMaestras : MetroForm
    {
        public Frm_TablasMaestras()
        {
            InitializeComponent();

        }

        // Private BindingSource BS_TablaMaestra;
        private BindingSource BS_TablaMaestra;

        private void Frm_TablasMaestras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Profesiones' Puede moverla o quitarla según sea necesario.
            this.TA_MProfesiones.Fill(this.DS_MonitorOperaciones.M_Profesiones);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_NivelRiesgo' Puede moverla o quitarla según sea necesario.
            this.TA_MNivelRiesgo.Fill(this.DS_MonitorOperaciones.M_NivelRiesgo);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Edad' Puede moverla o quitarla según sea necesario.
            this.TA_MEdad.Fill(this.DS_MonitorOperaciones.M_Edad);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Criptomonedas' Puede moverla o quitarla según sea necesario.
            this.TA_MCriptomonedas.Fill(this.DS_MonitorOperaciones.M_Criptomonedas);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_ActivComercial' Puede moverla o quitarla según sea necesario.
            this.TA_MActivComercial.Fill(this.DS_MonitorOperaciones.M_ActivComercial);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Antiguedad' Puede moverla o quitarla según sea necesario.
            this.TA_MAntiguedad.Fill(this.DS_MonitorOperaciones.M_Antiguedad);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Pais' Puede moverla o quitarla según sea necesario.
            this.TA_MPais.Fill(this.DS_MonitorOperaciones.M_Pais);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Estados' Puede moverla o quitarla según sea necesario.
            this.TA_MEstados.Fill(this.DS_MonitorOperaciones.M_Estados);

            BS_TablaMaestra = BS_MPais;
            this.Modo_Consulta();

        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Detalles_CurrentCellChanged(object sender, EventArgs e)
        {
            TSB_ActualizaBotonesNavegacion();
        }

        private void Grd_Detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modo_Consulta()
        {
            this.Txt_Codigo.Enabled = false;
            this.Txt_CodAlfa2.Enabled = false;
            this.Txt_CodAlfa3.Enabled = false;
            this.Txt_Nombre.Enabled = false;
            this.NUD_Valor.Enabled = false;
            this.Chk_CES.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Detalles.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Txt_Codigo.Enabled = true;
            this.Txt_CodAlfa2.Enabled = true;
            this.Txt_CodAlfa3.Enabled = true;
            this.Txt_Nombre.Enabled = true;
            this.NUD_Valor.Enabled = true;
            this.Chk_CES.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Detalles.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_TablaMaestra.Count <= 1)
            {
                this.TSB_Primero.Enabled = false;
                this.TSB_Anterior.Enabled = false;
                this.TSB_Siguiente.Enabled = false;
                this.TSB_Ultimo.Enabled = false;
            }
            else
            {
                this.TSB_Primero.Enabled = (BS_TablaMaestra.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_TablaMaestra.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_TablaMaestra.Position == BS_TablaMaestra.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_TablaMaestra.Position == BS_TablaMaestra.Count - 1) ? false : true;
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
            this.BS_TablaMaestra.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_MonitorOperaciones);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
            BS_TablaMaestra.AddNew();

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
            //  string vl_texto = BS_TablaMaestra.Current("Nombre");      // (char)Grd_Detalles.CurrentRow.Cells["Nombre"].Value;

            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + "***",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }

        private void m_PaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_MPais.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_MonitorOperaciones);

        }

        private void Cmb_TablaMaestra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Cmb_TablaMaestra.SelectedIndex.ToString());
            switch (Cmb_TablaMaestra.SelectedIndex)
            {
                case 0:  // "Actividad Comercial"
                    BS_TablaMaestra = BS_MActivComercial;
                    break;
                case 1:  // "Antigüedad"
                    BS_TablaMaestra = BS_MAntiguedad;
                    break;
                case 2:  // "Criptomonedas"
                    BS_TablaMaestra = BS_MCriptomonedas;
                    break;
                case 3:  // "Edad"
                    BS_TablaMaestra = BS_MEdad;
                    break;
                case 4:  // "Estados"
                    BS_TablaMaestra = BS_MEstados;
                    break;
                case 5: // Nivel de Riesgo
                    BS_TablaMaestra = BS_MNivelRiesgo;
                    break;
                case 6:  // "Pais"
                    BS_TablaMaestra = BS_MPais;
                    break;
                case 7:  // "P.E.P."
                    break;
                case 8:  // "Productos"
                    break;
                case 9:  // "Profesión"
                    BS_TablaMaestra = BS_MProfesiones;
                    break;
                case 10:  // "Servicios"
                    break;
                case 11:  // "Tipo de Documento Identidad"
                    break;
                case 12:  // "Tipo de Estructura"
                    break;
                case 13:  // "Tipo de Persona Jurídica"
                    break;
                case 14:  // "Vol. Oper. Pers. Natural"
                    break;
                case 15:  // "Vol. Oper. Pers. Jurídica"
                    break;
            }
            this.Txt_Codigo.DataBindings.Clear();
            this.Txt_Nombre.DataBindings.Clear();
            this.NUD_Valor.DataBindings.Clear();

            this.Txt_Codigo.DataBindings.Add("Text", BS_TablaMaestra, "Codigo");
            this.Txt_Nombre.DataBindings.Add("Text", BS_TablaMaestra, "Descripcion");
            this.NUD_Valor.DataBindings.Add("Value", BS_TablaMaestra, "Valor");
            Grd_Detalles.DataSource = BS_TablaMaestra;
            Grd_Detalles.Refresh();
        }

    }
}
    