using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;



namespace MofinDatos
{
    public class DEmpresas
    {
        public void Eliminar(Empresas obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Empresas.Attach(obj);
                db.Empresas.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Empresas> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Empresas.ToList();
            }
        }

        public Empresas GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Empresas.Find(id);
            }
        }
        public string GetNombre(string Codigo)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                var Emp_Nme = from Empresas in db.Empresas
                              where Empresas.Codigo == Codigo
                              select Empresas.Nombre;
                return Emp_Nme.First();
            }
        }

        public Empresas Isertar(Empresas obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Empresas.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(Empresas obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Empresas.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
