using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;

namespace modulo2DBConectionAPI.Controllers
{
    public class MetasController : ApiController
    {
        public List<Meta> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Meta.ToList();
            }
        }
        public List<Pr_Meta_Seleccionar_Result> Get(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Meta_Seleccionar(id).ToList();
            }
        }
        [HttpDelete]

        public List<int?> Delete(int id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Meta_Eliminar(id).ToList();
            }
        }
        [HttpPost]
        public List<Pr_Meta_Insertar_Result> Post(string nombre, string estaCumplida, int idObjectivoEspecifico,string descripcion)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Meta_Insertar(nombre, false, idObjectivoEspecifico,descripcion).ToList();
            }
        }
    }
}
