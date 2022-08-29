using Microsoft.AspNetCore.Mvc;
using ScaleupFinance.Assessment.Business.Interfaces;
using ScaleupFinance.Assessment.Business.Models;

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
        public async Task<List<BrandDto>> GetAllAsync()
        {
            return await _brandService.GetAllAsync();
        }
    }
}
