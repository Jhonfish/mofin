using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NGrupos
    {
        static DGrupos dGrupos;

        static NGrupos()
        {
            dGrupos = new DGrupos();
        }

        public static List<Grupos> Listar()
        {
            return dGrupos.Listar();
        }

        public static Grupos GetById(int id)
        {
            return dGrupos.GetById(id);
        }
        public static List<Grupos> ListarPorCodigo(string Codigo)
        {
            return dGrupos.ListarPorCodigo(Codigo);
        }

        public static Grupos Insertar(Grupos obj)
        {
            return dGrupos.Isertar(obj);
        }

        public static void Actualizar(Grupos obj)
        {
            dGrupos.Actualizar(obj);
        }

        public static void Elimiar(Grupos obj)
        {
            dGrupos.Eliminar(obj);
        }
    }
}
