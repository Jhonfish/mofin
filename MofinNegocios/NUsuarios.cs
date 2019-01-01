using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NUsuarios
    {
        static DUsuarios dUsuarios;

        static NUsuarios()
        {
            dUsuarios = new DUsuarios();
        }

        public static List<Usuarios> Listar()
        {
            return dUsuarios.Listar();
        }

        public static Usuarios GetById(int id)
        {
            return dUsuarios.GetById(id);
        }

        public static Usuarios Insertar(Usuarios obj)
        {
            return dUsuarios.Isertar(obj);
        }

        public static void Actualizar(Usuarios obj)
        {
            dUsuarios.Actualizar(obj);
        }

        public static void Elimiar(Usuarios obj)
        {
            dUsuarios.Eliminar(obj);
        }
    }
}
