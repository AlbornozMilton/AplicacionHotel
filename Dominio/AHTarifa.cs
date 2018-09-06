namespace Dominio
{
    public class AHTarifa
    {
        private int iAHTarifaId;
        private TarifaCliente iTarifaCliente;
        private AlojHab iAlojHab;

        public AHTarifa()
        {
        }

        public AHTarifa(TarifaCliente pTarifa)
        {
            iTarifaCliente = pTarifa;
        }

        public int AHTarifaId { get { return this.iAHTarifaId; } private set { this.iAHTarifaId = value; } }
        public TarifaCliente TarifaCliente { get { return this.iTarifaCliente; } private set { this.iTarifaCliente = value; } }
        public AlojHab AlojHab { get { return this.iAlojHab; } private set { this.iAlojHab = value; } }
    }
}
