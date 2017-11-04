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

                cfg.CreateMap<Cliente, pers.Cliente>()
                   .ReverseMap(); //Realiza el map inverso al definido en el renglon de arriba.

                cfg.CreateMap<Domicilio, pers.Domicilio>().ReverseMap();
                // .ForMember(c => c.Ciudad, s => s.NullSubstitute(null));

                cfg.CreateMap<Ciudad, pers.Ciudad>().ReverseMap();

                cfg.CreateMap<Alojamiento, pers.Alojamiento>()
                .ForMember(a => a.AlojamientoId, d => d.MapFrom(src => src.IdAlojamiento)).ReverseMap();

                cfg.CreateMap<Habitacion, pers.Habitacion>().ReverseMap();

                cfg.CreateMap<LineaServicio, pers.LineaServicio>().ReverseMap();

                cfg.CreateMap<Servicio, pers.Servicio>().ReverseMap();

                cfg.CreateMap<TarifaCliente, pers.TarifaCliente>().ReverseMap();

                cfg.CreateMap<Cupo, pers.Cupo>().ReverseMap();

                cfg.CreateMap<Pago, pers.Pago>().ReverseMap();

            });
        }
    }
}
