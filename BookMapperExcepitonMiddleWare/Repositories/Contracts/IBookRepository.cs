using BookMapperExcepitonMiddleWare.Models;
using BookMapperExcepitonMiddleWare.Models.DTO;

namespace BookMapperExcepitonMiddleWare.Repositories.Contracts
{
    public interface IBookRepository
    {
        Task<Book> AddBook(BookDTO book);
    }
}
