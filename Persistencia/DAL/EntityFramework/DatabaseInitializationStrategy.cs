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
            #region Tarfifas
            TarifaCliente TarifaTitular = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.Titular,
                Tarifa = 150,
                TarifaExclusiva = 250
            };
            context.Set<TarifaCliente>().Add(TarifaTitular);

            TarifaCliente TarifaAcompNoDirecto = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.AcompanianteNoDirecto,
                Tarifa = 100,
                TarifaExclusiva = 150
            };
            context.Set<TarifaCliente>().Add(TarifaAcompNoDirecto);

            TarifaCliente TarifaAcompDirecto = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.AcompanianteDirecto,
                Tarifa = 200,
                TarifaExclusiva = 300
            };
            context.Set<TarifaCliente>().Add(TarifaAcompDirecto);

            TarifaCliente TarifaExceptuado = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.TitularExceptuado,
                Tarifa = 50,
                TarifaExclusiva = 150
            };
            context.Set<TarifaCliente>().Add(TarifaExceptuado);

            TarifaCliente TarifaConvenio = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.Convenio,
                Tarifa = 500,
                TarifaExclusiva = 600
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

            

            #region Clientes
            Cliente Milton = new Cliente
            {
                ClienteId = 38387043,
                Apellido = "Albornoz",
                Nombre = "Milton",
                Telefono = "0345515431476",
                TarifaClienteId = TarifaTitular.TarifaClienteId,
                //DomicilioId = DomiciolioMilton.DomicilioId
            };
            context.Set<Cliente>().Add(Milton);

            Cliente Mauri = new Cliente
            {
                ClienteId = 37115628,
                Apellido = "Chamorro",
                Nombre = "Mauricio Manuel",
                Telefono = "0345615542154",
                TarifaClienteId = TarifaAcompNoDirecto.TarifaClienteId,
               //DomicilioId = DomicilioMauri.DomicilioId
            };
            context.Set<Cliente>().Add(Mauri);
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
                    Milton
                }
            };
            context.Set<Domicilio>().Add(DomiciolioMilton);

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

            #region Cupos
            Cupo cupo1 = new Cupo
            {
                Tipo = TipoCupo.doble,
                Disponible = true
            };

            Cupo cupo2 = new Cupo
            {
                Tipo = TipoCupo.simple,
                Disponible = true
            };

            Cupo cupo3 = new Cupo
            {
                Tipo = TipoCupo.simple,
                Disponible = true
            };

            Cupo cupo4 = new Cupo
            {
                Tipo = TipoCupo.doble,
                Disponible = true
            };

            Cupo cupo5 = new Cupo
            {
                Tipo = TipoCupo.simple,
                Disponible = true
            };

            #endregion

            #region Habitaciones
            Habitacion hab1 = new Habitacion()
            {
                HabitacionId = 1,
                Capacidad = 3,
                Planta = 1,
                Exclusiva = false,
                Cupos = new List<Cupo>()
                {
                    cupo1, cupo2
                }
                //COMPROBAR SI LOS CUPOS EXISTEN O SE DUPLICAN AGREGANDO A LA LISTA 
            };
            context.Set<Habitacion>().Add(hab1);

            Habitacion hab2 = new Habitacion()
            {
                HabitacionId = 2,
                Capacidad = 4,
                Exclusiva = false,
                Planta = 2,
                Cupos = new List<Cupo>()
                {
                    cupo3, cupo4, cupo5
                }
                //COMPROBAR SI LOS CUPOS EXISTEN O SE DUPLICAN AGREGANDO A LA LISTA 
            };
            context.Set<Habitacion>().Add(hab2);
            #endregion


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


            #region Alojamientos
            context.Set<Alojamiento>().Add(new Alojamiento
            {
                DniResponsable = Milton.ClienteId,
                FechaReserva = null,
                FechaIngreso = DateTime.Now,
                FechaEstimadaIngreso = null,
                FechaEstimadaEgreso = DateTime.Now.AddDays(3),
                FechaEgreso = null,
                MontoTotal = 250,
                MontoDeuda = 0,
                EstadoAlojamiento = EstadoAlojamiento.Alojado,
                HabitacionId = 2,
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
                }

            }); 
            #endregion

            base.Seed(context);
        }
    }
}
