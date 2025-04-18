﻿using MA_Portfolio.Common.Enums;
using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.Entities.Concrete
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public LanguageLevel Level { get; set; }
    }
}
