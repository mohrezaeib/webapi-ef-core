using System;
using System.Collections.Generic;
using System.Linq;
using webapi.Models;

namespace webapi.Data
{
    public class SqlStoreRepo : IStoreRepo
    {
        private readonly StoreContext _context;

        public SqlStoreRepo(StoreContext context)
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