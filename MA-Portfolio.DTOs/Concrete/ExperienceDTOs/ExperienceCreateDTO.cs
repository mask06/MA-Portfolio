using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.DTOs.Concrete.ExperienceDTOs
{
    public class ExperienceCreateDTO
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }//null olabilir
        public bool IsCurrentJob { get; set; } = false;
    }
}
