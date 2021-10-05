using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace modulo2DBConectionAPI.Controllers
{
    public class EstadoProyectoController : ApiController
    {
        // GET: EstadoProyecto
        public List<EstadoDeProyecto> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.EstadoDeProyecto.ToList();
            }
        }
    }
}