using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class HabClientesRow
    {
        public int iNumRow { get; private set; }
        public string iTarifaString { get; private set; }

        public HabClientesRow(int pNum, string pTarifa)
        {
            iNumRow = pNum;
            iTarifaString = pTarifa;
        }
    }
}
