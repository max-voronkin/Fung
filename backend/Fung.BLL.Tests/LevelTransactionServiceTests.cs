using Fung.BLL.Services;
using Fung.COMMON.Entities;
using Fung.DAL;
using Xunit;

namespace Fung.BLL.Tests
{
    public class LevelTransactionServiceTests : BaseTest
    {
        private readonly LevelTransactionService levelService;
        private readonly DataContext context;
        public LevelTransactionServiceTests()
        {
            context = new DataContext(dbContextOptions);
            levelService = new LevelTransactionService(context, mapper);
        }

        #region GetTransactionsByTimePeriod

        [Fact]
        public async Task GetTransactionsByTimePeriod_WhenNoData_ThenEmptyListReturned()
        {
            var tank = await CreateTankAsync();
            var result = await levelService.GetTransactionsByTimePeriod(tank.Id, 1);
            Assert.True(result.Count == 0);
        }

        [Fact]
        public async Task GetTransactionsByTimePeriod_WhenOneTransaction_ThenRsultsCountOne()
        {
            var tank = await CreateTankAsync();
            var transaction = new LevelIndicatorTransactions()
            {
                Volume = 2,
                TransactionTime = DateTime.UtcNow,
                Density = 200,
                FuelTankId = tank.Id,
                Height = 100,
                Temperature = 20
            };
            context.LevelIndicatorTransactions.Add(transaction);
            await context.SaveChangesAsync();

            var result = await levelService.GetTransactionsByTimePeriod(tank.Id, 1);
            Assert.True(result.Count == 1);
        }

        [Fact]
        public async Task GetTransactionsByTimePeriod_WhenTwoTransactionsWithHourGap_ThenRsultsCountOne()
        {
            var tank = await CreateTankAsync();
            var transaction = new LevelIndicatorTransactions()
            {
                Volume = 2,
                TransactionTime = DateTime.UtcNow,
                Density = 200,
                FuelTankId = tank.Id,
                Height = 100,
                Temperature = 20
            };
            var transaction2 = new LevelIndicatorTransactions()
            {
                Volume = 2,
                TransactionTime = DateTime.UtcNow.AddHours(-2),
                Density = 200,
                FuelTankId = tank.Id,
                Height = 100,
                Temperature = 20
            };
            context.LevelIndicatorTransactions.Add(transaction);
            context.LevelIndicatorTransactions.Add(transaction2);
            await context.SaveChangesAsync();

            var result = await levelService.GetTransactionsByTimePeriod(tank.Id, 1);
            Assert.True(result.Count == 1);
        }

        [Fact]
        public async Task GetTransactionsByTimePeriod_WhenTwoTransactionsInOneHour_ThenRsultsCountTwo()
        {
            var tank = await CreateTankAsync();
            var transaction = new LevelIndicatorTransactions()
            {
                Volume = 2,
                TransactionTime = DateTime.UtcNow,
                Density = 200,
                FuelTankId = tank.Id,
                Height = 100,
                Temperature = 20
            };
            var transaction2 = new LevelIndicatorTransactions()
            {
                Volume = 2,
                TransactionTime = DateTime.UtcNow.AddMinutes(-30),
                Density = 200,
                FuelTankId = tank.Id,
                Height = 100,
                Temperature = 20
            };
            context.LevelIndicatorTransactions.Add(transaction);
            context.LevelIndicatorTransactions.Add(transaction2);
            await context.SaveChangesAsync();

            var result = await levelService.GetTransactionsByTimePeriod(tank.Id, 1);
            Assert.True(result.Count == 2);
        }
        #endregion

        #region Helpers
        private async Task<FuelTank> CreateTankAsync()
        {
            var tank = new FuelTank()
            {
                Capacity = 10,
                CurrentAmount = 5,
                Name = "Name",
                Number = 3,
                StationId = 1
            };
            context.FuelTanks.Add(tank);
            await context.SaveChangesAsync();
            return tank;
        }
        #endregion
    }
}
