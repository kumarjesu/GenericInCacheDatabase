using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductGenericCacheApp.Server.ServiceRepos;
using ProductGenericCacheApp.Shared;

namespace ProductGenericCacheApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGenericController : ControllerBase
    {
        private readonly IProductGenericInterface _productGenericInterface;

        public ProductGenericController(IProductGenericInterface productGenericInterface)
        {
            _productGenericInterface = productGenericInterface;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productGenericInterface.GetProductsGeneric();
        }

    }
}
