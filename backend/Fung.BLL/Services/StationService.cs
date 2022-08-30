using AutoMapper;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.Station;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class StationService : BaseService
    {
        public StationService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<StationDTO>> GetStationsInfo(int userId)
        {
            var stations = await context.Stations.Where(s => s.UserId == userId)
                .Include(s => s.FuelTanks!)
                    .ThenInclude(ft => ft.LavelTransactions!.OrderByDescending(l => l.TransactionTime).Take(1))
                .Include(s => s.FuelTanks!)
                    .ThenInclude(ft => ft.RemainingTransactions!.OrderByDescending(r => r.TransactionTime).Take(1))
                .ToListAsync();

            return mapper.Map<ICollection<StationDTO>>(stations);
        }
    }
}
