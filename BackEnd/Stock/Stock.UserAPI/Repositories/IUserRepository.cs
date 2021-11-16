using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.UserAPI.Entities;
using Stock.UserAPI.Models;

namespace Stock.UserAPI.Repositories
{
    interface IUserRepository
    {
        void Register(User user);
        User Validate(Login login);



    }
}
