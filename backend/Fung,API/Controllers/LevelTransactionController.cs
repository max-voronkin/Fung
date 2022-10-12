using Fung.BLL.Services;
using Fung.COMMON.DTO.LevelIndicator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fung_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LevelTransactionController : ControllerBase
    {
        private readonly LevelTransactionService levelService;

        public LevelTransactionController(LevelTransactionService levelService)
        {
            this.levelService = levelService;
        }

        [HttpGet("{id}/{hours}")]
        public async Task<List<LevelIndicatorTransactionDTO>> GetTransactionsByTimePeriodAsync(int id, int hours)
        {
            return await levelService.GetTransactionsByTimePeriodAsync(id, hours);
        }

    }
}
