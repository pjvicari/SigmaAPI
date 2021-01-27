using APISigmaSystek.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static APISigmaSystek.Models.CasoSigmaModel;

namespace APISigmaSystek.Helpers
{
    public class XmlHelpers
    {
        private static Dictionary<string, string> caracteres = new Dictionary<string, string> {
            {"'", "''"},
            {"&lt;", "<"},
            {"&gt;", ">"},
            {"&quot;", @""""},
            {"&apos;", "`"},
            {"&amp;", "&"},
        };

        public static Resultado.SolicitudesCrearCaso LecturaXMLLinq(string xml)
        {
            Resultado.SolicitudesCrearCaso casoSigma = new Resultado.SolicitudesCrearCaso();
            TextReader textReader = new StringReader(xml.Replace("&", "&amp;"));
            XDocument xdoc = XDocument.Load(textReader);

            if (xdoc.Descendants("SolicitudesCrearCaso").SingleOrDefault() == null)
            {
                return null;
            }

            casoSigma.Solicitud.NumeroCaso = xdoc.Descendants("NumeroCaso").Single().Value;
            casoSigma.Solicitud.ResultadoOperacion.ResultadoId = xdoc.Descendants("ResultadoId").Single().Value;
            casoSigma.Solicitud.ResultadoOperacion.ResultadoDescripcion = xdoc.Descendants("ResultadoDescripcion").Single().Value;
           
            return casoSigma;
        }

        public static RespuestaConsultaCaso.SolicitudesConsultaCaso LecturaXMLConsulta(string xml)
        {
            RespuestaConsultaCaso.SolicitudesConsultaCaso casoSigma = new RespuestaConsultaCaso.SolicitudesConsultaCaso();
            TextReader textReader = new StringReader(xml.Replace("&", "&amp;"));
            XDocument xdoc = XDocument.Load(textReader);

            if (xdoc.Descendants("SolicitudesConsultaCaso").SingleOrDefault() == null)
            {
                return null;
            }

            casoSigma.Solicitud.NumeroCaso = xdoc.Descendants("NumeroCaso").Single().Value;
            casoSigma.Solicitud.ResultadoOperacion.ResultadoId = xdoc.Descendants("ResultadoId").Single().Value;
            casoSigma.Solicitud.ResultadoOperacion.ResultadoDescripcion = xdoc.Descendants("ResultadoDescripcion").Single().Value;
            casoSigma.Solicitud.Caso.DatosGenerales.CodigoEstado = xdoc.Descendants("CodigoEstado").Single().Value;
            casoSigma.Solicitud.Caso.DatosGenerales.Estado = xdoc.Descendants("Estado").Single().Value;

            return casoSigma;
        }

        public static string Serialize<T>(T instance)
        {
            string xml = "";
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xmlSerializer.Serialize(writer, instance, ns);
                    xml = sw.ToString();
                }
            }
            xml = xml.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            xml = xml.Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
            return xml;
        }
    }
}