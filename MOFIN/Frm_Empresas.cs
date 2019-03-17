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
using System.IO;


namespace MOFIN
{
    public partial class Frm_Empresas: MetroForm
    {
        bool vl_EsNuevo = true;
        Empresas r_Empresas = new Empresas();

        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();


        public Frm_Empresas()
        {
            InitializeComponent();

            this.TSB_Primero.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Anterior.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Siguiente.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Ultimo.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.ts_Sep1.Visible = Entorno.vs_CnfgBtnsNaveg;

            this.Asigna_Nombres(null, null);

        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            BS_Empresas.DataSource = NEmpresas.Listar();
            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;
            //this.Pic_Logo.InitialImage = null;

            this.Modo_Consulta();
            this.Grd_Empresas.Focus();
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Empresas_I == null ? false : (bool)r_GrupoOpciones.Empresas_I;
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Empresas_I == null ? false : (bool)r_GrupoOpciones.Empresas_I;
                this.TSB_Modificar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Empresas_M == null ? false : (bool)r_GrupoOpciones.Empresas_M;
                this.TSB_Eliminar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Empresas_E == null ? false : (bool)r_GrupoOpciones.Empresas_E;
                this.TSB_Imprimir.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Empresas_P == null ? false : (bool)r_GrupoOpciones.Empresas_P;
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

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            r_Empresas.Tipo_Valoracion = (byte)(Opc_MetVal1.Checked? 1 : 2);
            r_Empresas.NroDesktops = (byte)NUD_DsktpNr.Value;

            if (vl_EsNuevo)
                NEmpresas.Insertar(r_Empresas);
            else
                NEmpresas.Actualizar(r_Empresas);
            this.Modo_Consulta();
            BS_Empresas.DataSource = NEmpresas.Listar();
            MessageBox.Show(Funciones._Mens_Idioma(9019), Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            BS_Empresas.AddNew();
            r_Empresas =BS_Empresas.Current as Empresas;
            r_Empresas.NroDesktops = 0;
            r_Empresas.Tipo_Valoracion = 1;

            Opc_MetVal1.Checked = true;
            //BS_Empresas.Add(r_Empresas);

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
        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            string vl_RegEliminar = r_Empresas.Nombre.ToString();
            DialogResult vl_Resp = MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9010) + "\n\n" + vl_RegEliminar,
                MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                NEmpresas.Elimiar(BS_Empresas.Current as Empresas);
                BS_Empresas.DataSource = NEmpresas.Listar();
                //Grd_Empresas.Refresh();
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TSB_Imprimir_Click(object sender, EventArgs e)
        {

        }
        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Empresas_CurrentCellChanged(object sender, EventArgs e)
        {
            r_Empresas = BS_Empresas.Current as Empresas;
            if (r_Empresas.Logo != null)
                // this.Pic_Logo.Image = File.Exists(r_Empresas.Logo.Trim())? Image.FromFile(r_Empresas.Logo.ToString()) : "";
                if (File.Exists(r_Empresas.Logo))
                    this.Pic_Logo.Image = Image.FromFile(r_Empresas.Logo);
                else
                    this.Pic_Logo.Image = null ;
            else
                this.Pic_Logo.Image = null;

            Opc_MetVal1.Checked = r_Empresas.Tipo_Valoracion == 1 ? true : false;
            Opc_MetVal2.Checked = r_Empresas.Tipo_Valoracion == 2 ? true : false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Consulta()
        {
            this.Pan_Elementos.Enabled = false;
            this.Pan_Detalles.Enabled = false;
            this.Pan_Config.Enabled = false;

            this.TS_BarraHerramientas.Enabled = true;
            this.Grd_Empresas.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;

            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Pan_Elementos.Enabled = true;
            this.Pan_Detalles.Enabled = true;
            this.Pan_Config.Enabled = true;

            this.Txt_Codigo.Enabled = vl_EsNuevo;
            this.TS_BarraHerramientas.Enabled = false;
            this.Grd_Empresas.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
        }

        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = Funciones._Mens_Idioma(7100);
            this.Lbl_Codigo.Text = Funciones._Mens_Idioma(1001);
            this.Lbl_Nombre.Text = Funciones._Mens_Idioma(1002);
            this.Lbl_DocID.Text = Funciones._Mens_Idioma(1004);

            this.Pag1.Text = Funciones._Mens_Idioma(7103);
            this.Lbl_Direccion.Text = Funciones._Mens_Idioma(1009);
            this.Lbl_Siglas.Text = Funciones._Mens_Idioma(7101);
            this.Lbl_Email.Text = Funciones._Mens_Idioma(1010);
            this.Lbl_Telefono1.Text = Funciones._Mens_Idioma(1011) + "1";
            this.Lbl_Telefono2.Text = Funciones._Mens_Idioma(1011) + "2";
            this.Lbl_Logo.Text = Funciones._Mens_Idioma(7102);

            this.Pag2.Text =  Funciones._Mens_Idioma(7104);
            this.Lbl_ConexString.Text =  Funciones._Mens_Idioma(7105);
            this.Lbl_Proveedor.Text =  Funciones._Mens_Idioma(7106);
            this.Lbl_Metadata.Text =  Funciones._Mens_Idioma(7107);
            this.Lbl_MetodoValClientes.Text = Funciones._Mens_Idioma(7109);
            this.Opc_MetVal1.Text = Funciones._Mens_Idioma(7110);
            this.Opc_MetVal2.Text = Funciones._Mens_Idioma(7111);
            this.Lbl_DsktpImag.Text =  Funciones._Mens_Idioma(7108);

            this.TSB_Primero.Text = Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = MOFIN_LIB.Funciones._Mens_Idioma(140);

            this.Col_Codigo.HeaderText = Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = Funciones._Mens_Idioma(1002);
            //this.Col_Siglas.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(2001);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, Funciones._Mens_Idioma(142));
        }

        private void Txt_Logo_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog vl_Logo = new OpenFileDialog();
            string vl_Tipoarchivo = "*.JPG|*.JPG|*.BMP|*.BMP|*.PNG|*.PNG|*.*|*.*";
            vl_Logo.Filter = vl_Tipoarchivo;
            // vl_ArchivoImport.CheckFileExists = false;
            if (vl_Logo.ShowDialog() == DialogResult.OK)
                this.Txt_Logo.Text= vl_Logo.FileName;
        }

    }
}
    