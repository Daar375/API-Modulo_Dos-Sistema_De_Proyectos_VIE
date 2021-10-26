using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
namespace modulo2DBConectionAPI.Controllers
{
    public class InvestigadorController : ApiController
    {

        public List<Investigador> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Investigador.ToList();
            }
        }
        public List<Pr_EquipoDeTrabajo_Seleccionar_Result> Get(string id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_EquipoDeTrabajo_Seleccionar(id).ToList();
            }

        }
        [HttpPost]
        public System.Data.Objects.ObjectResult<int?> Post(string codigo, string numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_CambiarInvCoord(codigo, numIdentidad);
            }

        }


        [HttpPost]
        public System.Data.Objects.ObjectResult<Pr_Investigador_AgregarAProy_Result> Post(string numIdentidad, int idSetDatos, int idCondicionDeParticipacion,int idEscuela, string areaConocimiento)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Investigador_AgregarAProy( numIdentidad,  idSetDatos,  idCondicionDeParticipacion,  idEscuela,  areaConocimiento);
            }

        }

        [HttpDelete]
        public System.Data.Objects.ObjectResult<int?> Delete(string numIdentidad, int idSetDatos)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_EliminarInv(numIdentidad, idSetDatos);
            }

        }
    }
}