using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;

namespace MofinDatos
{
    public class DOpc_Sistema
    {
        public List<Opc_Sistema> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Opc_Sistema.ToList();
            }
        }

        public Opc_Sistema GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Opc_Sistema.Find(id);
            }
        }

        public void Actualizar(Opc_Sistema obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Opc_Sistema.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
