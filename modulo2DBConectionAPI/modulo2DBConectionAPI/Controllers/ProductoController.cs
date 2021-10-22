using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace modulo2DBConectionAPI.Controllers
{
    public class ProductoController : ApiController
    {

        public List<ProductoObjetivo> Get()
        {
            using (VieEntidades entidades = new VieEntidades())
            {
                entidades.Configuration.ProxyCreationEnabled = false;
                return entidades.ProductoObjetivo.ToList();
            }
        }

                public List<Pr_ProductoObjetivo_Seleccionar_Result> Get(String id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                System.Data.Objects.ObjectResult<Pr_ProductoObjetivo_Seleccionar_Result> res = entities.Pr_ProductoObjetivo_Seleccionar(id);
                return res.ToList();
            }
        }
    
    [HttpDelete]
    public List<String> Delete(int id)
    {
        using (VieEntidades entities = new VieEntidades())
        {
            entities.Configuration.ProxyCreationEnabled = false;
            return entities.Pr_ProductoObjetivo_Eliminar(id).ToList();
        }
    }
    [HttpPost]
   public List<Pr_ProductoObjetivo_Insertar_Result> Post(string actividad, string idInvestigadorEncargado, int idColaboradorEncargado, int idNivelDeResponsabilidad, string nombre, int idObjetivoEspecifico, int ano, int trimestre,string fecha)
        {
        using (VieEntidades entities = new VieEntidades())
        {
            entities.Configuration.ProxyCreationEnabled = false;
            System.Data.Objects.ObjectResult<Pr_ProductoObjetivo_Insertar_Result> res = entities.Pr_ProductoObjetivo_Insertar( actividad,  idInvestigadorEncargado,idColaboradorEncargado,idNivelDeResponsabilidad,nombre,idObjetivoEspecifico,ano,trimestre, DateTime.Parse(fecha) );
            return res.ToList();
        }
    }

    }
}
