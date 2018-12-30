using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_VolOperPersNat
    {
        public void Eliminar(M_VolOperPersNat obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_VolOperPersNat.Attach(obj);
                db.M_VolOperPersNat.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_VolOperPersNat> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_VolOperPersNat.ToList();
            }
        }

        public M_VolOperPersNat GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_VolOperPersNat.Find(id);
            }
        }

        public M_VolOperPersNat Isertar(M_VolOperPersNat obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_VolOperPersNat.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_VolOperPersNat obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_VolOperPersNat.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
