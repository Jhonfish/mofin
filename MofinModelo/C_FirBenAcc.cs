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
    
    public partial class C_FirBenAcc
    {
        public int ID_Sistema { get; set; }
        public string Cod_Cliente { get; set; }
        public Nullable<byte> TipoVinculo { get; set; }
        public string Doc_ID { get; set; }
        public Nullable<System.DateTime> Fec_Vencimiento { get; set; }
        public string Nombre { get; set; }
        public Nullable<short> Edad { get; set; }
        public Nullable<short> PaisNacim { get; set; }
        public Nullable<short> Nacionalidad { get; set; }
        public Nullable<short> PaisResid { get; set; }
        public Nullable<short> Estado { get; set; }
        public Nullable<short> Profesion { get; set; }
        public Nullable<short> Criptomoneda { get; set; }
        public string VincEmpresa { get; set; }
        public Nullable<byte> VincPorcent { get; set; }
        public Nullable<short> PEP { get; set; }
        public Nullable<short> Puntuacion { get; set; }
        public Nullable<bool> CondEspSeguridad { get; set; }
    
        public virtual C_Clientes C_Clientes { get; set; }
    }
}