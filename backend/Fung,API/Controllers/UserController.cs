using Fung.BLL.Services;
using Fung.COMMON.DTO.User;
using Fung_API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("fromToken")]
        public async Task<ActionResult<UserDTO>> GetUserFromTokenAsync()
        {
            return Ok(await _userService.GetUserByIdAsync(this.GetUserIdFromToken()));
        }

        [HttpPut("updatePassword")]
        public async Task<IActionResult> ChangeUserPasswordAsync([FromBody] UserChangePasswordDTO changePasswordDTO)
        {
            await _userService.ChangeUserPasswordAsync(changePasswordDTO, this.GetUserIdFromToken());
            return Ok();
        }
    }
}
