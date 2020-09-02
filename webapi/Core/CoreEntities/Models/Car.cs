using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.CoreEntities.Models
{
    public class Car
    {
        public int Id {get; set; }
        public string Name { get; set; }    
        public string Model { get; set; }
      
        public virtual User Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
