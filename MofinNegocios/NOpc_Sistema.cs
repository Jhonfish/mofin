using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NOpc_Sistema
    {
        static DOpc_Sistema dOpc_Sistema;

        static NOpc_Sistema()
        {
            dOpc_Sistema = new DOpc_Sistema();
        }

        public static List<Opc_Sistema> Listar()
        {
            return dOpc_Sistema.Listar();
        }

        public static Opc_Sistema GetById(int id)
        {
            return dOpc_Sistema.GetById(id);
        }

         public static void Actualizar(Opc_Sistema obj)
        {
            dOpc_Sistema.Actualizar(obj);
        }

    }
}
