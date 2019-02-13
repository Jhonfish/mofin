using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_TipoDocID
    {
        public void Eliminar(M_TipoDocID obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoDocID.Attach(obj);
                db.M_TipoDocID.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_TipoDocID> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoDocID.ToList();
            }
        }

        public M_TipoDocID GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoDocID.Find(id);
            }
        }
        public List<M_TipoDocID> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_TipoDocID
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_TipoDocID Isertar(M_TipoDocID obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoDocID.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_TipoDocID obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoDocID.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
