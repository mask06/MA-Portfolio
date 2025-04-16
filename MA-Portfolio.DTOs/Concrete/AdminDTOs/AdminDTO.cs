using MA_Portfolio.DTOs.Abstract;
using System.ComponentModel.DataAnnotations;

namespace MA_Portfolio.DTOs.Concrete.AdminDTOs
{
    public class AdminDTO : BaseDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
    }
}
