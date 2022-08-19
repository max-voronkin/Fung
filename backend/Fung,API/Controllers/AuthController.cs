﻿using Fung.BLL.Services;
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
        public async Task<IActionResult> Login([FromBody] UserLoginDTO loginDto)
        {
            throw new NotImplementedException();
        }

        // api/auth/register
        [HttpPost("register")]
        public async Task<AuthUserDTO> Register([FromBody] UserRegisterDTO registerDTO)
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
