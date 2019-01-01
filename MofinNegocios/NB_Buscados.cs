using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinNegocios
{
    public class NB_Buscados
    {
        static DB_Buscados dB_Buscados;

        static NB_Buscados()
        {
            dB_Buscados = new DB_Buscados();
        }

        public static List<B_Buscados> Listar()
        {
            return dB_Buscados.Listar();
        }

        public static B_Buscados GetById(int id)
        {
            return dB_Buscados.GetById(id);
        }

        public static B_Buscados Insertar(B_Buscados obj)
        {
            return dB_Buscados.Isertar(obj);
        }

        public static void Actualizar(B_Buscados obj)
        {
            dB_Buscados.Actualizar(obj);
        }

        public static void Elimiar(B_Buscados obj)
        {
            dB_Buscados.Eliminar(obj);
        }
    }
}
