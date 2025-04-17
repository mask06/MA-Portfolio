using AutoMapper;
using MA_Portfolio.DTOs.Concrete.EducationDTOs;
using MA_Portfolio.Entities.Concrete;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class EducationProfile : Profile
    {
        public EducationProfile()
        {
            CreateMap<EducationDTO, Education>().ReverseMap();
        }
    }
}
