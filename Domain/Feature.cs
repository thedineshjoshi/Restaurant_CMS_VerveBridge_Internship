﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Feature
    {
        public Guid id { get; set; }
        public string IconUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
