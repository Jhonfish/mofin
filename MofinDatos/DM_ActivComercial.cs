﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MofinModelo;


namespace MofinDatos
{
    public class DM_ActivComercial
    {
        public void Eliminar(M_ActivComercial obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_ActivComercial.Attach(obj);
                db.M_ActivComercial.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<M_ActivComercial> Listar()
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_ActivComercial.ToList();
            }
        }

        public M_ActivComercial GetById(int id)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                return db.M_ActivComercial.Find(id);
            }
        }

        public List<M_ActivComercial> ListarPorCodigo(short codigo)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                var registros = from datos in db.M_ActivComercial
                                where datos.Codigo == codigo
                                select datos;
                return registros.ToList();
            }
        }

        public M_ActivComercial Isertar(M_ActivComercial obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_ActivComercial.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Actualizar(M_ActivComercial obj)
        {
            using (MonitorOperacionesEntities db = new MonitorOperacionesEntities())
            {
                db.M_ActivComercial.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
