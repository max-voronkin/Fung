using Fung.COMMON.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fung.DAL.EtitiesConfiguration
{
    public class RemainingTransactionsConfiguration : IEntityTypeConfiguration<RemainingTransactions>
    {
        public void Configure(EntityTypeBuilder<RemainingTransactions> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
