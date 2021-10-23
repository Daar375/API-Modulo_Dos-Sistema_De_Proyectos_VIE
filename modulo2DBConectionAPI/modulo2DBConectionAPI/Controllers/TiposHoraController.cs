using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class TipoHoraController : ApiController
    {

        public List<TipoHora> Get()
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                return entidades.TipoHora.ToList();
            }
        }



    }
}
