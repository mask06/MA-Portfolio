using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.DTOs.Abstract
{
    public class BaseDTO
    {
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
