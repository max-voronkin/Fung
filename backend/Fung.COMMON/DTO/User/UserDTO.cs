namespace Fung.COMMON.DTO.User
{
    public sealed class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public bool IsEmailConfirmed { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
