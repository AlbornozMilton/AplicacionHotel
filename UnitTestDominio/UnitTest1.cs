﻿using System;
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
            Cliente lCliente1 = new Cliente(37115628, "Mauricio", "Chamorro", 34565154, TipoCliente.Titular);
            TarifaCliente lTarifaCliente = new TarifaCliente();

            Assert.AreEqual(lResultEsperado, iControlador.ObteberTarifa(lCliente1, lTarifaCliente, lExclusividad));
        }
        
        [TestMethod]
        public void TestCalcularCostoBase()
        {
            double lResultEsperado = 225 * 2;

            TarifaCliente lTarifaCliente = new TarifaCliente();
            Alojamiento lAlojamiento = new Alojamiento((DateTime.Now).AddDays(2));
            List<Cliente> lClientes = new List<Cliente>();
            Habitacion lHabitacion = new Habitacion(1, 0, true);

            Cliente lCliente1 = new Cliente(37115628, "Mauricio", "Chamorro", 56542154, TipoCliente.Titular);
            Cliente lCliente2 = new Cliente(37000000, "Josefina", "Chamorro", 56545661, TipoCliente.AcompanianteDirecto);
            Cliente lCliente3 = new Cliente(37158562, "Jaimito", "Chamorro", 56546889, TipoCliente.AcompanianteNoDirecto);
            Cliente lCliente4 = new Cliente(39284512, "Clara", "Burna", 6543221, TipoCliente.TitularExceptuado);

            lClientes.Add(lCliente1);
            lClientes.Add(lCliente2);
            lClientes.Add(lCliente3);
            lClientes.Add(lCliente4);

            lAlojamiento.Habitacion = lHabitacion; //exclusividad en true
            lAlojamiento.Clientes = lClientes;

            //diferencia de dias = 2

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
        public void TestOperacionesHabitacion()
        {
            Habitacion lHabitacion = new Habitacion(1, 0, false);
            //Verificando Capacidad Total de habitacion
            byte lResulEsperado = 6;
            Assert.AreEqual(lResulEsperado, lHabitacion.CapacidadTotal());

            //Verificando Capacidad actual de habitacion
            lResulEsperado = 5;
            Assert.AreEqual(lResulEsperado, lHabitacion.Capacidad);
            
            //Verificando cupos simples disponibles
            lResulEsperado = 1;
            Assert.AreEqual(lResulEsperado, lHabitacion.CuposSimpleDisponibles());

            //Verificando cupos dobles disponibles
            lResulEsperado = 2;
            Assert.AreEqual(lResulEsperado, lHabitacion.CuposDoblesDisponibles());

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
