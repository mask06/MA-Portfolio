using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Common.Enums
{
    public enum EducationDegree
    {
        none = 0,
        [Display(Name = "Lise")]
        HighSchool = 1,
        [Display(Name = "Önlisans")]
        Associate = 2,
        [Display(Name = "Lisans")]
        Bachelor = 3,
        [Display(Name = "Yüksek Lisans")]
        Master = 4,
        [Display(Name = "Doktora")]
        Doctorate = 5,
        [Display(Name = "Sertifika")]
        Certificate = 6,
        [Display(Name = "Diğer")]
        Other = 7
    }
}
