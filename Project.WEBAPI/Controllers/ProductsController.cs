using Microsoft.AspNetCore.Mvc;
using Project.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WEBAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController:Controller
    {
        private IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("getproducts")]
        public IActionResult GetProducts()
        {
            try
            {
                var products = productService.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {

                return BadRequest("Service error");
            }
        }
    }
}
