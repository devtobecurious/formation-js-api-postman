using Api.We.Tests._001.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.We.Tests._001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(User user)
        {
            user.Token = Guid.NewGuid().ToString();

            return this.Ok(user);
        }
    }
}
