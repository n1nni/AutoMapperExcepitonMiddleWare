using BookMapperExcepitonMiddleWare.Models.JunctionTables;
using System.Text.Json.Serialization;

namespace BookMapperExcepitonMiddleWare.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalPages { get; set; }

        [JsonIgnore]
        public ICollection<AuthorBook> AuthorBooks { get; set; } //junction table
    }
}
