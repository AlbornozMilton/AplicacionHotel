namespace Persistencia.Domain
{
    public class AHTarifa
    {
        public int AHTarifaId { get; set; }

        public int AHTarifa_TarifaCliente { get; set; }
        public TarifaCliente TarifaCliente { get; set; }

        public int AlojHabId { get; set; }
        public AlojHab AlojHab { get; set; }
    }
}
