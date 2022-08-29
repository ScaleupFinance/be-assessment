using Microsoft.EntityFrameworkCore;
using ScaleupFinance.Assessment.Data.Entities;
using ScaleupFinance.Assessment.Data.Interfaces;

namespace ScaleupFinance.Assessment.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly RetailDbContext _context;

        public BrandRepository(RetailDbContext context)
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
