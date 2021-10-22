using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class CoordinadorController : ApiController
    {

        public System.Data.Objects.ObjectResult<int?> Post(string codigo, string numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_CambiarInvCoord(codigo, numIdentidad);
            }

        }


    }
}