using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers////////////////////////en construccion
{
    public class CompraController : ApiController
    {
        public List<Compra> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Compra.ToList();
            }
        }
        public List<Pr_Compra_SeleccionarXProyecto_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Compra_SeleccionarXProyecto_Result> res = entities.Pr_Compra_SeleccionarXProyecto(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Compra_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_Compra_Insertar_Result> Post(string nombreProducto, int cantidad, int  precioTotal , string codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_Compra_Insertar_Result> res = entities.Pr_Compra_Insertar(nombreProducto, cantidad, precioTotal, codigoProyecto);
                return res.ToList();
            }
        }
    }
}
