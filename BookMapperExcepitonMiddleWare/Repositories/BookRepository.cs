using AutoMapper;
using BookMapperExcepitonMiddleWare.Data;
using BookMapperExcepitonMiddleWare.Models;
using BookMapperExcepitonMiddleWare.Models.DTO;
using BookMapperExcepitonMiddleWare.Repositories.Contracts;

namespace BookMapperExcepitonMiddleWare.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Book> AddBook(BookDTO book)
        {
            var bookEntity = _mapper.Map<Book>(book);

            try
            {
                _context.Books.Add(bookEntity);
                await _context.SaveChangesAsync();

                return bookEntity;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
