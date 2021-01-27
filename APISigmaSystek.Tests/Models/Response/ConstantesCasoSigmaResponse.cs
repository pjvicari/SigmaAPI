using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISigmaSystek.Tests.Models.Response
{
    static class ConstantesCasoSigmaResponse
    {
        public static string XmlOperacionExitosa =
            @"<?xml version=""1.0"" encoding=""UTF8""?>
                <SolicitudesCrearCaso>
                    <Solicitud NoSolicitud=""1"">
                        <NumeroCaso>34439</NumeroCaso>
                        <ResultadoOperacion>
                            <ResultadoId>0</ResultadoId>
                            <ResultadoDescripcion>Operacion realizada con exito</ResultadoDescripcion>
                        </ResultadoOperacion>
                        <EtapasActivas>
                            <EtapaActiva NoEtapa=""456"">
                                <NombreEtapaActiva>SOLICITUD DE AUTORIZACIÓN DE CAMBIO AL PROVEEDOR</NombreEtapaActiva>
                                <EtapaDatosEmpleado>
                                    <EmpleadoAsignadoEmpresa>171</EmpleadoAsignadoEmpresa>
                                    <EmpleadoAsignadoGrupoTrabajo>304</EmpleadoAsignadoGrupoTrabajo>
                                    <EmpleadoAsignadoSistema>1</EmpleadoAsignadoSistema>
                                    <EmpleadoAsignadoNumeroUnico>10518</EmpleadoAsignadoNumeroUnico>
                                </EtapaDatosEmpleado>
                            </EtapaActiva>
                        </EtapasActivas>
                        <Parametros>
                            <Parametro Codigo=""643"">
                                <NombreParametro>FACTURA SERIE</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>MX0511</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""644"">
                                <NombreParametro>FACTURA NO.</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>3865</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""645"">
                                <NombreParametro>NOMBRE</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>JUAN MAURICIO CALLE</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""646"">
                                <NombreParametro>TELEFONO</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>41511027 30071428</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""653"">
                                <NombreParametro>NO. DE ORDEN DE SERVICIO</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>344914</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""654"">
                                <NombreParametro>NO. ORDEN INTERNA 2</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""655"">
                                <NombreParametro>ORDEN DEL PROVEEDOR 1</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""658"">
                                <NombreParametro>TALLER DE REPARACION</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>STD</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""659"">
                                <NombreParametro>LÍNEA</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>WDF330PAHS</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""660"">
                                <NombreParametro>SERIE</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>F94831877</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""665"">
                                <NombreParametro>FECHA DE COMPRA</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>13/05/2020</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""666"">
                                <NombreParametro>FECHA DE INGRESO AL TALLER</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""671"">
                                <NombreParametro>INFORMACION</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""679"">
                                <NombreParametro>¿EL APARATO SE ENCUENTRA EN EL TALLER?</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""681"">
                                <NombreParametro>COSTO PROMEDIO (+ 5%)</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""767"">
                                <NombreParametro>DIRECCION</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>KM. 15 CARRETERA A PALENCIA, DESPUES DE SAN JOSE PINULA A MANO IZQUIERDA CONDOMINIO CONTECRISTO CASA Z1 CODIGO DE ACCESO 2376 O 2377</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""768"">
                                <NombreParametro>OBSERVACIONES</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""791"">
                                <NombreParametro>TALLER EXTERNO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""793"">
                                <NombreParametro>CATEGORÍA DE PRODUCTO</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>LINEA BLANCA</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""794"">
                                <NombreParametro>TIPO DE PRODUCTO</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>LAVAPLATOS EMP. ACERO</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""804"">
                                <NombreParametro>OBSERVACIONES CONTROL INTERNO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""809"">
                                <NombreParametro>TIPO DE MONEDA</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""814"">
                                <NombreParametro>VALOR DE DEVOLUCIÓN AL PROVEEDOR EN LOGÍSTICA</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""815"">
                                <NombreParametro>NO. DE DEVOLUCIÓN</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""937"">
                                <NombreParametro>ESTATUS DE LA SOLICITUD DE CAMBIO</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>CAMBIO AUTORIZADO POR PROVEEDOR</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""938"">
                                <NombreParametro>VALOR EN QUE SE RECIBE</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""939"">
                                <NombreParametro>FECHA DE ENTREGA DEL PRODUCTO NUEVO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""940"">
                                <NombreParametro>VALOR EN FACTURA DEL PRODUCTO NUEVO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""941"">
                                <NombreParametro>OBSERVACIONES EN LA EJECUCIÓN DEL CAMBIO Y TRASLADOS</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""942"">
                                <NombreParametro>FECHA DE AUTORIZACIÓN DEL PROVEEDOR PARA EL CAMBIO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""943"">
                                <NombreParametro>FECHA DE DEVOLUCIÓN</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""944"">
                                <NombreParametro>NO. DE DEVOLUCIÓN EN LOGÍSTICA</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""947"">
                                <NombreParametro>¿CLASIFICAR COMO ""AUTORIZADO POR SERVICIO AL CLIENTE""?</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""948"">
                                <NombreParametro>NOMBRE DE ASESOR DE SERVICIO AL CLIENTE QUE AUTORIZA CAMBIO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""1792"">
                                <NombreParametro>PROVEEDOR</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>WHIRLPOOL</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""1794"">
                                <NombreParametro>MARCA</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>WHIRLPOOL</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""1804"">
                                <NombreParametro>UBICACIÓN FÍSICA DEL APARATO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""1841"">
                                <NombreParametro>SELECCIONE</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                            <Parametro Codigo=""1842"">
                                <NombreParametro>TIPO DE GARANTÍA</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>GARANTÍA PROVEEDOR</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""1843"">
                                <NombreParametro>¿CAMBIO INTERNO CON DEPRECIACIÓN?</NombreParametro>
                                <FechaModificacionParametro>22/01/2021 15:55:30</FechaModificacionParametro>
                                <ValorParametro>NO</ValorParametro>
                            </Parametro>
                            <Parametro Codigo=""1844"">
                                <NombreParametro>INDIQUE EL VALOR QUE EL CLIENTE TIENE A SU FAVOR Y EL PORCENTAJE APLICADO</NombreParametro>
                                <FechaModificacionParametro/>
                                <ValorParametro/>
                            </Parametro>
                        </Parametros>
                    </Solicitud>
                </SolicitudesCrearCaso>";

        public static string XmlOperacionFallida =
            @"<?xml version=""1.0"" encoding=""UTF8""?>
            <SolicitudesCrearCaso>
                <Solicitud NoSolicitud=""1"">
                    <NumeroCaso>1</NumeroCaso>
                    <ResultadoOperacion>
                        <ResultadoId>2000</ResultadoId>
                        <ResultadoDescripcion>Numero unico del cliente: no definido.</ResultadoDescripcion>
                    </ResultadoOperacion>
                    <EtapasActivas>
                        <EtapaActiva NoEtapa=""1"">
                            <NombreEtapaActiva/>
                            <EtapaDatosEmpleado>
                                <EmpleadoAsignadoEmpresa/>
                                <EmpleadoAsignadoGrupoTrabajo/>
                                <EmpleadoAsignadoSistema/>
                                <EmpleadoAsignadoNumeroUnico/>
                            </EtapaDatosEmpleado>
                        </EtapaActiva>
                    </EtapasActivas>
                </Solicitud>
            </SolicitudesCrearCaso>";
        #region Consulta Exitosa
        public static string XmlConsultaExitosa =
            @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                <SolicitudesConsultaCaso>
                    <Solicitud NoSolicitud=""1"">
                        <NumeroCaso>483</NumeroCaso>
                        <ResultadoOperacion>
                            <ResultadoId>0</ResultadoId>
                            <ResultadoDescripcion>Consulta realizada con exito</ResultadoDescripcion>
                        </ResultadoOperacion>
                        <Caso NoCaso=""483"">
                            <DatosGenerales>
                                <NoCasoAlternativo>2011-0000000012-01-0101</NoCasoAlternativo>
                                <Estado>En proceso</Estado>
                                <CodigoEstado>1</CodigoEstado>
                                <Empresa>MI EMPRESA</Empresa>
                                <Proceso>LOTES2</Proceso>
                                <ColaboradorCreador>ADMINISTRADOR SIGMA 7</ColaboradorCreador>
                                <Cliente>Alejandro Barahona</Cliente>
                                <Descripcion>INGRESO DE SOLICITUD DE LOTES2</Descripcion>
                            </DatosGenerales>
                            <Etapas>
                                <Etapa NoEtapa=""117"">
                                    <NombreEtapa>ETAPA 1</NombreEtapa>
                                    <EstadoEtapa>Finalizado</EstadoEtapa>
                                    <CodigoEstadoEtapa>3</CodigoEstadoEtapa>
                                    <EstadoAsignacionEtapa>Asignada</EstadoAsignacionEtapa>
                                    <CodigoEstadoAsignacionEtapa>1</CodigoEstadoAsignacionEtapa>
                                    <EstadoAceptacionEtapa>Atendida</EstadoAceptacionEtapa>
                                    <CodigoEstadoAceptacionEtapa>2</CodigoEstadoAceptacionEtapa>
                                    <EtapaDatosEmpleado>
                                        <NombreEmpleadoAsignado>ADMINISTRADOR SIGMA7</NombreEmpleadoAsignado>
                                        <CodigoEmpleadoAsignado>0</CodigoEmpleadoAsignado>
                                        <EmpleadoAsignadoGrupoTrabajo>OPERADORES</EmpleadoAsignadoGrupoTrabajo>
                                        <CodigoEmpleadoAsignadoGrupoTrabajo>100</CodigoEmpleadoAsignadoGrupoTrabajo>
                                    </EtapaDatosEmpleado>
                                    <Comentarios>
                                        <Comentario Codigo=""235"">
                                            <Descripcion>comentario</Descripcion>
                                            <Fecha>16/06/2011 03:22:23</Fecha>
                                            <TipoComentario>COMENTARIO</TipoComentario>
                                            <CodigoTipoComentario>4</CodigoTipoComentario>
                                            <Empleado>ADMINISTRADOR SIGMA 7</Empleado>
                                        </Comentario>
                                    </Comentarios>
                                    <CheckLists>
                                    </CheckLists>
                                </Etapa>
                                <Etapa NoEtapa=""118"">
                                    <NombreEtapa>ETAPA 2</NombreEtapa>
                                    <EstadoEtapa>En proceso</EstadoEtapa>
                                    <CodigoEstadoEtapa>1</CodigoEstadoEtapa>
                                    <EstadoAsignacionEtapa>Asignada</EstadoAsignacionEtapa>
                                    <CodigoEstadoAsignacionEtapa>1</CodigoEstadoAsignacionEtapa>
                                    <EstadoAceptacionEtapa>Atendida</EstadoAceptacionEtapa>
                                    <CodigoEstadoAceptacionEtapa>2</CodigoEstadoAceptacionEtapa>
                                    <EtapaDatosEmpleado>
                                        <NombreEmpleadoAsignado>ADMINISTRADOR SIGMA7</NombreEmpleadoAsignado>
                                        <CodigoEmpleadoAsignado>0</CodigoEmpleadoAsignado>
                                        <EmpleadoAsignadoGrupoTrabajo>OPERADORES</EmpleadoAsignadoGrupoTrabajo>
                                        <CodigoEmpleadoAsignadoGrupoTrabajo>100</CodigoEmpleadoAsignadoGrupoTrabajo>
                                    </EtapaDatosEmpleado>
                                    <Comentarios>
                                        <Comentario Codigo=""236"">
                                            <Descripcion> comentario </Descripcion>
                                            <Fecha>16/06/2011 03:22:39</Fecha>
                                            <TipoComentario>COMENTARIO</TipoComentario>
                                            <CodigoTipoComentario>4</CodigoTipoComentario>
                                            <Empleado>ADMINISTRADOR SIGMA 7</Empleado>
                                        </Comentario>
                                        <Comentario Codigo=""237"">
                                            <Descripcion> comentario </Descripcion>
                                            <Fecha>16/06/2011 03:22:50</Fecha>
                                            <TipoComentario>COMENTARIO</TipoComentario>
                                            <CodigoTipoComentario>4</CodigoTipoComentario>
                                            <Empleado>ADMINISTRADOR SIGMA 7</Empleado>
                                        </Comentario>
                                    </Comentarios>
                                    <CheckLists>
                                        <CheckList Codigo=""105"">
                                            <Nombre>CHECKLISTETAPA1</Nombre>
                                            <Descripcion>CHECKLISTETAPA1</Descripcion>
                                            <Seleccionado>0</Seleccionado>
                                        </CheckList>
                                        <CheckList Codigo=""106"">
                                            <Nombre>CHECKLISTETAPA2</Nombre>
                                            <Descripcion>CHECKLISTETAPA2</Descripcion>
                                            <Seleccionado>1</Seleccionado>
                                        </CheckList>
                                        <CheckList Codigo=""107"">
                                            <Nombre> CHECKLISTETAPA3</Nombre>
                                            <Descripcion> CHECKLISTETAPA3</Descripcion>
                                            <Seleccionado>0</Seleccionado>
                                        </CheckList>
                                    </CheckLists>
                                </Etapa>
                            </Etapas>
                            <Parametros>
                                <Parametro Codigo=""159"">
                                    <NombreParametro>FIRMANTE</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                                <Parametro Codigo=""160"">
                                    <NombreParametro>TITULO FIRMANTE</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                                <Parametro Codigo=""161"">
                                    <NombreParametro>LUGAR DE ENTREGA DE PLIEGOS</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                                <Parametro Codigo=""162"">
                                    <NombreParametro>HORA DE ENTREGA DE PLIEGOS</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                                <Parametro Codigo=""163"">
                                    <NombreParametro>COSTO DE PLIEGOS</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                                <Parametro Codigo=""164"">
                                    <NombreParametro>LUGAR DE PAGO DE PLIEGOS</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                                <Parametro Codigo=""165"">
                                    <NombreParametro>TIPO TRAMITE</NombreParametro>
                                    <FechaModificacionParametro></FechaModificacionParametro>
                                    <ValorParametro></ValorParametro>
                                </Parametro>
                            </Parametros>
                        </Caso>
                    </Solicitud>
                </SolicitudesConsultaCaso>";
        #endregion

        #region ConsultaError
        public static string XmlConsultaFallida =
            @"<?xml version=""1.0"" encoding=""UTF8""?>
                <SolicitudesConsultaCaso>
                    <Solicitud NoSolicitud=""1"">
                        <ResultadoOperacion>
                            <ResultadoId>2000</ResultadoId>
                            <ResultadoDescripcion>Numero de Caso : Valor no registrado en Sigma7</ResultadoDescripcion>
                        </ResultadoOperacion>
                        <Caso NoCaso=""1"">
                            <DatosGenerales>
                                <NoCasoAlternativo>1</NoCasoAlternativo>
                                <Estado/>
                                <CodigoEstado/>
                                <Empresa/>
                                <Proceso/>
                                <ColaboradorCreador/>
                                <Cliente/>
                                <Descripcion/>
                            </DatosGenerales>
                            <Etapas>
                                <Etapa NoEtapa=""1"">
                                    <NombreEtapa/>
                                    <EstadoEtapa/>
                                    <CodigoEstadoEtapa/>
                                    <EstadoAsignacionEtapa/>
                                    <CodigoEstadoAsignacionEtapa/>
                                    <EstadoAceptacionEtapa/>
                                    <CodigoEstadoAceptacionEtapa/>
                                    <EtapaDatosEmpleado>
                                        <NombreEmpleadoAsignado/>
                                        <CodigoEmpleadoAsignado/>
                                        <EmpleadoAsignadoGrupoTrabajo/>
                                        <CodigoEmpleadoAsignadoGrupoTrabajo/>
                                    </EtapaDatosEmpleado>
                                    <Comentarios>
                                        <Comentario Codigo=""1"">
                                            <Descripcion/>
                                            <Fecha/>
                                            <TipoComentario/>
                                            <CodigoTipoComentario/>
                                            <Empleado/>
                                        </Comentario>
                                    </Comentarios>
                                    <CheckLists>
                                        <CheckList Codigo=""1"">
                                            <Nombre/>
                                            <Seleccionado/>
                                        </CheckList>
                                    </CheckLists>
                                </Etapa>
                            </Etapas>
                            <Parametros>
                                <Parametro Codigo=""1"">
                                    <NombreParametro/>
                                    <FechaModificacionParametro/>
                                    <ValorParametro/>
                                </Parametro>
                            </Parametros>
                        </Caso>
                    </Solicitud>
                </SolicitudesConsultaCaso>";
        #endregion
    }
}
