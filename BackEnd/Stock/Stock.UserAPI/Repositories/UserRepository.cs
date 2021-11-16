using Stock.UserAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.UserAPI.Models;

namespace Stock.UserAPI.Repositories
{
    public class UserRepository: IUserRepository
    {

        private readonly UserDBContext db = new UserDBContext();

        public void Register(User user)
        {
            bool usernameAlreadyExists = db.Users.Any(x => x.UserId == user.UserId);
            if (usernameAlreadyExists != true)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }




        }
        public User Validate(Login login)
        {
            User user = db.Users.SingleOrDefault(u => u.Email == login.Email && u.Password == login.Password);
            return user;
        }


    }
}
