using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.DTO;

namespace webapi.CoreEntities.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarDto> Cars { get; set; }
    }
}
