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
    public partial class Frm_Clientes : MetroForm
    {
        bool vl_EsNuevo = true;
        C_Clientes t_Cliente = new C_Clientes();
        C_FirBenAcc t_FirBenAcc = new C_FirBenAcc();
        //M_Pais mPais = new M_Pais();

        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.Listar();
            BS_CHistActClientes.DataSource = NC_FirBenAcc.Listar();

            BS_MActivComercial.DataSource = NM_ActivComercial.Listar();
            BS_MAntiguedad.DataSource = NM_Antiguedad.Listar();
            BS_MCriptomonedas.DataSource = NM_Criptomonedas.Listar();
            BS_MEdad.DataSource = NM_Edad.Listar();
            BS_MEstados.DataSource = NM_Estados.Listar();
            BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();
            BS_MPais.DataSource = NM_Pais.Listar();
            BS_MPEP.DataSource = NM_PEP.Listar();
            BS_MProductos.DataSource = NM_Productos.Listar();
            BS_MProfesiones.DataSource = NM_Profesiones.Listar();
            BS_MServicios.DataSource = NM_Servicios.Listar();
            BS_MTipoDocID.DataSource = NM_TipoDocID.Listar();
            BS_MTipoEstructuraEmpresa.DataSource = NM_TipoEstructuraEmpresa.Listar();
            BS_MTipoPersJuridica.DataSource = NM_TipoPersJuridica.Listar();
            BS_MVolOperPersNat.DataSource = NM_VolOperPersNat.Listar();
            BS_MVolOperPersJur.DataSource = NM_VolOperPersJur.Listar();

            //Cmb_Nacionalidad.DataSource = NM_Pais.Listar();
            //Cmb_Nacionalidad.DisplayMember = "Descripcion";
            //Cmb_Nacionalidad.ValueMember = "Cod_Pais";
            //Cmb_PaisNacimiento.DataSource = NM_Pais.Listar();
            //Cmb_PaisResidencia.DataSource = NM_Pais.Listar();
            BS_Nac.DataSource = NM_Pais.Listar();
            BS_Res.DataSource = NM_Pais.Listar();

            BS_AutPaisNac.DataSource = NM_Pais.Listar();
            BS_AutNac.DataSource = NM_Pais.Listar();
            BS_AutRes.DataSource = NM_Pais.Listar();

            BS_AutProfesion.DataSource = NM_Profesiones.Listar();
            BS_AutPEP.DataSource = NM_PEP.Listar();
            BS_AutCriptomoneda.DataSource = NM_Criptomonedas.Listar();
            BS_AutEdad.DataSource = NM_Edad.Listar();


            this.Modo_Consulta();
        }

        //**************
        // Eventos del formulario
        //**************
        private void Modo_Consulta()
        {
            this.Pan_DetallesEnc.Enabled = false;
            this.Pan_Detalles1.Enabled = false;
            this.Pan_Detalles2.Enabled = false;
            this.Pan_Detalles3.Enabled = false;
            this.Pan_Detalles4.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_DetallesEnc.Enabled = true;
            this.Txt_Codigo.Enabled = vl_EsNuevo;
            this.Pan_Detalles1.Enabled = true;
            this.Pan_Detalles2.Enabled = true;
            this.Pan_Detalles3.Enabled = true;
            this.Pan_Detalles4.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }

        //************
        // Comportamiento de Los Botones 
        //************

        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_CClientes.Count < 1)
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
        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Modo_Edicion();
        }
        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            this.Modo_Edicion();
        }
        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = t_Cliente.Nombre.Trim();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NC_Clientes.Elimiar(BS_CClientes.Current as C_Clientes);
                BS_CClientes.DataSource = NC_Clientes.Listar();
                Grd_Clientes.Refresh();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grd_Clientes_CurrentCellChanged(object sender, EventArgs e)
        {
            t_Cliente = BS_CClientes.Current as C_Clientes;
            t_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
        }

        private void Cmb_PaisResidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_PaisResidencia.SelectedIndex != -1)
            {
                //Cmb_PaisResidencia.Items.Clear();
                short pais = (short) Cmb_PaisResidencia.SelectedValue;

                Cmb_Estado.DataSource = NM_Estados.ListarPorPais(pais);
                Cmb_Estado.DisplayMember = "Descripcion";
                Cmb_Estado.ValueMember = "Codigo";
            }
        }

        private void Cmb_BenefPaisResid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_BenefPaisResid.SelectedIndex != -1)
            {
                //Cmb_BenefPaisResid.Items.Clear();
                short pais = (short)Cmb_BenefPaisResid.SelectedValue;

                Cmb_BenefEstado.DataSource = NM_Estados.ListarPorPais(pais);
                Cmb_BenefEstado.DisplayMember = "Descripcion";
                Cmb_BenefEstado.ValueMember = "Codigo";
            }

        }
    }
}
