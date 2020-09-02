using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using webapi.Core.CoreContract;
using webapi.CoreApplicationServices;
using webapi.CoreEntities.DTO;
using webapi.CoreEntities.Models;
using webapi.InfrastructureEF;

namespace webapi.CoreApplicationServices
{
    public class UserService : IUserService
    {
         private readonly IMapper _Mapper;
         private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository userRepository, IMapper Mapper)
        {
            _Mapper = Mapper;
            _UserRepository = userRepository;
        }



        public UserReadDetailDTO GetUserDetailById(int id)
        {
      
            var user = _Mapper.Map<UserReadDetailDTO>(_UserRepository.GetUserDetailById(id));

            return user;
        }
    }


}