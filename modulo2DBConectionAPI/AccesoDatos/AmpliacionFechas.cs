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
    
    public partial class AmpliacionFechas
    {
        public int id { get; set; }
        public System.DateTime FechaAprobacion { get; set; }
        public System.DateTime NuevaFechaFinalizacion { get; set; }
        public Nullable<System.DateTime> ViejaFechaFinalizacion { get; set; }
        public string Observaciones { get; set; }
        public string CodigoProyecto { get; set; }
    
        public virtual Proyecto Proyecto { get; set; }
    }
}
