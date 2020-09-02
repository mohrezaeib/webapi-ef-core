using System;
using System.Collections.Generic;
using webapi.CoreEntities.DTO;
using webapi.CoreEntities.Models;
namespace webapi.CoreApplicationServices
{
    public interface ICarService
    {
        List<CarDTO> GetCars();
        CarDTO GetCarById(int Id);

        CarDTO AddCar(CarWriteDTO Car);
        CarDTO DeleteCar(int Id);

        CarDTO EditCar(CarWriteDTO Car, int id );
        

    }
}