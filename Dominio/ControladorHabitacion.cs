using System.Collections.Generic;
using Persistencia.DAL.EntityFramework;
using AutoMapper;
using pers = Persistencia.Domain;
using System.Linq;
using System;

namespace Dominio
{
    public class ControladorHabitacion
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        public Habitacion ObtenerHabitacion(int unId)
        {
            pers.Habitacion unaHab = iUoW.RepositorioHabitacion.Get(unId);
            Habitacion laHabBuscada = Mapper.Map<pers.Habitacion, Habitacion>(unaHab);
            return laHabBuscada;
        }

        public List<Habitacion> GetAllHabitaciones()
        {
            List<Habitacion> listaResultado = new List<Habitacion>();
            foreach (var hab in iUoW.RepositorioHabitacion.GetAll())
            {
                listaResultado.Add(Mapper.Map<pers.Habitacion, Habitacion>(hab));
            }
            return listaResultado;
        }

        /// <summary>
        /// Devuelve las Habitaciones que estan solamente en Alta
        /// </summary>
        /// <returns></returns>
        public List<Habitacion> ObtenerHabitacionesFullLibres()
        {
            IEnumerable<pers.Habitacion> listaEnum = iUoW.RepositorioHabitacion.GetAll();
            List<Habitacion> lista = new List<Habitacion>();
            foreach (var hab in listaEnum)
            {
                if (hab.Alta)
                {
                    Habitacion HabDom = Mapper.Map<pers.Habitacion, Habitacion>(hab);
                    HabDom.DesocuparHabitacion();
                    lista.Add(HabDom);
                }
            }
            return (lista);
        }

        /// <summary>
        /// Devuelve una lista con Alojamiento Activos en los que se encuetra una Habitación
        /// </summary>
        public List<Alojamiento> ControlModificarAltaHabitacion(int pIdHabitacion)
        {
            List<Alojamiento> AlojsActivos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
            List<Alojamiento> AlojsResltultado = new List<Alojamiento>();

            foreach (var aloj in AlojsActivos)
            {
                foreach (var alojHab in aloj.AlojHabes)
                {
                    if (alojHab.Habitacion.HabitacionId == pIdHabitacion)
                    {
                        AlojsResltultado.Add(aloj);
                    }
                }
            }
            return AlojsResltultado;
        }

        public void ModificarAltaDeHabitacion(Habitacion pHabitacion)
        {
            iUoW.RepositorioHabitacion.ModificarAltaHabitacion(Mapper.Map<Habitacion, pers.Habitacion>(pHabitacion));
        }

        //pasar un datagrid
        public List<AlojHab> GenerarAlojHabs(System.Windows.Forms.DataGridView pHabSeleccionadas)
        {
            List<AlojHab> resultado = new List<AlojHab>();

            return resultado;
        }

        public List<AlojHab> GenerarTarifas(List<AlojHab> pAH)
        {
            var ltarifas = iUoW.RepositorioTarifa.GetAll().ToList();

            foreach (AlojHab item in pAH)
            {
                foreach (HabClientesRow row in item.Rows)
                {
                    switch (row.iTarifaString)
                    {
                        case ("Acomp. Directo"):
                            {
                                item.Tarifas.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(ltarifas.Find(t => t.TarifaClienteId == pers.TipoCliente.AcompanianteDirecto)));
                            }
                            break;
                        case ("Acomp. No Direct"):
                            {
                                item.Tarifas.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(ltarifas.Find(t => t.TarifaClienteId == pers.TipoCliente.AcompanianteNoDirecto)));
                            }
                            break;
                        case ("Convenio"):
                            {
                                item.Tarifas.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(ltarifas.Find(t => t.TarifaClienteId == pers.TipoCliente.Convenio)));
                            }
                            break;
                        case ("Titular"):
                            {
                                item.Tarifas.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(ltarifas.Find(t => t.TarifaClienteId == pers.TipoCliente.Titular)));
                            }
                            break;
                        case ("Titular Exceptuado"):
                            {
                                item.Tarifas.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(ltarifas.Find(t => t.TarifaClienteId == pers.TipoCliente.TitularExceptuado)));
                            }
                            break;
                        default:
                            throw new Exception("Falta seleccionar algún Tipo de Cliente");
                    }
                }
            }

            return pAH;
        }
    }
}
