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
                NombreTarifa = "Titular",
                Tarifa = 150,
                TarifaExclusiva = 250
            };
            context.Set<TarifaCliente>().Add(TarifaTitular);

            TarifaCliente TarifaAcompDirecto = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.AcompanianteDirecto,
                NombreTarifa = "Acompañante Directo",
                Tarifa = 170,
                TarifaExclusiva = 270
            };
            context.Set<TarifaCliente>().Add(TarifaAcompDirecto);

            TarifaCliente TarifaAcompNoDirecto = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.AcompanianteNoDirecto,
                NombreTarifa = "Acompañante No Directo",
                Tarifa = 200,
                TarifaExclusiva = 300
            };
            context.Set<TarifaCliente>().Add(TarifaAcompNoDirecto);

            TarifaCliente TarifaExceptuado = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.TitularExceptuado,
                NombreTarifa = "Titular Exceptuado",
                Tarifa = 0,
                TarifaExclusiva = 50
            };
            context.Set<TarifaCliente>().Add(TarifaExceptuado);

            TarifaCliente TarifaConvenio = new TarifaCliente
            {
                TarifaClienteId = TipoCliente.Convenio,
                NombreTarifa = "Convenio",
                Tarifa = 500,
                TarifaExclusiva = 750
            };
            context.Set<TarifaCliente>().Add(TarifaConvenio);

            #endregion

            #region Ciudades

            Ciudad CiudadFederacion = new Ciudad {CiudadId = 3206,Nombre = "Federación"};
            context.Set<Ciudad>().Add(CiudadFederacion);
            Ciudad CiudadCdelU = new Ciudad {CiudadId = 3260,Nombre = "Concepción del Uruguay"};
            context.Set<Ciudad>().Add(CiudadCdelU);
            Ciudad CiudadNogoya = new Ciudad { CiudadId = 3150, Nombre = "Nogoya" };
            context.Set<Ciudad>().Add(CiudadNogoya);
            Ciudad CiudadSeptiembre = new Ciudad { CiudadId = 3158, Nombre = "20 de Septiembre" };
            context.Set<Ciudad>().Add(CiudadSeptiembre);
            Ciudad CiudadAchiras = new Ciudad { CiudadId = 3246, Nombre = "Achiras" };
            context.Set<Ciudad>().Add(CiudadAchiras);
            Ciudad CiudadAero = new Ciudad { CiudadId = 2823, Nombre = "Aero Club Canal" };
            context.Set<Ciudad>().Add(CiudadAero);
            Ciudad CiudadAlarcon = new Ciudad { CiudadId = 2852, Nombre = "Alarcon" };
            context.Set<Ciudad>().Add(CiudadAlarcon);
            Ciudad CiudadAlbardon = new Ciudad { CiudadId = 2840, Nombre = "Albardon" };
            context.Set<Ciudad>().Add(CiudadAlbardon);
            Ciudad CiudadAlbariño = new Ciudad { CiudadId = 3183, Nombre = "Albariño" };
            context.Set<Ciudad>().Add(CiudadAlbariño);
            Ciudad CiudadAlberto = new Ciudad { CiudadId = 3170, Nombre = "ALberto Gerchunoff" };
            context.Set<Ciudad>().Add(CiudadAlberto);
            Ciudad CiudadAlcaracito = new Ciudad { CiudadId = 3142, Nombre = "Alcaracito" };
            context.Set<Ciudad>().Add(CiudadAlcaracito);
            Ciudad CiudadAlcaraz = new Ciudad { CiudadId = 3138, Nombre = "Alcaraz" };
            context.Set<Ciudad>().Add(CiudadAlcaraz);
            Ciudad CiudadAlcaraz2 = new Ciudad { CiudadId = 3144, Nombre = "Alcaraz 1°" };
            context.Set<Ciudad>().Add(CiudadAlcaraz2);
            Ciudad CiudadAlcaraz3 = new Ciudad { CiudadId = 3136, Nombre = "Alcaraz Norte" };
            context.Set<Ciudad>().Add(CiudadAlcaraz3);
            Ciudad CiudadAlcaraz4 = new Ciudad { CiudadId = 3137, Nombre = "Alcaraz Sud" };
            context.Set<Ciudad>().Add(CiudadAlcaraz4);
            Ciudad CiudadAlcete = new Ciudad { CiudadId = 3127, Nombre = "Alcete" };
            context.Set<Ciudad>().Add(CiudadAlcete);
            Ciudad CiudadAldea1 = new Ciudad { CiudadId = 3101, Nombre = "Aldea Asunción" };
            context.Set<Ciudad>().Add(CiudadAldea1);
            Ciudad CiudadAldea3 = new Ciudad { CiudadId = 3114, Nombre = "Aldea Maria Luisa" };
            context.Set<Ciudad>().Add(CiudadAldea3);
            Ciudad CiudadAldea5 = new Ciudad { CiudadId = 3188, Nombre = "Aldea San Isidro" };
            context.Set<Ciudad>().Add(CiudadAldea5);
            Ciudad CiudadAldea6 = new Ciudad { CiudadId = 3252, Nombre = "Aldea San Jorge" };
            context.Set<Ciudad>().Add(CiudadAldea6);
            Ciudad CiudadVillaguay = new Ciudad { CiudadId = 3240, Nombre = "Villaguay" };
            context.Set<Ciudad>().Add(CiudadVillaguay);
            Ciudad CiudadParana = new Ciudad { CiudadId = 3100, Nombre = "Paraná" };
            context.Set<Ciudad>().Add(CiudadParana);
            Ciudad CiudadGchu = new Ciudad { CiudadId = 2820, Nombre = "Gualeguachú" };
            context.Set<Ciudad>().Add(CiudadGchu);
            Ciudad CiudadGualeguay = new Ciudad { CiudadId = 2840, Nombre = "Gualeguay" };
            context.Set<Ciudad>().Add(CiudadGualeguay);
            Ciudad CiudadColon = new Ciudad { CiudadId = 3280, Nombre = "Colón" };
            context.Set<Ciudad>().Add(CiudadColon);
            Ciudad CiudadSanJose = new Ciudad { CiudadId = 3283, Nombre = "Villa San José" };
            context.Set<Ciudad>().Add(CiudadSanJose);
            Ciudad CiudadChajari= new Ciudad { CiudadId = 3228, Nombre = "Chajarí" };
            context.Set<Ciudad>().Add(CiudadChajari);
            Ciudad CiudadConcordia = new Ciudad { CiudadId = 3200, Nombre = "Concordia" };
            context.Set<Ciudad>().Add(CiudadConcordia);
            Ciudad CiudadLaPaz = new Ciudad { CiudadId = 3190, Nombre = "La Paz" };
            context.Set<Ciudad>().Add(CiudadLaPaz);
            Ciudad CiudadFederal = new Ciudad { CiudadId = 3180, Nombre = "Federal" };
            context.Set<Ciudad>().Add(CiudadFederal);
            Ciudad CiudadClara = new Ciudad { CiudadId = 3252, Nombre = "Clara" };
            context.Set<Ciudad>().Add(CiudadClara);
            Ciudad CiudadVelisa = new Ciudad { CiudadId = 3265, Nombre = "Villa Elisa" };
            context.Set<Ciudad>().Add(CiudadVelisa);
            Ciudad CiudadFeliciano = new Ciudad { CiudadId = 3187, Nombre = "San Jose de Feliciano" };
            context.Set<Ciudad>().Add(CiudadFeliciano);
            Ciudad CiudadCrespo = new Ciudad { CiudadId = 3116, Nombre = "Crespo" };
            context.Set<Ciudad>().Add(CiudadCrespo);
            Ciudad CiudadSanMartin = new Ciudad { CiudadId = 3103, Nombre = "Villa Libertador Gral San Martín" };
            context.Set<Ciudad>().Add(CiudadSanMartin);
            Ciudad CiudadBaso = new Ciudad { CiudadId = 3170, Nombre = "Basavilbaso" };
            context.Set<Ciudad>().Add(CiudadBaso);
            Ciudad CiudadDom = new Ciudad { CiudadId = 3246, Nombre = "Dominguez" };
            context.Set<Ciudad>().Add(CiudadDom);
            Ciudad CiudadMoscas = new Ciudad { CiudadId = 3244, Nombre = "Las Moscas" };
            context.Set<Ciudad>().Add(CiudadMoscas);
            Ciudad CiudadUbajay = new Ciudad { CiudadId = 3287, Nombre = "Ubajay" };
            context.Set<Ciudad>().Add(CiudadUbajay);
            Ciudad CiudadTala = new Ciudad { CiudadId = 3174, Nombre = "Rosario del Tala" };
            context.Set<Ciudad>().Add(CiudadTala);
            Ciudad CiudadSalvador = new Ciudad { CiudadId = 3218, Nombre = "San Salvador" };
            context.Set<Ciudad>().Add(CiudadSalvador);
            Ciudad CiudadJubileo = new Ciudad { CiudadId = 3254, Nombre = "Jubileo" };
            context.Set<Ciudad>().Add(CiudadJubileo);
            Ciudad CiudadAna = new Ciudad { CiudadId = 3208, Nombre = "Santa Ana" };
            context.Set<Ciudad>().Add(CiudadAna);
            Ciudad CiudadUrd = new Ciudad { CiudadId = 2826, Nombre = "Urdinarrain" };
            context.Set<Ciudad>().Add(CiudadUrd);
            Ciudad CiudadLarroque = new Ciudad { CiudadId = 2854, Nombre = "Larroque" };
            context.Set<Ciudad>().Add(CiudadLarroque);
            Ciudad CiudadCeibas = new Ciudad { CiudadId = 2823, Nombre = "Ceibas" };
            context.Set<Ciudad>().Add(CiudadCeibas);
            Ciudad CiudadVictoria = new Ciudad { CiudadId = 3153, Nombre = "Victoria" };
            context.Set<Ciudad>().Add(CiudadVictoria);
            Ciudad CiudadViale = new Ciudad { CiudadId = 3109, Nombre = "Viale" };
            context.Set<Ciudad>().Add(CiudadViale);
            Ciudad CiudadDiamante = new Ciudad { CiudadId = 3105, Nombre = "Diamante" };
            context.Set<Ciudad>().Add(CiudadDiamante);
            Ciudad CiudadCaseros = new Ciudad { CiudadId = 3262, Nombre = "Caseros" };
            context.Set<Ciudad>().Add(CiudadCaseros);


            #endregion

            #region Habitaciones y Cupos
            Habitacion hab1 = new Habitacion()
            {
                HabitacionId = 1,
                Planta = 0,// planta baja
                Exclusiva = false,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab1);

            Habitacion hab2 = new Habitacion()
            {
                HabitacionId = 2,
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true,
                        Alta = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Disponible = true,
                        Alta = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab2);

            Habitacion hab3 = new Habitacion()
            {
                HabitacionId = 3,
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab3);

            Habitacion hab4 = new Habitacion()
            {
                HabitacionId = 4,
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab4);

            Habitacion hab5 = new Habitacion()
            {
                HabitacionId = 5,
                Exclusiva = false,
                Planta = 0,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab5);

            Habitacion hab6 = new Habitacion()
            {
                HabitacionId = 6,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab6);

            Habitacion hab7 = new Habitacion()
            {
                HabitacionId = 7,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab7);

            Habitacion hab8 = new Habitacion()
            {
                HabitacionId = 8,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                   new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.doble,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab8);

            Habitacion hab9 = new Habitacion()
            {
                HabitacionId = 9,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Disponible = true,
                        Alta = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    }
                }
            };
            context.Set<Habitacion>().Add(hab9);

            Habitacion hab10 = new Habitacion()
            {
                HabitacionId = 10,
                Exclusiva = false,
                Planta = 1,
                Cupos = new List<Cupo>()
                {
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
                        Disponible = true
                    },
                    new Cupo
                    {
                        Tipo = TipoCupo.simple,
                        Alta = true,
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
                Legajo = 2222223,
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
                Legajo = 2222222,
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

            base.Seed(context);
        }
    }
}
