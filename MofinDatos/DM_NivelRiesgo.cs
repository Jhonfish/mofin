using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_NivelRiesgo
    {
        public void Eliminar(M_NivelRiesgo obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_NivelRiesgo.Attach(obj);
                db.M_NivelRiesgo.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_NivelRiesgo> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_NivelRiesgo.ToList();
            }
        }

        public M_NivelRiesgo GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_NivelRiesgo.Find(id);
            }
        }

        public M_NivelRiesgo Isertar(M_NivelRiesgo obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_NivelRiesgo.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_NivelRiesgo obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_NivelRiesgo.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
