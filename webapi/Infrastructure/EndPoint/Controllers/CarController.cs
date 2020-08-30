using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using webapi.CoreEntities.Models;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.DTO;
using webapi.Core.CoreEntities.dto.Car;

namespace webapi.InfrastuctureEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _CarService;
        public CarController(ICarService CarService)
        {
          _CarService = CarService;
        }


        [Route("cars/{id}")]
        [HttpGet()]
        
        public ActionResult<CarDTO> GetCarById(int id)
       
        {

            return _CarService.GetCarById(id);
             
             
        }


        [Route("cars")]
        [HttpGet()]
        public ActionResult< List<CarDTO> > GetAllCars()
        {
            return _CarService.GetCars();
        }
        [Route("cars")]
        [HttpPost()]
        public ActionResult< CarDTO> AddCar([FromBody] CarWriteDTO newCar)
        {


            return _CarService.AddCar(newCar);
        }
        [Route("cars/{id}")]
        [HttpPut()]
        public ActionResult<CarDTO> EditCar([FromBody] CarWriteDTO newCar , int id )
        {


            return _CarService.EditCar(newCar , id);
        }
        [Route("cars/{id}")]
        [HttpDelete()]
        public ActionResult<CarDTO> DeleteCar(int id)
        {


            return _CarService.DeleteCar(id);
        }


    }
}
