using BookAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Services;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksService _booksService;

        public BooksController(BooksService booksService) => _booksService = booksService;

        [HttpPost]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllBooks() => Ok(_booksService.GetAllBooks());

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id) => Ok(_booksService.GetBookById(id));

        [HttpPut("{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] BookVM bookVM) =>
            Ok(_booksService.UpdateBookById(id, bookVM));

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            _booksService.DeleteBook(id);
            return Ok();
        }
    }
}
