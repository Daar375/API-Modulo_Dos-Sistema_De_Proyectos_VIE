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
    
    public partial class Escuela
    {
        public Escuela()
        {
            this.EquipoDeTrabajo = new HashSet<EquipoDeTrabajo>();
            this.InvestigadorXEscuela = new HashSet<InvestigadorXEscuela>();
        }
    
        public int Id { get; set; }
        public string NombreEscuela { get; set; }
        public int IdSede { get; set; }
    
        public virtual ICollection<EquipoDeTrabajo> EquipoDeTrabajo { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual ICollection<InvestigadorXEscuela> InvestigadorXEscuela { get; set; }
    }
}