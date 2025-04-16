using MA_Portfolio.Common.Enums;

namespace MA_Portfolio.DTOs.Concrete.EducationDTOs
{
    public class EducationCreateDTO
    {
        public int Id { get; set; }
        public EducationDegree Degree { get; set; }
        public string InstitutionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //null olabilir
    }
}
