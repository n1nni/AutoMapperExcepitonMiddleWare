using System.ComponentModel.DataAnnotations;

namespace BookMapperExcepitonMiddleWare.Models.DTO
{
    public class AuthorDTO
    {
        [Required(ErrorMessage ="FirstName is required")]
        public string AuthorFirstName { get; set; }
        [Required(ErrorMessage ="LastName is required")]
        public string AuthorLastName { get; set; }
        [Range(1, int.MaxValue, ErrorMessage ="must be greater than 0")]
        public int BookCount { get; set; }
    }
}
