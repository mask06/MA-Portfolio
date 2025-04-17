using AutoMapper;
using MA_Portfolio.DTOs.LanguageDTOs;
using MA_Portfolio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<LanguageDTO, Language>().ReverseMap();
        }
    }

}