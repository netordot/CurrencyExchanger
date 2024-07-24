using CurrencyExchanger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace CurrencyExchanger.Configurations
{
    public class ExchangeRateConfiguration : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.HasKey(e => e.ID);

            //builder.
            //    HasMany(a => a.Currencies)
            //    .HasForeignKey();
        }
    }
}
