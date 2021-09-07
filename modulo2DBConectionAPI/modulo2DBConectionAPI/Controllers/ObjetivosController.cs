using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIEDataAccess;

namespace modulo2DBConectionAPI.Controllers
{
    public class ObjetivosController : ApiController
    {
        public List<Objetivo> Get()
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Objetivo.ToList();
            }
        }
        public List<getObjetivos_Result> Get(String id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getObjetivos_Result> res = entities.getObjetivos(id);
                return res.ToList();
            }
        }


    }
}
