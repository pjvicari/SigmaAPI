using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static APISigmaSystek.Models.CasoSigmaModel;

namespace APISigmaSystek.Models
{
    public class RequestCasoModel
    {
        #region Creación de caso
        public DatosClienteInterno DatosCliente { get; set; }
        public DatosCasoInterno DatosCaso { get; set; }
        public class DatosClienteInterno
        {
            public ClienteDatosGenerales ClienteDatosGenerales { get; set; }
            public ClienteIndividual ClienteIndividual { get; set; }
            public ClienteEmpresarial ClienteEmpresarial { get; set; }
        }

        public class DatosCasoInterno
        {
            public CasoDatosEmpleado CasoDatosEmpleado { get; set; }
            public CasoDatosGenerales CasoDatosGenerales { get; set; }
            public CasoDatosProducto CasoDatosProducto { get; set; }
            public CasoDatosParametrosInterno CasoDatosParametros { get; set; }

        }
        public class CasoDatosParametrosInterno
        {
            public Parametros Parametros { get; set; }
        }
        public class Parametros
        {
            public List<Parametro> Parametro { get; set; }

        }



        #endregion
    }

    public class RequestConsultaCasoModel
    {
        public int NumeroCaso { get; set; }

        public int CodigoEstado { get; set; }

        public string Estado { get; set; }
    }
}