using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using pers = Persistencia.Domain;
using AutoMapper;
using System.Windows.Forms;

namespace Dominio
{
    public class ControladorExtra
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        public void EsLetra (KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                throw new Exception("Se deben ingresar solo Letras");
            }
        }

        public void EsNumero(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                throw new Exception("Se deben ingresar solo Números sin espacio");
            }
        }
        public bool IsNumeric (string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 

        public List<Servicio> ObtenerServicios()
        {
            IEnumerable<pers.Servicio> listaEnum = iUoW.RepositorioServicio.GetAll();
            List<Servicio> lista = new List<Servicio>();

            foreach (var serv in listaEnum)
            {
                lista.Add(Mapper.Map<pers.Servicio, Servicio>(serv));
            }
            return (lista);
        }

        public void AcutalizarCostoServicio(Servicio pServicio, string pCosto)
        {
            pServicio.ActualizarCosto(Convert.ToDouble(pCosto));
            iUoW.RepositorioServicio.ActualizarCostoServicio(Mapper.Map<Servicio, pers.Servicio>(pServicio));
        }

        public void ActualizarTarifa(TarifaCliente pTarifa, string pCostoNoExcl, string pCostoExcl)
        {
            if (pCostoNoExcl == "")
            {
                throw new Exception("Debe ingresar una nuevo Costo de Tarifa");
            }
            else if (pCostoExcl == "")
            {
                throw new Exception("Debe ingresar una nuevo Costo de Tarifa Exclusiva");
            }
            else if ((!IsNumeric(pCostoExcl)) || (!IsNumeric(pCostoNoExcl)))
            {
                throw new Exception("Debe ingresar solo números");
            }

            pTarifa.ActualizarMontos(Convert.ToDouble(pCostoNoExcl), Convert.ToDouble(pCostoExcl));
            iUoW.RepositorioTarifa.ActualizarMontos(Mapper.Map<TarifaCliente, pers.TarifaCliente>(pTarifa));
        }

        /// <summary>
        /// Retorna lista de alojamientos a cancelar
        /// </summary>
        public List<Alojamiento> AlojamientosACancelar()
        {
            List<Alojamiento> Resultado = new List<Alojamiento>();
            List<Alojamiento> Activos = new ControladorAlojamiento().ObtenerAlojamientosActivos();

            foreach (var aloj in Activos)
            {
                if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado && aloj.FechaEstimadaIngreso.Date.CompareTo(DateTime.Now.Date) == 0)
                {
                    Resultado.Add(aloj);
                }
            }
            return Resultado;
        }

        /// <summary>
        /// Retorna lista de alojamientos que deben cerrarse hoy
        /// </summary>
        public List<Alojamiento> AlojamientosACerrar()
        {
            List<Alojamiento> Resultado = new List<Alojamiento>();
            List<Alojamiento> Activos = new ControladorAlojamiento().ObtenerAlojamientosActivos();

            foreach (var aloj in Activos)
            {
                if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado && aloj.FechaEstimadaEgreso.Date.CompareTo(DateTime.Now.Date) == 0)
                {
                    Resultado.Add(aloj);
                }
            }
            return Resultado;
        }

		public void NuevaCiudad(string pCodPostal, string pNombre)
		{
			iUoW.RepositorioCiudad.Add(Mapper.Map<Ciudad, pers.Ciudad>(new Ciudad(Convert.ToInt32(pCodPostal), pNombre)));
		}
        
    }
}
