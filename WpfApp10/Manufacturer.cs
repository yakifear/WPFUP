﻿using System;
using System.Collections.Generic;

namespace WpfApp10
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly? StartDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
