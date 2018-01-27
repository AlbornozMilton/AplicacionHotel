using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioAlojamiento:IRepositorio<Alojamiento>
    {
        IEnumerable<Alojamiento> GetAllAlojamientosActivos();
        IEnumerable<Alojamiento> AlojamientosConDeuda();
        void AddPago(Alojamiento unAloj, Pago pPago);
        void AddLineaServicio(Alojamiento unAloj, LineaServicio pLineaServicio);
        void FinalizarAlojamiento(Alojamiento unAloj);
        void AltaReserva(Alojamiento unAloj);
        IEnumerable<Alojamiento> ListaPersonalizada(List<EstadoAlojamiento> pEstados, DateTime pDesde, DateTime pHasta);
        int UltimoAgregado();

    }

}
