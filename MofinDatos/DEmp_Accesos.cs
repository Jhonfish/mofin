﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModeloEntorno;



namespace MofinDatos
{
    public class DEmp_Accesos
    {
        public void Eliminar(Emp_Accesos obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Emp_Accesos.Attach(obj);
                db.Emp_Accesos.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Emp_Accesos> Listar()
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Emp_Accesos.ToList();
            }
        }

        public Emp_Accesos GetById(int id)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                return db.Emp_Accesos.Find(id);
            }
        }

        public Emp_Accesos Isertar(Emp_Accesos obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Emp_Accesos.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(Emp_Accesos obj)
        {
            using (MofinEntornoEntidad db = new MofinEntornoEntidad())
            {
                db.Emp_Accesos.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
