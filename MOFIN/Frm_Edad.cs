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
            mEdadBindingSource.DataSource = NM_Edad.Listar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //mEdadBindingSource.Add(new M_Edad());
            //mEdadBindingSource.MoveLast();
            
            //mEdadBindingSource.DataSource = new M_Edad();
            
            txtCodigo.Text = null;
            txtDescripcion.Clear();
            txtValor.Clear();
            
            m_Edad.Codigo = short.Parse(txtCodigo.Text);
            m_Edad.Descripcion = txtDescripcion.Text;
            m_Edad.Valor = byte.Parse(txtValor.Text);
            
            EsNuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EsNuevo)
                //NM_Edad.Insertar(mEdadBindingSource.Current as M_Edad);
                NM_Edad.Insertar(m_Edad);
            else
                NM_Edad.Actualizar(mEdadBindingSource.Current as M_Edad);
            dgvEdad.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (mEdadBindingSource.Current == null)
                return;
            EsNuevo = false;
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string vaina = m_Edad.Descripcion.ToString();
            MessageBox.Show(vaina);
            NM_Edad.Elimiar(mEdadBindingSource.Current as M_Edad);
        }
    }
}
