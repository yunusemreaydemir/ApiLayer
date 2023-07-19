using BusinessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.Getlist();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult ProdyctList(Product product)
        {
            _productService.Insert(product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value = _productService.GetByID(id);
            _productService.Delete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.GetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.Update(product);
            return Ok();
        }
    }
}
