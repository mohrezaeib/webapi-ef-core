using System;
using System.Collections.Generic;
using webapi.Models;
namespace webapi.Data
{
    public interface IStoreRepo
    {
        List<Car> GetCars();
        Car GetCarById(int id);
        Boolean NewCar(Car car);
    }
}