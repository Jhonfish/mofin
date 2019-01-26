using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;



namespace MofinDatos
{
    public class DIdiomas
    {
        public void Eliminar(Idiomas obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Idiomas.Attach(obj);
                db.Idiomas.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Idiomas> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Idiomas.ToList();
            }
        }

        public Idiomas GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Idiomas.Find(id);
            }
        }

        public Idiomas Isertar(Idiomas obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Idiomas.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(Idiomas obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Idiomas.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
