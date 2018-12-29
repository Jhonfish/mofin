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
    public partial class Frm_SeleccionEmpresa : MetroForm
    {
        public Frm_SeleccionEmpresa()
        {
            InitializeComponent();
        }

        private void Frm_SeleccionEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Entorno.Usuarios' Puede moverla o quitarla según sea necesario.
            this.TA_Usuarios.Fill(this.DS_Entorno.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Empresas' Puede moverla o quitarla según sea necesario.
            this.TA_Empresas.Fill(this.DS_Entorno.Empresas);
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Empresas' Puede moverla o quitarla según sea necesario.
            this.TA_Empresas.Fill(this.DS_Entorno.Empresas);
            this.Cmb_Empresa.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Empresas.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void empresasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Empresas.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_Entorno);

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            int foundIndex = BS_Usuarios.Find("Nombre", Txt_Usuario.Text.ToString());
            if (foundIndex > -1)
            {
                BS_Usuarios.Position = foundIndex;
                string vl_DataUsuario = ((DataRowView)this.BS_Usuarios.Current).Row["ID_Usuario"].ToString();
                string vl_DataClave = ((DataRowView)this.BS_Usuarios.Current).Row["Password"].ToString();
                vl_DataUsuario = vl_DataUsuario.ToUpper().Trim();
                vl_DataClave = vl_DataClave.ToUpper().Trim();

                string vl_TxtUsuario = Txt_Usuario.Text.ToUpper().ToString();
                string vl_TxtClave = Txt_Password.Text.ToUpper().ToString();
                //                MessageBox.Show("*"+ vl_DataUsuario+ "*"+ "//"+ "*"+ vl_DataClave+ "*" + "\n" +
                //                                "*" + vl_TxtUsuario+ "*"+ "//"+ "*"+ vl_TxtClave + "*");
                if ((vl_DataUsuario == vl_TxtUsuario) &
                    (vl_DataClave == vl_TxtClave))
                {
                    MessageBox.Show("todo Bien");
                    
                    this.Close();
                }
                else
                    MessageBox.Show("Usuario y Clave Erradas");
            }
            else
                MessageBox.Show("usuario no encontrado");
        }
    }
}
