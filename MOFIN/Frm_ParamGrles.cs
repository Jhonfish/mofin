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
using MofinDatos;
using MofinModeloEntorno;
using MofinNegocios;
using MOFIN_LIB;

namespace MOFIN
{
    public partial class Frm_ParamGrles : MetroForm
    {
        Opc_Sistema r_OpcSistema = new Opc_Sistema();
        public Frm_ParamGrles()
        {
            InitializeComponent();
            BS_OpcSistema.DataSource = NOpc_Sistema.Listar();
        }
        private void Frm_ParamGrles_Load(object sender, EventArgs e)
        {
            r_OpcSistema = BS_OpcSistema.Current as Opc_Sistema;
            this.Opc_Idioma2.Checked = r_OpcSistema.IdiomaPredeterminado == 2 ? true : false;
            this.Opc_Idioma1.Checked = !this.Opc_Idioma2.Checked;

            this.Opc_Desktop2.Checked = r_OpcSistema.FondoEscritorio == 2 ? true : false;
            this.Opc_Desktop1.Checked = !this.Opc_Desktop2.Checked;

            this.Opc_Pais2.Checked = r_OpcSistema.PaisUso == 2 ? true : false;
            this.Opc_Pais1.Checked = !this.Opc_Pais2.Checked;

            this.Opc_FormFec2.Checked = r_OpcSistema.FormFecha == 2 ? true : false;
            this.Opc_FormFec1.Checked = !this.Opc_FormFec2.Checked;

            this.Opc_FormPuntoDec2.Checked = r_OpcSistema.FormPuntodecimal == 2 ? true : false ;
            this.Opc_FormPuntoDec1.Checked = !this.Opc_FormPuntoDec2.Checked;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            NOpc_Sistema.Actualizar(r_OpcSistema);
            this.Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Opc_Idioma1_CheckedChanged(object sender, EventArgs e)
        {
            r_OpcSistema.IdiomaPredeterminado = this.Opc_Idioma1.Checked ? (byte)1 : (byte)2;
        }

        private void Opc_Desktop1_CheckedChanged(object sender, EventArgs e)
        {
            r_OpcSistema.FondoEscritorio = this.Opc_Idioma1.Checked ? (byte)1 : (byte)2;
        }

        private void Opc_Pais1_CheckedChanged(object sender, EventArgs e)
        {
            r_OpcSistema.PaisUso = this.Opc_Pais1.Checked ? (byte)1 : (byte)2;

        }

        private void Opc_FormFec1_CheckedChanged(object sender, EventArgs e)
        {
            r_OpcSistema.FormFecha = this.Opc_FormFec1.Checked ? (byte)1 : (byte)2;

        }

        private void Opc_FormPuntoDec1_CheckedChanged(object sender, EventArgs e)
        {
            r_OpcSistema.FormPuntodecimal = this.Opc_FormPuntoDec1.Checked ? (byte)1 : (byte)2;

        }
    }
}
