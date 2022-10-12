using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.Station;
using Fung.COMMON.Entities;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class StationService : BaseService
    {
        public StationService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<StationDTO>> GetStationsAsync(int userId)
        {
            var stations = await context.Stations.Where(s => s.UserId == userId)
                .Include(s => s.FuelTanks!)
                    .ThenInclude(ft => ft.LevelTransactions!.OrderByDescending(l => l.TransactionTime).Take(1))
                .Include(s => s.FuelTanks!)
                    .ThenInclude(ft => ft.RemainingTransactions!.OrderByDescending(r => r.TransactionTime).Take(1))
                .ToListAsync();

            return mapper.Map<ICollection<StationDTO>>(stations);
        }

        public async Task<StationDTO> GetStationAsync(int stationId)
        {
            var station = await context.Stations
                .Include(s => s.FuelTanks!)
                    .ThenInclude(ft => ft.LevelTransactions!.OrderByDescending(l => l.TransactionTime).Take(1))
                .Include(s => s.FuelTanks!)
                    .ThenInclude(ft => ft.RemainingTransactions!.OrderByDescending(r => r.TransactionTime).Take(1))
                .FirstOrDefaultAsync(s => s.Id == stationId);

            return mapper.Map<StationDTO>(station);

        }

        public async Task<StationDTO> CreateStationAsync(StationCreateDTO newStationDTO)
        {
            var station = new Station()
            {
                Name = newStationDTO.Name,
                UserId = newStationDTO.UserId
            };

            await context.Stations.AddAsync(station);
            await context.SaveChangesAsync();

            var createdStation = await context.Stations.FirstOrDefaultAsync(s => s.Id == station.Id);
            if (createdStation is null)
            {
                throw new NotFoundException(nameof(Station));
            }
            return mapper.Map<StationDTO>(createdStation);
        }

        public async Task DeleteStationAsync(int stationId)
        {
            var station = await context.Stations.FirstOrDefaultAsync(s => s.Id == stationId);
            if (station is null)
            {
                throw new NotFoundException(nameof(Station), stationId);
            }
            context.Stations.Remove(station);
            await context.SaveChangesAsync();
        }
    }
}
