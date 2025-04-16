using System.ComponentModel.DataAnnotations;

namespace MA_Portfolio.DTOs.Concrete.AdminDTOs
{
    public class AdminUpdateDTO
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
    }
}
