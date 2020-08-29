using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.CoreEntities.Models;
using webapi.CoreApplicationServices;

namespace webapi.InfrastuctureEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IGetCarInfo _store;
        public StoreController(IGetCarInfo store)
        {
            _store = store;
        }


        [Route("cars/{id}")]
        [HttpGet()]
        
        public ActionResult<Car> GetCarById(int id)
       
        {

            Car c = new Car();
             
             return Ok(c);
        }


        [Route("cars")]
        [HttpGet()]
        public ActionResult< List<Car> > GetAllCars()
        {
            return Ok(new List<Car>() { } );
        }
        [Route("cars")]
        [HttpPost()]
        public ActionResult< string> NewCar( Car newCar)
        {
            
            return Ok();
        }

    }
}
