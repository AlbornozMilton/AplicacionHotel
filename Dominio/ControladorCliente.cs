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
            switch (pTipoCliente)
            {
                case ("Titular"):
                    {
                        this.iCliente.TarifaClienteId = pers.TipoCliente.Titular;
                        break;
                    }
                case ("AcompañanteDirecto"):
                    {
                        this.iCliente.TarifaClienteId = pers.TipoCliente.AcompanianteDirecto;
                        break;
                    }
                case ("AcompñanteNoDirecto"):
                    {
                        this.iCliente.TarifaClienteId = pers.TipoCliente.AcompanianteNoDirecto;
                        break;
                    }
                case ("Titular Exceptuado"):
                    {
                        this.iCliente.TarifaClienteId = pers.TipoCliente.TitularExceptuado;
                        break;
                    }
                case ("Convenio"):
                    {
                        this.iCliente.TarifaClienteId = pers.TipoCliente.Convenio;
                        break;
                    }
            }

            this.iCliente = Mapper.Map<Cliente, pers.Cliente>(new Cliente(Convert.ToInt32(pDni), pNombre, pApellido, pTel));
            this.iCliente.Domicilio = this.iDomicilio;

            iUoW.RepositorioCliente.Add(this.iCliente);
            iUoW.Complete();
            iUoW.Dispose();
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
