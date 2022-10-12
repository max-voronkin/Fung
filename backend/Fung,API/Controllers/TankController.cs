using Fung.BLL.Services;
using Fung.COMMON.DTO.FuelTank;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TankController : ControllerBase
    {
        private readonly TankService tankService;
        public TankController(TankService tankService)
        {
            this.tankService = tankService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FuelTankInfoDTO>> GetTankAsync(int id)
        {
            return Ok(await tankService.GetTankAsync(id));
        }
    }
}
