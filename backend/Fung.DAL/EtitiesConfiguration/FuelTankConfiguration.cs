using Fung.COMMON.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fung.DAL.EtitiesConfiguration
{
    public class FuelTankConfiguration : IEntityTypeConfiguration<FuelTank>
    {
        public void Configure(EntityTypeBuilder<FuelTank> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasMany(f => f.LavelTransactions)
                .WithOne()
                .HasForeignKey(li => li.FuelTankId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.RemainingTransactions)
                .WithOne()
                .HasForeignKey(rt => rt.FuelTankId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
