using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_TipoEstructuraEmpresa
    {
        public void Eliminar(M_TipoEstructuraEmpresa obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoEstructuraEmpresa.Attach(obj);
                db.M_TipoEstructuraEmpresa.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_TipoEstructuraEmpresa> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoEstructuraEmpresa.ToList();
            }
        }

        public M_TipoEstructuraEmpresa GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_TipoEstructuraEmpresa.Find(id);
            }
        }

        public List<M_TipoEstructuraEmpresa> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_TipoEstructuraEmpresa
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_TipoEstructuraEmpresa Isertar(M_TipoEstructuraEmpresa obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoEstructuraEmpresa.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_TipoEstructuraEmpresa obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_TipoEstructuraEmpresa.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
