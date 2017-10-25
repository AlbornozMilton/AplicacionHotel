using AutoMapper;
using Dominio.DTO_Mapper;
using Persistencia.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Persistencia.DAL.EntityFramework;

namespace Dominio
{ 
    public class ControladorCliente
    {
        AutoMapperHotel Mapeo = new AutoMapperHotel();
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //public void NuevoCliente(string pDni, string pNombre, string pApellido, int pTel)
        //{
        //    Mapeo.Mapear();
        //    Cliente cli = new Cliente(Convert.ToInt32(pDni), pNombre, pApellido, pTel);
        //    var nuevoCli = Mapper.Map<Cliente, Persistencia.Domain.Cliente>(cli);
        //    //Persistencia.Domain.Cliente cliente = Converter<Cliente, Persistencia.Domain.Cliente> Cliente;
        //    iUoW.RepositorioCliente.Add(nuevoCli);
        //    iUoW.Complete();
        //    iUoW.Dispose();
        //}

        public void NuevaCiudad(int pCodPostal, string pNombre)
        {
            Mapeo.Mapear();
            Ciudad city = new Ciudad(pCodPostal, pNombre);
            Persistencia.Domain.Ciudad persistenciaCity = Mapper.Map<Ciudad, Persistencia.Domain.Ciudad>(city);
            iUoW.RepositorioCiudad.Add(persistenciaCity);
            iUoW.Complete();
            iUoW.Dispose();
        }


        public void ExisteCliente(string pDni, string pNombre, string pApellido, int pTel)
        {
            Mapeo.Mapear();
            Cliente cli = new Cliente(Convert.ToInt32(pDni), pNombre, pApellido, pTel);
            var nuevoCli = Mapper.Map<Cliente, Persistencia.Domain.Cliente>(cli);
            iUoW.RepositorioCliente.Existe(nuevoCli);
            iUoW.Complete();
            iUoW.Dispose();
        }
    }
}
