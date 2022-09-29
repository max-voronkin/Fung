using Fung.COMMON.Enums;

namespace Fung.COMMON.Entities
{
    public sealed class Settings
    {
        public Settings()
        {
                
        }
        public Settings(int userId)
        {
            UserId = userId;
        }
        public int Id { get; set; }
        public HeightUnit HeightUnit { get; set; } = HeightUnit.Meter;
        public VolumeUnit VolumeUnit { get; set; } = VolumeUnit.Liter;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
