using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Edad
    {
        static DM_Edad dmEdad;

        static NM_Edad()
        {
            dmEdad = new DM_Edad();
        }

        public static List<M_Edad> Listar()
        {
            return dmEdad.Listar();
        }

        public static M_Edad GetById(int id)
        {
            return dmEdad.GetById(id);
        }

        public static List<M_Edad> ListarPorCodigo(short codigo)
        {
            return dmEdad.ListarPorCodigo(codigo);
        }

        public static M_Edad Insertar(M_Edad obj)
        {
            return dmEdad.Isertar(obj);
        }

        public static void Actualizar(M_Edad obj)
        {
            dmEdad.Actualizar(obj);
        }

        public static void Elimiar(M_Edad obj)
        {
            dmEdad.Eliminar(obj);
        }
    }
}
