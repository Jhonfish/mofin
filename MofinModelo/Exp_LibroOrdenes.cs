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
    
    public partial class Exp_LibroOrdenes
    {
        public int Secuencia { get; set; }
        public string Tipo_Orden { get; set; }
        public string Titulo_Cod { get; set; }
        public string Titulo_Nme { get; set; }
        public string Titulo_ISIN { get; set; }
        public Nullable<System.DateTime> Fecha_Orden { get; set; }
        public Nullable<System.DateTime> Fecha_Venta { get; set; }
        public Nullable<int> Nominal { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Valor_Efect { get; set; }
        public string Cuenta { get; set; }
        public string Cliente_Cod { get; set; }
        public string Cliente_Nme { get; set; }
        public string Cliente_Email { get; set; }
        public string Cliente_Status { get; set; }
        public string Cliente_Ejecutivo { get; set; }
        public string Aprobado_Por { get; set; }
        public Nullable<System.DateTime> Aprobado_Fecha { get; set; }
    }
}