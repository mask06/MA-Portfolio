using AutoMapper;
using MA_Portfolio.DTOs.Concrete.InformationDTOs;
using MA_Portfolio.Entities.Concrete;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class InformationProfile : Profile
    {
        public InformationProfile()
        {
            CreateMap<Information, InformationDTO>().ReverseMap();
        }
    }
}
