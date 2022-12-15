using Fung.BLL.Options;
using Fung.BLL.Services;
using Fung.COMMON.Entities;
using Fung.COMMON.Enums;

namespace Fung.BLL.Email
{
    public class BaseEmailService
    {
        protected readonly EmailOptions emailOptions;
        public BaseEmailService(EmailOptions options)
        {
            emailOptions = options;
        }

        protected string GetSubject(Token token)
        {
            return token.Type switch
            {
                TokenType.Reset => "Password reset",
                _ => ""
            };
        }

        protected async Task<string> GetContent(Token token)
        {
            string resource = token.Type switch
            {
                TokenType.Reset => await ResourceService.GetResource("RessetPasswordEmail.html"),
                _ => ""
            };

            var args = CreateArguments(token);
            foreach (var pair in args)
                resource = resource.Replace($"{{{pair.Key}}}", pair.Value);

            return resource;
        }

        protected string GetEndpoint(Token token)
        {
            return token.Type switch
            {
                TokenType.Reset => options.PasswordResetEndpoint,
                _ => ""
            };
        }

        protected Dictionary<string, string> CreateArguments(Token token)
        {
            Dictionary<string, string> args = new();

            switch (token.Type)
            {
                case TokenType.Refresh:
                    break;
                case TokenType.Reset:
                    string link = $"{options.Host}{GetEndpoint(token)}?token={token.Value}";
                    args.Add("link", link);
                    break;
                default:
                    break;
            }
            return args;
        }
    }
}
