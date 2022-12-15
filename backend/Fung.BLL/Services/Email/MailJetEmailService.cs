using Fung.BLL.Email;
using Fung.BLL.Options;
using Fung.COMMON.Entities;
using Mailjet.Client;
using Mailjet.Client.TransactionalEmails;

namespace Fung.BLL.Services.Email
{
    public class MailJetEmailService : BaseEmailService, IEmailService
    {
        private readonly IMailjetClient client;
        private readonly MailJetOptions mailJetOptions;
        public MailJetEmailService(IMailjetClient client, EmailOptions options, MailJetOptions mailJetOptions) : base(options)
        {
            this.client = client;
            this.mailJetOptions = mailJetOptions;
        }

        public async Task SendEmailAsync(string recipient, Token token)
        {
            var email = await BuildEmailAsync(recipient, token);

            var response = await client.SendTransactionalEmailAsync(email, isSandboxMode: mailJetOptions.IsSandboxMode);
        }

        private async Task<TransactionalEmail> BuildEmailAsync(string recipient, Token token)
        {
            return new TransactionalEmailBuilder()
                .WithFrom(new SendContact(emailOptions.SenderEmail))
                .WithTo(new SendContact(recipient))
                .WithSubject(GetSubject(token))
                .WithHtmlPart(await GetContent(token))
                .Build();
        }
    }
}
