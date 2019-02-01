using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Criptomonedas
    {
        static DM_Criptomonedas dmCriptomonedas;

        static NM_Criptomonedas()
        {
            dmCriptomonedas = new DM_Criptomonedas();
        }

        public static List<M_Criptomonedas> Listar()
        {
            return dmCriptomonedas.Listar();
        }

        public static M_Criptomonedas GetById(int id)
        {
            return dmCriptomonedas.GetById(id);
        }

        public static M_Criptomonedas Insertar(M_Criptomonedas obj)
        {
            return dmCriptomonedas.Isertar(obj);
        }

        public static List<M_Criptomonedas> ListarPorCodigo(short codigo)
        {
            return dmCriptomonedas.ListarPorCodigo(codigo);
        }

        public static void Actualizar(M_Criptomonedas obj)
        {
            dmCriptomonedas.Actualizar(obj);
        }

        public static void Elimiar(M_Criptomonedas obj)
        {
            dmCriptomonedas.Eliminar(obj);
        }
    }
}
