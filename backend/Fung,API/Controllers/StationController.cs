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
        public async Task<ICollection<StationDTO>> GetStations()
        {
            var userId = this.GetUserIdFromToken();
            return await stationService.GetStationsInfo(userId);
        }
    }
}
