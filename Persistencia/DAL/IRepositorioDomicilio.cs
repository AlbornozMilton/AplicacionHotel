using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioDomicilio:IRepositorio<Domicilio>
    {
        /// <summary>
        /// Retorna el ID del Domicilio que ya existe o el nuevo.
        /// </summary>
        /// <returns>ID domicilio</returns>
        int ComprobarDomicilio(Domicilio pDom);
    }
}
