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
    
    public partial class UbicacionGeografica
    {
        public int Id { get; set; }
        public int IdPais { get; set; }
        public Nullable<int> IdRegion { get; set; }
        public Nullable<int> IdProvincia { get; set; }
        public string CodigoProyecto { get; set; }
    
        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        public virtual Region Region { get; set; }
    }
}
