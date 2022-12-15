using Fung.BLL.Email;
using Fung.BLL.Options;
using Fung.COMMON.Entities;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Fung.BLL.Services.Email
{
    public class SendGirdEmailService : BaseEmailService, IEmailService
    {
        private readonly ISendGridClient client;

        public SendGirdEmailService(ISendGridClient client, EmailOptions emailOptions) : base(emailOptions)
        {
            this.client = client;
        }
        public async Task SendEmailAsync(string recipient, Token token)
        {
            SendGridMessage email = new SendGridMessage()
            {
                From = new EmailAddress(emailOptions.SenderEmail),             
                Subject = GetSubject(token),
                HtmlContent = await GetContent(token)
            };
            email.AddTo(recipient);

            var resp = await client.SendEmailAsync(email);
        }
    }
}
