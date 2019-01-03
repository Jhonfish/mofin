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

namespace MOFIN
{
    public partial class Frm_TablasMaestras : MetroForm
    {
        bool vl_EsNuevo = true;
        M_Edad m_Edad = new M_Edad();
        BindingSource BS_TablaMaestra;

        public Frm_TablasMaestras()
        {
            InitializeComponent();
        }
               
        private void Frm_TablasMaestras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Edad' Puede moverla o quitarla según sea necesario.
            this.TA_MEdad.Fill(this.DS_MonitorOperaciones.M_Edad);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_VolOperPersNat' Puede moverla o quitarla según sea necesario.
            this.m_VolOperPersNatTableAdapter.Fill(this.DS_MonitorOperaciones.M_VolOperPersNat);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_VolOperPersJur' Puede moverla o quitarla según sea necesario.
            this.m_VolOperPersJurTableAdapter.Fill(this.DS_MonitorOperaciones.M_VolOperPersJur);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_TipoPersJuridica' Puede moverla o quitarla según sea necesario.
            this.m_TipoPersJuridicaTableAdapter.Fill(this.DS_MonitorOperaciones.M_TipoPersJuridica);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_TipoEstructuraEmpresa' Puede moverla o quitarla según sea necesario.
            this.m_TipoEstructuraEmpresaTableAdapter.Fill(this.DS_MonitorOperaciones.M_TipoEstructuraEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_TipoDocID' Puede moverla o quitarla según sea necesario.
            this.m_TipoDocIDTableAdapter.Fill(this.DS_MonitorOperaciones.M_TipoDocID);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Servicios' Puede moverla o quitarla según sea necesario.
            this.m_ServiciosTableAdapter.Fill(this.DS_MonitorOperaciones.M_Servicios);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Productos' Puede moverla o quitarla según sea necesario.
            this.m_ProductosTableAdapter.Fill(this.DS_MonitorOperaciones.M_Productos);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_PEP' Puede moverla o quitarla según sea necesario.
            this.m_PEPTableAdapter.Fill(this.DS_MonitorOperaciones.M_PEP);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Profesiones' Puede moverla o quitarla según sea necesario.
            this.TA_MProfesiones.Fill(this.DS_MonitorOperaciones.M_Profesiones);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_NivelRiesgo' Puede moverla o quitarla según sea necesario.
            this.TA_MNivelRiesgo.Fill(this.DS_MonitorOperaciones.M_NivelRiesgo);

            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Edad' Puede moverla o quitarla según sea necesario.
            this.TA_MEdad.Fill(this.DS_MonitorOperaciones.M_Edad);
//            BS_MEdad.DataSource = NM_Edad.Listar();

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

//            BS_TablaMaestra = BS_MPais;
            Cmb_TablaMaestra.SelectedIndex = 0;
            this.Modo_Consulta();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Detalles_CurrentCellChanged(object sender, EventArgs e)
        {
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Consulta()
        {
            this.Txt_Codigo.Enabled = false;
            this.Cmb_Pais.Enabled = true;
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
            
            this.Txt_Codigo.Enabled = vl_EsNuevo;
            this.Cmb_Pais.Enabled = true;
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

        //************
        // Comportamiento de Los Botones 
        //************
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_TablaMaestra.Count <= 1)
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
                this.TSB_Primero.Enabled = (BS_TablaMaestra.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_TablaMaestra.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_TablaMaestra.Position == BS_TablaMaestra.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_TablaMaestra.Position == BS_TablaMaestra.Count - 1) ? false : true;
                this.TSB_Modificar.Enabled = true;
                this.TSB_Eliminar.Enabled = true;
                this.TSB_Imprimir.Enabled = true;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            switch (Cmb_TablaMaestra.SelectedIndex)
            {
                case 0:  // "Actividad Comercial"
                    break;
                case 1:  // "Antigüedad"
                    break;
                case 2:  // "Criptomonedas"
                    break;
                case 3:  // "Edad"
                    if (vl_EsNuevo)
                        NM_Edad.Insertar(m_Edad);
                    else
                        NM_Edad.Actualizar(BS_TablaMaestra.Current as M_Edad);
                    break;
                case 4:  // "Estados"
                    break;
                case 5: // Nivel de Riesgo
                    break;
                case 6:  // "Pais"
                    break;
                case 7:  // "P.E.P."
                    break;
                case 8:  // "Productos"
                    break;
                case 9:  // "Profesión"
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
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_Codigo.Focus();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = ((DataRowView)this.BS_TablaMaestra.Current).Row["Descripcion"].ToString();
            // string vl_RegEliminar = NM_Edad.GetById(BS_TablaMaestra.Position+1).Descripcion.ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
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

            this.Cmb_Pais.Visible = false;
            this.Txt_CodAlfa2.Visible = false;
            this.Txt_CodAlfa3.Visible = false;

            this.Lbl_Pais.Visible = false;
            this.Lbl_CodAlfa2.Visible = false;
            this.Lbl_CodAlfa3.Visible = false;

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
                    this.Lbl_Pais.Visible = true;
                    this.Cmb_Pais.Visible = true;
                    break;
                case 5: // Nivel de Riesgo
                    BS_TablaMaestra = BS_MNivelRiesgo;
                    break;
                case 6:  // "Pais"
                    BS_TablaMaestra = BS_MPais;
                    this.Lbl_CodAlfa2.Visible = true;
                    this.Lbl_CodAlfa3.Visible = true;
                    this.Txt_CodAlfa2.Visible = true;
                    this.Txt_CodAlfa3.Visible = true;
                    break;
                case 7:  // "P.E.P."
                    BS_TablaMaestra = BS_MPEP;
                    break;
                case 8:  // "Productos"
                    BS_TablaMaestra = BS_MProductos;
                    break;
                case 9:  // "Profesión"
                    BS_TablaMaestra = BS_MProfesiones;
                    break;
                case 10:  // "Servicios"
                    BS_TablaMaestra = BS_MServicios;
                    break;
                case 11:  // "Tipo de Documento Identidad"
                    BS_TablaMaestra = BS_MTipoDocID;
                    break;
                case 12:  // "Tipo de Estructura"
                    BS_TablaMaestra = BS_MTipoEstructuraEmpresa;
                    break;
                case 13:  // "Tipo de Persona Jurídica"
                    BS_TablaMaestra = BS_MTipoPersJuridica;
                    break;
                case 14:  // "Vol. Oper. Pers. Natural"
                    BS_TablaMaestra = BS_MVolOperPersNat;
                    break;
                case 15:  // "Vol. Oper. Pers. Jurídica"
                    BS_TablaMaestra = BS_MVolOperPersJur;
                    break;
            }
            this.Txt_Codigo.DataBindings.Clear();
            this.Txt_Nombre.DataBindings.Clear();
            this.NUD_Valor.DataBindings.Clear();
            this.Txt_Codigo.DataBindings.Add("Text", BS_TablaMaestra, "Codigo");
            this.Txt_Nombre.DataBindings.Add("Text", BS_TablaMaestra, "Descripcion");
            this.NUD_Valor.DataBindings.Add("Value", BS_TablaMaestra, "Valor");

            Grd_Detalles.DataSource = BS_TablaMaestra;
            TSB_ActualizaBotonesNavegacion();
            Grd_Detalles.Refresh();

        }
    }
}
    