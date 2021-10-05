using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class TipoDepartamentoController : ApiController
    {
        // GET: TipoDepartamento
        public List<TipoDepartamento> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.TipoDepartamento.ToList();
            }
        }
    }
}