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
    class Libreria
    {
    }
    public static class Funciones
    {
        /*public partial void C_DeclarVar(int Nivel)
        {
            public string vs_Idioma = "Ingles";
        }*/
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
    }
}
