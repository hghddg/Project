﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domains
{
    public class Booking : BaseDomainModel
    {
        
        public string Name { get; set; }

        public virtual Payment Payment { get; set; }
    }
}