﻿using System;
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
        Cliente Cliente;
        Domicilio Domicilio;
        int IdDomiciio;
        List<Ciudad> Ciudades;
        List<TarifaCliente> Tarifas;
        static IEnumerable<pers.Usuario> iUsuarios;

        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //--------------------------------------METODOS------------------

        public void NuevoCliente (string pDni, string pLegajo, string pNombre, string pApellido, string pTel, string pCorreo, string pTipoCliente)
        {
            this.Cliente = new Cliente(Convert.ToInt32(pDni), Convert.ToInt32(pLegajo), pNombre, pApellido, pTel, pCorreo, this.Domicilio, Tarifas.Find(t => t.NombreTarifa == pTipoCliente));

            iUoW.RepositorioCliente.ActualizarCliente(Mapper.Map<Cliente, pers.Cliente>(this.Cliente), IdDomiciio);
        }

        public Cliente BuscarClientePorDni(int unDni, bool pAlta)
        {
            return (Mapper.Map<pers.Cliente, Cliente>(iUoW.RepositorioCliente.GetPorDNI(unDni, pAlta)));
        }

        public Cliente BuscarClientePorLegajo(string pLegajo, bool pAlta)
        {
            return (Mapper.Map<pers.Cliente, Cliente>(iUoW.RepositorioCliente.GetPorLegajo(Convert.ToInt32(pLegajo), pAlta)));
        }

        public List<Cliente> BuscarClientePorNom_Ape(string pCadena, bool pAlta)
        {
            IEnumerable<pers.Cliente> listaEnum = iUoW.RepositorioCliente.ObtenerClientesPorNomyAp(pCadena, pAlta);
            List<Cliente> lista = new List<Cliente>();
            foreach (var i in listaEnum)
            {
                    lista.Add(Mapper.Map<pers.Cliente, Cliente>(i));
            }
            return (lista);
        }

        public bool ExisteClienteDNI(string pDNI)
        {
            return iUoW.RepositorioCliente.ExisteClienteDNI(Convert.ToInt32(pDNI));
        }

        public bool ExisteClienteLegajo(string pLegajo)
        {
            return iUoW.RepositorioCliente.ExisteClienteLegajo(Convert.ToInt32(pLegajo));
        }

        public void ModificarAltaCliente(int pDNI, bool pValoArlta)
        {
            iUoW.RepositorioCliente.ModificarAlta(pValoArlta, pDNI);
        }

        public void ActualizarCliente(Cliente pCliente)
        {
            iUoW.RepositorioCliente.ActualizarCliente(Mapper.Map<Cliente, pers.Cliente>(pCliente), this.IdDomiciio);
        }

        public List<TarifaCliente> DevolverListaTarifas() //devuelve todas las tarifas
        {
            List<TarifaCliente> TarifasClientes = new List<TarifaCliente>();
            IEnumerable<pers.TarifaCliente> Tarifas = iUoW.RepositorioTarifa.GetAll();
            foreach (var tarifa in Tarifas)
            {
                TarifasClientes.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(tarifa));
            }

            this.Tarifas = TarifasClientes;
            return TarifasClientes;
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

            this.Ciudades = resultado;

            return resultado;
        }

        public List<string> ObtenerCallesDeCiudad(string pCodPostal, string pNombreCiudad)
        {
            List<string> calles = new List<string>();
            foreach (var calle in iUoW.RepositorioCiudad.CallesDeCiudad(Convert.ToInt32(pCodPostal), pNombreCiudad))
            {
                calles.Add(calle.ToString());
            }
            return calles;
        }

        /// <summary>
        /// Genera un Domicilio con una Ciudad en este Controlador.
        /// </summary>
        public void CargarDomicilio(string pCalle, string pNumCalle, string pPiso, string pNumDpto, string pCodPostal, string pNombre)
        {
            Ciudad auxCiudad = Mapper.Map<pers.Ciudad, Ciudad>(iUoW.RepositorioCiudad.GetCiudad(Convert.ToInt32(pCodPostal), pNombre));
            this.Domicilio = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso, auxCiudad);
            IdDomiciio = iUoW.RepositorioDomicilio.ComprobarDomicilio(Mapper.Map<Domicilio, pers.Domicilio>(this.Domicilio));
        }

        public void CargarUsuarios()
        {
            iUsuarios = iUoW.RepositorioUsuario.GetAll();
            iUoW.Dispose();
        }

        public bool ValidarUsuario(string pUs, string pPass)
        {
            return iUsuarios.Contains(new pers.Usuario { UsuarioId = pUs, Password = pPass });
        }

        /// <summary>
        /// Controla que la cantidades de Clientes ingresados coincidan con la capacidad de la Habitacion
        /// </summary>
        /// <param name="pClientes">Acompañantes más el Responsable</param>
        public void ControlCapacidadConClientes(List<Cliente> pClientes, Habitacion pHab)
        {
            if (pClientes.Count != pHab.Capacidad)
            {
                throw new Exception("Las cantidades de Clientes ingresadas no corresponden con la Capacidad de la Habitación");
            }
        }

        /// <summary>
        /// Para la reserva.
        /// </summary>
        public void ControlContadoresConClientes(string pContadores, string pCapacidadHab)
        {
            byte auxCantidadContadores = 0;

            for (int i = 0; i < pContadores.Length; i++)
            {
				auxCantidadContadores += Convert.ToByte(pContadores[i].ToString());
            }
              
            if (Convert.ToByte(pCapacidadHab) != auxCantidadContadores + 1)
            {
                throw new Exception("La cantidad de Clientes cargados sobrepasa la Capacidad de la Habitación");
            }
        }

        /// <summary>
        /// Produce excepción si el Cliente elegido ya se encuentra en algún Alojamiento Activo.
        /// </summary>
        public void ControlClienteActivo(Cliente pCliente, DateTime pFechaDesde, DateTime pFechaHasta, List<Alojamiento> pAlojsActivos)
        {
            foreach (var aloj in pAlojsActivos)
            {
                foreach (var cliente in aloj.Clientes)
                {
                    if (cliente.ClienteId == pCliente.ClienteId)
                    {
                        if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        {
                            throw new Exception("El Cliente seleccionado ya es encuentra en un Alojamiento Alojado para las Fechas elegidas.");
                        }
                        else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                        {
                            //control de fechas
                            if 
                                (
                                    !(aloj.FechaEstimadaIngreso.Date.CompareTo(pFechaDesde.Date) >= 0 && aloj.FechaEstimadaIngreso.Date.CompareTo(pFechaHasta.Date) >= 0)
                                    &&
                                    !(aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaDesde.Date) <= 0 && aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaHasta.Date) <= 0)
                                )
                            {
                                throw new Exception("El Cliente seleccionado ya es encuentra en un Alojamiento Reservado entre las Fechas elegidas.");
                            }
                        }
                    }
                }
            }
        }

		public void ControlClienteModificacionALta(int pIdCliente)
		{
			List<Alojamiento> auxListaAloj = new ControladorAlojamiento().ObtenerAlojamientosActivos();

			foreach (Alojamiento aloj in auxListaAloj)
			{
				foreach (Cliente cli in aloj.Clientes)
				{
					if (cli.ClienteId == pIdCliente)
					{
						throw new Exception("El Cliente seleccionado se encuentra en un Alojamiento Reservado o Alojado, por lo que es posible modificar su Estado");
					}
				}
			}
		}

	}
}
