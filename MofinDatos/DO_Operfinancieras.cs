using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_Operfinancieras
    {
        public void Eliminar(O_Operfinancieras obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Operfinancieras.Attach(obj);
                db.O_Operfinancieras.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_Operfinancieras> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_Operfinancieras.ToList();
            }
        }

        public O_Operfinancieras GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_Operfinancieras.Find(id);
            }
        }

        public O_Operfinancieras Isertar(O_Operfinancieras obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Operfinancieras.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_Operfinancieras obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Operfinancieras.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
