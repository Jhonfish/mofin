using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Profesiones
    {
        static DM_Profesiones dmProfesiones;

        static NM_Profesiones()
        {
            dmProfesiones = new DM_Profesiones();
        }

        public static List<M_Profesiones> Listar()
        {
            return dmProfesiones.Listar();
        }

        public static M_Profesiones GetById(int id)
        {
            return dmProfesiones.GetById(id);
        }

        public static List<M_Profesiones> ListarPorCodigo(short codigo)
        {
            return dmProfesiones.ListarPorCodigo(codigo);
        }

        public static M_Profesiones Insertar(M_Profesiones obj)
        {
            return dmProfesiones.Isertar(obj);
        }

        public static void Actualizar(M_Profesiones obj)
        {
            dmProfesiones.Actualizar(obj);
        }

        public static void Elimiar(M_Profesiones obj)
        {
            dmProfesiones.Eliminar(obj);
        }
    }
}
