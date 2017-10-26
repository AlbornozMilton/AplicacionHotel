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
        //ATRIBUTOS NECESARIOS PARA RESPONDER A LAS UI
        Cliente iCliente;
        Domicilio iDomicilio = new Domicilio("Alejo", "661", 8, 0, new Ciudad(3260, "CdelU"));
        Ciudad iCiudad = new Ciudad(3260, "CdelU");

        //aca se instancoa UoW??
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //-----METODOS 
        public void NuevoCliente (string pDni, string pNombre, string pApellido, string pTel)
        {
            this.iCliente = new Cliente(Convert.ToInt32(pDni),pNombre,pApellido,pTel,this.iDomicilio,TipoCliente.Titular);
            var clienteDTO = Mapper.Map<Cliente, Persistencia.Domain.Cliente>(iCliente);
            iUoW.RepositorioCliente.Add(clienteDTO);
            iUoW.Complete();
            iUoW.Dispose();
        }
    }
}
