using Microsoft.EntityFrameworkCore;
using ProductGenericCacheApp.Shared;

namespace ProductGenericCacheApp.Server.DataContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
                
        }

        public DbSet<Product> productDbSet { get; set; }

    }
}
