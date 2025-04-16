using MA_Portfolio.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.DTOs.Concrete.InformationDTOs
{
    public class InformationUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime PostponedDate { get; set; }
        public MilitaryStatus MilitaryStatus { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string DrivingLicense { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }
        public string MediumUrl { get; set; }
    }
}
