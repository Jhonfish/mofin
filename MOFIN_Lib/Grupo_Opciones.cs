﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOFIN_Lib
{
    public partial class Grupo_Opciones : UserControl
    {
        RadioButton[] radio;
        public Grupo_Opciones(int numero)
        {
            for (int i = 0;i< numero; i++)
            {
                radio[i] = new RadioButton();
                radio[i].CheckedChanged += Opc_Opcion1_CheckedChanged;
            }
            InitializeComponent();
            
        }
        public void Pan_Opciones_Paint(object sender, PaintEventArgs e)
        {
            foreach (RadioButton obj in Pan_Opciones.Controls)
            {
                if (this.Pan_Opciones.Tag != null)
                    if ((obj.TabIndex + 1) == int.Parse(this.Pan_Opciones.Tag.ToString()))
                        obj.Checked = true;
            }
        }
        private void Pan_Opciones_Leave(object sender, EventArgs e)
        {
            foreach (RadioButton obj in Pan_Opciones.Controls)
            {
                if (obj.Checked == true)
                {
                    this.Pan_Opciones.Tag = (obj.TabIndex + 1).ToString();
                    break;
                }
            }
        }

        private void Opc_Opcion1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
