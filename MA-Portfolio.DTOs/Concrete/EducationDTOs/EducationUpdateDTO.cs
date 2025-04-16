using MA_Portfolio.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.DTOs.Concrete.EducationDTOs
{
    public class EducationUpdateDTO
    {
        public int Id { get; set; }
        public EducationDegree Degree { get; set; }
        public string InstitutionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //null olabilir
    }
}
