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
			Usuario user3 = new Usuario
			{
				UsuarioId = "norma",
				Password = "123456123"
			};
			context.Set<Usuario>().Add(user3);
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

            Ciudad CiudadFederacion = new Ciudad {CodPostal = 3206,Nombre = "Federación", };
            context.Set<Ciudad>().Add(CiudadFederacion);
            Ciudad CiudadCdelU = new Ciudad { CodPostal = 3260,Nombre = "Concepción del Uruguay", };
            context.Set<Ciudad>().Add(CiudadCdelU);
            Ciudad CiudadNogoya = new Ciudad { CodPostal = 3150, Nombre = "Nogoyá", Domicilios = null};
            context.Set<Ciudad>().Add(CiudadNogoya);
            Ciudad CiudadSeptiembre = new Ciudad { CodPostal = 3158, Nombre = "20 de Septiembre", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadSeptiembre);
            Ciudad CiudadAlarcon = new Ciudad { CodPostal = 2852, Nombre = "Alarcon", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlarcon);
            Ciudad CiudadAlbariño = new Ciudad { CodPostal = 3183, Nombre = "Albariño", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlbariño);
            Ciudad CiudadAlcaracito = new Ciudad { CodPostal = 3142, Nombre = "Alcaracito", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlcaracito);
            Ciudad CiudadAlcaraz = new Ciudad { CodPostal = 3138, Nombre = "Alcaraz", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlcaraz);
            Ciudad CiudadAlcaraz2 = new Ciudad { CodPostal = 3144, Nombre = "Alcaraz 1°", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlcaraz2);
            Ciudad CiudadAlcaraz3 = new Ciudad { CodPostal = 3136, Nombre = "Alcaraz Norte", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlcaraz3);
            Ciudad CiudadAlcaraz4 = new Ciudad { CodPostal = 3137, Nombre = "Alcaraz Sud", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlcaraz4);
            Ciudad CiudadAlcete = new Ciudad { CodPostal = 3127, Nombre = "Alcete", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAlcete);
            Ciudad CiudadAldea1 = new Ciudad { CodPostal = 3101, Nombre = "Aldea Asunción", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAldea1);
            Ciudad CiudadAldea3 = new Ciudad { CodPostal = 3114, Nombre = "Aldea Maria Luisa", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAldea3);
            Ciudad CiudadAldea5 = new Ciudad { CodPostal = 3188, Nombre = "Aldea San Isidro", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAldea5);
            Ciudad CiudadVillaguay = new Ciudad { CodPostal = 3240, Nombre = "Villaguay", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadVillaguay);
            Ciudad CiudadParana = new Ciudad { CodPostal = 3100, Nombre = "Paraná", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadParana);
            Ciudad CiudadGchu = new Ciudad { CodPostal = 2820, Nombre = "Gualeguachú", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadGchu);
            Ciudad CiudadGualeguay = new Ciudad { CodPostal = 2840, Nombre = "Gualeguay", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadGualeguay);
            Ciudad CiudadColon = new Ciudad { CodPostal = 3280, Nombre = "Colón", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadColon);
            Ciudad CiudadSanJose = new Ciudad { CodPostal = 3283, Nombre = "Villa San José", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadSanJose);
            Ciudad CiudadChajari = new Ciudad { CodPostal = 3228, Nombre = "Chajarí", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadChajari);
            Ciudad CiudadConcordia = new Ciudad { CodPostal = 3200, Nombre = "Concordia", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadConcordia);
            Ciudad CiudadLaPaz = new Ciudad { CodPostal = 3190, Nombre = "La Paz", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadLaPaz);
            Ciudad CiudadFederal = new Ciudad { CodPostal = 3180, Nombre = "Federal", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadFederal);
            Ciudad CiudadClara = new Ciudad { CodPostal = 3252, Nombre = "Clara", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadClara);
            Ciudad CiudadVelisa = new Ciudad { CodPostal = 3265, Nombre = "Villa Elisa", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadVelisa);
            Ciudad CiudadFeliciano = new Ciudad { CodPostal = 3187, Nombre = "San Jose de Feliciano", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadFeliciano);
            Ciudad CiudadCrespo = new Ciudad { CodPostal = 3116, Nombre = "Crespo", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadCrespo);
            Ciudad CiudadSanMartin = new Ciudad { CodPostal = 3103, Nombre = "Villa Libertador Gral San Martín", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadSanMartin);
            Ciudad CiudadBaso = new Ciudad { CodPostal = 3170, Nombre = "Basavilbaso", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadBaso);
            Ciudad CiudadDom = new Ciudad { CodPostal = 3246, Nombre = "Dominguez", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadDom);
            Ciudad CiudadMoscas = new Ciudad { CodPostal = 3244, Nombre = "Las Moscas", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadMoscas);
            Ciudad CiudadUbajay = new Ciudad { CodPostal = 3287, Nombre = "Ubajay", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadUbajay);
            Ciudad CiudadTala = new Ciudad { CodPostal = 3174, Nombre = "Rosario del Tala", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadTala);
            Ciudad CiudadSalvador = new Ciudad { CodPostal = 3218, Nombre = "San Salvador", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadSalvador);
            Ciudad CiudadJubileo = new Ciudad { CodPostal = 3254, Nombre = "Jubileo", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadJubileo);
            Ciudad CiudadAna = new Ciudad { CodPostal = 3208, Nombre = "Santa Ana", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadAna);
            Ciudad CiudadUrd = new Ciudad { CodPostal = 2826, Nombre = "Urdinarrain", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadUrd);
            Ciudad CiudadLarroque = new Ciudad { CodPostal = 2854, Nombre = "Larroque", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadLarroque);
            Ciudad CiudadCeibas = new Ciudad { CodPostal = 2823, Nombre = "Ceibas", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadCeibas);
            Ciudad CiudadVictoria = new Ciudad { CodPostal = 3153, Nombre = "Victoria", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadVictoria);
            Ciudad CiudadViale = new Ciudad { CodPostal = 3109, Nombre = "Viale", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadViale);
            Ciudad CiudadDiamante = new Ciudad { CodPostal = 3105, Nombre = "Diamante", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadDiamante);
            Ciudad CiudadCaseros = new Ciudad { CodPostal = 3262, Nombre = "Caseros", Domicilios = null };
            context.Set<Ciudad>().Add(CiudadCaseros);


			#endregion

			#region Habitaciones y Cupos
			Habitacion hab1 = new Habitacion()
			{
				HabitacionId = 1,
				Planta = 0,// planta baja
				Capacidad = 2,
				Ocupada = false,
				Alta = true,
                Exclusiva = false
            };
            context.Set<Habitacion>().Add(hab1);

            Habitacion hab2 = new Habitacion()
            {
                HabitacionId = 2,
                Exclusiva = false,
				Capacidad = 4,
				Ocupada = false,
				Alta = true,

				Planta = 0
            };
            context.Set<Habitacion>().Add(hab2);

            Habitacion hab3 = new Habitacion()
            {
                HabitacionId = 3,
                Exclusiva = false,
				Capacidad = 3,
				Ocupada = false,
				Alta = true,

				Planta = 0
            };
            context.Set<Habitacion>().Add(hab3);

            Habitacion hab4 = new Habitacion()
            {
                HabitacionId = 4,
                Exclusiva = false,
                Planta = 0,
				Capacidad = 3,
				Alta = true,

				Ocupada = false
			};
            context.Set<Habitacion>().Add(hab4);

            Habitacion hab5 = new Habitacion()
            {
                HabitacionId = 5,
                Exclusiva = false,
				Alta = true,

				Planta = 0,
				Capacidad = 3,
				Ocupada = false
			};
            context.Set<Habitacion>().Add(hab5);

            Habitacion hab6 = new Habitacion()
            {
                HabitacionId = 6,
				Alta = true,

				Exclusiva = false,
                Planta = 1,
				Capacidad = 3,
				Ocupada = false

			};
            context.Set<Habitacion>().Add(hab6);

            Habitacion hab7 = new Habitacion()
            {
                HabitacionId = 7,
                Exclusiva = false,
				Alta = true,

				Planta = 1,
				Capacidad = 3,
				Ocupada = false

			};
            context.Set<Habitacion>().Add(hab7);

            Habitacion hab8 = new Habitacion()
            {
                HabitacionId = 8,
                Exclusiva = false,
                Planta = 1,
				Alta = true,

				Capacidad = 3,
				Ocupada = false

			};
            context.Set<Habitacion>().Add(hab8);

            Habitacion hab9 = new Habitacion()
            {
                HabitacionId = 9,
                Exclusiva = false,
				Alta = true,

				Planta = 1,
				Capacidad = 3,
				Ocupada = false

			};
            context.Set<Habitacion>().Add(hab9);

            Habitacion hab10 = new Habitacion()
            {
                HabitacionId = 10,
                Exclusiva = false,
                Planta = 1,
				Capacidad = 3,
				Alta = true,

				Ocupada = false
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
				Ciudad = CiudadCdelU,

				Clientes = new List<Cliente>()
                {
                    Milton, Desconocido
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
				Ciudad = CiudadFederacion,
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
