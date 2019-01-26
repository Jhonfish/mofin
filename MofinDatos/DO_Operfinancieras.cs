using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_Operfinancieras
    {
        public void Eliminar(O_Operfinancieras obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Operfinancieras.Attach(obj);
                db.O_Operfinancieras.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_Operfinancieras> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_Operfinancieras.ToList();
            }
        }
        public List<O_Operfinancieras> ListarPorCodigo(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                if (FDesde == null)
                {
                    var lst = from Operaciones in db.O_Operfinancieras
                              where Operaciones.Cod_Cliente == Codigo
                              select Operaciones;
                    return lst.ToList();
                }
                else
                {
                    var lst = from Operaciones in db.O_Operfinancieras
                              where Operaciones.Cod_Cliente == Codigo &
                                    Operaciones.Fec_Pacto >= FDesde &
                                    Operaciones.Fec_Pacto <= FHasta
                              select Operaciones;
                    return lst.ToList();
                }
            }
        }

        public O_Operfinancieras GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_Operfinancieras.Find(id);
            }
        }

        public O_Operfinancieras Isertar(O_Operfinancieras obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Operfinancieras.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_Operfinancieras obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_Operfinancieras.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
