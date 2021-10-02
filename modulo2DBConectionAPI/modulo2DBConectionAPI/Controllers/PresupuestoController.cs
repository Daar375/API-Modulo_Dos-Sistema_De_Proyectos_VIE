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
        public List<RubroPresupuesto> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.RubroPresupuesto.ToList();
            }
        }
        public List<Pr_RubroPresupuesto_SeleccionarXProyecto_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_RubroPresupuesto_SeleccionarXProyecto_Result> res = entities.Pr_RubroPresupuesto_SeleccionarXProyecto(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_RubroPresupuesto_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_RubroPresupuesto_Insertar_Result> Post(string codigoProyecto, string nombre, int ano, int monto, string justificacion)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_RubroPresupuesto_Insertar_Result> res = entities.Pr_RubroPresupuesto_Insertar(nombre, ano, monto, codigoProyecto, justificacion);
                return res.ToList();
            }
        }
    }
}
