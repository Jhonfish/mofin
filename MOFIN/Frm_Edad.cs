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



namespace MOFIN
{
    public partial class Frm_Edad : MetroForm
    {
        bool EsNuevo = true;
        M_Edad m_Edad = new M_Edad();
        public Frm_Edad()
        {
            InitializeComponent();
        }

        private void Frm_Edad_Load(object sender, EventArgs e)
        {
            //mEdadBindingSource.DataSource = NM_Edad.Listar();
            dgvEdad.DataSource = NM_Edad.Listar();
            deshabilitar();
        }

        private void deshabilitar()
        {
            panel1.Enabled = false;
            /*
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtValor.Enabled = false;
            */
        }

        private void habilitar()
        {
            panel1.Enabled = true;
            /*
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtValor.Enabled = true;
            */
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //mEdadBindingSource.Add(new M_Edad());
            //mEdadBindingSource.MoveLast();

            //mEdadBindingSource.DataSource = new M_Edad();
            habilitar();
      
            txtCodigo.Text = null;
            txtDescripcion.Clear();
            txtValor.Clear();
          
            EsNuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            m_Edad.Codigo = short.Parse(txtCodigo.Text);
            m_Edad.Descripcion = txtDescripcion.Text;
            m_Edad.Valor = byte.Parse(txtValor.Text);

            if (EsNuevo)
            {
                //NM_Edad.Insertar(mEdadBindingSource.Current as M_Edad);
                NM_Edad.Insertar(m_Edad);
            }   
            else
            {
                //NM_Edad.Actualizar(mEdadBindingSource.Current as M_Edad);
                NM_Edad.Actualizar(m_Edad);
            }
            deshabilitar();
            dgvEdad.DataSource = NM_Edad.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
            txtCodigo.Enabled = false;
            //if (mEdadBindingSource.Current == null)
            //    return;
            EsNuevo = false;
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NM_Edad.Eliminar(mEdadBindingSource.Current as M_Edad);
            NM_Edad.Elimiar(m_Edad);
        }

        private void dgvEdad_SelectionChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dgvEdad.CurrentRow.Cells["Codigo"].Value);
            txtDescripcion.Text = Convert.ToString(dgvEdad.CurrentRow.Cells["Descripcion"].Value);
            txtValor.Text = Convert.ToString(dgvEdad.CurrentRow.Cells["Valor"].Value);
        }
    }
}
