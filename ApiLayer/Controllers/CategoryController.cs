using BusinessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult CategoryList()
        {
            var values = _categoryService.Getlist();
            return Ok(values);
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            _categoryService.Insert(category);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteCategory(int id)
        {
            var value = _categoryService.GetByID(id);
            _categoryService.Delete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetCategory(int id)
        {
            var value = _categoryService.GetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public ActionResult UpdateCategory(Category category)
        {
            _categoryService.Update(category);
            return Ok();
        }

    }
}
