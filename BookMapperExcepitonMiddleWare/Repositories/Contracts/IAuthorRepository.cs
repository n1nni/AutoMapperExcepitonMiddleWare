using BookMapperExcepitonMiddleWare.Models;
using BookMapperExcepitonMiddleWare.Models.DTO;

namespace BookMapperExcepitonMiddleWare.Repositories.Contracts
{
    public interface IAuthorRepository
    {
        Task<Author> AddAuthorAsync(AuthorDTO author);
        Task<IEnumerable<Author>> GetAllAuthorsAsync();
    }
}
