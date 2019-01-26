using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MofinNegocios;
using MofinModelo;
using MofinModeloEntorno;


namespace MOFIN
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'monitorOperacionesDataSet.M_Estados' Puede moverla o quitarla según sea necesario.
            this.m_EstadosTableAdapter.Fill(this.monitorOperacionesDataSet.M_Estados);
            // TODO: esta línea de código carga datos en la tabla 'monitorOperacionesDataSet.M_Pais' Puede moverla o quitarla según sea necesario.
            this.m_PaisTableAdapter.Fill(this.monitorOperacionesDataSet.M_Pais);

            m_EstadosBindingSource1.DataSource = NM_Estados.Listar();
        }

        private void txt_Codpais_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_Codpais.Text.Trim() != "")
            {
                m_EstadosBindingSource.Filter = "Cod_Pais = " + this.txt_Codpais.Text.Trim();
                m_EstadosBindingSource1.Filter = "Cod_Pais = " + this.txt_Codpais.Text.Trim();
                
               // if (this.Cmb_Pais.SelectedValue != null)
                 //   this.Txt_valorcombo.Text = this.Cmb_Pais.SelectedValue.ToString();
             //   if (m_PaisBindingSource.Position >= 0)
                   // this.Txt_Posicion.Text = m_PaisBindingSource.Position.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int aleatorio = r.Next(0,5);
            MessageBox.Show(aleatorio.ToString());
        }
    }
}
