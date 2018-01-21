using System;
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

        /// <summary>
        /// Requisito Obligatorio: la ciudad debe existir sino agregarla.
        /// </summary>
        public override void Add(Cliente pCliente)
        {
            Ciudad ciudad = iDbContext.Ciudades.Include("Domicilios").Single(c => c.CiudadId == pCliente.Domicilio.Ciudad.CiudadId);

            Domicilio domicilio = null;

            foreach (var dom in ciudad.Domicilios)
            {
                if
                    (
                     dom.Calle == pCliente.Domicilio.Calle &&
                     dom.Numero == pCliente.Domicilio.Numero &&
                     dom.NroDepto == pCliente.Domicilio.NroDepto &&
                     dom.Piso == pCliente.Domicilio.Piso
                    )
                {
                    domicilio = dom;
                    break;
                }
            }

            if (domicilio == null)
            {
                pCliente.Domicilio.CiudadId = pCliente.Domicilio.Ciudad.CiudadId;
                pCliente.Domicilio.Ciudad = null;
                this.iDbContext.Domicilios.Add(pCliente.Domicilio);

                //futuro prox ID 
                pCliente.DomicilioId = this.iDbContext.Domicilios.Max(d => d.DomicilioId) + 1;
                iDbContext.SaveChanges();
            }
            else
            {
                pCliente.DomicilioId = domicilio.DomicilioId;
                pCliente.Domicilio = null;
            }

            //this.VerificarDomicilio(pCliente);

            pCliente.EnAlta = true;
            pCliente.Domicilio = null;
            pCliente.TarifaClienteId = pCliente.TarifaCliente.TarifaClienteId;
            pCliente.TarifaCliente = null; 

            iDbContext.Clientes.Add(pCliente);

            iDbContext.SaveChanges();
        }

        public IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre, bool pAlta)
        {
            var clientes = from cli in this.iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad")
                           where ((cli.Nombre+cli.Apellido).Contains(pNombre))&&(cli.EnAlta == pAlta)
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
        /// Se exceptua la modificación para DNI.
        /// Requisito Obligatorio: la ciudad debe existir sino agregarla.
        /// </summary>
        public void ModificarDatosCliente(Cliente pCliente)
        {
            Cliente localCliente = this.GetPorDNI(pCliente.ClienteId, pCliente.EnAlta);

            if (localCliente.DomicilioId != pCliente.Domicilio.DomicilioId)
            {
                //this.VerificarDomicilio(pCliente); 
                pCliente.Domicilio.CiudadId = pCliente.Domicilio.Ciudad.CiudadId;
                pCliente.Domicilio.Ciudad = null;
                this.iDbContext.Domicilios.Add(pCliente.Domicilio);

                //futuro prox ID 
                localCliente.DomicilioId = this.iDbContext.Domicilios.Max(d => d.DomicilioId) + 1;
                iDbContext.SaveChanges();
            }

            CargarCliente(localCliente, pCliente);

            

            iDbContext.SaveChanges();
        }

        private void CargarCliente(Cliente pClienteViejo, Cliente pClienteNuevo)
        {
            // el domicilio tiene que haberse creado 
            pClienteViejo.Legajo = pClienteNuevo.Legajo;
            pClienteViejo.Nombre = pClienteNuevo.Nombre;
            pClienteViejo.Apellido = pClienteNuevo.Apellido;
            pClienteViejo.Telefono = pClienteNuevo.Telefono;
            pClienteViejo.TarifaClienteId = pClienteNuevo.TarifaCliente.TarifaClienteId;
            pClienteViejo.DomicilioId = pClienteNuevo.Domicilio.DomicilioId;
        }

        public void ModificarDNICliente(Cliente pCliente, int pLegajo)
        {
            Cliente localCliente = this.GetPorLegajo(pLegajo,pCliente.EnAlta);

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

        //private void VerificarDomicilio(Cliente pCliente)
        //{
        //    Ciudad ciudad = iDbContext.Ciudades.Include("Domicilios").Single(c => c.CiudadId == pCliente.Domicilio.Ciudad.CiudadId);

        //    Domicilio domicilio = null;

        //    foreach (var dom in ciudad.Domicilios)
        //    {
        //        if
        //            (
        //             dom.Calle == pCliente.Domicilio.Calle &&
        //             dom.Numero == pCliente.Domicilio.Numero &&
        //             dom.NroDepto == pCliente.Domicilio.NroDepto &&
        //             dom.Piso == pCliente.Domicilio.Piso
        //            )
        //        {
        //            domicilio = dom;
        //            break;
        //        }
        //    }

        //    if (domicilio == null)
        //    {
        //        pCliente.Domicilio.CiudadId = pCliente.Domicilio.Ciudad.CiudadId;
        //        pCliente.Domicilio.Ciudad = null;
        //        this.iDbContext.Domicilios.Add(pCliente.Domicilio);

        //        //futuro prox ID 
        //        pCliente.DomicilioId = this.iDbContext.Domicilios.Max(d => d.DomicilioId) + 1;
        //        iDbContext.SaveChanges();
        //    }
        //    else
        //    {
        //        pCliente.DomicilioId = domicilio.DomicilioId;
        //        pCliente.Domicilio = null;
        //    }
        //}
    }
}
