using ScaleupFinance.Assessment.Business.Models;
using ScaleupFinance.Assessment.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScaleupFinance.Assessment.Business.Services
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllAsync();
    }

    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            var response = new List<Brand>();

            foreach (var brand in brands)
            {
                response.Add(new Brand
                {
                    Id = brand.Id,
                    Name = brand.Name
                });
            }

            return response;
        }
    }
}
