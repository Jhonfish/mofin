using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_NivelRiesgo
    {
        static DM_NivelRiesgo dmNivelRiesgo;

        static NM_NivelRiesgo()
        {
            dmNivelRiesgo = new DM_NivelRiesgo();
        }

        public static List<M_NivelRiesgo> Listar()
        {
            return dmNivelRiesgo.Listar();
        }

        public static M_NivelRiesgo GetById(int id)
        {
            return dmNivelRiesgo.GetById(id);
        }

        public static M_NivelRiesgo Insertar(M_NivelRiesgo obj)
        {
            return dmNivelRiesgo.Isertar(obj);
        }

        public static void Actualizar(M_NivelRiesgo obj)
        {
            dmNivelRiesgo.Actualizar(obj);
        }

        public static void Elimiar(M_NivelRiesgo obj)
        {
            dmNivelRiesgo.Eliminar(obj);
        }
    }
}
