using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using pm_management_backend.Models;

namespace pm_management_backend.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsContext _productsContext;

        public ProductsRepository(IConfigurationRoot config)
        {
            _productsContext = new ProductsContext(config);
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _productsContext.Notes.Find(_ => true).ToListAsync();
            return products;
        }
    }
}
