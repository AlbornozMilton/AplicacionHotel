using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
	public class RepositorioCiudad : Repositorio<Ciudad, HotelContext>, IRepositorioCiudad
	{
		public RepositorioCiudad(HotelContext pContext) : base(pContext)
		{

		}

		public Ciudad GetCiudad(int pCodPostal, string pNombre)
		{
			return iDbContext.Ciudades.Include("Domicilios").SingleOrDefault(c => c.CodPostal == pCodPostal && c.Nombre == pNombre);
		}

		public IEnumerable<string> CallesDeCiudad(int pCodPostal, string pNombre)
		{
			var calles = from domicilio in iDbContext.Domicilios
						 where pCodPostal == domicilio.Ciudad.CodPostal && pNombre == domicilio.Ciudad.Nombre
						 select domicilio.Calle;

			return calles.Distinct();
		}

		public override void Add(Ciudad pCiudad)
		{
			//Ciudad localCiudad = GetCiudad(pCiudad.CodPostal, pCiudad.Nombre);

			foreach (Ciudad lciudad in iDbContext.Ciudades)
			{
				if (lciudad.Nombre == pCiudad.Nombre)
				{
					throw new Exception("Nombre de Ciudad Existente");
				}
			}
			//if (localCiudad != null)
			//	throw new Exception("Ciudad Existente");

			//if (localCiudad.Nombre == pCiudad.Nombre)
			//	throw new Exception("Nombre de Ciudad Existente");

			iDbContext.Ciudades.Add(pCiudad);
			iDbContext.SaveChanges();
		}

		public void ModificarCiudad(Ciudad pCiudad, int pKeyCiudad)
		{
			Ciudad localCiudad = iDbContext.Ciudades.Find(pKeyCiudad);
			if (localCiudad == null)
				throw new Exception("Ciudad Inexistente");
			else
			{
				localCiudad.CodPostal = pCiudad.CodPostal;
				localCiudad.Nombre = pCiudad.Nombre;
				iDbContext.SaveChanges();
			}
		}

		public void EliminarCiudad(int pKeyCiudad)
		{
			Ciudad localCiudad = iDbContext.Ciudades.Find(pKeyCiudad);
			if (localCiudad == null)
				throw new Exception("Ciudad Inexistente");
			else
			{
				iDbContext.Ciudades.Remove(localCiudad);
				iDbContext.SaveChanges();
			}
		}
	}
}
