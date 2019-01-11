using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;



namespace MofinDatos
{
    public class DC_Clientes
    {
        public void Eliminar(C_Clientes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_Clientes.Attach(obj);
                db.C_Clientes.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<C_Clientes> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_Clientes.ToList();
            }
        }

        public C_Clientes GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_Clientes.Find(id);
            }
        }

        public C_Clientes Isertar(C_Clientes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_Clientes.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(C_Clientes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_Clientes.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
