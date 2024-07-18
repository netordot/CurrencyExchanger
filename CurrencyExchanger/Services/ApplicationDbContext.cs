using Microsoft.EntityFrameworkCore;

namespace CurrencyExchanger.Services
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
