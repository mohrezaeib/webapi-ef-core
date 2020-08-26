
using System;
using System.Collections.Generic;
using webapi.Models;

namespace webapi.Data
{
    public class MockCommands : ICommandRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command { Id = id, CommandText = "my command Text",
                HowTo = "my how to ", Platfform = "myPlatform" };
        }

        public IEnumerable<Command> GetCommands()
        {
            var CommandList =  new List<Command>() {this.GetCommandById(0), this.GetCommandById(1)};
            //for (int i = 0; i<10; i++)
            //{
            //    CommandList.Add(GetCommandById(i));
            //}

            return CommandList;
        }

        public Command NewCommand(Command command)
        {
            var mylist = this.GetCommands();
           
            return command;
        }
    }

}