using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using pers = Persistencia.Domain;
using AutoMapper;

namespace Dominio
{
    public class ControladorExtra
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        public bool IsNumeric (string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 

        public List<Servicio> ObtenerServicios()
        {
            IEnumerable<pers.Servicio> listaEnum = iUoW.RepositorioServicio.GetAll();
            List<Servicio> lista = new List<Servicio>();

            foreach (var serv in listaEnum)
            {
                lista.Add(Mapper.Map<pers.Servicio, Servicio>(serv));
            }
            return (lista);
        }

        public void AcutalizarCostoServicio(Servicio pServicio, string pCosto)
        {
            pServicio.ActualizarCosto(Convert.ToDouble(pCosto));
            iUoW.RepositorioServicio.ActualizarCostoServicio(Mapper.Map<Servicio, pers.Servicio>(pServicio));
        }

        public List<TarifaCliente> ObtenerTarifas()
        {
            IEnumerable<pers.TarifaCliente> listaEnum = iUoW.RepositorioTarifa.GetAll();
            List<TarifaCliente> lista = new List<TarifaCliente>();

            foreach (var serv in listaEnum)
            {
                lista.Add(Mapper.Map<pers.TarifaCliente, TarifaCliente>(serv));
            }
            return (lista);
        }

        public void AcutalizarTarifa(TarifaCliente pTarifa, string pCostoNoExcl, string pCostoExcl)
        {
            if (pCostoNoExcl == "")
            {
                throw new Exception("Debe ingresar una nueva Tarifa");
            }
            else if (pCostoExcl == "")
            {
                throw new Exception("Debe ingresar una nueva Tarifa Exclusiva");
            }
            else if ((!IsNumeric(pCostoExcl)) || (!IsNumeric(pCostoNoExcl)))
            {
                throw new Exception("Debe ingresar solo números");
            }

            pTarifa.ActualizarMontos(Convert.ToDouble(pCostoNoExcl), Convert.ToDouble(pCostoExcl));
            iUoW.RepositorioTarifa.ActualizarMontos(Mapper.Map<TarifaCliente, pers.TarifaCliente>(pTarifa));
        }
    }
}
