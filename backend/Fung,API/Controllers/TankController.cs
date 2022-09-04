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
        public async Task<FuelTankInfoDTO> GetTank(int id)
        {
            return await tankService.GetTank(id);
        }
    }
}
