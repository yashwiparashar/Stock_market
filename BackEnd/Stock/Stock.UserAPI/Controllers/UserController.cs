using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.UserAPI.Entities;
using Stock.UserAPI.Models;

using Stock.UserAPI.Repositories;

namespace Stock.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository repository = new UserRepository();
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                repository.Register(user);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Login login)
        {
            try
            {
                User user = repository.Validate(login);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }








    }
}
