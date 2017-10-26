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
        public static void Mapaer()
        {
            Mapper.Initialize(cfg =>
                cfg.CreateMap<Cliente, Persistencia.Domain.Cliente>());
              //  .ForMember(c => c.Alojamiento).
        }
    }
}
