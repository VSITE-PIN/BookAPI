using BookAPI.Services;
using BookAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService BooksService { get; set; }
        public BooksController(BooksService booksService)
        {
            BooksService = booksService;
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            BooksService.AddBook(book);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var allBooks = BooksService.GetAllBooks();
            return Ok(allBooks);
        }
        [HttpGet("id")]
        public IActionResult GetBookById([FromQuery] int id)
        {
            var book = BooksService.GetBookById(id);
            return Ok(book);
        }

    }
}
