using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_Observaciones
    {
        public void Eliminar(O_Observaciones obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Observaciones.Attach(obj);
                db.O_Observaciones.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_Observaciones> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_Observaciones.ToList();
            }
        }
        public List<O_Observaciones> ListarPorCodTipo(string Codigo, int Tipo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var lst = from Observaciones in db.O_Observaciones
                          where Observaciones.Cod_Cliente == Codigo &
                                Observaciones.Tipo_Perfil == Tipo
                          orderby Observaciones.fecha ascending
                          select Observaciones;
                return lst.ToList();
            }
        }

        public O_Observaciones GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_Observaciones.Find(id);
            }
        }

        public O_Observaciones Isertar(O_Observaciones obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Observaciones.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_Observaciones obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Observaciones.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
