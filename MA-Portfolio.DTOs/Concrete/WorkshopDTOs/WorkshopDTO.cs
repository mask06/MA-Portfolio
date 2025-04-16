using MA_Portfolio.DTOs.Abstract;

namespace MA_Portfolio.DTOs.Concrete.WorkshopDTOs
{
    public class WorkshopDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
