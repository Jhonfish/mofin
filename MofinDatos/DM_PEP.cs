using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_PEP
    {
        public void Eliminar(M_PEP obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_PEP.Attach(obj);
                db.M_PEP.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_PEP> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_PEP.ToList();
            }
        }

        public M_PEP GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_PEP.Find(id);
            }
        }

        public M_PEP Isertar(M_PEP obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_PEP.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_PEP obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_PEP.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
