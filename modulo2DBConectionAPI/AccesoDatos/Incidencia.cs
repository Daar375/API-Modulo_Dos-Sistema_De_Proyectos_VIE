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
    
    public partial class Incidencia
    {
        public int Id { get; set; }
        public string TituloIncidencia { get; set; }
        public string Descripcion { get; set; }
        public string CodigoProyecto { get; set; }
    
        public virtual Proyecto Proyecto { get; set; }
    }
}
