﻿using System;
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

        void AddReserva(Alojamiento unAloj);
        void AddPago(Alojamiento unAloj, Pago pPago);
    }
}
