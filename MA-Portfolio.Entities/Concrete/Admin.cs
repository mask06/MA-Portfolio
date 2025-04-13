using MA_Portfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Entities.Concrete
{
    public class Admin : BaseEntity
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }

    }
}
