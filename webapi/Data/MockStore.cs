using System;
using System.Collections.Generic;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.Models;

namespace webapi.Data
{
    public class MockStore : IGetCarInfo
    {
        public Car GetCarById(int id)
        {
            return new Car() { Id = 5, Owner = new User() { Id = 0 } };
        }

        public List<Car> GetCars()
        {
            return new List<Car>() { this.GetCarById(1) };
        }

        public Car NewCar(Car car)
        {
            return GetCarById(0);
        }

    
    }


}