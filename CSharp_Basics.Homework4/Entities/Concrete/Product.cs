﻿using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product: IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
