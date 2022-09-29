using Fung.COMMON.Enums;

namespace Fung.COMMON.DTO.Settings
{
    public sealed class UpdateSettingsDTO
    {
        public int Id { get; set; }
        public HeightUnit HeightUnit { get; set; } = HeightUnit.Meter;
        public VolumeUnit VolumeUnit { get; set; } = VolumeUnit.Liter;
        public int UserId { get; set; }
    }
}
