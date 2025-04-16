using MA_Portfolio.Common.Enums;
using MA_Portfolio.DTOs.Abstract;

namespace MA_Portfolio.DTOs.LanguageDTOs
{
    public class LanguageDTO : BaseDTO
    {
        public string Name { get; set; }
        public LanguageLevel Level { get; set; }
    }
}
