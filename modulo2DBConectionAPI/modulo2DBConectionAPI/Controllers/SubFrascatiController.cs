using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class SubFrascatiController : ApiController
    {
       
            public List<SubAreaFrascati> Get()
            {
                using (VieEntidades entidades = new VieEntidades())
                {
                    entidades.Configuration.ProxyCreationEnabled = false;
                    return entidades.SubAreaFrascati.ToList();
                }
            }


            public List<Pr_SubAreaFrascati_Consultar_Result> Get(string area)
            {
                using (VieEntidades entidades = new VieEntidades())
                {
                    entidades.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_SubAreaFrascati_Consultar_Result> res = entidades.Pr_SubAreaFrascati_Consultar(int.Parse(area));
                return res.ToList();
                }
            }
    }
}
