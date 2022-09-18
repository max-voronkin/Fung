using AutoMapper;
using Fung.BLL.Exceptions;
using Fung.BLL.Services.Abstract;
using Fung.COMMON.DTO.FuelTank;
using Fung.COMMON.DTO.LevelIndicator;
using Fung.COMMON.Entities;
using Fung.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fung.BLL.Services
{
    public class InputService : BaseService
    {
        public InputService(DataContext context, IMapper mapper) : base(context, mapper)
        {
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
