using Fung.COMMON.DTO.FuelTank;
using Fung.COMMON.DTO.LevelIndicator;
using Microsoft.AspNetCore.Mvc;
using Fung.BLL.Services;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InputController : ControllerBase
    {
        private readonly InputService inputService;
        public InputController(InputService inputService)
        {
            this.inputService = inputService;
        }

        [HttpPost("level/{token}")]
        public async Task<IActionResult> PostLevelTransaction(string token, [FromBody] LevelIndicatorTransactionCreateDTO newTransactionDTO)
        {
            await inputService.CreateLevelTransaction(token, newTransactionDTO);
            return Ok();
        }

        [HttpPost("tank/{token}")]
        public async Task<FuelTankDTO> CreateTank(string token, [FromBody] FuelTankCreateDTO newTankDTO)
        {
            return await inputService.CreateTank(token, newTankDTO);
        }
    }
}
