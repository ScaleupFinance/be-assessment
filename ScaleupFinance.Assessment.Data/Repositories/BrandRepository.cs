using Microsoft.EntityFrameworkCore;
using ScaleupFinance.Assessment.Data.Models;

namespace ScaleupFinance.Assessment.Data.Repositories
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetAllAsync();
        Task<Brand> GetAsync(int id);
        Task<Brand> InsertAsync(Brand brand);
    }

    public class BrandRepository : IBrandRepository
    {
        private readonly ProductDbContext _context;

        public BrandRepository(ProductDbContext context)
        {
            _context = context;
        }

        public Task<List<Brand>> GetAllAsync()
        {
            return _context.Brands.ToListAsync();
        }

        public Task<Brand> GetAsync(int id)
        {
            return _context.Brands.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Brand> InsertAsync(Brand brand)
        {
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();

            return brand;
        }
    }
}
