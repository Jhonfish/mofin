using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;



namespace MofinDatos
{
    public class DC_FirBenAcc
    {
        public void Eliminar(C_FirBenAcc obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_FirBenAcc.Attach(obj);
                db.C_FirBenAcc.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<C_FirBenAcc> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.C_FirBenAcc.ToList();
            }
        }


        public List<C_FirBenAcc> ListarPorCliente(string cliente)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var beneficiarios = from datos in db.C_FirBenAcc
                                    where datos.Cod_Cliente == cliente
                                    select datos;
                return beneficiarios.ToList();
            }
        }

        public C_FirBenAcc Isertar(C_FirBenAcc obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_FirBenAcc.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(C_FirBenAcc obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.C_FirBenAcc.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
