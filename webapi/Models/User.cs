﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<Car> Cars { get; set; }
    }
}
