using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;
using MofinDatos;


namespace MofinDatos
{
    public class DM_TipoPersJuridica
    {
        public void Eliminar(M_TipoPersJuridica obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoPersJuridica.Attach(obj);
                db.M_TipoPersJuridica.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_TipoPersJuridica> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoPersJuridica.ToList();
            }
        }

        public M_TipoPersJuridica GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoPersJuridica.Find(id);
            }
        }

        public M_TipoPersJuridica Isertar(M_TipoPersJuridica obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoPersJuridica.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_TipoPersJuridica obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoPersJuridica.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
