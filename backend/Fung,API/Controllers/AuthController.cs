using Fung.BLL.Email;
using Fung.BLL.Exceptions;
using Fung.BLL.Services;
using Fung.BLL.Services.Email;
using Fung.COMMON.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService authService;
        private readonly IEmailService emailService;
        public AuthController(AuthService authService, IEmailService emailService)
        {
            this.authService = authService;
            this.emailService = emailService;
        }

        // api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult<AuthUserDTO>> LoginAsync([FromBody] UserLoginDTO loginDto)
        {
            return Ok(await authService.AutorizeAsync(loginDto));
        }

        // api/auth/register
        [HttpPost("register")]
        public async Task<ActionResult<AuthUserDTO>> RegisterAsync([FromBody] UserRegisterDTO registerDTO)
        {
            return Ok(await authService.RegisterAsync(registerDTO));
        }

        // api/auth/refresh
        [HttpPost("refresh")]
        public async Task<ActionResult<AuthUserDTO>> RefreshAsync([FromBody] UserRefreshDTO refreshDTO)
        {
            return Ok(await authService.RefreshTokenAsync(refreshDTO));
        }

        //api/auth/revoke
        [HttpPost("revoke")]
        public async Task RevokeAsync([FromBody] UserRevokeDTO token)
        {
            await authService.RevokeTokenAsync(token);
        }

        //api/auth/reset
        [HttpGet("reset/{email}")]
        public async Task<ActionResult<bool>> RequestResetPasswordAsync(string email)
        {
            try
            {
                var token = await authService.CreateResetTokenAsync(email);
                await emailService.SendEmailAsync(email, token);
            }
            catch (InvalidLoginCredentialsException)
            {
                return Ok(false);
            }
            return Ok(true);
        }
    }
}
