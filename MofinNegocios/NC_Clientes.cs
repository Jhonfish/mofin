using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NC_Clientes
    {
        static DC_Clientes dC_Clientes;

        static NC_Clientes()
        {
            dC_Clientes = new DC_Clientes();
        }

        public static List<C_Clientes> Listar()
        {
            return dC_Clientes.Listar();
        }

        public static C_Clientes GetById(int id)
        {
            return dC_Clientes.GetById(id);
        }

        public static C_Clientes Insertar(C_Clientes obj)
        {
            return dC_Clientes.Isertar(obj);
        }

        public static void Actualizar(C_Clientes obj)
        {
            dC_Clientes.Actualizar(obj);
        }

        public static void Elimiar(C_Clientes obj)
        {
            dC_Clientes.Eliminar(obj);
        }
    }
}
