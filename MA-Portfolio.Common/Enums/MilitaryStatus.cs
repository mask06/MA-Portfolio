using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Common.Enums
{
    public enum MilitaryStatus
    {
        [Display(Name = "Yapıldı")]
        Completed = 1,

        [Display(Name = "Muaf")]
        Exempted = 2,

        [Display(Name = "Tecilli")]
        Postponed = 3,

        [Display(Name = "Henüz Çağırılmadı")]
        NotApplicable = 4

    }
}