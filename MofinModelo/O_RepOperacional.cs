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
    
    public partial class O_RepOperacional
    {
        public int ID_Sistema { get; set; }
        public Nullable<System.DateTime> Fec_Generacion { get; set; }
        public Nullable<System.DateTime> Fec_UltOperac { get; set; }
        public string Cod_Cliente { get; set; }
        public string Nme_cliente { get; set; }
        public string Doc_ID { get; set; }
        public string Niv_Riesgo { get; set; }
        public string Period_UsoCta { get; set; }
        public Nullable<short> Nro_Transac { get; set; }
        public Nullable<byte> Perf_NroTransac { get; set; }
        public Nullable<decimal> Porc_Transac { get; set; }
        public Nullable<decimal> Mto_Compras { get; set; }
        public Nullable<decimal> Mto_Ventas { get; set; }
        public Nullable<decimal> Tot_Operaciones { get; set; }
        public Nullable<decimal> Perf_Financiero { get; set; }
        public Nullable<decimal> Porc_Operaciones { get; set; }
        public Nullable<bool> Alarma { get; set; }
        public string Ejecutivo { get; set; }
        public string Comentario { get; set; }
    }
}
