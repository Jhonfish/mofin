using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;



namespace MofinDatos
{
    public class DC_HistActClientes
    {
        public void Eliminar(C_HistActClientes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_HistActClientes.Attach(obj);
                db.C_HistActClientes.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<C_HistActClientes> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_HistActClientes.ToList();
            }
        }

        public List<C_HistActClientes> ListarPorCliente(string cliente)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var clientes = from datos in db.C_HistActClientes
                                    where datos.Codigo == cliente
                                    select datos;
                return clientes.ToList();
            }
        }

        public C_HistActClientes Isertar(C_HistActClientes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_HistActClientes.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(C_HistActClientes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_HistActClientes.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
