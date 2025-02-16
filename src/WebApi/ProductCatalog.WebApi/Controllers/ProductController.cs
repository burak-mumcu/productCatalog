using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Application.Interfaces.Repository;
using ProductCatalog.Application.Dtos;

namespace ProductCatalog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await productRepository.GetAllAsync();
            var result = list.Select(i => new ProductView()
            {
                Id = i.Id,
              Name = i.Name,
            }).ToList();

            return Ok(result);
        }
    }
}
