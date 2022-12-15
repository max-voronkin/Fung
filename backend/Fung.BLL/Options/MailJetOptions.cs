namespace Fung.BLL.Options
{
    public sealed class MailJetOptions
    {
        public string ApiKey { get; set; } = null!;
        public string ApiSecret { get; set; } = null!;
        public bool IsSandboxMode { get; set; }
    }
}
