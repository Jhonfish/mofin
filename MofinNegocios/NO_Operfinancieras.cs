using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NO_Operfinancieras
    {
        static DO_Operfinancieras dOperfinancieras;

        static NO_Operfinancieras()
        {
            dOperfinancieras = new DO_Operfinancieras();
        }

        public static List<O_Operfinancieras> Listar()
        {
            return dOperfinancieras.Listar();
        }
        public static List<O_Operfinancieras> ListarPorCodigo(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            return dOperfinancieras.ListarPorCodigo(Codigo, FDesde, FHasta);
        }
        public static O_Operfinancieras GetById(int id)
        {
            return dOperfinancieras.GetById(id);
        }

        public static O_Operfinancieras Insertar(O_Operfinancieras obj)
        {
            //obj.Directorio = "No tiene";
            return dOperfinancieras.Isertar(obj);
        }

        public static void Actualizar(O_Operfinancieras obj)
        {
            dOperfinancieras.Actualizar(obj);
        }

        public static void Elimiar(O_Operfinancieras obj)
        {
            dOperfinancieras.Eliminar(obj);
        }
    }
}
