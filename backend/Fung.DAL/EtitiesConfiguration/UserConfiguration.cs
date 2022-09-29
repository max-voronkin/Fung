using Fung.COMMON.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fung.DAL.EtitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasMany(u => u.Stations)
                .WithOne()
                .HasForeignKey(s => s.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<RefreshToken>()
                .WithOne()
                .HasForeignKey(s => s.UserId);

            builder.HasOne<Settings>(s => s.Settings)
                .WithOne(s => s.User)
                .HasForeignKey<Settings>(s => s.UserId);
        }
    }
}
