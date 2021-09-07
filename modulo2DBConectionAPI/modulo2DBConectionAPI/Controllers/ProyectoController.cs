using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIEDataAccess;
using System.Data.Entity;

namespace modulo2DBConectionAPI.Controllers
{
    public class ProyectoController : ApiController
    {

        public List<Proyecto> Get()
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Proyecto.ToList();
            }
        }
        public Proyecto Get(String id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Proyecto.FirstOrDefault(e => e.codigo == id);
            }
        }
        public List<getProyectosPorBusqueda_Result> Get(String criterioBusqueda, String parametros)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getProyectosPorBusqueda_Result> a = entities.getProyectosPorBusqueda(criterioBusqueda, parametros);
                return a.ToList();
            }
        }
    }
}
