using AccesoDatos;
using modulo2DBConectionAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class InformeController : ApiController
    {
        public List<Informe> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Informe.ToList();
            }
        }
        public List<Pr_Informe_SeleccionarXProyecto_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Informe_SeleccionarXProyecto_Result> res = entities.Pr_Informe_SeleccionarXProyecto(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Informe_Eliminar(id).ToList();
            }
        }


        [HttpPost]
        [Route("api/informe/agregarinforme")]
        public List<Pr_Informe_Insertar_Result> Post([FromBody] PostInformeResponce RequestInfo)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Informe_Insertar_Result> res = entities.Pr_Informe_Insertar(RequestInfo.tituloInforme,RequestInfo.idTipoInforme, DateTime.Parse(RequestInfo.fechaProgramada), RequestInfo.estado, RequestInfo.memorandoDIP, RequestInfo.observaciones, RequestInfo.codigoProyecto);
                return res.ToList();
            }
        }
    }   
}
