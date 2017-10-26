using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using AutoMapper;

namespace Dominio
{
    public class ControladorCliente
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());
        public void NuevoCliente (string pDni, string pNombre, string pApellido, string pTel)
        {
            Cliente cli = new Cliente(Convert.ToInt32(pDni),pNombre,pApellido,pTel);
            var cliente = Mapper.Map<Cliente, Persistencia.Domain.Cliente>(cli);
            iUoW.RepositorioCliente.Add(cliente);
            iUoW.Complete();
            iUoW.Dispose();
        }
    }
}
