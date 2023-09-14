using Library.Business;
using Library.Model;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private ICategoryBusiness _categoryBusiness;

        public CategoryController(ILogger<CategoryController> logger, ICategoryBusiness categoryBusiness)
        {
            _logger = logger;
            _categoryBusiness = categoryBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_categoryBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var category = _categoryBusiness.FindById(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CategoryVO category)
        {
            if (category == null) return BadRequest();
            return Ok(_categoryBusiness.Create(category));
        }

        [HttpPut]
        public IActionResult Put([FromBody] CategoryVO category)
        {
            if (category == null) return BadRequest();
            return Ok(_categoryBusiness.Update(category));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _categoryBusiness.Delete(id);
            return NoContent();
        }
    }
}
