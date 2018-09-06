namespace Persistencia.Domain
{
    public class AHCliente
    {
        public int AHClienteId { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int AlojHabId { get; set; }
        public AlojHab AlojHab { get; set; }
    }
}
