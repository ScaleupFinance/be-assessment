using Microsoft.AspNetCore.Mvc;
using ScaleupFinance.Assessment.Business.Services;
using ScaleupFinance.Assessment.API.Models;

namespace ScaleupFinance.Assessment.API.Controllers
{
    [ApiController]
    [Route("api/brands")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<List<BrandGetModel>> GetAllAsync()
        {
            var brands = await _brandService.GetAllAsync();
            var response = new List<BrandGetModel>();
            foreach (var brand in brands)
            {
                response.Add(new BrandGetModel
                {
                    Id = brand.Id,
                    Name = brand.Name
                });
            }

            return response;
        }
    }
}
