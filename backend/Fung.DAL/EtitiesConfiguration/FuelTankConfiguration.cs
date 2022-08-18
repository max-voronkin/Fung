using Fung.COMMON.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fung.DAL.EtitiesConfiguration
{
    public class FuelTankConfiguration : IEntityTypeConfiguration<FuelTank>
    {
        public void Configure(EntityTypeBuilder<FuelTank> builder)
        {
            builder.HasMany<LevelIndicatorTransactions>()
                .WithOne();

            builder.HasMany<RemainingTransactions>()
                .WithOne();
        }
    }
}
