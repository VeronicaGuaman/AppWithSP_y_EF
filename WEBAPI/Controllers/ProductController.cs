using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Interfaces;
using System.Collections.Generic;

namespace WEBAPI.Controllers
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

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _productRepository.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            var products = _productRepository.GetProductById(id);
            return products;
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            _productRepository.Create(product);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateProduct(int id, Product product)
        {
            _productRepository.Update(product);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteProduct(int id)
        {
            var productFound = _productRepository.GetProductById(id);
            _productRepository.Delete(productFound);
            return Ok();
        }
    }
}
