using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

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
        public List<Pr_EntradaBitacora_Insertar_Result> Post(string descripcion, string responsable, System.DateTime fechaYHora, string codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_EntradaBitacora_Insertar(descripcion, responsable, fechaYHora, codigoProyecto).ToList();
            }
        }
    }
}
