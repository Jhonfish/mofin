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
    
    public partial class O_HistPerfOperac
    {
        public int ID_Sistema { get; set; }
        public byte Tipo_Perfil { get; set; }
        public string Cod_Cliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Mto_Perfil { get; set; }
        public byte Nro_Transacciones { get; set; }
        public string Nivel_Riesgo { get; set; }
    
        public virtual C_Clientes C_Clientes { get; set; }
    }
}
