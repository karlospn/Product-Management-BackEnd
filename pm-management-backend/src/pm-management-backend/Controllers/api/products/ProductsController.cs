using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pm_management_backend.Repository;
using pm_management_backend.ViewModel;

namespace pm_management_backend.Controllers.api.products
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
   
        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var productsEntity =  await _productsRepository.GetAllProducts();
                if (productsEntity.Any())
                {
                    var productsViewModel = AutoMapper.Mapper.Map<IEnumerable<ProductViewModel>>(productsEntity);
                    return Ok(productsViewModel);
                }
                return NotFound("No values found on the BBDD");
            }
            catch (Exception ex)
            {
                return BadRequest("Error Retrieving Trip");
            }
        }


        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] ProductViewModel ViewModel)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Bad Request");
            }
        }


    }
}