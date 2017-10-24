using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;

namespace Dominio
{
    public class ControladorCliente
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());
        public void NuevoCliente (string pDni, string pNombre, string pApellido, string pTel)
        {
            Cliente cli = new Cliente(Convert.ToInt32(pDni),pNombre,pApellido,pTel);
            //Persistencia.Domain.Cliente cliente = Converter<Cliente, Persistencia.Domain.Cliente> Cliente;
            //iUoW.RepositorioCliente.Add(Persistencia.Domain.Cliente Converter<Cliente,Persistencia.Domain.Cliente> Cliente cli);
        }
    }
}
