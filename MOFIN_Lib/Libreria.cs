using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MofinModeloEntorno;
using MofinNegocios;


namespace MOFIN_LIB
{
    public struct Entorno
    {
        public static int vs_Idiomas = 1;   // 1: Espanol, 2: Ingles
        public static bool vs_Maestro = false;
        public static string vs_Empresa = "001";
        public static string vs_Grupo = "001";
        public static string vs_Usuario = "JMARIN";
        public static bool vs_CnfgBtnsNaveg = true;
        public static byte vs_TipoValoracCliente = 1;   

    }
    public static class Funciones
    {
        public static void TTT_Pic(PictureBox objeto, string vl_Mensaje)
        {
            ToolTip PictureTooltip = new ToolTip();
            PictureTooltip.AutoPopDelay = 5000;
            PictureTooltip.InitialDelay = 250;
            PictureTooltip.ReshowDelay = 500;
            PictureTooltip.SetToolTip(objeto, vl_Mensaje);
        }
        public static void TTT_Btn(Button objeto, string vl_Mensaje)
        {
            ToolTip PictureTooltip = new ToolTip();
            PictureTooltip.AutoPopDelay = 5000;
            PictureTooltip.InitialDelay = 250;
            PictureTooltip.ReshowDelay = 500;
            PictureTooltip.SetToolTip(objeto, vl_Mensaje);
        }
        public static void TTT_Chk(CheckBox objeto, string vl_Mensaje)
        {
            ToolTip PictureTooltip = new ToolTip();
            PictureTooltip.AutoPopDelay = 5000;
            PictureTooltip.InitialDelay = 250;
            PictureTooltip.ReshowDelay = 500;
            PictureTooltip.SetToolTip(objeto, vl_Mensaje);
        }
        public static string _Mens_Idioma(int Codigo)
        {
            Idiomas r_Idiomas = new Idiomas();
            r_Idiomas = NIdiomas.GetById(Codigo);
            if (r_Idiomas != null)
                if(MOFIN_LIB.Entorno.vs_Idiomas==1)
                    return (r_Idiomas.espanol);
                else
                    return (r_Idiomas.ingles);
            else
                return ("Indice Inexistente");
        }
        public static int UltimoDiaMes(DateTime Fecha)
        {
            int Mes = Fecha.Month;
            int Ano = Fecha.Year;

            int UltimoDia = 30;
            if (Mes == 4 | Mes == 6 | Mes == 9 | Mes == 11)
                UltimoDia = 30;
            else
                if(Mes==2)
                {
                    if((Ano % 4)==0)
                        UltimoDia = 29;
                    else
                        UltimoDia = 28;
                }
                else
                    UltimoDia = 31;
            return (UltimoDia);
        }
        public static string MasterKey(string MasterKey)
        {
            string MK = DateTime.Now.Day.ToString() + "BILLFISH" + DateTime.Now.Hour.ToString();
            return (MK);
        }

    }
}
