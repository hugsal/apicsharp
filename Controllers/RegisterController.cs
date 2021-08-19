using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ok");
        }

        [HttpPost("add")]
        public IActionResult AddPerson(Register user)
        {
            Console.WriteLine(user);
            if (user.UserName == "") return BadRequest("User is empty");
            if (user.Password == "") return BadRequest("Password is empty");
            if (user.Password != user.ConfPassword) return BadRequest("password do not match");
            return CreatedAtAction(nameof(AddPerson), "User add succefully");
        }
    }
}
