using Fung.BLL.Services;
using Fung.COMMON.DTO.Station;
using Fung_API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StationController : ControllerBase
    {
        private readonly StationService stationService;
        public StationController(StationService stationService)
        {
            this.stationService = stationService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<StationDTO>>> GetStationsAsync()
        {
            var userId = this.GetUserIdFromToken();
            return Ok(await stationService.GetStationsAsync(userId));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StationDTO>> GetStationAsync(int id)
        {
            return Ok(await stationService.GetStationAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<StationDTO>> CreateStationAsync([FromBody] StationCreateDTO newStationDTO)
        {
            return Ok(await stationService.CreateStationAsync(newStationDTO));
        }

        [HttpDelete("{stationId}")]
        public async Task<IActionResult> DeleteStationAsync(int stationId)
        {
            await stationService.DeleteStationAsync(stationId);
            return NoContent();
        }
    }
}
