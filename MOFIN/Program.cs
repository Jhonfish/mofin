﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOFIN
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Frm_Desktop());
            Application.Run(new Frm_Usuarios());
            // Application.Run(new Frm_Edad());

            //            Form childForm = new Frm_SeleccionEmpresa();
            //            childForm.MdiParent = Frm_Desktop;
            //            childForm.Show();


        }
    }
}
