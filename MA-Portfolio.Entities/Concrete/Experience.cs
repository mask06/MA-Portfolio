﻿using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.Entities.Concrete
{
    public class Experience : BaseEntity
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }//null olabilir
        public bool IsCurrentJob { get; set; } = false;
    }
}
