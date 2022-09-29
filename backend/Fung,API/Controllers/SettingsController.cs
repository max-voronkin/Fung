using Fung.BLL.Services;
using Fung.COMMON.DTO.Settings;
using Fung_API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SettingsController : ControllerBase
    {
        private readonly SettingsService _settingsService;
        public SettingsController(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet("fromToken")]
        public async Task<ActionResult<SettingsDTO>> GetSettingsFromTokenAsync(int userId)
        {
            return Ok(await _settingsService.GetSettingsByIdAsync(this.GetUserIdFromToken()));
        }

        [HttpPut]
        public async Task<ActionResult<SettingsDTO>> UpdateSettingsAsync([FromBody] UpdateSettingsDTO dto)
        {
            return Ok(await _settingsService.UpdateSettingsAsync(dto));
        }
    }
}
