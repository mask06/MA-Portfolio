using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Portfolio.Entities
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }

    }
}
