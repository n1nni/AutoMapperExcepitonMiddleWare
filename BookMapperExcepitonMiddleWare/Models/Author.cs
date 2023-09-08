using BookMapperExcepitonMiddleWare.Models.JunctionTables;
using System.Text.Json.Serialization;

namespace BookMapperExcepitonMiddleWare.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }

        [JsonIgnore]
        public ICollection<AuthorBook> AuthorBooks { get; set; } // junction table

    }
}
