using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;



namespace MofinDatos
{
    public class DL_LibroOrdenes
    {
        public void Eliminar(L_LibroOrdenes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.L_LibroOrdenes.Attach(obj);
                db.L_LibroOrdenes.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<L_LibroOrdenes> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.L_LibroOrdenes.ToList();
            }
        }
        public List<L_LibroOrdenes> ListarPorTitulo(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                if (FDesde == null)
                {
                    var lst = from Operaciones in db.L_LibroOrdenes
                              where Operaciones.Titulo_Cod == Codigo
                              orderby Operaciones.Orden_Fecha
                              select Operaciones;
                    return lst.ToList();
                }
                else
                {
                    var lst = from Operaciones in db.L_LibroOrdenes
                              where Operaciones.Titulo_Cod == Codigo &
                                    Operaciones.Orden_Fecha >= FDesde &
                                    Operaciones.Orden_Fecha <= FHasta
                                    orderby Operaciones.Orden_Fecha
                              select Operaciones;
                    return lst.ToList();
                }
            }
        }
        public List<L_LibroOrdenes> ListarPorCliente(string Codigo, DateTime? FDesde, DateTime? FHasta)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                if (FDesde == null)
                {
                    var lst = from Ordenes in db.L_LibroOrdenes
                              where Ordenes.Cliente_Cod == Codigo
                              orderby Ordenes.Orden_Fecha
                              select Ordenes;
                    return lst.ToList();
                }
                else
                {
                    var lst = from Ordenes in db.L_LibroOrdenes
                              where Ordenes.Cliente_Cod == Codigo &
                                    Ordenes.Orden_Fecha >= FDesde &
                                    Ordenes.Orden_Fecha <= FHasta
                              orderby Ordenes.Orden_Fecha
                              select Ordenes;
                    return lst.ToList();
                }
            }
        }
        public List<L_LibroOrdenes> ListarPorStatus(int Status, DateTime? FDesde, DateTime? FHasta)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                if (Status < 5)
                {
                    if (FDesde == null)
                    {
                        var lst = from Ordenes in db.L_LibroOrdenes
                                  where Ordenes.Status == Status
                                  orderby Ordenes.Orden_Fecha
                                  select Ordenes;
                        return lst.ToList();
                    }
                    else
                    {
                        var lst = from Ordenes in db.L_LibroOrdenes
                                  where Ordenes.Status == Status &
                                        Ordenes.Orden_Fecha >= FDesde &
                                        Ordenes.Orden_Fecha <= FHasta
                                  orderby Ordenes.Orden_Fecha
                                  select Ordenes;
                        return lst.ToList();
                    }
                }
                else
                {
                    if (FDesde == null)
                    {
                        var lst = from Ordenes in db.L_LibroOrdenes
                                  where Ordenes.Status > 0 
                                  orderby Ordenes.Orden_Fecha
                                  select Ordenes;
                        return lst.ToList();
                    }
                    else
                    {
                        var lst = from Ordenes in db.L_LibroOrdenes
                                  where Ordenes.Status > 0 &
                                        Ordenes.Orden_Fecha >= FDesde &
                                        Ordenes.Orden_Fecha <= FHasta
                                  orderby Ordenes.Orden_Fecha
                                  select Ordenes;
                        return lst.ToList();
                    }

                }
            }
        }
        /*       public List<Exp_LibroOrdenes> GeneraDataGrid()
               {

                   using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
                   {
                       var Query = from Ordenes in db.L_LibroOrdenes
                                   join tipoOrden in db.M_TipoOrdenes
                                     on Ordenes.Tipo_Orden equals tipoOrden.Codigo
                                   join cliente in db.C_Clientes
                                     on Ordenes.Cliente_Cod equals cliente.Codigo
                                   join titulos in db.M_Titulos
                                     on Ordenes.Titulo_Cod equals titulos.Codigo
                                   orderby Ordenes.Cliente_Cod, Ordenes.Fecha_Orden
                                   select new
                                   {
                                       Ordenes.Secuencia,
                                       TipoOrden = tipoOrden.Descripcion,
                                       Tit_Codigo = titulos.Codigo,
                                       Tit_Nombre = titulos.Descripcion,
                                       Tit_ISIN = titulos.ISIN,
                                       Ordenes.Fecha_Orden,
                                       Ordenes.Fecha_Venta,
                                       Ordenes.Nominal,
                                       Ordenes.Precio,
                                       Ordenes.Valor_Efectivo,
                                       Ordenes.Cuenta,
                                       Clte_Codigo = cliente.Codigo,
                                       Clte_Nombre = cliente.Nombre,
                                       Clte_Email = cliente.IG_Email,
                                       Clte_Status = "Activo",
                                       Clte_Ejecutivo = cliente.Ejecutivo,
                                       Ordenes.Aprob_Por,
                                       Ordenes.Aprob_Fecha
                                   };

                       return (List<Exp_LibroOrdenes>)Query.ToList();

                   }
               }*/

        public L_LibroOrdenes GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.L_LibroOrdenes.Find(id);
            }
        }

        public L_LibroOrdenes Insertar(L_LibroOrdenes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.L_LibroOrdenes.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(L_LibroOrdenes obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.L_LibroOrdenes.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
