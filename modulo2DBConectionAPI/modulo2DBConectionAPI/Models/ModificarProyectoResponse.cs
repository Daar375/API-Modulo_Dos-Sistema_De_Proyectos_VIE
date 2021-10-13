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

        public string nuevaFechaIngreso { get; set; }

        public int nuevoIdEstado { get; set; }
        public int nuevoIdTipoProyecto { get; set; }

        public int nuevoIdTipoProceso { get; set; }

        public int nuevoIdModalidad { get; set; }
        public string nuevaFechaAprobacion { get; set; }

        public string nuevaFechaInicio { get; set; }


    }
}

