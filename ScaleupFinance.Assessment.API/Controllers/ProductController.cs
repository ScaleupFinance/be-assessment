using Microsoft.AspNetCore.Mvc;

namespace ScaleupFinance.Assessment.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        //TODO : Design and implement a POST API to create products
        // API should accept name, price and brand fields to create products
        // API should return the created product

        //Create a test project in the application and write a unit test for business layer implementation
    }
}