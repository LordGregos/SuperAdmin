//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admins
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public bool utilizado { get; set; }
    
        public virtual Ciudades Ciudades { get; set; }
    }
}
