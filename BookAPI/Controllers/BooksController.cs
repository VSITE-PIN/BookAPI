using BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
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
        [HttpPut("id")]
        public IActionResult UpdateBookById([FromQuery] int id,
        [FromBody] BookVM bookVM)
        {
            var updatedBook = BooksService.UpdateBookById(id, bookVM);
            return Ok(updatedBook);
        }
        [HttpDelete("id")]
        public IActionResult DeleteBook([FromQuery] int id)
        {
            BooksService.DeleteBook(id);
            return Ok();
        }


        public class BookVM
        {
            public string Title { get; set; }
            public string Description { get; set; }
            //Da li smo pročitali knjigu
            public bool IsRead { get; set; }
            //datum kada smo ju pročitali (nullable Datetime - ako ju nismo
            //pročitala datum će imati vrijednost null)
            public DateTime? DateRead { get; set; }
            //ocjena (nullable int - ako ju nismo pročitali ne možemo ju ocijeniti
            //pa će vrijednost biti null)
            public int? Rate { get; set; }
            public string Genre { get; set; }
            public string Author { get; set; }
            public string CoverPictureURL { get; set; }
        }

    }
}

    



