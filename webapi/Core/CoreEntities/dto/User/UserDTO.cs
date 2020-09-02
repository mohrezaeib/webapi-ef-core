using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.DTO;

namespace webapi.CoreEntities.DTO
{
    public class UserReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<CarDTO> Cars { get; set; }
    }

    public class UserReadDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarDTO> Cars { get; set; }
    }

    public class UserWriteDTO
    {

        public string Name { get; set; }
        //public List<CarDTO> Cars { get; set; }
    }
    public class UserWriteDetailDTO
    {

        public string Name { get; set; }
        //public List<CarDTO> Cars { get; set; }
    }
}
