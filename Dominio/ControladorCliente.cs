using AutoMapper;
using Dominio.DTO_Mapper;
using Persistencia.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladorCliente
    {
        AutoMapperHotel Mapeo = new AutoMapperHotel();
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());
        public void NuevoCliente(string pDni, string pNombre, string pApellido, string pTel)
        {
            Mapeo.Mapear();
            Cliente cli = new Cliente(Convert.ToInt32(pDni), pNombre, pApellido, pTel);
            var nuevoCli = Mapper.Map<Cliente, Persistencia.Domain.Cliente>(cli);
            //Persistencia.Domain.Cliente cliente = Converter<Cliente, Persistencia.Domain.Cliente> Cliente;
            iUoW.RepositorioCliente.Add(nuevoCli);
            iUoW.Complete();
        }
    }
}
