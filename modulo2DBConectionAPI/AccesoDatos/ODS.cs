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
    
    public partial class ODS
    {
        public ODS()
        {
            this.ProyectoXODS = new HashSet<ProyectoXODS>();
            this.SubODS = new HashSet<SubODS>();
        }
    
        public int Id { get; set; }
        public string ODS1 { get; set; }
    
        public virtual ICollection<ProyectoXODS> ProyectoXODS { get; set; }
        public virtual ICollection<SubODS> SubODS { get; set; }
    }
}