using Microsoft.AspNetCore.Identity;
using CurrencyExchanger.Models;
using Microsoft.EntityFrameworkCore;

namespace CurrencyExchanger.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }

    }
}
