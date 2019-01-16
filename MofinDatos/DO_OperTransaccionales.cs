using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_OperTransaccionales
    {
        public void Eliminar(O_OperTransaccionales obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_OperTransaccionales.Attach(obj);
                db.O_OperTransaccionales.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_OperTransaccionales> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_OperTransaccionales.ToList();
            }
        }

        public O_OperTransaccionales GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_OperTransaccionales.Find(id);
            }
        }

        public O_OperTransaccionales Isertar(O_OperTransaccionales obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_OperTransaccionales.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_OperTransaccionales obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_OperTransaccionales.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
