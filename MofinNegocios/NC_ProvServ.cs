using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NC_ProdServ
    {
        static DC_ProdServ dC_ProdServ;

        static NC_ProdServ()
        {
            dC_ProdServ = new DC_ProdServ();
        }

        public static List<C_ProdServ> Listar()
        {
            return dC_ProdServ.Listar();
        }

        public static List<C_ProdServ> ListarPorCliente(string cliente)
        {
            return dC_ProdServ.ListarPorCliente(cliente);
        }

        public static C_ProdServ Insertar(C_ProdServ obj)
        {
            return dC_ProdServ.Isertar(obj);
        }

        public static void Actualizar(C_ProdServ obj)
        {
            dC_ProdServ.Actualizar(obj);
        }

        public static void Elimiar(C_ProdServ obj)
        {
            dC_ProdServ.Eliminar(obj);
        }
    }
}
