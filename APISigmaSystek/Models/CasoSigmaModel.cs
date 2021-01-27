using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace APISigmaSystek.Models
{
    public class CasoSigmaModel
    {

        #region Creación de caso
        [XmlRoot(ElementName = "SolicitudesCrearCaso")]
        public class SolicitudesCrearCaso
        {
            [XmlElement(ElementName = "Solicitud")]
            public Solicitud Solicitud { get; set; }
            public SolicitudesCrearCaso()
            {
                Solicitud = new Solicitud();
                Solicitud.DatosCliente = new DatosCliente();
                Solicitud.DatosCliente.ClienteDatosGenerales = new ClienteDatosGenerales();
                Solicitud.DatosCliente.ClienteIndividual = new ClienteIndividual();
                Solicitud.DatosCliente.ClienteEmpresarial = new ClienteEmpresarial();
                Solicitud.DatosCliente.ClienteIndividual.DatosCedula = new DatosCedula();
                Solicitud.DatosCaso = new DatosCaso();
                Solicitud.DatosCaso.CasoDatosEmpleado = new CasoDatosEmpleado();
                Solicitud.DatosCaso.CasoDatosGenerales = new CasoDatosGenerales();
                Solicitud.DatosCaso.CasoDatosProducto = new CasoDatosProducto();
                Solicitud.DatosCaso.CasoDatosParametros = new CasoDatosParametros();
                Solicitud.DatosCaso.CasoDatosParametros.Parametros = new Parametros();
                Solicitud.DatosCaso.CasoDatosParametros.Parametros.Parametro = new List<Parametro>();
            }
        }

        [XmlRoot(ElementName = "Solicitud")]
        public class Solicitud
        {
            [XmlAttribute(AttributeName = "NoSolicitud")]
            public int NoSolicitud { get; set; }

            [XmlElement(ElementName = "DatosCliente")]
            public DatosCliente DatosCliente { get; set; }
            [XmlElement(ElementName = "DatosCaso")]
            public DatosCaso DatosCaso { get; set; }

        }

        [XmlRoot(ElementName = "DatosCliente")]
        public class DatosCliente
        {
            [XmlElement(ElementName = "ClienteDatosGenerales")]
            public ClienteDatosGenerales ClienteDatosGenerales { get; set; }
            [XmlElement(ElementName = "ClienteIndividual")]
            public ClienteIndividual ClienteIndividual { get; set; }
            [XmlElement(ElementName = "ClienteEmpresarial")]
            public ClienteEmpresarial ClienteEmpresarial { get; set; }
        }

        [XmlRoot(ElementName = "ClienteDatosGenerales")]
        public class ClienteDatosGenerales
        {
            [XmlElement(ElementName = "ClienteSistema")]
            public int ClienteSistema { get; set; }

            [XmlElement(ElementName = "ClienteTipoCliente")]
            public int ClienteTipoCliente { get; set; }

            [XmlElement(ElementName = "ClienteNumeroUnico")]
            public int ClienteNumeroUnico { get; set; }

            [XmlElement(ElementName = "ClienteNit")]
            public string ClienteNit { get; set; }

            [XmlElement(ElementName = "ClienteMail")]
            public string ClienteMail { get; set; }

        }
        [XmlRoot(ElementName = "ClienteIndividual")]
        public class ClienteIndividual
        {
            [XmlElement(ElementName = "Nombres")]
            public string Nombres { get; set; }

            [XmlElement(ElementName = "Apellidos")]
            public string Apellidos { get; set; }

            [XmlElement(ElementName = "ApellidoCasada")]
            public string ApellidoCasada { get; set; }

            [XmlElement(ElementName = "Sexo")]
            public string Sexo { get; set; }

            [XmlElement(ElementName = "FechaNacimiento")]
            public string FechaNacimiento { get; set; }

            [XmlElement(ElementName = "EstadoCivil")]
            public string EstadoCivil { get; set; }
            [XmlElement(ElementName = "DatosCedula")]
            public DatosCedula DatosCedula { get; set; }

        }

        [XmlRoot(ElementName = "DatosCedula")]
        public class DatosCedula
        {
            [XmlElement(ElementName = "NumeroRegistro")]
            public string NumeroRegistro { get; set; }

        }

        [XmlRoot(ElementName = "ClienteEmpresarial")]
        public class ClienteEmpresarial
        {
            [XmlElement(ElementName = "Nombre")]
            public string Nombre { get; set; }

            [XmlElement(ElementName = "Contacto")]
            public string Contacto { get; set; }
        }

        [XmlRoot(ElementName = "DatosCaso")]
        public class DatosCaso
        {
            [XmlElement(ElementName = "CasoDatosEmpleado")]
            public CasoDatosEmpleado CasoDatosEmpleado { get; set; }
            [XmlElement(ElementName = "CasoDatosGenerales")]
            public CasoDatosGenerales CasoDatosGenerales { get; set; }
            [XmlElement(ElementName = "CasoDatosProducto")]
            public CasoDatosProducto CasoDatosProducto { get; set; }
            [XmlElement(ElementName = "CasoDatosParametros")]
            public CasoDatosParametros CasoDatosParametros { get; set; }
        }
        [XmlRoot(ElementName = "CasoDatosEmpleado")]
        public class CasoDatosEmpleado
        {
            [XmlElement(ElementName = "EmpleadoGrupoTrabajo")]
            public int EmpleadoGrupoTrabajo { get; set; }

            [XmlElement(ElementName = "EmpleadoSistema")]
            public int EmpleadoSistema { get; set; }

            [XmlElement(ElementName = "EmpleadoNumeroUnico")]
            public string EmpleadoNumeroUnico { get; set; }

            [XmlElement(ElementName = "EmpleadoLogin")]
            public string EmpleadoLogin { get; set; }

        }
        [XmlRoot(ElementName = "CasoDatosGenerales")]
        public class CasoDatosGenerales
        {
            [XmlElement(ElementName = "Proceso")]
            public int Proceso { get; set; }

            [XmlElement(ElementName = "Descripcion")]
            public string Descripcion { get; set; }

        }

        [XmlRoot(ElementName = "CasoDatosProducto")]
        public class CasoDatosProducto
        {
            [XmlElement(ElementName = "Filial")]
            public string Filial { get; set; }

            [XmlElement(ElementName = "GrupoProducto")]
            public string GrupoProducto { get; set; }

            [XmlElement(ElementName = "SubProducto")]
            public string SubProducto { get; set; }

            [XmlElement(ElementName = "Producto")]
            public string Producto { get; set; }
        }

        [XmlRoot(ElementName = "CasoDatosParametros")]
        public class CasoDatosParametros
        {
            [XmlElement(ElementName = "Parametros")]
            public Parametros Parametros { get; set; }
        }
        [XmlRoot(ElementName = "Parametros")]
        public class Parametros
        {
            [XmlElement(ElementName = "Parametro")]
            public List<Parametro> Parametro { get; set; }
        }

        [XmlRoot(ElementName = "Parametro")]
        public class Parametro
        {
            [XmlElement(ElementName = "CodigoParametro")]
            public int CodigoParametro { get; set; }

            [XmlElement(ElementName = "ValorParametro")]
            public string ValorParametro { get; set; }
        }




        #endregion

        #region Resultado

        public class Resultado
        {
            [XmlRoot(ElementName = "ResultadoOperacion")]
            public class ResultadoOperacion
            {
                [XmlElement(ElementName = "ResultadoId")]
                public string ResultadoId { get; set; }
                [XmlElement(ElementName = "ResultadoDescripcion")]
                public string ResultadoDescripcion { get; set; }
            }

            [XmlRoot(ElementName = "EtapaDatosEmpleado")]
            public class EtapaDatosEmpleado
            {
                [XmlElement(ElementName = "EmpleadoAsignadoEmpresa")]
                public string EmpleadoAsignadoEmpresa { get; set; }
                [XmlElement(ElementName = "EmpleadoAsignadoGrupoTrabajo")]
                public string EmpleadoAsignadoGrupoTrabajo { get; set; }
                [XmlElement(ElementName = "EmpleadoAsignadoSistema")]
                public string EmpleadoAsignadoSistema { get; set; }
                [XmlElement(ElementName = "EmpleadoAsignadoNumeroUnico")]
                public string EmpleadoAsignadoNumeroUnico { get; set; }
            }

            [XmlRoot(ElementName = "EtapaActiva")]
            public class EtapaActiva
            {
                [XmlElement(ElementName = "NombreEtapaActiva")]
                public string NombreEtapaActiva { get; set; }
                [XmlElement(ElementName = "EtapaDatosEmpleado")]
                public EtapaDatosEmpleado EtapaDatosEmpleado { get; set; }
                [XmlAttribute(AttributeName = "NoEtapa")]
                public string NoEtapa { get; set; }
            }

            [XmlRoot(ElementName = "EtapasActivas")]
            public class EtapasActivas
            {
                [XmlElement(ElementName = "EtapaActiva")]
                public EtapaActiva EtapaActiva { get; set; }
            }

            [XmlRoot(ElementName = "Parametro")]
            public class Parametro
            {
                [XmlElement(ElementName = "NombreParametro")]
                public string NombreParametro { get; set; }
                [XmlElement(ElementName = "FechaModificacionParametro")]
                public string FechaModificacionParametro { get; set; }
                [XmlElement(ElementName = "ValorParametro")]
                public string ValorParametro { get; set; }
                [XmlAttribute(AttributeName = "Codigo")]
                public string Codigo { get; set; }
            }

            [XmlRoot(ElementName = "Parametros")]
            public class Parametros
            {
                [XmlElement(ElementName = "Parametro")]
                public List<Parametro> Parametro { get; set; }
            }

            [XmlRoot(ElementName = "Solicitud")]
            public class Solicitud
            {
                [XmlElement(ElementName = "NumeroCaso")]
                public string NumeroCaso { get; set; }
                [XmlElement(ElementName = "ResultadoOperacion")]
                public ResultadoOperacion ResultadoOperacion { get; set; }
                [XmlElement(ElementName = "EtapasActivas")]
                public EtapasActivas EtapasActivas { get; set; }
                [XmlElement(ElementName = "Parametros")]
                public Parametros Parametros { get; set; }
                [XmlAttribute(AttributeName = "NoSolicitud")]
                public string NoSolicitud { get; set; }
            }

            [XmlRoot(ElementName = "SolicitudesCrearCaso")]
            public class SolicitudesCrearCaso
            {
                [XmlElement(ElementName = "Solicitud")]
                public Solicitud Solicitud { get; set; }

                public SolicitudesCrearCaso()
                {
                    Solicitud = new Solicitud();
                    Solicitud.ResultadoOperacion = new ResultadoOperacion();
                    Solicitud.EtapasActivas = new EtapasActivas();
                    Solicitud.Parametros = new Parametros();
                    Solicitud.EtapasActivas.EtapaActiva = new EtapaActiva();
                    Solicitud.EtapasActivas.EtapaActiva.EtapaDatosEmpleado = new EtapaDatosEmpleado();
                    Solicitud.Parametros.Parametro = new List<Parametro>();
                }
            }
        }
        #endregion

        #region Consulta de casos
        public class ConsultaCasoSigma
        {
            [XmlRoot(ElementName = "SolicitudesConsultaCaso")]
            public class SolicitudesConsultaCaso
            {
                [XmlElement(ElementName = "Solicitud")]
                public Solicitud Solicitud { get; set; }

                public SolicitudesConsultaCaso()
                {
                    Solicitud = new Solicitud();
                }
            }

            [XmlRoot(ElementName = "Solicitud")]
            public class Solicitud
            {
                [XmlElement(ElementName = "DatosCaso")]
                public DatosCaso DatosCaso { get; set; }
                [XmlAttribute(AttributeName = "NoSolicitud")]
                public string NoSolicitud { get; set; }

                public Solicitud()
                {
                    DatosCaso = new DatosCaso();
                    NoSolicitud = "1";
                }
            }

            [XmlRoot(ElementName = "DatosCaso")]
            public class DatosCaso
            {
                [XmlElement(ElementName = "NumeroCaso")]
                public string NumeroCaso { get; set; }

                public DatosCaso()
                {
                    NumeroCaso = "";
                }
            }
        }


        #endregion

        #region Respuesta de consulta de caso
        public class RespuestaConsultaCaso
        {
            [XmlRoot(ElementName = "ResultadoOperacion")]
            public class ResultadoOperacion
            {
                [XmlElement(ElementName = "ResultadoId")]
                public string ResultadoId { get; set; }
                [XmlElement(ElementName = "ResultadoDescripcion")]
                public string ResultadoDescripcion { get; set; }

                public ResultadoOperacion()
                {
                    ResultadoId = ResultadoDescripcion = "";
                }
            }

            [XmlRoot(ElementName = "DatosGenerales")]
            public class DatosGenerales
            {
                [XmlElement(ElementName = "NoCasoAlternativo")]
                public string NoCasoAlternativo { get; set; }
                [XmlElement(ElementName = "Estado")]
                public string Estado { get; set; }
                [XmlElement(ElementName = "CodigoEstado")]
                public string CodigoEstado { get; set; }
                [XmlElement(ElementName = "Empresa")]
                public string Empresa { get; set; }
                [XmlElement(ElementName = "Proceso")]
                public string Proceso { get; set; }
                [XmlElement(ElementName = "ColaboradorCreador")]
                public string ColaboradorCreador { get; set; }
                [XmlElement(ElementName = "Cliente")]
                public string Cliente { get; set; }
                [XmlElement(ElementName = "Descripcion")]
                public string Descripcion { get; set; }

                public DatosGenerales()
                {
                    Descripcion = Cliente = Proceso = Empresa = CodigoEstado = Estado = NoCasoAlternativo = "";
                }
            }

            [XmlRoot(ElementName = "EtapaDatosEmpleado")]
            public class EtapaDatosEmpleado
            {
                [XmlElement(ElementName = "NombreEmpleadoAsignado")]
                public string NombreEmpleadoAsignado { get; set; }
                [XmlElement(ElementName = "CodigoEmpleadoAsignado")]
                public string CodigoEmpleadoAsignado { get; set; }
                [XmlElement(ElementName = "EmpleadoAsignadoGrupoTrabajo")]
                public string EmpleadoAsignadoGrupoTrabajo { get; set; }
                [XmlElement(ElementName = "CodigoEmpleadoAsignadoGrupoTrabajo")]
                public string CodigoEmpleadoAsignadoGrupoTrabajo { get; set; }
            }

            [XmlRoot(ElementName = "Comentario")]
            public class Comentario
            {
                [XmlElement(ElementName = "Descripcion")]
                public string Descripcion { get; set; }
                [XmlElement(ElementName = "Fecha")]
                public string Fecha { get; set; }
                [XmlElement(ElementName = "TipoComentario")]
                public string TipoComentario { get; set; }
                [XmlElement(ElementName = "CodigoTipoComentario")]
                public string CodigoTipoComentario { get; set; }
                [XmlElement(ElementName = "Empleado")]
                public string Empleado { get; set; }
                [XmlAttribute(AttributeName = "Codigo")]
                public string Codigo { get; set; }
            }

            [XmlRoot(ElementName = "Comentarios")]
            public class Comentarios
            {
                [XmlElement(ElementName = "Comentario")]
                public List<Comentario> Comentario { get; set; }
            }

            [XmlRoot(ElementName = "Etapa")]
            public class Etapa
            {
                [XmlElement(ElementName = "NombreEtapa")]
                public string NombreEtapa { get; set; }
                [XmlElement(ElementName = "EstadoEtapa")]
                public string EstadoEtapa { get; set; }
                [XmlElement(ElementName = "CodigoEstadoEtapa")]
                public string CodigoEstadoEtapa { get; set; }
                [XmlElement(ElementName = "EstadoAsignacionEtapa")]
                public string EstadoAsignacionEtapa { get; set; }
                [XmlElement(ElementName = "CodigoEstadoAsignacionEtapa")]
                public string CodigoEstadoAsignacionEtapa { get; set; }
                [XmlElement(ElementName = "EstadoAceptacionEtapa")]
                public string EstadoAceptacionEtapa { get; set; }
                [XmlElement(ElementName = "CodigoEstadoAceptacionEtapa")]
                public string CodigoEstadoAceptacionEtapa { get; set; }
                [XmlElement(ElementName = "EtapaDatosEmpleado")]
                public EtapaDatosEmpleado EtapaDatosEmpleado { get; set; }
                [XmlElement(ElementName = "Comentarios")]
                public Comentarios Comentarios { get; set; }
                [XmlAttribute(AttributeName = "NoEtapa")]
                public string NoEtapa { get; set; }
                [XmlElement(ElementName = "CheckLists")]
                public CheckLists CheckLists { get; set; }
            }

            [XmlRoot(ElementName = "CheckList")]
            public class CheckList
            {
                [XmlElement(ElementName = "Nombre")]
                public string Nombre { get; set; }
                [XmlElement(ElementName = "Descripcion")]
                public string Descripcion { get; set; }
                [XmlElement(ElementName = "Seleccionado")]
                public string Seleccionado { get; set; }
                [XmlAttribute(AttributeName = "Codigo")]
                public string Codigo { get; set; }
            }

            [XmlRoot(ElementName = "CheckLists")]
            public class CheckLists
            {
                [XmlElement(ElementName = "CheckList")]
                public List<CheckList> CheckList { get; set; }
            }

            [XmlRoot(ElementName = "Etapas")]
            public class Etapas
            {
                [XmlElement(ElementName = "Etapa")]
                public List<Etapa> Etapa { get; set; }
            }

            [XmlRoot(ElementName = "Parametro")]
            public class Parametro
            {
                [XmlElement(ElementName = "NombreParametro")]
                public string NombreParametro { get; set; }
                [XmlElement(ElementName = "FechaModificacionParametro")]
                public string FechaModificacionParametro { get; set; }
                [XmlElement(ElementName = "ValorParametro")]
                public string ValorParametro { get; set; }
                [XmlAttribute(AttributeName = "Codigo")]
                public string Codigo { get; set; }
            }

            [XmlRoot(ElementName = "Parametros")]
            public class Parametros
            {
                [XmlElement(ElementName = "Parametro")]
                public List<Parametro> Parametro { get; set; }
            }

            [XmlRoot(ElementName = "Caso")]
            public class Caso
            {
                [XmlElement(ElementName = "DatosGenerales")]
                public DatosGenerales DatosGenerales { get; set; }
                [XmlElement(ElementName = "Etapas")]
                public Etapas Etapas { get; set; }
                [XmlElement(ElementName = "Parametros")]
                public Parametros Parametros { get; set; }
                [XmlAttribute(AttributeName = "NoCaso")]
                public string NoCaso { get; set; }

                public Caso()
                {
                    DatosGenerales = new DatosGenerales();
                    Etapas = new Etapas();
                    Parametros = new Parametros();
                    NoCaso = "";
                }
            }

            [XmlRoot(ElementName = "Solicitud")]
            public class Solicitud
            {
                [XmlElement(ElementName = "NumeroCaso")]
                public string NumeroCaso { get; set; }
                [XmlElement(ElementName = "ResultadoOperacion")]
                public ResultadoOperacion ResultadoOperacion { get; set; }
                [XmlElement(ElementName = "Caso")]
                public Caso Caso { get; set; }
                [XmlAttribute(AttributeName = "NoSolicitud")]
                public string NoSolicitud { get; set; }

                public Solicitud()
                {
                    NumeroCaso = NoSolicitud = "";
                    ResultadoOperacion = new ResultadoOperacion();
                    Caso = new Caso();
                }
            }

            [XmlRoot(ElementName = "SolicitudesConsultaCaso")]
            public class SolicitudesConsultaCaso
            {
                [XmlElement(ElementName = "Solicitud")]
                public Solicitud Solicitud { get; set; }

                public SolicitudesConsultaCaso()
                {
                    Solicitud = new Solicitud();
                }
            }
        }
        #endregion
    }
}