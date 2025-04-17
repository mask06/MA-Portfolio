using AutoMapper;
using MA_Portfolio.DTOs.Concrete.ExperienceDTOs;
using MA_Portfolio.Entities.Concrete;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()
        {
            CreateMap<ExperienceDTO, Experience>().ReverseMap();
        }
    }
}
