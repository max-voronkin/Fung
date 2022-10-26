namespace Fung.COMMON.DTO.User
{
    public sealed class UserChangePasswordDTO
    {
        public string Password { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
    }
}
