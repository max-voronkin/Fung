using Fung.COMMON.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fung.DAL.EtitiesConfiguration
{
    public class StationConfiguration : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(s => s.Id);
       
            builder.HasMany(s => s.FuelTanks)
                .WithOne()
                .HasForeignKey(ft => ft.StationId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
