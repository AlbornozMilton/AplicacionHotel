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
            ControladorAlojamiento iControlador = new ControladorAlojamiento();

            //instancias solo para prueba
            Cliente lCliente = new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);
            TarifaCliente lTarifaCliente = new TarifaCliente();
            bool lExclusividad = true;

            //---------------------------

            Console.WriteLine(iControlador.ObteberTarifa(lCliente, lTarifaCliente, lExclusividad) );

            Console.ReadKey();
        }
    }
}
