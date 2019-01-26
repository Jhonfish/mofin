using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NC_FirBenAcc
    {
        static DC_FirBenAcc dC_FirBenAcc;

        static NC_FirBenAcc()
        {
            dC_FirBenAcc = new DC_FirBenAcc();
        }

        public static List<C_FirBenAcc> Listar()
        {
            return dC_FirBenAcc.Listar();
        }

        public static List<C_FirBenAcc> ListarPorCliente(string cliente)
        {
            return dC_FirBenAcc.ListarPorCliente(cliente);
        }

        public static C_FirBenAcc Insertar(C_FirBenAcc obj)
        {
            return dC_FirBenAcc.Isertar(obj);
        }

        public static void Actualizar(C_FirBenAcc obj)
        {
            dC_FirBenAcc.Actualizar(obj);
        }

        public static void Elimiar(C_FirBenAcc obj)
        {
            dC_FirBenAcc.Eliminar(obj);
        }
    }
}
