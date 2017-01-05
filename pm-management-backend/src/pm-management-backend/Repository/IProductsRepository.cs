using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pm_management_backend.Models;

namespace pm_management_backend.Repository
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        void AddProduct(Product productEntity);
    }
}
