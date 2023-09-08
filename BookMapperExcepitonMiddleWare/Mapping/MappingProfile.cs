using AutoMapper;
using BookMapperExcepitonMiddleWare.Models;
using BookMapperExcepitonMiddleWare.Models.DTO;

namespace BookMapperExcepitonMiddleWare.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDTO, Book>();
            CreateMap<AuthorDTO, Author>()
                .ForMember(dest => dest.AuthorName,
                opt => opt.MapFrom(src => src.AuthorFirstName + " " + src.AuthorLastName))
                .ReverseMap();
        }
    }
}
