using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.CoreEntities.DTO
{
    public class CarDTO
    {
        public int Id {get; set; }
        public string Name { get; set; }    
        public string Model { get; set; }
      
        //public UserDTO Owner { get; set; }
        public int OwnerID { get; set; }
    }

    public class CarWriteDTO
    {
        public string Name { get; set; }
        public string Model { get; set; }

        //public UserDTO Owner { get; set; }
        public int OwnerID { get; set; }
    }
}
