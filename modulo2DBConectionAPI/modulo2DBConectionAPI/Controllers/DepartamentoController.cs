using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class DepartamentoController : ApiController
    {
        public List<Departamento> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Departamento.ToList();
            }
        }
        public List<Pr_ProyectoXDepartamentos_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXDepartamentos_Seleccionar_Result> res = entities.Pr_ProyectoXDepartamentos_Seleccionar(id);
                return res.ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_ProyectoXDepartamento_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_ProyectoXDepartamento_Insertar_Result> Post(string codigoProyecto, int  idDepartamento, int idTipoDepartamento)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProyectoXDepartamento_Insertar_Result> res = entities.Pr_ProyectoXDepartamento_Insertar(codigoProyecto, idDepartamento, idTipoDepartamento);
                return res.ToList();
            }
        }
    }
}
