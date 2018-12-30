using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_VolOperPersNat
    {
        static DM_VolOperPersNat dmVolOperPersNat;

        static NM_VolOperPersNat()
        {
            dmVolOperPersNat = new DM_VolOperPersNat();
        }

        public static List<M_VolOperPersNat> Listar()
        {
            return dmVolOperPersNat.Listar();
        }

        public static M_VolOperPersNat GetById(int id)
        {
            return dmVolOperPersNat.GetById(id);
        }

        public static M_VolOperPersNat Insertar(M_VolOperPersNat obj)
        {
            return dmVolOperPersNat.Isertar(obj);
        }

        public static void Actualizar(M_VolOperPersNat obj)
        {
            dmVolOperPersNat.Actualizar(obj);
        }

        public static void Elimiar(M_VolOperPersNat obj)
        {
            dmVolOperPersNat.Eliminar(obj);
        }
    }
}
