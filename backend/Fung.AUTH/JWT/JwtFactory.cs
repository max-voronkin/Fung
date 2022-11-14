
using Fung.COMMON.Security;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fung.BLL.JWT
{
    public class JwtFactory
    {
        private readonly JwtIssuerOptions options;
        private readonly JwtSecurityTokenHandler jwtTokenHandler;
        public JwtFactory(JwtIssuerOptions options)
        {
            this.options = options;
            this.jwtTokenHandler = new JwtSecurityTokenHandler();
        }

        public string GenerateAccessToken(int id, string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, email),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new Claim("userId", id.ToString())
             };

            var token = new JwtSecurityToken(null,
                null,
                claims,
                expires: DateTime.Now.AddMinutes(options.ValidFor),
                signingCredentials: credentials);

            return jwtTokenHandler.WriteToken(token);
        }

        public string GenerateResetToken(int id, string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
{
                 new Claim(JwtRegisteredClaimNames.Email, email),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new Claim("userId", id.ToString())
             };

            var token = new JwtSecurityToken(null, null, claims,expires: DateTime.Now.AddMinutes(15), signingCredentials: credentials);
            return jwtTokenHandler.WriteToken(token);
        }

        public int GetUserIdFromToken(string accessToken, string signingKey)
        {
            var claimsPrincipal = GetPrincipalFromToken(accessToken, signingKey);
            return int.Parse(claimsPrincipal.Claims.First(c => c.Type == "userId").Value);
        }

        public ClaimsPrincipal GetPrincipalFromToken(string token, string signingKey)
        {
            return ValidateToken(token, new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey)),
                ValidateLifetime = false // we check expired tokens here
            });
        }

        private ClaimsPrincipal ValidateToken(string token, TokenValidationParameters tokenValidationParameters)
        {

            var principal = jwtTokenHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);

            if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }

        public string GenerateRefreshToken()
        {
            return Convert.ToBase64String(SecurityHelper.GetRandomBytes());
        }
    }
}
