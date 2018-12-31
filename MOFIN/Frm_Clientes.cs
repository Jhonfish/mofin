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
    public partial class Frm_Clientes : MetroForm
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Servicios' Puede moverla o quitarla según sea necesario.
            this.m_ServiciosTableAdapter.Fill(this.DS_MonitorOperaciones.M_Servicios);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.M_Productos' Puede moverla o quitarla según sea necesario.
            this.m_ProductosTableAdapter.Fill(this.DS_MonitorOperaciones.M_Productos);
            // TODO: esta línea de código carga datos en la tabla 'DS_MonitorOperaciones.C_FirBenAcc' Puede moverla o quitarla según sea necesario.
            this.TA_CFirBenAcc.Fill(this.DS_MonitorOperaciones.C_FirBenAcc);
            // TODO: esta línea de código carga datos en la tabla 'monitorOperacionesDataSet.C_Clientes' Puede moverla o quitarla según sea necesario.
            this.TA_CClientes.Fill(this.DS_MonitorOperaciones.C_Clientes);
            this.Modo_Consulta();
        }

        private void c_ClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_CClientes.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_MonitorOperaciones);

        }
        //**************
        // Eventos del formulario
        //**************
        private void Modo_Consulta()
        {

            this.Grp_TipoPersona.Enabled = false;
            this.Txt_Codigo.Enabled = false;
            this.Txt_DocID.Enabled = false;
            this.Txt_Nombre.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;


            // Pagina 1
            this.Cmb_TipDocID.Enabled = false;
            this.DTP_FecVencDocID.Enabled = false;
            this.Cmb_Nacionalidad.Enabled = false;
            this.Cmb_PaisNacimiento.Enabled = false;
            this.Cmb_PaisResidencia.Enabled = false;
            this.Cmb_Estado.Enabled = false;
            this.Cmb_Edad.Enabled = false;
            this.Cmb_TipoPersJuridica.Enabled = false;
            this.Cmb_TipoEstructura.Enabled = false;
            this.Cmb_PEP.Enabled = false;
            this.Cmb_VolOperNat.Enabled = false;
            this.Cmb_Criptomonedas.Enabled = false;
            this.Cmb_Profesion.Enabled = false;
            this.Cmb_ActivComercial.Enabled = false;
            this.Lst_Servicios.Enabled = false;
            this.Lst_Productos.Enabled = false;

            // Pagina 2
            this.Grp_BenfTipoVinculacion.Enabled = false;
            this.Txt_BenefDoc_ID.Enabled = false;
            this.Dtp_BenefFec_Venc.Enabled = false;
            this.Txt_BenefNme.Enabled = false;
            this.Cmb_BenefPaisNacim.Enabled = false;
            this.Cmb_BenefNacionalidad.Enabled = false;
            this.Cmb_BenefPaisResid.Enabled = false;
            this.Cmb_BenefEstado.Enabled = false;
            this.Cmb_BenefEdad.Enabled = false;
            this.Cmb_BenefPEP.Enabled = false;
            this.Cmb_BenefProfesion.Enabled = false;
            this.Cmb_BenefCriptomonedas.Enabled = false;
            this.Cmb_BenefVincEmpresa.Enabled = false;
            this.Nud_BenefVincPorcent.Enabled = false;

            this.Pan_BenefBtns.Visible = false;


            // Pagina 3
            Chk_Opc1.Enabled = false;
            Chk_Opc2.Enabled = false;
            Chk_Opc3.Enabled = false;
            Chk_Opc4.Enabled = false;
            Chk_Opc5.Enabled = false;
            Chk_Opc6.Enabled = false;
            Chk_Opc7.Enabled = false;
            Chk_Opc8.Enabled = false;
            Chk_Opc9.Enabled = false;
            Chk_Opc10.Enabled = false;
            Chk_Opc11.Enabled = false;
            Chk_Opc12.Enabled = false;
            Chk_Opc13.Enabled = false;
            Chk_Opc14.Enabled = false;
            Chk_Opc15.Enabled = false;
            Chk_Opc16.Enabled = false;
            Chk_Opc17.Enabled = false;
            Chk_Opc18.Enabled = false;
            Chk_Opc19.Enabled = false;
            Chk_Opc20.Enabled = false;
            Chk_Opc21.Enabled = false;
            Chk_Opc22.Enabled = false;
            Chk_Opc23.Enabled = false;
            Chk_Opc24.Enabled = false;
            Chk_Opc25.Enabled = false;
            Chk_Opc26.Enabled = false;
            Chk_Opc27.Enabled = false;
            Chk_Opc28.Enabled = false;
            Chk_Opc29.Enabled = false;
            Chk_Opc30.Enabled = false;

            // Pagina 4
            this.Txt_Observacion.Enabled = false;
            this.Txt_Ejecutivo.Enabled = false;
            this.Txt_NivRiesgo.Enabled = false;
            this.Txt_PerFinanciero.Enabled = false;
            this.Grp_PerUsoCta.Enabled = false;
            this.NUD_NroTransacciones.Enabled = false;
            this.DTP_FecUltAct.Enabled = false;
            this.NUD_TriMes.Enabled = false;
            this.NUD_TriAno.Enabled = false;
            

            // Pagina 5

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Grp_TipoPersona.Enabled = true;
            this.Txt_Codigo.Enabled = true;
            this.Txt_DocID.Enabled = true;
            this.Txt_Nombre.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;

            // Pagina 1
            this.Cmb_TipDocID.Enabled = true;
            this.DTP_FecVencDocID.Enabled = true;
            this.Cmb_Nacionalidad.Enabled = true;
            this.Cmb_PaisNacimiento.Enabled = true;
            this.Cmb_PaisResidencia.Enabled = true;
            this.Cmb_Estado.Enabled = true;
            this.Cmb_Edad.Enabled = true;
            this.Cmb_TipoPersJuridica.Enabled = true;
            this.Cmb_TipoEstructura.Enabled = true;
            this.Cmb_PEP.Enabled = true;
            this.Cmb_VolOperNat.Enabled = true;
            this.Cmb_Criptomonedas.Enabled = true;
            this.Cmb_Profesion.Enabled = true;
            this.Cmb_ActivComercial.Enabled = true;
            this.Lst_Servicios.Enabled = true;
            this.Lst_Productos.Enabled = true;

            // Pagina 2
            this.Grp_BenfTipoVinculacion.Enabled = true;
            this.Txt_BenefDoc_ID.Enabled = true;
            this.Dtp_BenefFec_Venc.Enabled = true;
            this.Txt_BenefNme.Enabled = true;
            this.Cmb_BenefPaisNacim.Enabled = true;
            this.Cmb_BenefNacionalidad.Enabled = true;
            this.Cmb_BenefPaisResid.Enabled = true;
            this.Cmb_BenefEstado.Enabled = true;
            this.Cmb_BenefEdad.Enabled = true;
            this.Cmb_BenefPEP.Enabled = true;
            this.Cmb_BenefProfesion.Enabled = true;
            this.Cmb_BenefCriptomonedas.Enabled = true;
            this.Cmb_BenefVincEmpresa.Enabled = true;
            this.Nud_BenefVincPorcent.Enabled = true;

            this.Pan_BenefBtns.Visible = true;

            // Pagina 3
            Chk_Opc1.Enabled = true;
            Chk_Opc2.Enabled = true;
            Chk_Opc3.Enabled = true;
            Chk_Opc4.Enabled = true;
            Chk_Opc5.Enabled = true;
            Chk_Opc6.Enabled = true;
            Chk_Opc7.Enabled = true;
            Chk_Opc8.Enabled = true;
            Chk_Opc9.Enabled = true;
            Chk_Opc10.Enabled = true;
            Chk_Opc11.Enabled = true;
            Chk_Opc12.Enabled = true;
            Chk_Opc13.Enabled = true;
            Chk_Opc14.Enabled = true;
            Chk_Opc15.Enabled = true;
            Chk_Opc16.Enabled = true;
            Chk_Opc17.Enabled = true;
            Chk_Opc18.Enabled = true;
            Chk_Opc19.Enabled = true;
            Chk_Opc20.Enabled = true;
            Chk_Opc21.Enabled = true;
            Chk_Opc22.Enabled = true;
            Chk_Opc23.Enabled = true;
            Chk_Opc24.Enabled = true;
            Chk_Opc25.Enabled = true;
            Chk_Opc26.Enabled = true;
            Chk_Opc27.Enabled = true;
            Chk_Opc28.Enabled = true;
            Chk_Opc29.Enabled = true;
            Chk_Opc30.Enabled = true;

            // Pagina 4
            this.Txt_Observacion.Enabled = true;
            this.Txt_Ejecutivo.Enabled = true;
            this.Txt_NivRiesgo.Enabled = true;
            this.Txt_PerFinanciero.Enabled = true;
            this.Grp_PerUsoCta.Enabled = true;
            this.NUD_NroTransacciones.Enabled = true;
            this.DTP_FecUltAct.Enabled = true;
            this.NUD_TriMes.Enabled = true;
            this.NUD_TriAno.Enabled = true;

            // Pagina 5

        }

        //************
        // Comportamiento de Los Botones 
        //************

        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_CClientes.Count <= 1)
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
                this.TSB_Primero.Enabled = (BS_CClientes.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_CClientes.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_CClientes.Position == BS_CClientes.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_CClientes.Position == BS_CClientes.Count - 1) ? false : true;
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

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_CClientes.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_CClientes.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_CClientes.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_CClientes.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }
        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
        }
        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = ((DataRowView)this.BS_CClientes.Current).Row["Nombre"].ToString();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pag1_Click(object sender, EventArgs e)
        {

        }
    }
}
