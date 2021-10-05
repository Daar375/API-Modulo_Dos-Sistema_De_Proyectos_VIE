using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class PalabrasClaveController : ApiController
    {
        public List<PalabraClave> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.PalabraClave.ToList();
            }
        }
        public List<Pr_PalabrasClave_SeleccionarXProyecto_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_PalabrasClave_SeleccionarXProyecto_Result> res = entities.Pr_PalabrasClave_SeleccionarXProyecto(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_PalabraClave_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_PalabraClave_Insertar_Result> Post(string codigoProyecto, string palabraClave)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_PalabraClave_Insertar_Result> res = entities.Pr_PalabraClave_Insertar( palabraClave, codigoProyecto);
                return res.ToList();
            }
        }
    }
}
