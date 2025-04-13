using MA_Portfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Entities.Concrete
{
    public class Education: BaseEntity
    {
        //public string Degree { get; set; } lisans önlisans açık öğretim enum olacak
        public string InstitutionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //null olabilir

    }
}
