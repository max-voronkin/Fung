using Fung.COMMON.DTO.Settings;

namespace Fung.COMMON.DTO.User
{
    public sealed class AuthUserDTO
    {
        public UserDTO User { get; set; } = null!;
        public SettingsDTO Settings { get; set; } = null!;
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
    }
}
