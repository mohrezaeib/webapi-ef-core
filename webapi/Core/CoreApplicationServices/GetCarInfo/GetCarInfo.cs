using System;
using System.Collections.Generic;
using System.Linq;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.Models;
using webapi.InfrastructureEF;

namespace webapi.CoreApplicationServices
{
    public class GetCarInfo : IGetCarInfo
    {
        private readonly StoreContext _context;

        public GetCarInfo(StoreContext context)
        {
            _context = context;
        }
        public Car GetCarById(int id)
        {
            return _context.Cars.SingleOrDefault(p => p.Id == id );
        }

        public List<Car> GetCars()
        {
            return _context.Cars.ToList();
        }

        public Boolean  NewCar(Car car)
        {
            return false;
        }


    }


}