﻿using MA_Portfolio.Entities.Abstract;

namespace MA_Portfolio.Entities.Concrete
{
    public class Workshop : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
