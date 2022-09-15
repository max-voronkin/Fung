namespace Fung.COMMON.Entities
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Token { get; set; } = Guid.NewGuid().ToString();
        public int UserId { get; set; }
        public ICollection<FuelTank>? FuelTanks{ get; set; }
    }
}
