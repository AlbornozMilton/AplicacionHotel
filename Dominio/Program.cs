using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            TarifaCliente lTarifaCliente = new TarifaCliente();
            Alojamiento lAlojamiento = new Alojamiento();
            List<Cliente> lClientes = new List<Cliente>();
            Habitacion lHabitacion = new Habitacion(1, 4, 0, true);

            Cliente lCliente1 = new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);
            Cliente lCliente2 = new Cliente(37000000, "Josefina", "Chamorro", "3456542154", TipoCliente.AcompanianteDirecto);
            Cliente lCliente3 = new Cliente(13123412, "Jaimito", "Chamorro", "3456542154", TipoCliente.AcompanianteNoDirecto);
            Cliente lCliente4 = new Cliente(44134234, "Clara", "Burna", "3456542154", TipoCliente.TitularExceptuado);

            lClientes.Add(lCliente1);
            lClientes.Add(lCliente2);
            lClientes.Add(lCliente3);
            lClientes.Add(lCliente4);

            lAlojamiento.Habitacion = lHabitacion; //exclusividad en true
            lAlojamiento.Clientes = lClientes;

            lAlojamiento.FechaEstimadaIngreso = DateTime.Now;
            lAlojamiento.FechaEstimadaEgreso = (DateTime.Now).AddDays(2);

            Console.ReadKey();
        }
    }
}
