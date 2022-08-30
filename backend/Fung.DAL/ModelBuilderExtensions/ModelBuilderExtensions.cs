using Bogus;
using Fung.COMMON.Entities;
using Fung.COMMON.Security;
using Microsoft.EntityFrameworkCore;

namespace Fung.DAL.ModelBuilderExtensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var users = GenerateUsers();
            var stations = GenereteStations(users);
            var fuelTanks = GenereteFuelTanks(stations.First());
            var remaingTransactions = GenereteRemainings(fuelTanks);
            var levelTransactions = GenereteLevelindicator(fuelTanks);

            builder.Entity<User>().HasData(users);
            builder.Entity<Station>().HasData(stations);
            builder.Entity<FuelTank>().HasData(fuelTanks);
            builder.Entity<RemainingTransactions>().HasData(remaingTransactions);
            builder.Entity<LevelIndicatorTransactions>().HasData(levelTransactions);
        }

        private static ICollection<User> GenerateUsers()
        {
            int Id = 1;
            var usersFaker = new Faker<User>()
                .RuleFor(u => u.Id, f => Id)
                .RuleFor(u => u.Email, f => $"{Id++}@gmail.com")
                .RuleFor(u => u.IsEmailConfirmed, f => false)
                .RuleFor(u => u.CreatedAt, f => DateTime.UtcNow)
                .RuleFor(u => u.Salt, f => Convert.ToBase64String(SecurityHelper.GetRandomBytes()))
                .RuleFor(u => u.Password, (f, u) => SecurityHelper.HashPassword("11111111", Convert.FromBase64String(u.Salt)));

            return usersFaker.Generate(3);
        }

        private static ICollection<Station> GenereteStations(ICollection<User> users)
        {
            int Id = 1;
            var stationsFaker = new Faker<Station>()
                .RuleFor(s => s.Id, f => Id++)
                .RuleFor(s => s.Name, f => f.Person.Address.City)
                .RuleFor(s => s.UserId, users.First().Id);

            return stationsFaker.Generate(3);
        }

        private static ICollection<FuelTank> GenereteFuelTanks(Station station)
        {
            int Id = 1;
            var fuelTankFaker = new Faker<FuelTank>()
                .RuleFor(t => t.Id, f => Id)
                .RuleFor(t => t.Name, f => f.Lorem.Word())
                .RuleFor(t => t.Number, f => Id++)
                .RuleFor(t => t.Capacity, f => 10d)
                .RuleFor(t => t.CurrentAmount, f => 3.5d + Id)
                .RuleFor(t => t.StationId, f => station.Id)
                .RuleFor(t => t.UpdatedAt, f => DateTime.UtcNow);
            return fuelTankFaker.Generate(3);
        }

        private static ICollection<RemainingTransactions> GenereteRemainings(ICollection<FuelTank> tanks)
        {
            int Id = 1;
            List<RemainingTransactions> transactions = new List<RemainingTransactions>();
            foreach (var item in tanks)
            {          
                var remainingTransactionsFaker = new Faker<RemainingTransactions>()
                    .RuleFor(t => t.Id, f => Id++)
                    .RuleFor(t => t.Value, f => 10d - (Id * 0.1))
                    .RuleFor(t => t.TransactionTime, f => DateTime.UtcNow)
                    .RuleFor(t => t.FuelTankId, f => item.Id);

                var s = remainingTransactionsFaker.Generate(3);
                transactions.AddRange(s);
            }
            return transactions;
        }

        private static ICollection<LevelIndicatorTransactions> GenereteLevelindicator(ICollection<FuelTank> tanks)
        {
            int Id = 1;
            List<LevelIndicatorTransactions> transactions = new List<LevelIndicatorTransactions>();
            foreach (var item in tanks)
            {
                var levelTransactionsFaker = new Faker<LevelIndicatorTransactions>()
                    .RuleFor(t => t.Id, f => Id++)
                    .RuleFor(t => t.Height, f => 10d - (Id * 0.1))
                    .RuleFor(t => t.Temperature, f => f.Random.Number(40))
                    .RuleFor(t => t.Volume, f => f.Random.Double(0, 10))
                    .RuleFor(t => t.Density, f => f.Random.Double(0, 1000))
                    .RuleFor(t => t.TransactionTime, f => DateTime.UtcNow)
                    .RuleFor(t => t.FuelTankId, f => item.Id);
                transactions.AddRange(levelTransactionsFaker.Generate(3));
            }
            return transactions;
        }


    }
}
