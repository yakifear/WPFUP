﻿using System;
using System.Collections.Generic;

namespace WpfApp10
{
    public partial class Gender
    {
        public Gender()
        {
            Clients = new HashSet<Client>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
