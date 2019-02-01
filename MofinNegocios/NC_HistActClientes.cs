using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NC_HistActClientes
    {
        static DC_HistActClientes dC_HistActClientes;

        static NC_HistActClientes()
        {
            dC_HistActClientes = new DC_HistActClientes();
        }

        public static List<C_HistActClientes> Listar()
        {
            return dC_HistActClientes.Listar();
        }

        public static List<C_HistActClientes> ListarPorCliente(string cliente)
        {
            return dC_HistActClientes.ListarPorCliente(cliente);
        }

        public static C_HistActClientes Insertar(C_HistActClientes obj)
        {
            return dC_HistActClientes.Isertar(obj);
        }

        public static void Actualizar(C_HistActClientes obj)
        {
            dC_HistActClientes.Actualizar(obj);
        }

        public static void Elimiar(C_HistActClientes obj)
        {
            dC_HistActClientes.Eliminar(obj);
        }
    }
}
