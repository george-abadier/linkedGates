using ResourseMangerDTOs.UserDTOs;
using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerServices.Services.ServicesContracts
{
    public interface IUserServices:IServices<User,GetAllUsers,CreateUser,EditUser>
    {
    }
}
