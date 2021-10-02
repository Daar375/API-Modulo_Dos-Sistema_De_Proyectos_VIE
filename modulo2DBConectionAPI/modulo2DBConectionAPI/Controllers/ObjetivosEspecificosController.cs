using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class ObjetivosEspecificosController : ApiController
    {
        public List<ObjetivoEspecifico> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.ObjetivoEspecifico.ToList();
            }
        }
        
        public List<string> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<string> res = entities.Pr_ObjetivoEspecifico_Seleccionar(id);
                return res.ToList();
            }
        }


    }
}
