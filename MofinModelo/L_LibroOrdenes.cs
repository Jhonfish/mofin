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
    
    public partial class L_LibroOrdenes
    {
        public int ID_Sistema { get; set; }
        public int Secuencia { get; set; }
        public Nullable<byte> Status { get; set; }
        public System.DateTime Orden_Fecha { get; set; }
        public Nullable<short> Orden_Validez { get; set; }
        public short Orden_Tipo { get; set; }
        public string Cliente_Cod { get; set; }
        public string Titulo_Cod { get; set; }
        public Nullable<int> Orden_Nominal { get; set; }
        public Nullable<bool> Orden_PrecMercado { get; set; }
        public Nullable<decimal> Orden_Precio { get; set; }
        public Nullable<decimal> Orden_ValorEfectivo { get; set; }
        public string Cuenta { get; set; }
        public string Aprob_Por { get; set; }
        public Nullable<System.DateTime> Aprob_Fecha { get; set; }
        public Nullable<System.DateTime> Pacto_Fecha { get; set; }
        public Nullable<System.DateTime> Pacto_FecValor { get; set; }
        public Nullable<int> Pacto_Nominal { get; set; }
        public Nullable<decimal> Pacto_Precio { get; set; }
        public Nullable<decimal> Pacto_Valor { get; set; }
        public string Ejecutada_Por { get; set; }
    }
}