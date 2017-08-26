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
            Habitacion lHabitacion = new Habitacion(1, 0, true);

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

        [TestMethod]
        public void TestOcuparDesocuparCupos()
        {
            Habitacion lHabitacion = new Habitacion(1, 0, false);
            List<Cupo> lCuposEsperados = new List<Cupo>()
            {
                new Cupo(1, TipoCupo.simple, false),
                new Cupo(2, TipoCupo.doble, false),
                new Cupo(3, TipoCupo.simple, false),
                new Cupo(4, TipoCupo.doble, true)
            };

            //Verificacion si se ocuparon un cupo simple y un cupo doble
            lHabitacion.OcuparCupos2(1, 1);
            bool restEsperado = false;

            for (int i = 0; i < lHabitacion.Cupos.Count; i++)
            {
                if (        lHabitacion.Cupos[i].CodCupo == lCuposEsperados[i].CodCupo &
                            lHabitacion.Cupos[i].TipoCupo == lCuposEsperados[i].TipoCupo &
                            lHabitacion.Cupos[i].Disponible == lCuposEsperados[i].Disponible)
                {
                    restEsperado = true;
                }
                else
                {
                    restEsperado = false;
                    break;
                }
            }
            Assert.AreEqual(restEsperado, true);

            //-------------------- DESOCUPAR
            lHabitacion.DesocuparCupos(2, 1);
            
            lCuposEsperados = new List<Cupo>()
            {
                new Cupo(1, TipoCupo.simple, true),
                new Cupo(2, TipoCupo.doble,  true),
                new Cupo(3, TipoCupo.simple, true),
                new Cupo(4, TipoCupo.doble, true)
            };

            restEsperado = true;

            for (int i = 0; i < lHabitacion.Cupos.Count; i++)
            {
                if (!(lHabitacion.Cupos[i].CodCupo == lCuposEsperados[i].CodCupo &
                            lHabitacion.Cupos[i].TipoCupo == lCuposEsperados[i].TipoCupo &
                            lHabitacion.Cupos[i].Disponible == lCuposEsperados[i].Disponible))
                {
                    restEsperado = false;
                    break;
                }
            }
            Assert.AreEqual(true, restEsperado);
        }

        [TestMethod]
        public void TestTipoReferenciaCupos()
        {
            Habitacion lHabitacion = new Habitacion(1, 0, false);
            //Verificando Capacidad de habitacion
            int lResulEsperado = 6;
            Assert.AreEqual(lResulEsperado, lHabitacion.Capacidad);

            //// se verifica que lCuposEsperados aputa a lHabitacion.Cupos, y son iguales a pesar de la modificacion solo a lHabitacion.Cupos
            List<Cupo> lCuposEsperados = lHabitacion.Cupos;
            lHabitacion.OcuparCupos(1, 1);
            Assert.AreEqual(lCuposEsperados, lHabitacion.Cupos);

            //// se verifica que lCuposEsperados no apunta a lHabitacion.Cupos, y son distintos luego de la modificacion solo a lHabitacion.Cupos
            lHabitacion = new Habitacion(1, 0, false);
            lCuposEsperados = new List<Cupo>(lHabitacion.Cupos);
            lHabitacion.OcuparCupos(1, 1);
            Assert.AreNotEqual(lCuposEsperados, lHabitacion.Cupos);

        }
    }
}
