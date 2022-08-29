using ScaleupFinance.Assessment.Business.Models;

namespace ScaleupFinance.Assessment.Business.Interfaces
{
    public interface IBrandService
    {
        Task<List<BrandDto>> GetAllAsync();
    }
}
