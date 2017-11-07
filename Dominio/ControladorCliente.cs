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
        static IEnumerable<pers.Usuario> iUsuarios;

        //aca se instancoa UoW?? SI, al instanciar el controlador
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //-----METODOS
        public void CargarCiudad(int pCp, string pNombre)
        {
            //Ciudad city = new Ciudad(pCp, pNombre);
            //this.iCiudad = Mapper.Map<Ciudad, pers.Ciudad>(city);
            this.iCiudad = iUoW.RepositorioCiudad.Get(pCp);

            if (this.iCiudad == null)
            {
                throw new Exception("Codigo postal no encontrado");
            }

            if (this.iCiudad.Nombre != pNombre)
            {
                this.iCiudad = null;
                throw new Exception("Nombre de Ciudad no Correspondiente");
            }

        }

        public void CargarDomicilio(string pCalle, string pNumCalle, string pPiso, string pNumDpto)
        {
            Domicilio dom = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso);
            this.iDomicilio = Mapper.Map<Domicilio, pers.Domicilio>(dom);
            this.iDomicilio.CiudadId = this.iCiudad.CiudadId;

        }

        //public void CargarTarifa(string p.)
        //{
        //    Domicilio dom = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso);
        //    this.iDomicilio = Mapper.Map<Domicilio, pers.Domicilio>(dom);
        //}


        public void NuevoCliente (string pDni, string pNombre, string pApellido, string pTel, string pTipoCliente)
        {

            Cliente cli = new Cliente(Convert.ToInt32(pDni), pNombre, pApellido, pTel);
            this.iCliente = Mapper.Map<Cliente, pers.Cliente>(cli);

            this.iCliente.Domicilio = this.iDomicilio;

            //buscar una tarifa por tipo cliente ingresado desde la UI y generar una pers.TarifaCliente
            //probar hacer un find(tipo cliente) y asignarlo a pers.TarifaCliente, sinn tener que hacer un automapper
            

            iUoW.RepositorioCliente.Add(this.iCliente);
            iUoW.Complete();
            iUoW.Dispose();
            //{ "The INSERT statement conflicted with the FOREIGN KEY constraint \"FK_dbo.Cliente_dbo.Domicilio_DomicilioId\". The conflict occurred in database \"HotelBD\", table \"dbo.Domicilio\", column 'DomicilioId'.\r\nThe statement has been terminated."}
        }

        public Cliente BuscarClientePorDni(int unDni)
        {
            return (Mapper.Map<pers.Cliente, Cliente>(iUoW.RepositorioCliente.Get(unDni)));
        }

        public List<Cliente> BuscarClientePorNom_Ape(string pCadena)
        {
            IEnumerable<pers.Cliente> listaEnum = iUoW.RepositorioCliente.ObtenerClientesPorNomyAp(pCadena);
            List<Cliente> lista = new List<Cliente>();
            foreach (var i in listaEnum)
            {
                    lista.Add(Mapper.Map<pers.Cliente, Cliente>(i));
            }
            return (lista);
        }

        public bool ValidarUsuario(string pUs, string pPass)
        {
            //bool result = false;
            //foreach (var user in iUsuarios)
            //{
            //    result = (user.UsuarioId == pUs && user.Password == pPass);
            //}
            //return result;
            return iUsuarios.Contains(new pers.Usuario { UsuarioId = pUs, Password = pPass });
            
        }

        public void CargarUsuarios()
        {
            iUsuarios = iUoW.RepositorioUsuario.GetAll();
            iUoW.Dispose();

        }
        
    }
}
