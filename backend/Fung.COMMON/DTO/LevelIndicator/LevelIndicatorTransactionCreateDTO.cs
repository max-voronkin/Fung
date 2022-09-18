namespace Fung.COMMON.DTO.LevelIndicator
{
    public sealed class LevelIndicatorTransactionCreateDTO
    {
        public double Height { get; set; }
        public decimal Temperature { get; set; }
        public double Volume { get; set; }
        public double Density { get; set; }
        public DateTime TransactionTime { get; set; }
        public int FuelTankId { get; set; }
    }
}
