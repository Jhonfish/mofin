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
    };

    enum TipoVinculo
    {
        Final = 1,
        Firmante = 2,
        Conyugue = 3
    };

    enum PeriodoUsoCta
    {
        semanal = 1,
        mensual = 2,
        trimestral = 3,
        semestral = 4,
        anual = 5
    };

    enum TipoProdServ
    {
        Producto = 1,
        Servicio = 2
    };

    struct Puntuacion
    {
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
        public byte total;
        public byte promedio;

        public byte Promedio()
        {
            total = 0;
            promedio = 0;
            if (puntos_nacionalidad != 0)
            {
                promedio += puntos_nacionalidad;
                total++;
            }
            if (puntos_paisNac != 0)
            {
                promedio += puntos_paisNac;
                total++;
            }   
            if (puntos_paisRes != 0)
            {
                promedio += puntos_paisRes;
                total++;
            }
            if (puntos_UbicGeo != 0)
            {
                promedio += puntos_UbicGeo;
                total++;
            }
            if (puntos_profesion != 0)
            {
                promedio += puntos_profesion;
                total++;
            }
            if (puntos_ActComer != 0)
            {
                promedio += puntos_ActComer;
                total++;
            }
            if (puntos_edad != 0)
            {
                promedio += puntos_edad;
                total++;
            }
            if (puntos_tipoPers != 0)
            {
                promedio += puntos_tipoPers;
                total++;
            }
            if (puntos_estruc != 0)
            {
                promedio += puntos_estruc;
                total++;
            }
            if (puntos_pep != 0)
            {
                promedio += puntos_pep;
                total++;
            }
            if (puntos_volOper != 0)
            {
                promedio += puntos_volOper;
                total++;
            }
            if(puntos_cripto != 0)
            {
                promedio += puntos_cripto;
                total++;
            }
            return (byte)(promedio / total);
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
        Puntuacion puntuacion;
        List<M_Servicios> m_Servicios;
        List<M_Productos> m_Productos;
        List<M_Productos> m_ProdSeleccionado = new List<M_Productos>();
        List<M_Servicios> m_ServSelecionado = new List<M_Servicios>();
        

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
            
            m_Servicios = NM_Servicios.Listar();
            m_Productos = NM_Productos.Listar();
            //m_ProdServ = NC_ProdServ.Listar();

            /*
            foreach (M_Servicios item in m_Servicios)
            {
                Chlst_Servicos.Items.Add(item.Descripcion);
            }

            foreach (M_Productos item in m_Productos)
            {
                Chlst_Productos.Items.Add(item.Descripcion);
            }
            */

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

            //for(int i = 0; i < Chlst_Productos.Items.Count; i++)
            //{
            //    for (int j = 0; j < variable; j++)
            //    {
            //
            //    }
            //}

            /*
            for (int i = 0; i < Chlst_Servicios.Items.Count; i++)
            {


                if (Chlst_Servicios.GetItemChecked(i))
                {
                    C_ProdServ m_ProdServ = new C_ProdServ();
                    m_ProdServ.Cod_Cliente = r_Cliente.Codigo;
                    m_ProdServ.Tipo_ProdServ = 2;
                    m_ProdServ.Cod_Tipo = (byte)m_Servicios[i].Codigo;
                    m_ProdServ.valor = true;
                    NC_ProdServ.Insertar(m_ProdServ);
                }
            }

            for (int i = 0; i < Chlst_Productos.Items.Count; i++)
            {
                if (Chlst_Productos.GetItemChecked(i))
                {
                    C_ProdServ m_ProdServ = new C_ProdServ();
                    m_ProdServ.Cod_Cliente = r_Cliente.Codigo;
                    m_ProdServ.Tipo_ProdServ = 1;
                    m_ProdServ.Cod_Tipo = (byte)m_Productos[i].Codigo;
                    m_ProdServ.valor = true;

                    NC_ProdServ.Insertar(m_ProdServ);
                }
            }
            */
            List<C_ProdServ> ProdSelec = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Producto);

            foreach(M_Productos prod in Chlst_Productos.CheckedItems)
            {
                m_ProdSeleccionado.Add(prod);
            }

            for (int i = 0; i < ProdSelec.Count; i++)
            {
                bool existe = (from c in m_ProdSeleccionado where c.Codigo == ProdSelec[i].Cod_Tipo select c).Any();
                if (!existe)
                {
                    NC_ProdServ.Elimiar(ProdSelec[i]);
                }
            }

            for (int i = 0; i < m_ProdSeleccionado.Count; i++)
            {
                for (int j = 0; j < ProdSelec.Count; j++)
                {
                    if (m_ProdSeleccionado[i].Codigo == ProdSelec[j].Cod_Tipo)
                    {
                        m_ProdSeleccionado.RemoveAt(i);
                    }
                }
            }

            foreach (M_Productos producto in m_ProdSeleccionado)
            {
                C_ProdServ m_ProdServ = new C_ProdServ();
                m_ProdServ.Cod_Cliente = r_Cliente.Codigo;
                m_ProdServ.Tipo_ProdServ = (byte)TipoProdServ.Producto;
                m_ProdServ.Cod_Tipo = (byte)producto.Codigo;
                m_ProdServ.valor = true;

                NC_ProdServ.Insertar(m_ProdServ);
            }

            List<C_ProdServ> ServSelec = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Servicio);

            foreach (M_Servicios serv in Chlst_Servicios.CheckedItems)
            {
                m_ServSelecionado.Add(serv);
            }

            for (int i = 0; i < ServSelec.Count; i++)
            {
                bool existe = (from c in m_ServSelecionado where c.Codigo == ServSelec[i].Cod_Tipo select c).Any();
                if (!existe)
                {
                    NC_ProdServ.Elimiar(ServSelec[i]);
                }
            }

            for (int i = 0; i < m_ServSelecionado.Count; i++)
            {
                for (int j = 0; j < ServSelec.Count; j++)
                {
                    if (m_ServSelecionado[i].Codigo == ServSelec[j].Cod_Tipo)
                    {
                        m_ServSelecionado.RemoveAt(i);
                    }
                }
            }

            foreach (M_Servicios servicio in m_ServSelecionado)
            {
                C_ProdServ m_ProdServ = new C_ProdServ();
                m_ProdServ.Cod_Cliente = r_Cliente.Codigo;
                m_ProdServ.Tipo_ProdServ = (byte)TipoProdServ.Servicio;
                m_ProdServ.Cod_Tipo = (byte)servicio.Codigo;
                m_ProdServ.valor = true;

                NC_ProdServ.Insertar(m_ProdServ);
            }
           
            if (ClienteEsNuevo)
            {
                r_Cliente.Cliente_Punt = puntuacion.Promedio();
                NC_Clientes.Insertar(r_Cliente);
                //NC_FirBenAcc.Insertar(r_FirBenAcc);
            }   
            else
            {
                //NC_Clientes.Actualizar(BS_CClientes.Current as C_Clientes);
                //NC_FirBenAcc.Actualizar(BS_CFirBenAcc.Current as C_FirBenAcc);
                //m_ProdServ = NC_ProdServ.ListarPorCliente(r_Cliente.Codigo);

                //foreach(string serv in Chlst_Servicos.CheckedItems)
               /*
                for (int i = 0; i < Chlst_Servicos.Items.Count; i++)
                {
                    if (Chlst_Servicos.GetItemChecked(i))
                    {
                        //C_ProdServ m_ProdServ = new C_ProdServ();
                        //m_ProdServ.Cod_Cliente = r_Cliente.Codigo;
                        //m_ProdServ.Tipo_ProdServ = 2;
                        //m_ProdServ.Cod_Tipo = (byte)m_Servicios[i].Codigo;
                        //m_ProdServ.valor = true;

                        NC_ProdServ.Actualizar(m_ProdServ);
                    }
                }

                for (int i = 0; i < Chlst_Productos.Items.Count; i++)
                {
                    if (Chlst_Productos.GetItemChecked(i))
                    {
                        //C_ProdServ m_ProdServ = new C_ProdServ();
                        //m_ProdServ.Cod_Cliente = r_Cliente.Codigo;
                        //m_ProdServ.Tipo_ProdServ = 1;
                        //m_ProdServ.Cod_Tipo = (byte)m_Productos[i].Codigo;
                        m

                        NC_ProdServ.Actualizar(m_ProdServ);
                    }
                }
                */
                byte punt = puntuacion.Promedio();
                if (punt != 0)
                    r_Cliente.InfGen_Punt = punt;
                else
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
            if(Opc_TipPers1.Checked)
            {
                Cmb_TipoPersJuridica.Enabled = false;
                Cmb_TipoEstructura.Enabled = false;
            }
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
                {
                    Opc_TipPers1.Checked = true;
                    Lbl_Edad.Text = "Edad:";
                    Lbl_Edad.Enabled = true;
                    Cmb_Edad.BringToFront();
                    Cmb_VolOperNat.BringToFront();
                }
                else
                {
                    Opc_TipPers2.Checked = true;
                    Lbl_Edad.Text = "Antiguedad:";
                    Lbl_Edad.Enabled = true;
                    Cmb_Antiguedad.BringToFront();
                    Cmb_VolOperJur.BringToFront();
                }
                    

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

                Tab_Clientes.TabPages[0].Text = "Información General: " + r_Cliente.InfGen_Punt.ToString();
                Lbl_Puntuacion.Text = r_Cliente.Cliente_Punt.ToString();
            }
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.ListarPorCliente(r_Cliente.Codigo);

            List<C_ProdServ> ProdSelec = NC_ProdServ.ListarPorClienyTipProdServ(r_Cliente.Codigo, (byte)TipoProdServ.Producto);

            Chlst_Productos.Items.Clear();

            foreach (M_Productos item in m_Productos)
            {
                Chlst_Productos.Items.Add(item);
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

            Chlst_Servicios.Items.Clear();

            foreach (M_Servicios item in m_Servicios)
            {
                Chlst_Servicios.Items.Add(item);
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
            /*
             * Este codigo va en un procedimiento de ayuda
             * calcula el promedio de todas las puntuaciones de los beneficiarios
             * del cliente seleccionado
             * *********************************************************************
            List<C_FirBenAcc> lstFirBenAcc = NC_FirBenAcc.ListarPorCliente(r_Cliente.Codigo);
            byte media = 0; 
            byte cont = 0;
            foreach(C_FirBenAcc dato in lstFirBenAcc)
            {
                media += (byte)dato.Puntuacion;
                cont++;
            }
            media = (byte)(media / cont);
            */
            if (BS_CFirBenAcc.Current == null)
                return;
            else
            {
                r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                Tab_Clientes.TabPages[1].Text = "Beneficiarios / Autorizados: " + r_Cliente.Benef_Punt.ToString();
            }
        }

        private void Cmb_PaisResidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_PaisResidencia.SelectedIndex != -1)
            {
                short pais = (short) Cmb_PaisResidencia.SelectedValue;

                Cmb_Estado.DataSource = NM_Estados.ListarPorPais(pais);
                Cmb_Estado.DisplayMember = "Descripcion";
                Cmb_Estado.ValueMember = "Codigo";

                M_Pais m_Pais = BS_MPais.Current as M_Pais;
                puntuacion.puntos_paisRes = m_Pais.Valor;
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
                {
                    r_Cliente.TipoPersona = (byte)TipoPersona.natural;
                    Lbl_Edad.Text = "Edad:";
                    Lbl_Edad.Enabled = true;
                    Cmb_Edad.BringToFront();
                    Cmb_VolOperNat.BringToFront();
                }
                   
                else
                {
                    r_Cliente.TipoPersona = (byte)TipoPersona.juridica;
                    Lbl_Edad.Text = "Antiguedad";
                    Lbl_Edad.Enabled = true;
                    Cmb_Antiguedad.BringToFront();
                    Cmb_VolOperJur.BringToFront();
                }  
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

        private void Cmb_Nacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Nacionalidad.SelectedIndex != -1)
            {
                M_Pais m_Pais = BS_MPais.Current as M_Pais;
                puntuacion.puntos_nacionalidad = m_Pais.Valor;
            }
        }

        private void Cmb_PaisNacimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_PaisNacimiento.SelectedIndex != -1)
            {
                M_Pais m_Pais = BS_MPais.Current as M_Pais;
                puntuacion.puntos_paisNac = m_Pais.Valor;
            }

        }

        private void Cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Estado.SelectedIndex != -1)
            {
                M_Estados m_Estados = BS_MEstados.Current as M_Estados;
                puntuacion.puntos_UbicGeo = m_Estados.Valor;
            }
        }

        private void Cmb_Profesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Profesion.SelectedIndex != -1)
            {
                M_Profesiones m_Profesion = BS_MProfesiones.Current as M_Profesiones;
                puntuacion.puntos_profesion = m_Profesion.Valor;
            }
        }

        private void Cmb_ActivComercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_ActivComercial.SelectedIndex != -1)
            {
                M_ActivComercial m_ActvComercial = BS_MActivComercial.Current as M_ActivComercial;
                puntuacion.puntos_ActComer = m_ActvComercial.Valor;
            }
        }

        private void Cmb_Edad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Edad.SelectedIndex != -1)
            {
                M_Edad m_Edad = BS_MEdad.Current as M_Edad;
                puntuacion.puntos_edad = m_Edad.Valor;
            }
        }

        private void Cmb_TipoPersJuridica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_TipoPersJuridica.SelectedIndex != -1)
            {
                M_TipoPersJuridica m_TipoPersJuridica = BS_MTipoPersJuridica.Current as M_TipoPersJuridica;
                puntuacion.puntos_tipoPers = m_TipoPersJuridica.Valor;
            }
        }

        private void Cmb_TipoEstructura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_TipoEstructura.SelectedIndex != -1)
            {
                M_TipoEstructuraEmpresa m_TipoEstructura = BS_MTipoEstructuraEmpresa.Current as M_TipoEstructuraEmpresa;
                puntuacion.puntos_estruc = m_TipoEstructura.Valor;
            }
        }

        private void Cmb_PEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_PEP.SelectedIndex != -1)
            {
                M_PEP m_Pep = BS_MPEP.Current as M_PEP;
                puntuacion.puntos_pep = m_Pep.Valor;
            }
        }

        private void Cmb_VolOperNat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_VolOperNat.SelectedIndex != -1)
            {
                M_VolOperPersNat m_VolOperPerNat = BS_MVolOperPersNat.Current as M_VolOperPersNat;
                puntuacion.puntos_volOper = m_VolOperPerNat.Valor;
            }
        }

        private void Cmb_Criptomonedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Criptomonedas.SelectedIndex != -1)
            {
                M_Criptomonedas m_Cripto = BS_MCriptomonedas.Current as M_Criptomonedas;
                puntuacion.puntos_cripto = m_Cripto.Valor;
            }
        }
    }
}
