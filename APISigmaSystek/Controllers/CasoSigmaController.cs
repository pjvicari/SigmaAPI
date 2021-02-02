using System;
using AutoMapper;
using System.Web.Http;
using APISigmaSystek.Models;
using static APISigmaSystek.Helpers.XmlHelpers;
using static APISigmaSystek.Helpers.ExceptionHelper;
using Newtonsoft.Json;
using APISigmaSystek.wsSigma7;


namespace APISigmaSystek.Controllers
{
    [GDAH.AutorizacionHandler]
    //[GDAH.ProtocolHandler]
    public class CasoSigmaController : ApiController
    {
        WsInt_DevKitSoapClient wsCliente;
        bool esTest;
        string xmlRespuesta;
        APISigmaSystek.Mocks.WsInt_DevKitSoapClient wsClienteTest;

        public CasoSigmaController(APISigmaSystek.Mocks.WsInt_DevKitSoapClient wsCliente, bool esTest)
        {
            this.wsClienteTest = wsCliente;
            this.esTest = esTest;
            APISigmaSystek.App_Start.MappingProfile.Initialize();
        }

        public CasoSigmaController()
        {
            wsCliente = new WsInt_DevKitSoapClient();
        }

        [System.Web.Http.HttpPost, Route("api/Generacion/Caso")]
        public IHttpActionResult GenerarCaso([FromBody] RequestCasoModel data)
        {
            return (GeneraCasoSigma(data));
        }

        [System.Web.Http.HttpGet, Route("api/Consulta/Caso")]
        public IHttpActionResult ConsultaCaso(int numeroCaso)
        {
            return (ConsultaCasoSigma(numeroCaso));
        }

        public IHttpActionResult GeneraCasoSigma(RequestCasoModel item)
        {
            string usuario = GDAH.AutorizacionHandler.getClaim(ActionContext, GDAH.AutorizacionHandler.usuario);
            int idSistema;
            try
            {
                CasoSigmaModel.SolicitudesCrearCaso casoSigma = new CasoSigmaModel.SolicitudesCrearCaso();
                idSistema = Convert.ToInt32(GDAH.AutorizacionHandler.getClaim(ActionContext, GDAH.AutorizacionHandler.sistema));
                casoSigma.Solicitud.NoSolicitud = 1;
                casoSigma.Solicitud.DatosCliente = Mapper.Map<RequestCasoModel.DatosClienteInterno, CasoSigmaModel.DatosCliente>(item.DatosCliente);
                casoSigma.Solicitud.DatosCaso = Mapper.Map<RequestCasoModel.DatosCasoInterno, CasoSigmaModel.DatosCaso>(item.DatosCaso);


                string strXmlCaso = Serialize(casoSigma);


                if (!esTest)
                    xmlRespuesta = wsCliente.DEVKIT_CreacionCasos(strXmlCaso);
                else
                    xmlRespuesta = wsClienteTest.DEVKIT_CreacionCasos(strXmlCaso);

                CasoSigmaModel.Resultado.SolicitudesCrearCaso sigmaRespuesta = LecturaXMLLinq(xmlRespuesta);

                if (sigmaRespuesta.Solicitud.ResultadoOperacion.ResultadoId == "0")
                    return Ok(sigmaRespuesta.Solicitud.NumeroCaso);
                else
                    return BadRequest(sigmaRespuesta.Solicitud.ResultadoOperacion.ResultadoDescripcion);
            }
            catch (Exception ex)
            {
                return InternalServerError(GetException(ex));
            }
        }

        public IHttpActionResult ConsultaCasoSigma(int numeroCaso)
        {
            string usuario = GDAH.AutorizacionHandler.getClaim(ActionContext, GDAH.AutorizacionHandler.usuario);
            int idSistema;
            CasoSigmaModel.ConsultaCasoSigma.SolicitudesConsultaCaso casoSigma = new CasoSigmaModel.ConsultaCasoSigma.SolicitudesConsultaCaso();
            try
            {
                idSistema = Convert.ToInt32(GDAH.AutorizacionHandler.getClaim(ActionContext, GDAH.AutorizacionHandler.sistema));

                casoSigma.Solicitud.DatosCaso.NumeroCaso = numeroCaso.ToString();


                string strXmlCaso = Serialize(casoSigma);
                if (!esTest)
                    xmlRespuesta = wsCliente.DEVKIT_ConsultaCasos(strXmlCaso);
                else
                    xmlRespuesta = wsClienteTest.DEVKIT_ConsultaCasos(strXmlCaso);

                CasoSigmaModel.RespuestaConsultaCaso.SolicitudesConsultaCaso sigmaRespuesta = LecturaXMLConsulta(xmlRespuesta);

                if (sigmaRespuesta.Solicitud.ResultadoOperacion.ResultadoId == "0")
                {
                    RequestConsultaCasoModel item = new RequestConsultaCasoModel();
                    item.NumeroCaso = numeroCaso;
                    item.CodigoEstado = Convert.ToInt32(sigmaRespuesta.Solicitud.Caso.DatosGenerales.CodigoEstado);
                    item.Estado = sigmaRespuesta.Solicitud.Caso.DatosGenerales.Estado;
                    return Ok(JsonConvert.SerializeObject(item).Replace("\"", ""));
                }
                else
                    return BadRequest(sigmaRespuesta.Solicitud.ResultadoOperacion.ResultadoDescripcion);
            }
            catch (Exception ex)
            {
                return InternalServerError(GetException(ex));
            }
        }

    }
}
