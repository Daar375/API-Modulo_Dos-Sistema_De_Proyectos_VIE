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
    
    public partial class SubAreaFrascati
    {
        public SubAreaFrascati()
        {
            this.ProyectoXFrascati = new HashSet<ProyectoXFrascati>();
        }
    
        public int Id { get; set; }
        public int IdAreaFrascati { get; set; }
        public string SubArea { get; set; }
    
        public virtual AreaFrascati AreaFrascati { get; set; }
        public virtual ICollection<ProyectoXFrascati> ProyectoXFrascati { get; set; }
    }
}