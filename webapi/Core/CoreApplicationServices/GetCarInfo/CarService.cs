using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using webapi.Core.CoreContract;
using webapi.Core.CoreEntities.dto.Car;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.DTO;
using webapi.CoreEntities.Models;
using webapi.InfrastructureEF;

namespace webapi.CoreApplicationServices
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _CarRepository;
        private readonly IMapper _Mapper;

        //private readonly StoreContext _context;

        public CarService(ICarRepository CarRepository, IMapper Mapper)
        {
            _CarRepository = CarRepository;
            _Mapper = Mapper;
        }

        public CarDTO AddCar(CarWriteDTO CarWDto)
        {
            Car c = _Mapper.Map<Car>(CarWDto);
            return _Mapper.Map<CarDTO>(_CarRepository.AddCar(c));
        }

        public CarDTO DeleteCar(int id)
        {
            return _Mapper.Map < CarDTO > (_CarRepository.DeleteCar(id));
        }

        public CarDTO EditCar(CarWriteDTO carWDto , int id )
        {
            Car car = _Mapper.Map<Car>(carWDto );
            car.Id = id;
            return _Mapper.Map<CarDTO>(_CarRepository.EditCar(car ));
        }

        public CarDTO GetCarById(int id)
        {
            return _Mapper.Map<CarDTO>(_CarRepository.GetCarById(id));
        }

        public List<CarDTO> GetCars()
        {

           return _Mapper.Map< List < CarDTO > >( _CarRepository.GetCars());
        }
    }


}