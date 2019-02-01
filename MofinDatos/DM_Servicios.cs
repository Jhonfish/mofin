using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Servicios
    {
        public void Eliminar(M_Servicios obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Servicios.Attach(obj);
                db.M_Servicios.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Servicios> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Servicios.ToList();
            }
        }

        public M_Servicios GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Servicios.Find(id);
            }
        }

        public List<M_Servicios> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_Servicios
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_Servicios Isertar(M_Servicios obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Servicios.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Servicios obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Servicios.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
