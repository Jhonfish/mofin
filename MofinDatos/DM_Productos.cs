using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Productos
    {
        public void Eliminar(M_Productos obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Productos.Attach(obj);
                db.M_Productos.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Productos> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Productos.ToList();
            }
        }

        public M_Productos GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Productos.Find(id);
            }
        }

        public M_Productos Isertar(M_Productos obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Productos.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Productos obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Productos.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
