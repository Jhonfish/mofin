using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_RepOperacional
    {
        public void Eliminar(O_RepOperacional obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_RepOperacional.Attach(obj);
                db.O_RepOperacional.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_RepOperacional> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_RepOperacional.ToList();
            }
        }

        public O_RepOperacional GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_RepOperacional.Find(id);
            }
        }

        public O_RepOperacional Isertar(O_RepOperacional obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_RepOperacional.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_RepOperacional obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_RepOperacional.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
