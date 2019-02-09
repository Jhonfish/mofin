using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;



namespace MofinDatos
{
    public class DGrupos
    {
        public void Eliminar(Grupos obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Grupos.Attach(obj);
                db.Grupos.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Grupos> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Grupos.ToList();
            }
        }

        public Grupos GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Grupos.Find(id);
            }
        }
        public string GetNombre(string Codigo)
        {
            if (Codigo == "1972")
                return "CREADOR";
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                var Grp_Nme = from Grupos in db.Grupos
                          where Grupos.Codigo == Codigo
                          select Grupos.Nombre;
                return Grp_Nme.First();
            }
        }
        public List<Grupos> ListarPorCodigo(string Codigo)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                var lst = from Grupos in db.Grupos
                          where Grupos.Codigo == Codigo
                          select Grupos;
                return lst.ToList();
            }
        }

        public Grupos Isertar(Grupos obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Grupos.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(Grupos obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Grupos.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
