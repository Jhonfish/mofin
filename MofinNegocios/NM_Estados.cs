using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Estados
    {
        static DM_Estados dmEstados;

        static NM_Estados()
        {
            dmEstados = new DM_Estados();
        }

        public static List<M_Estados> Listar()
        {
            return dmEstados.Listar();
        }

        public static List<M_Estados> ListarPorPais(short codPais)
        {
            return dmEstados.ListarPorPais(codPais);
        }
        public static M_Estados GetById(int id)
        {
            return dmEstados.GetById(id);
        }
        public static List<M_Estados> ListarPorCodigo(int Codigo)
        {
            return dmEstados.ListarPorCodigo(Codigo);
        }
        public static M_Estados Insertar(M_Estados obj)
        {
            return dmEstados.Isertar(obj);
        }

        public static void Actualizar(M_Estados obj)
        {
            dmEstados.Actualizar(obj);
        }

        public static void Elimiar(M_Estados obj)
        {
            dmEstados.Eliminar(obj);
        }
    }
}
