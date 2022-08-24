using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fung.BLL.JWT
{
    public class JwtFactory
    {
        private readonly JwtIssuerOptions options;
        public JwtFactory(JwtIssuerOptions options)
        {
            this.options = options;
        }
        public string GenerateAccessToken(int id, string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, email),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new Claim("UserId", id.ToString())
             };

            var token = new JwtSecurityToken(null,
                null,
                claims,
                expires: DateTime.Now.AddDays(options.ValidFor),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
