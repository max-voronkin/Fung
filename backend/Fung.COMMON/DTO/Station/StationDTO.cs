using Fung.COMMON.DTO.FuelTank;
using Fung.COMMON.Entities;

namespace Fung.COMMON.DTO.Station
{
    public sealed class StationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UserId { get; set; }
        public string Token { get; set; } = null!;
        public ICollection<FuelTankDTO>? FuelTanks { get; set; }
    }
}
