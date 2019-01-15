using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NO_RepOperacional
    {
        static DO_RepOperacional dRepOperacional;

        static NO_RepOperacional()
        {
            dRepOperacional = new DO_RepOperacional();
        }

        public static List<O_RepOperacional> Listar()
        {
            return dRepOperacional.Listar();
        }

        public static O_RepOperacional GetById(int id)
        {
            return dRepOperacional.GetById(id);
        }

        public static O_RepOperacional Insertar(O_RepOperacional obj)
        {
            //obj.Directorio = "No tiene";
            return dRepOperacional.Isertar(obj);
        }

        public static void Actualizar(O_RepOperacional obj)
        {
            dRepOperacional.Actualizar(obj);
        }

        public static void Elimiar(O_RepOperacional obj)
        {
            dRepOperacional.Eliminar(obj);
        }
    }
}
