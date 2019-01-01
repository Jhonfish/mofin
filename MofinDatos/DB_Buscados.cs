using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DB_Buscados
    {
        public void Eliminar(B_Buscados obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.B_Buscados.Attach(obj);
                db.B_Buscados.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<B_Buscados> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.B_Buscados.ToList();
            }
        }

        public B_Buscados GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.B_Buscados.Find(id);
            }
        }

        public B_Buscados Isertar(B_Buscados obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.B_Buscados.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(B_Buscados obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.B_Buscados.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
