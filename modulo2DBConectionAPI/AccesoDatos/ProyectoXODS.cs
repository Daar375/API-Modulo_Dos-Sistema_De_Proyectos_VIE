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
    
    public partial class ProyectoXODS
    {
        public int Id { get; set; }
        public string CodigoProyecto { get; set; }
        public int IdSubODS { get; set; }
        public int IdODS { get; set; }
    
        public virtual ODS ODS { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        public virtual SubODS SubODS { get; set; }
    }
}