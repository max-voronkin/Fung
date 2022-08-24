using Microsoft.IdentityModel.Tokens;

namespace Fung.BLL.JWT
{
    public class JwtIssuerOptions
    {
        public string Key { get; set; } = null!;
        public int ValidFor { get; set; }
        public SigningCredentials SigningCredentials { get; set; } = null!;
    }
}
