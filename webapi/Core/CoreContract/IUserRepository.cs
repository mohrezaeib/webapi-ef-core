using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.CoreEntities.Models;

namespace webapi.Core.CoreContract
{
    interface IUserRepository
    {
        User GetUserById(int id);
        List <User> GetUsers();

        User AddUser(User User);
        User EditUser(User User);

        User DeleteUser(int id);


    }
}
