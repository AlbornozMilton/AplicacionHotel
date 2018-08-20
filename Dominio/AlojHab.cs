using System.Collections.Generic;

namespace Dominio
{
    public class AlojHab
    {
        int iAlojHabId;
        bool iExclusividad;
        Alojamiento iAloj;
        Habitacion iHab;
        List<HabClientesRow> iRowTarifas = new List<HabClientesRow>();
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
        public List<HabClientesRow> Rows { get { return this.iRowTarifas; } private set { this.iRowTarifas = value; } }

        public void AgregarTarifa(int pNum, string pTarifa)
        {
            var row = iRowTarifas.Find(r => r.iNumRow == pNum);

            if (row != null)
                iRowTarifas.Remove(row);

            iRowTarifas.Add(new HabClientesRow(pNum, pTarifa));
        }
    }
}
