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
    
    public partial class O_Operfinancieras
    {
        public int ID_Sistema { get; set; }
        public string Tipo_Orden { get; set; }
        public System.DateTime Fec_Pacto { get; set; }
        public string Doc_ID { get; set; }
        public string Cod_Cliente { get; set; }
        public string Nme_Cliente { get; set; }
        public Nullable<System.DateTime> Fec_Cierre { get; set; }
        public Nullable<System.DateTime> Fec_Valor { get; set; }
        public Nullable<decimal> Mto_Solicitado { get; set; }
        public Nullable<decimal> Mto_Pactado { get; set; }
        public string Cod_Titulo { get; set; }
        public Nullable<decimal> Precio_USD { get; set; }
        public Nullable<decimal> Efectivo { get; set; }
        public Nullable<decimal> Comision_Clie { get; set; }
        public string Cod_Contraparte { get; set; }
        public string Nme_Contraparte { get; set; }
        public string Agencia { get; set; }
        public Nullable<int> Sec_Operac { get; set; }
        public Nullable<int> Cod_Bloq { get; set; }
        public Nullable<int> Nro_OrdBCV { get; set; }
        public string Cta_USD { get; set; }
        public string Comprobante { get; set; }
        public Nullable<System.DateTime> Hora_carga { get; set; }
    }
}
