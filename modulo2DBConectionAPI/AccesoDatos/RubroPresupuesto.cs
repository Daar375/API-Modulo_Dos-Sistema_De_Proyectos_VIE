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
    
    public partial class RubroPresupuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Ano { get; set; }
        public int Monto { get; set; }
        public int IdPlanteamientoProyecto { get; set; }
        public string Justificacion { get; set; }
    
        public virtual PlanteamientoProyecto PlanteamientoProyecto { get; set; }
    }
}