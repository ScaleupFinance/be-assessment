using ScaleupFinance.Assessment.Business.Interfaces;
using ScaleupFinance.Assessment.Business.Models;
using ScaleupFinance.Assessment.Data.Interfaces;

namespace ScaleupFinance.Assessment.Business.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<BrandDto>> GetAllAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            var response = new List<BrandDto>();

            foreach (var brand in brands)
            {
                response.Add(new BrandDto
                {
                    Id = brand.Id,
                    Name = brand.Name
                });
            }

            return response;
        }
    }
}
