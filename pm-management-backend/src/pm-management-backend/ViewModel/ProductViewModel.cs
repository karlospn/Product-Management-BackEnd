using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pm_management_backend.ViewModel
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ReleaseDate { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double StarRating { get; set; }
        public string ImageUrl { get; set; }
    }
}
