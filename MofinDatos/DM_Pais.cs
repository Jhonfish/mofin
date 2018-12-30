using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Pais
    {
        public void Eliminar(M_Pais obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Pais.Attach(obj);
                db.M_Pais.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Pais> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Pais.ToList();
            }
        }

        public M_Pais GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Pais.Find(id);
            }
        }

        public M_Pais Isertar(M_Pais obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Pais.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Pais obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Pais.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
