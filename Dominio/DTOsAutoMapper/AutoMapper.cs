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
				cfg.CreateMap<AlojHab, pers.AlojHab>().ReverseMap();

                cfg.CreateMap<AHCliente, pers.AHCliente>().ReverseMap();

                cfg.CreateMap<AHTarifa, pers.AHTarifa>().ReverseMap();

                cfg.CreateMap<Cliente, pers.Cliente>().ReverseMap();

                cfg.CreateMap<Domicilio, pers.Domicilio>().ReverseMap();

                cfg.CreateMap<Ciudad, pers.Ciudad>().ReverseMap();

                cfg.CreateMap<Alojamiento, pers.Alojamiento>().ReverseMap();

                cfg.CreateMap<Habitacion, pers.Habitacion>().ReverseMap();

                cfg.CreateMap<LineaServicio, pers.LineaServicio>().ReverseMap();

                cfg.CreateMap<Servicio, pers.Servicio>().ReverseMap();

                cfg.CreateMap<TarifaCliente, pers.TarifaCliente>().ReverseMap();

                cfg.CreateMap<Pago, pers.Pago>().ReverseMap();

                cfg.CreateMap<TipoCliente, pers.TipoCliente>().ReverseMap();

                cfg.CreateMap<TipoPago, pers.TipoPago>().ReverseMap();

                cfg.CreateMap<EstadoAlojamiento, pers.EstadoAlojamiento>().ReverseMap();

                cfg.CreateMap<TipoMetadaHotel, pers.TipoMetadaHotel>().ReverseMap();
            });
        }
    }
}
