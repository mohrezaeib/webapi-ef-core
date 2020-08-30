using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Core.CoreContract;
using webapi.CoreEntities.Models;

namespace webapi.Infrastructure.EF.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User AddUser(User User)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User EditUser(User User)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
