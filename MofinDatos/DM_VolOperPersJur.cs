using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_VolOperPersJur
    {
        public void Eliminar(M_VolOperPersJur obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_VolOperPersJur.Attach(obj);
                db.M_VolOperPersJur.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_VolOperPersJur> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_VolOperPersJur.ToList();
            }
        }

        public M_VolOperPersJur GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_VolOperPersJur.Find(id);
            }
        }

        public M_VolOperPersJur Isertar(M_VolOperPersJur obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_VolOperPersJur.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_VolOperPersJur obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_VolOperPersJur.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
