using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Edad
    {
        public void Eliminar(M_Edad obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Edad.Attach(obj);
                db.M_Edad.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Edad> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Edad.ToList();
            }
        }

        public M_Edad GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Edad.Find(id);
            }
        }

        public M_Edad Isertar(M_Edad obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Edad.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Edad obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Edad.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
