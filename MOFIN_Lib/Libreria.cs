using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MOFIN
{
    class Libreria
    {
        public static void ToolTipText(PictureBox objeto, string vl_Mensaje)
        {
            ToolTip PictureTooltip = new ToolTip();
            PictureTooltip.AutoPopDelay = 5000;
            PictureTooltip.InitialDelay = 250;
            PictureTooltip.ReshowDelay = 500;
            PictureTooltip.SetToolTip(objeto, vl_Mensaje);
        }
    }
    public class C_DeclarVar
    {
        public static string vs_Idioma = "Ingles";

    }

}
