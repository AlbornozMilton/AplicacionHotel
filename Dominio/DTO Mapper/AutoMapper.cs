using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Dominio.DTO_Mapper
{
    class AutoMapperHotel : Profile
    {
        public void Mapear()
        {
            
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<Cliente, Persistencia.Domain.Cliente>()
                //.ForMember(t => t.ClienteId, f => f.MapFrom(r => r.Dni))
                //.ForMember(t => t.Alojamiento, opt => opt.Ignore())//determinar que atributo va con que, porque varian en nombre.
                //.ForMember(t => t.Alojamiento, opt => opt.Ignore())//determinar que atributo va con que, porque varian en nombre.
                //.ForMember(t => t.Domicilio, opt => opt.Ignore());//determinar que atributo va con que, porque varian en nombre.
                //                                                  //.ForMember(t => t.Nombre, f => f.MapFrom(r => r.Nombre))
                //                                                  //.ForMember(t => t.Apellido, f => f.MapFrom(r => r.Apellido))
                //                                                  //.ForMember(t => t.Telefono, f => f.MapFrom(r => r.Telefono))
                //                                                  //.ForMember(t => t.Correo, f => f.MapFrom(r => r.Correo))
                //                                                  //.ForMember(t => t.DomicilioId, f => f.MapFrom( r => r.GetDomicilio.Ciudad.CodPostal))
                //                                                  //.ReverseMap();//para que funcione la conversion a la inversa, es decir de persistencia.cliente a domain.cliente

                ////        cfg.CreateMap<Domicilio, Persistencia.Domain.Domicilio>()
                cfg.CreateMap<Ciudad, Persistencia.Domain.Ciudad>()
                .ForMember(t => t.CiudadId, f => f.MapFrom(r => r.CodPostal))
                .ForMember(t => t.Nombre, f => f.MapFrom(r => r.Nombre));//determinar que atributo va con que, porque varian en nombre.
            });

        }

        //private int iDni;
        //private string iNombre;
        //private string iApellido;
        //private string iTelefono;
        //private string iCorreo;
        //private Domicilio iDomicilio;
        //private TipoCliente iTipoCliente;

        //public int ClienteId { get; set; } //dni
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public int Telefono { get; set; }
        //public string Correo { get; set; }

        //public int DomicilioId { get; set; }
        //public Domicilio Domicilio { get; set; }


        //public int TarifaClienteId { get; set; }
        //public TarifaCliente TarifaCliente { get; set; }

        //public int AlojamientoId { get; set; }
        //public Alojamiento Alojamiento { get; set; }
    }
}
