using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_TipoDocID
    {
        static DM_TipoDocID dmTipoDocId;

        static NM_TipoDocID()
        {
            dmTipoDocId = new DM_TipoDocID();
        }

        public static List<M_TipoDocID> Listar()
        {
            return dmTipoDocId.Listar();
        }

        public static M_TipoDocID GetById(int id)
        {
            return dmTipoDocId.GetById(id);
        }

        public static M_TipoDocID Insertar(M_TipoDocID obj)
        {
            return dmTipoDocId.Isertar(obj);
        }

        public static void Actualizar(M_TipoDocID obj)
        {
            dmTipoDocId.Actualizar(obj);
        }

        public static void Elimiar(M_TipoDocID obj)
        {
            dmTipoDocId.Eliminar(obj);
        }
    }
}
