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
        List<Ciudad> Ciudades;
        List<TarifaCliente> Tarifas;
        static IEnumerable<pers.Usuario> iUsuarios;

        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //--------------------------------------METODOS------------------

        /// <summary>
        /// Retoran verdadero si el mismo domicilio existe.
        /// </summary>
        public void CargarDomicilio(string pCalle, string pNumCalle, string pPiso, string pNumDpto, string pCodPostal)
        {
            Ciudad auxCiudad = Mapper.Map < pers.Ciudad, Ciudad>(iUoW.RepositorioCiudad.Get(Convert.ToInt32(pCodPostal)));
            this.Domicilio = new Domicilio(pCalle, pNumCalle, pNumDpto, pPiso, auxCiudad);
        }

        public bool ExisteClienteDNI(string pDNI)
        {
            return iUoW.RepositorioCliente.ExisteClienteDNI(Convert.ToInt32(pDNI));
        }

        public bool ExisteClienteLegajo(string pLegajo)
        {
            return iUoW.RepositorioCliente.ExisteClienteLegajo(Convert.ToInt32(pLegajo));
        }

        public void NuevoCliente (string pDni, string pLegajo, string pNombre, string pApellido, string pTel, string pCorreo, string pTipoCliente)
        {
            this.Cliente = new Cliente(Convert.ToInt32(pDni), Convert.ToInt32(pLegajo), pNombre, pApellido, pTel, pCorreo, this.Domicilio, Tarifas.Find(t => t.NombreTarifa == pTipoCliente));
            iUoW.RepositorioCliente.Add(Mapper.Map<Cliente, pers.Cliente>(this.Cliente));
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

        public Cliente BuscarClientePorDni(int unDni, bool pAlta)
        {
            return (Mapper.Map<pers.Cliente, Cliente>(iUoW.RepositorioCliente.GetPorDNI(unDni, pAlta)));
        }

        public List<string> ObenerCallesDeCiudad(string pCodPostal)
        {
            List<string> calles = new List<string>();
            foreach (var calle in iUoW.RepositorioCiudad.CallesDeCiudad(Convert.ToInt32(pCodPostal)))
            {
                calles.Add(calle.ToString());
            }
            return calles;
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

        public List<Cliente> GetAllClientes()
        {
            IEnumerable<pers.Cliente> listaEnum = iUoW.RepositorioCliente.GetAll();
            List<Cliente> lista = new List<Cliente>();
            foreach (var i in listaEnum)
            {
                lista.Add(Mapper.Map<pers.Cliente, Cliente>(i));
            }
            return (lista);
        }

        public void ModificarAltaCliente(bool pValor, int pIdCliente)
        {
            iUoW.RepositorioCliente.ModificarAlta(pValor,pIdCliente);
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

            this.Tarifas = TarifasClientes;
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

        public void ControlCuposConClientes(Cliente pResponsable, string pContadores, decimal pCantS, decimal pCantD)
        {
            decimal auxCantidad = pCantS + pCantD * 2;
            decimal auxCantidadContadores = 0;
            bool contieneResponsable = false;
            int auxTipo = Convert.ToInt32(pResponsable.TarifaCliente.TarifaClienteId);

            for (int i = 0; i < pContadores.Length; i++)
            {
                if (Convert.ToDecimal(pContadores[i].ToString()) > 0)
                {
                    auxCantidadContadores += Convert.ToDecimal(pContadores[i].ToString());
                    if (i == auxTipo)
                    {
                        contieneResponsable = true;
                    } 
                }
            }
              
            if (!contieneResponsable)
            {
                throw new Exception("Los contadores de Tipo de Clientes ingresados debe contener al Responsable.");
            }

            if (auxCantidad != auxCantidadContadores)
            {
                throw new Exception("Las cantidades de cupos ingresadas no corresponden con la cantidad de Clientes cargados.");
            }
        }

        /// <summary>
        /// Produce excepción si el Cliente elegido ya se encuentra en algún Alojamiento Activo.
        /// </summary>
        public void ControlClienteActivo(Cliente pCliente, EstadoAlojamiento pEstado, DateTime pFechaDesde, DateTime pFechaHasta)
        {
            List<Alojamiento> auxListaAloj = new ControladorAlojamiento().ObtenerAlojamientosActivos();

            foreach (var aloj in auxListaAloj)
            {
                foreach (var cliente in aloj.Clientes)
                {
                    if (cliente.ClienteId == pCliente.ClienteId)
                    {
                        if (pEstado == EstadoAlojamiento.Alojado && aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        {
                            throw new Exception("El Cliente seleccionado ya es encuentra en un Alojamiento Alojado.");
                        }
                        else if (pEstado == EstadoAlojamiento.Reservado && aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                        {
                            //control de fechas
                            if 
                                (
                                    !(aloj.FechaEstimadaIngreso.Date.CompareTo(pFechaDesde.Date) >= 0 && aloj.FechaEstimadaIngreso.Date.CompareTo(pFechaHasta.Date) >= 0)
                                    &&
                                    !(aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaDesde.Date) <= 0 && aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaHasta.Date) <= 0)
                                )
                            {
                                throw new Exception("El Cliente seleccionado ya es encuentra en un Alojamiento Reservado entre las Fechas seleccionadas.");
                            }
                        }
                    }
                }
            }
        }

        public void ModificarAltaCliente(int pDNI, bool pValoAlta)
        {
            iUoW.RepositorioCliente.ModificarAlta(pValoAlta, pDNI);
        }

    }
}
