﻿using DbPoc.Domain.Enums;
using System.Collections.Generic;

namespace DbPoc.Domain.Entities
{
    public class Product : BasicEntity
    {
        public Product()
        {
            CompositeProducts = new List<Recipe>();
            ComponentProducts = new List<Recipe>();
            Children = new List<Product>();
        }

        public string Name { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Vat { get; set; }
        public UnitEnum Unit { get; set; }
        public virtual ICollection<Recipe> CompositeProducts { get;  set; }
        public ICollection<Recipe> ComponentProducts { get;  set; }
        public int? ParentId { get; set; }
        public virtual Product Parent { get; set; }
        public ICollection<Product> Children { get;  set; }

    }
}
