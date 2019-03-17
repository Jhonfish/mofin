using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_TipoOrdenes
    {
        public void Eliminar(M_TipoOrdenes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoOrdenes.Attach(obj);
                db.M_TipoOrdenes.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_TipoOrdenes> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoOrdenes.ToList();
            }
        }

        public M_TipoOrdenes GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoOrdenes.Find(id);
            }
        }

        public List<M_TipoOrdenes> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_TipoOrdenes
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_TipoOrdenes Insertar(M_TipoOrdenes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoOrdenes.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_TipoOrdenes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoOrdenes.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
