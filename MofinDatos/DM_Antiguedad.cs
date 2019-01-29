using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Antiguedad
    {
        public void Eliminar(M_Antiguedad obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Antiguedad.Attach(obj);
                db.M_Antiguedad.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Antiguedad> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Antiguedad.ToList();
            }
        }

        public M_Antiguedad GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Antiguedad.Find(id);
            }
        }

        public List<M_Antiguedad> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_Antiguedad
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_Antiguedad Isertar(M_Antiguedad obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Antiguedad.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Antiguedad obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Antiguedad.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
