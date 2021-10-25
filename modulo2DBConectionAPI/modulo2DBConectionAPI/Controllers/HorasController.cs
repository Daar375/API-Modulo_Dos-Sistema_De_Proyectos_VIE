using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
namespace modulo2DBConectionAPI.Controllers
{
    public class HorasController : ApiController
    {


        public List<Pr_Investigador_ConsultHoras_Result> Get(string numIdentidad, string codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Investigador_ConsultHoras(numIdentidad, codigoProyecto).ToList();
            }

        }
        [HttpPost]

        public System.Data.Objects.ObjectResult<Pr_Investigador_AgregarHoras_Result> Post(int idEquipoDeTrabajo, int idTipoHora, string fechaInicio, string fechaFinalizacion, int cantidadHoras)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                    return entities.Pr_Investigador_AgregarHoras(idEquipoDeTrabajo, idTipoHora, DateTime.Parse( fechaInicio), DateTime.Parse(fechaFinalizacion), cantidadHoras);
            }

        }

        [HttpDelete]
        public System.Data.Objects.ObjectResult<int?> Delete(int idHoras)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Investigador_EliminarHoras(idHoras);
            }

        }
    }
}

