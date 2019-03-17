using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Titulos
    {
        static DM_Titulos dmTitulos;

        static NM_Titulos()
        {
            dmTitulos = new DM_Titulos();
        }

        public static List<M_Titulos> Listar()
        {
            return dmTitulos.Listar();
        }

        public static M_Titulos GetById(int id)
        {
            return dmTitulos.GetById(id);
        }

        public static List<M_Titulos> ListarPorCodigo(string codigo)
        {
            return dmTitulos.ListarPorCodigo(codigo);
        }

        public static M_Titulos Insertar(M_Titulos obj)
        {
            return dmTitulos.Insertar(obj);
        }

        public static void Actualizar(M_Titulos obj)
        {
            dmTitulos.Actualizar(obj);
        }

        public static void Elimiar(M_Titulos obj)
        {
            dmTitulos.Eliminar(obj);
        }
    }
}
