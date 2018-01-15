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

            pCliente.EnAlta = true;
            pCliente.Domicilio = null;
            pCliente.TarifaClienteId = pCliente.TarifaCliente.TarifaClienteId;
            pCliente.TarifaCliente = null; 

            iDbContext.Clientes.Add(pCliente);

            iDbContext.SaveChanges();
        }

        public IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre)
        {
            var clientes = from cli in this.iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad")
                           where ((cli.Nombre+cli.Apellido).Contains(pNombre))&&(cli.EnAlta == true)
                           select cli;

            return clientes.ToList<Cliente>();
        }

        public override Cliente Get(int pId)
        {
            try
            {
                return iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad").Where(c => c.ClienteId == pId && c.EnAlta == true).Single();
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

        public Cliente GetPorLegajo(int pLegajo)
        {
            try
            {
                return iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio.Ciudad").Where(c => c.Legajo == pLegajo && c.EnAlta == true).Single();
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
    }
}
