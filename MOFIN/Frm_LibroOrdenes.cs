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
    public partial class Frm_LibroOrdenes : MetroForm
    {
        bool vl_EsNuevo = false;
        L_LibroOrdenes r_LibroOrdenes = new L_LibroOrdenes();
        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();

        public Frm_LibroOrdenes()
        {
            InitializeComponent();

            this.TSB_Primero.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Anterior.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Siguiente.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Ultimo.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.ts_Sep1.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.Asigna_Nombres(null, null);
        }

        private void Frm_LibroOrdenes_Load(object sender, EventArgs e)
        {
            BS_LLibroOrdenes.DataSource = NL_LibroOrdenes.Listar();
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_MTipoOrdenes.DataSource = NM_TipoOrdenes.Listar();
            BS_MTitulos.DataSource = NM_Titulos.Listar();

            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            this.Construye_ListaLibroOrdenes();
            this.Modo_Consulta();
        }
        //************
        // Comportamiento de Los Botones 
        //************
        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_LLibroOrdenes.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }
        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_LLibroOrdenes.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }
        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_LLibroOrdenes.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }
        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_LLibroOrdenes.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }
        private void KeyPress_JF(object sender, KeyEventArgs e)
        {
            // Activar el KeyPreview = true en el formulario

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
            vl_EsNuevo = true;
            BS_LLibroOrdenes.AddNew();
            this.Modo_Edicion();
            this.Opc_Status1.Checked = true;
            this.Opc_Validez1.Checked = true;
            this.Dtp_FecOrden.Value = DateTime.Now;
            this.Txt_OrdenHora.Refresh();
        }
        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            if (BS_LLibroOrdenes.Current == null)
                return;
            vl_EsNuevo = false;
            this.Modo_Edicion();
        }
        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = r_LibroOrdenes.Secuencia.ToString();
            DialogResult vl_Resp = MessageBox.Show(Funciones._Mens_Idioma(15900) + "\n\n" + vl_RegEliminar,
                Funciones._Mens_Idioma(201), MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Abort)
                r_LibroOrdenes.Status = 3;  // Anulada
            if (vl_Resp == DialogResult.Retry)
                r_LibroOrdenes.Status = 4;  // Cancelada

            //NL_LibroOrdenes.Elimiar(r_LibroOrdenes);
            NL_LibroOrdenes.Actualizar(r_LibroOrdenes);
            BS_LLibroOrdenes.DataSource = NL_LibroOrdenes.Listar();
            Grd_LibroOrdenes.Refresh();

            //MessageBox.Show(Funciones._Mens_Idioma(9011), Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TSB_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            r_LibroOrdenes.Status = (byte)( this.Opc_Status2.Checked ? 2 :
                                                this.Opc_Status3.Checked ? 3 :
                                                    this.Opc_Status4.Checked ? 4 : 1);
            r_LibroOrdenes.Orden_Validez = (byte)(this.Opc_Validez2.Checked ? 2 : 1);
            r_LibroOrdenes.Cliente_Cod = Cmb_Cliente.SelectedValue.ToString();
            r_LibroOrdenes.Titulo_Cod = Cmb_Titulo.SelectedValue.ToString();

            if (vl_EsNuevo)
                NL_LibroOrdenes.Insertar(r_LibroOrdenes);
            else
                NL_LibroOrdenes.Actualizar(r_LibroOrdenes);
            this.Modo_Consulta();
            BS_LLibroOrdenes.DataSource = NL_LibroOrdenes.Listar();

        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            BS_LLibroOrdenes.CancelEdit();
            r_LibroOrdenes = BS_LLibroOrdenes.Current as L_LibroOrdenes;
            this.Modo_Consulta();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = Funciones._Mens_Idioma(15000);

            this.Pag1.Text = Funciones._Mens_Idioma(7103);
                this.Lbl_Secuencia.Text = Funciones._Mens_Idioma(15001);
                this.Col_Secuencia.HeaderText = Funciones._Mens_Idioma(15001);
                this.Col_Cliente.HeaderText = Funciones._Mens_Idioma(15003);
                this.Col_Fecha.HeaderText = Funciones._Mens_Idioma(15002);
                this.Col_Titulo.HeaderText = Funciones._Mens_Idioma(15004);

            this.Lbl_StatusP1.Text = Funciones._Mens_Idioma(1032);
                    this.Opc_Status1.Text = Funciones._Mens_Idioma(15021);
                    this.Opc_Status2.Text = Funciones._Mens_Idioma(15022);
                    this.Opc_Status3.Text = Funciones._Mens_Idioma(15023);
                    this.Opc_Status4.Text = Funciones._Mens_Idioma(15024);
                this.Lbl_FecOrden.Text = Funciones._Mens_Idioma(15002);
                this.Lbl_TipoOrden.Text = Funciones._Mens_Idioma(10033);
                this.Lbl_Cliente.Text = Funciones._Mens_Idioma(15003);
                this.Lbl_Titulo.Text = Funciones._Mens_Idioma(15004);
                this.Lbl_Precio.Text = Funciones._Mens_Idioma(15005);
                this.Lbl_Validez.Text = Funciones._Mens_Idioma(15006);
                    this.Opc_Validez1.Text = Funciones._Mens_Idioma(15025);
                    this.Opc_Validez2.Text = Funciones._Mens_Idioma(15026);
                this.Lbl_Nominal.Text = Funciones._Mens_Idioma(15007);
                this.Lbl_ValorEfectivo.Text = Funciones._Mens_Idioma(15008);
                this.Lbl_Cuenta.Text = Funciones._Mens_Idioma(15009);
                this.Lbl_AprobadoPor.Text = Funciones._Mens_Idioma(15010);
                this.Lbl_PactoFecha.Text = Funciones._Mens_Idioma(10034);
                this.Lbl_Fechavalor.Text = Funciones._Mens_Idioma(10036);
                this.Lbl_PactoNominal.Text = Funciones._Mens_Idioma(15011);
                this.Lbl_PactoPrecio.Text = Funciones._Mens_Idioma(15005);
                this.Lbl_PactoValor.Text = Funciones._Mens_Idioma(15008);
                this.Lbl_EjecutadaPor.Text = Funciones._Mens_Idioma(15012);

            this.Pag2.Text = Funciones._Mens_Idioma(1031);
                this.Lbl_StatusP2.Text = Funciones._Mens_Idioma(1032);
                    this.Opc_Filtro1.Text = Funciones._Mens_Idioma(1034);
                    this.Opc_Filtro2.Text = Funciones._Mens_Idioma(15021);
                    this.Opc_Filtro3.Text = Funciones._Mens_Idioma(15022);
                    this.Opc_Filtro4.Text = Funciones._Mens_Idioma(15023);
                    this.Opc_Filtro5.Text = Funciones._Mens_Idioma(15024);

            this.Lbl_FDesde.Text = Funciones._Mens_Idioma(1013);
                this.Lbl_FHasta.Text = Funciones._Mens_Idioma(1014);

            this.TSB_Primero.Text = Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = Funciones._Mens_Idioma(140);

            Funciones.TTT_Btn(Btn_Aceptar, Funciones._Mens_Idioma(141));
            Funciones.TTT_Btn(Btn_Cancelar, Funciones._Mens_Idioma(142));
            Funciones.TTT_Btn(Btn_Filtrar, Funciones._Mens_Idioma(1033));
            Funciones.TTT_Btn(Btn_Importar, Funciones._Mens_Idioma(1021));
            Funciones.TTT_Btn(Btn_Exportar, Funciones._Mens_Idioma(1025));

        }

        private void Modo_Consulta()
        {
            this.Pan_Orden.Enabled = false;
            this.Pan_Aprobado.Enabled = false;
            this.Pan_Pactado.Enabled = false;

            this.Grd_LibroOrdenes.Enabled = true;
            this.Pan_Pag2.Enabled = true;

            this.Txt_ClienteNme.Visible = true;
            this.Txt_TituloDesc.Visible = true;


            this.TS_BarraHerramientas.Enabled = true;
            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {

            this.Grd_LibroOrdenes.Enabled = false;
            this.Pan_Pag2.Enabled = false;

            this.Pan_Orden.Enabled = Txt_Aprobadopor.Text.Trim() == ""? true : false;
            this.Txt_ClienteNme.Visible = !this.Pan_Orden.Enabled;
            this.Txt_TituloDesc.Visible = !this.Pan_Orden.Enabled;

            this.Pan_Aprobado.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.LibOper_A == null ? false : (bool)r_GrupoOpciones.LibOper_A;
            this.Pan_Pactado.Enabled = Txt_Aprobadopor.Text.Trim() == "" ? false : true;

            this.TS_BarraHerramientas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;

            this.Txt_Secuencia.Focus();
        }

        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_LLibroOrdenes.Count < 1)
            {
                this.TSB_Primero.Enabled = false;
                this.TSB_Anterior.Enabled = false;
                this.TSB_Siguiente.Enabled = false;
                this.TSB_Ultimo.Enabled = false;
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.LibOper_I == null ? false : (bool)r_GrupoOpciones.LibOper_I;
                this.TSB_Modificar.Enabled = false;
                this.TSB_Eliminar.Enabled = false;
                this.TSB_Imprimir.Enabled = false;
            }
            else
            {
                this.TSB_Primero.Enabled = (BS_LLibroOrdenes.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_LLibroOrdenes.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_LLibroOrdenes.Position == BS_LLibroOrdenes.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_LLibroOrdenes.Position == BS_LLibroOrdenes.Count - 1) ? false : true;
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.LibOper_I == null ? false : (bool)r_GrupoOpciones.LibOper_I;
                this.TSB_Modificar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.LibOper_M == null ? false : (bool)r_GrupoOpciones.LibOper_M;
                this.TSB_Eliminar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.LibOper_E == null ? false : (bool)r_GrupoOpciones.LibOper_E;
                this.TSB_Imprimir.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.LibOper_P == null ? false : (bool)r_GrupoOpciones.LibOper_P;
            }
        }

        public class ListaRepLibroOrdenes
        {
            public string Secuencia { get; set; }
            public string Status { get; set; }
            public DateTime Orden_Fecha { get; set; }
            public string Orden_Validez { get; set; }
            public string Orden_Tipo { get; set; }
            public string Titulo_Cod { get; set; }
            public string Titulo_Nme { get; set; }
            public string Titulo_ISIN { get; set; }
            public int Orden_Nominal { get; set; }
            public bool Orden_PrecMercado { get; set; }
            public decimal Orden_Precio { get; set; }
            public decimal Orden_ValorEfectivo { get; set; }
            public string Cuenta { get; set; }
            public string Cliente_Cod { get; set; }
            public string Cliente_Nme { get; set; }
            public string Cliente_Email { get; set; }
            public string Cliente_Status { get; set; }
            public string Cliente_Ejecutivo { get; set; }
            public string Aprobado_Por { get; set; }
            public DateTime Aprobado_Fecha { get; set; }
            public DateTime Pacto_Fecha { get; set; }
            public DateTime Pacto_FecValor { get; set; }
            public int Pacto_Nominal { get; set; }
            public decimal Pacto_Precio { get; set; }
            public decimal Pacto_Valor { get; set; }
            public string Ejecutada_Por { get; set; }
        }
        private void Construye_ListaLibroOrdenes()
        {

            L_LibroOrdenes r_LibroOrdenes = new L_LibroOrdenes();
            List<ListaRepLibroOrdenes> Lst_LibroOrdenes = new List<ListaRepLibroOrdenes>();

            int vl_regact = BS_LLibroOrdenes.Position;
            int vl_Filtro = this.Opc_Filtro2.Checked ? 1 :
                        this.Opc_Filtro3.Checked ? 2 :
                            this.Opc_Filtro4.Checked ? 3 :
                                this.Opc_Filtro5.Checked ? 4 : 5;

            BS_LLibroOrdenes.DataSource = NL_LibroOrdenes.ListarPorStatus(vl_Filtro, Dtp_FDesde.Value, Dtp_FHasta.Value);

            BS_LLibroOrdenes.MoveFirst();
            foreach(object Registro in BS_LLibroOrdenes)
            {
                r_LibroOrdenes = BS_LLibroOrdenes.Current as L_LibroOrdenes;
                if (vl_Filtro == 5 | r_LibroOrdenes.Status == vl_Filtro)
                {
                    Lst_LibroOrdenes.Add(new ListaRepLibroOrdenes()
                    {
                        Secuencia = r_LibroOrdenes.Secuencia.ToString(),
                        Status = r_LibroOrdenes.Status != null ? Funciones._Mens_Idioma((int)r_LibroOrdenes.Status + 15020) : Funciones._Mens_Idioma(15020),
                        Orden_Fecha = r_LibroOrdenes.Orden_Fecha != null ? (DateTime)r_LibroOrdenes.Orden_Fecha : DateTime.Now,
                        Orden_Tipo = NM_TipoOrdenes.ListarPorCodigo(r_LibroOrdenes.Orden_Tipo).First().Descripcion,
                        Orden_Validez = r_LibroOrdenes.Orden_Validez != null ? Funciones._Mens_Idioma(r_LibroOrdenes.Orden_Validez == 2 ? 15026 : 15025) : "???" ,
                        Titulo_Cod = r_LibroOrdenes.Titulo_Cod,
                        Titulo_Nme = NM_Titulos.ListarPorCodigo(r_LibroOrdenes.Titulo_Cod).First().Descripcion,
                        Titulo_ISIN = NM_Titulos.ListarPorCodigo(r_LibroOrdenes.Titulo_Cod).First().ISIN,
                        Orden_Nominal = (int)r_LibroOrdenes.Orden_Nominal,
                        Orden_PrecMercado = r_LibroOrdenes.Orden_PrecMercado != null ? (bool)r_LibroOrdenes.Orden_PrecMercado : false,
                        Orden_Precio = r_LibroOrdenes.Orden_Precio != null ? (decimal)r_LibroOrdenes.Orden_Precio : 0,
                        Orden_ValorEfectivo = r_LibroOrdenes.Orden_ValorEfectivo != null ? (decimal)r_LibroOrdenes.Orden_ValorEfectivo : 0,
                        Cuenta = r_LibroOrdenes.Cuenta,
                        Cliente_Cod = r_LibroOrdenes.Cliente_Cod,
                        Cliente_Nme = NC_Clientes.ListarPorCliente(r_LibroOrdenes.Cliente_Cod).First().Nombre,
                        Cliente_Email = NC_Clientes.ListarPorCliente(r_LibroOrdenes.Cliente_Cod).First().IG_Email,
                        Cliente_Ejecutivo = NC_Clientes.ListarPorCliente(r_LibroOrdenes.Cliente_Cod).First().Ejecutivo,
                        Cliente_Status = Funciones._Mens_Idioma(NC_Clientes.ListarPorCliente(r_LibroOrdenes.Cliente_Cod).First().Activo == true ?  126 : 127),
                        Aprobado_Por = r_LibroOrdenes.Aprob_Por,
                        Aprobado_Fecha = r_LibroOrdenes.Aprob_Fecha != null ? (DateTime)r_LibroOrdenes.Aprob_Fecha : DateTime.Now,
                        Pacto_Fecha = r_LibroOrdenes.Pacto_Fecha != null ? (DateTime)r_LibroOrdenes.Pacto_Fecha : DateTime.Now,
                        Pacto_FecValor = r_LibroOrdenes.Pacto_FecValor != null ? (DateTime)r_LibroOrdenes.Pacto_FecValor : DateTime.Now,
                        Pacto_Nominal = r_LibroOrdenes.Pacto_Nominal != null ? (int)r_LibroOrdenes.Pacto_Nominal : 0,
                        Pacto_Precio = r_LibroOrdenes.Pacto_Precio != null ? (decimal)r_LibroOrdenes.Pacto_Precio.Value : 0,
                        Pacto_Valor = r_LibroOrdenes.Pacto_Valor != null ? (decimal)r_LibroOrdenes.Pacto_Valor : 0,
                        Ejecutada_Por = r_LibroOrdenes.Ejecutada_Por
                    });
                }
                BS_LLibroOrdenes.MoveNext();
            }
            BS_LLibroOrdenes.DataSource = NL_LibroOrdenes.Listar();
            BS_LLibroOrdenes.Position = vl_regact;
            Grd_LibroCompuesto.DataSource = Lst_LibroOrdenes;
        }

        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
            Funciones.Exportar_Excel(Grd_LibroCompuesto);
        }

        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            this.Construye_ListaLibroOrdenes();
        }

        private void Grd_LibroOrdenes_CurrentCellChanged(object sender, EventArgs e)
        {
            r_LibroOrdenes = BS_LLibroOrdenes.Current as L_LibroOrdenes;

            this.Opc_Status1.Checked = r_LibroOrdenes.Status == 1 ? true : false;
            this.Opc_Status2.Checked = r_LibroOrdenes.Status == 2 ? true : false;
            this.Opc_Status3.Checked = r_LibroOrdenes.Status == 3 ? true : false;
            this.Opc_Status4.Checked = r_LibroOrdenes.Status == 4 ? true : false;

            this.Opc_Validez1.Checked = r_LibroOrdenes.Orden_Validez == 1 ? true : false;
            this.Opc_Validez2.Checked = r_LibroOrdenes.Orden_Validez == 2 ? true : false;

            this.TSB_ActualizaBotonesNavegacion();

            this.Txt_ClienteNme.Text = NC_Clientes.ListarPorCliente(r_LibroOrdenes.Cliente_Cod).Count > 0 ? NC_Clientes.ListarPorCliente(r_LibroOrdenes.Cliente_Cod).First().Nombre : "";
            this.Txt_TituloDesc.Text = NM_Titulos.ListarPorCodigo(r_LibroOrdenes.Titulo_Cod).Count > 0 ? NM_Titulos.ListarPorCodigo(r_LibroOrdenes.Titulo_Cod).First().Descripcion : "";
            
        }

        private void Chk_PrecMercado_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_OrdenPrecio.Enabled = this.Chk_PrecMercado.Checked ? false : true;
        }

        private void Txt_ValorEfectivo_Enter(object sender, EventArgs e)
        {
            if (this.Txt_OrdenPrecio.Text != "" & this.Txt_OrdenNominal.Text != "")
                this.Txt_OrdenValor.Text = (decimal.Parse(this.Txt_OrdenPrecio.Text) * decimal.Parse(this.Txt_OrdenNominal.Text)).ToString();
        }

        private void pacto_ValorTextBox_Enter(object sender, EventArgs e)
        {
            if (this.Txt_PactoNomina.Text != "" & this.Txt_PactoPrecio.Text != "")
                this.Txt_PactoValor.Text = (decimal.Parse(this.Txt_PactoNomina.Text) * decimal.Parse(this.Txt_PactoPrecio.Text)).ToString();

        }
    }
}
