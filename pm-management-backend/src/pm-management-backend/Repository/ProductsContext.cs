using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using pm_management_backend.Models;

namespace pm_management_backend.Repository
{
    public class ProductsContext
    {
        private readonly IMongoDatabase _database;
        private readonly string collectionName;

        public ProductsContext(IConfigurationRoot config)
        {

            var client = new MongoClient(config["ConnectionStrings:DatabaseConnectionString"]);
            if (client != null)
            {
                _database = client.GetDatabase(config["ConnectionStrings:DatabaseName"]);
                collectionName = config["ConnectionStrings:CollectionName"];
            }        
        }

        public IMongoCollection<Product> Products
        {
            get
            {
                return _database.GetCollection<Product>(collectionName);
            }
        }
    }
}
