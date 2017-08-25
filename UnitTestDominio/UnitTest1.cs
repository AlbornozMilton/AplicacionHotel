using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Dominio;

namespace UnitTestDominio
{
    [TestClass]
    public class UnitTest1
    {
        ControladorAlojamiento iControlador = new ControladorAlojamiento();
              


        [TestMethod]
        public void TestObteberTarifa() 
        {
            double lResultEsperado = 50;
            bool lExclusividad = true;
            Cliente lCliente1 = new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);
            TarifaCliente lTarifaCliente = new TarifaCliente();

            Assert.AreEqual(lResultEsperado, iControlador.ObteberTarifa(lCliente1, lTarifaCliente, lExclusividad));

        }

        
        [TestMethod]
        public void TestCalcularCostoBase()
        {
            double lResultEsperado = 225 * 2;

            TarifaCliente lTarifaCliente = new TarifaCliente();
            Alojamiento lAlojamiento = new Alojamiento();
            List<Cliente> lClientes = new List<Cliente>();
            Habitacion lHabitacion = new Habitacion(1, 4, 0, true);

            Cliente lCliente1 = new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);
            Cliente lCliente2 = new Cliente(37000000, "Josefina", "Chamorro", "3456545661", TipoCliente.AcompanianteDirecto);
            Cliente lCliente3 = new Cliente(37158562, "Jaimito", "Chamorro", "3456546889", TipoCliente.AcompanianteNoDirecto);
            Cliente lCliente4 = new Cliente(39284512, "Clara", "Burna", "3456543221", TipoCliente.TitularExceptuado);

            lClientes.Add(lCliente1);
            lClientes.Add(lCliente2);
            lClientes.Add(lCliente3);
            lClientes.Add(lCliente4);

            lAlojamiento.Habitacion = lHabitacion; //exclusividad en true
            lAlojamiento.Clientes = lClientes;

            //diferencia de dias = 2
            lAlojamiento.FechaEstimadaIngreso = DateTime.Now;
            lAlojamiento.FechaEstimadaEgreso = (DateTime.Now).AddDays(2);

            //----------------Para el caso de exclusividad de la habitacion en verdadero
            Assert.AreEqual(lResultEsperado, lAlojamiento.CalcularCostoBase(lTarifaCliente));


            //----------------Para el caso de exclusividad de la habitacion en falso
            lAlojamiento.Habitacion.Exclusiva = false;
            int lResultEsperado2 = 1000;
            Assert.AreEqual(lResultEsperado2, lAlojamiento.CalcularCostoBase(lTarifaCliente));

            // cuando se da de alta un alojamiento sin reserva o se confirma... la fecha estimada de ingreso debe ser "null"
            lAlojamiento.FechaEstimadaIngreso = default(DateTime);
            lAlojamiento.FechaIngreso = DateTime.Now;

            Assert.AreEqual(lResultEsperado2, lAlojamiento.CalcularCostoBase(lTarifaCliente));


        }
    }
}
