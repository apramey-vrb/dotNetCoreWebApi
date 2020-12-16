using coreMicroservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coreMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.GetProductDetails();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productRepository.GetProductById(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("InsertProduct")]
        public void InsertProduct([FromBody] Product product)
        {
            _productRepository.InserProduct(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        [Route("UpdateProduct")]
        public void Put([FromBody] Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        [Route("DeleteProduct")]
        public void Delete(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
