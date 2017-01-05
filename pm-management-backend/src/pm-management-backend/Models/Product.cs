using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace pm_management_backend.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        [BsonElement("productName")]
        public string ProductName { get; set; }
        [BsonElement("productCode")]
        public string ProductCode { get; set; }
        [BsonElement("releaseDate")]
        public string ReleaseDate { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("price")]
        public double Price { get; set; }
        [BsonElement("starRating")]
        public double StarRating { get; set; }
        [BsonElement("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
