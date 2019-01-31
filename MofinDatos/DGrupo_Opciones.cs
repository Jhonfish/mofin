using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;


namespace MofinDatos
{
    public class DGrupo_Opciones
    {
        public void Eliminar(Grupo_Opciones obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Grupo_Opciones.Attach(obj);
                db.Grupo_Opciones.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Grupo_Opciones> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Grupo_Opciones.ToList();
            }
        }

        public Grupo_Opciones GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Grupo_Opciones.Find(id);
            }
        }
        public List<Grupo_Opciones> ListarPorCodigo(string Codigo)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                var lst = from Grupo_Opciones in db.Grupo_Opciones
                          where Grupo_Opciones.Cod_Grupo == Codigo
                          select Grupo_Opciones;
                return lst.ToList();
            }
        }

        public Grupo_Opciones Isertar(Grupo_Opciones obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Grupo_Opciones.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(Grupo_Opciones obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Grupo_Opciones.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
