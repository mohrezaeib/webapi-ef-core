using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.Models;

namespace webapi.Core.CoreContract
{
    public interface ICarRepository
    {
         
        List<Car> GetCars();
        Car GetCarById(int id);
        Car AddCar(Car car);
        Car EditCar(Car car);

        Car DeleteCar(int id);
       // Boolean NewCar(Car car);
    
    }
}
