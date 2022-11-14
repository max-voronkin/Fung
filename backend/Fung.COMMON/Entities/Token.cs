using Fung.COMMON.Enums;

namespace Fung.COMMON.Entities
{
    public sealed class Token
    {
        public Token()
        {
            Expires = DateTime.UtcNow.AddDays(5);
        }
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public DateTime Expires { get; set; }

        public int UserId { get; set; }
        public bool IsActive => DateTime.UtcNow <= Expires;
        public TokenType Type { get; set; }
    }
}
