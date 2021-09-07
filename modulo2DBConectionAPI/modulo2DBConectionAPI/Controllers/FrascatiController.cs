using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIEDataAccess;

namespace modulo2DBConectionAPI.Controllers
{
    public class FrascatiController : ApiController
    {
        public List<Frascati> Get()
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Frascati.ToList();
            }
        }
        public List<getFrascati_Result> Get(String id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getFrascati_Result> res = entities.getFrascati(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public int Delete(int id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                int res = entities.eliminarFrascati(id);
                return res;
            }
        }
        [HttpPost]
        public int Post(string codigoProyecto, string area, string subArea)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                int res = entities.agregarFrascati(codigoProyecto,area,subArea);
                return res;
            }
        }
    }
}
