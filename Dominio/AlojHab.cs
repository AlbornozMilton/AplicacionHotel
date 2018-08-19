using System.Collections.Generic;

namespace Dominio
{
    public class AlojHab
    {
        int iAlojHabId;
        bool iExclusividad;
        Alojamiento iAloj;
        Habitacion iHab;
        List<TarifaCliente> iTarifas = new List<TarifaCliente>();
        List<Cliente> iClientes = new List<Cliente>();

        public AlojHab() { }

        //Para reserva 
        public AlojHab(bool pExcl, Habitacion pHab, List<TarifaCliente> pTarifas)
        {
            iHab = pHab;
            iExclusividad = pExcl;
            iTarifas = pTarifas;
        }

        //Para reserva 
        public AlojHab(Habitacion pHab)
        {
            iHab = pHab;
        }

        public int AlojHabId { get { return this.iAlojHabId; } private set { this.iAlojHabId = value; } }
        public bool Exclusividad { get { return this.iExclusividad; } set { this.iExclusividad = value; } }
        public Alojamiento Alojamiento { get { return this.iAloj; } private set { this.iAloj = value; } }
        public Habitacion Habitacion { get { return this.iHab; } private set { this.iHab = value; } }
        public List<TarifaCliente> Tarifas { get { return this.iTarifas; } private set { this.iTarifas = value; } }
        public List<Cliente> Clientes { get { return this.iClientes; } private set { this.iClientes = value; } }

        public void AgregarTarifa(TarifaCliente pTarifa)
        {
            iTarifas.Add(pTarifa);
        }

        public void CambioTarifa(TarifaCliente pOldTarifa, TarifaCliente pNewTarifa)
        {
            iTarifas.Remove(iTarifas.Find(t => t.NombreTarifa == pOldTarifa.NombreTarifa));
            AgregarTarifa(pNewTarifa);
        }

    }
}
