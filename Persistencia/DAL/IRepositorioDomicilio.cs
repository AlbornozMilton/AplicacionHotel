using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioDomicilio:IRepositorio<Domicilio>
    {
        /// <summary>
        /// Retorna el ID del Domicilio que ya existe o el nuevo.
        /// </summary>
        /// <returns>ID domicilio</returns>
        Domicilio CargaDomicilio(Domicilio pDom);
    }
}
