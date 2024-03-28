using AutoMapper;
using ResourseMangerDTOs.UserDTOs;
using ResourseMangerModels;
using ResourseMangerServices.Contracts;
using ResourseMangerServices.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Services
{
    public class UserServices:Services<User,GetAllUsers,CreateUser,EditUser>,IUserServices
    {
        public UserServices(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
        }
    }
}
