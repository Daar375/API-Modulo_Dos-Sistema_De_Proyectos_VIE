//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIEDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Frascati = new HashSet<Frascati>();
            this.Objetivo = new HashSet<Objetivo>();
            this.ODS = new HashSet<ODS>();
            this.Poblacion_Beneficiaria = new HashSet<Poblacion_Beneficiaria>();
        }
    
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public string objetivoGeneral { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
        public Nullable<System.DateTime> fechaSuspension { get; set; }
        public string oficialDeProyecto { get; set; }
        public string modalidad { get; set; }
        public string numeroDeActaVIE { get; set; }
        public string numeroDeActaEscuela { get; set; }
        public Nullable<System.DateTime> fechaAprobación { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFinalizacion { get; set; }
        public string investigadorCoordinador { get; set; }
        public string descripcion { get; set; }
        public string justificacion { get; set; }
    
        public virtual ICollection<Frascati> Frascati { get; set; }
        public virtual ICollection<Objetivo> Objetivo { get; set; }
        public virtual ICollection<ODS> ODS { get; set; }
        public virtual ICollection<Poblacion_Beneficiaria> Poblacion_Beneficiaria { get; set; }
    }
}
