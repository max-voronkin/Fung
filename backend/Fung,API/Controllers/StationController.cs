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
        public async Task<ICollection<StationDTO>> GetStationsAsync()
        {
            var userId = this.GetUserIdFromToken();
            return await stationService.GetStationsAsync(userId);
        }

        [HttpGet("{id}")]
        public async Task<StationDTO> GetStationAsync(int id)
        {
            return await stationService.GetStationAsync(id);
        }

        [HttpPost]
        public async Task<StationDTO> CreateStationAsync([FromBody] StationCreateDTO newStationDTO)
        {
            return await stationService.CreateStationAsync(newStationDTO);
        }

        [HttpDelete("{stationId}")]
        public async Task<IActionResult> DeleteStationAsync(int stationId)
        {
            await stationService.DeleteStationAsync(stationId);
            return NoContent();
        }
    }
}
