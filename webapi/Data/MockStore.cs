using System;
using System.Collections.Generic;
using webapi.Models;

namespace webapi.Data
{
    public class MockStore : IStoreRepo
    {
        public Car GetCarById(int id)
        {
            return new Car(){Id =5, Owner = new User(){Id=0 } };
        }

        public IEnumerable<Car> GetCars()
        {
            return new List<Car>(){this.GetCarById(1)};
        }

        public Car NewCar(Car car)
        {
            return GetCarById(0);
        }

        public Car NewCommand(Car car)
        {
            throw new NotImplementedException();
        }
    }


}