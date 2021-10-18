using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modulo2DBConectionAPI.Models
{
    public class PostAmpliacionResponce
    {
        public string fechaAprobacion { get; set; }
        public string nuevaFechaFinalizacion { get; set; }
        public string viejaFechaFinalizacion { get; set; }
        public string observaciones { get; set; }

        public string codigo { get; set; }

    }
}
