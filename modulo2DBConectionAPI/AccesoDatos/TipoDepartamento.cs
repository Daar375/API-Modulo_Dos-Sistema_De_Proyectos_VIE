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
    
    public partial class TipoDepartamento
    {
        public TipoDepartamento()
        {
            this.ProyectoXDepartamento = new HashSet<ProyectoXDepartamento>();
        }
    
        public int Id { get; set; }
        public string TipoDepartamento1 { get; set; }
    
        public virtual ICollection<ProyectoXDepartamento> ProyectoXDepartamento { get; set; }
    }
}
