using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NEmpresas
    {
        static DEmpresas dEmpresas;

        static NEmpresas()
        {
            dEmpresas = new DEmpresas();
        }

        public static List<Empresas> Listar()
        {
            return dEmpresas.Listar();
        }

        public static Empresas GetById(int id)
        {
            return dEmpresas.GetById(id);
        }
        public static string GetNombre(string Codigo)
        {
            return dEmpresas.GetNombre(Codigo);
        }
        public static Empresas Insertar(Empresas obj)
        {
            //obj.Directorio = "No tiene";
            return dEmpresas.Isertar(obj);
        }

        public static void Actualizar(Empresas obj)
        {
            dEmpresas.Actualizar(obj);
        }

        public static void Elimiar(Empresas obj)
        {
            dEmpresas.Eliminar(obj);
        }
    }
}
