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
        public static List<O_Observaciones> ListarPorCodigoTipo(string Codigo, int Tipo)
        {
            return dObservaciones.ListarPorCodTipo(Codigo, Tipo);
        }

        public static O_Observaciones GetById(int id)
        {
            return dObservaciones.GetById(id);
        }

        public static List<O_Observaciones> ListarPorCliente(string codigo)
        {
            return dObservaciones.ListarPorCliente(codigo);
        }

        public static O_Observaciones Insertar(O_Observaciones obj)
        {
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
