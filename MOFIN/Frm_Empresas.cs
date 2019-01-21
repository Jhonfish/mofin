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
    public partial class Frm_Empresas: MetroForm
    {
        bool vl_EsNuevo = true;
        Empresas t_Empresas = new Empresas();

        public Frm_Empresas()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            BS_Empresas.DataSource = NEmpresas.Listar();
            this.Modo_Consulta();
            this.Grd_Empresas.Focus();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Empresas_CurrentCellChanged(object sender, EventArgs e)
        {
            t_Empresas = BS_Empresas.Current as Empresas;
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Consulta()
        {
            this.Pan_Elementos.Enabled = false;
            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Empresas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_Elementos.Enabled = true;
            this.Txt_Codigo.Enabled = vl_EsNuevo;
            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Empresas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }

        //************
        // Comportamiento de Los Botones 
        //************
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_Empresas.Count < 1)
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
                this.TSB_Primero.Enabled = (BS_Empresas.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_Empresas.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_Empresas.Position == BS_Empresas.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_Empresas.Position == BS_Empresas.Count - 1) ? false : true;
                this.TSB_Modificar.Enabled = true;
                this.TSB_Eliminar.Enabled = true;
                this.TSB_Imprimir.Enabled = true;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (vl_EsNuevo)
                //NEmpresas.Insertar(t_Empresas);
                NEmpresas.Insertar(BS_Empresas.Current as Empresas);
            else
                //NEmpresas.Actualizar(t_Empresas);
                NEmpresas.Actualizar(BS_Empresas.Current as Empresas);
            this.Modo_Consulta();
            BS_Empresas.DataSource = NEmpresas.Listar();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();   
        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            BS_Empresas.AddNew();
            //BS_Empresas.Add(t_Empresas);
            BS_Empresas.MoveLast();
            this.Modo_Edicion();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            if (BS_Empresas.Current == null)
                return;
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_Nombre.Focus();
        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
           string vl_RegEliminar = t_Empresas.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010)+ "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NEmpresas.Elimiar(BS_Empresas.Current as Empresas);
                BS_Empresas.DataSource = NEmpresas.Listar();
                //Grd_Empresas.Refresh();
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_Empresas.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_Empresas.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_Empresas.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_Empresas.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }

        private void Grd_Empresas_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (Grd_Empresas.CurrentRow != null)
            {
                TSB_ActualizaBotonesNavegacion();
            }
        }
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(2100);
            this.Lbl_Codigo.Text = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Lbl_Nombre.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_Direccion.Text = MOFIN_LIB.Funciones._Mens_Idioma(1009);
            this.Lbl_DocID.Text = MOFIN_LIB.Funciones._Mens_Idioma(1004);
            this.Lbl_Siglas.Text = MOFIN_LIB.Funciones._Mens_Idioma(2001);
            this.Lbl_Email.Text= MOFIN_LIB.Funciones._Mens_Idioma(1010);
            this.Lbl_Telefono1.Text= MOFIN_LIB.Funciones._Mens_Idioma(1011) + "1";
            this.Lbl_Telefono2.Text = MOFIN_LIB.Funciones._Mens_Idioma(1011) + "2";
            this.Lbl_Logo.Text= MOFIN_LIB.Funciones._Mens_Idioma(2002);

            this.TSB_Primero.Text = MOFIN_LIB.Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = MOFIN_LIB.Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = MOFIN_LIB.Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = MOFIN_LIB.Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = MOFIN_LIB.Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = MOFIN_LIB.Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = MOFIN_LIB.Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = MOFIN_LIB.Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = MOFIN_LIB.Funciones._Mens_Idioma(140);

            this.Col_Codigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Col_Siglas.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(2001);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }

        private void Txt_Logo_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog vl_ArchivoImport = new OpenFileDialog();
            string vl_Tipoarchivo = "*.JPG|*.JPG |*.BMP|*.BMP |*.PNG|*.PNG|*.*|*.*";
            vl_ArchivoImport.Filter = vl_Tipoarchivo;
            // vl_ArchivoImport.CheckFileExists = false;
            if (vl_ArchivoImport.ShowDialog() == DialogResult.OK)
                this.Txt_Logo.Text= vl_ArchivoImport.FileName;
        }
    }
}
    