using System;
using System.Collections.Generic;
using webapi.CoreEntities.DTO;
using webapi.CoreEntities.Models;
namespace webapi.CoreApplicationServices
{
    public interface IUserService
    {

        UserReadDetailDTO GetUserDetailById(int id);

    }
}