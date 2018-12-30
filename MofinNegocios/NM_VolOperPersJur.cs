using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_VolOperPersJur
    {
        static DM_VolOperPersJur dmVolOperPersJur;

        static NM_VolOperPersJur()
        {
            dmVolOperPersJur = new DM_VolOperPersJur();
        }

        public static List<M_VolOperPersJur> Listar()
        {
            return dmVolOperPersJur.Listar();
        }

        public static M_VolOperPersJur GetById(int id)
        {
            return dmVolOperPersJur.GetById(id);
        }

        public static M_VolOperPersJur Insertar(M_VolOperPersJur obj)
        {
            return dmVolOperPersJur.Isertar(obj);
        }

        public static void Actualizar(M_VolOperPersJur obj)
        {
            dmVolOperPersJur.Actualizar(obj);
        }

        public static void Elimiar(M_VolOperPersJur obj)
        {
            dmVolOperPersJur.Eliminar(obj);
        }
    }
}
