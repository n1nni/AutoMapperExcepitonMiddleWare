using BookMapperExcepitonMiddleWare.Models.JunctionTables;

namespace BookMapperExcepitonMiddleWare.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }

        public ICollection<AuthorBook> AuthorBooks { get; set; } // junction table

    }
}
