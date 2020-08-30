using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Core.CoreContract;
using webapi.CoreEntities.Models;
using webapi.InfrastructureEF;

namespace webapi.Infrastructure.EF.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly StoreContext _Context;

        public CarRepository(StoreContext storeContext)
        {
            _Context = storeContext;
        }

        public Car AddCar(Car car)
        {
            _Context.Cars.Add(car );
            _Context.SaveChanges();
            return car;
        }

        public Car DeleteCar(int id)
        {
             Car car = _Context.Cars.First(c => c.Id == id);
            _Context.Cars.Remove(car);
            _Context.SaveChanges();
            return car;
        }

        public Car EditCar(Car car)
        {
            try
            {
                _Context.Cars.Update(car);
             
            
            }
            catch (DbUpdateException  e)
            {
                Console.WriteLine(e.Message);
            }
            _Context.SaveChanges();
            return _Context.Cars.First(p => p.Id == car.Id);
        }

        public Car GetCarById(int id)
        {
            return _Context.Cars.Single(car => car.Id == id);
        }

        public List<Car> GetCars()
        {
            
            return _Context.Cars.ToList();

        }

 
    }
}
