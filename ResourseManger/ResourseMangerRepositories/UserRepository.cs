using ResourseMangerModels;
using ResourseMangerServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerRepositories
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(ResourseMangerContext.ResourseMangerContext context) : base(context)
        {

        }
    }
}
