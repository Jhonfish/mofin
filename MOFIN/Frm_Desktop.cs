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

namespace MOFIN
{
    public partial class Frm_Desktop : MetroForm
    {
        private int childFormNumber = 0;

        public Frm_Desktop()
        {
            InitializeComponent();
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
            SS_BarradeEstadoPrincipal.Visible = statusBarToolStripMenuItem.Checked;
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

        private void Frm_Desktop_Load(object sender, EventArgs e)
        {

        }

        public void Actualiza_Menu(int vl_RegistroGrupo)
        {
            this.Mnu_Clientes.Enabled = true;
            this.Mnu_Operaciones.Enabled = false;
            this.Mnu_TablasMaestras.Enabled = true;
            this.Mnu_Herramientas.Enabled = false;
           
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

        private void financierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Frm_OpeFinancieras();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
