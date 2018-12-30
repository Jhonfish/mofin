using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_PEP
    {
        static DM_PEP dmPEP;

        static NM_PEP()
        {
            dmPEP = new DM_PEP();
        }

        public static List<M_PEP> Listar()
        {
            return dmPEP.Listar();
        }

        public static M_PEP GetById(int id)
        {
            return dmPEP.GetById(id);
        }

        public static M_PEP Insertar(M_PEP obj)
        {
            return dmPEP.Isertar(obj);
        }

        public static void Actualizar(M_PEP obj)
        {
            dmPEP.Actualizar(obj);
        }

        public static void Elimiar(M_PEP obj)
        {
            dmPEP.Eliminar(obj);
        }
    }
}
