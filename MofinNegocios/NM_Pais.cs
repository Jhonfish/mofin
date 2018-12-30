using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Pais
    {
        static DM_Pais dmPais;

        static NM_Pais()
        {
            dmPais = new DM_Pais();
        }

        public static List<M_Pais> Listar()
        {
            return dmPais.Listar();
        }

        public static M_Pais GetById(int id)
        {
            return dmPais.GetById(id);
        }

        public static M_Pais Insertar(M_Pais obj)
        {
            return dmPais.Isertar(obj);
        }

        public static void Actualizar(M_Pais obj)
        {
            dmPais.Actualizar(obj);
        }

        public static void Elimiar(M_Pais obj)
        {
            dmPais.Eliminar(obj);
        }
    }
}
