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
        Cliente Cliente;
        Domicilio Domicilio;
        Ciudad Ciudades;
      //  pers.TarifaCliente iTarifa;
        static IEnumerable<pers.Usuario> iUsuarios;

        //aca se instancoa UoW?? SI, al instanciar el controlador
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //-----METODOS
        public void CargarDomicilio(string pCalle, string pNumCalle, string pPiso, string pNumDpto)
        {
            this.Domicilio = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso);
            //this.Domicilio = Mapper.Map<Domicilio, pers.Domicilio>(dom);
        }

        public void NuevoCliente (string pDni, string pLegajo, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDomicilio, string pTipoCliente)
        {
            if (iUoW.RepositorioCliente.Get(Convert.ToInt32(pDni)) != null)
            {
                throw new Exception("Ya Existe un Cliente con el mismo DNI");
            }

            // control para legajo - metodo buscar por legajo
            TarifaCliente Tarifa = Mapper.Map<pers.TarifaCliente, TarifaCliente>(iUoW.RepositorioTarifa.GetTarifaString(pTipoCliente));

            Cliente auxCliente = new Cliente(Convert.ToInt32(pDni), Convert.ToInt32(pLegajo), pNombre, pApellido, pTel, pCorreo, pDomicilio, Tarifa);

            //this.Cliente = Mapper.Map<Cliente, pers.Cliente>(auxCliente);

            //switch (pTipoCliente)
            //{
            //    case ("Titular Afiliado"):
            //        {
            //            this.iCliente.TarifaClienteId = pers.TipoCliente.Titular;
            //            break;
            //        }
            //    case ("Acomp. Directo"):
            //        {
            //            this.iCliente.TarifaClienteId = pers.TipoCliente.AcompanianteDirecto;
            //            break;
            //        }
            //    case ("Acomp. No Directo"):
            //        {
            //            this.iCliente.TarifaClienteId = pers.TipoCliente.AcompanianteNoDirecto;
            //            break;
            //        }
            //    case ("Afiliado Exceptuado"):
            //        {
            //            this.iCliente.TarifaClienteId = pers.TipoCliente.TitularExceptuado;
            //            break;
            //        }
            //    case ("Afiliado Convenio"):
            //        {
            //            this.iCliente.TarifaClienteId = pers.TipoCliente.Convenio;
            //            break;
            //        }
            //    default: throw new Exception("No se eligio un Tipo de Cliente");
            //}

            //this.Cliente.Domicilio = this.Domicilio;

            //iUoW.RepositorioCliente.Add(this.Cliente);
            //iUoW.Complete();
            //iUoW.Dispose();
        }

        public Cliente BuscarClientePorDni(int unDni)
        {
            return (Mapper.Map<pers.Cliente, Cliente>(iUoW.RepositorioCliente.Get(unDni)));
        }

        public Cliente BuscarClientePorLegajo(int pLegajo)
        {
            return (Mapper.Map<pers.Cliente, Cliente>(iUoW.RepositorioCliente.GetPorLegajo(pLegajo)));
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
            return iUsuarios.Contains(new pers.Usuario { UsuarioId = pUs, Password = pPass });
            
        }

        public void CargarUsuarios()
        {
            iUsuarios = iUoW.RepositorioUsuario.GetAll();
            iUoW.Dispose();

        }

        public List<TarifaCliente> DevolverListaTarifas() //devuelve todas las tarifas
        {
            List<TarifaCliente> TarifasClientes = new List<TarifaCliente>();
            IEnumerable<pers.TarifaCliente> Tarifas = iUoW.RepositorioTarifa.GetAll();
            foreach (var tarifa in Tarifas)
            {
                TarifasClientes.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(tarifa));
            }
            return TarifasClientes;
        }

        /// <summary>
        /// Controla que la cantidades de cupos ingresados coincidan con la cantidad de clientes totales del Alojamiento
        /// </summary>
        /// <param name="pClientes">Acompañantes más el Responsable</param>
        /// <param name="pCantS">Ya pasó el control de la cantidad posible para la Habitación.</param>
        /// <param name="pCantD">Ya pasó el control de la cantidad posible para la Habitación.</param>
        public void ControlCuposConClientes(List<Cliente> pClientes, decimal pCantS, decimal pCantD)
        {
            decimal auxCantidad = pCantS + pCantD * 2;

            if (pClientes.Count != auxCantidad)
            {
                throw new Exception("Las cantidades de cupos ingresadas no corresponden con la cantidad de Clientes cargados.");
            }
        }

        public void ControlCuposConClientes(string pContadores, decimal pCantS, decimal pCantD)
        {
            decimal auxCantidad = pCantS + pCantD * 2;
            decimal auxCantidadContadores = 0;

            foreach (var contador in pContadores)
            {
                auxCantidadContadores+= Convert.ToDecimal(contador.ToString());
            }

            if (auxCantidad != auxCantidadContadores)
            {
                throw new Exception("Las cantidades de cupos ingresadas no corresponden con la cantidad de Clientes cargados.");
            }
        }

        public List<Ciudad> ObtenerCiudades()
        {
            List<Ciudad> resultado = new List<Ciudad>();

            //obtener con las relaciones a Domicilios
            List<pers.Ciudad> ciudadesPer = iUoW.RepositorioCiudad.GetAll().ToList();

            foreach (var ciudad in ciudadesPer)
            {
                resultado.Add(Mapper.Map<pers.Ciudad, Ciudad>(ciudad));
            }

            return resultado;
        }
    }
}
