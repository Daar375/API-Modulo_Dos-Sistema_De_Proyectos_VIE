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
    
    public partial class EquipoDeTrabajo
    {
        public EquipoDeTrabajo()
        {
            this.EquipoDeTrabajoXTipoHora = new HashSet<EquipoDeTrabajoXTipoHora>();
        }
    
        public int Id { get; set; }
        public string NumIdentidad { get; set; }
        public int IdSetDatos { get; set; }
        public int IdCondicionDeParticipacion { get; set; }
        public int IdEscuela { get; set; }
        public string AreaConocimiento { get; set; }
        public bool EstaEliminado { get; set; }
    
        public virtual Escuela Escuela { get; set; }
        public virtual Investigador Investigador { get; set; }
        public virtual SetDatosGenerales SetDatosGenerales { get; set; }
        public virtual TipoParticipacion TipoParticipacion { get; set; }
        public virtual ICollection<EquipoDeTrabajoXTipoHora> EquipoDeTrabajoXTipoHora { get; set; }
    }
}
