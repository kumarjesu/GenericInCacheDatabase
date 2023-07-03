using ProductGenericCacheApp.Shared;

namespace ProductGenericCacheApp.Server.ServiceRepos
{
    public interface IProductGenericInterface
    {
        void AddProductGeneric(IEnumerable<Product> products);
        IEnumerable<Product> GetProductsGeneric();
    }
}
