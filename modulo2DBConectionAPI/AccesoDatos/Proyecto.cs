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
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Compra = new HashSet<Compra>();
            this.Informe = new HashSet<Informe>();
            this.PalabraClave = new HashSet<PalabraClave>();
            this.ProyectoXBeneficiaria = new HashSet<ProyectoXBeneficiaria>();
            this.ProyectoXDepartamento = new HashSet<ProyectoXDepartamento>();
            this.ProyectoXFrascati = new HashSet<ProyectoXFrascati>();
            this.ProyectoXODS = new HashSet<ProyectoXODS>();
        }
    
        public string Codigo { get; set; }
        public int IdTipoProyecto { get; set; }
        public int IdEstadoDeProyecto { get; set; }
        public string ActaVIE { get; set; }
        public string ActaEscuela { get; set; }
        public int IdTipoDeProceso { get; set; }
        public System.DateTime FechaAprobacion { get; set; }
        public Nullable<System.DateTime> FechaSuspension { get; set; }
        public string IdOficialDeProyecto { get; set; }
        public int IdPlanteamientoProyecto { get; set; }
        public int IdSetDatosGenerales { get; set; }
        public int IdModalidad { get; set; }
        public string IdInvestigadorCoordinador { get; set; }
        public System.DateTime FechaIngreso { get; set; }
    
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual EstadoDeProyecto EstadoDeProyecto { get; set; }
        public virtual ICollection<Informe> Informe { get; set; }
        public virtual Investigador Investigador { get; set; }
        public virtual Investigador Investigador1 { get; set; }
        public virtual ModalidadProyecto ModalidadProyecto { get; set; }
        public virtual ICollection<PalabraClave> PalabraClave { get; set; }
        public virtual PlanteamientoProyecto PlanteamientoProyecto { get; set; }
        public virtual SetDatosGenerales SetDatosGenerales { get; set; }
        public virtual TipoDeProceso TipoDeProceso { get; set; }
        public virtual TipoProyecto TipoProyecto { get; set; }
        public virtual ICollection<ProyectoXBeneficiaria> ProyectoXBeneficiaria { get; set; }
        public virtual ICollection<ProyectoXDepartamento> ProyectoXDepartamento { get; set; }
        public virtual ICollection<ProyectoXFrascati> ProyectoXFrascati { get; set; }
        public virtual ICollection<ProyectoXODS> ProyectoXODS { get; set; }
    }
}
