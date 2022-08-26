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
        private readonly UserService userService;
        public AuthController(AuthService authService, UserService userService)
        {
            this.authService = authService;
            this.userService = userService;
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
            var createdUser = await userService.CreateUser(registerDTO);
            return authService.GenerateAccessToken(createdUser.Id, createdUser.Email);
        }

        // api/auth/refresh
        [HttpPost("refresh")]
        public async Task<ActionResult<AuthUserDTO>> Refresh([FromBody] UserRefreshDTO refreshDTO)
        {
            return await authService.RefreshToken(refreshDTO);
        }
    }
}
