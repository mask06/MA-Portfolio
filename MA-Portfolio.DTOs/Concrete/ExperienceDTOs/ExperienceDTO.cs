using MA_Portfolio.DTOs.Abstract;

namespace MA_Portfolio.DTOs.Concrete.ExperienceDTOs
{
    public class ExperienceDTO : BaseDTO
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }//null olabilir
        public bool IsCurrentJob { get; set; } = false;
    }
}
