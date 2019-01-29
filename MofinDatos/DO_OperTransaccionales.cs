using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DO_OperTransaccionales
    {
        public void Eliminar(O_OperTransaccionales obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_OperTransaccionales.Attach(obj);
                db.O_OperTransaccionales.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<O_OperTransaccionales> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_OperTransaccionales.ToList();
            }
        }

        public O_OperTransaccionales GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.O_OperTransaccionales.Find(id);
            }
        }

        public List<O_OperTransaccionales> ListarPorCliente(string cliente)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.O_OperTransaccionales
                                where datos.Cod_Cliente == cliente
                                select datos;
                return registros.ToList();
            }
        }

        public List<O_OperTransaccionales> ListarPorTipoOrden(string orden)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.O_OperTransaccionales
                                where datos.Tipo_Orden == orden
                                select datos;
                return registros.ToList();
            }
        }

        public List<O_OperTransaccionales> ListarPorTiporDocId(string id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.O_OperTransaccionales
                                where datos.Doc_ID == id
                                select datos;
                return registros.ToList();
            }
        }

        public O_OperTransaccionales Isertar(O_OperTransaccionales obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_OperTransaccionales.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(O_OperTransaccionales obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.O_OperTransaccionales.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
