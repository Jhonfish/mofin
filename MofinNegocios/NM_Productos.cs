using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinDatos;
using MofinModelo;


namespace MofinNegocios
{
    public static class NM_Productos
    {
        static DM_Productos dmProductos;

        static NM_Productos()
        {
            dmProductos = new DM_Productos();
        }

        public static List<M_Productos> Listar()
        {
            return dmProductos.Listar();
        }

        public static M_Productos GetById(int id)
        {
            return dmProductos.GetById(id);
        }

        public static List<M_Productos> ListarPorCodigo(short codigo)
        {
            return dmProductos.ListarPorCodigo(codigo);
        }

        public static M_Productos Insertar(M_Productos obj)
        {
            return dmProductos.Isertar(obj);
        }

        public static void Actualizar(M_Productos obj)
        {
            dmProductos.Actualizar(obj);
        }

        public static void Elimiar(M_Productos obj)
        {
            dmProductos.Eliminar(obj);
        }
    }
}
