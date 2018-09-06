namespace Dominio
{
    public class AHCliente
    {
        private int iAHClienteId;
        private Cliente iCliente;
        private AlojHab iAlojHab;

        public int AHClienteId { get { return this.iAHClienteId; } private set { this.iAHClienteId = value; } }
        public Cliente Cliente { get { return this.iCliente; } private set { this.iCliente = value; } }
        public AlojHab AlojHab { get { return this.iAlojHab; } private set { this.iAlojHab = value; } }
    }
}
