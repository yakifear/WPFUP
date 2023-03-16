﻿using System;
using System.Collections.Generic;

namespace WpfApp10
{
    public partial class Service
    {
        public Service()
        {
            ClientServices = new HashSet<ClientService>();
            ServicePhotos = new HashSet<ServicePhoto>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Cost { get; set; }
        public double Discount { get; set; }
        public string? Description { get; set; }
        public byte[]? MainImage { get; set; }

        public virtual ICollection<ClientService> ClientServices { get; set; }
        public virtual ICollection<ServicePhoto> ServicePhotos { get; set; }
    }
}
