using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class FuenteController : ApiController
    {

        public List<FuenteFinanciamiento> Get()
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                return entidades.FuenteFinanciamiento.ToList();
            }
        }


        /*    [HttpPost]
            public List<Pr_ProyectoXFrascati_Insertar_Result> Post(string codigoProyecto, int area, int subArea)
            {
                using (VieEntidades entidades = new VieEntidades())
                {
                    entidades.Configuration.ProxyCreationEnabled = false;
                    System.Data.Objects.ObjectResult<Pr_ProyectoXFrascati_Insertar_Result> res = entidades.Pr_ProyectoXFrascati_Insertar(codigoProyecto, subArea, area);
                    return res.ToList();
                }
            }*/
    }
}
