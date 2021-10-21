using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using modulo2DBConectionAPI.Models;

namespace modulo2DBConectionAPI.Controllers
{
    [RoutePrefix("api/Investigador")]
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
        [HttpGet]
        [Route("GetNombre/{nombre}")]
        public List<Pr_Investigador_Buscar_Result> Get(String nombre)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_Buscar(nombre).ToList();
            }
        }
        [HttpGet]
        [Route("GetIdentidad/{numIdentidad}")]
        public List<Pr_Investigador_Consultar_Result> GetIdentidad(String numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_Consultar(numIdentidad).ToList();
            }
        }
        [HttpGet]
        [Route("ConsultarHoras/{numIdentidad}/{codigoProyecto}")]
        public List<Pr_Investigador_ConsultHoras_Result> ConsultarHoras(String numIdentidad, String codigoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_ConsultHoras(numIdentidad, codigoProyecto).ToList();
            }
        }

        [HttpPost]
        [Route("SeleccionarDiciplina/{estado}/{diciplina}")]
        public List<Pr_Investigador_DiscipSelect_Result> SeleccionarDiciplina(String estado, int diciplina)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_DiscipSelect(estado, diciplina).ToList();
            }
        }

        [HttpPost]
        [Route("SeleccionarEscuela/{estado}/{escuela}")]
        public List<Pr_Investigador_EscuelaSelect_Result> SeleccionarEscuela(String estado, int escuela)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_EscuelaSelect(estado, escuela).ToList();
            }
        }

        [HttpPost]
        [Route("SeleccionarEstado/{estado}")]
        public List<Pr_Investigador_EstadoSelect_Result> SeleccionarEstado(String estado)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_EstadoSelect(estado).ToList();
            }
        }

        [HttpPost]
        [Route("DiscipliInvestigador/{numIdentidad}")]
        public List<Pr_Investigador_SelectDiscip_Result> DiscipliInvestigador(String numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_SelectDiscip(numIdentidad).ToList();
            }
        }


        [HttpPost]
        [Route("EscuelaInvestigador/{numIdentidad}")]
        public List<Pr_Investigador_SelectEscuela_Result> EscuelaInvestigador(String numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_SelectEscuela(numIdentidad).ToList();
            }
        }


        [HttpPost]
        [Route("IdiomasInvestigador/{numIdentidad}")]
        public List<Pr_Investigador_SelectIdiomas_Result> IdiomasInvestigador(String numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_SelectIdiomas(numIdentidad).ToList();
            }
        }

    }
}
