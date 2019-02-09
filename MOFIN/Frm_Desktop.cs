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
using MOFIN_LIB;
using MofinNegocios;
using MofinModelo;
using MofinModeloEntorno;


namespace MOFIN
{
    //public interface IForm { }

    public partial class Frm_Desktop : MetroForm, IForm
    {
        private int childFormNumber = 0;
        Grupos r_GrupoOpciones = new Grupos();

        public Frm_Desktop()
        {

            InitializeComponent();
            this.CambiaImagen();
            this.Asigna_Nombres(null, null);
            //TS_MenuPrincipal.ForeColor = Color.White; ;
            //this.Inicio();
            this.Lbl_Detalle1.Text = NEmpresas.GetNombre(Entorno.vs_Empresa) + " | " + Entorno.vs_Usuario + " | " + NGrupos.GetNombre(Entorno.vs_Grupo);
        }

        #region IForm Members
        public void ActualizaLabeldesktop(string Text)
        {
            this.Lbl_Detalle1.Text = Text;
        }
        public void ActualizaMenu()
        {
            BS_Grupos.DataSource = NGrupos.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupos.Current as Grupos;

            Mnu_Clientes.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Clientes == null ? false : (bool)r_GrupoOpciones.Clientes;
            Cli_Monitor.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Cli_Monitor == null ? false : (bool)r_GrupoOpciones.Cli_Monitor;
            Cli_Busqueda.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Cli_Busqueda == null ? false : (bool)r_GrupoOpciones.Cli_Busqueda;
            Mnu_Operaciones.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Mon_Operaciones == null ? false : (bool)r_GrupoOpciones.Mon_Operaciones;
            Ope_Financieras.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Mon_Financiero == null ? false : (bool)r_GrupoOpciones.Mon_Financiero;
            Ope_Transaccionales.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Mon_Operacional == null ? false : (bool)r_GrupoOpciones.Mon_Operacional;
            Mnu_TablasMaestras.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Tablas_Maestras == null ? false : (bool)r_GrupoOpciones.Tablas_Maestras;
            Mnu_TablasMaestras.Visible = MOFIN_LIB.Entorno.vs_Maestro;
            Tab_Maestros.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Tab_Maestras == null ? false : (bool)r_GrupoOpciones.Tab_Maestras;
            Mnu_Herramientas.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Opc_Sistema == null ? false : (bool)r_GrupoOpciones.Opc_Sistema;
            Her_Empresas.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Ops_Empresas == null ? false : (bool)r_GrupoOpciones.Ops_Empresas;
            Her_Grupos.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Ops_Grupos == null ? false : (bool)r_GrupoOpciones.Ops_Grupos;
            Her_Usuarios.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.Ops_Usuarios == null ? false : (bool)r_GrupoOpciones.Ops_Usuarios;
        }

        #endregion

        private void Frm_Desktop_Load(object sender, EventArgs e)
        {
        }

        private void Inicio()
        {
            this.ActualizaMenu();
            TS_MenuPrincipal.Visible = false;
            var sesion = new Frm_SeleccionEmpresa();
            sesion.ShowDialog();
            if (sesion.DialogResult == DialogResult.Cancel)
            {
                //this.Close();
                this.ExitToolsStripMenuItem_Click(null, null);
            }
            TS_MenuPrincipal.Visible = true;

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

         private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SS_BarradeEstadoPrincipal.Visible = Ver_BarraStado.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Her_Usuarios_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_Usuarios();
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void Her_Grupos_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_Grupos();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Her_Empresas_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_Empresas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Arc_SelEmpresa_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_SeleccionEmpresa();
            childForm.MdiParent = this;
            childForm.Show();
//            childForm.Activate();

        }

        private void tablasMaestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_TablasMaestras();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void monitorDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_Clientes();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void búsquedaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_BusqPersonas();
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void financierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_OpeFinancieras();
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void Ope_Transaccionales_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_OpeTransac();
            childForm.MdiParent = this;
            childForm.Show();
        }


        private void CambiaImagen()
        {
            Random vl_Rnd = new Random();
            int aleatorio = vl_Rnd.Next(0, 7);
            switch (aleatorio)
            {
                case 0:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop0;
                    break;
                case 1:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop1;
                    break;
                case 2:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop2;
                    break;
                case 3:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop3;
                    break;
                case 4:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop4;
                    break;
                case 5:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop5;
                    break;
                case 6:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop6;
                    break;
                case 7:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop7;
                    break;
/*                case 8:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop8;
                    break;
                case 9:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop9;
                    break;
                case 10:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop10;
                    break;
                case 11:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop11;
                    break;
                case 12:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop12;
                    break;
                case 13:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop13;
                    break;
                case 14:
                    this.BackgroundImage = global::MOFIN.Properties.Resources.desktop14;
                    break;*/
            }

        }
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(1);

