using BookManager.Application.InputModels;
using BookManager.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            var books = _bookService.GetAll(query);

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var books = _bookService.GetById(id);

            if(books == null) return NotFound();

            return Ok(books);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateRegisterBookInputModel modelInput)
        {

            if (string.IsNullOrEmpty(modelInput.Title)) return BadRequest();

            var id = _bookService.Create(modelInput);

            return CreatedAtAction(nameof(GetById), new { id }, modelInput);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateBookInputModel updateRegisterBook) 
        {
            if(string.IsNullOrEmpty(updateRegisterBook.Title)) return BadRequest();

            _bookService.Update(updateRegisterBook);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            _bookService.Delete(id);

            return NoContent();
        }
    }
}
