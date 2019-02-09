using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;



namespace MofinNegocios
{
    public static class NO_OperTransaccionales
    {
        static DO_OperTransaccionales dOperTransaccionales;

        static NO_OperTransaccionales()
        {
            dOperTransaccionales = new DO_OperTransaccionales();
        }

        public static List<O_OperTransaccionales> Listar()
        {
            return dOperTransaccionales.Listar();
        }
        public static List<O_OperTransaccionales> ListarPorCodigo(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            return dOperTransaccionales.ListarPorCodigo(Codigo, FDesde, FHasta);
        }

        public static O_OperTransaccionales GetById(int id)
        {
            return dOperTransaccionales.GetById(id);
        }

        public static List<O_OperTransaccionales> ListarPorCliente(string cliente)
        {
            return dOperTransaccionales.ListarPorCliente(cliente);
        }

        public static List<O_OperTransaccionales> ListarPorTipoOrden(string orden)
        {
            return dOperTransaccionales.ListarPorTipoOrden(orden);
        }

        public static List<O_OperTransaccionales> ListarPorTiporDocId(string id)
        {
            return dOperTransaccionales.ListarPorTiporDocId(id);
        }

        public static O_OperTransaccionales Insertar(O_OperTransaccionales obj)
        {
            return dOperTransaccionales.Isertar(obj);
        }

        public static void Actualizar(O_OperTransaccionales obj)
        {
            dOperTransaccionales.Actualizar(obj);
        }

        public static void Elimiar(O_OperTransaccionales obj)
        {
            dOperTransaccionales.Eliminar(obj);
        }
    }
}
