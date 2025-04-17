using AutoMapper;
using MA_Portfolio.DTOs.Concrete.SkillDTOs;
using MA_Portfolio.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Mapper.MapperProfiles
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<SkillDTO, Skill>().ReverseMap();
        }
    }

}
