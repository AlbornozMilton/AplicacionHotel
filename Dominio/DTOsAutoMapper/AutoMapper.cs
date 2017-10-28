using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Dominio.DTOsAutoMapper
{
    public class AutoMapper
    {
        public static void Mapear()
        {
            Mapper.Initialize(cfg =>
            {

                cfg.CreateMap<Cliente, Persistencia.Domain.Cliente>();

                cfg.CreateMap<Domicilio, Persistencia.Domain.Domicilio>()
                .ForMember(c => c.Ciudad, s => s.NullSubstitute(null));

                cfg.CreateMap<Ciudad, Persistencia.Domain.Ciudad>();
            });

            //ForMember(c => c.DomicilioId, s => s.MapFrom(o => o.Domicilio.DomicilioId)));
            //   .ForMember(c => c.Domicilio, opt => opt.Ignore()));

            //Mapper.Initialize(cfg =>
            //    cfg.CreateMap<Domicilio, Persistencia.Domain.Domicilio>()
            //.ForMember(c => c.Ciudad, s => s.NullSubstitute(null)));
            //.ForMember(c => c.CiudadId, s=> s.Ignore()));

            //Mapper.Initialize(cfg =>
            //    cfg.CreateMap<Ciudad, Persistencia.Domain.Ciudad>());

            //AutoMapperMappingException: Missing type map configuration or unsupported mapping.
        }

    }
}
