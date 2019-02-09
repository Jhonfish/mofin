using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NGrupo_Opciones
    {
        static DGrupo_Opciones dGrupo_Opciones;

        static NGrupo_Opciones()
        {
            dGrupo_Opciones = new DGrupo_Opciones();
        }

        public static List<Grupo_Opciones> Listar()
        {
            return dGrupo_Opciones.Listar();
        }

        public static Grupo_Opciones GetById(int id)
        {
            return dGrupo_Opciones.GetById(id);
        }

        public static List<Grupo_Opciones> ListarPorCodigo(string Codigo)
        {
            return dGrupo_Opciones.ListarPorCodigo(Codigo);
        }

        public static Grupo_Opciones Insertar(Grupo_Opciones obj)
        {
            return dGrupo_Opciones.Isertar(obj);
        }

        public static void Actualizar(Grupo_Opciones obj)
        {
            dGrupo_Opciones.Actualizar(obj);
        }

        public static void Elimiar(Grupo_Opciones obj)
        {
            dGrupo_Opciones.Eliminar(obj);
        }


    }
}
