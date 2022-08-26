namespace Fung.COMMON.Entities
{
    public sealed class RefreshToken
    {
        public RefreshToken()
        {
            Expires = DateTime.UtcNow.AddDays(5);
        }
        public int Id { get; set; }
        public string Token { get; set; } = null!;
        public DateTime Expires { get; set; }

        public int UserId { get; set; }
        public bool IsActive => DateTime.UtcNow <= Expires;
    }
}
