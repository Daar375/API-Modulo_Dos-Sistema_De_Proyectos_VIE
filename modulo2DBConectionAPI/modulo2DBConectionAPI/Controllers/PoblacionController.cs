
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using System.Data.Objects;

namespace modulo2DBConectionAPI.Controllers
{
    public class PoblacionController : ApiController
    {
        public List<PoblacionBeneficiaria> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.PoblacionBeneficiaria.ToList();
            }
        }
        public List<Pr_ProyectoXBeneficiaria_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
               ObjectResult<Pr_ProyectoXBeneficiaria_Seleccionar_Result> res = entities.Pr_ProyectoXBeneficiaria_Seleccionar(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return  entities.Pr_ProyectoXBeneficiaria_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_ProyectoXBeneficiaria_Insertar_Result> Post(string codigoProyecto, int poblacion)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXBeneficiaria_Insertar_Result> res = entities.Pr_ProyectoXBeneficiaria_Insertar(codigoProyecto, poblacion);
                return res.ToList();
            }
        }
    }
}
