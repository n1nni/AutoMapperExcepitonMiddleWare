using AutoMapper;
using BookMapperExcepitonMiddleWare.Data;
using BookMapperExcepitonMiddleWare.Models;
using BookMapperExcepitonMiddleWare.Models.DTO;
using BookMapperExcepitonMiddleWare.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BookMapperExcepitonMiddleWare.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AuthorRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Author> AddAuthorAsync(AuthorDTO author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            try
            {
                _context.Authors.Add(authorEntity);
                await _context.SaveChangesAsync();
                return authorEntity;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            var authors = await _context.Authors.ToListAsync();
            return authors;
        }
    }
}
