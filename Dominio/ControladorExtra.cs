using System;
using System.Collections.Generic;
using Persistencia.DAL.EntityFramework;
using pers = Persistencia.Domain;
using AutoMapper;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

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

		public void ModificarCiudad(string pCodPostalViejo, string pNombreViejo, string pCodPostalNuevo, string pNombreNuevo, List<Ciudad> pCiudades)
		{
			if (pCiudades.Exists(c => c.Nombre == pNombreNuevo))
				throw new Exception("Nombre de Ciudad ya existente");

			iUoW.RepositorioCiudad.ModificarCiudad(Mapper.Map<Ciudad, pers.Ciudad>(new Ciudad(Convert.ToInt32(pCodPostalNuevo), pNombreNuevo)),
				pCiudades.Find(c => c.Nombre == pNombreViejo && c.CodPostal.ToString() == pCodPostalViejo).CiudadId);
		}

		public void EliminarCiudad(int pKeyCiudad)
		{
			iUoW.RepositorioCiudad.EliminarCiudad(pKeyCiudad);
		}

		public string DeterminarColor(Alojamiento aloj)
		{
			string color = "White";
			
			if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado && aloj.FechaEstimadaIngreso.Date.CompareTo(DateTime.Now.Date) == 0)
			{
				color = "Aquamarine"; //alojamientos que se deben dar de alta hoy
			}
			else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado && aloj.FechaEstimadaEgreso.Date.CompareTo(DateTime.Now.Date) == 0)
			{
				color = "DarkTurquoise"; //alojamientos que se deben cerrar hoy
			}
			else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado && aloj.FechaEstimadaIngreso.Date.CompareTo(DateTime.Now.Date) < 0)
			{
				color = "Pink"; //alojamientos reservados sin dado de alta tras pasar fecha de ingreso
			}
			else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado && aloj.FechaEstimadaEgreso.Date.CompareTo(DateTime.Now.Date) < 0)
			{
				color = "Plum"; //alojamientos sin dar de baja tras pasar fecha de egreso
			}
			else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Cerrado && aloj.MontoDeuda > 0)
			{
				if (!aloj.Pagos.Exists(p => p.Tipo == TipoPago.Servicios))
				{
					color = "Orange"; //alojamientos cerrados sin pago de servicios:
				}
				else
				{
					color = "OrangeRed"; //alojamientos cerrados adeudados (pago de servicios incompleto)
				}
			}
			else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado
				&&
				(
					(DateTime.Now.Subtract(aloj.FechaReserva).Ticks >= (TimeSpan.TicksPerHour * 72))
						&
						!aloj.Pagos.Exists(p => p.Tipo == TipoPago.Deposito)//no existe pago de deposito
					)
				)
			{
				color = "Gold"; //sin deposito tras 72hs
			}

			return color;
		}

		public bool ValidarEmail(string strIn)
		{
			if (String.IsNullOrEmpty(strIn))
				return false;

			// Use IdnMapping class to convert Unicode domain names.
			try
			{
				strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
									  RegexOptions.None, TimeSpan.FromMilliseconds(200));
			}
			catch (ArgumentException)
			{
				return false;
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}

			// Return true if strIn is in valid email format.
			try
			{
				return Regex.IsMatch(strIn,
					  @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
					  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
					  RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

		private string DomainMapper
            (Match match)
		{
			// IdnMapping class with default property values.
			IdnMapping idn = new IdnMapping();

			string domainName = match.Groups[2].Value;
			domainName = idn.GetAscii(domainName);
			return match.Groups[1].Value + domainName;
		}
	}
}
