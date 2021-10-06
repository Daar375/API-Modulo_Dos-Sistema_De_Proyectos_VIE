using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modulo2DBConectionAPI.Models
{
    public class ModificarProyectoResponse
    {
        public string codigoProyecto { get; set; }
        public string nuevoNombre { get; set; }
        public string nuevoObjetivoGeneral { get; set; }
        public string nuevaActaVIE { get; set; }
        public string nuevaActaEscuela { get; set; }
        public string nuevaDescripcion { get; set; }
        public string nuevaJustificacion { get; set; }
    }
}