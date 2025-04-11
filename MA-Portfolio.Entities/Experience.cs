using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }//null olabilir
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public bool IsCurrentJob { get; set; } = false;
    }
}
