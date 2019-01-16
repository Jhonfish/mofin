using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NO_Observaciones
    {
        static DO_Observaciones dObservaciones;

        static NO_Observaciones()
        {
            dObservaciones = new DO_Observaciones();
        }

        public static List<O_Observaciones> Listar()
        {
            return dObservaciones.Listar();
        }

        public static O_Observaciones GetById(int id)
        {
            return dObservaciones.GetById(id);
        }

        public static O_Observaciones Insertar(O_Observaciones obj)
        {
            //obj.Directorio = "No tiene";
            return dObservaciones.Isertar(obj);
        }

        public static void Actualizar(O_Observaciones obj)
        {
            dObservaciones.Actualizar(obj);
        }

        public static void Elimiar(O_Observaciones obj)
        {
            dObservaciones.Eliminar(obj);
        }
    }
}
