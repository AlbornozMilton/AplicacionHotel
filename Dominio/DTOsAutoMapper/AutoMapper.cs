//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using AutoMapper;
using pers = Persistencia.Domain;
namespace Dominio.DTOsAutoMapper
{
    public class AutoMapper
    {
        public static void Mapear()
        {
            Mapper.Initialize(cfg =>
            {

                cfg.CreateMap<Cliente, pers.Cliente>();

                cfg.CreateMap<Domicilio, pers.Domicilio>();
                // .ForMember(c => c.Ciudad, s => s.NullSubstitute(null));

                cfg.CreateMap<Ciudad, pers.Ciudad>();

                cfg.CreateMap<Alojamiento, pers.Alojamiento>()
                .ForMember(a => a.AlojamientoId, d => d.MapFrom(src => src.IdAlojamiento));

                cfg.CreateMap<Habitacion, pers.Habitacion>();

                cfg.CreateMap<LineaServicio, pers.LineaServicio>();

                cfg.CreateMap<Servicio, pers.Servicio>();

                cfg.CreateMap<TarifaCliente, pers.TarifaCliente>();

                cfg.CreateMap<Cupo, pers.Cupo>();

                cfg.CreateMap<Pago, pers.Pago>();

            });
        }
    }
}
