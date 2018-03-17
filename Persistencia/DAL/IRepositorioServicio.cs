using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioServicio: IRepositorio<Servicio>
    {
        Servicio GetByNombre(string pNombreServicio);
		void ActualizarCostoServicio(Servicio pServicio);
	}
}
