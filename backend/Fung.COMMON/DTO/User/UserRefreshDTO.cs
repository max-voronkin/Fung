using System.Text.Json.Serialization;

namespace Fung.COMMON.DTO.User
{
    public sealed class UserRefreshDTO
    {
        public UserRefreshDTO()
        {
            SigningKey = Environment.GetEnvironmentVariable("jwt")!;
        }
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;

        [JsonIgnore]
        public string SigningKey { get; private set; }
    }
}
