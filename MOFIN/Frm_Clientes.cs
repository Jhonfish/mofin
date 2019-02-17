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
    enum TipoPersona    {natural = 1, juridica = 2};
    enum TipoVinculo    {Final = 1, Firmante = 2, Conyugue = 3};
    enum PeriodoUsoCta    {semanal = 1, mensual = 2, trimestral = 3, semestral = 4, anual = 5};
    enum TipoProdServ    {Producto = 1,Servicio = 2};

    struct Punt_Cliente
    {
        public byte puntos_TipoDocID;
        public byte puntos_nacionalidad;
        public byte puntos_paisNac;
        public byte puntos_paisRes;
        public byte puntos_UbicGeo;
        public byte puntos_profesion;
        public byte puntos_ActComer;
        public byte puntos_edad;
        public byte puntos_tipoPers;
        public byte puntos_estruc;
        public byte puntos_pep;
        public byte puntos_volOper;
        public byte puntos_cripto;
        public byte puntos_Productos;
        public byte puntos_Servicios;

        public byte total;
        public byte sumatoria;
        public decimal Puntaje;

        public byte Calculo()
        {

            if (Entorno.vs_TipoValoracCliente == 1)    // Promedio
            {
                total = 0;
                sumatoria = 0;
                if ( puntos_TipoDocID != 0)
                {
                    sumatoria += puntos_TipoDocID;
                    total++;
                }
                if (puntos_nacionalidad != 0)
                {
                    sumatoria += puntos_nacionalidad;
                    total++;
                }
                if (puntos_paisNac != 0)
                {
                    sumatoria += puntos_paisNac;
                    total++;
                }   
                if (puntos_paisRes != 0)
                {
                    sumatoria += puntos_paisRes;
                    total++;
                }
                if (puntos_UbicGeo != 0)
                {
                    sumatoria += puntos_UbicGeo;
                    total++;
                }
                if (puntos_profesion != 0)
                {
                    sumatoria += puntos_profesion;
                    total++;
                }
                if (puntos_ActComer != 0)
                {
                    sumatoria += puntos_ActComer;
                    total++;
                }
                if (puntos_edad != 0)
                {
                    sumatoria += puntos_edad;
                    total++;
                }
                if (puntos_tipoPers != 0)
                {
                    sumatoria += puntos_tipoPers;
                    total++;
                }
                if (puntos_estruc != 0)
                {
                    sumatoria += puntos_estruc;
                    total++;
                }
                if (puntos_pep != 0)
                {
                    sumatoria += puntos_pep;
                    total++;
                }
                if (puntos_volOper != 0)
                {
                    sumatoria += puntos_volOper;
                    total++;
                }
                if(puntos_cripto != 0)
                {
                    sumatoria += puntos_cripto;
                    total++;
                }
                if(puntos_Productos != 0)
                {
                    sumatoria += puntos_Productos;
                    total++;
                }
                if (puntos_Servicios != 0)
                {
                    sumatoria += puntos_Servicios;
                    total++;
                }
                    if (total > 0)
                        Puntaje = (decimal)((float)sumatoria / (float)total);
                    else
                        Puntaje = 0;
            }

            byte Puntuacion = (byte)Math.Round(Puntaje, MidpointRounding.AwayFromZero);

            MessageBox.Show(puntos_TipoDocID.ToString() + " + " + puntos_nacionalidad.ToString() + " + " + puntos_paisNac.ToString() + " + " + puntos_paisRes.ToString() + " + " +
                            puntos_UbicGeo.ToString() + " + " + puntos_edad.ToString() + " + " + puntos_tipoPers.ToString() + " + " + puntos_estruc.ToString() + " + " + 
                            puntos_pep.ToString() + " + " + puntos_volOper.ToString() + " + " + puntos_cripto.ToString() + " + " + puntos_profesion.ToString() + " + " + 
                            puntos_ActComer.ToString() + " + " + puntos_Servicios.ToString() + " + " + puntos_Productos.ToString() +
                            "\n\n" + sumatoria.ToString()+ " / " + total.ToString()+ "\n\n"+ Puntaje.ToString() + "\n\n" + Puntuacion.ToString());

            return Puntuacion;
        }
    }
    struct Punt_FirBenAcc
    {
        public byte puntos_nacionalidad;
        public byte puntos_paisNac;
        public byte puntos_paisRes;
        public byte puntos_UbicGeo;
        public byte puntos_edad;
        public byte puntos_pep;
        public byte puntos_profesion;
        public byte puntos_cripto;
 
        public byte total;
        public byte sumatoria;
        public decimal Puntaje;

        public byte Calculo()
        {

            if (Entorno.vs_TipoValoracCliente == 1)    // Promedio
            {
                total = 0;
                sumatoria = 0;

                if (puntos_nacionalidad != 0)
                {
                    sumatoria += puntos_nacionalidad;
                    total++;
                }
                if (puntos_paisNac != 0)
                {
                    sumatoria += puntos_paisNac;
                    total++;
                }
                if (puntos_paisRes != 0)
                {
                    sumatoria += puntos_paisRes;
                    total++;
                }
                if (puntos_UbicGeo != 0)
                {
                    sumatoria += puntos_UbicGeo;
                    total++;
                }
                if (puntos_profesion != 0)
                {
                    sumatoria += puntos_profesion;
                    total++;
                }
                if (puntos_edad != 0)
                {
                    sumatoria += puntos_edad;
                    total++;
                }
                if (puntos_pep != 0)
                {
                    sumatoria += puntos_pep;
                    total++;
                }
                if (puntos_cripto != 0)
                {
                    sumatoria += puntos_cripto;
                    total++;
                }
                if (total > 0)
                    Puntaje = (decimal)((float)sumatoria / (float)total);
                else
                    Puntaje = 0;
            }

            byte Puntuacion = (byte)Math.Round(Puntaje, MidpointRounding.AwayFromZero);

            MessageBox.Show(puntos_nacionalidad.ToString() + " + " + puntos_paisNac.ToString() + " + " + puntos_paisRes.ToString() + " + " + puntos_UbicGeo.ToString() + " + " + 
                            puntos_edad.ToString()  + " + " + puntos_pep.ToString() + " + " + puntos_cripto.ToString() + " + " + puntos_profesion.ToString() +
                            "\n\n" + sumatoria.ToString() + " / " + total.ToString() + "\n\n" + Puntaje.ToString() + "\n\n" + Puntuacion.ToString());

            return Puntuacion;
        }
    }

    public partial class Frm_Clientes : MetroForm
    {
        bool ClienteEsNuevo = true;
        bool ClientModConsulta = true;
        bool EsBenefNuevo;
        bool BenefModConsulta = true;
        C_Clientes r_Cliente = new C_Clientes();
        C_FirBenAcc r_FirBenAcc = new C_FirBenAcc();
        Punt_Cliente punt_Cliente;
        Punt_FirBenAcc punt_FirBenAcc;
        List<M_Servicios> m_Servicios;
        List<M_Productos> m_Productos;
        List<M_Productos> m_ProdSeleccionado = new List<M_Productos>();
        List<M_Servicios> m_ServSelecionado = new List<M_Servicios>();

        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();

        public Frm_Clientes()
        {
            InitializeComponent();
            this.TSB_Primero.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Anterior.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Siguiente.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Ultimo.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.ts_Sep1.Visible = Entorno.vs_CnfgBtnsNaveg;

        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
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

            BS_OOperfinancieras.DataSource = NO_Operfinancieras.Listar();
            BS_OOperTransaccionales.DataSource = NO_OperTransaccionales.Listar();

            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            BS_Nac.DataSource = NM_Pais.Listar();
            BS_Res.DataSource = NM_Pais.Listar();

            BS_AutPaisNac.DataSource = NM_Pais.Listar();
            BS_AutNac.DataSource = NM_Pais.Listar();
            BS_AutRes.DataSource = NM_Pais.Listar();

            BS_AutProfesion.DataSource = NM_Profesiones.Listar();
            BS_AutPEP.DataSource = NM_PEP.Listar();
            BS_AutCriptomoneda.DataSource = NM_Criptomonedas.Listar();
            BS_AutEdad.DataSource = NM_Edad.Listar();
            
            m_Servicios = NM_Servicios.Listar();
            m_Productos = NM_Productos.Listar();
            
            foreach (M_Servicios item in m_Servicios)
            {
                Chlst_Servicios.Items.Add(item.Descripcion);
            }
            
            foreach (M_Productos item in m_Productos)
            {
                Chlst_Productos.Items.Add(item.Descripcion);
            }
            
            BS_CClientes.DataSource = NC_Clientes.Listar();
            
            this.Asigna_Nombres();
            this.Modo_Consulta();
            this.Grd_Clientes_CurrentCellChanged(false, e);

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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Clientes_I == null ? false : (bool)r_GrupoOpciones.Clientes_I;
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Clientes_I == null ? false : (bool)r_GrupoOpciones.Clientes_I;
                this.TSB_Modificar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Clientes_M == null ? false : (bool)r_GrupoOpciones.Clientes_M;
                this.TSB_Eliminar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Clientes_E == null ? false : (bool)r_GrupoOpciones.Clientes_E;
                this.TSB_Imprimir.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Clientes_P == null ? false : (bool)r_GrupoOpciones.Clientes_P;
            }
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
        private void KeyPressed_JF(object sender, KeyEventArgs e)
        {
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
            if (Opc_TipPers1.Checked)
            {
                Cmb_TipoPersJuridica.Enabled = false;
                Cmb_TipoEstructura.Enabled = false;
            }
            Modo_Edicion();
        }
        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = r_Cliente.Nombre.Trim(); 
            DialogResult vl_Resp = MessageBox.Show(Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                BS_CClientes.DataSource = NC_Clientes.Listar();
                MessageBox.Show(Funciones._Mens_Idioma(9011), Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void TSB_Imprimir_Click(object sender, EventArgs e)
        {

        }
        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {

            NC_ProdServ.EliminarxCodigo(r_Cliente.Codigo);
            for (int i = 0; i < Chlst_Productos.Items.Count; i++)
            {
                if (Chlst_Productos.GetItemChecked(i))
                {
                    C_ProdServ m_ProdServ = new C_ProdServ
                    {
                        Cod_Cliente = r_Cliente.Codigo,
                        Tipo_ProdServ = 1,
                        Cod_Tipo = (byte)m_Productos[i].Codigo,
                        Valor = m_Productos[i].Valor
                    };
                    NC_ProdServ.Insertar(m_ProdServ);
                }
            }
            for (int i = 0; i < Chlst_Servicios.Items.Count; i++)
            {
                if (Chlst_Servicios.GetItemChecked(i))
                {
                    C_ProdServ m_ProdServ = new C_ProdServ
                    {
                        Cod_Cliente = r_Cliente.Codigo,
                        Tipo_ProdServ = 2,
                        Cod_Tipo = (byte)m_Servicios[i].Codigo,
                        Valor = m_Servicios[i].Valor
                    };
                    NC_ProdServ.Insertar(m_ProdServ);
                }
            }

            this.Clientes_RellenaDatosCalculo();
            r_Cliente.InfGen_Punt = punt_Cliente.Calculo();

            if (r_Cliente.Benef_Punt > 0)
                r_Cliente.Cliente_Punt = (byte)Math.Round((decimal)((float)r_Cliente.InfGen_Punt + (float)r_Cliente.Benef_Punt)/2, MidpointRounding.AwayFromZero);
            else
                r_Cliente.Cliente_Punt = r_Cliente.InfGen_Punt;

            r_Cliente.Fec_UltimAct = DateTime.Today;

            if (ClienteEsNuevo)
                NC_Clientes.Insertar(r_Cliente);
            else
                NC_Clientes.Actualizar(r_Cliente);

            BS_CClientes.DataSource = NC_Clientes.Listar();
            this.Modo_Consulta();
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Modo_Consulta();
            BS_CClientes.CancelEdit();
        }

        private void Btn_BenefIncluir_Click(object sender, EventArgs e)
        {
            Pan_Detalles2.Enabled = true;
            BS_CFirBenAcc.AddNew();
            EsBenefNuevo = true;
            BenefModConsulta = false;

            this.Grd_CFirBenAcc.Enabled = false;
            this.Pan_BenefBtns.Enabled = false;
            this.Pan_BenefAcepCanc.Visible = true;

            this.AcceptButton = Btn_BenefAceptar;
        }
        private void Btn_BenefModificar_Click(object sender, EventArgs e)
        {
            Pan_Detalles2.Enabled = true;
            EsBenefNuevo = false;
            BenefModConsulta = false;

            this.Grd_CFirBenAcc.Enabled = false;
            this.Pan_BenefBtns.Enabled = false;

            this.Pan_BenefAcepCanc.Visible = true;
            this.AcceptButton = Btn_BenefAceptar;
        }
        private void Btn_BenefEliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = r_FirBenAcc.Nombre.Trim();
            DialogResult vl_Resp = MessageBox.Show(Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                MessageBox.Show(Funciones._Mens_Idioma(9011), Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);

                NC_FirBenAcc.Elimiar(BS_CFirBenAcc.Current as C_FirBenAcc);
                BS_CFirBenAcc.DataSource = NC_FirBenAcc.ListarPorCliente(Txt_Codigo.Text);

                // Procedimiento para calcular nuevamente la puntuacion de los Beneficiarios luego de eliminar uno
                BS_CFirBenAcc.MoveFirst();
                byte vl_Cuantos = 0;
                byte vl_Puntos = 0;
                byte vl_Puntuacion = 0;
                foreach (object Registro in BS_CFirBenAcc)
                {
                    r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                    vl_Puntos = (byte)(vl_Puntos + r_FirBenAcc.Puntuacion);
                    vl_Cuantos++;
                    BS_CFirBenAcc.MoveNext();
                }

                if (vl_Cuantos >= 0)
                    vl_Puntuacion = (byte)Math.Round((decimal)((float)vl_Puntos / (float)vl_Cuantos), MidpointRounding.AwayFromZero);
                else
                    vl_Puntuacion = 0;

                r_Cliente.Benef_Punt = vl_Puntuacion;
                this.Pag2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11005) + ": " + r_Cliente.Benef_Punt.ToString();
            }


            Pan_Detalles2.Enabled = false;
            BenefModConsulta = true;
        }

        private void Btn_BenefAceptar_Click(object sender, EventArgs e)
        {
            
            this.FirBenAcc_RellenaDatosCalculo();
            r_FirBenAcc.Puntuacion = punt_FirBenAcc.Calculo();

            if (EsBenefNuevo)
            {
                r_FirBenAcc.Cod_Cliente = r_Cliente.Codigo;
                NC_FirBenAcc.Insertar(r_FirBenAcc);
            }
            else
            {
                NC_FirBenAcc.Actualizar(r_FirBenAcc);
            }

            Pan_Detalles2.Enabled = false;
            BenefModConsulta = true;
            this.Grd_CFirBenAcc.Enabled = true;
            this.Pan_BenefBtns.Enabled = true;
            this.Pan_BenefAcepCanc.Visible = false;
            Cmb_BenefEstado.DataSource = NM_Estados.Listar();

            BS_CFirBenAcc.MoveFirst();
            byte vl_Cuantos = 0;
            byte vl_Puntos = 0;
            byte vl_Puntuacion = 0;

            foreach(object Registro in BS_CFirBenAcc)
            {
                r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                vl_Puntos = (byte)(vl_Puntos + r_FirBenAcc.Puntuacion);
                vl_Cuantos++;
                BS_CFirBenAcc.MoveNext();
            }

            if (vl_Cuantos >= 0)
                vl_Puntuacion = (byte)Math.Round((decimal)((float)vl_Puntos / (float)vl_Cuantos), MidpointRounding.AwayFromZero);
            else
                vl_Puntuacion = 0;

            r_Cliente.Benef_Punt = vl_Puntuacion;
            this.Pag2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11005) + ": " + r_Cliente.Benef_Punt.ToString();

            this.AcceptButton = this.Btn_Aceptar;
            this.Grd_CFirBenAcc_CurrentCellChanged(true, e);
        }

        private void Btn_BenefCancelar_Click(object sender, EventArgs e)
        {
            Pan_Detalles2.Enabled = false;
            BenefModConsulta = true;
            this.Grd_CFirBenAcc.Enabled = true;
            this.Pan_BenefBtns.Enabled = true;
            this.Pan_BenefAcepCanc.Visible = false;

            Cmb_BenefEstado.DataSource = NM_Estados.Listar();
            this.AcceptButton = this.Btn_Aceptar;
        }

        
        //**************
        // Eventos del formulario
        //**************
        private void Asigna_Nombres()
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(11000);
            this.Opc_TipPers1.Text = MOFIN_LIB.Funciones._Mens_Idioma(11001);
            this.Opc_TipPers2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11002);
            this.Lbl_Codigo.Text = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Lbl_DocID.Text = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Lbl_Nombre.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_EtiqPunt.Text = MOFIN_LIB.Funciones._Mens_Idioma(11003);

            this.Col_CliCodigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_CliNme.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);

            this.Pag1.Text = MOFIN_LIB.Funciones._Mens_Idioma(11004);
            this.Lbl_TipDocID.Text = MOFIN_LIB.Funciones._Mens_Idioma(10022);
            this.Lbl_FecVencDocID.Text = MOFIN_LIB.Funciones._Mens_Idioma(11008);
            this.Lbl_Nacionalidad.Text = MOFIN_LIB.Funciones._Mens_Idioma(11009);
            this.Lbl_PaisNacimiento.Text = MOFIN_LIB.Funciones._Mens_Idioma(11010);
            this.Lbl_PaisResidencia.Text = MOFIN_LIB.Funciones._Mens_Idioma(11011);
            this.Lbl_Estado.Text = MOFIN_LIB.Funciones._Mens_Idioma(11012);
            this.Lbl_Edad.Text = MOFIN_LIB.Funciones._Mens_Idioma(10014);
            this.Lbl_TipoPersJur.Text = MOFIN_LIB.Funciones._Mens_Idioma(10024);
            this.Lbl_TipoEstructura.Text = MOFIN_LIB.Funciones._Mens_Idioma(10023);
            this.Lbl_PEP.Text = MOFIN_LIB.Funciones._Mens_Idioma(10018);
            this.Lbl_VolOperaciones.Text = MOFIN_LIB.Funciones._Mens_Idioma(11013);
            this.Lbl_Criptomonedas.Text = MOFIN_LIB.Funciones._Mens_Idioma(10013);
            this.Lbl_Profesion.Text = MOFIN_LIB.Funciones._Mens_Idioma(10020);
            this.Lbl_ActivComercial.Text = MOFIN_LIB.Funciones._Mens_Idioma(10011);
            this.Lbl_Productos.Text = MOFIN_LIB.Funciones._Mens_Idioma(10019);
            this.Lbl_Servicios.Text = MOFIN_LIB.Funciones._Mens_Idioma(10021);

            this.Pag2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11005);
            this.Col_BFANme.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_BFADocID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Lbl_BenefEtiqPuntuacion.Text = MOFIN_LIB.Funciones._Mens_Idioma(11003);
            this.Lbl_TipoVinculo.Text = MOFIN_LIB.Funciones._Mens_Idioma(11014);
            this.Opc_TipVinc1.Text = MOFIN_LIB.Funciones._Mens_Idioma(11015);
            this.Opc_TipVinc2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11016);
            this.Opc_TipVinc3.Text = MOFIN_LIB.Funciones._Mens_Idioma(11017);
            this.Lbl_BenefName.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_BenefDoc_ID.Text = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Lbl_BenefNacionalidad.Text = MOFIN_LIB.Funciones._Mens_Idioma(11009);
            this.Lbl_BenefPaisNacim.Text = MOFIN_LIB.Funciones._Mens_Idioma(11010);
            this.Lbl_BenefPaisResid.Text = MOFIN_LIB.Funciones._Mens_Idioma(11011);
            this.Lbl_BenefEstado.Text = MOFIN_LIB.Funciones._Mens_Idioma(11012);
            this.Lbl_BenefFecVenc.Text = MOFIN_LIB.Funciones._Mens_Idioma(11008);
            this.Lbl_BenefEdad.Text = MOFIN_LIB.Funciones._Mens_Idioma(10014);
            this.Lbl_BenefPEP.Text = MOFIN_LIB.Funciones._Mens_Idioma(10018);
            this.Lbl_BenefProfesion.Text = MOFIN_LIB.Funciones._Mens_Idioma(10020);
            this.Lbl_BenefCriptomonedas.Text = MOFIN_LIB.Funciones._Mens_Idioma(10013);
            this.Lbl_BenefVincEmpresa.Text = MOFIN_LIB.Funciones._Mens_Idioma(11018);
            this.Lbl_BenefVincPorcent.Text = MOFIN_LIB.Funciones._Mens_Idioma(11019);

            this.Pag3.Text = MOFIN_LIB.Funciones._Mens_Idioma(11006);
            this.Chk_Opc1.Text = MOFIN_LIB.Funciones._Mens_Idioma(11020);
            this.Chk_Opc2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11021);
            this.Chk_Opc3.Text = MOFIN_LIB.Funciones._Mens_Idioma(11022);
            this.Chk_Opc4.Text = MOFIN_LIB.Funciones._Mens_Idioma(11023);
            this.Chk_Opc5.Text = MOFIN_LIB.Funciones._Mens_Idioma(11024);
            this.Chk_Opc6.Text = MOFIN_LIB.Funciones._Mens_Idioma(11025);
            this.Chk_Opc7.Text = MOFIN_LIB.Funciones._Mens_Idioma(11026);
            this.Chk_Opc8.Text = MOFIN_LIB.Funciones._Mens_Idioma(11027);
            this.Chk_Opc9.Text = MOFIN_LIB.Funciones._Mens_Idioma(11028);
            this.Chk_Opc10.Text = MOFIN_LIB.Funciones._Mens_Idioma(11029);
            this.Chk_Opc11.Text = MOFIN_LIB.Funciones._Mens_Idioma(11030);
            this.Chk_Opc12.Text = MOFIN_LIB.Funciones._Mens_Idioma(11031);
            this.Chk_Opc13.Text = MOFIN_LIB.Funciones._Mens_Idioma(11032);
            this.Chk_Opc14.Text = MOFIN_LIB.Funciones._Mens_Idioma(11033);
            this.Chk_Opc15.Text = "";
            this.Chk_Opc16.Text = MOFIN_LIB.Funciones._Mens_Idioma(11034);
            this.Chk_Opc17.Text = MOFIN_LIB.Funciones._Mens_Idioma(11035);
            this.Chk_Opc18.Text = MOFIN_LIB.Funciones._Mens_Idioma(1010);
            this.Chk_Opc19.Text = MOFIN_LIB.Funciones._Mens_Idioma(11009);
            this.Chk_Opc20.Text = MOFIN_LIB.Funciones._Mens_Idioma(1023);
            this.Chk_Opc21.Text = MOFIN_LIB.Funciones._Mens_Idioma(11036);
            this.Chk_Opc22.Text = MOFIN_LIB.Funciones._Mens_Idioma(11037);
            this.Chk_Opc23.Text = MOFIN_LIB.Funciones._Mens_Idioma(11038);
            this.Chk_Opc24.Text = MOFIN_LIB.Funciones._Mens_Idioma(11039);
            this.Chk_Opc25.Text = MOFIN_LIB.Funciones._Mens_Idioma(11040);
            this.Chk_Opc26.Text = MOFIN_LIB.Funciones._Mens_Idioma(11041);
            this.Chk_Opc27.Text = MOFIN_LIB.Funciones._Mens_Idioma(11042);
            this.Chk_Opc28.Text = MOFIN_LIB.Funciones._Mens_Idioma(11043);
            this.Chk_Opc29.Text = "";
            this.Chk_Opc30.Text = "";

            this.Pag4.Text = MOFIN_LIB.Funciones._Mens_Idioma(1016);
            this.Lbl_Observacion.Text = MOFIN_LIB.Funciones._Mens_Idioma(1016);
            this.Lbl_Ejecutivo.Text = MOFIN_LIB.Funciones._Mens_Idioma(13063);
            this.Lbl_NivRiesgo.Text = MOFIN_LIB.Funciones._Mens_Idioma(13024);
            this.Lbl_PerFinanciero.Text = MOFIN_LIB.Funciones._Mens_Idioma(13021);
            this.Lbl_PerUsoCta.Text = MOFIN_LIB.Funciones._Mens_Idioma(11050);
            this.Opt_PerUsoCta1.Text = MOFIN_LIB.Funciones._Mens_Idioma(191);
            this.Opt_PerUsoCta2.Text = MOFIN_LIB.Funciones._Mens_Idioma(192);
            this.Opt_PerUsoCta3.Text = MOFIN_LIB.Funciones._Mens_Idioma(193);
            this.Opt_PerUsoCta4.Text = MOFIN_LIB.Funciones._Mens_Idioma(194);
            this.Opt_PerUsoCta5.Text = MOFIN_LIB.Funciones._Mens_Idioma(195);
            this.Lbl_NroTransacciones.Text = MOFIN_LIB.Funciones._Mens_Idioma(13023);
            this.Lbl_FecUltAct.Text = MOFIN_LIB.Funciones._Mens_Idioma(11052);
            this.Lbl_TrimPeriodo.Text = MOFIN_LIB.Funciones._Mens_Idioma(11051);
            this.Lbl_TrimNroOper.Text = MOFIN_LIB.Funciones._Mens_Idioma(13023);
            this.Lbl_TrimMtoFinanc.Text = MOFIN_LIB.Funciones._Mens_Idioma(11053);
            this.Lbl_TrimMtoTransac.Text = MOFIN_LIB.Funciones._Mens_Idioma(11054);

            this.Pag5.Text = MOFIN_LIB.Funciones._Mens_Idioma(11007);

            this.TSB_Primero.Text = Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = Funciones._Mens_Idioma(140);


            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }
        
        private void Modo_Consulta()
        {
            Cmb_Estado.DataSource = NM_Estados.Listar();
            Cmb_BenefEstado.DataSource = NM_Estados.Listar();

            Pan_DetallesEnc.Enabled = false;
            Pan_Detalles1.Enabled = false;
            Pan_Detalles2.Enabled = false;
            Pan_Detalles3.Enabled = false;
            Pan_Detalles4.Enabled = false;
            Pan_BenefBtns.Visible = false;
            Pan_BenefAcepCanc.Visible = false;

            TS_BarraHerramientas.Enabled = true;

            Btn_Aceptar.Visible = false;
            Btn_Cancelar.Visible = false;

            this.Grd_Clientes.Enabled = true;
            this.Grd_CFirBenAcc.Enabled = true;
            
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            Pan_DetallesEnc.Enabled = true;
            Txt_Codigo.Enabled = ClienteEsNuevo;
            Pan_Detalles1.Enabled = true;
            this.Cmb_TipoPersJuridica.Enabled = r_Cliente.TipoPersona == (byte)TipoPersona.juridica ? true : false;
            this.Cmb_TipoEstructura.Enabled = this.Cmb_TipoPersJuridica.Enabled;
            Pan_Detalles2.Enabled = false;
            Pan_Detalles3.Enabled = true;
            Pan_Detalles4.Enabled = true;
            Pan_BenefBtns.Visible = true;

            TS_BarraHerramientas.Enabled = false;

            this.Grd_Clientes.Enabled = false;

            Btn_Aceptar.Visible = true;
            Btn_Cancelar.Visible = true;
            this.AcceptButton = this.Btn_Aceptar;

        }

        private void Grd_Clientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BS_CClientes.Current == null)
                return;

            r_Cliente = BS_CClientes.Current as C_Clientes;
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.ListarPorCliente(r_Cliente.Codigo);

            this.Grd_CFirBenAcc_CurrentCellChanged(true, e);

            this.Lbl_Activo.Text = Funciones._Mens_Idioma(r_Cliente.Activo == true ? 126 : 127);
            this.Lbl_Activo.ForeColor = r_Cliente.Activo == true ? Color.Green : Color.Red;

            this.Opc_TipPers1.Checked = r_Cliente.TipoPersona == (byte)TipoPersona.natural ? true : false ;
            this.Opc_TipPers2.Checked = r_Cliente.TipoPersona == (byte)TipoPersona.juridica ? true : false;

            this.Lbl_Edad.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 10014 : 10012 );
            Cmb_Edad.Visible = r_Cliente.TipoPersona == 1 ? true : false;
            Cmb_Antiguedad.Visible = !Cmb_Edad.Visible;
            Cmb_VolOperNat.Visible = Cmb_Edad.Visible;
            Cmb_VolOperJur.Visible = !Cmb_Edad.Visible;

            this.Chk_Opc5.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11024 : 1009);
            this.Chk_Opc6.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11025 : 1011);
            this.Chk_Opc16.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11034 : 11047);
            this.Chk_Opc19.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11009 : 11043);
            this.Chk_Opc20.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 1023 : 11044);
            this.Chk_Opc21.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11036 : 11045);
            this.Chk_Opc22.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11037 : 11046);
            this.Chk_Opc23.Visible = r_Cliente.TipoPersona == 1 ? true : false;
            this.Chk_Opc24.Visible = this.Chk_Opc23.Visible;
            this.Chk_Opc25.Visible = this.Chk_Opc23.Visible;
            this.Chk_Opc26.Visible = this.Chk_Opc23.Visible;
            this.Chk_Opc27.Visible = this.Chk_Opc23.Visible;

            switch(r_Cliente.PeriodUsoCta)
            {
                case (byte)PeriodoUsoCta.semanal:
                    Opt_PerUsoCta1.Checked = true;
                    break;
                case (byte)PeriodoUsoCta.mensual:
                    Opt_PerUsoCta2.Checked = true;
                    break;
                case (byte)PeriodoUsoCta.trimestral:
                    Opt_PerUsoCta3.Checked = true;
                    break;
                case (byte)PeriodoUsoCta.semestral:
                    Opt_PerUsoCta4.Checked = true;
                    break;
                case (byte)PeriodoUsoCta.anual:
                    Opt_PerUsoCta5.Checked = true;
                    break;
            }

            this.Pag1.Text = MOFIN_LIB.Funciones._Mens_Idioma(11004) + ": " + r_Cliente.InfGen_Punt.ToString();
            this.Pag2.Text = MOFIN_LIB.Funciones._Mens_Idioma(11005) + ": " + r_Cliente.Benef_Punt.ToString();
            Lbl_Puntuacion.Text = r_Cliente.Cliente_Punt.ToString();
            

            List<C_ProdServ> ProdSelec = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Producto);
            for (int i = 0; i < m_Productos.Count; i++)
            {
                Chlst_Productos.SetItemChecked(i, false);
            }
            for (int i = 0; i < m_Productos.Count; i++)
            {
                for (int j = 0; j < ProdSelec.Count; j++)
                {
                    if (m_Productos[i].Codigo == ProdSelec[j].Cod_Tipo)
                    {
                        Chlst_Productos.SetItemChecked(i, true);
                    }
                }
            }

            List<C_ProdServ> ServSelec = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Servicio);
            for (int i = 0; i < m_Servicios.Count; i++)
            {
                Chlst_Servicios.SetItemChecked(i, false);
            }

            for (int i = 0; i < m_Servicios.Count; i++)
            {
                for (int j = 0; j < ServSelec.Count; j++)
                {
                    if (m_Servicios[i].Codigo == ServSelec[j].Cod_Tipo)
                    {
                        Chlst_Servicios.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void Grd_CFirBenAcc_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BS_CFirBenAcc.Current == null)
            {
                Opc_TipVinc1.Checked = false;
                Opc_TipVinc2.Checked = false;
                Opc_TipVinc3.Checked = false;
                return;
            }
            else
            {
                r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                this.Lbl_BenefPuntuacion.Text = r_FirBenAcc.Puntuacion.ToString();

                switch(r_FirBenAcc.TipoVinculo)
                {
                    case (byte)TipoVinculo.Final :
                        Opc_TipVinc1.Checked = true;
                        break;
                    case (byte)TipoVinculo.Firmante :
                        Opc_TipVinc2.Checked = true;
                        break;
                    case (byte)TipoVinculo.Conyugue :
                        Opc_TipVinc3.Checked = true;
                        break;
                }
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

                this.Lbl_Edad.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 10014 : 10012);
                Cmb_Edad.Visible = r_Cliente.TipoPersona == 1 ? true : false;
                Cmb_Antiguedad.Visible = !Cmb_Edad.Visible;
                Cmb_VolOperNat.Visible = Cmb_Edad.Visible;
                Cmb_VolOperJur.Visible = !Cmb_Edad.Visible;

                this.Chk_Opc5.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11024 : 1009);
                this.Chk_Opc6.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11025 : 1011);
                this.Chk_Opc16.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11034 : 11047);
                this.Chk_Opc19.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11009 : 11043);
                this.Chk_Opc20.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 1023 : 11044);
                this.Chk_Opc21.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11036 : 11045);
                this.Chk_Opc22.Text = Funciones._Mens_Idioma(r_Cliente.TipoPersona == (byte)TipoPersona.natural ? 11037 : 11046);
                this.Chk_Opc23.Visible = r_Cliente.TipoPersona == 1 ? true : false;
                this.Chk_Opc24.Visible = this.Chk_Opc23.Visible;
                this.Chk_Opc25.Visible = this.Chk_Opc23.Visible;
                this.Chk_Opc26.Visible = this.Chk_Opc23.Visible;
                this.Chk_Opc27.Visible = this.Chk_Opc23.Visible;
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
 
        private void Cmb_Estado_Enter(object sender, EventArgs e)
        {
            if (Cmb_PaisResidencia.SelectedIndex != -1)
            {
                short pais = (short)Cmb_PaisResidencia.SelectedValue;
                Cmb_Estado.DataSource = NM_Estados.ListarPorPais(pais);
                //Cmb_Estado.DisplayMember = "Descripcion";
                //Cmb_Estado.ValueMember = "Cod_Compuesto";
            }
        }

        private void Cmb_BenefEstado_Enter(object sender, EventArgs e)
        {
            if (Cmb_BenefPaisResid.SelectedIndex != -1)
            {
                short pais = (short)Cmb_BenefPaisResid.SelectedValue;

                Cmb_BenefEstado.DataSource = NM_Estados.ListarPorPais(pais);
                //                Cmb_BenefEstado.DisplayMember = "Descripcion";
                //                Cmb_BenefEstado.ValueMember = "Codigo";
            }

        }

        private void Clientes_RellenaDatosCalculo()
        {
            // son 13 controles fijos mas los producot sy sevicios

            if (r_Cliente.IG_TipDocID != 0 & r_Cliente.IG_TipDocID != null)
            {
                M_TipoDocID r_TipoDocID = NM_TipoDocID.ListarPorCodigo((short)r_Cliente.IG_TipDocID).First();
                punt_Cliente.puntos_TipoDocID = r_TipoDocID.Valor;
            }
            else
                punt_Cliente.puntos_TipoDocID = 0;

            if(r_Cliente.IG_Nacionalidad != 0 & r_Cliente.IG_Nacionalidad != null)
            {
                M_Pais r_Pais = NM_Pais.ListarPorCodigo((short)r_Cliente.IG_Nacionalidad).First();
                punt_Cliente.puntos_nacionalidad = r_Pais.Valor;
            }
            else
                punt_Cliente.puntos_nacionalidad = 0;

            if (r_Cliente.IG_PaisNacim != 0 & r_Cliente.IG_PaisNacim != null)
            {
                M_Pais r_Pais = NM_Pais.ListarPorCodigo((short)r_Cliente.IG_PaisNacim).First();
                punt_Cliente.puntos_paisNac = r_Pais.Valor;
            }
            else
                punt_Cliente.puntos_paisNac = 0;

            if (r_Cliente.IG_PaisResid != 0 & r_Cliente.IG_PaisResid != null)
            {
                M_Pais r_Pais = NM_Pais.ListarPorCodigo((short)r_Cliente.IG_PaisResid).First();
                punt_Cliente.puntos_paisRes = r_Pais.Valor;
            }
            else
                punt_Cliente.puntos_paisRes = 0;

            if (r_Cliente.IG_Estado != 0 & r_Cliente.IG_Estado != null)
            {
                M_Estados r_Estados = NM_Estados.ListarPorCodigo((int)r_Cliente.IG_Estado).First();
                punt_Cliente.puntos_UbicGeo = r_Estados.Valor;
            }
            else
                punt_Cliente.puntos_UbicGeo = 0;

            if (r_Cliente.TipoPersona == (byte)TipoPersona.natural)
            {
                if (r_Cliente.IG_Edad != 0 & r_Cliente.IG_Edad != null)
                {
                    M_Edad r_Edad = NM_Edad.ListarPorCodigo((short)r_Cliente.IG_Edad).First();
                    punt_Cliente.puntos_edad = r_Edad.Valor;
                }
                else
                    punt_Cliente.puntos_edad = 0;
            }
            else
            {
                if (r_Cliente.IG_Edad != 0 & r_Cliente.IG_Edad != null)
                {
                    M_Antiguedad r_Antiguedad = NM_Antiguedad.ListarPorCodigo((short)r_Cliente.IG_Edad).First();
                    punt_Cliente.puntos_edad = r_Antiguedad.Valor;
                }
                else
                    punt_Cliente.puntos_edad = 0;
            }

            if (r_Cliente.IG_TipoPersJur != 0 & r_Cliente.IG_TipoPersJur != null)
            {
                M_TipoPersJuridica r_TipoPersJuridica = NM_TipoPersJuridica.ListarPorCodigo((short)r_Cliente.IG_TipoPersJur).First();
                punt_Cliente.puntos_tipoPers = r_TipoPersJuridica.Valor;
            }
            else
                punt_Cliente.puntos_tipoPers = 0;

            if (r_Cliente.IG_TipoEstructura != 0 & r_Cliente.IG_TipoEstructura != null)
            {
                M_TipoEstructuraEmpresa r_TipoEstructura = NM_TipoEstructuraEmpresa.ListarPorCodigo((short)r_Cliente.IG_TipoEstructura).First();
                punt_Cliente.puntos_estruc = r_TipoEstructura.Valor;
            }
            else
                punt_Cliente.puntos_estruc = 0;

            if (r_Cliente.IG_PEP != 0 & r_Cliente.IG_PEP != null)
            {
                M_PEP r_PEP = NM_PEP.ListarPorCodigo((short)r_Cliente.IG_PEP).First();
                punt_Cliente.puntos_pep = r_PEP.Valor;
            }
            else
                punt_Cliente.puntos_pep = 0;
                       
            if (r_Cliente.IG_VolumOperac != 0 & r_Cliente.IG_VolumOperac != null)
            {
                M_VolOperPersNat r_VolOperNat = BS_MVolOperPersNat.Current as M_VolOperPersNat;
                M_VolOperPersJur r_VolOperJur = BS_MVolOperPersJur.Current as M_VolOperPersJur;
                if (r_Cliente.TipoPersona == (byte)TipoPersona.natural)
                    r_VolOperNat = NM_VolOperPersNat.ListarPorCodigo((short)r_Cliente.IG_VolumOperac).First();
                else
                    r_VolOperJur = NM_VolOperPersJur.ListarPorCodigo((short)r_Cliente.IG_VolumOperac).First();

                punt_Cliente.puntos_volOper = r_Cliente.TipoPersona == (byte)TipoPersona.natural?  r_VolOperNat.Valor : r_VolOperJur.Valor;
            }
            else
                punt_Cliente.puntos_volOper = 0;

            if (r_Cliente.IG_Criptomoneda != 0 & r_Cliente.IG_Criptomoneda != null)
            {
                M_Criptomonedas r_Criptomon = NM_Criptomonedas.ListarPorCodigo((short)r_Cliente.IG_Criptomoneda).First();
                punt_Cliente.puntos_cripto = r_Criptomon.Valor;
            }
            else
                punt_Cliente.puntos_cripto = 0;

            if (r_Cliente.IG_Profesion != 0 & r_Cliente.IG_Profesion != null)
            {
                M_Profesiones r_Profesion = NM_Profesiones.ListarPorCodigo((short)r_Cliente.IG_Profesion).First();
                punt_Cliente.puntos_profesion = r_Profesion.Valor;
            }
            else
                punt_Cliente.puntos_profesion = 0;

            if (r_Cliente.IG_ActivComer != 0 & r_Cliente.IG_ActivComer != null)
            {
                M_ActivComercial r_ActivComerc = NM_ActivComercial.ListarPorCodigo((short)r_Cliente.IG_ActivComer).First();
                punt_Cliente.puntos_ActComer = r_ActivComerc.Valor;
            }
            else
                punt_Cliente.puntos_ActComer = 0;

            var Lst_ProdxClie = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Producto);
            int Suma_Prod = 0;
            int Cant_Prod = Lst_ProdxClie.Count;
            for (int i = 0; i < Cant_Prod; i++)
                Suma_Prod = Suma_Prod + Lst_ProdxClie[i].Valor ;
            punt_Cliente.puntos_Productos = (byte)Math.Round(((float)Suma_Prod / (float)Cant_Prod));

            var Lst_ServxClie = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Servicio);
            int Suma_Serv = 0;
            int Cant_Serv = Lst_ServxClie.Count;
            for (int i = 0; i < Cant_Serv; i++)
                Suma_Serv = Suma_Serv + Lst_ServxClie[i].Valor;
            punt_Cliente.puntos_Servicios  = (byte)Math.Round(((float)Suma_Serv / (float)Cant_Serv));

        }

        private void FirBenAcc_RellenaDatosCalculo()
        {
            // son 13 controles fijos mas los producot sy sevicios

            if (r_FirBenAcc.Nacionalidad != 0 & r_FirBenAcc.Nacionalidad!= null)
            {
                M_Pais r_Pais = NM_Pais.ListarPorCodigo((short)r_FirBenAcc.Nacionalidad).First();
                punt_FirBenAcc.puntos_nacionalidad = r_Pais.Valor;
            }
            else
                punt_FirBenAcc.puntos_nacionalidad = 0;

            if (r_FirBenAcc.PaisNacim != 0 & r_FirBenAcc.PaisNacim != null)
            {
                M_Pais r_Pais = NM_Pais.ListarPorCodigo((short)r_FirBenAcc.PaisNacim).First();
                punt_FirBenAcc.puntos_paisNac = r_Pais.Valor;
            }
            else
                punt_FirBenAcc.puntos_paisNac = 0;

            if (r_FirBenAcc.PaisResid != 0 & r_FirBenAcc.PaisResid != null)
            {
                M_Pais r_Pais = NM_Pais.ListarPorCodigo((short)r_FirBenAcc.PaisResid).First();
                punt_FirBenAcc.puntos_paisRes = r_Pais.Valor;
            }
            else
                punt_FirBenAcc.puntos_paisRes = 0;

            if (r_FirBenAcc.Estado != 0 & r_FirBenAcc.Estado != null)
            {
                M_Estados r_Estados = NM_Estados.ListarPorCodigo((int)r_FirBenAcc.Estado).First();
                punt_FirBenAcc.puntos_UbicGeo = r_Estados.Valor;
            }
            else
                punt_FirBenAcc.puntos_UbicGeo = 0;

            if (r_FirBenAcc.Edad != 0 & r_FirBenAcc.Edad != null)
            {
                M_Edad r_Edad = NM_Edad.ListarPorCodigo((short)r_FirBenAcc.Edad).First();
                punt_FirBenAcc.puntos_edad = r_Edad.Valor;
            }
            else
                punt_FirBenAcc.puntos_edad = 0;

            if (r_FirBenAcc.PEP != 0 & r_FirBenAcc.PEP != null)
            {
                M_PEP r_PEP = NM_PEP.ListarPorCodigo((short)r_FirBenAcc.PEP).First();
                punt_FirBenAcc.puntos_pep = r_PEP.Valor;
            }
            else
                punt_FirBenAcc.puntos_pep = 0;

            if (r_FirBenAcc.Criptomoneda != 0 & r_FirBenAcc.Criptomoneda != null)
            {
                M_Criptomonedas r_Criptomon = NM_Criptomonedas.ListarPorCodigo((short)r_FirBenAcc.Criptomoneda).First();
                punt_FirBenAcc.puntos_cripto = r_Criptomon.Valor;
            }
            else
                punt_FirBenAcc.puntos_cripto = 0;

            if (r_FirBenAcc.Profesion != 0 & r_FirBenAcc.Profesion != null)
            {
                M_Profesiones r_Profesion = NM_Profesiones.ListarPorCodigo((short)r_FirBenAcc.Profesion).First();
                punt_FirBenAcc.puntos_profesion = r_Profesion.Valor;
            }
            else
                punt_FirBenAcc.puntos_profesion = 0;

        }
        private void Lbl_Puntuacion_TextChanged(object sender, EventArgs e)
        {
            switch(this.Lbl_Puntuacion.Text)
            {
                case "3":
                    this.Lbl_Puntuacion.ForeColor = Color.Red;
                    break;
                case "2":
                    this.Lbl_Puntuacion.ForeColor = Color.Yellow;
                    break;
                default:
                    this.Lbl_Puntuacion.ForeColor = Color.Green;
                    break;
            }
        }

        private void Lbl_BenefPuntuacion_TextChanged(object sender, EventArgs e)
        {
            switch (this.Lbl_BenefPuntuacion.Text)
            {
                case "3":
                    this.Lbl_BenefPuntuacion.ForeColor = Color.Red;
                    break;
                case "2":
                    this.Lbl_BenefPuntuacion.ForeColor = Color.Yellow;
                    break;
                default:
                    this.Lbl_BenefPuntuacion.ForeColor = Color.Green;
                    break;
            }

        }

        private void Btn_Trimestre_Click(object sender, EventArgs e)
        {
            DateTime vl_FDesde = DateTime.Today;
            DateTime vl_FHasta = DateTime.Today;
            switch (this.NUD_TriMes.Value)
            {
                case 1:
                    vl_FDesde = DateTime.Parse("01/01/" + this.NUD_TriAno.Value.ToString());
                    vl_FHasta = DateTime.Parse("31/03/" + this.NUD_TriAno.Value.ToString());
                    break;
                case 2:
                    vl_FDesde = DateTime.Parse("01/04/" + this.NUD_TriAno.Value.ToString());
                    vl_FHasta = DateTime.Parse("30/06/" + this.NUD_TriAno.Value.ToString());
                    break;
                case 3:
                    vl_FDesde = DateTime.Parse("01/07/" + this.NUD_TriAno.Value.ToString());
                    vl_FHasta = DateTime.Parse("30/09/" + this.NUD_TriAno.Value.ToString());
                    break;
                case 4:
                    vl_FDesde = DateTime.Parse("01/10/" + this.NUD_TriAno.Value.ToString());
                    vl_FHasta = DateTime.Parse("31/12/" + this.NUD_TriAno.Value.ToString());
                    break;
            }
            ///
            /// Calculo de las Operaciones Financieras
            /// 
            var Lst_OpeFinan = NO_Operfinancieras.ListarPorCodigo(r_Cliente.Codigo, vl_FDesde, vl_FHasta).ToList();
            short vl_NroOperfin = (short)Lst_OpeFinan.Count();// (item => item.Efectivo);
            decimal vl_TrimMtoFin = (decimal)Lst_OpeFinan.Sum(item => item.Efectivo);

            Txt_TrimNroOperFin.Text = vl_NroOperfin.ToString();
            this.Txt_TrimOpFinan.Text = vl_TrimMtoFin.ToString("N");

            r_Cliente.Trim_NroOperFin = vl_NroOperfin;
            r_Cliente.Trim_MtoFinanc = vl_TrimMtoFin;

            ///
            /// Calculo de las Operaciones Transaccionales
            /// 
            // List<O_OperTransaccionales> Lst_Operaciones;
            var Lst_OpeTransac = NO_OperTransaccionales.ListarPorCodigo(r_Cliente.Codigo, vl_FDesde, vl_FHasta).ToList();
            decimal vl_Compra = 0;
            decimal vl_Venta = 0;
            decimal vl_Total = 0;
            short vl_NroOperTrans = 0;
            foreach (var r_registro in Lst_OpeTransac)
            {   /********
                **Procedimiento para el calculo de los datos mensual del reporte
                *******
                * Tipo de Operacion         SUMA +      Valor       RESTA -     Valor
                * Renta Variable            Venta       Columna1    Compra      Columna1
                * Renta Fija                Compra      Columna1    Venta       Columna1
                * Renta Fija                Venta       Columna1    Compra      Columna1 
                * Margen                    Abono       Columna1    Retiro      Columna1
                *                           Apertura    Columna1    Cierre      Columna1
                * Mutuo                     Cierre      Columna2    Apertura    Columna1
                *******
                * Campos: rg_detopet
                * Tip_Orden, Cod_Clie, mto_Pactad, Val_Efect, Grp_Clie
                *
                *******/
                switch (r_registro.Tipo_Operacion.Trim())
                {
                    case "MARGEN":     // 0 : MARGEN
                        if (r_registro.Tipo_Orden.ToUpper() == "ABONO" | r_registro.Tipo_Orden.ToUpper() == "APERT")
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        else
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Monto_Pactado;
                        }
                        break;

                    case "RENTA FIJA":     // 1 : RENTA FIJA
                        if (r_registro.Tipo_Orden.ToUpper() == "VENTA")
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Monto_Pactado;
                        }
                        else
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        break;

                    case "RENTA VARIABLE":     // 2 : RENTA VARIABLE
                        if (r_registro.Tipo_Orden.ToUpper() == "VENTA")
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Monto_Pactado;
                        }
                        else
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        break;

                    case "FURUTOS":     // 3 : FUTUROS
                        vl_Compra = 0;
                        vl_Venta = 0;
                        break;

                    case "OPCIONES":     // 4 : OPCIONES
                        vl_Compra = 0;
                        vl_Venta = 0;
                        break;

                    case "MUTUO":     // 0 :MUTUO
                        if (r_registro.Tipo_Orden.ToUpper() == "CIERR")
                        {
                            vl_Compra = 0;
                            vl_Venta = (Decimal)r_registro.Valor_Efectivo;
                        }
                        else
                        {
                            vl_Compra = (Decimal)r_registro.Monto_Pactado;
                            vl_Venta = 0;
                        }
                        break;

                }

                vl_NroOperTrans++;
                vl_Total = vl_Total + (vl_Compra + vl_Venta);

            }

            this.Txt_TrimNroOperTran.Text = vl_NroOperTrans.ToString();
            this.Txt_TrimOpTransac.Text = vl_Total.ToString("N");
            r_Cliente.Trim_NroOperTrans = vl_NroOperTrans;
            r_Cliente.Trim_MtoTransac = vl_Total;
        }
    }
}
