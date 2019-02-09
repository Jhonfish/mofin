using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DC_ProdServ
    {
        public void Eliminar(C_ProdServ obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_ProdServ.Attach(obj);
                db.C_ProdServ.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<C_ProdServ> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_ProdServ.ToList();
            }
        }

        public List<C_ProdServ> ListarPorCliente(string cliente)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.C_ProdServ
                                    where datos.Cod_Cliente == cliente
                                    select datos;
                return registros.ToList();
            }
        }

        public List<C_ProdServ> ListarPorClienyTipProdServ(string cliente,byte TipoProdServ)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.C_ProdServ
                                where datos.Cod_Cliente == cliente & 
                                datos.Tipo_ProdServ == TipoProdServ
                                select datos;
                return registros.ToList();
            }
        }

        public C_ProdServ Isertar(C_ProdServ obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_ProdServ.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(C_ProdServ obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_ProdServ.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
