//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class NivelDeResponsabilidad
    {
        public NivelDeResponsabilidad()
        {
            this.ProductoObjetivo = new HashSet<ProductoObjetivo>();
        }
    
        public int Id { get; set; }
        public string NivelDeResponsabilidad1 { get; set; }
    
        public virtual ICollection<ProductoObjetivo> ProductoObjetivo { get; set; }
    }
}
