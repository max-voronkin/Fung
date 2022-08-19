using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Fung.COMMON.Security
{
    public static class SecurityHelper
    {
        public static byte[] GetRandomBytes(int length = 32)
        {
            return RandomNumberGenerator.GetBytes(length);
        }

        public static string HashPassword(string password, byte[] salt)
        => Convert.ToBase64String(
            KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            )
        );

    }
}
