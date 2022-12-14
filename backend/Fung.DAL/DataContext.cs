using Fung.COMMON.Entities;
using Fung.DAL.EtitiesConfiguration;
using Fung.DAL.ModelBuilderExtensions;
using Microsoft.EntityFrameworkCore;

namespace Fung.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new StationConfiguration());
            modelBuilder.ApplyConfiguration(new RemainingTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new LevelIndicatorTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new FuelTankConfiguration());
            modelBuilder.ApplyConfiguration(new SettingsConfiguration());

            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Station> Stations { get; set; } = null!;
        public DbSet<RemainingTransactions> RemainingTransactions { get; set; } = null!;
        public DbSet<LevelIndicatorTransactions> LevelIndicatorTransactions { get; set; } = null!;
        public DbSet<FuelTank> FuelTanks { get; set; } = null!;
        public DbSet<RefreshToken> RefreshTokens { get; set; } = null!;
        public DbSet<Settings> Settings { get; set; } = null!;

    }
}
