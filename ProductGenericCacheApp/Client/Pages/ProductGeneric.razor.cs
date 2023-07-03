using ProductGenericCacheApp.Shared;
using System.Net.Http.Json;

namespace ProductGenericCacheApp.Client.Pages
{
    public partial class ProductGeneric
    {
        public IEnumerable<Product> products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetProductList();
        }

        private async Task GetProductList()
        {
            products = await Http.GetFromJsonAsync<IEnumerable<Product>>("api/ProductGeneric");
        }
    }
}
