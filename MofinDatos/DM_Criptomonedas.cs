using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;

namespace MofinDatos
{
    public class DM_Criptomonedas
    {
        public void Eliminar(M_Criptomonedas obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Criptomonedas.Attach(obj);
                db.M_Criptomonedas.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Criptomonedas> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Criptomonedas.ToList();
            }
        }

        public M_Criptomonedas GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Criptomonedas.Find(id);
            }
        }

        public List<M_Criptomonedas> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_Criptomonedas
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_Criptomonedas Isertar(M_Criptomonedas obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Criptomonedas.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Criptomonedas obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Criptomonedas.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
