using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NL_LibroOrdenes
    {
        static DL_LibroOrdenes dlLibroOrdenes;

        static NL_LibroOrdenes()
        {
            dlLibroOrdenes = new DL_LibroOrdenes();
        }

        public static List<L_LibroOrdenes> Listar()
        {
            return dlLibroOrdenes.Listar();
        }
        public static List<L_LibroOrdenes> ListarPorTitulo(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            return dlLibroOrdenes.ListarPorTitulo(Codigo, FDesde, FHasta);
        }
        public static List<L_LibroOrdenes> ListarPorCliente(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            return dlLibroOrdenes.ListarPorCliente(Codigo, FDesde, FHasta);
        }
        public static List<L_LibroOrdenes> ListarPorStatus(int Status, DateTime? FDesde, DateTime? FHasta)
        {
            return dlLibroOrdenes.ListarPorStatus(Status, FDesde, FHasta);
        }
        /* public static List<Exp_LibroOrdenes> GeneraDataGrid()
         {
             return dlLibroOrdenes.GeneraDataGrid();
         }*/

        public static L_LibroOrdenes GetById(int id)
        {
            return dlLibroOrdenes.GetById(id);
        }

        public static L_LibroOrdenes Insertar(L_LibroOrdenes obj)
        {
            return dlLibroOrdenes.Insertar(obj);
        }

        public static void Actualizar(L_LibroOrdenes obj)
        {
            dlLibroOrdenes.Actualizar(obj);
        }

        public static void Elimiar(L_LibroOrdenes obj)
        {
            dlLibroOrdenes.Eliminar(obj);
        }
    }
}
