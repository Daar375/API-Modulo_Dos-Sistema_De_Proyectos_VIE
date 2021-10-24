using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
namespace modulo2DBConectionAPI.Controllers
{
    public class ActividadesController : ApiController
    {


        public List<Pr_Proyecto_SelectActividades_Result> Get(string codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_SelectActividades(codigoProyecto).ToList();
            }

        }

    }
}

