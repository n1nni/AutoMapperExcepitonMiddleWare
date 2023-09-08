using BookMapperExcepitonMiddleWare.Models.DTO;
using BookMapperExcepitonMiddleWare.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookMapperExcepitonMiddleWare.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController:Controller
    {

        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost("add-book")]
        public async Task<IActionResult> AddBook(BookDTO book)
        {
            var addedBook = await _bookRepository.AddBook(book);

            if (addedBook != null)
            {
                return Ok(addedBook);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
