using System;
using System.Collections.Generic;
using webapi.Models;
namespace webapi.Data
{
    public interface IStoreRepo
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int id);
        Car NewCar(Car car);
    }
}