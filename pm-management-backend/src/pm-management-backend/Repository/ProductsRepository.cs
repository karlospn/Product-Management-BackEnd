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
            var products = await _productsContext.Products.Find(_ => true).ToListAsync();
            return products;
        }

        public async Task<Product> GetOneProduct(string id)
        {
            var filter = Builders<Product>.Filter.Eq("Id", id);
            return await _productsContext.Products.Find(filter).FirstOrDefaultAsync();
        }

        public async void AddProduct(Product productEntity)
        {
            await _productsContext.Products.InsertOneAsync(productEntity);
        }

        public async void DeleteProduct(int id)
        {
            await _productsContext.Products.DeleteOneAsync(
                        Builders<Product>.Filter.Eq("Id", id));
        }
    }
}
