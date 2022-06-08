using Microsoft.EntityFrameworkCore;
using ScaleupFinance.Assessment.Data.Models;

namespace ScaleupFinance.Assessment.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }
    }
}
