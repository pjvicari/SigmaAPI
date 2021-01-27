using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISigmaSystek.Tests.Models.Request
{
    static class ConstantesCasoSigmaRequest
    {
        public static string RequestOrdenCasoSigma =
            @"{
                ""datosCliente"": {
                    ""clienteDatosGenerales"": {
                        ""clienteSistema"": 1,
                        ""clienteTipoCliente"": 1,
                        ""clienteNumeroUnico"":593,
                        ""clienteNit"": """",
                        ""clienteMail"": """"
                    },
                    ""clienteIndividual"": {
                        ""nombres"": """",
                        ""apellidos"": """",
                        ""apellidoCasada"": """",
                        ""sexo"": """",
                        ""fechaNacimiento"": """",
                        ""estadoCivil"": """",
                        ""datosCedula"": {
                            ""NumeroRegistro"": """"
                        }
                    },
                    ""clienteEmpresarial"": {
                        ""nombre"": ""STD"",
                        ""contacto"": ""JOEL CIFUENTES""
                    }
                },
                ""datosCaso"": {
                    ""casoDatosEmpleado"": {
                        ""empleadoGrupoTrabajo"": 304,
                        ""empleadoSistema"": 1,
                        ""empleadoNumeroUnico"": ""10518"",
                        ""empleadoLogin"": """"
                    },
                    ""casoDatosGenerales"": {
                        ""proceso"": 199,
                        ""descripcion"": ""STD 344914""
                    },
                    ""casoDatosProducto"": {
                        ""filial"": """",
                        ""grupoProducto"": """",
                        ""subProducto"": """",
                        ""producto"": """"
                    },
                    ""casoDatosParametros"": {
                        ""parametros"": {
                            ""parametro"": [
                                {
                                    ""codigoParametro"": 653,
                                    ""valorParametro"": ""344914""
                                },
                                {
                                    ""codigoParametro"": 1792,
                                    ""valorParametro"": ""WHIRLPOOL""
                                },
                                {
                                    ""codigoParametro"": 937,
                                    ""valorParametro"": ""CAMBIO AUTORIZADO POR PROVEEDOR""
                                },
                                {
                                    ""codigoParametro"": 658,
                                    ""valorParametro"": ""STD""
                                },
                                {
                                    ""codigoParametro"": 1794,
                                    ""valorParametro"": ""WHIRLPOOL""
                                },
                                {
                                    ""codigoParametro"": 659,
                                    ""valorParametro"": ""WDF330PAHS""
                                },
                                {
                                    ""codigoParametro"": 660,
                                    ""valorParametro"": ""F94831877""
                                },
                                {
                                    ""codigoParametro"": 794,
                                    ""valorParametro"": ""LAVAPLATOS EMP. ACERO""
                                },
                                {
                                    ""codigoParametro"": 665,
                                    ""valorParametro"": ""13/05/2020""
                                },
                                {
                                    ""codigoParametro"": 643,
                                    ""valorParametro"": ""MX051-1""
                                },
                                {
                                    ""codigoParametro"": 644,
                                    ""valorParametro"": ""3865""
                                },
                                {
                                    ""codigoParametro"": 645,
                                    ""valorParametro"": ""JUAN MAURICIO CALLE ""
                                },
                                {
                                    ""codigoParametro"": 646,
                                    ""valorParametro"": ""41511027\t\t30071428""
                                },
                                {
                                    ""codigoParametro"": 767,
                                    ""valorParametro"": ""KM. 15 CARRETERA A PALENCIA, DESPUES DE SAN JOSE PINULA A MANO IZQUIERDA CONDOMINIO CONTECRISTO CASA  Z-1 CODIGO DE ACCESO 2376 O 2377""
                                },
                                {
                                    ""codigoParametro"": 1842,
                                    ""valorParametro"": ""GARANTÍA PROVEEDOR""
                                },
                                {
                                    ""codigoParametro"": 1843,
                                    ""valorParametro"": ""NO""
                                },
                                {
                                    ""codigoParametro"": 793,
                                    ""valorParametro"": ""LINEA BLANCA""
                                }
                            ]
                        }
                    }
                }
            }";
    }
}
