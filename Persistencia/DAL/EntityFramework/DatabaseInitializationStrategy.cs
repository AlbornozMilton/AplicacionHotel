using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class DatabaseInitializationStrategy: CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            //---------------- CARGA DATOS BASICOS ---------------------
            #region Usuarios
            Usuario user1 = new Usuario
            {
                UsuarioId = "mauri",
                Password = "chamorro"
            };
            context.Set<Usuario>().Add(user1);
            Usuario user2 = new Usuario
            {
                UsuarioId = "milton",
                Password = "albornoz"
            };
            context.Set<Usuario>().Add(user2);
            #endregion

            #region Tarfifas
            TarifaCliente TarifaTitular = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.Titular,
                Tarifa = 150,
                TarifaExclusiva = 250
            };
            context.Set<TarifaCliente>().Add(TarifaTitular);

            TarifaCliente TarifaAcompDirecto = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.AcompanianteDirecto,
                Tarifa = 170,
                TarifaExclusiva = 200
            };
            context.Set<TarifaCliente>().Add(TarifaAcompDirecto);

            TarifaCliente TarifaAcompNoDirecto = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.AcompanianteNoDirecto,
                Tarifa = 200,
                TarifaExclusiva = 280
            };
            context.Set<TarifaCliente>().Add(TarifaAcompNoDirecto);

            TarifaCliente TarifaExceptuado = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.TitularExceptuado,
                Tarifa = 0,
                TarifaExclusiva = 0
            };
            context.Set<TarifaCliente>().Add(TarifaExceptuado);

            TarifaCliente TarifaConvenio = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.Convenio,
                Tarifa = 500,
                TarifaExclusiva = 750
            };
            context.Set<TarifaCliente>().Add(TarifaConvenio);

            #endregion

            #region Ciudades

            Ciudad CiudadFederacion = new Ciudad
            {
                CiudadId = 3206,
                Nombre = "Federación"
            };
            context.Set<Ciudad>().Add(CiudadFederacion);
            Ciudad CiudadCdelU = new Ciudad
            {
                CiudadId = 3260,
                Nombre = "Concepción del Uruguay"
            };
            context.Set<Ciudad>().Add(CiudadCdelU);

            #endregion

            #region Habitaciones y Cupos
            Habitacion hab1 = new Habitacion()
            {
                HabitacionId = 1,
                //Capacidad = 2, // 2 CAMAS
                Planta = 0,// planta baja
                Exclusiva = false,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = false
                    }
                }
            };
            context.Set<Habitacion>().Add(hab1);

            Habitacion hab2 = new Habitacion()
            {
                HabitacionId = 2,
                //Capacidad = 4, // 4 CAMAS
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = false
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Disponible = false
                    }
                }
            };
            context.Set<Habitacion>().Add(hab2);

            Habitacion hab3 = new Habitacion()
            {
                HabitacionId = 3,
                //Capacidad = 3,
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab3);

            Habitacion hab4 = new Habitacion()
            {
                HabitacionId = 4,
                //Capacidad = 3, // 3 CAMAS
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab4);

            Habitacion hab5 = new Habitacion()
            {
                HabitacionId = 5,
                //Capacidad = 3, // 3 CAMAS
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab5);

            Habitacion hab6 = new Habitacion()
            {
                HabitacionId = 6,
                //Capacidad = 3, // 3 CAMAS
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab6);

            Habitacion hab7 = new Habitacion()
            {
                HabitacionId = 7,
                //Capacidad = 3, // 3 CAMAS
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab7);

            Habitacion hab8 = new Habitacion()
            {
                HabitacionId = 8,
                //Capacidad = 3, // 3 CAMAS
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                   new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab8);

            Habitacion hab9 = new Habitacion()
            {
                HabitacionId = 9,
                //Capacidad = 3,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab9);

            Habitacion hab10 = new Habitacion()
            {
                HabitacionId = 10,
                //Capacidad = 3, // 3 CAMAS
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab10);

            #endregion

            #region Servicios
            Servicio Bata = new Servicio
            {
                ServicioId = 1,
                Nombre = "Bata",
                Detalle = "El costo de este servicio es por día",
                CostoBase = 10
            };
            context.Set<Servicio>().Add(Bata);

            Servicio AireAcondicionado = new Servicio
            {
                ServicioId = 2,
                Nombre = "Aire Acondicionado",
                Detalle = "El costo de este servicio es por hora",
                CostoBase = 30
            };

            context.Set<Servicio>().Add(AireAcondicionado);

            Servicio SeguroDeSalud = new Servicio
            {
                ServicioId = 3,
                Nombre = "Seguridad Medica",
                Detalle = "El costo de este servicio es por día",
                CostoBase = 10
            };
            context.Set<Servicio>().Add(SeguroDeSalud);

            Servicio Calefaccion = new Servicio
            {
                ServicioId = 4,
                Nombre = "Calefacción",
                Detalle = "El costo de este servicio es por hora",
                CostoBase = 30
            };
            context.Set<Servicio>().Add(Calefaccion);

            Servicio RecargoPorFumar = new Servicio
            {
                ServicioId = 5,
                Nombre = "Recargo por Fumar",
                Detalle = "El costo de este servicio por estadía",
                CostoBase = 50
            };
            context.Set<Servicio>().Add(RecargoPorFumar);

            #endregion
            ////-----------------------FIN DATOS BASICOS------------------

            ////-----------------------A MODO DE EJEMPLO-----------------

            #region Clientes
            Cliente Milton = new Cliente
            {
                ClienteId = 38387043,
                Apellido = "Albornoz",
                Nombre = "Milton",
                Telefono = "0345515431476",
                TarifaClienteId = TarifaTitular.TarifaClienteId,
                EnAlta = true
            };
            context.Set<Cliente>().Add(Milton);

            Cliente Mauri = new Cliente
            {
                ClienteId = 37115628,
                Apellido = "Chamorro",
                Nombre = "Mauricio Manuel",
                Telefono = "0345615542154",
                TarifaClienteId = TarifaAcompDirecto.TarifaClienteId,
                EnAlta = true
            };
            context.Set<Cliente>().Add(Mauri);

            Cliente Desconocido = new Cliente
            {
                ClienteId = 30000001,
                Apellido = "Anonimous",
                Nombre = "Marcelo",
                Telefono = "3554585854",
                TarifaClienteId = TarifaConvenio.TarifaClienteId,
                EnAlta = false
            };
            context.Set<Cliente>().Add(Desconocido);

            #endregion

            #region Domicilios
            Domicilio DomiciolioMilton = new Domicilio
            {
                Calle = "Peron",
                Numero = "610",
                Piso = "0",
                NroDepto = "1",
                CiudadId = CiudadCdelU.CiudadId,
                Clientes = new List<Cliente>()
                {
                    Milton, Desconocido
                }
            };
            context.Set<Domicilio>().Add(DomiciolioMilton);

            //Domicilio DomiciolioMilton2 = new Domicilio
            //{
            //  //----- Agrega el domicilio pero no enlace el IdDomiciolio del CLiente, es decir, el cliente sigue con el 
            //----- IdDomicilio original
            //    Calle = "Peron",
            //    Numero = "610",
            //    Piso = "0",
            //    NroDepto = "1",
            //    CiudadId = CiudadFederacion.CiudadId,
            //    Clientes = new List<Cliente>()
            //    {
            //        Milton
            //    }
            //};
            //context.Set<Domicilio>().Add(DomiciolioMilton2);

            Domicilio DomicilioMauri = new Domicilio
            {
                Calle = "Atencio Al Este",
                Numero = "180",
                Piso = "0",
                NroDepto = "1",
                CiudadId = CiudadFederacion.CiudadId,
                Clientes = new List<Cliente>()
                {
                    Mauri
                }
            };
            context.Set<Domicilio>().Add(DomicilioMauri);
            #endregion 

            #region Linea de Servicios para Alojamientos 

            //las lineas de servicio se generan solo para Alojamientos dado
            LineaServicio CantBatas = new LineaServicio
            {
                Cantidad = 3,
                CostoServicio = 30,
                FechaServicio = DateTime.Now.AddDays(1),
                ServicioId = Bata.ServicioId
            };

            LineaServicio CantAireAcond = new LineaServicio
            {
                Cantidad = 5,
                CostoServicio = 150,
                FechaServicio = DateTime.Now.AddDays(2),
                ServicioId = AireAcondicionado.ServicioId
            };
            #endregion

            ///*
            #region Alojamientos
            Alojamiento Aloj1 = new Alojamiento
            {
                DniResponsable = Milton.ClienteId,
                FechaReserva = null,
                FechaIngreso = DateTime.Now,
                FechaEstimadaIngreso = null,
                FechaEstimadaEgreso = DateTime.Now.AddDays(3),
                FechaEgreso = null,
                MontoTotal = 250,
                MontoDeuda = 0,
                CantCuposDobles = 1,
                CantCuposSimples = 2,
                EstadoAlojamiento = EstadoAlojamiento.Alojado,
                HabitacionId = 5,
                Clientes = new List<Cliente>() { Milton, Mauri },
                Pagos = new List<Pago>()
                {
                    new Pago
                    {
                        Tipo = TipoPago.Alojado,
                        Monto = 250,
                        FechaPago = DateTime.Now,
                        Detalle = "El viejo era tacaño"
                    }
                },
                Servicios = new List<LineaServicio>()
                {
                    CantBatas, CantAireAcond
                }
            };

            context.Set<Alojamiento>().Add(Aloj1);

            Alojamiento Aloj2 = new Alojamiento
            {
                DniResponsable = Mauri.ClienteId,
                FechaReserva = DateTime.Now.AddDays(4),
                FechaIngreso = null,
                FechaEstimadaIngreso = DateTime.Now.AddDays(4),
                FechaEstimadaEgreso = DateTime.Now.AddDays(7),
                FechaEgreso = null,
                MontoTotal = 250,
                MontoDeuda = 125,
                EstadoAlojamiento = EstadoAlojamiento.Reservado,
                HabitacionId = 1,
                Clientes = new List<Cliente>() { Milton, Mauri },
                Pagos = new List<Pago>()
                {
                    new Pago
                    {
                        Tipo = TipoPago.Deposito,
                        Monto = 125,
                        FechaPago = DateTime.Now,
                        Detalle = "Reservando"
                    }
                },
                Servicios = new List<LineaServicio>()
                {
                    CantBatas
                }
            };

            context.Set<Alojamiento>().Add(Aloj2);
            #endregion
            //*/

            base.Seed(context);
        }
    }
}
