//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MofinModeloEntorno
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grupo_Opciones
    {
        public int ID_Sistema { get; set; }
        public string Cod_Grupo { get; set; }
        public Nullable<bool> Empresas_I { get; set; }
        public Nullable<bool> Empresas_M { get; set; }
        public Nullable<bool> Empresas_E { get; set; }
        public Nullable<bool> Empresas_P { get; set; }
        public Nullable<bool> Grupos_I { get; set; }
        public Nullable<bool> Grupos_M { get; set; }
        public Nullable<bool> Grupos_E { get; set; }
        public Nullable<bool> Grupos_P { get; set; }
        public Nullable<bool> Usuarios_I { get; set; }
        public Nullable<bool> Usuarios_M { get; set; }
        public Nullable<bool> Usuarios_E { get; set; }
        public Nullable<bool> Usuarios_P { get; set; }
        public Nullable<bool> TabMaestras_I { get; set; }
        public Nullable<bool> TabMaestras_M { get; set; }
        public Nullable<bool> TabMaestras_E { get; set; }
        public Nullable<bool> TabMaestras_P { get; set; }
    
        public virtual Grupos Grupos { get; set; }
    }
}
