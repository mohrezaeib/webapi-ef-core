using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.Models;

namespace webapi.Core.CoreContract
{
    interface ICarRepository
    {
         
        List<Car> GetCars();
        Car GetCarById(int id);
        Boolean NewCar(Car car);
    
    }
}
