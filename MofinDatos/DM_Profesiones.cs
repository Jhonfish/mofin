using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Profesiones
    {
        public void Eliminar(M_Profesiones obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Profesiones.Attach(obj);
                db.M_Profesiones.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Profesiones> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Profesiones.ToList();
            }
        }

        public M_Profesiones GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Profesiones.Find(id);
            }
        }

        public M_Profesiones Isertar(M_Profesiones obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Profesiones.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Profesiones obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Profesiones.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
