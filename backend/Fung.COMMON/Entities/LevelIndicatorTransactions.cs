namespace Fung.COMMON.Entities
{
    public class LevelIndicatorTransactions
    {
        public int Id { get; set; }
        public double Height { get; set; }
        public decimal Temperature { get; set; }
        public double Volume { get; set; }
        public double Density { get; set; }
        public DateTime TransactionTime { get; set; }
        public DateTime CeatedAt { get; set; } = DateTime.UtcNow;
        public int FuelTankId { get; set; }
    }
}
