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
    
    public partial class AreaFrascati
    {
        public AreaFrascati()
        {
            this.ProyectoXFrascati = new HashSet<ProyectoXFrascati>();
            this.SubAreaFrascati = new HashSet<SubAreaFrascati>();
        }
    
        public int Id { get; set; }
        public string Area { get; set; }
    
        public virtual ICollection<ProyectoXFrascati> ProyectoXFrascati { get; set; }
        public virtual ICollection<SubAreaFrascati> SubAreaFrascati { get; set; }
    }
}
