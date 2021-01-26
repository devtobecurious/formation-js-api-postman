using Api.We.Tests._001.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.We.Tests._001.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(token);

            List<Selfy> selfies = new List<Selfy>();

            selfies.Add(new Selfy());
            selfies.Add(new Selfy());

            return this.Ok(selfies);
        }
    }
}
