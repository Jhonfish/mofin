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
    
    public partial class O_OperTransaccionales
    {
        public string Tipo_Orden { get; set; }
        public System.DateTime Fec_Pacto { get; set; }
        public string Doc_ID { get; set; }
        public string Cod_Cliente { get; set; }
        public string Nme_Cliente { get; set; }
        public Nullable<System.DateTime> Fec_Cierre { get; set; }
        public Nullable<System.DateTime> Fec_Valor { get; set; }
        public Nullable<decimal> Monto_Pactado { get; set; }
        public string Tipo_Operacion { get; set; }
        public Nullable<decimal> Valor_Efectivo { get; set; }
        public string Grp_Cliente { get; set; }
        public string Comprobante { get; set; }
        public Nullable<System.DateTime> Hora_Carga { get; set; }
    }
}