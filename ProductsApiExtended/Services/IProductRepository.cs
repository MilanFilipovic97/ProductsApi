using ProductsApiExtended.Dtos;
using ProductsApiExtended.Models;

namespace ProductsApiExtended.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
