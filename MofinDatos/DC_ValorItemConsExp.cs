using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;



namespace MofinDatos
{
    public class DC_ValorItemConsExp
    {
        public void Eliminar(C_ValorItemConsExp obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_ValorItemConsExp.Attach(obj);
                db.C_ValorItemConsExp.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<C_ValorItemConsExp> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_ValorItemConsExp.ToList();
            }
        }

        public C_ValorItemConsExp GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_ValorItemConsExp.Find(id);
            }
        }

        public C_ValorItemConsExp Isertar(C_ValorItemConsExp obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_ValorItemConsExp.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(C_ValorItemConsExp obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_ValorItemConsExp.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
