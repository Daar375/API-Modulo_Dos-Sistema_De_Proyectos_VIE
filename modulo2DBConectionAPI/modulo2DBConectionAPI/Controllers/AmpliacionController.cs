using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class AmpliacionController : ApiController
    {
        public List<AmpliacionFechas> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.AmpliacionFechas.ToList();
            }
        }

        [HttpPost]
        public List<int?> Post(System.DateTime fechaAprobacion, System.DateTime nuevaFechaFinalizacion, System.DateTime viejaFechaFinalizacion, string observaciones, string codigo)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_AmpliarFecha(fechaAprobacion, nuevaFechaFinalizacion, viejaFechaFinalizacion, observaciones, codigo).ToList();
            }
        }
    }
}
