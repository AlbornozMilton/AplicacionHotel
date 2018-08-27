namespace Dominio
{
    public class HabClientesRow
    {
        public int NumRow { get; private set; }
        public string TarifaString { get; private set; }
        public bool Check { get; set; }

        public HabClientesRow(int pNum, string pTarifa)
        {
            NumRow = pNum;
            TarifaString = pTarifa;
            Check = false;
        }
    }
}
