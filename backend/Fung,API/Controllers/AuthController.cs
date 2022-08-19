using Fung.BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService authService;
        public AuthController(AuthService service)
        {
            authService = service;
        }
    }
}
