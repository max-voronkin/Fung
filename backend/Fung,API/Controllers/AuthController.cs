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
            return await authService.RefreshTokenAsync(refreshDTO);
        }

        //api/auth/revoke
        [HttpPost("revoke")]
        public async Task RevokeAsync([FromBody] UserRevokeDTO token)
        {
            await authService.RevokeTokenAsync(token);
        }
    }
}
