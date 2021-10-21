using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using modulo2DBConectionAPI.Models;

namespace modulo2DBConectionAPI.Controllers
{
    public class BitacoraController : ApiController
    {
        public List<EntradaBitacora> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.EntradaBitacora.ToList();
            }
        }
        public List<Pr_EntradaBitacora_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_EntradaBitacora_Seleccionar(id).ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_EntradaBitacora_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        [Route("api/bitacora/AgregarBitacora")]

        public List<Pr_EntradaBitacora_Insertar_Result> Post([FromBody] PostBitacoraResponce RequestInfo)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_EntradaBitacora_Insertar(RequestInfo.descripcion, RequestInfo.responsable, RequestInfo.cedulaResponsable, DateTime.Parse(RequestInfo.fechaYHora) , RequestInfo.codigoProyecto).ToList();
            }
        }
    }
}
