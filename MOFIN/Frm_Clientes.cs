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
    enum TipoPersona
    {
        natural = 1,
        juridica = 2
    }

    enum TipoVinculo
    {
        Final = 1,
        Firmante = 2,
        Conyugue = 3
    }

    enum PeriodoUsoCta
    {
        semanal = 1,
        mensual = 2,
        trimestral = 3,
        semestral = 4,
        anual = 5
    }

    public partial class Frm_Clientes : MetroForm
    {
        bool ClienteEsNuevo = true;
        bool ClientModConsulta = true;
        bool EsBenefNuevo;
        bool BenefModConsulta = true;
        C_Clientes r_Cliente = new C_Clientes();
        C_FirBenAcc r_FirBenAcc = new C_FirBenAcc();

        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            //BS_CHistActClientes.DataSource = NC_FirBenAcc.Listar();
            BS_CHistActClientes.DataSource = NC_HistActClientes.Listar();

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

            BS_CClientes.DataSource = NC_Clientes.Listar();
            //BS_CFirBenAcc.DataSource = NC_FirBenAcc.Listar();
            this.Modo_Consulta();
        }

        //**************
        // Eventos del formulario
        //**************
        private void Modo_Consulta()
        {
            Pan_DetallesEnc.Enabled = false;
            Pan_Detalles1.Enabled = false;
            Pan_Detalles2.Enabled = false;
            Pan_Detalles3.Enabled = false;
            Pan_Detalles4.Enabled = false;
            Pan_BenefBtns.Visible = false;

            TS_BarraHerramientas.Enabled = true;

            Btn_Aceptar.Visible = false;
            Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            Pan_DetallesEnc.Enabled = true;
            Txt_Codigo.Enabled = ClienteEsNuevo;
            Pan_Detalles1.Enabled = true;
            Pan_Detalles2.Enabled = false;
            Pan_Detalles3.Enabled = true;
            Pan_Detalles4.Enabled = true;
            Pan_BenefBtns.Visible = true;

            TS_BarraHerramientas.Enabled = false;

            Btn_Aceptar.Visible = true;
            Btn_Cancelar.Visible = true;
        }

        //************
        // Comportamiento de Los Botones 
        //************

        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_CClientes.Count < 1)
            {
                TSB_Primero.Enabled = false;
                TSB_Anterior.Enabled = false;
                TSB_Siguiente.Enabled = false;
                TSB_Ultimo.Enabled = false;
                TSB_Modificar.Enabled = false;
                TSB_Eliminar.Enabled = false;
                TSB_Imprimir.Enabled = false;
            }
            else
            {
                TSB_Primero.Enabled = (BS_CClientes.Position == 0) ? false : true;
                TSB_Anterior.Enabled = (BS_CClientes.Position == 0) ? false : true;
                TSB_Siguiente.Enabled = (BS_CClientes.Position == BS_CClientes.Count - 1) ? false : true;
                TSB_Ultimo.Enabled = (BS_CClientes.Position == BS_CClientes.Count - 1) ? false : true;
                TSB_Modificar.Enabled = true;
                TSB_Eliminar.Enabled = true;
                TSB_Imprimir.Enabled = true;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            //r_Cliente.Codigo = Txt_Codigo.Text;
            //r_Cliente.Activo = true;
            //r_Cliente.Doc_ID = Txt_DocID.Text;
            //r_Cliente.Nombre = Txt_Nombre.Text;

            //r_Cliente.TipoPersona = (byte)Cmb_TipDocID.SelectedValue;
            //r_Cliente.na
            //t_Cliente.IG_TipDocID = (short)Cmb_TipDocID.SelectedValue;
            //t_Cliente.IG_Edad = (short)Cmb_Edad.SelectedValue;
            //t_Cliente.IG_FecVencDocID = DTP_FecVencDocID.Value;
            //t_Cliente.IG_TipoPersJur = (short)Cmb_TipoPersJuridica.SelectedValue;
            //t_Cliente.IG_Nacionalidad = (short)Cmb_Nacionalidad.SelectedValue;
            //t_Cliente.IG_TipoEstructura = (short)Cmb_TipoEstructura.SelectedValue;
            //t_Cliente.IG_PaisNacim = (short)Cmb_PaisNacimiento.SelectedValue;
            //t_Cliente.IG_PEP = (short)Cmb_PEP.SelectedValue;

            //r_FirBenAcc.Nombre = Txt_BenefNme.Text;

            //r_FirBenAcc.Doc_ID = Txt_BenefDoc_ID.Text;
            //r_Cliente = BS_CClientes.Current as C_Clientes;
            //r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;

            if (ClienteEsNuevo)
            {
                NC_Clientes.Insertar(r_Cliente);
                //NC_FirBenAcc.Insertar(r_FirBenAcc);
            }   
            else
            {
                //NC_Clientes.Actualizar(BS_CClientes.Current as C_Clientes);
                //NC_FirBenAcc.Actualizar(BS_CFirBenAcc.Current as C_FirBenAcc);
                NC_Clientes.Actualizar(r_Cliente);
               // NC_FirBenAcc.Actualizar(r_FirBenAcc);
            }
            this.Modo_Consulta();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Modo_Consulta();
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
            ClienteEsNuevo = true;
            ClientModConsulta = false;
            BS_CClientes.AddNew();
            //BS_CClientes.DataSource = r_Cliente;
            //BS_CFirBenAcc.DataSource = r_FirBenAcc;


            Modo_Edicion();
            Txt_Codigo.Focus();
        }
        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            ClienteEsNuevo = false;
            ClientModConsulta = false;
            Modo_Edicion();
        }
        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = r_Cliente.Nombre.Trim();
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NC_Clientes.Elimiar(BS_CClientes.Current as C_Clientes);
                NC_FirBenAcc.Elimiar(BS_CFirBenAcc.Current as C_FirBenAcc);
                BS_CClientes.DataSource = NC_Clientes.Listar();
                Grd_Clientes.Refresh();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grd_Clientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BS_CClientes.Current == null)
                return;
            else
            {
                r_Cliente = BS_CClientes.Current as C_Clientes;

                if (r_Cliente.TipoPersona == (byte)TipoPersona.natural)
                    Opc_TipPers1.Checked = true;
                else
                    Opc_TipPers2.Checked = true;

                if (r_Cliente.PeriodUsoCta == (byte)PeriodoUsoCta.semanal)
                    Opt_PerUsoCta1.Checked = true;
                else if (r_Cliente.PeriodUsoCta == (byte)PeriodoUsoCta.mensual)
                    Opt_PerUsoCta2.Checked = true;
                else if (r_Cliente.PeriodUsoCta == (byte)PeriodoUsoCta.trimestral)
                    Opt_PerUsoCta3.Checked = true;
                else if (r_Cliente.PeriodUsoCta == (byte)PeriodoUsoCta.semestral)
                    Opt_PerUsoCta4.Checked = true;
                else
                    Opt_PerUsoCta5.Checked = true;
            }
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.ListarPorCliente(r_Cliente.Codigo);

            if (BS_CFirBenAcc.Current == null)
                return;
            else
                r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
        }

        private void Cmb_PaisResidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_PaisResidencia.SelectedIndex != -1)
            {
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
                short pais = (short)Cmb_BenefPaisResid.SelectedValue;

                Cmb_BenefEstado.DataSource = NM_Estados.ListarPorPais(pais);
                Cmb_BenefEstado.DisplayMember = "Descripcion";
                Cmb_BenefEstado.ValueMember = "Codigo";
            }

        }

        private void Opc_TipPers1_CheckedChanged(object sender, EventArgs e)
        {
            if(ClientModConsulta == false)
            {
                if (Opc_TipPers1.Checked == true)
                    r_Cliente.TipoPersona = (byte)TipoPersona.natural;
                else
                    r_Cliente.TipoPersona = (byte)TipoPersona.juridica;
            }
        }

        

        private void Opc_TipVinc1_CheckedChanged(object sender, EventArgs e)
        {
            if (BenefModConsulta == false)
            {
                if (Opc_TipVinc1.Checked == true)
                    r_FirBenAcc.TipoVinculo = (byte)TipoVinculo.Final;
                else if (Opc_TipVinc2.Checked == true)
                    r_FirBenAcc.TipoVinculo = (byte)TipoVinculo.Firmante;
                else
                    r_FirBenAcc.TipoVinculo = (byte)TipoVinculo.Conyugue;
            }
        }

        private void Btn_BenefIncluir_Click(object sender, EventArgs e)
        {
            Pan_Detalles2.Enabled = true;
            BS_CFirBenAcc.AddNew();
            EsBenefNuevo = true;
            BenefModConsulta = false;
        }

        private void Btn_BenefModificar_Click(object sender, EventArgs e)
        {
            Pan_Detalles2.Enabled = true;
            EsBenefNuevo = false;
            BenefModConsulta = false;
        }

        private void Btn_BenefAceptar_Click(object sender, EventArgs e)
        {
            if (EsBenefNuevo)
            {
                r_FirBenAcc.Cod_Cliente = r_Cliente.Codigo;
                NC_FirBenAcc.Insertar(r_FirBenAcc);
            }
            else
            {
                //NC_Clientes.Actualizar(BS_CClientes.Current as C_Clientes);
                //NC_FirBenAcc.Actualizar(BS_CFirBenAcc.Current as C_FirBenAcc);
                NC_FirBenAcc.Actualizar(r_FirBenAcc);
            }
            Pan_Detalles2.Enabled = false;
            BenefModConsulta = true;
        }

        private void Btn_BenefCancelar_Click(object sender, EventArgs e)
        {
            Pan_Detalles2.Enabled = false;
            BenefModConsulta = true;
        }

        private void Btn_BenefEliminar_Click(object sender, EventArgs e)
        {
            string RegEliminar = r_FirBenAcc.Nombre.Trim();
            DialogResult Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n" + RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                NC_FirBenAcc.Elimiar(BS_CFirBenAcc.Current as C_FirBenAcc);
                BS_CFirBenAcc.DataSource = NC_FirBenAcc.ListarPorCliente(Txt_Codigo.Text);
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Pan_Detalles2.Enabled = false;
            BenefModConsulta = true;
        }

        private void Grd_CFirBenAcc_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BS_CFirBenAcc.Current == null)
                return;
            else
            {
                r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;

                if (r_FirBenAcc.TipoVinculo == (byte)TipoVinculo.Final)
                    Opc_TipVinc1.Checked = true;
                else if (r_FirBenAcc.TipoVinculo == (byte)TipoVinculo.Firmante)
                    Opc_TipVinc2.Checked = true;
                else
                    Opc_TipVinc3.Checked = true;
            }
        }

        private void Opt_PerUsoCta1_CheckedChanged(object sender, EventArgs e)
        {
            if (ClientModConsulta == false)
            {
                if (Opt_PerUsoCta1.Checked == true)
                    r_Cliente.PeriodUsoCta = (byte)PeriodoUsoCta.semanal;
                else if(Opt_PerUsoCta2.Checked == true)
                    r_Cliente.PeriodUsoCta = (byte)PeriodoUsoCta.mensual;
                else if (Opt_PerUsoCta3.Checked == true)
                    r_Cliente.PeriodUsoCta = (byte)PeriodoUsoCta.trimestral;
                else if (Opt_PerUsoCta4.Checked == true)
                    r_Cliente.PeriodUsoCta = (byte)PeriodoUsoCta.semestral;
                else
                    r_Cliente.PeriodUsoCta = (byte)PeriodoUsoCta.anual;
            }
        }
    }
}
