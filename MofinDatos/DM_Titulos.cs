using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_Titulos
    {
        public void Eliminar(M_Titulos obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Titulos.Attach(obj);
                db.M_Titulos.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_Titulos> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Titulos.ToList();
            }
        }

        public M_Titulos GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_Titulos.Find(id);
            }
        }

        public List<M_Titulos> ListarPorCodigo(string codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_Titulos
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_Titulos Insertar(M_Titulos obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Titulos.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_Titulos obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_Titulos.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
