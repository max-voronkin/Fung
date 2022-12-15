namespace Fung.BLL.Options
{
    public sealed class EmailOptions
    {
        public string Host { get; set; } = "";
        public string PasswordResetEndpoint { get; set; } = "";
        public string SenderEmail { get; set; } = null!;
    }
}
