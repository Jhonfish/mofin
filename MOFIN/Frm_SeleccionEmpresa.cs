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


namespace MOFIN
{
    public partial class Frm_SeleccionEmpresa : MetroForm
    {
        Usuarios r_Usuarios;
        Empresas r_Empresas;
        
        public Frm_SeleccionEmpresa()
        {
            InitializeComponent();
        }

        private void Frm_SeleccionEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Grupos' Puede moverla o quitarla según sea necesario.
            this.TA_Grupos.Fill(this.entornoDataSet.Grupos);
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Emp_Accesos' Puede moverla o quitarla según sea necesario.
            this.TA_Emp_Accesos.Fill(this.entornoDataSet.Emp_Accesos);
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.TA_Usuarios.Fill(this.entornoDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'entornoDataSet.Empresas' Puede moverla o quitarla según sea necesario.
            this.TA_Empresas.Fill(this.entornoDataSet.Empresas);

            /*  BS_Empresas.DataSource = NEmpresas.Listar();
              BS_Emp_Accesos.DataSource = NEmp_Accesos.Listar();
              BS_Grupos.DataSource = NGrupos.Listar();
              BS_Usuarios.DataSource = NUsuarios.Listar();
              */
            this.Cmb_Empresa.SelectedIndex = 0;
            this.Cmb_Empresa.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            int foundIndex = BS_Usuarios.Find("ID_Usuario", Txt_Usuario.Text.Trim());
            if (foundIndex > -1)
            {
                BS_Usuarios.Position = foundIndex;
                string vl_DataEmpresa = ((DataRowView)this.BS_Empresas.Current).Row["Codigo"].ToString();
                string vl_DataUsuario = ((DataRowView)this.BS_Usuarios.Current).Row["ID_Usuario"].ToString();
                string vl_DataClave = ((DataRowView)this.BS_Usuarios.Current).Row["Password"].ToString();
                string vl_CodGrupo = "";

                vl_DataUsuario = vl_DataUsuario.ToUpper().Trim();
                vl_DataClave = vl_DataClave.ToUpper().Trim();

                string vl_TxtUsuario = Txt_Usuario.Text.ToUpper().ToString();
                string vl_TxtClave = Txt_Password.Text.ToUpper().ToString();
                if ((vl_DataUsuario == vl_TxtUsuario) &
                    (vl_DataClave == vl_TxtClave))
                {
                    int vl_nroregs = BS_Emp_Accesos.Count;
                    int vl_Contador = 0;
                    for (vl_Contador = 0; vl_Contador < vl_nroregs; vl_Contador++)
                    {
                        BS_Emp_Accesos.Position = vl_Contador;
                        if(((DataRowView)this.BS_Emp_Accesos.Current).Row["ID_Usuario"].ToString() == vl_TxtUsuario &
                           ((DataRowView)this.BS_Emp_Accesos.Current).Row["Cod_Empresa"].ToString() == vl_DataEmpresa)
                        {
                            vl_CodGrupo = ((DataRowView)this.BS_Emp_Accesos.Current).Row["Cod_Grupo"].ToString();
                            break; 
                        }
                    }
                    if (vl_Contador == vl_nroregs)
                        MessageBox.Show("Este Usuario no tiene permisos para operar en la empresa Seleccionada",
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Usuario Aceptado" + "\n\n" + "Grupo: " + vl_CodGrupo,
                                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                MessageBox.Show("Usuario y Clave Erradas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Usuario NO Encontrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void empresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BS_Empresas.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entornoDataSet);

        }
    }
}
