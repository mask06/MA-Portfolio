﻿using MA_Portfolio.Common.Enums;
using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.Entities.Concrete
{
    public class Education: BaseEntity
    {
        public EducationDegree Degree { get; set; }
        public string InstitutionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //null olabilir

    }
}
