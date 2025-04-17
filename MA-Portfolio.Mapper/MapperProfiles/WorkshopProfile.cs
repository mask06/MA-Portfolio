using AutoMapper;
using MA_Portfolio.DTOs.Concrete.WorkshopDTOs;
using MA_Portfolio.Entities.Concrete;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class WorkshopProfile : Profile
    {
        public WorkshopProfile()
        {
            CreateMap<WorkshopDTO, Workshop>().ReverseMap();
        }
    }
}
