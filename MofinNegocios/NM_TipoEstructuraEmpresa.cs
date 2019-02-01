using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public static class NM_TipoEstructuraEmpresa
    {
        static DM_TipoEstructuraEmpresa dmTipoEstructuraEmpresa;

        static NM_TipoEstructuraEmpresa()
        {
            dmTipoEstructuraEmpresa = new DM_TipoEstructuraEmpresa();
        }

        public static List<M_TipoEstructuraEmpresa> Listar()
        {
            return dmTipoEstructuraEmpresa.Listar();
        }

        public static M_TipoEstructuraEmpresa GetById(int id)
        {
            return dmTipoEstructuraEmpresa.GetById(id);
        }

        public static List<M_TipoEstructuraEmpresa> ListarPorCodigo(short codigo)
        {
            return dmTipoEstructuraEmpresa.ListarPorCodigo(codigo);
        }

        public static M_TipoEstructuraEmpresa Insertar(M_TipoEstructuraEmpresa obj)
        {
            return dmTipoEstructuraEmpresa.Isertar(obj);
        }

        public static void Actualizar(M_TipoEstructuraEmpresa obj)
        {
            dmTipoEstructuraEmpresa.Actualizar(obj);
        }

        public static void Elimiar(M_TipoEstructuraEmpresa obj)
        {
            dmTipoEstructuraEmpresa.Eliminar(obj);
        }
    }
}
