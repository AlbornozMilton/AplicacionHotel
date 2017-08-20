using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace UnitTestDominio
{
    [TestClass]
    public class UnitTest1
    {
        ControladorAlojamiento iControlador = new ControladorAlojamiento();
        TarifaCliente lTarifaCliente = new TarifaCliente();

        Cliente lCliente = new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);

        [TestMethod]
        public void TestObteberTarifa()
        {
            double lResultEsperado = 50;
            bool lExclusividad = true;

            Assert.AreEqual(lResultEsperado, iControlador.ObteberTarifa(lCliente, lTarifaCliente, lExclusividad));

        }
    }
}
