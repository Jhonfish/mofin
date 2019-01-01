using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;


namespace MofinDatos
{
    public class DUsuarios
    {
        public void Eliminar(Usuarios obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Usuarios.Attach(obj);
                db.Usuarios.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Usuarios> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Usuarios.ToList();
            }
        }

        public Usuarios GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Usuarios.Find(id);
            }
        }

        public Usuarios Isertar(Usuarios obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Usuarios.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(Usuarios obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Usuarios.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
