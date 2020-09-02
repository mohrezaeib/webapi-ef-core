using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using webapi.CoreEntities.Models;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.DTO;


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



        [HttpGet("{id}", Name = "GetCarById")]


        public ActionResult<CarDTO> GetCarById(int id)
       
        {

            return _CarService.GetCarById(id);
             
             
        }


      
        [HttpGet()]
        public ActionResult< List<CarDTO> > GetAllCars()
        {
            return _CarService.GetCars();
        }
        
        [HttpPost()]
        public ActionResult AddCar([FromBody] CarWriteDTO newCar)
        {

            var ResponseCar = _CarService.AddCar(newCar);
            return 
                CreatedAtRoute(nameof(GetCarById), new { id = ResponseCar.Id }, ResponseCar);
           // return ResponseCar;

        }
        
        [HttpPut("{id}")]
        public ActionResult<CarDTO> EditCar([FromBody] CarWriteDTO newCar , int id )
        {


            return _CarService.EditCar(newCar , id);
        }
       
        [HttpDelete("{id}")]
        public ActionResult<CarDTO> DeleteCar(int id)
        {


            return _CarService.DeleteCar(id);
        }


    }
}
