using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinDatos;
using MofinModelo;


namespace MofinNegocios
{
    public static class NM_ActivComercial
    {
        static DM_ActivComercial dmActividadComercial;

        static NM_ActivComercial()
        {
            dmActividadComercial = new DM_ActivComercial();
        }

        public static List<M_ActivComercial> Listar()
        {
            return dmActividadComercial.Listar();
        }

        public static M_ActivComercial GetById(int id)
        {
            return dmActividadComercial.GetById(id);
        }

        public static M_ActivComercial Insertar(M_ActivComercial obj)
        {
            return dmActividadComercial.Isertar(obj);
        }

        public static void Actualizar(M_ActivComercial obj)
        {
            dmActividadComercial.Actualizar(obj);
        }

        public static void Elimiar(M_ActivComercial obj)
        {
            dmActividadComercial.Eliminar(obj);
        }
    }
}
