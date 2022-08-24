using Fung.COMMON.DTO.Auth;

namespace Fung.COMMON.DTO.User
{
    public sealed class AuthUserDTO
    {
        public AuthTokenDTO Token { get; set; } = null!;
    }
}
