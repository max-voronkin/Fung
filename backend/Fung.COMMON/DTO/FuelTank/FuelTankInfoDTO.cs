using Fung.COMMON.DTO.LevelIndicator;
using Fung.COMMON.DTO.RemainingTransaction;

namespace Fung.COMMON.DTO.FuelTank
{
    public sealed class FuelTankInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Number { get; set; }
        public double Capacity { get; set; }
        public double CurrentAmount { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int StationId { get; set; }
        public ICollection<LevelIndicatorTransactionsDTO>? LevelTransactions { get; set; }
        public ICollection<RemainingTransactionsDTO>? RemainingTransactions { get; set; }
        public string StationName { get; set; } = null!;
    }
}
