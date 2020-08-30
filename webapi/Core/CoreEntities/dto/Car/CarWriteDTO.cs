using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Core.CoreEntities.dto.Car
{
    public class CarWriteDTO
    {
        public string Name { get; set; }
        public string Model { get; set; }

        //public UserDTO Owner { get; set; }
        public int OwnerID { get; set; }
    }
}
