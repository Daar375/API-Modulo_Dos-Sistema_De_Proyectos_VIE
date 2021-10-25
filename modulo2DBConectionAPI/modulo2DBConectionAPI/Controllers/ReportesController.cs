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
    [RoutePrefix("api/Reportes")]
    public class ReportesController : ApiController
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

        [HttpPost]
        [Route("ReporteBeneficiaria/{estadoBusqueda}/{idBeneficiaria}")]
        public List<Pr_Proyecto_ReporteBeneficiaria_Result> ReporteBeneficiaria(string estadoBusqueda, int idBeneficiaria)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteBeneficiaria(estadoBusqueda, idBeneficiaria).ToList();
            }
        }
        [HttpPost]
        [Route("ReporteBeneficiaria/{fechaRangoInicio}/{fechaRangoFinal}/{idDepartamento}/{idTipoDepartamento}/{estadoBusqueda}")]
        public List<Pr_Proyecto_ReporteEscuelas_Result> ResporteEscuelas(System.DateTime fechaRangoInicio, System.DateTime fechaRangoFinal,int idDepartamento,int idTipoDepartamento, string estadoBusqueda)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteEscuelas(fechaRangoInicio,  fechaRangoFinal,  idDepartamento,  idTipoDepartamento,  estadoBusqueda).ToList();
            }
        }

        [HttpPost]
        [Route("ResporteEstado/{estado}")]
        public List<Pr_Proyecto_ReporteEstado_Result> ResporteEstado(string estado)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteEstado(estado).ToList();
            }
        }

        [HttpPost]
        [Route("ResporteHoras/{fechaRangoInicio}/{fechaRangoFinal}/{idDepartamento}/{idTipoDepartamento}/{estadoBusqueda}")]
        public List<Pr_Proyecto_ReporteHoras_Result> ResporteHoras(System.DateTime fechaRangoInicio, System.DateTime fechaRangoFinal, int idDepartamento, int idTipoDepartamento, string estadoBusqueda)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteHoras(fechaRangoInicio, fechaRangoFinal, idDepartamento, idTipoDepartamento, estadoBusqueda).ToList();
            }
        }

        [HttpPost]
        [Route("ResporteModalidad/{estadoBusqueda}/{idModalidadProyecto}")]
        public List<Pr_Proyecto_ReporteModalidad_Result> ResporteModalidad(string estadoBusqueda, int idModalidadProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteModalidad(estadoBusqueda, idModalidadProyecto).ToList();
            }
        }

        [HttpPost]
        [Route("ReportePresupuesto/{fechaRangoInicio}/{fechaRangoFinal}/{idDepartamento}/{idTipoDepartamento}/{estadoBusqueda}")]
        public List<Pr_Proyecto_ReportePresup_Result> ReportePresupuesto(System.DateTime fechaRangoInicio, System.DateTime fechaRangoFinal, int idDepartamento, int idTipoDepartamento, string estadoBusqueda)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReportePresup(fechaRangoInicio,  fechaRangoFinal,  idDepartamento,  idTipoDepartamento,  estadoBusqueda).ToList();
            }
        }

        [HttpPost]
        [Route("ReporteUbicacion/{estadoBusqueda}/{idPais}/{idRegion}/{idProvinvia}/{estadoBusqueda}")]
        public List<Pr_Proyecto_ReporteUbicacion_Result> ReporteUbicacion(string estadoBusqueda, int idPais, Nullable<int> idRegion, Nullable<int> idProvinvia)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteUbicacion(estadoBusqueda, idPais, idRegion, idProvinvia).ToList();
            }
        }

        [HttpPost]
        [Route("ReporteTIpoProyecto/{estadoBusqueda}/{idTipoProyecto}")]
        public List<Pr_Proyecto_ReporteTipoProy_Result> ReporteTIpoProyecto(string estadoBusqueda, int idTipoProyecto)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_ReporteTipoProy( estadoBusqueda,  idTipoProyecto).ToList();
            }
        }

        [HttpPost]
        [Route("InvestigadorParticipante/{numIdentidad}/")]
        public List<Pr_Proyecto_InvParticipante_Result> InvestigadorParticipante(string numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_InvParticipante(numIdentidad).ToList();
            }
        }

        [HttpPost]
        [Route("ProyectoInformesPendientes/")]
        public List<Pr_Proyecto_InfPendientes_Result> ProyectoInformesPendientes()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Proyecto_InfPendientes().ToList();
            }
        }

        [HttpPost]
        [Route("InvestigadorInformesPendientes/")]
        public List<Pr_Investigador_InfPendientes_Result> InvestigadorInformesPendientes()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_InfPendientes().ToList();
            }
        }



        [HttpPost]
        [Route("InvestigadorSexo/{sexo}/")]
        public List<Pr_Investigador_SexoSelect_Result> InvestigadorSexo(string sexo)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_SexoSelect(sexo).ToList();
            }
        }

        [HttpPost]
        [Route("InvestigadorCodigo/{numIdentidad}/")]
        public List<Pr_Investigador_BuscarPorCod_Result> InvestigadorCodigo(string numIdentidad)
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_BuscarPorCod(numIdentidad).ToList();
            }
        }

        [HttpPost]
        [Route("InvestigadorCoordinadores/")]
        public List<Pr_Investigador_SelectCoord_Result> InvestigadorCoordinadores()
        {
            using (VieEntidades entities = new VieEntidades())
            {
                entities.Configuration.ProxyCreationEnabled = false;

                return entities.Pr_Investigador_SelectCoord().ToList();
            }
        }
    }
}
