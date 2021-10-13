using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class ColaboradoresController : ApiController
    {
        public List<Colaborador> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Colaborador.ToList();
            }
        }
        public List<Pr_Colaborador_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Colaborador_Seleccionar().ToList();
            }

        }
    }
}