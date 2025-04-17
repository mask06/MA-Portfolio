using AutoMapper;
using MA_Portfolio.DTOs.Concrete.CertificateDTOs;
using MA_Portfolio.Entities.Concrete;
namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class CertificateProfile: Profile
    {
        public CertificateProfile()
        {
            CreateMap<CertificateDTO, Certificate>().ReverseMap();
        }
    }
    
}
