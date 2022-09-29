using Fung.COMMON.Enums;

namespace Fung.COMMON.DTO.Settings
{
    public sealed class SettingsDTO
    {
        public int Id { get; set; }
        public HeightUnit HeightUnit { get; set; }
        public VolumeUnit VolumeUnit { get; set; }
        public int UserId { get; set; }
    }
}
