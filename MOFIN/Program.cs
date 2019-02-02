using System;
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
            MOFIN_LIB.Entorno.vs_Maestro = true;
            MOFIN_LIB.Entorno.vs_Idiomas = 2;   // 1: Español, 2: Ingles

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Frm_Desktop());
            //Application.Run(new Frm_OpeTransac());
        }
    }
}
