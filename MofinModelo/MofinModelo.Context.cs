﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MofinModelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MonitorOperacionesEntities : DbContext
    {
        public MonitorOperacionesEntities()
            : base("name=MonitorOperacionesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Clientes> C_Clientes { get; set; }
        public virtual DbSet<C_FirBenAcc> C_FirBenAcc { get; set; }
        public virtual DbSet<C_HistActClientes> C_HistActClientes { get; set; }
        public virtual DbSet<C_ValorItemConsExp> C_ValorItemConsExp { get; set; }
        public virtual DbSet<M_ActivComercial> M_ActivComercial { get; set; }
        public virtual DbSet<M_Antiguedad> M_Antiguedad { get; set; }
        public virtual DbSet<M_Criptomonedas> M_Criptomonedas { get; set; }
        public virtual DbSet<M_Edad> M_Edad { get; set; }
        public virtual DbSet<M_Estados> M_Estados { get; set; }
        public virtual DbSet<M_NivelRiesgo> M_NivelRiesgo { get; set; }
        public virtual DbSet<M_Pais> M_Pais { get; set; }
        public virtual DbSet<M_PEP> M_PEP { get; set; }
        public virtual DbSet<M_Productos> M_Productos { get; set; }
        public virtual DbSet<M_Profesiones> M_Profesiones { get; set; }
        public virtual DbSet<M_Servicios> M_Servicios { get; set; }
        public virtual DbSet<M_TipoDocID> M_TipoDocID { get; set; }
        public virtual DbSet<M_TipoEstructuraEmpresa> M_TipoEstructuraEmpresa { get; set; }
        public virtual DbSet<M_TipoPersJuridica> M_TipoPersJuridica { get; set; }
        public virtual DbSet<M_VolOperPersJur> M_VolOperPersJur { get; set; }
        public virtual DbSet<M_VolOperPersNat> M_VolOperPersNat { get; set; }
        public virtual DbSet<O_HistPerfOperac> O_HistPerfOperac { get; set; }
        public virtual DbSet<O_Observaciones> O_Observaciones { get; set; }
        public virtual DbSet<B_Buscados> B_Buscados { get; set; }
        public virtual DbSet<O_Operfinancieras> O_Operfinancieras { get; set; }
        public virtual DbSet<O_OperTransaccionales> O_OperTransaccionales { get; set; }
        public virtual DbSet<O_RepOperacional> O_RepOperacional { get; set; }
    }
}
