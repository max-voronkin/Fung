using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.FuelTank;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class TankService : BaseService
    {
        public TankService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<FuelTankInfoDTO> GetTank(int tankId)
        {
            var tank = await context.FuelTanks
                .Include(t => t.LevelTransactions)
                .Include(t => t.RemainingTransactions)
                .FirstOrDefaultAsync(t => t.Id == tankId);

            if (tank is null)
            {
                throw new NotFoundException(nameof(tank), tankId);
            }

            var tankInfoDto =  mapper.Map<FuelTankInfoDTO>(tank);

            var station = context.Stations.FirstOrDefault(st => st.Id == tank.StationId);
            if (station is null)
            {
                throw new NotFoundException(nameof(station), tank.StationId);
            }
            tankInfoDto.StationName = station.Name;

            return tankInfoDto;

        }
    }
}
