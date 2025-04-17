using AutoMapper;
using MA_Portfolio.DTOs.Concrete.AboutDTOs;
using MA_Portfolio.Entities.Concrete;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class AboutProfile :Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutDTO, About>().ReverseMap();
        }
    }
}
