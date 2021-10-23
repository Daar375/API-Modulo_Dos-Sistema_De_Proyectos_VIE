﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
namespace modulo2DBConectionAPI.Controllers
{
    public class InvestigadorController : ApiController
    {

        public List<Investigador> Get()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Investigador.ToList();
            }
        }
        public List<Pr_EquipoDeTrabajo_Seleccionar_Result> Get(string id)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_EquipoDeTrabajo_Seleccionar(id).ToList();
            }

        }
        [HttpPost]

        public System.Data.Objects.ObjectResult<int?> Post(string codigo, string numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Pr_Proyecto_CambiarInvCoord(codigo, numIdentidad);
            }

        }
    }
}