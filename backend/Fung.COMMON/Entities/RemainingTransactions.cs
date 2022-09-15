namespace Fung.COMMON.Entities
{
    public class RemainingTransactions
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime TransactionTime { get; set; }
        public DateTime CeatedAt { get; set; } = DateTime.UtcNow;
        public int FuelTankId { get; set; }
    }
}
