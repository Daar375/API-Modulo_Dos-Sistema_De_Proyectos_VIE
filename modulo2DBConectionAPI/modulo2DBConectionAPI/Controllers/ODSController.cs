using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class ODSController : ApiController
    {
        public List<ODS> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.ODS.ToList();
            }
        }
        public List<Pr_ProyectoXODS_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXODS_Seleccionar_Result> res = entities.Pr_ProyectoXODS_Seleccionar(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_ProyectoXODS_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_ProyectoXODS_Insertar_Result> Post(string codigoProyecto, int idSubODS, int idODS)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXODS_Insertar_Result> res = entities.Pr_ProyectoXODS_Insertar(codigoProyecto, idSubODS, idODS);
                return res.ToList();
            }
        }
    }
}
