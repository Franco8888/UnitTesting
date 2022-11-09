using DBAccess.Services;
using Ecommerce_server.Models;
using Microsoft.AspNetCore.Mvc;

namespace xxfdsfd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
        // CTOR
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "getProduct")]
        public async Task<Product> GetProduct()
        {
            var result = await _productService.GetProduct("4");

            return result;
        }
    }
}
