using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NO_HistPerfOperac
    {
        static DO_HistPerfOperac dHistperfoperac;

        static NO_HistPerfOperac()
        {
            dHistperfoperac = new DO_HistPerfOperac();
        }

        public static List<O_HistPerfOperac> Listar()
        {
            return dHistperfoperac.Listar();
        }
        public static List<O_HistPerfOperac> ListarPorCodigoTipo(string Codigo, int Tipo)
        {
            return dHistperfoperac.ListarPorCodTipo(Codigo, Tipo);
        }
        public static O_HistPerfOperac GetById(int id)
        {
            return dHistperfoperac.GetById(id);
        }

        public static O_HistPerfOperac Insertar(O_HistPerfOperac obj)
        {
            //obj.Directorio = "No tiene";
            return dHistperfoperac.Isertar(obj);
        }

        public static void Actualizar(O_HistPerfOperac obj)
        {
            dHistperfoperac.Actualizar(obj);
        }

        public static void Elimiar(O_HistPerfOperac obj)
        {
            dHistperfoperac.Eliminar(obj);
        }
    }
}
