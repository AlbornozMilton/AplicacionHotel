﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladorAlojamiento
    {
        public Alojamiento NuevoAlojSinReserva()
        {
            Alojamiento lAlojamiento = new Alojamiento();
            TarifaCliente lTarifaCliente = new TarifaCliente();

            //-------determinar disponibilidad



            Habitacion lHabitacion = new Habitacion(1, 4, 0, true); //exclusividad en true

            //-------------------------

            

            // ---------------BUSCAR y Asociar Cliente responsable
            bool op;
            do
            {
                int lDNI = 37115628; //dni desde la interfaz
                Cliente lResponsable = this.BuscarCliente(lDNI);
                op = false;

                if (lResponsable.TipoCliente != TipoCliente.Titular)
                {
                    //obtener el valor de "op" desde la interfaz

                    if (op == true)
                    {
                        lAlojamiento.DniResponsable = lResponsable.Dni;
                        lAlojamiento.AgregarCliente(lResponsable);
                        //op tendra el valor de true, que luego corta el while
                    }

                }else
                {
                    lAlojamiento.DniResponsable = lResponsable.Dni;
                    lAlojamiento.AgregarCliente(lResponsable);
                    op = true;
                    //mostrar en la interfaz
                }

            } while (op == false);
            //////-----------------------


            //----------------------- 

            //obtener cantS y cantD desde la interfaz
            // notificar si las cantidades no son del tipo byte como excepcion
            byte cantS = 2;
            byte cantD = 1;

            do
            {
                op = VerificarCuposIngresados(cantS, cantD, lAlojamiento);
                //notificar mediante interfaz cantidades no corresponden
                
            } while (op == false);


            //------------------------------------

            Cliente lCliente2 = new Cliente(37000000, "Josefina", "Chamorro", "3456542154", TipoCliente.AcompanianteDirecto);
            Cliente lCliente3 = new Cliente(13123412, "Jaimito", "Chamorro", "3456542154", TipoCliente.AcompanianteNoDirecto);
            Cliente lCliente4 = new Cliente(44134234, "Clara", "Burna", "3456542154", TipoCliente.TitularExceptuado);

            lAlojamiento.AgregarCliente(lCliente2);
            lAlojamiento.AgregarCliente(lCliente3);
            lAlojamiento.AgregarCliente(lCliente4);


            lAlojamiento.Habitacion = lHabitacion; 

            lAlojamiento.FechaEstimadaIngreso = DateTime.Now;
            lAlojamiento.FechaEstimadaEgreso = (DateTime.Now).AddDays(2);

            return lAlojamiento;
        }
        
        public Cliente BuscarCliente(int pDNI)
        {
            // buscar en base de datos - repositorio de clientes ?? -
            return new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);
        }

        public double ObteberTarifa(Cliente pCliente, TarifaCliente pTarifa, bool pExclusividad)
        {
            
            return  pTarifa.DeterminarTarifa(pCliente.TipoCliente, pExclusividad);
          
        }

        public void DeterminarDisponibilidad (DateTime pFechaDesde, DateTime pFechaHasta)
        {
            //fechas obtenidas desde la interfaz
            //hacer un try catch para que la fecha desde esa menor que fecha hasta
            //tambien notificar que ingrese datos obligatorios
            pFechaDesde = DateTime.Now;
            pFechaHasta = (DateTime.Now).AddDays(2);

            List<Habitacion> lHabitacionesDisponibles = new List<Habitacion>();

            List<Alojamiento> lRepoAlojamiento = new List<Alojamiento>(); // obtner como respositorio de alojamientos??

          

        }

        public bool VerificarCuposIngresados(byte pCantS, byte pCantD, Alojamiento pAlojamiento)
        {
            //verifica si la cantidad de clientes agregados al alojamiento es igual a la cantidad de cupos que ingresó
            return (pAlojamiento.Clientes.LongCount() == pCantS+pCantD*2);
        }

        public bool ConfirmarAlta()
        {

            return true;
        }
    }
}
