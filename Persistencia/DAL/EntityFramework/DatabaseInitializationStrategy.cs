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
            Cliente cli1 = new Cliente()
            {
                ClienteId = 38387043,
                Apellido = "Albornoz",
                Nombre = "Milton",
                Telefono = "0345515431476",
                TarifaCliente = new TarifaCliente()
                {
                    TipoClienteId = TipoCliente.Titular,
                    Tarifa = 150,
                    TarifaExclusiva = 250
                }, 
                Domicilio = new Domicilio()
                {
                    DomicilioId = 12,
                    Calle = "Peron",
                    Numero = "610",
                    Piso = "0",
                    NroDepto = "1",
                    Ciudad = new Ciudad()
                    {
                        CiudadId=3260,
                        Nombre="ConcepcionDelUruguay"
                    }
                }
            };

            Cliente cli2 = new Cliente()
            {
                ClienteId = 37115628,
                Apellido = "Chamorro",
                Nombre = "Mauricio Manuel",
                Telefono = "0345615542154",
                TarifaCliente = new TarifaCliente()
                {
                    TipoClienteId = TipoCliente.AcompanianteDirecto,
                    Tarifa = 100,
                    TarifaExclusiva = 200
                },
                Domicilio = new Domicilio()
                {
                    DomicilioId = 13,
                    Calle = "Atencio Al Este",
                    Numero = "180",
                    Piso = "0",
                    NroDepto = "1",
                    Ciudad = new Ciudad()
                    {
                        CiudadId = 3206,
                        Nombre = "Federacion"
                    }
                }

            };
            Habitacion hab1 = new Habitacion()
            {
                HabitacionId = 1,
                Capacidad = 3,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo()
                    {
                        CupoId = 1,
                        Disponible = true,
                        Tipo = TipoCupo.simple
                    },
                    new Cupo()
                    {
                        CupoId = 2,
                        Disponible = true,
                        Tipo = TipoCupo.doble
                    }
                }
            };

            Habitacion hab2 = new Habitacion()
            {
                HabitacionId = 2,
                Capacidad = 4,
                Exclusiva = false,
                Planta = 2,
                Cupos = new List<Cupo>()
                {
                    new Cupo()
                    {
                        CupoId = 3,
                        Disponible = true,
                        Tipo = TipoCupo.simple
                    },
                    new Cupo()
                    {
                        CupoId = 4,
                        Disponible = true,
                        Tipo = TipoCupo.simple
                    },
                    new Cupo()
                    {
                        CupoId = 5,
                        Disponible = true,
                        Tipo = TipoCupo.doble
                    }
                }
            };

            Usuario user1 = new Usuario
            {
                UsuarioId= "mauri",
                Password = "chamorro"
            };

            Usuario user2 = new Usuario
            {
                UsuarioId = "milton",
                Password = "albornoz"
            };

            context.Set<Cliente>().Add(cli1);
            context.Set<Cliente>().Add(cli2);
            context.Set<Habitacion>().Add(hab1);
            context.Set<Habitacion>().Add(hab2);
            context.Set<Habitacion>().Add(hab2);
            context.Set<Usuario>().Add(user1);
            context.Set<Usuario>().Add(user2);

            base.Seed(context);
        }
    }
}
