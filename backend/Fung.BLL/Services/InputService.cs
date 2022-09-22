using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.Hubs;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.FuelTank;
using Fung.COMMON.DTO.LevelIndicator;
using Fung.COMMON.Entities;
using Fung.DAL;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace Fung.BLL.Services
{
    public class InputService : BaseService
    {
        private readonly IHubContext<LastLevelTransactionHub> tankHub;
        public InputService(DataContext context, IMapper mapper, IHubContext<LastLevelTransactionHub> tankHub) : base(context, mapper)
        {
            this.tankHub = tankHub;
        }

        public async Task CreateLevelTransaction(string token, LevelIndicatorTransactionCreateDTO newTransactionDTO)
        {
            var station = await context.Stations
                .Include(s => s.FuelTanks)
                .FirstOrDefaultAsync(s => s.Token == token);
            if (station is null)
            {
                throw new InvalidTokenException();
            }

            var tank = station.FuelTanks?.FirstOrDefault(t => t.Id == newTransactionDTO.FuelTankId);
            if (tank is null)
            {
                throw new NotFoundException(nameof(FuelTank), newTransactionDTO.FuelTankId);
            }

            var transaction = mapper.Map<LevelIndicatorTransactions>(newTransactionDTO);
            tank.CurrentAmount = transaction.Volume;
            tank.UpdatedAt = DateTime.UtcNow;

            await context.LevelIndicatorTransactions.AddAsync(transaction);
            await context.SaveChangesAsync();

            await tankHub.Clients.Groups(tank.Id.ToString()).SendAsync("NewTransaction", mapper.Map<LevelIndicatorTransactionDTO>(transaction));
        }

        public async Task<FuelTankDTO> CreateTank(string token, FuelTankCreateDTO newTankDTO)
        {
            var station = await context.Stations.FirstOrDefaultAsync(s => s.Token == token);
            if (station is null)
            {
                throw new InvalidTokenException();
            }

            var tank = mapper.Map<FuelTank>(newTankDTO);
            tank.StationId = station.Id;
            await context.FuelTanks.AddAsync(tank);
            await context.SaveChangesAsync();

            var createdTank = await context.FuelTanks.FirstOrDefaultAsync(t => t.Id == tank.Id);
            return mapper.Map<FuelTankDTO>(createdTank);
        }
    }
}
