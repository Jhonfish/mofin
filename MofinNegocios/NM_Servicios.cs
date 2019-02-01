using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinDatos;
using MofinModelo;

namespace MofinNegocios
{
    public static class NM_Servicios
    {
        static DM_Servicios dmServicios;

        static NM_Servicios()
        {
            dmServicios = new DM_Servicios();
        }

        public static List<M_Servicios> Listar()
        {
            return dmServicios.Listar();
        }

        public static M_Servicios GetById(int id)
        {
            return dmServicios.GetById(id);
        }

        public static List<M_Servicios> ListarPorCodigo(short codigo)
        {
            return dmServicios.ListarPorCodigo(codigo);
        }

        public static M_Servicios Insertar(M_Servicios obj)
        {
            return dmServicios.Isertar(obj);
        }

        public static void Actualizar(M_Servicios obj)
        {
            dmServicios.Actualizar(obj);
        }

        public static void Elimiar(M_Servicios obj)
        {
            dmServicios.Eliminar(obj);
        }
    }
}
