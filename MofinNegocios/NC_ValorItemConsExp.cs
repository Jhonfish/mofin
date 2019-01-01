using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NC_ValorItemConsExp
    {
        static DC_ValorItemConsExp dC_ValorItemConsExp;

        static NC_ValorItemConsExp()
        {
            dC_ValorItemConsExp = new DC_ValorItemConsExp();
        }

        public static List<C_ValorItemConsExp> Listar()
        {
            return dC_ValorItemConsExp.Listar();
        }

        public static C_ValorItemConsExp GetById(int id)
        {
            return dC_ValorItemConsExp.GetById(id);
        }

        public static C_ValorItemConsExp Insertar(C_ValorItemConsExp obj)
        {
            return dC_ValorItemConsExp.Isertar(obj);
        }

        public static void Actualizar(C_ValorItemConsExp obj)
        {
            dC_ValorItemConsExp.Actualizar(obj);
        }

        public static void Elimiar(C_ValorItemConsExp obj)
        {
            dC_ValorItemConsExp.Eliminar(obj);
        }
    }
}
