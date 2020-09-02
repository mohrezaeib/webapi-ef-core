using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.DTO;
using webapi.CoreEntities.Models;

namespace webapi.Core.CoreEntities.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarDTO, Car>();
            CreateMap<Car, CarDTO>();
            CreateMap<CarWriteDTO, Car>();
            CreateMap< Car, CarWriteDTO > ();
        }
    }
}
