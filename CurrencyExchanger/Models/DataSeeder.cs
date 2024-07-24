using CurrencyExchanger.Services;
using System.Reflection.Metadata.Ecma335;

namespace CurrencyExchanger.Models
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();

            AddCurrencies(context);
        }

        private static void AddCurrencies(ApplicationDbContext context)
        {
            var currency = context.Currencies.FirstOrDefault();
            if (currency != null)
            {
                return;
            }

            context.Currencies.Add(new Currency
            {
                CurrencyCode = "USD",
                CurrencySgin= "$", 
                FullName = "US Dollar"
            });

            context.SaveChanges();

            

        }
    }
}
