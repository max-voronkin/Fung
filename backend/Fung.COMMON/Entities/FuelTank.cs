namespace Fung.COMMON.Entities
{
    public class FuelTank
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Number { get; set; }
        public double Capacity { get; set; }
        public double CurrentAmount { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int StationId { get; set; }

        public ICollection<LevelIndicatorTransactions>? LevelTransactions{ get; set; }
        public ICollection<RemainingTransactions>? RemainingTransactions{ get; set; }

    }
}
