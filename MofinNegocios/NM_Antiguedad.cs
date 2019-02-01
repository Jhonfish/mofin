using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_Antiguedad
    {
        static DM_Antiguedad dmAntiguedad;

        static NM_Antiguedad()
        {
            dmAntiguedad = new DM_Antiguedad();
        }

        public static List<M_Antiguedad> Listar()
        {
            return dmAntiguedad.Listar();
        }

        public static M_Antiguedad GetById(int id)
        {
            return dmAntiguedad.GetById(id);
        }

        public static List<M_Antiguedad> ListarPorCodigo(short codigo)
        {
            return dmAntiguedad.ListarPorCodigo(codigo);
        }

        public static M_Antiguedad Insertar(M_Antiguedad obj)
        {
            return dmAntiguedad.Isertar(obj);
        }

        public static void Actualizar(M_Antiguedad obj)
        {
            dmAntiguedad.Actualizar(obj);
        }

        public static void Elimiar(M_Antiguedad obj)
        {
            dmAntiguedad.Eliminar(obj);
        }
    }
}
