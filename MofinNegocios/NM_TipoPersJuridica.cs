using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public class NM_TipoPersJuridica
    {
        static DM_TipoPersJuridica dmTipoPersJuridica;

        static NM_TipoPersJuridica()
        {
            dmTipoPersJuridica = new DM_TipoPersJuridica();
        }

        public static List<M_TipoPersJuridica> Listar()
        {
            return dmTipoPersJuridica.Listar();
        }

        public static List<M_TipoPersJuridica> ListarPorCodigo(short codigo)
        {
            return dmTipoPersJuridica.ListarPorCodigo(codigo);
        }

        public static M_TipoPersJuridica GetById(int id)
        {
            return dmTipoPersJuridica.GetById(id);
        }

        public static M_TipoPersJuridica Insertar(M_TipoPersJuridica obj)
        {
            return dmTipoPersJuridica.Isertar(obj);
        }

        public static void Actualizar(M_TipoPersJuridica obj)
        {
            dmTipoPersJuridica.Actualizar(obj);
        }

        public static void Elimiar(M_TipoPersJuridica obj)
        {
            dmTipoPersJuridica.Eliminar(obj);
        }
    }
}
