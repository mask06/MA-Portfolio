﻿using MA_Portfolio.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

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
