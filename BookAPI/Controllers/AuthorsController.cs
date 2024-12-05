using BookAPI.Services;
using BookAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        public AuthorsService AuthorsService { get; set; }
        public AuthorsController(AuthorsService authorsService)
        {
            AuthorsService = authorsService;
        }
        [HttpPost]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            AuthorsService.AddAuthor(author);
            return Ok();
        }

    }
}
