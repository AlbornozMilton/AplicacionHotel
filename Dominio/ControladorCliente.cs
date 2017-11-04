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
        pers.TarifaCliente iTarifa;

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

        //public void CargarTarifa(string p.)
        //{
        //    Domicilio dom = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso);
        //    this.iDomicilio = Mapper.Map<Domicilio, pers.Domicilio>(dom);
        //}


        public void NuevoCliente (string pDni, string pNombre, string pApellido, string pTel)
        {

            Cliente cli = new Cliente(Convert.ToInt32(pDni), pNombre, pApellido, pTel);
            this.iCliente = Mapper.Map<Cliente, pers.Cliente>(cli);
            this.iDomicilio.Ciudad = this.iCiudad;
            this.iCliente.Domicilio = this.iDomicilio;

            //buscar una tarifa por tipo cliente ingresado desde la UI y generar una pers.TarifaCliente
            //probar hacer un find(tipo cliente) y asignarlo a pers.TarifaCliente, sinn tener que hacer un automapper
            this.iCliente.TarifaCliente = new pers.TarifaCliente
              { TarifaClienteId = 0,
                TipoCliente = pers.TipoCliente.Titular,
                Tarifa = 150, TarifaExclusiva = 250
              };

            iUoW.RepositorioCliente.Add(this.iCliente);
            iUoW.Complete();
            iUoW.Dispose();
            //{ "The INSERT statement conflicted with the FOREIGN KEY constraint \"FK_dbo.Cliente_dbo.Domicilio_DomicilioId\". The conflict occurred in database \"HotelBD\", table \"dbo.Domicilio\", column 'DomicilioId'.\r\nThe statement has been terminated."}
        }

        public Cliente BuscarClientePorDni(int unDni)
        {
            pers.Cliente clipers = new pers.Cliente();
            clipers = iUoW.RepositorioCliente.Get(unDni);
            Cliente cli= Mapper.Map<pers.Cliente,Cliente>(clipers);
            return (cli); //Es necesario convertir?
        }

        public List<Cliente> BuscarClientePorNom_Ape(string pCadena)
        {
            IEnumerable < pers.Cliente > listaEnum;
            listaEnum = iUoW.RepositorioCliente.GetAll();
            List<Cliente> lista = new List<Cliente>();
            foreach (var i in listaEnum)
            {
                if (i.Nombre == pCadena)
                {
                    lista.Add(Mapper.Map<pers.Cliente,Cliente>(i));
                }
            }
                return (lista);
        }

        public bool ValidarUsuario(string pUs, string pPass)
        {
            return (iUoW.RepositorioUsuario.Existe(pUs,pPass));
        }

        
        }
    }
