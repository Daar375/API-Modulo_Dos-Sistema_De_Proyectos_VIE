using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class FrascatiController : ApiController
    {
        public List<AreaFrascati> Get()
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                return entidades.AreaFrascati.ToList();
            }
        }
        public List<Pr_ProyectoXFrascati_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXFrascati_Seleccionar_Result> res = entidades.Pr_ProyectoXFrascati_Seleccionar(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<int?> res = entidades.Pr_ProyectoXFrascati_Eliminar(id);
                return res.ToList();
            }
        }
        [HttpPost]
        public List<Pr_ProyectoXFrascati_Insertar_Result> Post(string codigoProyecto, int area, int subArea)
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXFrascati_Insertar_Result> res = entidades.Pr_ProyectoXFrascati_Insertar(codigoProyecto, area, subArea);
                return res.ToList();
            }
        }
    }
}
