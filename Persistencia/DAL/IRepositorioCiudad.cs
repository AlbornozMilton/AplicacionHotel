using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    public interface IRepositorioCiudad:IRepositorio<Ciudad>
    {
		Ciudad GetCiudad(int pCodPostal, string pNombre);
		IEnumerable<string> CallesDeCiudad(int pCodPostal, string pNombre);
		void ModificarCiudad(Ciudad pCiudad, int pKeyCiudad);
		void EliminarCiudad(int pKeyCiudad);
	}
}
