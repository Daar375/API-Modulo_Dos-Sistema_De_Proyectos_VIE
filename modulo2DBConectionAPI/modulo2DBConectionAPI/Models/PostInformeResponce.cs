using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modulo2DBConectionAPI.Models
{
    public class PostInformeResponce
    {
        public string tituloInforme { get; set; }
        public int idTipoInforme { get; set; }
        public string fechaProgramada { get; set; }
        public string estado { get; set; }

        public string memorandoDIP { get; set; }


        public string observaciones { get; set; }
        public string codigoProyecto { get; set; }





    }
}
