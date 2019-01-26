//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class C_Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_Clientes()
        {
            this.C_HistActClientes = new HashSet<C_HistActClientes>();
            this.O_HistPerfOperac = new HashSet<O_HistPerfOperac>();
            this.O_Observaciones = new HashSet<O_Observaciones>();
            this.C_FirBenAcc = new HashSet<C_FirBenAcc>();
        }
    
        public int ID_Sistema { get; set; }
        public string Codigo { get; set; }
        public byte TipoPersona { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string Doc_ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<byte> Cliente_Punt { get; set; }
        public Nullable<byte> Benef_Punt { get; set; }
        public Nullable<byte> InfGen_Punt { get; set; }
        public Nullable<byte> ConstExped_Punt { get; set; }
        public Nullable<bool> CondEspSeguridad { get; set; }
        public Nullable<short> IG_PaisNacim { get; set; }
        public Nullable<short> IG_Nacionalidad { get; set; }
        public Nullable<short> IG_PaisResid { get; set; }
        public Nullable<short> IG_Estado { get; set; }
        public Nullable<short> IG_PEP { get; set; }
        public Nullable<short> IG_Profesion { get; set; }
        public Nullable<short> IG_TipDocID { get; set; }
        public Nullable<System.DateTime> IG_FecVencDocID { get; set; }
        public Nullable<short> IG_TipoPersJur { get; set; }
        public Nullable<short> IG_Edad { get; set; }
        public Nullable<short> IG_ActivComer { get; set; }
        public Nullable<short> IG_VolumOperac { get; set; }
        public Nullable<short> IG_Criptomoneda { get; set; }
        public Nullable<short> IG_TipoEstructura { get; set; }
        public Nullable<bool> IG_Servicio1 { get; set; }
        public Nullable<bool> IG_Servicio2 { get; set; }
        public Nullable<bool> IG_Servicio3 { get; set; }
        public Nullable<bool> IG_Servicio4 { get; set; }
        public Nullable<bool> IG_Servicio5 { get; set; }
        public Nullable<bool> IG_Servicio6 { get; set; }
        public Nullable<bool> IG_Servicio7 { get; set; }
        public Nullable<bool> IG_Servicio8 { get; set; }
        public Nullable<bool> IG_Servicio9 { get; set; }
        public Nullable<bool> IG_Servicio10 { get; set; }
        public Nullable<bool> IG_Producto1 { get; set; }
        public Nullable<bool> IG_Producto2 { get; set; }
        public Nullable<bool> IG_Producto3 { get; set; }
        public Nullable<bool> IG_Producto4 { get; set; }
        public Nullable<bool> IG_Producto5 { get; set; }
        public Nullable<bool> IG_Producto6 { get; set; }
        public Nullable<bool> IG_Producto7 { get; set; }
        public Nullable<bool> IG_Producto8 { get; set; }
        public Nullable<bool> IG_Producto9 { get; set; }
        public Nullable<bool> IG_Producto10 { get; set; }
        public Nullable<bool> CE_Opc1 { get; set; }
        public Nullable<bool> CE_Opc2 { get; set; }
        public Nullable<bool> CE_Opc3 { get; set; }
        public Nullable<bool> CE_Opc4 { get; set; }
        public Nullable<bool> CE_Opc5 { get; set; }
        public Nullable<bool> CE_Opc6 { get; set; }
        public Nullable<bool> CE_Opc7 { get; set; }
        public Nullable<bool> CE_Opc8 { get; set; }
        public Nullable<bool> CE_Opc9 { get; set; }
        public Nullable<bool> CE_Opc10 { get; set; }
        public Nullable<bool> CE_Opc11 { get; set; }
        public Nullable<bool> CE_Opc12 { get; set; }
        public Nullable<bool> CE_Opc13 { get; set; }
        public Nullable<bool> CE_Opc14 { get; set; }
        public Nullable<bool> CE_Opc15 { get; set; }
        public Nullable<bool> CE_Opc16 { get; set; }
        public Nullable<bool> CE_Opc17 { get; set; }
        public Nullable<bool> CE_Opc18 { get; set; }
        public Nullable<bool> CE_Opc19 { get; set; }
        public Nullable<bool> CE_Opc20 { get; set; }
        public Nullable<bool> CE_Opc21 { get; set; }
        public Nullable<bool> CE_Opc22 { get; set; }
        public Nullable<bool> CE_Opc23 { get; set; }
        public Nullable<bool> CE_Opc24 { get; set; }
        public Nullable<bool> CE_Opc25 { get; set; }
        public Nullable<bool> CE_Opc26 { get; set; }
        public Nullable<bool> CE_Opc27 { get; set; }
        public Nullable<bool> CE_Opc28 { get; set; }
        public Nullable<bool> CE_Opc29 { get; set; }
        public Nullable<bool> CE_Opc30 { get; set; }
        public string Observacion { get; set; }
        public string Ejecutivo { get; set; }
        public Nullable<short> NivelRiesgo { get; set; }
        public Nullable<decimal> PerfilFinanciero { get; set; }
        public Nullable<byte> PeriodUsoCta { get; set; }
        public Nullable<byte> NroTransacciones { get; set; }
        public Nullable<System.DateTime> Fec_UltimAct { get; set; }
        public Nullable<byte> Trim_Mes { get; set; }
        public Nullable<short> Trim_Ano { get; set; }
        public Nullable<short> Trim_NroOperac { get; set; }
        public Nullable<decimal> Trim_MontoOperac { get; set; }
        public string MapaEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_HistActClientes> C_HistActClientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<O_HistPerfOperac> O_HistPerfOperac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<O_Observaciones> O_Observaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_FirBenAcc> C_FirBenAcc { get; set; }
    }
}
