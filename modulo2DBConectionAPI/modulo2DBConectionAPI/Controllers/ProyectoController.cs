using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AccesoDatos;
using System.Data.Entity;
using System.IO;
using modulo2DBConectionAPI.Models;

namespace modulo2DBConectionAPI.Controllers
{
    public class ProyectoController : ApiController
    {

        public List<Pr_Proyecto_Seleccionar_Result> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Proyecto_Seleccionar_Result> res = entities.Pr_Proyecto_Seleccionar();
                return res.ToList();
            }
        }
        public List<Pr_Proyecto_Consultar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Proyecto_Consultar_Result> res = entities.Pr_Proyecto_Consultar(id);
                return res.ToList();
            }
        }
        public List<Pr_Proyecto_Buscar_Result> Get(String criterioBusqueda, String parametros)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Proyecto_Buscar_Result> res = entities.Pr_Proyecto_Buscar(criterioBusqueda, parametros);
                return res.ToList();
            }
        }

        [HttpPost]
        [Route("api/proyecto/ModificarProyecto")]
        public List<int?> ModificarProyecto([FromBody] ModificarProyectoResponse RequestInfo)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_Modificar(RequestInfo.codigoProyecto, RequestInfo.nuevoNombre, RequestInfo.nuevoObjetivoGeneral, RequestInfo.nuevaActaVIE, RequestInfo.nuevaActaEscuela, RequestInfo.nuevaDescripcion, RequestInfo.nuevaJustificacion).ToList();
            }
        }
    }
}
