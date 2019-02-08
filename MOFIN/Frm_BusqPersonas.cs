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
    public partial class Frm_BusqPersonas : MetroForm
    {
        B_Buscados r_Buscados = new B_Buscados();
        C_Clientes r_Clientes = new C_Clientes();
        C_FirBenAcc r_FirBenAcc = new C_FirBenAcc();

        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();
        
        public Frm_BusqPersonas()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_BusqPersonas_Load(object sender, EventArgs e)
        {
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.Listar();
            BS_BBuscados.DataSource = NB_Buscados.Listar();
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;
        }

        private void Opc_CritBus3_CheckedChanged(object sender, EventArgs e)
        {
            this.Grp_DocId.Visible = this.Opc_CritBus3.Checked;
        }
        private void Btn_MostrarTodos_Click(object sender, EventArgs e)
        {
            BS_CClientes.DataSource = NC_Clientes.Listar();
            BS_CFirBenAcc.DataSource = NC_FirBenAcc.Listar();
            BS_BBuscados.DataSource = NB_Buscados.Listar();
            BS_CClientes.MoveFirst();
            BS_CFirBenAcc.MoveFirst();
            BS_BBuscados.MoveFirst();
        }

        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(12000);
            this.Lbl_DocID.Text = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Lbl_Nombre.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_CritBusq.Text = MOFIN_LIB.Funciones._Mens_Idioma(12001);
            this.Lbl_ListBuscados.Text = MOFIN_LIB.Funciones._Mens_Idioma(12006);
            this.Lbl_Listclientes.Text = MOFIN_LIB.Funciones._Mens_Idioma(12007);
            this.Lbl_ListFirBenAcc.Text = MOFIN_LIB.Funciones._Mens_Idioma(12008);
            this.Opc_CritBus1.Text = MOFIN_LIB.Funciones._Mens_Idioma(12002);
            this.Opc_CritBus2.Text = MOFIN_LIB.Funciones._Mens_Idioma(12003);
            this.Opc_CritBus3.Text = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Opc_DocID1.Text = MOFIN_LIB.Funciones._Mens_Idioma(12005);
            this.Opc_DocID2.Text = MOFIN_LIB.Funciones._Mens_Idioma(12004);

            this.Col_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_DocID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Col_EnteBusca.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(12009);
            this.Col_FecBusqueda.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(12010);
            this.Col_FecRegistro.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(12011);
            this.Col_PaisBusca.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(12012);

            this.Col_CliCodigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_CliNombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_CliDocID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);

            this.Col_FBACodigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_FBANombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_FBADocID.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1004);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Buscar1, MOFIN_LIB.Funciones._Mens_Idioma(144));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_BuscarTodos, MOFIN_LIB.Funciones._Mens_Idioma(145));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_MostrarTodos, MOFIN_LIB.Funciones._Mens_Idioma(143));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Imprimir, MOFIN_LIB.Funciones._Mens_Idioma(139));
        }
        public class ListaBuscados
        {
            public string Nombre { get; set; }
            public string Doc_ID { get; set; }
            public string Ente_Busca { get; set; }
            public DateTime Fec_Busqueda { get; set; }
            public DateTime Fec_Registro { get; set; }
            public string pais_Busca { get; set; }
        }
        public class ListaClientes
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Doc_ID { get; set; }
        }
        public class ListaFirBenAcc
        {
            public string Cod_Cliente { get; set; }
            public string Nombre { get; set; }
            public string Doc_ID { get; set; }
        }
        public class ListaBuscaTodos
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Doc_ID { get; set; }
            public string Ente_Busca { get; set; }
            public DateTime Fec_Busqueda { get; set; }
            public DateTime Fec_Registro { get; set; }
            public string pais_Busca { get; set; }
        }
        private void Btn_Buscar1_Click(object sender, EventArgs e)
        {

            this.Btn_MostrarTodos_Click(null, null);
            int vl_opcBusqueda = this.Opc_CritBus1.Checked ? 1 : this.Opc_CritBus2.Checked ? 2 : 3;
            string vl_Nombre = this.Txt_Nombre.Text.ToUpper().Trim();
            List<string> Lst_Nombres = this.Txt_Nombre.Text.ToUpper().Trim().Split(' ').ToList();

            for (int i = 0; i < Lst_Nombres.Count; i++)
            {
                if (Lst_Nombres[i].Length <= 0)
                {
                    Lst_Nombres.RemoveAt(i);
                    i = 0;
                }
            }
            if(Lst_Nombres.Count<6)
            {
                for (int i = Lst_Nombres.Count; i < 6; i++)
                    Lst_Nombres.Add("");

            }

            List<ListaBuscados> Lst_Buscados = new List<ListaBuscados>();
            List<ListaClientes> Lst_Clientes = new List<ListaClientes>();
            List<ListaFirBenAcc> Lst_FirBenAcc = new List<ListaFirBenAcc>();

            switch (vl_opcBusqueda)
            {
                case 1:     // Todas las Palabras del Nombre

                    /// Busqueda en tabla de Buscados 
                    BS_BBuscados.MoveFirst();
                    foreach (object Registro in BS_BBuscados)
                    {
                        r_Buscados = BS_BBuscados.Current as B_Buscados;
                        if (r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true &
                                r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true &
                                    r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true &
                                        r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true &
                                            r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true &
                                                r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true) 
                        {
                            Lst_Buscados.Add(new ListaBuscados()
                            {
                                Nombre = r_Buscados.Nombre,
                                Doc_ID = r_Buscados.Doc_ID,
                                Ente_Busca = r_Buscados.Ente_Busca,
                                Fec_Busqueda = (DateTime)r_Buscados.Fec_Busqueda,
                                Fec_Registro = (DateTime)r_Buscados.Fec_Registro,
                                pais_Busca = r_Buscados.Pais_Busca
                            });
                        }
                        BS_BBuscados.MoveNext();
                    }

                    /// Busqueda en tabla de Clientes
                    BS_CClientes.MoveFirst();
                    foreach (object Registro in BS_CClientes)
                    {
                        r_Clientes = BS_CClientes.Current as C_Clientes;
                        if (r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true &
                                r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true &
                                    r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true &
                                        r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true &
                                            r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true &
                                                r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true)
                    {
                        Lst_Clientes.Add(new ListaClientes()
                            {
                                Codigo = r_Clientes.Codigo,
                                Nombre = r_Clientes.Nombre,
                                Doc_ID = r_Clientes.Doc_ID,
                            });
                        }
                        BS_CClientes.MoveNext();
                    }

                    /// Busqueda en tabla de Firmantes, Beneficiarios y Accionistas
                    BS_CFirBenAcc.MoveFirst();
                    foreach (object Registro in BS_CFirBenAcc)
                    {
                        r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                        if (r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true &
                                r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true &
                                    r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true &
                                        r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true &
                                            r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true &
                                                r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true)
                        {
                            Lst_FirBenAcc.Add(new ListaFirBenAcc()
                            {
                                Cod_Cliente = r_FirBenAcc.Cod_Cliente,
                                Nombre = r_FirBenAcc.Nombre,
                                Doc_ID = r_FirBenAcc.Doc_ID,
                            });
                        }
                        BS_CFirBenAcc.MoveNext();
                    }
                    break;

                case 2:         // Cualquier palabra el Nombre
                                /// Busqueda en tabla de Buscados 
                    BS_BBuscados.MoveFirst();
                    foreach (object Registro in BS_BBuscados)
                    {
                        r_Buscados = BS_BBuscados.Current as B_Buscados;
                        if (r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true |
                                (Lst_Nombres[1] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true : false) |
                                    (Lst_Nombres[2] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true : false) |
                                        (Lst_Nombres[3] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true : false) |
                                            (Lst_Nombres[4] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true : false) |
                                                (Lst_Nombres[5] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true : false) )

                        {
                            Lst_Buscados.Add(new ListaBuscados()
                            {
                                Nombre = r_Buscados.Nombre,
                                Doc_ID = r_Buscados.Doc_ID,
                                Ente_Busca = r_Buscados.Ente_Busca,
                                Fec_Busqueda = (DateTime)r_Buscados.Fec_Busqueda,
                                Fec_Registro = (DateTime)r_Buscados.Fec_Registro,
                                pais_Busca = r_Buscados.Pais_Busca
                            });
                        }
                        BS_BBuscados.MoveNext();
                    }

                    /// Busqueda en tabla de Clientes
                    BS_CClientes.MoveFirst();
                    foreach (object Registro in BS_CClientes)
                    {
                        r_Clientes = BS_CClientes.Current as C_Clientes;
                        if (r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true |
                                (Lst_Nombres[1] != "" ? r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true : false) |
                                    (Lst_Nombres[2] != "" ? r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true : false) |
                                        (Lst_Nombres[3] != "" ? r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true : false) |
                                            (Lst_Nombres[4] != "" ? r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true : false) |
                                                (Lst_Nombres[5] != "" ? r_Clientes.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true : false))
                        {
                            Lst_Clientes.Add(new ListaClientes()
                            {
                                Codigo = r_Clientes.Codigo,
                                Nombre = r_Clientes.Nombre,
                                Doc_ID = r_Clientes.Doc_ID,
                            });
                        }
                        BS_CClientes.MoveNext();
                    }

                    /// Busqueda en tabla de Firmantes, Beneficiarios y Accionistas
                    BS_CFirBenAcc.MoveFirst();
                    foreach (object Registro in BS_CFirBenAcc)
                    {
                        r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                        if (r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true |
                                (Lst_Nombres[1] != "" ? r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true : false) |
                                    (Lst_Nombres[2] != "" ? r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true : false) |
                                        (Lst_Nombres[3] != "" ? r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true : false) |
                                            (Lst_Nombres[4] != "" ? r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true : false) |
                                                (Lst_Nombres[5] != "" ? r_FirBenAcc.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true : false))
                        {
                            Lst_FirBenAcc.Add(new ListaFirBenAcc()
                            {
                                Cod_Cliente = r_FirBenAcc.Cod_Cliente,
                                Nombre = r_FirBenAcc.Nombre,
                                Doc_ID = r_FirBenAcc.Doc_ID,
                            });
                        }
                        BS_CFirBenAcc.MoveNext();
                    }
                    break;

                case 3:         // Documento de Identidad

                    if (this.Txt_DocID.Text.Length >= 3)
                    {
                        int vl_NumCars = 0;
                        if (this.Opc_DocID1.Checked == true)
                            vl_NumCars = this.Nud_NroCar.Value > this.Txt_DocID.Text.ToUpper().Trim().Length ? this.Txt_DocID.Text.ToUpper().Trim().Length : (int)this.Nud_NroCar.Value;
                        else
                            vl_NumCars = this.Txt_DocID.Text.ToUpper().Trim().Length;

                        string vl_DocID = this.Txt_DocID.Text.ToUpper().Trim().Substring((int)(this.Txt_DocID.Text.ToUpper().Trim().Length - vl_NumCars));

                        /// Busqueda en tabla de Buscados 
                        BS_BBuscados.MoveFirst();
                        foreach (object Registro in BS_BBuscados)
                        {
                            r_Buscados = BS_BBuscados.Current as B_Buscados;
                            if (r_Buscados.Doc_ID.ToUpper().Contains(vl_DocID) == true)
                            {
                                Lst_Buscados.Add(new ListaBuscados()
                                {
                                    Nombre = r_Buscados.Nombre,
                                    Doc_ID = r_Buscados.Doc_ID,
                                    Ente_Busca = r_Buscados.Ente_Busca,
                                    Fec_Busqueda = (DateTime)r_Buscados.Fec_Busqueda,
                                    Fec_Registro = (DateTime)r_Buscados.Fec_Registro,
                                    pais_Busca = r_Buscados.Pais_Busca
                                });
                            }
                            BS_BBuscados.MoveNext();
                        }

                        /// Busqueda en tabla de Clientes
                        BS_CClientes.MoveFirst();
                        foreach (object Registro in BS_CClientes)
                        {
                            r_Clientes = BS_CClientes.Current as C_Clientes;
                            if (r_Clientes.Doc_ID.ToUpper().Contains(vl_DocID) == true)
                            {
                                Lst_Clientes.Add(new ListaClientes()
                                {
                                    Codigo = r_Clientes.Codigo,
                                    Nombre = r_Clientes.Nombre,
                                    Doc_ID = r_Clientes.Doc_ID,
                                });
                            }
                            BS_CClientes.MoveNext();
                        }

                        /// Busqueda en tabla de Firmantes, Beneficiarios y Accionistas
                        BS_CFirBenAcc.MoveFirst();
                        foreach (object Registro in BS_CFirBenAcc)
                        {
                            r_FirBenAcc = BS_CFirBenAcc.Current as C_FirBenAcc;
                            if (r_FirBenAcc.Doc_ID.ToUpper().Contains(vl_DocID) == true)
                            {
                                Lst_FirBenAcc.Add(new ListaFirBenAcc()
                                {
                                    Cod_Cliente = r_FirBenAcc.Cod_Cliente,
                                    Nombre = r_FirBenAcc.Nombre,
                                    Doc_ID = r_FirBenAcc.Doc_ID,
                                });
                            }
                            BS_CFirBenAcc.MoveNext();
                        }
                    }
                    break;
            }
            BS_BBuscados.DataSource = Lst_Buscados.ToList();
            BS_CClientes.DataSource = Lst_Clientes.ToList();
            BS_CFirBenAcc.DataSource = Lst_FirBenAcc.ToList();
            BS_BBuscados.MoveFirst();
            BS_CClientes.MoveFirst();
            BS_CFirBenAcc.MoveFirst();
                       
        }


        private void Btn_BuscarTodos_Click(object sender, EventArgs e)
        {
            this.Btn_MostrarTodos_Click(null, null);

            List<ListaBuscaTodos> Lst_BuscaTodos = new List<ListaBuscaTodos>();
            int vl_opcBusqueda = this.Opc_CritBus1.Checked ? 1 : this.Opc_CritBus2.Checked ? 2 : 3;

            BS_CClientes.DataSource = NC_Clientes.Listar();
            int vl_cuantosson = BS_CClientes.Count;
            BS_CClientes.MoveFirst();
            foreach(object registro in BS_CClientes)
            {
                r_Clientes = BS_CClientes.Current as C_Clientes;
                int vl_regactual = BS_CClientes.Position+1;

                this.Lbl_Proceso.Text = vl_regactual.ToString()+"/" + vl_cuantosson + " "+ r_Clientes.Nombre+"...";
//                this.Lbl_Proceso.ForeColor = System.Drawing.ColorTranslator.FromOle(0);
                this.Lbl_Proceso.Refresh();

                string vl_Nombre = r_Clientes.Nombre.ToUpper().Trim();
                List<string> Lst_Nombres = vl_Nombre.ToUpper().Trim().Split(' ').ToList();

                for (int i = 0; i < Lst_Nombres.Count; i++)
                {
                    if (Lst_Nombres[i].Length <= 0)
                    {
                        Lst_Nombres.RemoveAt(i);
                        i = 0;
                    }
                }
                if (Lst_Nombres.Count < 6)
                {
                    for (int i = Lst_Nombres.Count; i < 6; i++)
                        Lst_Nombres.Add("");
                }

                switch (vl_opcBusqueda)
                {
                    case 1:     // Todas las Palabras del Nombre

                        /// Busqueda en tabla de Buscados 
                        BS_BBuscados.MoveFirst();
                        foreach (object Registro in BS_BBuscados)
                        {
                            r_Buscados = BS_BBuscados.Current as B_Buscados;
                            if (r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true &
                                    r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true &
                                        r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true &
                                            r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true &
                                                r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true &
                                                    r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true)
                            {
                                Lst_BuscaTodos.Add(new ListaBuscaTodos()
                                {
                                    Codigo = r_Clientes.Codigo,
                                    Nombre = r_Buscados.Nombre,
                                    Doc_ID = r_Buscados.Doc_ID,
                                    Ente_Busca = r_Buscados.Ente_Busca,
                                    Fec_Busqueda = (DateTime)r_Buscados.Fec_Busqueda,
                                    Fec_Registro = (DateTime)r_Buscados.Fec_Registro,
                                    pais_Busca = r_Buscados.Pais_Busca
                                });
                            }
                            BS_BBuscados.MoveNext();
                        }
                        break;

                    case 2: // Cualquier Palabra del Nombre

                        /// Busqueda en tabla de Buscados 
                        BS_BBuscados.MoveFirst();
                        foreach (object Registro in BS_BBuscados)
                        {
                            r_Buscados = BS_BBuscados.Current as B_Buscados;
                            if (r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[0]) == true |
                                    (Lst_Nombres[1] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[1]) == true : false) |
                                        (Lst_Nombres[2] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[2]) == true : false) |
                                            (Lst_Nombres[3] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[3]) == true : false) |
                                                (Lst_Nombres[4] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[4]) == true : false) |
                                                    (Lst_Nombres[5] != "" ? r_Buscados.Nombre.ToUpper().Contains(Lst_Nombres[5]) == true : false))
                            {
                                Lst_BuscaTodos.Add(new ListaBuscaTodos()
                                {
                                    Codigo = r_Clientes.Codigo,
                                    Nombre = r_Buscados.Nombre,
                                    Doc_ID = r_Buscados.Doc_ID,
                                    Ente_Busca = r_Buscados.Ente_Busca,
                                    Fec_Busqueda = (DateTime)r_Buscados.Fec_Busqueda,
                                    Fec_Registro = (DateTime)r_Buscados.Fec_Registro,
                                    pais_Busca = r_Buscados.Pais_Busca
                                });
                            }
                            BS_BBuscados.MoveNext();
                        }
                        break;

                    case 3:         // Documento de Identidad

                        string vl_Doc_ID = r_Clientes.Doc_ID.ToUpper().Trim();

                        if (vl_Doc_ID.Length >= 3)
                        {
                            int vl_NumCars = 0;
                            if (this.Opc_DocID1.Checked == true)
                                vl_NumCars = this.Nud_NroCar.Value > vl_Doc_ID.Length ? vl_Doc_ID.Length : (int)this.Nud_NroCar.Value;
                            else
                                vl_NumCars = vl_Doc_ID.Length;

                            string vl_DocID = vl_Doc_ID.Substring((int)(vl_Doc_ID.Length - vl_NumCars));

                            /// Busqueda en tabla de Buscados 
                            BS_BBuscados.MoveFirst();
                            foreach (object Registro in BS_BBuscados)
                            {
                                r_Buscados = BS_BBuscados.Current as B_Buscados;
                                if (r_Buscados.Doc_ID.ToUpper().Contains(vl_DocID) == true)
                                {
                                    Lst_BuscaTodos.Add(new ListaBuscaTodos()
                                    {
                                        Codigo = r_Clientes.Codigo,
                                        Nombre = r_Buscados.Nombre,
                                        Doc_ID = r_Buscados.Doc_ID,
                                        Ente_Busca = r_Buscados.Ente_Busca,
                                        Fec_Busqueda = (DateTime)r_Buscados.Fec_Busqueda,
                                        Fec_Registro = (DateTime)r_Buscados.Fec_Registro,
                                        pais_Busca = r_Buscados.Pais_Busca
                                    });
                                }
                                BS_BBuscados.MoveNext();
                            }
                        }
                        break;
                }

                BS_CClientes.MoveNext();
            }
            this.Grd_BuscaTodos.DataSource = Lst_BuscaTodos.ToList();

            this.Grd_BuscaTodos.Visible = true;
            this.Btn_Mostrar.Visible = true;
            this.Lbl_Proceso.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Btn_Mostrar.Visible = false;
            this.Grd_BuscaTodos.Visible = false;

        }
    }
 
}
