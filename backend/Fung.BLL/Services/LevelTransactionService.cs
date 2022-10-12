using AutoMapper;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.LevelIndicator;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Fung.BLL.Services
{
    public class LevelTransactionService : BaseService
    {
        public LevelTransactionService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<List<LevelIndicatorTransactionDTO>> GetTransactionsByTimePeriodAsync(int tankId, int hours)
        {
            var lastTransaction = await context.LevelIndicatorTransactions
                .Where(t => t.FuelTankId == tankId)
                .OrderByDescending(t => t.TransactionTime)
                .FirstOrDefaultAsync();

            if (lastTransaction is null)
            {
                return new List<LevelIndicatorTransactionDTO>();
            }

            var transactions = await context.LevelIndicatorTransactions
                .Where(t => t.FuelTankId == tankId)
                .OrderByDescending(t => t.TransactionTime)
                .Where(t => t.TransactionTime >= lastTransaction!.TransactionTime.AddHours(-hours))
                .ToListAsync();

            return mapper.Map<List<LevelIndicatorTransactionDTO>>(transactions);
        }
    }
}
