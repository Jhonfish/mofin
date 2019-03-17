using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MofinModeloEntorno;
using MofinNegocios;



namespace MOFIN
{
    //public interface IForm { }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Opc_Sistema> r_OpcSistema = new List<Opc_Sistema>();
            r_OpcSistema = NOpc_Sistema.Listar();
            
            
            //MOFIN_LIB.Entorno.vs_Maestro = true;
            MOFIN_LIB.Entorno.vs_Idiomas = (int)r_OpcSistema[0].IdiomaPredeterminado;   // 1: Español, 2: Ingles
            MOFIN_LIB.Entorno.vs_CnfgBtnsNaveg = true;
            MOFIN_LIB.Entorno.vs_TipoValoracCliente = 1; // Promedio
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var Acceso = new Frm_SeleccionEmpresa();
            if (Acceso.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Frm_Desktop());
            }
            
            //Application.Run(new Frm_LibroOrdenes());
            //Application.Run(new Frm_VisorCrystalRep());
        }
    }
}
