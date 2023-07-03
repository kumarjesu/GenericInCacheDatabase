using Microsoft.Extensions.Caching.Memory;
using ProductGenericCacheApp.Server.DataContext;
using ProductGenericCacheApp.Shared;
using System.Collections;
using System.Collections.Generic;

namespace ProductGenericCacheApp.Server.ServiceRepos
{
    public class ProductGenericServiceRepo : IProductGenericInterface
    {
        private const string KEY = "JazJer";
        private readonly IMemoryCache _memoryCache;
        private readonly ProductDbContext _productDbContext;
        public ProductGenericServiceRepo(IMemoryCache memoryCache, ProductDbContext productDbContext)
        {
            _memoryCache = memoryCache;
            _productDbContext = productDbContext;
        }

        public void AddProductGeneric(IEnumerable<Product> products)
        {
            var option = new MemoryCacheEntryOptions
                {
                    SlidingExpiration= TimeSpan.FromSeconds(30),
                    AbsoluteExpirationRelativeToNow= TimeSpan.FromSeconds(60)
                };
            _memoryCache.Set(KEY, products,option);
        }

        public IEnumerable<Product> GetProductsGeneric()
        {
            IEnumerable<Product> products;

            if(!_memoryCache.TryGetValue(KEY, out products))
            {
                products = _productDbContext.productDbSet.ToList();
            };
            AddProductGeneric(products);
            Thread.Sleep(30);
            return products;
        }
    }
}
