using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebShop.Core.ApplicationServices;
using WebShop.Core.Entities;

namespace WebShop.RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService customerService)
        {
            _productService = customerService;
        }

        // GET api/customers -- READ All
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get([FromQuery] Filter filter)
        {
            return _productService.GetFilteredList(filter);
        }

        // GET api/customers/5 -- READ By Id
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            if (id < 1)
            {
                return BadRequest("Id must be greater then 0");
            }

            return _productService.FindProductById(id);
        }

        // POST api/customers -- CREATE JSON
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            try
            {
                return Ok(_productService.CreateProduct(product));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/customers/5 -- Update
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product product)
        {
            if (id < 1 || id != product.Id)
            {
                return BadRequest("Parameter Id and product ID must be the same");
            }

            return Ok(_productService.UpdateProduct(product));
        }

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var product = _productService.DeleteProduct(id);

            return Ok($"Product with Id: {id} is Deleted");
        }
    }
}