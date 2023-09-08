using System.ComponentModel.DataAnnotations;

namespace BookMapperExcepitonMiddleWare.Models.DTO
{
    public class BookDTO
    {
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Description is require")]
        public string Description { get; set; }
        [Range(1, int.MaxValue, ErrorMessage ="Page must be greater than 0")]
        public int TotalPages { get; set; }
    }
}
