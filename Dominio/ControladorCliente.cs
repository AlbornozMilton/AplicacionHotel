using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using AutoMapper;
using pers = Persistencia.Domain;

namespace Dominio
{
    public class ControladorCliente
    {
        //ATRIBUTOS NECESARIOS PARA RESPONDER A LAS UI
        pers.Cliente iCliente;
        pers.Domicilio iDomicilio;
        pers.Ciudad iCiudad;

        //aca se instancoa UoW??
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //-----METODOS
        public void CargarCiudad(int pCp, string pNombre)
        {
            Ciudad city = new Ciudad(pCp, pNombre);
            this.iCiudad = Mapper.Map<Ciudad, pers.Ciudad>(city);
        }

        public void CargarDomicilio(string pCalle, string pNumCalle, string pPiso, string pNumDpto)
        {
            Domicilio dom = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso);
            this.iDomicilio = Mapper.Map<Domicilio, pers.Domicilio>(dom);
        }

        public void NuevoCliente (string pDni, string pNombre, string pApellido, string pTel)
        {

            Cliente cli = new Cliente(Convert.ToInt32(pDni),pNombre,pApellido,pTel,TipoCliente.Titular);
            this.iCliente = Mapper.Map<Cliente, pers.Cliente>(cli);
            this.iDomicilio.Ciudad = this.iCiudad;
            this.iCliente.Domicilio = this.iDomicilio;
            iUoW.RepositorioCliente.Add(this.iCliente);
            iUoW.Complete();
            iUoW.Dispose();
            //{ "The INSERT statement conflicted with the FOREIGN KEY constraint \"FK_dbo.Cliente_dbo.Domicilio_DomicilioId\". The conflict occurred in database \"HotelBD\", table \"dbo.Domicilio\", column 'DomicilioId'.\r\nThe statement has been terminated."}
        }

        public Cliente BuscarCliente(int unDni)
        {
            pers.Cliente clipers = new pers.Cliente();
            clipers = iUoW.RepositorioCliente.Get(unDni);
            Cliente cli= Mapper.Map<pers.Cliente,Cliente>(clipers);
            return (cli); //Es necesario convertir?
        }

        public bool ValidarUsuario(string pUs, string pPass)
        {
            return (iUoW.RepositorioUsuario.Existe(pUs,pPass));
        }

        
        }
    }
