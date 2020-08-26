using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class Car
    {
        public int Id {get; set; }

       [Required] 
        public User Owner { get; set; }
    }
}
