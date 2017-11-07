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
            context.Set<TarifaCliente>().Add(new TarifaCliente
                {
                    TarifaClienteId = TipoCliente.Titular,
                    Tarifa = 150,
                    TarifaExclusiva = 250
                });
            context.Set<TarifaCliente>().Add(new TarifaCliente
                {
                    TarifaClienteId = TipoCliente.AcompanianteNoDirecto,
                    Tarifa = 100,
                    TarifaExclusiva = 150
                });
            context.Set<TarifaCliente>().Add(new TarifaCliente
                 {
                     TarifaClienteId = TipoCliente.AcompanianteNoDirecto,
                     Tarifa = 200,
                     TarifaExclusiva = 300
                 });
            context.Set<TarifaCliente>().Add(new TarifaCliente
                 {
                     TarifaClienteId = TipoCliente.TitularExceptuado,
                     Tarifa = 50,
                     TarifaExclusiva = 150
                 });
            context.Set<TarifaCliente>().Add(new TarifaCliente
                 {
                     TarifaClienteId = TipoCliente.Convenio,
                     Tarifa = 500,
                     TarifaExclusiva = 600
                 });

            context.Set<Ciudad>().Add(new Ciudad
            {
                CiudadId = 3260,
                Nombre = "ConcepcionDelUruguay"
            });
            context.Set<Ciudad>().Add(new Ciudad
            {
                CiudadId = 3206,
                Nombre = "Federacion"
            });


            Cliente cli1 = new Cliente()
            {
                ClienteId = 38387043,
                Apellido = "Albornoz",
                Nombre = "Milton",
                Telefono = "0345515431476",
                TarifaClienteId = TipoCliente.Titular,
                Domicilio = new Domicilio()
                {
                    Calle = "Peron",
                    Numero = "610",
                    Piso = "0",
                    NroDepto = "1",
                    CiudadId = 3260
                }
            };

            Cliente cli2 = new Cliente()
            {
                ClienteId = 37115628,
                Apellido = "Chamorro",
                Nombre = "Mauricio Manuel",
                Telefono = "0345615542154",
                TarifaClienteId = TipoCliente.AcompanianteDirecto,

                Domicilio = new Domicilio()
                {
                    Calle = "Atencio Al Este",
                    Numero = "180",
                    Piso = "0",
                    NroDepto = "1",
                    CiudadId = 3206
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
                        Disponible = true,
                        Tipo = TipoCupo.simple
                    },
                    new Cupo()
                    {
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
                        Disponible = true,
                        Tipo = TipoCupo.simple
                    },
                    new Cupo()
                    {
                        Disponible = true,
                        Tipo = TipoCupo.simple
                    },
                    new Cupo()
                    {
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
