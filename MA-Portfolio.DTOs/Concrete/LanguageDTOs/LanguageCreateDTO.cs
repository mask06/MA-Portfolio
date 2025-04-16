using MA_Portfolio.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.DTOs.LanguageDTOs
{
    public class LanguageCreateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LanguageLevel Level { get; set; }
    }
}
