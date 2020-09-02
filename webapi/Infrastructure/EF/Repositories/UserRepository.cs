using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using webapi.Core.CoreContract;
using webapi.CoreEntities.DTO;
using webapi.CoreEntities.Models;
using webapi.InfrastructureEF;

namespace webapi.Infrastructure.EF.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StoreContext _Context;

        public UserRepository(StoreContext ctx)
        {
            _Context = ctx; 
        }
        public User AddUser(UserReadDTO User)
        {
            //_Context.Users.Add();
            throw new NotImplementedException();

        }

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

        public User GetUserDetailById(int id)
        {
            //List<Car> cars = _Context.Cars.Where(c => c.OwnerId == id).ToList();
            
            User user = _Context.Users
                .Include(c => c.Cars)
                 .Where(u => u.Id == id)
                 .FirstOrDefault();
          //  user.Cars = cars;
            return user;
            

        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
