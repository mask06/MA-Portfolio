using AutoMapper;
using MA_Portfolio.DTOs.Concrete.AdminDTOs;
using MA_Portfolio.Entities.Concrete;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class AdminProfile:Profile
    {
        public AdminProfile()
        {
            CreateMap<AdminDTO, Admin>().ReverseMap();
        }
    }
}
