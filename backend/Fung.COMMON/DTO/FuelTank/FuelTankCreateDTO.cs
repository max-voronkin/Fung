namespace Fung.COMMON.DTO.FuelTank
{
    public sealed class FuelTankCreateDTO
    {
        public string Name { get; set; } = null!;
        public int Number { get; set; }
        public double Capacity { get; set; }
    }
}
