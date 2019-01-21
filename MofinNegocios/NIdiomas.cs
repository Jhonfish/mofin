using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NIdiomas
    {
        static DIdiomas dIdiomas;

        static NIdiomas()
        {
            dIdiomas = new DIdiomas();
        }

        public static List<Idiomas> Listar()
        {
            return dIdiomas.Listar();
        }

        public static Idiomas GetById(int id)
        {
            return dIdiomas.GetById(id);
        }

        public static Idiomas Insertar(Idiomas obj)
        {
            return dIdiomas.Isertar(obj);
        }

        public static void Actualizar(Idiomas obj)
        {
            dIdiomas.Actualizar(obj);
        }

        public static void Elimiar(Idiomas obj)
        {
            dIdiomas.Eliminar(obj);
        }
    }
}
