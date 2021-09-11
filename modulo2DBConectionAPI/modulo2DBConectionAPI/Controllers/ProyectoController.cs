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

        public List<getProyectos_Result> Get()
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getProyectos_Result> a = entities.getProyectos();
                return a.ToList();
            }
        }
        public List<getProyecto_Result> Get(String id)
        {
            using (VIEEntities entities = new VIEEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<getProyecto_Result> a = entities.getProyecto(id);
                return a.ToList();
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
