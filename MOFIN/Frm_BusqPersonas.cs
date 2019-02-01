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
    }
 
}
