using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class UbicacionGeograficaController : ApiController
    {

            public List<UbicacionGeografica> Get()
            {
                using (VieEntidades entities = new VieEntidades())
                {
                    entities.Configuration.ProxyCreationEnabled = false;
                    return entities.UbicacionGeografica.ToList();
                }
            }
            public List<Pr_UbicacionGeografica_Seleccionar_Result> Get(String id)
            {
                using (VieEntidades entities = new VieEntidades())
                {
                    entities.Configuration.ProxyCreationEnabled = false;
                  
                    return entities.Pr_UbicacionGeografica_Seleccionar(id).ToList();
                }
            }
            [HttpDelete]

            public List<int?> Delete(int id)
            {
                using (VieEntidades entities = new VieEntidades())
                {
                    entities.Configuration.ProxyCreationEnabled = false;
                    return entities.Pr_UbicacionGeografica_Eliminar(id).ToList();
                }
            }
            [HttpPost]
            public List<Pr_UbicacionGeografica_Insertar_Result> Post(int idPais, Nullable<int> idRegion, Nullable<int> idProvincia, string codigoProyecto)
        {
                using (VieEntidades entities = new VieEntidades())
                {
                    entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_UbicacionGeografica_Insertar(idPais, idRegion, idProvincia, codigoProyecto).ToList();
                }
            }
        
    }
}
