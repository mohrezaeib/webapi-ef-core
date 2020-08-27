using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using  webapi.Data;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepo _store;
        public StoreController(IStoreRepo store)
        {
            _store = store;
        }


        [Route("cars/{id}")]
        [HttpGet()]
        
        public ActionResult<Car> GetCarById(int id)
       
        {
             
             Car c = _store.GetCarById(id);
             
             return Ok(c);
        }


        [Route("cars")]
        [HttpGet()]
        public ActionResult< List<Car> > GetAllCars()
        {
            return Ok( _store.GetCars());
        }
        [Route("cars")]
        [HttpPost()]
        public ActionResult< string> NewCar( Car newCar)
        {
            _store.N
            return Ok();
        }

    }
}
