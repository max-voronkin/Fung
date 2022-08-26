using Fung.BLL.Exceptions;
using Fung.BLL.Services;
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
        public AuthController(AuthService authService)
        {
            this.authService = authService;
        }

        // api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult<AuthUserDTO>> Login([FromBody] UserLoginDTO loginDto)
        {
            return Ok(await authService.Autorize(loginDto));
        }

        // api/auth/register
        [HttpPost("register")]
        public async Task<ActionResult<AuthUserDTO>> Register([FromBody] UserRegisterDTO registerDTO)
        {
            return Ok(await authService.Register(registerDTO));
        }

        // api/auth/refresh
        [HttpPost("refresh")]
        public async Task<ActionResult<AuthUserDTO>> Refresh([FromBody] UserRefreshDTO refreshDTO)
        {
            return await authService.RefreshToken(refreshDTO);
        }

        //api/auth/revoke
        [HttpPost("revoke")]
        public async Task<IActionResult> Revoke([FromBody] string refreshToken)
        {
            await authService.RevokeToken(refreshToken);
            return Ok();
        }
    }
}
