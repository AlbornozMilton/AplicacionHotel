using System.Collections.Generic;
using System.Linq;

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

        public void AgregarTarifaRow(int pNum, string pTarifa)
        {
            //pNum es el numero de fila, si ya existe es por que se esta cambiando de tipo de tarifa para la misma fila
            var row = iRowTarifas.Find(r => r.NumRow == pNum);
            if (row != null)
                iRowTarifas.Remove(row);

            iRowTarifas.Add(new HabClientesRow(pNum, pTarifa));
        }

        /// <param name="TipoC">Nombre de Tarfifa que se evaluara el "Contains"</param>
        /// <returns>bool</returns>
        public bool CheckinTarifaCliente(string TipoC)
        {
            bool result = false;
            foreach (HabClientesRow row in iRowTarifas)
            {
                if (!row.Check && row.TarifaString == TipoC)
                    result = true;
                else
                    result = false;
            }
            return result;
        }

        /// <summary>
        /// Solo cuando este alojamiento se haya reservado
        /// </summary>
        public bool ControlTarifasCliente()
        {
            bool resultado = true;

            if (this.Tarifas.Count == this.Clientes.Count)
            {
                List<TarifaCliente> AuxTarifas = this.Tarifas.OrderBy(t => t.TarifaClienteId).ToList();
                List<Cliente> AuxTarifasCli = this.Clientes.OrderBy(c => c.TarifaCliente.TarifaClienteId).ToList();

                for (int i = 0; i < AuxTarifas.Count; i++)
                {
                    if (AuxTarifas[i].TarifaClienteId != AuxTarifasCli[i].TarifaCliente.TarifaClienteId)
                    {
                        resultado = false;
                        break;
                    }
                } 
            }
            else
                resultado = false;

            return resultado;
        }
    }
}
