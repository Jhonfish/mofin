using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;
using MofinDatos;


namespace MofinNegocios
{
    public static class NEmp_Accesos
    {
        static DEmp_Accesos dEmp_Accesos;

        static NEmp_Accesos()
        {
            dEmp_Accesos = new DEmp_Accesos();
        }

        public static List<Emp_Accesos> Listar()
        {
            return dEmp_Accesos.Listar();
        }

        public static Emp_Accesos GetById(int id)
        {
            return dEmp_Accesos.GetById(id);
        }

        public static Emp_Accesos Insertar(Emp_Accesos obj)
        {
            return dEmp_Accesos.Isertar(obj);
        }

        public static void Actualizar(Emp_Accesos obj)
        {
            dEmp_Accesos.Actualizar(obj);
        }

        public static void Elimiar(Emp_Accesos obj)
        {
            dEmp_Accesos.Eliminar(obj);
        }
    }
}
