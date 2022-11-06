using Microsoft.EntityFrameworkCore;
using ProductsApiExtended.DbContexts;
using ProductsApiExtended.Models;

namespace ProductsApiExtended.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _productContext;
        public ProductRepository(ProductContext context)
        {
            _productContext = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }
    }
}
