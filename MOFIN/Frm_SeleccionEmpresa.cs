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
    public partial class Frm_SeleccionEmpresa : MetroForm
    {
        Usuarios r_Usuarios;
        Grupos r_Grupos;
        Empresas r_Empresas;
        Emp_Accesos r_EmpAccesos;
        
        public Frm_SeleccionEmpresa()
        {
            InitializeComponent();
            this.Asigna_Nombres(null, null);
        }

        private void Frm_SeleccionEmpresa_Load(object sender, EventArgs e)
        {
              BS_Empresas.DataSource = NEmpresas.Listar();
              BS_Emp_Accesos.DataSource = NEmp_Accesos.Listar();
              BS_Grupos.DataSource = NGrupos.Listar();
              BS_Usuarios.DataSource = NUsuarios.Listar();
              
            this.Cmb_Empresa.SelectedIndex = 0;
            this.Cmb_Empresa.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            r_Empresas = BS_Empresas.Current as Empresas;
            string vl_Usuario = this.Txt_Usuario.Text.Trim();
            string vl_Clave = this.Txt_Password.Text.Trim();
            bool vl_Encontrado = false;
            BS_Usuarios.MoveFirst();

            foreach(object obj in BS_Usuarios)
            {
                r_Usuarios = BS_Usuarios.Current as Usuarios;
                //MessageBox.Show(r_Usuarios.ID_Usuario);
                BS_Usuarios.MoveNext();
                if (r_Usuarios.ID_Usuario.ToUpper() == vl_Usuario.ToUpper() & r_Usuarios.Password == vl_Clave)
                {
                    vl_Encontrado = true;
                    break;
                }

            }
            if (vl_Encontrado == true)
            {
                vl_Encontrado = false;
                foreach (object obj in BS_Emp_Accesos)
                {
                    r_EmpAccesos = BS_Emp_Accesos.Current as Emp_Accesos;
                    // MessageBox.Show(r_Usuarios.Nombre);
                    BS_Emp_Accesos.MoveNext();
                    if (r_EmpAccesos.ID_Usuario == vl_Usuario & r_EmpAccesos.Cod_Empresa == r_Empresas.Codigo)
                    {
                        vl_Encontrado = true;
                        break;
                    }

                }
                if (vl_Encontrado==true)
                {
                    foreach (object obj in BS_Grupos)
                    {
                        r_Grupos = BS_Grupos.Current as Grupos;
                        BS_Grupos.MoveNext();
                        if (r_Grupos.Codigo == r_EmpAccesos.Cod_Grupo)
                        {
                            break;
                        }
                    }

                    MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9004) + "\n\n" + "Grupo: " + r_Grupos.Nombre,
                                    MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*                  Frm_Desktop FondoEscritorio = new Frm_Desktop();
                                        //((TextBox)formularioPadre.Controls["nombreDelControl"]).Text = “Texto en un TextBox de otro formulario”;
                                        ((Label)FondoEscritorio.Controls["Lbl_Detalle1"]).Text = r_Empresas.Nombre + " / " + r_Grupos.Nombre + " / " + r_Usuarios.Nombre;

                                        //Desktop.Lbl_Detalle1.Text = r_Empresas.Nombre + " / " + r_Grupos.Nombre + " / " + r_Usuarios.Nombre;

                                        */
                    Entorno.vs_Maestro = true;
                    this.Close();

                }
                else
                    MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9003),
                                    MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9002), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(2000);
            this.Lbl_Empresa.Text = MOFIN_LIB.Funciones._Mens_Idioma(1006);
            this.Lbl_Usuario.Text = MOFIN_LIB.Funciones._Mens_Idioma(1007);
            this.Lbl_Contraseña.Text = MOFIN_LIB.Funciones._Mens_Idioma(1008);
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }
    }
}
