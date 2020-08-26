using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Data;

namespace webapi.Controllers
{
    [Route("")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _repository;

        

        public CommandsController(ICommandRepo repository)
        {
            _repository = repository;
        }
        // GET: api/Commands

        [HttpGet]
        public ActionResult< IEnumerable<Command>> GetCommands()
        {
            return Ok( _repository.GetCommands());
        }

        // GET: api/Commands/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Command> Get(int id)
        {
            return Ok(_repository.GetCommandById(id));
        }

        // POST: api/Commands
        [HttpPost]
        public ActionResult Post([FromBody] Command command)
        {
            _repository.NewCommand(command);
            return Ok(command);
        }

        //// PUT: api/Commands/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
