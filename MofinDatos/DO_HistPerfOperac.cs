using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_HistPerfOperac
    {
        public void Eliminar(O_HistPerfOperac obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_HistPerfOperac.Attach(obj);
                db.O_HistPerfOperac.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_HistPerfOperac> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_HistPerfOperac.ToList();
            }
        }
        public List<O_HistPerfOperac> ListarPorCodTipo(string Codigo, int Tipo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var lst = from HistPerfOperac in db.O_HistPerfOperac
                          where HistPerfOperac.Cod_Cliente == Codigo &
                                HistPerfOperac.Tipo_Perfil == Tipo
                                orderby HistPerfOperac.Fecha ascending
                          select HistPerfOperac;
                return lst.ToList();
            }
        }
        public O_HistPerfOperac GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_HistPerfOperac.Find(id);
            }
        }

        public O_HistPerfOperac Isertar(O_HistPerfOperac obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_HistPerfOperac.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_HistPerfOperac obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_HistPerfOperac.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
