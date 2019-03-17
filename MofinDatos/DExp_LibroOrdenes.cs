using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;



namespace MofinDatos
{
    public class DExp_LibroOrdenes
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
        public List<L_LibroOrdenes> ListarPorStatus(string Status, DateTime? FDesde, DateTime? FHasta)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                if (FDesde == null)
                {
                    var lst = from Ordenes in db.L_LibroOrdenes
                              where Ordenes.Cliente_Cod == Status
                              orderby Ordenes.Orden_Fecha
                              select Ordenes;
                    return lst.ToList();
                }
                else
                {
                    var lst = from Ordenes in db.L_LibroOrdenes
                              where Ordenes.Cliente_Cod == Status &
                                    Ordenes.Orden_Fecha >= FDesde &
                                    Ordenes.Orden_Fecha <= FHasta
                              orderby Ordenes.Orden_Fecha
                              select Ordenes;
                    return lst.ToList();
                }
            }
        }

        /*        public List<object> GeneraDataGrid()
                {
                    using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
                    {
                        var Query = from Ordenes in db.L_LibroOrdenes
                                  join tipoOrden in db.M_TipoOrdenes
                                  on Ordenes.Tipo_Orden equals tipoOrden.Codigo
                                  join cliente in db.C_Clientes
                                  on Ordenes.Cliente_Cod equals cliente.Codigo
                                  orderby Ordenes.Cliente_Cod, Ordenes.Fecha_Orden
                                  select new { Ordenes.Secuencia, tipoOrden.Descripcion, cliente.Nombre}; 

                        return Query;

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
    }
}
