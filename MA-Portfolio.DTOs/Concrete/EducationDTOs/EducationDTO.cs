using MA_Portfolio.Common.Enums;
using MA_Portfolio.DTOs.Abstract;

namespace MA_Portfolio.DTOs.Concrete.EducationDTOs
{
    public class EducationDTO : BaseDTO
    {
        public EducationDegree Degree { get; set; }
        public string InstitutionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //null olabilir
    }
}
