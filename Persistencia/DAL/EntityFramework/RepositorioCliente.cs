﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCliente : Repositorio<Cliente, HotelContext>, IRepositorioCliente
    {
        public RepositorioCliente(HotelContext pContext) : base(pContext)
        {

        }

        public IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre, bool pAlta)
        {
            var clientes = from cli in this.iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad")
                           where ((cli.Nombre + cli.Apellido).Contains(pNombre)) && (cli.EnAlta == pAlta)
                           select cli;

            return clientes.ToList<Cliente>();
        }

        public Cliente GetPorDNI(int pId, bool pAlta)
        {
            try
            {
                return iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad").Where(c => c.ClienteId == pId && c.EnAlta == pAlta).Single();
            }
            catch
            {
                throw new Exception("Cliente No Existe");
            }
        }

        /// <summary>
        /// Retorna una lista con todos Clientes aunque no esten en Alta
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Cliente> GetAll()
        {
            return iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad");
        }

        public bool ExisteClienteDNI(int pDNI)
        {
            foreach (var cli in iDbContext.Clientes)
            {
                if (cli.ClienteId == pDNI)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ExisteClienteLegajo(int pLegajo)
        {
            foreach (var cli in iDbContext.Clientes)
            {
                if (cli.Legajo == pLegajo)
                {
                    return true;
                }
            }
            return false;
        }

        public Cliente GetPorLegajo(int pLegajo, bool pAlta)
        {
            try
            {
                return iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad").Where(c => c.Legajo == pLegajo && c.EnAlta == pAlta).Single();
            }
            catch
            {
                throw new Exception("Cliente No Existe");
            }
        }

        public void ModificarAlta(bool pValor, int pIdCliente)
        {
            iDbContext.Clientes.Find(pIdCliente).EnAlta = pValor;
            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Si el cliente existe actualiza los cambios, sino lo agrega.
        /// </summary>
        public void ActualizarCliente(Cliente pCliente, int pIdDomicilio)
        {
            Cliente localCliente = this.GetPorDNI(pCliente.ClienteId, pCliente.EnAlta);
            pCliente.Domicilio = null;

            //if (ExisteClienteDNI(pCliente.ClienteId))
            if (localCliente != null) //MODIFICACION
            {
                CargarCliente(localCliente, pCliente, pIdDomicilio);
                pCliente.TarifaCliente = null;
            }
            else //NUEVO CLIENTE
            {
                pCliente.EnAlta = true;
                pCliente.DomicilioId = pIdDomicilio;
                pCliente.TarifaClienteId = pCliente.TarifaCliente.TarifaClienteId;
                pCliente.TarifaCliente = null;
                iDbContext.Clientes.Add(pCliente);
            }

            iDbContext.SaveChanges();
        }

        private void CargarCliente(Cliente pClienteViejo, Cliente pClienteNuevo, int pIdDomicilio)
        {
            pClienteViejo.Legajo = pClienteNuevo.Legajo;
            pClienteViejo.Nombre = pClienteNuevo.Nombre;
            pClienteViejo.Apellido = pClienteNuevo.Apellido;
            pClienteViejo.Telefono = pClienteNuevo.Telefono;
            pClienteViejo.TarifaClienteId = pClienteNuevo.TarifaCliente.TarifaClienteId;
            pClienteViejo.DomicilioId = pIdDomicilio;
        }

        /// <summary>
        /// Actualiza el DNI de un Cliente en base a su Legajo
        /// </summary>
        public void ModificarDNICliente(Cliente pCliente, int pLegajo)
        {
            Cliente localCliente = this.GetPorLegajo(pLegajo, pCliente.EnAlta);

            //cambiar el cliente para todos los alojamientos en los que estuvo y esta.
            foreach (var aloj in iDbContext.Alojamientos)
            {
                foreach (var cli in aloj.Clientes)
                {
                    if (cli.ClienteId == localCliente.ClienteId)
                    {
                        cli.ClienteId = pCliente.ClienteId;
                    }
                }
            }

            localCliente.ClienteId = pCliente.ClienteId;

            iDbContext.SaveChanges();
        }
    }
}