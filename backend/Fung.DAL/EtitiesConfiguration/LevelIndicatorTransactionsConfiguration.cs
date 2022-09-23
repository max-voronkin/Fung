using Fung.COMMON.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fung.DAL.EtitiesConfiguration
{
    public class LevelIndicatorTransactionsConfiguration : IEntityTypeConfiguration<LevelIndicatorTransactions>
    {
        public void Configure(EntityTypeBuilder<LevelIndicatorTransactions> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
