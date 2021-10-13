using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class PresupuestoController : ApiController
    {
        public List<PresupuestoProyecto> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.PresupuestoProyecto.ToList();
            }
        }
        public List<Pr_PresupuestoProyecto_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_PresupuestoProyecto_Seleccionar_Result> res = entities.Pr_PresupuestoProyecto_Seleccionar(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_PresupuestoProyecto_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_PresupuestoProyecto_Insertar_Result> Post(Nullable<int> idFuenteFinanciamiento, string organizacion, int idPartida, int ano, int monto, string codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_PresupuestoProyecto_Insertar_Result> res = entities.Pr_PresupuestoProyecto_Insertar(idFuenteFinanciamiento,  organizacion,  idPartida,  ano,  monto,  codigoProyecto);
                return res.ToList();
            }
        }
    }
}
