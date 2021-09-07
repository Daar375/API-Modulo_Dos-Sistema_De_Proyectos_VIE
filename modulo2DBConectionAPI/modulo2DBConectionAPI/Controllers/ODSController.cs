using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIEDataAccess;

namespace modulo2DBConectionAPI.Controllers
{
    public class ODSController : ApiController
    {
        public List<ODS> Get()
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.ODS.ToList();
            }
        }
        public List<getODS_Result> Get(String id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getODS_Result> res = entities.getODS(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public int Delete(int id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                int res = entities.eliminarODS(id);
                return res;
            }
        }
        [HttpPost]
        public int Post(string codigoProyecto, string area, string subArea)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                int res = entities.agregarODS(codigoProyecto, area, subArea);
                return res;
            }
        }
    }
}
