using System;
using System.Collections.Generic;
using webapi.Models;
namespace webapi.Data
{
    public interface ICommandRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        Command NewCommand(Command command);
    }
}