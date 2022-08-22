﻿using Fung.BLL.Exceptions;
using Fung.BLL.Services;
using Fung.COMMON.DTO.Auth;
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
            try
            {
                return Ok(await authService.Autorize(loginDto));
            }
            catch (NotFoundException ex)
            {
                return Forbid(ex.Message);
            }
            catch (InvalidLoginCredentials ex)
            {
                return Forbid(ex.Message);
            }

        }

        // api/auth/register
        [HttpPost("register")]
        public async Task<ActionResult<AuthUserDTO>> Register([FromBody] UserRegisterDTO registerDTO)
        {
            var createdUser = await userService.CreateUser(registerDTO);
            var token = authService.GenerateAccessToken(createdUser.Id, createdUser.Email);
            return new AuthUserDTO
            {
                User = createdUser,
                Token = token
            };
        }
    }
}
