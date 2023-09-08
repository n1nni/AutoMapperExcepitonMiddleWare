using BookMapperExcepitonMiddleWare.Models;
using BookMapperExcepitonMiddleWare.Models.DTO;
using BookMapperExcepitonMiddleWare.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace BookMapperExcepitonMiddleWare.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpPost("add-author")]
        public async Task<IActionResult> AddAuthor(AuthorDTO author)
        {
            var addedAuthor = await _authorRepository.AddAuthorAsync(author);

            if (addedAuthor != null)
            {
                return Ok(addedAuthor);
            }
            else
                return BadRequest();

        }

        [HttpGet("get-all-authors")]
        public async Task<IActionResult> GetAuthorsAsync()
        {
            var authors = await _authorRepository.GetAllAuthorsAsync();
            return Ok(authors);

        }
    }
}
