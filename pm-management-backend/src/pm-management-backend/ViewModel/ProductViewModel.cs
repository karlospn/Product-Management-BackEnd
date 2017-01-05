using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pm_management_backend.ViewModel
{
    public class ProductViewModel
    {
        public  string Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ReleaseDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double StarRating { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
