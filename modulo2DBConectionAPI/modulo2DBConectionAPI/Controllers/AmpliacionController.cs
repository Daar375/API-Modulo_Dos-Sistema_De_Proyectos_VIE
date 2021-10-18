using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using modulo2DBConectionAPI.Models;

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
        [Route("api/ampliacion/AmpliarFecha")]

        public List<int?> Post([FromBody] PostAmpliacionResponce RequestInfo)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_AmpliarFecha(DateTime.Parse(RequestInfo.fechaAprobacion), DateTime.Parse(RequestInfo.nuevaFechaFinalizacion), DateTime.Parse(RequestInfo.viejaFechaFinalizacion), RequestInfo.observaciones, RequestInfo.codigo).ToList();
            }
        }
    }
}