            this.Mnu_Archivo.Text= MOFIN_LIB.Funciones._Mens_Idioma(401);
                this.Arc_Abrir.Text = MOFIN_LIB.Funciones._Mens_Idioma(402);
                this.Arc_SelEmpresa.Text = MOFIN_LIB.Funciones._Mens_Idioma(2000);
                this.Arc_Imprimir.Text = MOFIN_LIB.Funciones._Mens_Idioma(139);
                this.Arc_VistaPrevia.Text = MOFIN_LIB.Funciones._Mens_Idioma(403);
                this.Arc_ConfigImpres.Text = MOFIN_LIB.Funciones._Mens_Idioma(404);
                this.Arc_Salir.Text = MOFIN_LIB.Funciones._Mens_Idioma(140);

            this.Mnu_Editar.Text = MOFIN_LIB.Funciones._Mens_Idioma(411);
                this.Edi_Deshacer.Text = MOFIN_LIB.Funciones._Mens_Idioma(412);
                this.Edi_Rehacer.Text = MOFIN_LIB.Funciones._Mens_Idioma(413);
                this.Edi_Cortar.Text = MOFIN_LIB.Funciones._Mens_Idioma(414);
                this.Edi_Copiar.Text = MOFIN_LIB.Funciones._Mens_Idioma(415);
                this.Edi_Pegar.Text = MOFIN_LIB.Funciones._Mens_Idioma(416);
                this.Edi_SelecTodo.Text = MOFIN_LIB.Funciones._Mens_Idioma(417);

            this.Mnu_Ver.Text = MOFIN_LIB.Funciones._Mens_Idioma(421);
                this.Ver_BarraStado.Text = MOFIN_LIB.Funciones._Mens_Idioma(422);

            this.Mnu_Clientes.Text = MOFIN_LIB.Funciones._Mens_Idioma(2321);
                this.Cli_Monitor.Text = MOFIN_LIB.Funciones._Mens_Idioma(11000);
                this.Cli_Busqueda.Text = MOFIN_LIB.Funciones._Mens_Idioma(12000);

            this.Mnu_Operaciones.Text = MOFIN_LIB.Funciones._Mens_Idioma(2331);
                this.Ope_Financieras.Text = MOFIN_LIB.Funciones._Mens_Idioma(13000);
                this.Ope_Transaccionales.Text = MOFIN_LIB.Funciones._Mens_Idioma(14000);

            this.Mnu_TablasMaestras.Text = MOFIN_LIB.Funciones._Mens_Idioma(2341);
                this.Tab_Maestros.Text = MOFIN_LIB.Funciones._Mens_Idioma(10001);

            this.Mnu_Herramientas.Text = MOFIN_LIB.Funciones._Mens_Idioma(2311);
                this.Her_Empresas.Text = MOFIN_LIB.Funciones._Mens_Idioma(2100);
                this.Her_Grupos.Text = MOFIN_LIB.Funciones._Mens_Idioma(2300);
                this.Her_Usuarios.Text = MOFIN_LIB.Funciones._Mens_Idioma(2200);

            this.Mnu_Ventanas.Text = MOFIN_LIB.Funciones._Mens_Idioma(431);
                this.Ven_Cascada.Text = MOFIN_LIB.Funciones._Mens_Idioma(432);
                this.Ven_MosVert.Text = MOFIN_LIB.Funciones._Mens_Idioma(433);
                this.Ven_MosHor.Text = MOFIN_LIB.Funciones._Mens_Idioma(434);
                this.Ven_CerrarTodo.Text = MOFIN_LIB.Funciones._Mens_Idioma(435);

            this.Mnu_Ayuda.Text = MOFIN_LIB.Funciones._Mens_Idioma(441);
                this.Ayu_Acerca.Text = MOFIN_LIB.Funciones._Mens_Idioma(442);

            //            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            //            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }

        private void cambiaFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CambiaImagen();
        }

        private void Frm_Desktop_Activated(object sender, EventArgs e)
        {
            this.Lbl_Detalle1.Text = NEmpresas.GetNombre(Entorno.vs_Empresa) + " / " + Entorno.vs_Usuario + " / " + NGrupos.GetNombre(Entorno.vs_Grupo);

        }
    }
}
