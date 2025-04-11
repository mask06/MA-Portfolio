using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; } // A1, A2, B1, B2, C1, C2
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //null olabilir
    }
}
