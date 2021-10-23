using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class RiesgoController : ApiController
    {
        public List<Riesgo> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Riesgo.ToList();
            }
        }
        public List<Pr_Riesgo_Seleccionar_Result> Get(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Riesgo_Seleccionar(id).ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Riesgo_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_Riesgo_Insertar_Result> Post(string nombre, string accionesMitagacion, int idObjetivoEspecifico)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Riesgo_Insertar(nombre, accionesMitagacion,  idObjetivoEspecifico).ToList();
            }
        }
    }
}
