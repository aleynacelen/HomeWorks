using AleynaDailyData.Abstract;
using AleynaDailyEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AleynaDailyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {   private readonly IGenericRepository<Product> _productRepository;
        public ProductController(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            var newProduct = await _productRepository.AddAsync(product);
            return Ok(newProduct);
        }
    }
}
