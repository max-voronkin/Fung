namespace Fung.COMMON.DTO.User
{
    public sealed class AuthUserDTO
    {
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = "refresh";
    }
}
