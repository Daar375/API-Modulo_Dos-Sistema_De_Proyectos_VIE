using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class subODSController : ApiController
    {
        public List<SubODS> Get()
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                return entidades.SubODS.ToList();
            }
        }


        public List<Pr_SubODS_Consultar1_Result> Get(string ods)
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_SubODS_Consultar1_Result> res = entidades.Pr_SubODS_Consultar1(int.Parse(ods));
                return res.ToList();
            }
        }
    }
}
