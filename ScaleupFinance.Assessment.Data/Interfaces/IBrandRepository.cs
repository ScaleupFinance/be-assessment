using ScaleupFinance.Assessment.Data.Entities;

namespace ScaleupFinance.Assessment.Data.Interfaces
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetAllAsync();
        Task<Brand> GetAsync(int id);
        Task<Brand> InsertAsync(Brand brand);
    }
}
