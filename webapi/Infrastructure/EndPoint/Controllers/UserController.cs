using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using webapi.CoreEntities.Models;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.DTO;


namespace webapi.InfrastuctureEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;
        public UserController(IUserService UserService)
        {
         _UserService = UserService;
        }


        [Route("Users/{id}")]
        [HttpGet()]
        
        public ActionResult<UserReadDetailDTO> GetUserById(int id)
       
        {

          return _UserService.GetUserDetailById(id);
             
             
        }


        //[Route("Users")]
        //[HttpGet()]
        //public ActionResult< List<UserDTO> > GetAllUsers()
        //{
        //    return _UserService.GetUsers();
        //}
        //[Route("Users")]
        //[HttpPost()]
        //public ActionResult< UserDTO> AddUser([FromBody] UserWriteDTO newUser)
        //{


        //    return _UserService.AddUser(newUser);
        //}
        //[Route("Users/{id}")]
        //[HttpPut()]
        //public ActionResult<UserDTO> EditUser([FromBody] UserWriteDTO newUser , int id )
        //{


        //    return _UserService.EditUser(newUser , id);
        //}
        //[Route("Users/{id}")]
        //[HttpDelete()]
        //public ActionResult<UserDTO> DeleteUser(int id)
        //{


        //    return _UserService.DeleteUser(id);
        //}


    }
}
