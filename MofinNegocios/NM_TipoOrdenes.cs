using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_TipoOrdenes
    {
        static DM_TipoOrdenes dmTipoOrdenes;

        static NM_TipoOrdenes()
        {
            dmTipoOrdenes = new DM_TipoOrdenes();
        }

        public static List<M_TipoOrdenes> Listar()
        {
            return dmTipoOrdenes.Listar();
        }

        public static M_TipoOrdenes GetById(int id)
        {
            return dmTipoOrdenes.GetById(id);
        }

        public static List<M_TipoOrdenes> ListarPorCodigo(short codigo)
        {
            return dmTipoOrdenes.ListarPorCodigo(codigo);
        }

        public static M_TipoOrdenes Insertar(M_TipoOrdenes obj)
        {
            return dmTipoOrdenes.Insertar(obj);
        }

        public static void Actualizar(M_TipoOrdenes obj)
        {
            dmTipoOrdenes.Actualizar(obj);
        }

        public static void Elimiar(M_TipoOrdenes obj)
        {
            dmTipoOrdenes.Eliminar(obj);
        }
    }
}
