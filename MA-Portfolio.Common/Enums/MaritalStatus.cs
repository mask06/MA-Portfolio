using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Common.Enums
{
    public enum MaritalStatus
    {
        [Display(Name = "Bekar")]
        Single = 1,

        [Display(Name = "Evli")]
        Married = 2,

        [Display(Name = "Boşanmış")]
        Divorced = 3,
    }
}
