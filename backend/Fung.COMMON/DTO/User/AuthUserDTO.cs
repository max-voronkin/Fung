using Fung.COMMON.DTO.Auth;

namespace Fung.COMMON.DTO.User
{
    public sealed class AuthUserDTO
    {
        public UserDTO User { get; set; } = null!;
        public AuthTokenDTO Token { get; set; } = null!;
    }
}
