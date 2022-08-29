using Microsoft.EntityFrameworkCore;
using ScaleupFinance.Assessment.Data.Entities;

namespace ScaleupFinance.Assessment.Data
{
    public class RetailDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public RetailDbContext(DbContextOptions<RetailDbContext> options)
            : base(options)
        {

        }
    }
}
