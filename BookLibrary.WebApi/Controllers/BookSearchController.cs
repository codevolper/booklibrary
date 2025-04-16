using BookLibrary.Application.Interfaces;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookSearchController(IBookService bookService) : ControllerBase
    {
        private readonly IBookService _bookService = bookService;

        [HttpGet]
        public async Task<IActionResult> SearchBooks([FromQuery] string title, [FromQuery] string isbn)
        {
            var book = new Book
            {
                Title = title,
                ISBN = isbn
            };
            var result = await _bookService.SearchBooks(book);
            return Ok(result);
        }
    }
}
