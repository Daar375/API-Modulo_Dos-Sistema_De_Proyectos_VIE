
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIEDataAccess;

namespace modulo2DBConectionAPI.Controllers
{
    public class PoblacionController : ApiController
    {
        public List<Poblacion_Beneficiaria> Get()
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Poblacion_Beneficiaria.ToList();
            }
        }
        public List<getPoblaciones_Result> Get(String id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getPoblaciones_Result> res = entities.getPoblaciones(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public int Delete(int id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                int res = entities.eliminarPoblación(id);
                return res;
            }
        }
        [HttpPost]
        public int Post(string codigoProyecto, string poblacion)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                int res = entities.agregarPoblación(codigoProyecto,  poblacion);
                return res;
            }
        }
    }
}
