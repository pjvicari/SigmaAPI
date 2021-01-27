using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using APISigmaSystek.Models;
using static APISigmaSystek.Models.CasoSigmaModel;

namespace APISigmaSystek.App_Start
{
    public class MappingProfile
    {
        static bool Inicializado = false;
        public static void Initialize()
        {
            if (!Inicializado)
                Mapper.Initialize(m =>
                {
                    m.CreateMap<RequestCasoModel.DatosClienteInterno, CasoSigmaModel.DatosCliente>();
                    m.CreateMap<RequestCasoModel.DatosCasoInterno, CasoSigmaModel.DatosCaso>();
                    Inicializado = true;
                });
        }
    }
}