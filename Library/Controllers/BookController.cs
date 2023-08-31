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
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService BookService)
        {
            _logger = logger;
            _bookService = BookService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_bookService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var Book = _bookService.FindById(id);
            if (Book == null) return NotFound();
            return Ok(Book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookService.Create(book));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookService.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
