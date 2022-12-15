using Fung.COMMON.Entities;

namespace Fung.BLL.Email
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string recipient, Token token);
    }
}
