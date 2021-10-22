using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class IncidenciasCOntroller : ApiController
    {

        public List<Incidencia> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Incidencia.ToList();
            }
        }
        public List<Pr_Incidencias_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Incidencias_Seleccionar(id).ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Incidencia_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_Incidencia_Insertar_Result> Post(string tituloIncidencia, string descripcion, string codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Incidencia_Insertar(tituloIncidencia, descripcion,  codigoProyecto).ToList();
            }
        }

    }
}
