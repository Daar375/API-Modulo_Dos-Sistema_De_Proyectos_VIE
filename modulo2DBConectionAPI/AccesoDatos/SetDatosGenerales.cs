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
    
    public partial class SetDatosGenerales
    {
        public SetDatosGenerales()
        {
            this.EquipoDeTrabajo = new HashSet<EquipoDeTrabajo>();
            this.Proyecto = new HashSet<Proyecto>();
        }
    
        public int Id { get; set; }
        public string NombreDelProyecto { get; set; }
        public System.DateTime FechaInicioEjecucion { get; set; }
        public System.DateTime FechaFinEjecucion { get; set; }
        public string Estado { get; set; }
        public string Justificacion { get; set; }
    
        public virtual ICollection<EquipoDeTrabajo> EquipoDeTrabajo { get; set; }
        public virtual ICollection<Proyecto> Proyecto { get; set; }
    }
}
