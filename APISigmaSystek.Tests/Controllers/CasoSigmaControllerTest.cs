using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using Newtonsoft.Json;
using APISigmaSystek.Tests.Models.Response;
using APISigmaSystek.Tests.Models.Request;
using APISigmaSystek.Controllers;
using APISigmaSystek.Models;
using APISigmaSystek.Mocks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web.Http.Results;
using APISigmaSystek.Tests.Constantes;

namespace APISigmaSystek.Tests.Controllers
{
    [TestClass]
    public class CasoSigmaControllerTest
    {
        [TestMethod]
        public void PostCasoSigmaExitoso()
        {
            //Arrange 
            RequestCasoModel datosOrdenRecibida = new RequestCasoModel();
            WsInt_DevKitSoapClientI wsCliente = new WsInt_DevKitSoapClientI(ConstantesCasoSigmaResponse.XmlOperacionExitosa);
            datosOrdenRecibida = JsonConvert.DeserializeObject<RequestCasoModel>(ConstantesCasoSigmaRequest.RequestOrdenCasoSigma);
            AuthenticationHeaderValue headerValue = new AuthenticationHeaderValue("Berear", ConstantesAPI.TokenModel);
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Authorization = headerValue;
            //Act 
            CasoSigmaController controllerCasoSigma = new CasoSigmaController(wsCliente, true);
            controllerCasoSigma.Request = request;
            IHttpActionResult actionResult =  controllerCasoSigma.GeneraCasoSigma(datosOrdenRecibida);
            OkNegotiatedContentResult<string> contentResult = actionResult as OkNegotiatedContentResult<string>;
            int numero = (int.TryParse(contentResult.Content, out numero)) ? numero : 0;

            //Assert 
            Assert.AreNotEqual(0, numero);
        }

        [TestMethod]
        public void PostCasoSigmaError()
        {
            //Arrange 
            RequestCasoModel datosOrdenRecibida = new RequestCasoModel();
            WsInt_DevKitSoapClientI wsCliente = new WsInt_DevKitSoapClientI(ConstantesCasoSigmaResponse.XmlOperacionFallida);
            datosOrdenRecibida = JsonConvert.DeserializeObject<RequestCasoModel>(ConstantesCasoSigmaRequest.RequestOrdenCasoSigma);
            AuthenticationHeaderValue headerValue = new AuthenticationHeaderValue("Berear", ConstantesAPI.TokenModel);
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Authorization = headerValue;
            //Act 
            CasoSigmaController controllerCasoSigma = new CasoSigmaController(wsCliente, true);
            controllerCasoSigma.Request = request;
            IHttpActionResult actionResult = controllerCasoSigma.GeneraCasoSigma(datosOrdenRecibida);
            OkNegotiatedContentResult<string> contentResult = actionResult as OkNegotiatedContentResult<string>;

            //Assert 
            Assert.IsNull(contentResult);
        }

        [TestMethod]
        public void GetCasoSigmaExitoso()
        {
            //Arrange 
            WsInt_DevKitSoapClientI wsCliente = new WsInt_DevKitSoapClientI(ConstantesCasoSigmaResponse.XmlConsultaExitosa);
            AuthenticationHeaderValue headerValue = new AuthenticationHeaderValue("Berear", ConstantesAPI.TokenModel);
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Authorization = headerValue;
            //Act 
            CasoSigmaController controllerCasoSigma = new CasoSigmaController(wsCliente, true);
            controllerCasoSigma.Request = request;
            IHttpActionResult actionResult = controllerCasoSigma.ConsultaCasoSigma(483);
            OkNegotiatedContentResult<string> contentResult = actionResult as OkNegotiatedContentResult<string>;
            bool resultado = contentResult.Content.Replace("\"","").ToUpper().Contains("CODIGOESTADO:1");
            //Assert 
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void GetCasoSigmaFallido()
        {
            //Arrange 
            WsInt_DevKitSoapClientI wsCliente = new WsInt_DevKitSoapClientI(ConstantesCasoSigmaResponse.XmlConsultaFallida);
            AuthenticationHeaderValue headerValue = new AuthenticationHeaderValue("Berear", ConstantesAPI.TokenModel);
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Authorization = headerValue;
            //Act 
            CasoSigmaController controllerCasoSigma = new CasoSigmaController(wsCliente, true);
            controllerCasoSigma.Request = request;
            IHttpActionResult actionResult = controllerCasoSigma.ConsultaCasoSigma(483);
            BadRequestErrorMessageResult contentResult = actionResult as BadRequestErrorMessageResult;
            bool resultado = contentResult.Message.Replace("\"", "").ToUpper().Contains("CODIGOESTADO:1");
            //Assert 
            Assert.IsFalse(resultado);
        }
    }
}
