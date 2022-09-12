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

        public async Task<ICollection<LevelIndicatorTransactionDTO>> GetOneHourInfo(int tankId)
        {
            var transactions = await context.LevelIndicatorTransactions
                .Where(t => t.FuelTankId == tankId)
                .OrderByDescending(t => t.TransactionTime)
                .TakeWhile(t => t.TransactionTime <= DateTime.UtcNow.AddHours(-1))
                .ToListAsync();

            return mapper.Map<ICollection<LevelIndicatorTransactionDTO>>(transactions);
        }
    }
}
