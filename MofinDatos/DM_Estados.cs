using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Estados
    {
        public void Eliminar(M_Estados obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Estados.Attach(obj);
                db.M_Estados.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Estados> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Estados.ToList();
            }
        }

        public List<M_Estados> ListarPorPais(short codPais)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var lst = from estados in db.M_Estados
                              where estados.Cod_Pais == codPais
                              select estados;
                return lst.ToList();

                               //   var lst = from d in db.categorias
                               //              select d;
                               //   return lst.ToList();
            }
        }

        public M_Estados GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Estados.Find(id);
            }
        }

        public M_Estados Isertar(M_Estados obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Estados.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Estados obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Estados.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
