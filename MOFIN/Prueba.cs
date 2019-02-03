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
using MOFIN_Lib;
using MOFIN_LIB;



namespace MOFIN
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            BS_Idiomas.DataSource = NIdiomas.Listar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Pan_Prueba_Paint(null, null);
        }

        private void Pan_Prueba_Leave(object sender, EventArgs e)
        {
            foreach (RadioButton obj in Pan_Prueba.Controls)
            {
                if (obj.Checked == true)
                {
                    this.Pan_Prueba.Tag = (obj.TabIndex + 1).ToString();
                    break;
                }
            }
        }

        private void Pan_Prueba_Paint(object sender, PaintEventArgs e)
        {
            foreach (RadioButton obj in Pan_Prueba.Controls)
            {
                if (this.Pan_Prueba.Tag != null)
                    if ((obj.TabIndex + 1) == int.Parse(this.Pan_Prueba.Tag.ToString()))
                        obj.Checked = true;
            }
        }

        private void NUD_Valor_ValueChanged(object sender, EventArgs e)
        {
            //this.Opc_Prueba.Tag = this.NUD_Valor.Value.ToString();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            //this.textBox1.Text = this.Opc_Prueba.Tag.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Txt_Resultado.Text = MOFIN_LIB.Funciones.UltimoDiaMes(this.DTP_Fecha.Value.Date).ToString();
        }
    }
}
